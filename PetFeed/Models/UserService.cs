using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * This class functions that manages the database for the User table.
 * 
 * Only currently support one user that is id=0 since it is only going to be used for personal/private use at first
 * author Kristofer Castro
 */ 
namespace PetFeed.Models
{
    public class UserService : DBService
    {
        public User GetUserById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    User user = session.Get<User>(id);
                    transaction.Commit();
                    return user;
                }
            }
        }
    }
}