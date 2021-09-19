import urlBase from "../helpers/url";

let ProductService = {
    find: async (code) => {
        let response = await fetch(`${urlBase}/product/${code}`)
        return await response.json();
    },
    search: async (description) => {
        let response = await fetch(`${urlBase}/product/search/${description}`)
        if (response.status == 200) 
            return await response.json();

        return [];
    }
}

export default ProductService