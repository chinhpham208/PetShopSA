using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetClient.DTO;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PetClient.BLL
{
    class userBUS
    {
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "SyTMxX4k3tYfCBKEJXsjAz89DrfQABmmBU6D654b",
            BasePath = "https://sarchitech-f393b.firebaseio.com/"
        };

        public IFirebaseClient client;

        public void check()
        {
            client = new FireSharp.FirebaseClient(ifc);
        }
        
    }
}
