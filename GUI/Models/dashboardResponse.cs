using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models
{
    internal class dashboardResponse
    {
        public int TotalFoods { get; set; }
        public int TotalFoodGoodConditions { get; set; }
        public int TotalFoodNotGoods { get; set; }
        public int TotalFoodDistributeds { get; set; }
    }
}
