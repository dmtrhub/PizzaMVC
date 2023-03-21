using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPizza.Models
{
    public class PizzaModel
    {
        [Display(Name = "Pizza ID")]
        [Range(100,999, ErrorMessage = "You need to enter a valid pizza ID (3-digits number)")]
        public int PizzaID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You need to enter a pizza name!")]
        public string PizzaName { get; set; }

        [Display(Name = "Size")]
        [Range(20,50, ErrorMessage = "Size: 20 - 50 cm!")]
        [Required(ErrorMessage = "You need to enter a pizza size!")]
        public int PizzaSize { get; set; }

        [Display(Name = "Price")]
        [Range(10, 50, ErrorMessage = "Price: 10 - 50 $!")]
        [Required(ErrorMessage = "You need to enter a pizza price!")]
        public int PizzaPrice { get; set; }
    }
}