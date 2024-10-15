//ex03-arrow function
let n1=100,n2=200;

//using function keyword
function sum(a,b) {
    let result=a+b;
    console.log(`sum of ${a} and ${b} is ${result}`);
}


let subtract=function(a,b){
    let result=a-b;
    console.log(`Difference of ${a} and ${b} is ${result}`);
}

//arrow function
let multiply=(a,b)=>{
    let result=a*b;
    console.log(`product of ${a} and ${b} is ${result}`);
}

let divide=(a,b)=>{
  let result=a/b;
  return result;  
};

sum(n1,n2);
subtract(n1,n2);
multiply(n1,n2);
let res=divide(n2,n1);
console.log(`Division of ${n2} and ${n1} is ${res}`);