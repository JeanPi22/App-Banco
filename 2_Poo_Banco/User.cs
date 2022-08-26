using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Poo_Banco
{
    public class User
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public User()
        {
            this.Name = "";
            this.Amount = 0;
        }

        public void ToDeposit() //Depositar
        {

            Console.WriteLine("Ingrese cuanto dinero va a depositar");
            int AuxAmount = int.Parse(Console.ReadLine());
            Amount += AuxAmount;
            Console.WriteLine(AuxAmount);
        }       

        public void Withdraw() //Retirar
        {
            //amount -= withdraws;
            Console.WriteLine("Ingrese el monto a retirar");
            //Amount -= this.Amount;
        }

        public void ShowAmount() //Mostrar monto
        {
            //Console.Write("El dinero en la cuenta es: " + Amount);
        }

    }
}
