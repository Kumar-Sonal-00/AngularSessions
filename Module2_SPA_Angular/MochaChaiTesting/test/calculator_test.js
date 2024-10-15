var assert=require('assert');

var calc=require('../calculator');
var a=0,b=0;

describe('Testing Calculator Methods',function(){
    this.beforeEach('Setting up a and b values',function(){
        a=100;
        b=200;
        console.log('beforeEach');
    });
    it('should return sum result of numbers',function(){

        // let a=100,b=200;      
        let result=calc.add(a,b);
        assert.equal(result,300);
    });
    it('should return difference result of numbers----',function(){

        // let a=100,b=200;
        let result=calc.subtract(a,b);
        assert.equal(result,-100);        
    });
    it('should return product of numbers',function(){

        // let a=100,b=200;
        let result=calc.multiply(a,b);
        assert.equal(result,20000);
    });
    it('should return division result of numbers',function(){

        // let a=100,b=200;
        let result=calc.divide(b,a);
        assert.equal(result,2);
    });

    describe('group 2 tests',function(){
        it('some independent test1',function(){
            assert.equal(true,true);
        });
        it('some independent test2',function(){
            assert.equal(true,true);
        });
    });

    this.afterEach('Clean up code',function(){
        console.log('afterEach');
    });
});

describe('Basic Mocha String Test',function(){
	it('should return number of characters in a string',function(){
		assert.equal("Hello".length,5);
	});
	
	it('should return first character of the string',function(){
		assert.equal("Hello".charAt(0),"H");
	});

});





