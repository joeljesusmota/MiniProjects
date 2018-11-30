class product { //37:49
    constructor(name, price, year) { 
        this.name = name;
        this.price = price;
        this.year = year;
    }
}

class UI{
    addProduct(product) {
        const productList = document.getElementById('products-list');
        const element = document.createElement('div');
        element.innerHTML = `
        <div class="card text-center mb-4">
            <div class="card-body">
                <strong>Product</strong>: ${product.name} -
                <strong>Price</strong>: ${product.price} - 
                <strong>Year</strong>: ${product.year}
            </div>
        </div>
    `;
        productList.appendChild(element);
    }

    deleteProduct() {

    }

    showMessage() {

    }
}

// DOM Events

document.getElementById('product-form')
    .addEventListener('submit', function(e) {
        const name = document.getElementById('name').value;
        const price = document.getElementById('price').value;
        const year = document.getElementById('year').value;
        
        console.log(name,price,year);

        const product = new product(name, price, year);
        
        const ui = new UI();
        ui.addProduct(product);
        e.preventDefault();
    });