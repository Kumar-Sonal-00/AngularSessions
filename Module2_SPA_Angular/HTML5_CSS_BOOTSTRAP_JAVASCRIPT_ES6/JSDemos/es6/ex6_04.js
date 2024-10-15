//ex04 - spread operators
let num1=[10,20,30,40];
//to create another array have some more numbers
//plus numbers from the array, we use spread operator

let anotherNums=[100,200,...num1];
console.log(num1);
console.log(anotherNums);

anotherNums.push(999);
console.log(num1);
console.log(anotherNums);// both will have different array data

//spread can also be used with objects
let p1={name:'Ramnath',email:'raman9999@gmail.com'};
//to cretae clone of this object with the same properties
let p2={city:'Bangalore',...p1,country:'India'};
console.log(p1);
console.log(p2);

