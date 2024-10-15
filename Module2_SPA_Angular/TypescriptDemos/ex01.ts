console.log('typescript demo');
let username:string='Ramnath';
console.log('username:',username);
//username=101; //invalid

function add(n1:number,n2:number):number{
    let sum:number =n1+n2;
    return sum;
}

let a=100,b=200;
console.log(`sum of ${a} and ${b} is ${add(a,b)}`);

let subtract=(a:number,b:number):number=>{
    return a-b;
};
console.log(`difference of ${a} and ${b} is ${subtract(b,a)}`);
