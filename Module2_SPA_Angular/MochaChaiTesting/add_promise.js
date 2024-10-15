function add_promise(a,b){
    return new Promise((resolve)=>{
        setTimeout(()=>{
            resolve(a+b);
        },1);
    });
}

module.exports=add_promise;