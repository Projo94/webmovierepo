function saveMessage(firstName, lastName) {
    //alert(firstName + ' ' + lastName + ' has been saved successfully!');

    document.getElementById('divServerValidations').innerText = firstName + ' ' + lastName + ' has been saved successfully!';
}

function setFocusOnElement(element) {
    element.focus();
}

function getBrands() {

    //throw 'Something has gone wrong JS';

    var products = [{ "BrandTypeEID": 1, "Caption": "Puma" },
                  { "BrandTypeEID": 2, "Caption": "Nike" }
                 ];
    return products;
}


function getCategories() {

    //throw 'Something has gone wrong JS';

    var categories = [{ "CategoryID": 1, "Caption": "Shoes" }
    ];
    return categories;
}