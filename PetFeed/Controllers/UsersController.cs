using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using PetFeed.Models;

namespace PetFeed.Controllers
{
    public class UsersController : ApiController
    {

        private UserService userService = new UserService();

        /*
         *Call the user service to return the user asked for in JSON 
         */
        public User GetUserById(int id)
        {
            User user = userService.GetUserById(id);
            return user;
        }
    }
}
