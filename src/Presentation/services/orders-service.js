import url from '../helpers/url';

let ordersService = {
    send: async (items) => {
        let response = await fetch(`${url}/order`, {
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
        let response =  await fetch(`${url}/order/${id}`);

        if (response.status ==  200)
            return await response.json();

        return null;
    },
    today: async () => {
        let response =  await fetch(`${url}/order/today`);
        let ordersToday = [];

        if (response.status ==  200)
            ordersToday = await response.json();

        return ordersToday;
    }
}

export default ordersService