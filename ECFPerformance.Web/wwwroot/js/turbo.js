//add turbo to cart
let addToCartBtn = document.getElementById("addToCartButton");
addToCartBtn.addEventListener('click', addToCart);

async function addToCart() {
    let turboId = document.getElementById("turboId").textContent;

    await post(`/ShoppingCart/AddTurboToCart/${turboId}`);
}