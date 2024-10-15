//ex01.js var vs let
const y=100;

var x=0;
console.log("before:x=",x);
for (let x = 1; x <= 5; x++) {
    console.log('inside loop x=',x);
}
console.log("after:x=",x);
y=200;
