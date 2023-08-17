let div = document.getElementById("usersTable");

async function getUsers() {

    //fetch data
    let response = await get("/Admin/Home/AllUsers");

    let table = document.createElement("table");
    table.className = "table";

    //implement table head
    let thead = document.createElement("thead");
    let tr = document.createElement("tr");

    let thEmail = document.createElement("th");
    let thEmailLabel = document.createElement("label");
    thEmailLabel.textContent = "Email";
    thEmail.appendChild(thEmailLabel);

    let thFname = document.createElement("th");
    let thFnameLabel = document.createElement("label");
    thFnameLabel.textContent = "First Name";
    thFname.appendChild(thFnameLabel);

    let thLname = document.createElement("th");
    let thLnameLabel = document.createElement("label");
    thLnameLabel.textContent = "Last Name";
    thLname.appendChild(thLnameLabel);

    let thPhone = document.createElement("th");
    let thPhoneLabel = document.createElement("label");
    thPhoneLabel.textContent = "Phone Number";
    thPhone.appendChild(thPhoneLabel);

    tr.appendChild(thEmail);
    tr.appendChild(thFname);
    tr.appendChild(thLname);
    tr.appendChild(thPhone);

    thead.appendChild(tr);
    table.appendChild(thead);

    //implement table body
    let tbody = document.createElement("tbody");
    for (let i = 0; i < response.length; i++) {
        let tr = document.createElement("tr");
        let tdEmail = document.createElement("td");
        let labelEmail = document.createElement("label");
        labelEmail.textContent = response[i].email;

        tdEmail.appendChild(labelEmail);
        tr.appendChild(tdEmail);

        tbody.appendChild(tr);
    }

    table.appendChild(tbody);

    div.replaceChildren(table);
}


async function getOrders() {
    //fetch data
    let response = await get("/Admin/Order/GetAllOrders");

    let table = document.createElement("table");
    table.className = "table";

    //implement table head
    let thead = document.createElement("thead");
    let tr = document.createElement("tr");

    let thDate = document.createElement("th");
    let thDateLabel = document.createElement("label");
    thDateLabel.textContent = "Date";
    thDate.appendChild(thDateLabel);

    let thEmail = document.createElement("th");
    let thEmailLabel = document.createElement("label");
    thEmailLabel.textContent = "Email";
    thEmail.appendChild(thEmailLabel);

    let thPhone = document.createElement("th");
    let thPhoneLabel = document.createElement("label");
    thPhoneLabel.textContent = "Phone Number";
    thPhone.appendChild(thPhoneLabel);

    let thDescription = document.createElement("th");
    let thDescriptionLabel = document.createElement("label");
    thDescriptionLabel.textContent = "Description";
    thDescription.appendChild(thDescriptionLabel);

    let thTotal = document.createElement("th");
    let thTotalLabel = document.createElement("label");
    thTotalLabel.textContent = "Total Price";
    thTotal.appendChild(thTotalLabel);

    tr.appendChild(thDate);
    tr.appendChild(thEmail);
    tr.appendChild(thPhone);
    tr.appendChild(thDescription);
    tr.appendChild(thTotal);

    thead.appendChild(tr);
    table.appendChild(thead);

    //implement table body
    let tbody = document.createElement("tbody");
    for (let i = 0; i < response.length; i++) {
        let tr = document.createElement("tr");

        let tdDate = document.createElement("td");
        let labelDate = document.createElement("label");
        let labelDateObj = new Date(response[i].createdOn);
        labelDate.textContent = labelDateObj.toLocaleTimeString("en-GB") + " - " + labelDateObj.toLocaleDateString("en-GB");
        tdDate.appendChild(labelDate);
        tr.appendChild(tdDate);

        let tdEmail = document.createElement("td");
        let labelEmail = document.createElement("label");
        labelEmail.textContent = response[i].userEmail;
        tdEmail.appendChild(labelEmail);
        tr.appendChild(tdEmail);

        let tdPhone = document.createElement("td");
        let labelPhone = document.createElement("label");
        labelPhone.textContent = response[i].userPhone;
        tdPhone.appendChild(labelPhone);
        tr.appendChild(tdPhone);

        let tdDescription = document.createElement("td");
        let labelDescription = document.createElement("label");
        labelDescription.textContent = response[i].description;
        tdDescription.appendChild(labelDescription);
        tr.appendChild(tdDescription);

        let tdTotal = document.createElement("td");
        let labelTotal = document.createElement("label");
        labelTotal.textContent = Number(response[i].totalPrice).toFixed(2);
        tdTotal.appendChild(labelTotal);
        tr.appendChild(tdTotal);

        tbody.appendChild(tr);
    }

    table.appendChild(tbody);

    div.replaceChildren(table);
}