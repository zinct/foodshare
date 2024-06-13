using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models.Response
{
    public class GetUserResponse
    {
        public string Name { get; set; }
        public string Username { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
