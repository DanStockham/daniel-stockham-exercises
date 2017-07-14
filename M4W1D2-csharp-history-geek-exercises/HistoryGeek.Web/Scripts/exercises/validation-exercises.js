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

    $('input[name="ShippingType"]').change(function () {
        console.log();
        $('#shipping span').text($('input[name="ShippingType"]').data().cost);
    })
   
});


