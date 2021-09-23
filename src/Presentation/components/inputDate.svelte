<script>
    import { createEventDispatcher } from 'svelte';

    export let field;
    export let name;
    export let ref;
    export let showLabel = true

    let dispach = createEventDispatcher();

    const keypressHander = (e) => {
        if (e.key == 'Enter') {
            dispach('enter');
        }
    }

</script>

{#if showLabel}
    <label for={name}>{name}</label>
{/if}
<input bind:value={field} on:keypress={keypressHander} bind:this={ref} id={name} type="datetime-local" />