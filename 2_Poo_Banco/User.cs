using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Poo_Banco
{
    class User
    {
        public string name { get; set; }

        public User(string _name)
        {
            this.name = _name;
        }

        ~User()
        {

        }
    }
}
