using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Child : Person
    {
        public List<ChildInterest> ChildInterests { get; set; }
        [ValidateComplexType] public List<Pet> Pets { get; set; }

        public void Update(Child toUpdate)
        {
            base.Update(toUpdate);
            ChildInterests = toUpdate.ChildInterests;
            Pets = toUpdate.Pets;
        }

        public Child()
        {
            Pets = new List<Pet>();
            ChildInterests = new List<ChildInterest>();
        }
    }
}