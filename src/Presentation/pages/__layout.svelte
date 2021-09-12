<script>
    import Header from "../components/header.svelte";
    import Nav from "../components/nav.svelte";
</script>

<svelte:head>
    <title>Mobnet Store</title>
</svelte:head>

<Header/>
<Nav/>
<main>
    <slot></slot>
</main>

<style>
    
</style>