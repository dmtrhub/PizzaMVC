using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public int PizzaID { get; set; }
        public string PizzaName { get; set; }
        public int PizzaSize { get; set; }
        public int PizzaPrice { get; set; }

    }
}
