
import Item from "../models/item.js";
class Order {
    item = new Item();
    items = [];
    total = 0.00;
    add (item) {
        this.items.push(item)
    }

    applyDiscount () {
        this.item.price = this.item.price - this.item.getDiscount();
    }

    map (product) {
        this.item.code = product.code;
        this.item.name = product.name;
        this.item.price = product.price;
        this.item.discount = product.maxDiscount
        this.item.total = product.price;
    }
}

export default Order;