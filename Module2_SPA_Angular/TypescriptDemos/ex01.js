console.log('typescript demo');
var username = 'Ramnath';
console.log('username:', username);
//username=101; //invalid
function add(n1, n2) {
    var sum = n1 + n2;
    return sum;
}
var a = 100, b = 200;
console.log("sum of ".concat(a, " and ").concat(b, " is ").concat(add(a, b)));
var subtract = function (a, b) {
    return a - b;
};
console.log("difference of ".concat(a, " and ").concat(b, " is ").concat(subtract(b, a)));
