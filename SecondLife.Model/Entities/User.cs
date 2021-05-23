using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLife.Model.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
    }
}
