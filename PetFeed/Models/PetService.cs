using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using NHibernate;
using NHibernate.Criterion;

/*
 * This class functions that manages the database for the Pet table.
 * author Kristofer Castro
 */ 
namespace PetFeed.Models
{
    public class PetService : DBService
    {

        public IList<Pet> GetAllPet(User user)
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                var pets = session.CreateQuery("from Pet where user_id = :id")
                    .SetParameter("id", user.Id).List<Pet>();
                return pets;
             
            }
        }

        public Pet GetById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Pet pet = session.Get<Pet>(id);
                    transaction.Commit();
                    return pet;
                }
            }
        }

        /*
         * Gets the pet from the database and updates its Last_Meal_date value to todays date (DateTime.now)
         */ 
        public Pet UpdateLastMealDate(int petID)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Pet loadedPet = session.Get<Pet>(petID);
                    loadedPet.Last_Meal_Date = DateTime.Now;
                    session.SaveOrUpdate(loadedPet);
                    transaction.Commit();
                    return loadedPet;
                }
            }
        }
    }
}