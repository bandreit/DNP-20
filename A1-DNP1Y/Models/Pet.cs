using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace Models
{
    public class Pet
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("species")] [Required] [ValidSpecies] public string Species { get; set; } = "";
        [JsonPropertyName("name")] [Required] public string Name { get; set; }
        [JsonPropertyName("age")] [Required] public int Age { get; set; }
    }

    public class ValidSpecies : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "hamster", "bunny", "frog", "budgerigar",
                "owl", "snake", "dog", "cat"
            }.ToList();
            if (valid == null || valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(
                "Valid pet species are: Hamster, Bunny, Frog, Budgerigar, Owl, Snake, Cat, Dog");
        }
    }
}