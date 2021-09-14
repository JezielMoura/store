<header>
    <div class="box-menu">
        <span></span>
        <span></span>
        <span></span>
    </div>
    <div class="box-search">
        <input type="text" placeholder="Pesquise aqui...">
    </div>
    <div class="box-user">
        <img src="/icons/user-circle-solid.svg" alt="User">
    </div>
</header>

<style>
    header { 
        width: 100%; height: 70px; background: #fff; box-shadow: 2px 2px 4px #f0f0f0;
        padding-left: 290px; display: flex; justify-content: space-between; align-items: center;}

        header .box-menu { 
            width: 35px;  height: 26px; display: flex; flex-direction: column; justify-content: space-between; }

            header .box-menu span { 
                display: block; width: 100%;  height: 4px; background: #555; border-radius: 1px; }

        header .box-user {
            width: 40px; height: 40px; margin-right: 30px; border-radius: 100%; }

        header .box-search { 
            width: 50%;}
</style>