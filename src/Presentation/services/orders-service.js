let ordersService = {
    find: async (code) => {
        let response = await fetch(`//localhost:5000/api/product/${code}`)
        let item = await response.json();
        
        item.total = item.price;
        item.quantity  = 1
        
        return item
    },
    search:  (description) => {
        alert("Search")
    }
}

export default ordersService