using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaygroundAPI.Controllers
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

    }
    public class ValuesController : ApiController
    {


        List<Employee> employees = new List<Employee>
        {
            new Employee() { Id = 1, Job = "Janitor", Name = "Steve"},
        new Employee() { Id = 2, Job = "Teacher", Name = "Prydz"},
        new Employee() { Id = 3, Job = "Student", Name = "Roux"},
        new Employee() { Id = 4, Job = "Professor", Name = "Simmons"}

    };



        List<int> SampleList = new List<int> { 0, 1, 2, 3 };
        List<string> StringList = new List<string>();

        public Employee Get(int id)
        {
            Employee emp = employees.FirstOrDefault(e => e.Id == id);
            if(emp != null)
            {
                return emp;
            }
            else
            {
                return new Employee { Id = 10, Job = "Police", Name = "Huckleberry" };
            }
        }


        //private int AddImplement(int a, int b)
        //{
        //    return a + b;
        //}

        //public int PublicAdder(int a, int b)
        //{
        //    return (AddImplement(a, b));
        //}

        // GET api/values
        //public List<int> Get()
        //{
        //    return SampleList;

        //}

        //public int Get(int id, int id2)
        //{
        //    return PublicAdder(id, id2);
        //}





        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public string Post([FromBody]string a)
        {
            StringList.Add(a);
            return StringList[0];
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public List<int> Delete(int id)
        {
            SampleList.Remove(id);
            return SampleList;
        }
    }
}
