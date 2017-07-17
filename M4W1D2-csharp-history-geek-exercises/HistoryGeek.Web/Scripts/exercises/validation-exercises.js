/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {
    $('#contact').validate({
        debug: true,
        rules: {
            billingAddress1: {
                required: true
            },
            billingAddress2: {
                required: true
            },
            billingCity: {
                required: true
            },
            billingState: {
                required: true
            },
            billingPostalCode: {
                required: true,
                minLength: 5,
                numbersonly: true
            },
            shippingAddress1: {
                required: true
            },
            shippingCity: {
                required: true
            },
            shippingState: {
                required: true
            },
            shippingPostalCode: {
                required: true
            },
            nameOnCard: {
                required: true,
                lettersonly: true
            },
            creditCardNumber: {
                required: true,
                numbersonly: true,
                minLength: 16
            },
            expirationDate: {
                required: true,
                date: true
            },
            shippingInfo: {
                required: true
            }
        },
        messages: {
            billingPostalCode: {
                minLength: "Please enter a valid zipcode",
                numbersonly: "Please enter a valid zipcode"
            },
            creditCardNumber: {
                numbersonly: "Please enter a valid credit card number",
                minLength: "Please enter a valid credit card number"
            },
            expirationDate: {
                date: "Please enter a valid date"
            }
        
        },
        errorClass: "error"

    })
   
});


