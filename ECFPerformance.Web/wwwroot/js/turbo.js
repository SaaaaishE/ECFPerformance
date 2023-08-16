let addToCartBtn = document.getElementById("addToCartButton");
addToCartBtn.addEventListener('click', addToCart);

async function addToCart() {
    let turboId = document.getElementById("turboId").textContent;

    //let body = { 'id': turboId };

    await post(`/ShoppingCart/AddTurboToCart/${turboId}`);
}