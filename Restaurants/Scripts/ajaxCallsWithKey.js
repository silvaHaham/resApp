function ajaxCall(method, api, data, successCB, errorCB) {
    $.ajax({
        type: method,
        url: api,
        data: data,
        cache: false,
		headers: {
            'user-key': 'eaf4471686e4362ce0f1c8e983646159',
        },
        contentType: "application/json",
        dataType: "json",
        success: successCB,
        error: errorCB
    });
}