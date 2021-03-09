
// a & b are array [x, y, z] 
function FFF(a, b) {
    const func = (x, y) => x * y;
    return Math.abs(a.reduce(func) - b.reduce(func));
}

// Random password generator
function passwordGen() {
    var members = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    var reg = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[^\W_]{6,20}$/;
    var result = "";
    while (reg.test(result) != true) {
        result = "";
        var length = Math.random() * 20;
        length = length < 6 ? 6 : length;

        for (var i = 0; i < length; i++) {
            result += members.charAt(Math.random() * members.length);
        }
    }
    return result;
}


// min & max in the array
var min = function (list) {
    return Math.min(...list);
}

var max = function (list) {
    return Math.max(...list);
}

function feast(beast, dish) {
    return beast.charAt(0) === dish.charAt(0) && beast.charAt(beast.length - 1) === dish.charAt(dish.length - 1);
}

function greet(name, owner) {
    return name === owner ? 'Hello boss' : 'Hello guest';
}

function cockroachSpeed(s) {
    return Math.floor(s * 100000 / 3600);
}


function lovefunc(flower1, flower2) {
    return (flower1 + flower2) % 2 != 0;
}

function reverseWords(str) {
    return str.split(" ").reverse().join(" ");
}

function reverseString(str) {
    return str.split("").reverse().join("");
}

function hexHash(code) {
    if (code.length == 0) {
        return 0;
    }
    let str = "";
    for (let i = 0; i < code.length; i++) {
        str += code.charCodeAt(i).toString(16);
    }
    let reg = /[abcdef]/gi;
    return str.replace(reg, "").split("").reduce((x, y) => parseInt(x) + parseInt(y));
}


// Log 'number' for base 'base'
Math.logb = function (number, base) {
    return Math.log(number) / Math.log(base);
};


// Number of trailing zeros of N!
// From Codewars community:
// const zeros = n => n/5 < 1 ? 0 : Math.floor(n/5) + zeros(n/5);
function zeros(n) {
    var k = Math.floor(n / 5);
    var res = k;
    while (k >= 5) {
        k = Math.floor(k / 5);
        res += k;
    }
    return res;
}