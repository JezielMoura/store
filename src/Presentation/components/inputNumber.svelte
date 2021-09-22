<script>
    import { createEventDispatcher } from 'svelte';

    export let field;
    export let name;
    export let ref;

    let dispach = createEventDispatcher();

    const keypressHander = (e) => {
        if (e.key == 'Enter') {
            dispach('enter');
        }
    }

</script>

<label for={name}>{name}</label>
<input bind:value={field} on:keypress={keypressHander} bind:this={ref} id={name} type="number" />