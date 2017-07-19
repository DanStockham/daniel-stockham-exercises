/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {
    $('#SameShipping').change(function() {
        $('#ShippingAddress1').val($('#BillingAddress1').val());
        $('#ShippingAddress2').val($('#BillingAddress2').val());
        $('#ShippingCity').val($('#BillingCity').val());
        $('#ShippingState').val($('#BillingState').val());
        $('#ShippingPostalCode').val($('#BillingPostalCode').val());

    });

    $('input[name="ShippingType"]').change(function (evt) {
        
        $('#shipping span').text(evt.target.dataset.cost);
        $('#grandtotal span').text(
            "$" + (parseFloat(evt.target.dataset.cost.substr(1)) + parseFloat($('.price').text().substr(1)))    
        );
    })

    var validator = $('#checkout').validate({
        debug: true,
        rules: {
            BillingAddress1: {
                required: true
            },
            BillingCity: {
                required: true,

            }

        },
        messages: {
            billingAddress1: "The address entered is not valid",
            billingCity: "Please enter a valid city name"
        },
        errorClass: 'field-validation-error',
        errorLabelContainer: "#errors ",
        wrapper: "li"
    });

});


