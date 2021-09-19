<header>
    <div class="menu">
        <span></span>
        <span></span>
        <span></span>
    </div>
    <div class="search">
        <input type="text" placeholder="Pesquise aqui...">
    </div>
    <div class="user">
        <img src="/icons/user-circle-solid.svg" alt="User">
    </div>
</header>

<style>
    header { 
    width: 100%; height: 70px; padding: 15px 25px; background: #fff; box-shadow: 0px 0px 4px rgba(0, 0, 0, 0.1);
    display: flex; justify-content: space-between; align-items: center; padding-left: 260px;}

        header .menu { 
            height: 26px; width: 40px; display: flex; flex-direction: column; justify-content: space-between;}

            header .menu span { 
                height: 4px; width: 100%; background: rgba(0, 0, 0, 0.6); border-radius: 3px;}

        header .search { 
            height: 40px; width: 50%; display: flex; align-items: center;}

            header .search input { 
                padding: 8px 15px;}

        header .user { 
            height: 40px; width: 40px;}
</style>