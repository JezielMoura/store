<script context="module">
	export const ssr = false;
</script>

<script>
    import Header from "../components/header.svelte";
    import Nav from "../components/nav.svelte";
    import "../app.postcss";
</script>

<svelte:head>
    <title>Mobnet Store</title>
</svelte:head>

<Header/>
<Nav/>

<main>
    <slot></slot>
</main>