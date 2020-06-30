using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using PetResfulService.Models;

namespace PetResfulService.DAL
{
    public class PetSerDAO
    {
        static String strCon = ConfigurationManager.ConnectionStrings["mngpetsConnectionString"].ConnectionString;
        PetSerDBDataContext db = new PetSerDBDataContext(strCon);
        public List<PetSer> SelectAll()
        {

            List<PetSer> petSers = db.PetSers.ToList();
            return petSers;
        }
        public PetSer SelectById(int Id)
        {
            PetSer petSers = db.PetSers.SingleOrDefault(x => x.Id == Id);
            return petSers;
        }
        public PetSer Insert(PetSer newPetSer)
        {
            try
            {
                db.PetSers.InsertOnSubmit(newPetSer);
                db.SubmitChanges();
                return newPetSer;
            }
            catch
            {
                return null;
            }
        }
        public PetSer Update(int Id, PetSer newPetSer)
        {
            try
            {
                PetSer data = db.PetSers.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    data.Id = newPetSer.Id;
                    data.CusName = newPetSer.CusName;
                    data.PetName = newPetSer.PetName;
                    data.PetGender = newPetSer.PetGender;
                    data.PetAge = newPetSer.PetAge;
                    data.PetWeight = newPetSer.PetWeight;
                    data.PetType = newPetSer.PetType;
                    data.WhatServices = newPetSer.WhatServices;
                    db.SubmitChanges();
                }
                return data;
            }
            catch
            {
                return null;
            }
        }
        public PetSer Delete(int Id)
        {
            try
            {
                PetSer petSer = db.PetSers.Single(u => u.Id == Id);
                if (petSer != null)
                {
                    db.PetSers.DeleteOnSubmit(petSer);
                    db.SubmitChanges();
                }
                return petSer;
            }
            catch
            {
                return null;
            }
        }
        public List<PetSer> SelectByName(String keyWord)
        {
            List<PetSer> petSers = db.PetSers.Where(b => b.PetType.Contains(keyWord)).ToList();
            return petSers;
        }
    }
}
