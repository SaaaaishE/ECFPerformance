//add turbo to cart

async function addToCart(turboId) {
    let btn = document.getElementById("btn" + turboId);

    btn.className = "btn btn-success btn-md";

    setTimeout(function () {
        btn.className = "btn btn-primary btn-sm";
    }, 300)

    await post(`/ShoppingCart/AddTurboToCart/${turboId}`);
}