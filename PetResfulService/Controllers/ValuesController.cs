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
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("api/pets")]
        public List<PetSale> GetAll()
        {
            List<PetSale> pets = new PetDAO().SelectAll();
            return pets;
        }

        [HttpGet]
        [Route("api/pets/{Id}")]
        public PetSale GetDetails(int Id)
        {
            PetSale pet = new PetDAO().SelectById(Id);
            return pet;
        }

        [HttpPost]
        [Route("api/pets")]
        public PetSale AddNew(PetSale newPet)
        {
            PetSale pet = new PetDAO().InsertS(newPet);
            return pet;
        }

        [HttpPut]
        [Route("api/pets/{Id}")]
        public PetSale UpdatePet(int Id, PetSale newPet)
        {
            PetSale pet = new PetDAO().UpdateS(Id, newPet);
            return pet;
        }

        [HttpDelete]
        [Route("api/pets/{Id}")]
        public PetSale DeletePet(int Id)
        {
            PetSale pet = new PetDAO().DeleteS(Id);
            return pet;
        }

        [HttpGet]
        [Route("api/pets/search/{keyword}")]
        public List<PetSale> Search(String keyword)
        {
            List<PetSale> pets = new PetDAO().SelectByName(keyword);
            return pets;
        }
    }
}