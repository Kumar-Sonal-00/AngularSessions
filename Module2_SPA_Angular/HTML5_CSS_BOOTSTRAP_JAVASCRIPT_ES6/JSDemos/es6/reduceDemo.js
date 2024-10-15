//higher-order-function - reduce()

const numbers=[1,2,3,4,5];

const sum=numbers.reduce((accumulator,currentValue)=>{
		return accumulator + currentValue;
	},0);
console.log('sum:',sum);
