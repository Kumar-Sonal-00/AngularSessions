var expect=require('chai').expect;
var add_cb=require('../callback_demo');

it('Testing asynchronous method with callback',(done)=>{
    let a=100,b=200;
    add_cb(a,b,(result)=>{
        expect(result).to.be.equal(300);
        done();
    });
});
