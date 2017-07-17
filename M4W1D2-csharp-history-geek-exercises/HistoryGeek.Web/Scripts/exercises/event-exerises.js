/// <reference path="../jquery-3.1.1.js" />

$(document).ready(function () {

    $('#SameShipping').change(function () {
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

    var shipLoc = $(".ship").attr("id");
    var col = parseInt(shipLoc.substr(4, 1));
    var row = parseInt(shipLoc.substr(13, 1));
    var colMax = $('table tr').length;
    var rowMax = $('table #row_0 td').length;
    var intendedMove;

    function movementLogic(evt) {
        
        switch (evt.keyCode) {
            case 37:

                if (col > 0) {

                    col--;
                    intendedMove = $("#row_" + row + "_column_" + col);

                    if (intendedMove.hasClass('iceberg')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You hit an iceberg and sunk your ship. Game Over.</h2>');
                    } else if (intendedMove.hasClass('pirate')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You got attacked by pirates and had to walk the plank. Game Over.</h2>');
                    } else if (intendedMove.hasClass('treasure')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gamewin">Congrats! you found treasure!</h2>');
                    }

                    $(".ship").removeClass("ship");
                    intendedMove.addClass("ship");
                } else {
                    $(".ship").removeClass("ship");
                    $('h2').after('<h2 class="gameover">Your ship got lost out at sea. Game Over.</h2>');
                    $('body').off("keydown");
                }

                break;
            case 38:

                if (row > 0) {

                    row--;
                    intendedMove = $("#row_" + row + "_column_" + col);

                    if (intendedMove.hasClass('iceberg')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You hit an iceberg and sunk your ship. Game Over.</h2>');
                    } else if (intendedMove.hasClass('pirate')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You got attacked by pirates and had to walk the plank. Game Over.</h2>');
                    } else if (intendedMove.hasClass('treasure')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gamewin">Congrats! you found treasure!</h2>');
                    }

                    $(".ship").removeClass("ship");
                    intendedMove.addClass("ship");
                } else {
                    $(".ship").removeClass("ship");
                    $('h2').after('<h2 class="gameover">Your ship got lost out at sea. Game Over.</h2>');
                    $('body').off("keydown");
                }

                break;
            case 39:

                if (col < colMax - 1) {

                    col++;
                    intendedMove = $("#row_" + row + "_column_" + col);

                    if (intendedMove.hasClass('iceberg')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You hit an iceberg and sunk your ship. Game Over.</h2>');
                    } else if (intendedMove.hasClass('pirate')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You got attacked by pirates and had to walk the plank. Game Over.</h2>');
                    } else if (intendedMove.hasClass('treasure')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gamewin">Congrats! you found treasure!</h2>');
                    }

                    $(".ship").removeClass("ship");
                    intendedMove.addClass("ship");
                } else {
                    $(".ship").removeClass("ship");
                    $('h2').after('<h2 class="gameover">Your ship got lost out at sea. Game Over.</h2>');
                    $('body').off("keydown");
                }

                break;
            case 40:

                if (row < rowMax - 1) {

                    row++;
                    intendedMove = $("#row_" + row + "_column_" + col);

                    if (intendedMove.hasClass('iceberg')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You hit an iceberg and sunk your ship. Game Over.</h2>');
                    } else if (intendedMove.hasClass('pirate')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gameover">You got attacked by pirates and had to walk the plank. Game Over.</h2>');
                    } else if (intendedMove.hasClass('treasure')) {
                        $(".ship").removeClass("ship");
                        $('body').off("keydown");
                        $('h2').after('<h2 class="gamewin">Congrats! you found treasure!</h2>');
                    }

                    $(".ship").removeClass("ship");
                    intendedMove.addClass("ship");

                } else {
                    $(".ship").removeClass("ship");
                    $('h2').after('<h2 class="gameover">Your ship got lost out at sea. Game Over.</h2>');
                    $('body').off("keydown");
                }

                break;
            default:
                break;
        }
    }

    $('#btnRestart').click(function () {

        row = 0;
        col = 0;
        $('h2').next('h2').remove();
        $('.ship').removeClass('ship');
        $('body').keydown(movementLogic)
        intendedMove = $("#row_" + row + "_column_" + col);
        intendedMove.addClass("ship");
    });

    $('body').keydown(movementLogic)
    
    
});




