import { Employee } from "./employee";

let emps:Employee[]=[];

emps.push(new Employee(101,'Ravi',1111,201));
emps.push(new Employee(102,'Rahul',2222,202));
emps.push(new Employee(103,'Rohit',3333,203));

emps.forEach((e)=>{
 e.display();
})
