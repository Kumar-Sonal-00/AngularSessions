"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var employee_1 = require("./employee");
var emps = [];
emps.push(new employee_1.Employee(101, 'Ravi', 1111, 201));
emps.push(new employee_1.Employee(102, 'Rahul', 2222, 202));
emps.push(new employee_1.Employee(103, 'Rohit', 3333, 203));
emps.forEach(function (e) {
    e.display();
});
