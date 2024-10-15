import { IEmployee } from "./IEmployee";

export class Employee implements IEmployee{
    ecode: number;
    ename: string;
    salary: number;
    deptid: number;
    
    
    constructor(ecode:number,ename:string,salary:number,deptid:number){
        this.ecode=ecode;
        this.ename=ename;
        this.salary=salary;
        this.deptid=deptid;
    }

    display(): void {
        console.log(`${this.ecode}\t${this.ename}\t${this.salary}\t${this.deptid}`)
    }
    calculateBonus():number{
        let bonus:number;
        if(this.salary>5000){
            bonus=0.1*this.salary;
        }else{
            bonus=0.2*this.salary;
        }

        return bonus;
    }
}