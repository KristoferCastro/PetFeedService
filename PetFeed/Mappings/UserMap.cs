using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using PetFeed.Models;

namespace PetFeed.Mappings
{
    /*
     * Map our Models.User Object to the database table User
     */ 
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).Column("id");
            Map(x => x.Name).Column("name");
            HasMany(x => x.Pets)
                .Inverse()
                .Cascade.All()
                .Not.LazyLoad();
        }
    }
}