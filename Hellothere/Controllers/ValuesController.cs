using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hellothere.Models;

namespace MyFirstProject.Controllers
{
      public class NameController : ApiController
    {
        Member[] Person = new Member[]
        {
                new Member { ID = 1, Name = "Karthik", DoB = "07/06/1979", Color = "Blue" },
                new Member { ID = 2, Name = "Laavanya", DoB = "08/16/1979", Color = "Red" },
                new Member { ID = 3, Name = "Aditi", DoB = "09/09/2012", Color = "Pink" },
                new Member { ID = 4, Name = "Aarav", DoB = "01/27/2016", Color = "Orange" }
        };

        public IEnumerable<Member> Get()
        {
            return Person;
        }
            
        // GET api/names/5
        public string Get(int id)
        {
            return "value";
        }

    }
}
