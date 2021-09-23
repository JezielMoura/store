<script>    
    import currency from "../../helpers/currency.js";
    import date from "../../helpers/date.js";
    import OrderService from '../../services/orders-service.js';
    import InputDate from '../../components/inputDate.svelte';

    let orders = [];
    let totalValue = 0.00;
    let selectedOrder;
    let init;
    let end;

    const handleKeydown = (e) => {
        if (e.key == 'Escape') 
            selectedOrder = null;
    }

    const select = async (order) => {
        selectedOrder = await OrderService.get(order.id);
        console.log(selectedOrder)
    }

    const processHandler = async () => {
        orders = await OrderService.getByRangeDate(init, end);

        totalValue = 0.00;

        for (let i = 0; i < orders.length; i++) {
            totalValue = totalValue + orders[i].value;
        }
    }

</script>

<svelte:window on:keydown={handleKeydown} />

<p class="title">Vendas do Dia</p>

<InputDate bind:field={init} name="Data de Início" />
<InputDate bind:field={end} name="Data de Fim" />
<button on:click={processHandler}>Processar</button>

{#if orders.length > 0}
    <div class="order-list">
        <div class="order">
            <p class="w1">Data</p>
            <p class="w2">Valor</p>
        </div>
        {#each orders as order}
            <div class="order body" on:click={() => select(order)}>
                <p class="w1">{date(order.created)}</p>
                <p class="w2">{currency(order.value)}</p>
            </div>
        {/each}
    </div>
{/if}

<div class="value bg-info">
    <p>TOTAL VENDAS DO DIA</p>
    <p>{currency(totalValue)}</p>
</div>

{#if selectedOrder}
    <div class="order-details">
        <div class="products-list">
            <div class="product">
                <p class="w1">Nome</p>
                <p class="w2">Quantidade</p>
                <p class="w3">Desconto</p>
                <p class="w4">Preço</p>
            </div>
            {#each selectedOrder.items as item}
                <div class="product">
                    <p class="w1">{item.name}</p>
                    <p class="w2">{item.quantity}</p>
                    <p class="w3">{item.discount}%</p>
                    <p class="w4">{currency(item.price)}</p>
                </div>
            {/each}
        </div>
    </div>
{/if}


<style>
    .order-list { 
        padding: 15px 20px; width: 100%; background: #fff; box-shadow: 0px 0px 4px #eee; }

        .order { 
            width: 100%; border-bottom: 1px solid #eee; padding: 3px 5px; }

        .body:hover { 
            background: #eee; transition: ease-in-out 250ms; cursor: pointer;}

            .order p { 
                display: inline-block; font-size: 12px; font-weight: 500;}

                .order .w1 {
                    width: 85%;}

                .order .w2 { 
                    width: 14%;}

    .value { 
        width: 100%; height: 80px; background: #3975EA; border-radius: 5px; margin-top: 20px; display: flex; 
        justify-content: space-between; align-items: center; padding: 25px;}

        .value p { 
            color: #fff; font-size: 20px; font-weight: 600;}

    .order-details { 
        width: 90%; background: #fff; height: 460px; border-radius: 5px; padding: 15px 20px;
        position: absolute; top: 130px; left: 5%; box-shadow: 0 0 10px #777; }

        .product { 
            width: 100%; border-bottom: 1px solid #eee; padding: 3px 5px; }

            .product p { 
                display: inline-block; font-size: 12px; font-weight: 500;}

                .product .w1 {
                    width: 60%;}

                .product .w2 { 
                    width: 12%;}

                .product .w3, .product .w4 { 
                    width: 13%; }
</style>