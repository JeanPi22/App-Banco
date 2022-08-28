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

        public void ToDeposit(int Amount) //Depositar
        {
            int AuxAmount;
            Console.WriteLine("Ingrese cuanto dinero va a depositar");
            AuxAmount = int.Parse(Console.ReadLine());
            Amount += AuxAmount;
            Console.WriteLine(Amount);
        }

        public void Withdraw(int Amount) //Retirar
        {
            int AuxAmount;
            Console.WriteLine("Ingrese el monto a retirar");
            AuxAmount = int.Parse(Console.ReadLine());
            Amount -= AuxAmount;
            Console.WriteLine(Amount);
        }

        public void ShowAmount(int Amount) //Mostrar monto
        {
            Console.Write("El dinero en la cuenta es: " + Amount);
        }

    }
}
