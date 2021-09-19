<script>
    import currency from '../helpers/currency.js'
    import { createEventDispatcher } from 'svelte';

	const dispatch = createEventDispatcher();

    export let searchProducts = [];

    const select = (product) => {
        let item = {
            productId: product.id,
            code: product.code,
            name: product.name,
            price: product.price,
            discount: product.maxDiscount,
            quantity: 1,
            total: product.price
        }
        dispatch('select', item)
    }
</script>

{#if searchProducts.length > 0}
    <div class="products-list">
        <div class="product">
            <p class="w1">Código</p>
            <p class="w2">Nome</p>
            <p class="w3">Preço</p>
            <p class="w4">Desc Máximo</p>
            <p class="w5">Estoque</p>
            <p class="w5">Estoque</p>
        </div>
        {#each searchProducts as product}
            <div class="product body" on:click={() => select(product)}>
                <p class="w1">{product.code}</p>
                <p class="w2">{product.name} {product.description}</p>
                <p class="w3">{currency(product.price)}</p>
                <p class="w4">{product.maxDiscount}%</p>
                <p class="w5">{product.stock}</p>
                <p class="w6">{product.stockMin}</p>
            </div>
        {/each}
    </div>
{/if}


<style>
    .products-list { 
        width: 90%; background: #fff; height: 460px; border-radius: 5px; padding: 15px 20px;
    position: absolute; top: 130px; left: 5%; box-shadow: 0 0 10px #777; }

        .product { 
            width: 100%; border-bottom: 1px solid #eee; padding: 3px 5px; }

        .body:hover { 
            background: #eee; transition: ease-in-out 250ms; cursor: pointer;}

            .product p { 
                display: inline-block; font-size: 12px; font-weight: 500;}

                .product .w1 {
                    width: 10%;}

                .product .w2 { 
                    width: 40%;}

                .product .w3, .product .w4, .product .w5, .product .w6 { 
                    width: 12%; }
</style>