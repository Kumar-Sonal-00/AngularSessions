//ex06.js - rest operator
function display(name1,name2,...names){
    console.log(name1,name2);
    console.log('Hello,',names);
}

display('Ramnath');
display('Ramnath','Shyam');
display('Ramnath','Shyam','John');
display('Ramnath','Shyam','John','Tom');
display('Ramnath','Shyam','John','Tom',"David");