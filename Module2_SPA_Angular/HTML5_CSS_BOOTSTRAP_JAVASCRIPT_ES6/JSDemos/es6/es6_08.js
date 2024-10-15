//ex08.js - inheritance
class Person{
    constructor(name,city){
        this.name=name;
        this.city=city;
    }
}

class Employee extends Person{
    constructor(name,city,salary,deptid){        
        super(name,city);       
        this.salary=salary;
        this.deptid=deptid;
    }
}

let e1=new Employee('Ravi','Mysore',50000,201);
console.log(e1);

