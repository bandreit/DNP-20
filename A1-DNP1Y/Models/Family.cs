using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Family
    {
        public int? Id { get; set; }
        [Required (ErrorMessage = "Street Name Field is Required")] public string StreetName { get; set; }
        [Required] public int HouseNumber { get; set; }
        [ValidateComplexType] public List<Adult> Adults { get; set; }
        [ValidateComplexType] public List<Child> Children { get; set; }
        [ValidateComplexType] public List<Pet> Pets { get; set; }

        public Family()
        {
            Adults = new List<Adult>();
            Children = new List<Child>();
            Pets = new List<Pet>();
        }
    }
}