using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CategoriesViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-ZñÑ\s]{1,15}$", ErrorMessage = "Error! Solo caracteres del alfabeto y espacios!")]
        public string Name { get; set; }
    }
}