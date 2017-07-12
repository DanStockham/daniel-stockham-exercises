function iqTest(str) {
    var strArr = str.split(' ');
    var even = 0;
    var odd = 0;
    var numIdx;

    if (strArr.length <= 1) {
        numIdx = 0;
        return numIdx;
    }

    strArr.forEach(function (curr) {
        if (parseInt(curr) % 2 === 0) {
            even++;
        } else {
            odd++;
        }
    });

    if (even === 1) {
        strArr.forEach(function (curr, idx) {
            if (curr % 2 === 0) {
                numIdx = idx + 1;
            }
        });
    } else if(odd === 1) {
        strArr.forEach(function (curr, idx) {
            if (curr % 2 !== 0) {
                numIdx = idx + 1;
            }
        });
    } else {
        numIdx = 0;
        return numIdx;
    }

    return numIdx;
}

function titleCase(str, minor) {
    var lowerStr = str.toLowerCase().split(' ');
    var minorArr

    if (minor) {
        minorArr = minor.toLowerCase().split(' ');
        minorArr.join(' ');
    }

    var titleCase = lowerStr.map(function (curr) {
        if (!minor || minorArr.indexOf(curr) === -1) {
            curr = curr[0].toUpperCase() + curr.substring(1);
            return curr
        } else {
            return curr;
        }
    })

    titleCase[0] = titleCase[0][0].toUpperCase() + titleCase[0].slice(1);

    return titleCase.join(' ');
}

function perfectSquare(num) {
    var sqrt = Math.sqrt(num);

    if (sqrt % Math.floor(Math.sqrt(num)) === 0) {
        sqrt++;
        return Math.pow(sqrt, 2);
    } else {
        return -1;
    }
}