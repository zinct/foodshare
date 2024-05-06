using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShareConsoleApp.Entities.Response
{
    public class ReadFoodResponse
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateOnly Expire { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
    }
}
