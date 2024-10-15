var assert = require('assert');

var expect=require('chai').expect;
var should=require('chai').should();


 describe('Basic Mocha String Test',function(){
	it('should return number of characters in a string',function(){
		//assert.equal("Hello".length,5);
        "Hello".length.should.equal(5);
        //expect("Hello".length).equal(5);
	});
	
	it('should return first character of the string',function(){
		// assert.equal("Hello".charAt(0),"H");
        expect("Hello".charAt(0)).equals("H");
	});
});

