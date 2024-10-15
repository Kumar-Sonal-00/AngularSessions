function add_cb(a,b,cb){
       setTimeout(()=>{
            cb(a+b);
       },1);
}

module.exports=add_cb;