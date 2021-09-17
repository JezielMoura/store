import { NextPage } from "next";
import React from "react";
import NavItem from "../components/navItem";
import styles from "../styles/Navbar.module.css";

export const Navbar : NextPage = () => {
    return (
        <nav className={styles.nav}>
            <h1>Mobnet</h1>
            <NavItem href="/" icon="home-solid">Dashboard</NavItem>
            <NavItem href="/order" icon="shopping-cart-solid">Vendas</NavItem>
            <NavItem href="/box" icon="coins-solid">Caixa</NavItem>
            <NavItem href="/product" icon="box-open-solid">Produtos</NavItem>
            <NavItem href="/report" icon="chart-area-solid">Relatórios</NavItem>
            <NavItem href="/account" icon="wallet-solid">Contas</NavItem>
            <NavItem href="/exit" icon="times-circle-solid">Sair</NavItem>
        </nav>
    )
}
