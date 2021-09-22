<script>
    import InputText from '../../components/inputText.svelte';
    import InputNumber from '../../components/inputNumber.svelte';
    import ProductService from '../../services/product.service.js';

    let codeRef, nameRef, descriptionRef, purchasePriceRef, priceRef, maxDiscountRef, stockRef, stockMinRef;

    let product = {
        code: 0, name: '', description: '', purchasePrice: 0.00, price: 0.00, maxDiscount: 0.00, stock: 0.00, stockMin: 0.00
    }

    const codeHander = () => {
        nameRef.select()
        nameRef.focus()
    }

    const nameHander = () => {
        descriptionRef.select()
        descriptionRef.focus()
    }

    const descriptionHander = () => {
        priceRef.select()
        priceRef.focus()
    }

    const priceHander = () => {
        maxDiscountRef.select()
        maxDiscountRef.focus()
    }

    const maxDiscountHander = () => {
        stockRef.select()
        stockRef.focus()
    }

    const stockHander = () => {
        stockMinRef.select()
        stockMinRef.focus()
    }

    const stockMinHander = () => {
        nameRef.select()
        nameRef.focus()
    }

    const cancel = () => {
        product = {
            code: 0, name: '', description: '', purchasePrice: 0.00, price: 0.00, maxDiscount: 0.00, stock: 0.00, stockMin: 0.00
        }
        nameRef.select();
        nameRef.focus();
    }

    const save = () => {
        ProductService.add(product);
        cancel();
    }
</script>

<p class="title">Novo Produto</p>

<div class="container">
    <InputText bind:field={product.code} bind:ref={codeRef} on:enter={codeHander} name="Código"/>
    <InputText bind:field={product.name} bind:ref={nameRef} on:enter={nameHander} name="Nome"/>
    <InputText bind:field={product.description} bind:ref={descriptionRef} on:enter={descriptionHander} name="Descrição" />
    <InputNumber bind:field={product.price} bind:ref={priceRef} on:enter={priceHander} name="Preço de Venda" />
    <InputNumber bind:field={product.purchasePrice} bind:ref={purchasePriceRef} on:enter={priceHander} name="Preço de Compra" />
    <InputNumber bind:field={product.maxDiscount} bind:ref={maxDiscountRef} on:enter={maxDiscountHander} name="Desconto Máximo" />
    <InputNumber bind:field={product.stock} bind:ref={stockRef} on:enter={stockHander} name="Estoque"/>
    <InputNumber bind:field={product.stockMin} bind:ref={stockMinRef} on:enter={stockMinHander} name="Estoque Mínimo" />
    <button on:click={cancel} class="bg-error">CANCELAR</button>
    <button on:click={save}>SALVAR</button>
</div>

<style>

</style>