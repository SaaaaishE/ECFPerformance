//add turbo to cart

async function addToCart(turboId) {
    let btn = document.getElementById("btn" + turboId);

    btn.className = "btn btn-success btn-md";

    setTimeout(function () {
        btn.className = "btn btn-primary btn-sm";
    }, 300)

    try {
        await post(`/ShoppingCart/AddTurboToCart/${turboId}`);
    }
    catch {
        let currentUrl = window.location.href;
        currentUrl = currentUrl.split('/');
        currentUrl[3] = "User";
        currentUrl[4] = "Login";

        let newUrl = currentUrl.join('/');

        window.location = newUrl;
    }
}