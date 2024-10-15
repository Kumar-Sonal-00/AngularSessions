// async/await - ES7 feataure
//it gives more neater code which looks like
//synchronouse code but under the hood it is
//stil asynchronous model

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

//==========main script===========
console.log('start of script');
let a=12,b=5;
   setTimeout(async ()=>{
       try{
            let result = await divide(a,b);
            console.log('Result of division:',result);       
       }catch(err){
            console.log('There was an error:',err);
        }
   },0); 
console.log('end of script');