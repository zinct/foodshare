using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models.Request
{
    public  class CreateUserRequest
    {
        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
