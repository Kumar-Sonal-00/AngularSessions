//es5_09.js - callback -ES5 feature
function divide(n1,n2,callback){
    setTimeout(()=>{
        //console.log('divide function started');
            if(typeof n1!=='number'){
                callback('first argument is not a number');
            }
            if(typeof n2!=='number'){
                callback('second argument is not a number');
            }
            if(n2===0){
                callback('cannot divide by zero');
            }
            callback(null,n1/n2);        
    },0);  
}

console.log('start of script');
let a=10,b=5;
let c=divide(a,b,(err,result)=>{
    if(err){
        console.log('There was an error:',err)
    }else{
        console.log('The result of division:',result);
    }
});
console.log('end of script');