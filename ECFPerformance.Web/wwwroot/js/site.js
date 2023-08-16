function optionsFunc(methodArg, bodyArg) {
    let currentHeader = { 'content-type': 'application/json' };
    let currentBody = null;

    if (bodyArg)
        currentBody = JSON.stringify(bodyArg);

    return {
        method: methodArg,
        headers: currentHeader,
        body: currentBody
    }
}

async function wrapperRequest(url, method, body) {
    let response = await fetch("https://localhost:7052" + url, optionsFunc(method, body));
    if (response.status == 201)
        return response;

    let responseData = await response.json();

    if (response.ok == false) {
        throw new Error(`${responseData.code} ${responseData.message}`);
    }

    return responseData;
}

async function get(url) {
    return await wrapperRequest(url, 'get');
}
async function post(url, body) {
    return await wrapperRequest(url, 'post', body);
}

//-----------------------------------------------------------------------------------------


