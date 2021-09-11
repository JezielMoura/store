<script async>
    import { onMount } from 'svelte'

    onMount(async () => {
        let response = await fetch('/api');
        console.log(response)
    })
</script>

<h1>Welcome to SvelteKit</h1>
<p>Visit <a href="https://kit.svelte.dev">kit.svelte.dev</a> to read the documentation</p>

