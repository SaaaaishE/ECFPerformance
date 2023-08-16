let allUsersButton = document.getElementById("editTurboBtn")
allUsersButton.addEventListener('click', getUsers);

async function getUsers(event) {

    //fetch data
    const response = await get("/Admin/Home/AllUsers");

    const div = document.getElementById("usersTable");

    const table = document.createElement("table");

    //implement table head
    const thead = document.createElement("thead");
    const tr = document.createElement("tr");

    const thEmail = document.createElement("th");
    const thEmailLabel = document.createElement("label");
    thEmailLabel.textContent = "Email";
    thEmail.appendChild(thEmailLabel);

    const thFname = document.createElement("th");
    const thFnameLabel = document.createElement("label");
    thFnameLabel.textContent = "First Name";
    thFname.appendChild(thFnameLabel);

    const thLname = document.createElement("th");
    const thLnameLabel = document.createElement("label");
    thLnameLabel.textContent = "Last Name";
    thLname.appendChild(thLnameLabel);

    const thPhone = document.createElement("th");
    const thPhoneLabel = document.createElement("label");
    thPhoneLabel.textContent = "Phone Number";
    thPhone.appendChild(thPhoneLabel);

    tr.appendChild(thEmail);
    tr.appendChild(thFname);
    tr.appendChild(thLname);
    tr.appendChild(thPhone);

    thead.appendChild(tr);
    table.appendChild(thead);

    //implement table body
    const tbody = document.createElement("tbody");
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

    div.replaceWith(table);
}