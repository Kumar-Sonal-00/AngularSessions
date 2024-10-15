"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Employee = void 0;
var Employee = /** @class */ (function () {
    function Employee(ecode, ename, salary, deptid) {
        this.ecode = ecode;
        this.ename = ename;
        this.salary = salary;
        this.deptid = deptid;
    }
    Employee.prototype.display = function () {
        console.log("".concat(this.ecode, "\t").concat(this.ename, "\t").concat(this.salary, "\t").concat(this.deptid));
    };
    Employee.prototype.calculateBonus = function () {
        var bonus;
        if (this.salary > 5000) {
            bonus = 0.1 * this.salary;
        }
        else {
            bonus = 0.2 * this.salary;
        }
        return bonus;
    };
    return Employee;
}());
exports.Employee = Employee;
