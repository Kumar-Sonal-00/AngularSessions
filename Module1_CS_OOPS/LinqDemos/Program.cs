namespace LinqDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repo = new EmployeeRepository();
            var lstEmps = repo.GetEmps();
            var lstDepts=repo.GetDepts();

            //Q1. for getting employees records by deptid
            //SQL: select * from employee where deptid=201
            //LINQ: using operators
            var res1 = from e in lstEmps
                       where e.Deptid==201 //&& e.Salary>2000
                       select e;

            //OR using extension method
            res1 = lstEmps.Where(e=>e.Deptid==201);


            foreach (var r in res1)
            {
                //Console.WriteLine(r.ToString());
            }

            //Q2. select only ecode and ename of the employees
            //SQL: select ecode as EmpCode,ename as EmpName from employee
            //LINQ:
            var res2 = from e in lstEmps
                       select new 
                       { 
                          Empcode= e.Ecode, 
                          EmpName= e.Ename 
                       };

            //OR: using extension method
            res2 = lstEmps.Select(e => new 
                                    {
                                        Empcode=e.Ecode,
                                        EmpName=e.Ename 
                                    });

            foreach (var r in res2)
            {
                //Console.WriteLine(r.Empcode+"\t"+r.EmpName);
            }

            //Q3. sorting the records by salary 
            //SQL: select * from employee order by salary asc
            //LINQ:
            var res3 = from e in lstEmps
                       orderby e.Salary descending,e.Ecode 
                       select e;

            //OR: using extension method
            res3 = lstEmps.OrderByDescending(e=>e.Salary)
                          .ThenBy(e=>e.Ecode);

            foreach (var r in res3)
            {
                //Console.WriteLine(r.ToString());
            }

            //Q4. select employees details along with bonus as 10% of salary
            //SQL: select *,0.1*salary as Bonus from employee 
            //LINQ:using operators
            var res4 = from e in lstEmps
                       select new
                       {
                           Emp=e,
                           Bonus=(e.Salary==null?0:0.1*e.Salary)
                       };

            //OR: using extension method
            res4 = lstEmps.Select(e=> new
                            {
                                Emp = e,
                                Bonus = (e.Salary == null ? 0 : 0.1 * e.Salary)
                            });

            foreach (var r in res4)
            {
                //Console.WriteLine(r.Emp.ToString()+"\t"+String.Format("{0:.00}",r.Bonus));
            }

            //Q5. Group by deptid
            //SQL:
            //select deptid,sum(salary) as TotalSal,
            //avg(salary) as AvgSal,
            //max(salary) as MaxSal,
            //min(salary) as MinSal,
            //count(salary) as NoOfSal
            //from employee
            //group by deptid

            //LINQ: using operators
            var res5 = from e in lstEmps
                       group e by e.Deptid into g
                       select new
                       {
                           Deptid=g.Key,
                           TotalSal=g.Sum(e=>e.Salary),
                           AvgSal =g.Average(e=>e.Salary),
                           MaxSal=g.Max(e=>e.Salary),
                           MinSal=g.Min(e=>e.Salary),
                           NoOfSal=g.Count()
                       };

            //OR: using extension methods
            res5 = lstEmps.GroupBy(e => e.Deptid).Select(g=> new
            {
                Deptid = g.Key,
                TotalSal = g.Sum(e => e.Salary),
                AvgSal = g.Average(e => e.Salary),
                MaxSal = g.Max(e => e.Salary),
                MinSal = g.Min(e => e.Salary),
                NoOfSal = g.Count()
            });

            foreach (var r in res5)
            {
               //Console.WriteLine($"{r.Deptid}\t{r.TotalSal}\t{r.AvgSal}\t{r.MaxSal}\t{r.MinSal}\t{r.NoOfSal}");
            }

            //Q6. Group functions
            //SQL:
            //select sum(salary) as TotalSal,
            //avg(salary) as AvgSal,
            //max(salary) as MaxSal,
            //min(salary) as MinSal,
            //count(salary) as NoOfSal
            //from employee

            var res6 = new
            {
                TotalSal=lstEmps.Sum(e=>e.Salary),
                AvgSal=lstEmps.Average(e=>e.Salary),
                MaxSal=lstEmps.Max(e=>e.Salary),
                MinSal=lstEmps.Min(e=>e.Salary),
                NoOfSal=lstEmps.Count()
            };

            //Console.WriteLine($"{res6.TotalSal}\t{res6.AvgSal}\t{res6.MaxSal}\t{res6.MinSal}\t{res6.NoOfSal}");

            //Q7.Nested query:
            //find the employees working in the department of employee whose ecode=101 
            //SQL: 
            //select * 
            //from employee
            //where deptid=(select deptid
            //              from employee
            //              where ecode=101)
            //LINQ: using operators
            var res7 = from e in lstEmps
                       where e.Deptid==(from p in lstEmps 
                                        where p.Ecode==101 
                                        select p.Deptid).SingleOrDefault()
                       select e;
            
            //OR: using extension method

            res7 = lstEmps.Where(e => e.Deptid == lstEmps.Where(p=>p.Ecode==101)
                                                         .Select(p=>p.Deptid)
                                                         .SingleOrDefault());

            foreach (var r in res7)
            {
                //Console.WriteLine(r.ToString());
            }

            //Q8: using pattern matching with string data 
            //Find the employees whose name start with 'R'
            //SQL: select * from employee where ename like 'R%'
            //LINQ:using operators
            var res8 = from e in lstEmps
                       where e.Ename.Contains("i",StringComparison.OrdinalIgnoreCase) //LIKE '%i%'
                       select e;

            //OR: using extension method
            res8 = lstEmps.Where(e=>e.Ename.Contains("i", StringComparison.OrdinalIgnoreCase));
            
            foreach (var r in res8)
            {
                //Console.WriteLine(r.ToString());
            }

            //Q9: select the distinct records
            //SQL: select distinct deptid from employee
            //LINQ:using operators
            var res9 = (from e in lstEmps
                        select e.Deptid).Distinct();

            //OR: using extension method
            res9 = lstEmps.Select(e => e.Deptid).Distinct();

            foreach (var r in res9)
            {
                //Console.WriteLine(r);
            }

            //Q10. inner join
            //SQL:
            //select e.ecode,e.ename,e.salary,d.deptid,d.dname,d.dhead
            //from employee as e
            //join department as d
            //on(e.deptid=d.deptid)
            //LINQ: using operators
            var res10 = from e in lstEmps
                        join d in lstDepts on e.Deptid equals d.Deptid
                        select new
                        {
                            e.Ecode,
                            e.Ename,
                            e.Salary,
                            d.Deptid,
                            d.Dname,
                            d.Dhead
                        };

            //OR: using extension method
            res10 = lstEmps.Join(lstDepts, 
                                e => e.Deptid, 
                                d => d.Deptid, 
                                (e, d) => new
                                {
                                    e.Ecode,
                                    e.Ename,
                                    e.Salary,
                                    d.Deptid,
                                    d.Dname,
                                    d.Dhead
                                });
            //OR: using extension method

            foreach (var r in res10)
            {
                //Console.WriteLine($"{r.Ecode}\t{r.Ename}\t{r.Salary}\t{r.Deptid}\t{r.Dname}\t{r.Dhead}");
            }


            //Q11. Left-outer join
            //SQL: 
            //select e.ecode,e.ename,e.salary,d.deptid,d.dname,d.dhead
            //from employee as e
            //left outer join department as d
            //on(e.deptid=d.deptid)

            //LINQ: using operators
            var res11 = from e in lstEmps
                        join d in lstDepts on e.Deptid equals d.Deptid into g
                        from j in g.DefaultIfEmpty()                        
                        select new
                        {
                            e.Ecode,
                            e.Ename,
                            e.Salary,
                            Deptid=(j==null?0:j.Deptid),
                            Dname=(j==null?"No dname":j.Dname),
                            Dhead=(j==null?0:j.Dhead)
                        };

            //OR : using extension method
            //res11 = lstEmps.Join(lstDepts,
            //                    e => e.Deptid,
            //                    d => d.Deptid,
            //                    (e,d)=>new { e,d}).DefaultIfEmpty()
            //                    .Select((emp,j)=> new
            //                    {
            //                        emp.e.Ecode,
            //                        emp.e.Ename,
            //                        emp.e.Salary,
            //                        Deptid = (j == null ? 0 : emp.d.Deptid),
            //                        Dname = (j == null ? "No dname" : emp.d.Dname),
            //                        Dhead = (j == null ? 0 : emp.d.Dhead)
            //                    }).DefaultIfEmpty();

            foreach (var r in res11)
            {
                Console.WriteLine($"{r.Ecode}\t{r.Ename}\t{r.Salary}\t{r.Deptid}\t{r.Dname}\t{r.Dhead}");
            }


            //Q12. Right-outer join
            //SQL: 
            //select e.ecode,e.ename,e.salary,d.deptid,d.dname,d.dhead
            //from employee as e
            //right outer join department as d
            //on(e.deptid=d.deptid)

            //LINQ:
            var res12 = from d in lstDepts
                        join e in lstEmps on d.Deptid equals e.Deptid into g
                        from j in g.DefaultIfEmpty()
                        select new
                        {
                            Ecode=(j==null?0:j.Ecode),
                            Ename=(j==null?"No ename":j.Ename),
                            Salary=(j==null?0:j.Salary),
                            Deptid = d.Deptid,
                            Dname = d.Dname,
                            Dhead = d.Dhead
                        };

            foreach (var r in res12)
            {
                //Console.WriteLine($"{r.Ecode}\t{r.Ename}\t{r.Salary}\t{r.Deptid}\t{r.Dname}\t{r.Dhead}");
            }


            //Q13. Full-outer join
            //SQL: 
            //select e.ecode,e.ename,e.salary,d.deptid,d.dname,d.dhead
            //from employee as e
            //full outer join department as d
            //on(e.deptid=d.deptid)

            //LINQ:
            var res13 = res11.Union(res12);
            foreach (var r in res13)
            {
                //Console.WriteLine($"{r.Ecode}\t{r.Ename}\t{r.Salary}\t{r.Deptid}\t{r.Dname}\t{r.Dhead}");
            }





            //List<int> list = new List<int> { 5, 10, 20, 11, 60 };
            ////select all the even numbers
            //var evenNums = (from n in list
            //               where n%2==0 && n > 20
            //               select n).SingleOrDefault();

            //Console.WriteLine(evenNums);

            //foreach (var item in evenNums)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
