<script>
    import { onMount } from 'svelte';   
    import SearchProduct from '../../components/searchProduct.svelte'
    import isDigit from '../../helpers/isDigit.js'
    import currency from '../../helpers/currency.js'
    import OrdersService  from '../../services/orders-service.js'
    import ProductService  from '../../services/product.service.js'

    let codeRef, discountRef, quantityRef, productPrice;

    let order = {
        item: {
            code: '', productId: '', name: '', price: 0, discount: 0, quantity: 0, total: 0
        },
        items: [], total: 0,
        searchProducts: []
    }

    onMount(() => codeRef.focus());

    const handleKeydown = (e) => {
        if (e.key == 'Escape') 
            order.searchProducts = []
    }

    const search = async () => {
        if (isDigit(order.item.code)) {
            let product = await ProductService.find(order.item.code)
            
            order.item.productId = product.id;
            order.item.name = `${product.name} ${product.description}`;
            order.item.price = product.price;
            order.item.discount = product.maxDiscount;
            order.item.quantity = 1
            order.item.total = product.price;

            productPrice = product.price;
            discountRef.select();
            discountRef.focus();
        } else {
            order.searchProducts = await ProductService.search(order.item.code);
        }
    }

    const applyDiscount = () => {
        let discount = (productPrice * order.item.discount) / 100;
        order.item.price = productPrice - discount;
        order.item.total = order.item.price;
        quantityRef.select();
        quantityRef.focus();
    }

    const add = () => {
        order.item.total = order.item.price * order.item.quantity;
        order.items = [...order.items, order.item]
        order.item = {
            code: '', productId: '', name: '', price: 0, discount: 0, quantity: 0, total: 0
        };
        sumOrder();
        codeRef.focus();
    }
    
    const sumOrder = () => {
        order.total = 0;
        for(let i = 0; i < order.items.length; i++) 
        order.total += order.items[i].total;
    }
    
    const selectItem = (item) => {
        order.item = item;
        order.item.name = `${item.name} ${item.description}`;
        productPrice = item.price;
        order.searchProducts = [];
        discountRef.select();
        discountRef.focus();
    }
    
    const removeItem = (item) => {
        let conf = confirm(`Deseja remover o item ${item.name}?`);
        if (conf) {
            order.items = order.items.filter((value) => value.code != item.code);
            sumOrder();
        }
    }
    
    const cancel = () => {
        order = order = {
            item: {
                code: '', productId: '', name: '', price: 0, discount: 0, quantity: 0, total: 0
            },
            items: [], total: 0,
            searchProducts: []
        }
        codeRef.focus();
    }

    const finalize = async () => {
        let postOrder = {
            valor: order.total,
            items: order.items
        }
        let sucess = await OrdersService.send(postOrder);

        if (sucess)
            cancel();
        else
            alert("Erro ao processar venda");
    }
</script>

<svelte:window on:keydown={handleKeydown} />

<p class="title">Nova Venda</p>

<div class="container">
    <div class="controls">
        <label for="c">Código</label>
        <input bind:value={order.item.code} bind:this="{codeRef}" on:keypress={(e) => {if (e.key == 'Enter') search()}} id="c">
        <label for="name">Nome</label>
        <input bind:value={order.item.name} readonly id="name">
        <label for="price">Preço</label>
        <input value={currency(order.item.price)} readonly id="price">
        <label for="d">Desconto</label>
        <input bind:value={order.item.discount} bind:this="{discountRef}" on:keypress={(e) => {if (e.key == 'Enter') applyDiscount()}} id="d">
        <label for="q">Quantidade</label>
        <input type="number" bind:value={order.item.quantity} bind:this="{quantityRef}"  on:keypress={(e) => {if (e.key == 'Enter') add()}} id="q">
        <label for="total">Total</label>
        <input value={currency(order.item.total)} readonly id="total">
        <button on:click={cancel} class="bg-error">CANCELAR</button>
        <button on:click={finalize}>FINALIZAR</button>
    </div>
    <div class="order-items">
        <div class="order__item">
            <p class="w1">Código</p>
            <p class="w2">Nome</p>
            <p class="w3">Preço</p>
            <p class="w4">Desconto</p>
            <p class="w5">Unidade</p>
            <p class="w6">Total</p>
        </div>
        {#each order.items as it}
            <div class="order__item" on:click={() => removeItem(it)}>
                <p class="w1">{it.code}</p>
                <p class="w2">{it.name}</p>
                <p class="w3">{currency(it.price)}</p>
                <p class="w4">{it.discount}%</p>
                <p class="w5">{it.quantity}</p>
                <p class="w6">{currency(it.total)}</p>
            </div>
        {/each}
    </div>
    <div class="value bg-info">
        <p>VALOR TOTAL</p>
        <p>{currency(order.total)}</p>
    </div>
</div>

<SearchProduct bind:searchProducts={order.searchProducts} on:select={(i) => selectItem(i.detail)}></SearchProduct>

<style>
    .container { 
        width: 100%; display: flex; flex-wrap: wrap; }

        .controls { 
            width: 30%; padding: 10px 20px; background: #fff; border-radius: 5px; height: 460px;}

        .order-items { 
            width: 68%; margin-left: 2%; background: #fff; height: 460px; border-radius: 5px; padding: 15px 20px;}

            .order__item { 
                width: 100%; border-bottom: 1px solid #eee; padding: 3px 5px; cursor: pointer;}

            .order__item:hover { 
                background: #eee; transition: ease-in-out 250ms;}

                .order__item p { 
                    display: inline-block; font-size: 12px; font-weight: 500;}

                    .order__item .w1 {
                        width: 10%;}

                    .order__item .w2 { 
                        width: 40%;}

                    .order__item .w3, .order__item .w4, .order__item .w5, .order__item .w6 { 
                        width: 11%;}

        .value { 
            width: 100%; height: 80px; background: #3975EA; border-radius: 5px; margin-top: 20px; display: flex; 
            justify-content: space-between; align-items: center; padding: 25px;}

            .value p { color: #fff; font-size: 20px; font-weight: 600;}
</style>