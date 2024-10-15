const numbers=[28,77,45,99,27];
numbers.forEach((n)=>{
    console.log(n);
});

const cities=['Mysore','Jaipur','Delhi','Bangalore'];

let ele="<ul>";
cities.forEach((city)=>{
    ele+="<li>"+city+"</li>";
});
ele+="</ul>";
console.log(ele);


