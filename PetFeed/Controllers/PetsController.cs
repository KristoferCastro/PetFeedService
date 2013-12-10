using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using PetFeed.Models;
using System.Data;
using Npgsql;
using System.Diagnostics;
using System.Configuration;


namespace PetFeed.Controllers
{
    public class PetsController : ApiController
    {
        private readonly String connectionString = ConfigurationManager.ConnectionStrings["KierServerConnectionString"].ConnectionString;
        private PetService petService = new PetService();

        /*
         * Return the pet asked
         */
        public Pet GetPetById(int id)
        {
            Pet myPet = petService.GetById(id);
            return myPet;
        }

        /* 
         * updates the field in the database that stores the time the pet has last fed
         */ 
        [HttpPost]
        public Pet ChangeLastFedTime(int id)
        {
            return petService.UpdateLastMealDate(id); 
        }
    }
}
