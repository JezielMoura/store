<script>
    export let title;
    export let href;
    export let icon;
    let showBody = false;

    function toggleNav() {
        if (!href)
            showBody = !showBody;
    }
</script>

<div class="dropdown">
    <div class="head" on:click={toggleNav} >
        {#if href}
            <img src="/icons/{icon}" class="icon" alt="Home">
            <a href={href} title="{title}">{title}</a>
        {/if}
        {#if !href}
            <img src="/icons/{icon}" class="icon" alt="Home">
            <p>{title}</p>
            <img src="/icons/down.svg" class="down" alt="Home">
        {/if}
    </div>
    <div class="body {showBody ? "show-body" : ''}">
        <slot/>
    </div>
</div>

<style>
    .dropdown{ 
        width: 100%; cursor: pointer; }

        .dropdown .head{ 
            width: 100%; height: 45px; padding: 10px 20px; display: flex; justify-content: start; align-items: center;}

            .dropdown .head .icon { 
                width: 20px; margin-right: 15px;}
                
            .dropdown .head p, .dropdown .head a { 
                display: block; width: 180px; color: rgba(255, 255, 255, 0.9); }

            .dropdown .head .down { 
                width: 20px; height: 20px; padding: 4px;}

        .dropdown .body{ 
            width: 100%; border-bottom: 2px solid rgba(255, 255, 255, 0.1); padding: 0px 20px 15px 20px; display: none;}

            :global(.dropdown .body a) { 
                display: block; width: 100%; color: rgba(255, 255, 255, 0.9); margin-left: 36px; font-size: 14px; 
                line-height: 1.8; font-weight: 500;}

        .dropdown .show-body {
            display: block; }

</style>