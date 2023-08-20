async function addToCart(productId, subCategory) {
    let btn = document.getElementById("btn" + subCategory + productId);
    btn.className = "btn btn-success btn-md";

    setTimeout(function () {
        btn.className = "btn btn-primary btn-sm";
    }, 300)

    try {
          await post(`/ShoppingCart/AddProduct/${productId}/${subCategory}`);
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