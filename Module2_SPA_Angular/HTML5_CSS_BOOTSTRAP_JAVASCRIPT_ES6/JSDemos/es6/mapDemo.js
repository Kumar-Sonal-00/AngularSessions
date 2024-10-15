//higher-order-function - map

let arr=[2,4,6,8,10];
let arr2=arr.map((n)=>{return n*n});
console.log('arr:',arr);
console.log('arr2:',arr2);

const contestants=['Taylor','Donald','Tom','Bobby'];
const announcements=contestants.map(member=>{
    return member + ' joined the contest';
});

console.log(announcements);