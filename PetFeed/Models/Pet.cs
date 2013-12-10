using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetFeed.Models
{
    public class Pet
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Image_Path { get; set; }
        public virtual int Max_Meal { get; set; }
        public virtual DateTime Last_Meal_Date { get; set; }
        public virtual User User { get; set; }
    }
}