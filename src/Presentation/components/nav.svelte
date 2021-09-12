<script>
import Navitem from "./navitem.svelte";
import NavItem from "./navitem.svelte";

</script>
<nav>
    <h1>Mobnet</h1>
    <NavItem href="/" title="Home" icon="home-solid.svg"/>
    <Navitem title="Vendas" icon="shopping-cart-solid.svg">
        <a href="/orders/add">Nova</a>
        <a href="/orders/now">Relizadas</a>
    </Navitem>
    <Navitem title="Produtos" icon="box-open-solid.svg">
        <a href="/products/add">Novo</a>
        <a href="/products/edit">Editar</a>
        <a href="/products/delete">Excluir</a>
    </Navitem>
    <Navitem title="Relatórios" icon="chart-area-solid.svg">
        <a href="/reports/orders">Vendas</a>
    </Navitem>
    <Navitem title="Caixa" icon="coins-solid.svg">
        <a href="/boxs/open">Abrir/Fechar</a>
        <a href="/boxs/details">Ver</a>
    </Navitem>
    <Navitem title="Contas" icon="wallet-solid.svg">
        <a href="/accounts/receive">A Receber</a>
        <a href="/accounts/pay">A Pagar</a>
    </Navitem>
    <Navitem title="Sair" icon="times-circle-solid.svg" href="#">
    </Navitem>
</nav>

<style>
    nav { 
        width: 260px; height: 100%; position: fixed; top: 0; left: 0; background: #1d3557;}

        nav h1 { 
            line-height: 70px; text-align: center; color: #ffffff; font-size: 26px; margin-bottom: 20px;
            background: rgba(255, 255, 255, 0.02); box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.1);}
</style>