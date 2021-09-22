<script>
    import InputText from '../../components/inputText.svelte';
    import InputNumber from '../../components/inputNumber.svelte';
    import ProductService from '../../services/product.service.js';
    import SearchProduct from '../../components/searchProduct.svelte'

    let products = [];
    let term = "";

    let product = {
        code: 0, name: '', description: '', purchasePrice: 0.00, price: 0.00, maxDiscount: 0.00, stock: 0.00, stockMin: 0.00
    }

    const handleKeydown = (e) => {
        if (e.key == 'Escape') 
            products = []
    }

    const search = async () => {
        products = await ProductService.search(term)
    }

    const selectProduct = (p) => {
        product = p;
        products = [];
    }

    const cancel = () => {
        product = {
            code: 0, name: '', description: '', purchasePrice: 0.00, price: 0.00, maxDiscount: 0.00, stock: 0.00, stockMin: 0.00
        }
        nameRef.select();
        nameRef.focus();
    }

    const exclude = async () => {
        let sucess = await ProductService.delete(product.code)

        if (sucess) {
            cancel();
        } else {
            alert("Erro ao tentar excluir produto");
        }
    }

    const save = () => {
        ProductService.add(product);
        cancel();
    }
</script>

<svelte:window on:keydown={handleKeydown} />

<p class="title">Editar Produto</p>

<div class="products">
    <InputText bind:field={term} on:enter={search} showLabel={false} name="Procurar Produto"/>
    <button on:click={search}>BUSCAR</button>
</div>

<div class="controls">
    <InputText bind:field={product.code} name="Código"/>
    <InputText bind:field={product.name} name="Nome"/>
    <InputText bind:field={product.description} name="Descrição" />
    <InputNumber bind:field={product.price} name="Preço de Venda" />
    <InputNumber bind:field={product.purchasePrice} name="Preço de Compra" />
    <InputNumber bind:field={product.maxDiscount} name="Desconto Máximo" />
    <InputNumber bind:field={product.stock} name="Estoque"/>
    <InputNumber bind:field={product.stockMin} name="Estoque Mínimo" />
    <button on:click={exclude} class="bg-error">EXCLUIR</button>
    <button on:click={save}>ALTERAR</button>
</div>

<SearchProduct bind:searchProducts={products} on:select={(i) => selectProduct(i.detail)}></SearchProduct>

<style>
    .products { 
        width: 66%; float: left; padding-right: 40px;}
    .controls { 
        width: 30%; float: left;}
</style>