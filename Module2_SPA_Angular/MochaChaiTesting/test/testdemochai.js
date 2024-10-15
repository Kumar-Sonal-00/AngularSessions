var assert=require('assert');
var calc=require('../calculator');

var expect=require('chai').expect;
var should=require('chai').should();

describe('Calculator Testing using Chai',()=>{
    it('add()-expect',()=>{
        let a=100,b=200;
        let sum=calc.add(a,b);
        //using mocha
        //assert.equal(sum,300);

        //using chai expect interface
        expect(sum).to.be.equal(300);
    });
    it('subtract()-should',()=>{
        let a=100,b=200;
        let sum=calc.subtract(b,a);
        //using mocha
        //assert.equal(sum,300);

        //using chai expect interface
        //expect(sum).to.be.equal(300);

        //using chai should interface
        sum.should.be.equal(100);
    });
});