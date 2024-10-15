//ex07.js - defining class

//if u want to define fields also in class then we shud use ctor:

class Person{

    constructor(name,city='Banaglore'){
        this.name=name;
        this.city=city;
    }
    display(){
        console.log(`Name:${this.name}\tCity:${this.city}`);
        this.test();
    }
    test(){
        console.log('this is another method');
    }
}

let p1=new Person('Ramnath');
let p2=new Person('John','Dallas');

p1.display();

//console.log(p1);
//console.log(p2);

