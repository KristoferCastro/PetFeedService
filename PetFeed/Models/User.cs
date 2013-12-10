using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetFeed.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Pet> Pets { get; set; }

        public User()
        {
            Pets = new List<Pet>();
        }

        public virtual void AddPet(Pet pet)
        {
            Pets.Add(pet);
        }
    }
}