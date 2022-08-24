using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Poo_Banco
{
    public class User
    {
        public string name { get; set; }
        public int Amount { get; set; }

        public User(string _name, int _amount)
        {
            this.name = _name;
            this.Amount = _amount;
        }

        ~User()
        {

        }
    }
}
