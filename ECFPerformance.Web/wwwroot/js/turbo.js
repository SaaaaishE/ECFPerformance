//add turbo to cart

async function addToCart(turboId) {
    await post(`/ShoppingCart/AddTurboToCart/${turboId}`);
}