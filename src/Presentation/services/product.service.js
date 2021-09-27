let ProductService = {
    all: async () => {
        let response = await fetch(`/api/product`)
        return await response.json();
    },
    find: async (code) => {
        let response = await fetch(`/api/product/${code}`)
        return await response.json();
    },
    search: async (description) => {
        let response = await fetch(`/api/product/search/${description}`)
        if (response.status == 200) 
            return await response.json();

        alert("Nenhum produto encontrado");
        
        return [];
    },
    add: async (product) => {
        let response = await fetch(`/api/product`, {
            headers: {
                'Content-Type': 'application/json'
            },
            mode: 'cors',
            method: 'post',
            body: JSON.stringify(product)
        });

        if (response.status == 200) {
            return true
        }
    },
    edit: async (product) => {
        let response = await fetch(`/api/product`, {
            headers: {
                'Content-Type': 'application/json'
            },
            mode: 'cors',
            method: 'put',
            body: JSON.stringify(product)
        });

        if (response.status == 200) {
            return true
        }
    },
    delete: async (id) => {
        let response = await fetch(`/api/product/delete/${id}`);

        if (response.status == 200)
            return true
        
        return false;
    }
}

export default ProductService