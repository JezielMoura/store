import Link from "next/link";
import React from "react";
import styles from "../styles/NavItem.module.css";

const navItem = (props: any) => {
    return (
        <div className={styles.nav__item}>
            <img src={`/icons/${props.icon}.svg`} alt="Home" />
            <Link href={props.href}> 
                <a>{props.children}</a>
            </Link>
            
        </div>
    )
}

export default navItem;