using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using Models;

namespace A1_DNP1Y.Models
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

        public string GetLastNames()
        {
            string LastNames = "";
            if (Adults.Count > 1)
            {
                if (Adults.Any(adult => adult.LastName != Adults[0].LastName))
                {
                    Adults.ForEach(adult => LastNames += adult.LastName + "-");
                    LastNames = LastNames.Remove(LastNames.Length - 1);
                }
                else
                {
                    LastNames = Adults[0].LastName;
                }
            }
            else if (Adults.Count == 1)
            {
                LastNames = Adults[0].LastName;
            }
            LastNames += " Family";

            return LastNames;
        }
    }
}