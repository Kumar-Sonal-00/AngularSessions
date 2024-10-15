//es6_10.js - Promise ES6 feature
function divide(n1,n2){ //notice there is no 3rd arg callback
    return new Promise((resolve,reject)=>{
        if(typeof n1 !=='number'){
            reject('first argument is not a number');
        }
        if(typeof n2!=='number'){
            reject('second argument is not a number');
        }    
        if(n2===0){
            reject('cannot divide by zero');
        }
        resolve(n1/n2);
    });
}

console.log('start of script');
let a=12,b=0;
divide(a,b).then(result=>{
                console.log('Result of division:',result);
}).catch(err=>{
        console.log('There was an error:',err);
});
console.log('end of script');
