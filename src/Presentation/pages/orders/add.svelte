<script>
    import IsDigit from '../../helpers/isDigit.js'
    import currency from '../../helpers/currency.js'
    import Item from '../../models/item.js'
    import OrdersService  from '../../services/orders-service.js'

    let codeRef;
    let discountRef;
    let quantityRef;

    let item = new Item();
    let items = [];
    let searchProducts = []

    async function codeHandler (e) {
        if (e.charCode !== 13) return

        if (IsDigit(item.code)) {
            let product = await OrdersService.find(item.code)
            if (product != null){
                item.code = product.code;
                item.name = product.name;
                item.price = product.price;
                item.discount = product.maxDiscount
                item.total = product.price;
            }
        } 
        else {
            searchProducts = OrdersService.search(item.code)
        }

        discountRef.focus();
        discountRef.select();
    }

    function discountHandler (e) {
        if (e.charCode !== 13) return

        item.price = item.price - item.getDiscount();
        item.total = item.price;
        quantityRef.focus();
        quantityRef.select();
    }

    function quantityHandler (e) {
        if (e.charCode !== 13) return

        item.total = item.price * item.quantity
        items = [...items, item]
        item = new Item();
        codeRef.focus();
        console.log(items)
    }

</script>

<p class="title">Nova Venda</p>

<div class="container">
    <div class="controls">
        <p>Código</p>
        <input type="text" bind:value={item.code} bind:this="{codeRef}" on:keypress={codeHandler}>
        <p>Nome</p>
        <input type="text" readonly bind:value={item.name}>
        <p>Preço</p>
        <input type="text" readonly value="{currency(item.price)}">
        <p>Desconto</p>
        <input type="text" bind:value={item.discount} bind:this="{discountRef}" on:keypress={discountHandler}>
        <p>Quantidade</p>
        <input type="text" bind:value={item.quantity} bind:this="{quantityRef}" on:keypress={quantityHandler}>
        <p>Total</p>
        <input type="text" readonly value="{currency(item.total)}">
        <button class="bg-error">CANCELAR</button>
        <button>FINALIZAR</button>
    </div>
    <div class="items">
        {#each items as it}
            <p>{it.code} {it.name} {currency(it.price)} {it.discount} % {it.quantity} UN {currency(it.total)}</p>
        {/each}
    </div>
    <div class="value bg-info">

    </div>
</div>

<style>
    .container { 
        width: 100%; display: flex; flex-wrap: wrap; }

        .controls { 
            width: 30%; padding: 10px 20px; background: #fff; border-radius: 5px; height: 435px;}

            .controls p { 
                font-size: 12px; font-weight: 500;}

        .items { 
            width: 68%; margin-left: 2%; background: #fff; height: 435px; border-radius: 5px;}

        .value { 
            width: 100%; height: 80px; background: #3975EA; border-radius: 5px; margin-top: 20px;}
</style>