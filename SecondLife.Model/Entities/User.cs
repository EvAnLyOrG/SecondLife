using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Model.Entities
{
    public class User
    {
        public int Id { get; set; }
        public String UserId { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Firstname { get; set; }
        public String Email { get; set; }
    }
}
