let ordersService = {
    send: async (items) => {
        let response = await fetch(`/api/order`, {
            headers: {
                'Content-Type': 'application/json'
            },
            method: 'post',
            body: JSON.stringify(items),
            mode: 'cors'
        })
        let sucess = response.status == 200;
        
        return sucess;
    },
    get: async (id) => {
        let response =  await fetch(`/api/order/${id}`);

        if (response.status ==  200)
            return await response.json();

        return null;
    },
    delete: async (id) => {
        let response =  await fetch(`/api/order/delete/${id}`);

        if (response.status ==  200) 
            return true
            
        return false
    },
    today: async () => {
        let response =  await fetch(`/api/order/today`);
        let ordersToday = [];

        if (response.status ==  200)
            ordersToday = await response.json();

        return ordersToday;
    },
    getByRangeDate: async (init, end) => {
        let response =  await fetch(`/api/order/${init}/${end}`);
        let ordersByRangeDate = [];

        if (response.status ==  200)
            ordersByRangeDate = await response.json();

        return ordersByRangeDate;
    }
}

export default ordersService