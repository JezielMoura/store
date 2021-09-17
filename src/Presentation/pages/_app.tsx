import '../styles/globals.css'
import type { AppProps } from 'next/app'
import React, { useEffect } from 'react'
import { Header } from '../components/header'
import { Navbar } from '../components/navbar'
import Head from "next/head";

function MyApp({ Component, pageProps }: AppProps) {
    return (
        <>
            <Head>
                <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;500;600&display=swap" rel="stylesheet" />
            </Head>
            <Header></Header>
            <Navbar></Navbar>
            <main>
                <Component {...pageProps} />
            </main>
        </>
    )
}
export default MyApp
