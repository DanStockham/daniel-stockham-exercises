/// <reference path="../jquery-3.1.1.js" />
//Locate all <div> elements and add the 'president' class.
$('#btnPresident').click(presentialDivs());
function presentialDivs() {
    $('div').addClass('president');
}

$('#btnFoundingFather').click(georgeWashington());
//Locate George Washington and add the 'founding-father' class
function georgeWashington() {
    $('#george-washington').addClass('founding-father');
}

//Locate all Republican presidents and add the 'red' class.
$('#btnRepublicans').click(republicanPresidents());
function republicanPresidents() {
    $('.Republican').addClass('red');
}

//Locate all Democrat presidents and add the 'blue' class.
$('#btnDemocrats').click(democratPresidents())
function democratPresidents() {
    $('.Democratic').addClass('blue');
}

//Locate all Federalist presidents and add the 'gold' class.
$('#btnOther').click(otherPresidents);
function otherPresidents() {
    $('.Whigs').addClass('gold');
    $('.Nonpartisan').addClass('gold');
    $('.National').addClass('gold');
    $('.Democratic-Republican').addClass('gold');
}

//Locate all presidents named 'James' and add the 'james' class.
$('#btnJames').click(presidentsNamedJames);
function presidentsNamedJames() {
    $('[id^=james]').addClass('james');
    
}

//Locate each president serving at the beginning of each century and add the 'beginningOfCentury' class.
$('#btnBeginningOfCentury').click(turnOfTheCenturyPresidents)
function turnOfTheCenturyPresidents() {
    $('#presidents h2').next().addClass('beginningOfCentury');
    
}

//Locate each president serving at the end of the century and add the 'endOfCentury' class.
$('#btnEndOfCentury').click(endOfTheCenturyPresidents)
function endOfTheCenturyPresidents() {

    $('#presidents h2').prev().addClass('endOfCentury');

}

//Locate all presidents serving in the 1900s who appear on currency and add the 'appearOnCurrency' class.
$('#btnAppearOnCurrancy').click(currencyPresidents)
function currencyPresidents() {

    $('h2').eq(2).nextUntil('h2').filter('.currency').addClass('appearOnCurrency');
    
    
}