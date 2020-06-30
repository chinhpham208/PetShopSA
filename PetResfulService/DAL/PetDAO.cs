using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using PetResfulService.Models;

namespace PetResfulService.DAL
{
    public class PetDAO
    {
        static String strCon = ConfigurationManager.ConnectionStrings["mngpetsConnectionString"].ConnectionString;
        PetDBDataContext db = new PetDBDataContext(strCon);
        public List<PetSale> SelectAll()
        {

            List<PetSale> pets = db.PetSales.ToList();
            return pets;
        }
        public PetSale SelectById(int Id)
        {
            PetSale pets = db.PetSales.SingleOrDefault(x => x.ID == Id);
            return pets;
        }
        public PetSale InsertS(PetSale newPet)
        {
            try
            {
                db.PetSales.InsertOnSubmit(newPet);
                db.SubmitChanges();
                return newPet;
            }
            catch
            {
                return null;
            }
        }
        public PetSale UpdateS(int Id, PetSale newPet)
        {
            try
            {
                PetSale data = db.PetSales.SingleOrDefault(x => x.ID == Id);
                if (data != null)
                {
                    data.ID = newPet.ID;
                    data.Type = newPet.Type;
                    data.Gender = newPet.Gender;
                    data.Weight = newPet.Weight;
                    data.Age = newPet.Age;
                    data.Price = newPet.Price;
                    //data.img = newPet.img;
                    db.SubmitChanges();
                }
                return data;
            }
            catch
            {
                return null;
            }
        }
        public PetSale DeleteS(int Id)
        {
            try
            {
                PetSale pet = db.PetSales.Single(u => u.ID == Id);
                if (pet != null)
                {
                    db.PetSales.DeleteOnSubmit(pet);
                    db.SubmitChanges();
                }
                return pet;
            }
            catch
            {
                return null;
            }
        }
        public List<PetSale> SelectByName(String keyWord)
        {
            List<PetSale> pets = db.PetSales.Where(b => b.Type.Contains(keyWord)).ToList();
            return pets;
        }
    }
}
