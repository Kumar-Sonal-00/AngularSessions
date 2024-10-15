//ex06.js - destructuring array and objects

//1. destructuring array
let numbers=[10,20,30];

//let x1=numbers[0];
//let y1=numbers[1];
//let z1=numbers[2];

let [x1,y1,z1]=numbers; //destructuring the array
console.log('x1=',x1,'y1=',y1,'z1=',z1);

let [a,b]=numbers;
console.log('a=',a,'b=',b);

//destructuring can be used with objects also
let obj1={
    name:'Ramnath',
    email:'raman9999@gmail.com',
    city:'Bangalore'
};

//let name=obj1.name;
//let email=obj1.email;
//let city=obj1.city;

let {name,email,city}=obj1; //names must match with object properties

console.log(name,email,city);