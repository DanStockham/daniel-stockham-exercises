/// <reference path="../jquery-3.1.1.js" />
/// <reference path="../jquery.validate.js" />

$(document).ready(function () {
    $('#SameShipping').change(function () {
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

    $('#form0').validate({
        rules: {
            EmailAddress: {
                required: true,
                email: true,
            },
            Password: {
                required: true,
                minlength: 8
            },
            ConfirmPassword: {
                equalTo: '#Password',
                minlength: 8,
                strongpassword: true
            }
        },
        messages: {
            EmailAddress: {
                required: "Please enter a valid email address",
            },
            Password: {
                minlength: "Password must be at least 8 characters",
                required: "Please enter a password"
            }
        },
        errorClass: 'field-validation-error',
        //submitHandler: function (form) {
        //    form.submit();
        //}

    });

    $.validator.addMethod("strongpassword", function (value, index) {
        return value.match(/[A-Z]/) && value.match(/[a-z]/) && value.match(/\d/);  //check for one capital letter, one lower case letter, one num
    }, "Please enter a strong password (one capital, one lower case, and one number");  

    $("#mylogin").validate({
        rules: {
            EmailAddress: {
                required: true

            },
            Password: {
                required: true
            }
        },
        messages: {
            EmailAddress: "*",
            Password: "*"
        },
        errorClass: 'field-validation-error'
    });

    $('#checkout').validate({
        rules: {
            BillingAddress1: {
                required: true
            },
            BillingCity: {
                required: true,
                lettersonly: true
            },
            BillingState: {
                required: true,
                lettersonly: true
            },
            BillingPostalCode: {
                required: true,
                digits: true,
                minlength: 5
            },
            ShippingAddress1: {
                required: true
            },
            ShippingCity: {
                required: true,
                lettersonly: true
            },
            ShippingState: {
                required: true,
                letterssonly: true
            },
            ShippingPostalCode: {
                required: true,
                numbersonly: true,
                minLength: 5
            },
            NameOnCard: {
                required: true,
                lettersonly: true
            },
            CreditCardNumber: {
                required: true,
                numbersonly: true,
                minLength: 16
            },
            ExpirationDate: {
                required: true,
                date: true
            },
            ShippingType: {
                required: true
            }
        },
        messages: {
            BillingAddress1: "Please enter a valid billing address",
            BillingCity: "Please enter a valid billing city name",
            BillingState: "Please enter a valid state",
            BillingPostalCode: "Please enter a valid zipcode",
            ShippingAddress1: "Please enter a valid shipping address",
            ShippingCity: "Please enter a valid shipping city",
            ShippingState: "Please enter a valid shipping state",
            ShippingPostalCode: "Please enter a valid shipping zipcode",
            NameOnCard: "Please enter name how it is displayed on your card",
            CreditCardNumber: "Please enter valid credit card number",
            ExpirationDate: "Please enter a valid expiration date",
            ShippingType: "Please enter a method of shipping"


        },
        errorClass: 'field-validation-error',
        errorLabelContainer: "#errors ",
        wrapper: "li"
    });

    
    $('body').keydown(function () {
        var zipcode = $('#BillingPostalCode').val();
        var subtotal = parseInt($('.price').text().substr(1));

        if ($('#BillingPostalCode').valid()) {
            getTax(zipcode, subtotal);
        }
    });

    function getTax(zipcode, subtotal) {
        console.log(window.location.origin);
        $.ajax({
            url: '/api/getTax',
            type: 'get',
            data: "billingZipCode=" + zipcode + "&subtotal=" + subtotal,
            success: function (data) {
                console.log(data);
                $('#tax span').text('$' + data);
            },
            error: function (err) {
                console.log(err);
            }
        })
    }
    
});


