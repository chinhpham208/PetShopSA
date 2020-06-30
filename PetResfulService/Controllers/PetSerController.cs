using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PetResfulService.Models;
using PetResfulService.DAL;

namespace PetResfulService.Controllers
{
    public class PetSerController : ApiController
    {
        [HttpGet]
        [Route("api/petSers")]
        public List<PetSer> GetAll()
        {
            List<PetSer> petSers = new PetSerDAO().SelectAll();
            return petSers;
        }

        [HttpGet]
        [Route("api/petSers/{Id}")]
        public PetSer GetDetails(int Id)
        {
            PetSer petSer = new PetSerDAO().SelectById(Id);
            return petSer;
        }

        [HttpPost]
        [Route("api/petSers")]
        public PetSer AddNew(PetSer newPetSer)
        {
            PetSer petSer = new PetSerDAO().Insert(newPetSer);
            return petSer;
        }

        [HttpPut]
        [Route("api/petSers/{Id}")]
        public PetSer UpdatePetSer(int Id, PetSer newPetSer)
        {
            PetSer petSer = new PetSerDAO().Update(Id, newPetSer);
            return petSer;
        }

        [HttpDelete]
        [Route("api/petSers/{Id}")]
        public PetSer DeletePetSer(int Id)
        {
            PetSer petSer = new PetSerDAO().Delete(Id);
            return petSer;
        }

        [HttpGet]
        [Route("api/petSers/search/{keyword}")]
        public List<PetSer> Search(String keyword)
        {
            List<PetSer> petSers = new PetSerDAO().SelectByName(keyword);
            return petSers;
        }
    }
}