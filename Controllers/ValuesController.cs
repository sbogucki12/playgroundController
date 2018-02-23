using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaygroundAPI.Controllers
{
    public class ValuesController : ApiController
    {

        List<int> SampleList = new List<int> { 0, 1, 2, 3 };
        List<string> StringList = new List<string>();

        private int AddImplement(int a, int b)
        {
            return a + b; 
        }

        public int PublicAdder (int a, int b)
        {
            return (AddImplement(a, b));
        }

        // GET api/values
        //public List<int> Get()
        //{
        //    return SampleList;
               
        //}

        public int Get(int id, int id2)
        {
            return PublicAdder(id, id2);
        }
        

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

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
