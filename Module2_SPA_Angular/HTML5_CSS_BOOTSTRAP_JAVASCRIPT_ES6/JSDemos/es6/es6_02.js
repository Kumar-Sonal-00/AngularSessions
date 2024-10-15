//ex02 - templated string

let s1='my name is Ramnath';
let s2="i line in Bangalore";
let s3="this is 'angular' training";
let s4='the training is on "angular"';

let s5=`This is a new feature in ES6
this is a multiline text
`;

console.log(s1);
console.log(s2);
console.log(s3);
console.log(s4);
console.log(s5);

//templated string can use substitution of variables
let name="Ramnath";
let email="raman9999@gmail.com";
let s6=`Email address of ${name} is ${email}`;
console.log(s6);

//u can use any expression also in substitution
let age=45;
let s7=`${name} is ${age<18?'a minor':'an adult'}`;
console.log(s7);

