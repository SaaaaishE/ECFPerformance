//add turbo to cart

async function addToCart(turboId) {
    let btn = document.getElementById("btn" + turboId);
    console.log(turboId);
    console.log(btn);
    btn.className = "btn btn-success";
    //await post(`/ShoppingCart/AddTurboToCart/${turboId}`);
}