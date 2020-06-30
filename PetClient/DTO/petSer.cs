using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClient.DTO
{
    class petSer
    {
        public int ID { get; set; }
        public string CusName { get; set; }
        public string PetName { get; set; }
        public string PetGender { get; set; }
        public string PetAge { get; set; }
        public float PetWeight { get; set; }

        public string PetType { get; set; }
        public string WhatServices { get; set; }
        public object NullValue { get; set; }
    }
}
