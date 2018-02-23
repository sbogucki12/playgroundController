﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaygroundAPI.Controllers
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }

    }
    public class PracticeController : ApiController
    {

        List<Animal> animals = new List<Animal>
        {
            new Animal{ Id = 1, Name = "Tiger", IsMale = true },
            new Animal{ Id = 2, Name = "Bear", IsMale = false },
            new Animal{ Id = 3, Name = "Lion", IsMale = true },
            new Animal{ Id = 4, Name = "Monkey", IsMale = false }
        };

        [Route("api/Practice/{id}")]
        public HttpResponseMessage Get(int id)
        {
            IEnumerable<Animal> an = animals;
            Animal selectedAnimal = an.FirstOrDefault(a => a.Id == id);
            if (selectedAnimal != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, selectedAnimal);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "No such Animal located");              
               
            }
        }




        //[Route("api/Practice/")]
        //public string Get()
        //{
        //    return "Hello World";
        //}
    }
}
