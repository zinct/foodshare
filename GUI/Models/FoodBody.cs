using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models
{
    public class FoodBody
    {
        public String Expire { get; set; }
        public string Name { get; set; }
        public string Conditions { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
    }
}
