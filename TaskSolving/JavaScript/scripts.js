
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


// Even or Odd - Which is Greater?
// from Codewars:
// var odd = str.split('').filter(o => o % 2 != 0).reduce((a, b) => (+a) + (+b));
// var even = str.split('').filter(e => e % 2 == 0).reduce((a, b) => (+a) + (+b))
function evenOrOdd(str) {
    var array = str.split("");
    var odd = 0, even = 0;
    for (var item of array) {
        if (parseInt(item) % 2 == 0) {
            even += parseInt(item);
        }
        else {
            odd += parseInt(item);
        }
    }
    return even > odd ? "Even is greater than Odd" :
        even < odd ? 'Odd is greater than Even' : 'Even and Odd are the same';
}

function heron(a, b, c) {
    var s = (a + b + c) / 2;
    return Math.sqrt(s * (s - a) * (s - b) * (s - c));
}

// Sum of Cubes
function sumCubes(n) {
    var sum = 0;
    for (let i = 1; i <= n; i++) {
        sum += Math.pow(i, 3);
    }
    return sum;
}


var trueIfValueEqualsIndex = function (v, i) { return v === i; }
var findInArray = function (array, iterator) {
    for (let index = 0; index < array.length; index++) {
        if (iterator(array[index], index) == true) {
            return index;
        }
    }
    return -1;
};

// Cumulative Triangle
// 1
// 2 3
// 4 5 6
// 7 8 9 10
function cumulativeTriangle(n) {
    return (n ** 3) / 2 + n / 2;
}


// Multiples of 3 or 5
function solution(number) {
    var sum = 0;
    for (let i = 0; i < number; i++) {
        sum += (i % 3 == 0 || i % 5 == 0) ? i : 0;
    }
    return sum;
}

//Write Number in Expanded Form
function expandedForm(num) {
    var str = [];
    var i = 0;
    while (num.toString().length > 1) {
        var rate = num.toString().length - 1;
        str.push(Math.floor(num / (10 ** rate)) * (10 ** rate));
        num = num - str[i++];
    }
    str.push(num);
    str = str.filter(p => p != 0);
    return str.join(" + ");
}


// Сколько переносов разряда при сложении в столбик
function numberOfCarries(a, b) {
    var arr1 = a.toString().split("").reverse().map(x => parseInt(x));
    var arr2 = b.toString().split("").reverse().map(x => parseInt(x));
    var maxLength = arr1.length >= arr2.length ? arr1.length : arr2.length;
    var result = 0;
    var carry = 0;

    for (let i = 0; i < maxLength; i++) {
        var unit = (arr1[i] == undefined ? 0 : arr1[i]) + (arr2[i] == undefined ? 0 : arr2[i]) + carry;
        if (unit > 9) {
            result++;
            carry = 1;
            console.log(`unit: ${unit} | result: ${result} | carry: ${carry}`);
        }
        else {
            carry = 0;
            console.log(`unit: ${unit} | result: ${result} | carry: ${carry}`);
        }
    }
    return result;
}


// Дешифровка по заданному алгоритму 
// console.log(encryptThis("ABCD"));

var encryptThis = function (text) {
    var sepText = text.split(" ");
    var res = [];

    for (const w of sepText) {
        var length = w.length;
        res.push(w.charCodeAt(0) + (length < 3 ? "" : w.charAt(length - 1)) + (length - 1 < 2 ? "" : w.substring(2, length - 1)) + w.charAt(1));
    }
    return res.join(" ");
}


// IP Validation

function isValidIP(str) {
    var patern = /[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}$/gi;
    if (!patern.test(str)) {
        return false;
    }
    var array = str.Split(".");
    for (const item of array) {
        var temp = parseInt(item);
        if ((item.length > 1 && item.charAt(0) === "0") || isNaN(temp) || item > 255 || item < 0) {
            return false;
        }
    }
    return true;
}
// return /^(([1-9]?\d|1\d\d|2[0-4]\d|25[0-5])(\.(?!$)|$)){4}$/.test(str);
// const net = require('net');
// const isValidIP = (s) => net.isIP(s);


///////////////////////////
// "Format words into a sentence" - string array filter 
function formatWords(words) {
    var words = words.filter(p => p !== '' && p !== ' ');
    if (worsd.length == 0) {
        return false;
    }
    var res = words.slice(0, words.length - 1).join(", ");
    return words.length > 1 ? res + " and " + words[words.length - 1] : words[0];
}

// from community 
function formatWords(words) {
    if (!words) return "";
    return words.filter(function (a) { return a !== '' }).join(', ').replace(/(, )+(\S+)$/, ' and $2');
}
let formatWords = (a) => !a ? '' : a.filter(w => w).join(', ').replace(/, ([^ ]*)$/, " and $1")
///////////////////////////


function pigIt(str) {
    var words = str.split(" ");
    var list = [];
    for (const word of words) {
        if (word.match(/[a-z]/i)) {
            list.push(word.slice(1, word.length) + word.charAt(0) + "ay");
        }
        else {
            list.push(word);
        }
    }
    return list.join(" ");
}

///////////////////////////
// n-th Fibonachi element 
function Fibonachi(n) {
    var psi = (1 - Math.sqrt(5)) / 2;
    var fi = (1 + Math.sqrt(5)) / 2;
    var fib = (fi ** (n - 1) - psi ** (n - 1)) / Math.sqrt(5);
    return Math.floor(fib);
}
///////////////////////////

// Sequence: 0 50 150 300 500 750 1050
function getScore(n) {
    return 50 * n * (n + 1) / 2;
}
///////////////////////////




// Calculate Hypotenuse of Right-angled Triangle
// It's a useful using of REGEX
function calculateHypotenuse(a, b) {
    if (!/^[0-9]+/gi.test(a.toString()) || !/^[0-9]+/gi.test(b.toString())) {
        throw "error";
    }
    return Math.sqrt(a ** 2 + b ** 2).toFixed(3);
}
///////////////////////////


// Calculate scores
function scoreThrows(radii) {
    var scores = 0;
    for (const r of radii) {
        if (r >= 5 && r <= 10) {
            scores += 5;
        }
        else if (r < 5) {
            scores += 10;
        }
    }
    return radii.filter(p => p < 5).length === radii.length ? scores + 100 : scores;
}
///////////////////////////


// Check for phonenumber
function validPhoneNumber(phoneNumber) {
    var reg = /^(\(\d{3}\)\s)(\d{3}-\d{4})$/;
    return reg.test(phoneNumber);
}
///////////////////////////