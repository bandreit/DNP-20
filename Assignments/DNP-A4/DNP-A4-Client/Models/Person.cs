using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;

namespace Models
{
    public class Person
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("firstName")] [Required (ErrorMessage = "First Name Field is Required")] public string FirstName { get; set; }
        [JsonPropertyName("lastName")] [Required (ErrorMessage = "Last Name Field is Required")] public string LastName { get; set; }
        [JsonPropertyName("hairColor")] [Required (ErrorMessage = "Hair Color Field is Required"), ValidHairColor] public string HairColor { get; set; } = "";
        [JsonPropertyName("eyeColor")] [Required (ErrorMessage = "Eye Color Field is Required"), ValidEyeColor] public string EyeColor { get; set; } = "";
        [JsonPropertyName("age")] [Required, Range(0, 125)] public int Age { get; set; }
        [JsonPropertyName("weight")] [Required, Range(1, 250)] public float Weight { get; set; }
        [JsonPropertyName("height")] [Required, Range(30, 250)] public int Height { get; set; }
        [JsonPropertyName("sex")] [Required (ErrorMessage = "Sex Field is Required")] public string Sex { get; set; }

        public void Update(Person toUpdate)
        {
            Age = toUpdate.Age;
            Height = toUpdate.Height;
            HairColor = toUpdate.HairColor;
            Sex = toUpdate.Sex;
            Weight = toUpdate.Weight;
            EyeColor = toUpdate.EyeColor;
            FirstName = toUpdate.FirstName;
            LastName = toUpdate.LastName;
        }
    }

    public class ValidHairColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "blond", "red", "brown", "black",
                "white", "grey", "blue", "green", "leverpostej"
            }.ToList();
            if (valid == null || valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(
                "Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
        }
    }

    public class ValidEyeColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[]
            {
                "brown", "grey", "green", "blue",
                "amber", "hazel"
            }.ToList();
            if (valid != null && valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
        }
    }
}