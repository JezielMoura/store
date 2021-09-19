<script>
    import NavItem from "./NavItem.svelte";
</script>
<nav>
    <h1>Mobnet</h1>
    <NavItem href="/" title="Home" icon="home-solid.svg"/>
    <NavItem title="Vendas" icon="shopping-cart-solid.svg">
        <a href="/orders/add">Nova</a>
        <a href="/orders/now">Relizadas</a>
    </NavItem>
    <NavItem title="Produtos" icon="box-open-solid.svg">
        <a href="/products/add">Novo</a>
        <a href="/products/edit">Editar</a>
        <a href="/products/delete">Excluir</a>
    </NavItem>
    <NavItem title="Relatórios" icon="chart-area-solid.svg">
        <a href="/reports/orders">Vendas</a>
    </NavItem>
    <NavItem title="Caixa" icon="coins-solid.svg">
        <a href="/boxs/open">Abrir/Fechar</a>
        <a href="/boxs/details">Ver</a>
    </NavItem>
    <NavItem title="Contas" icon="wallet-solid.svg">
        <a href="/accounts/receive">A Receber</a>
        <a href="/accounts/pay">A Pagar</a>
    </NavItem>
    <NavItem title="Sair" icon="times-circle-solid.svg" href="#">
    </NavItem>
</nav>

<style>
    nav { 
        width: 240px; height: 100%; top: 0; left: 0; background: rgb(2, 89, 129); position: fixed;}

        nav h1 { 
            display: block; color: #fff; text-align: center; padding: 20px; box-shadow: 0 2px 3px rgba(0,0,0,0.1);
            margin-bottom: 20px;}
</style>