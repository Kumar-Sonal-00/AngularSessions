var chai=require('chai');
var chaiAsPromised=require('chai-as-promised');
chai.use(chaiAsPromised).should;

var add_promise=require('../add_promise');

it('add_promise synchronous using chai',()=>{
    let a=50,b=30;
    return add_promise(a,b).should.equal(80);    
});