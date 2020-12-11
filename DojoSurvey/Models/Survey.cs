using System.ComponentModel.DataAnnotations;
using System;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Key]
        [Required]
        [Display(Name="Name: ")]
        public string Name {get;set;}

        [Required]
        [Display(Name="Dojo location: ")]
        public string Location {get;set;}

        [Required]
        [Display(Name="Favorite Language: ")]
        public string Language {get;set;}

        [Required]
        [Display(Name="Comment: ")]
        public string Comment {get;set;}
    }
}