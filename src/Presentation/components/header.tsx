import { NextPage } from "next";
import styles from "../styles/Header.module.css";

export const Header : NextPage = () => {
    return (
        <header className={styles.header}>
            <div className={styles.menu}>
                <span></span>
                <span></span>
                <span></span>
            </div>
            <div className={styles.search}>
                <input type="text" placeholder="Pesquise aqui..." className={styles.input} />
            </div>
            <div className={styles.user}>
                <img src="/icons/user-circle-solid.svg" alt="User" />
            </div>
        </header>
    )
}
