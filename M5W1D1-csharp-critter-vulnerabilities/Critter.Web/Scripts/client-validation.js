$(document).ready(function () {
    $("#form0").validate({
        rules: {
            Username: {
                required: true

            },
            Password: {
                required: true,
                minlength: 8,
                hasUpper: true,
                hasLower: true,
                hasNum: true,
                hasSpecial: true
            },
            ConfirmPassword: {
                equalTo: Password
                
            }
        },
        messages: {
            Username: "Please enter an username",
            Password: {
                minlength: "Password must be atleast 8 characters",
                
            }

        },
        errorClass: 'field-validation-error'
    });

    $.validator.addMethod("hasUpper", function (value, index) {
        return value.match(/[A-Z]/);   //check for one capital letter, one lower case letter, one num
    }, "The password is missing an uppercase letter");

    $.validator.addMethod("hasLower", function (value, index) {
        return value.match(/[a-z]/);
    }, "The password is missing a lowercase letter");

    $.validator.addMethod("hasNum", function (value, index) {
        return value.match(/\d/);
    }, "The password is missing a numeric character");

    $.validator.addMethod("hasSpecial", function (value, index) {
        return value.match(/[!@#$%]/);
    }, "The password is missing a special character (!,@,#,$,%)");

});