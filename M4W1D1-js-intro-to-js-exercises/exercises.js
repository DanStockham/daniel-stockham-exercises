function sumDouble(num1, num2) {
    if (num1 === num2) {
        return (num1 + num2) * 2;
    }

    return num1 + num2;
}

function hasTeen(a, b, c) {
    for (var i = 0; i < arguments.length; i++) {
        if (arguments[i] >= 13 && arguments[i] <= 19) {
            return true;
        }
    }
    return false;
}

function lastDigit(a, b) {
    var lastDigitArray = [a, b];
    lastDigitArray = lastDigitArray.map(function (curr) {
        return curr.toString();
    });

    if (lastDigitArray[0].substr(-1) === lastDigitArray[1].substr(-1)) {
        return true;
    } else {
        return false;
    }
}

function seeColor(str) {
    if (str.indexOf('blue') === 0) {
        return 'blue';
    } else if (str.indexOf('red') === 0) {
        return 'red';
    } else {
        return '';
    }

}

function middleThree(str) {
    var outlier = (str.length - 3) / 2;

    return str.substr(outlier, 3);
}

function frontAgain(str) {
    if (str.substr(0, 2) === str.substr(-2)) {
        return true;
    }

    return false;
}

function alarmClock(dayIdx, vacay) {
    var day = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];

    if ((dayIdx === 0 || dayIdx === 9) && vacay) {
        return 'off'
    } else if (dayIdx === 0 || dayIdx === 9) {
        return '10:00'
    } else if (vacay) {
        return '10:00';
    } else {
        return '7:00';
    }
}

function makeMiddle(arr) {
    var middle = (arr.length / 2) - 1;

    if (arr.length % 2 === 0 && arr.length >= 2) {
        return [arr[middle], arr[middle + 1]];
    } else {
        return [];
    }
}

function oddOnly(arr) {
    return arr.filter(function (curr) {
        return curr % 2 !== 0;
    });
}

function weave(arr1, arr2) {
    var weaveArr = [];

    arr1.forEach(function (curr) {
        weaveArr.push(curr);
    })
    arr2.forEach(function (curr) {
        weaveArr.push(curr);
    });

    return weaveArr.sort();
}

function cigarParty(cigars, weekend) {
    if (cigars >= 40 && cigars <= 60) {
        return true
    } else if (cigars >= 40 && weekend) {
        return true;
    } else {
        return false;
    }
}

function stringSplosion(str) {
    var newStr = '';
    for (var i = 0; i <= str.length; i++) {
        newStr += str.substring(0, i);
    }

    return newStr;
}

function fizzBuzz(num) {
    if (num % 3 == 0 && num % 5 == 0) {
        return "FizzBuzz";
    } else if (num % 3 == 0) {
        return "Fizz";
    } else if (num % 5 == 0) {
        return "Buzz";
    } else {
        return num;
    }
}

function countValues(arr) {
    var countObj = {};

    arr.forEach(function (curr, idx, arr) {
        var count = 0;
        var index = curr.toString();
        countObj[index];
        for (var i = 0; i < arr.length; i++) {
            if (curr === arr[i]) {
                count++;
            }
        }
        countObj[index] = count;
    });
    return countObj;
}

function reverseArray(arr) {
    return arr.reverse();
}

