function iqTest(str) {
    var strArr = str.split(' ');
    var even = 0;
    var odd = 0;

    strArr.forEach(function (curr) {
        if (curr % 2 === 0) {
            even++;
        } else {
            odd++;
        }
    });

    if (even === 1) {
        strArr.forEach(function (curr, idx) {
            if (curr % 2 === 0) {
                return idx + 1
            }
        });
    }

    if (odd === 1) {
        strArr.forEach(function (curr, idx) {
            if (curr % 2 !== 0) {
                return idx + 1;
            }
        });
    }
}