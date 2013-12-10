using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using PetFeed.Models;

namespace PetFeed.Mappings
{
    /*
     * Map our Models.Pet Object to the database table Pet
     */ 
    public class PetMap : ClassMap<Pet>
    {
        public PetMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Image_Path);
            Map(x => x.Max_Meal);
            Map(x => x.Last_Meal_Date);
            References(x => x.User).Cascade.All().Not.LazyLoad();
        }
    }
}