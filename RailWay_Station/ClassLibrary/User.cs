using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace ClassLibrary
{
    class User
    {
        public int UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

    }
}
