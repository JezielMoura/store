class Item {
    code = "";
    name = "";
    price = 0.00;
    quantity = 1;
    discount = 0;
    total = 0.00;

    getDiscount() {
        let discountValue = (this.price * this.discount) / 100;
        return discountValue
    }
}

export default Item