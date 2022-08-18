using System;
using System.Collections.Generic;

//Un banco tiene la necesidad de desarrollar un sistema que le permita a 3 clientes ingresar su nombre,
//hacer depósitos, hacer retiros, calcular la cantidad de dinero que hay depositada en total en el banco
//y lo que le corresponde a cada cliente de ese total.

namespace _2_Poo_Banco
{
    
    class Banco
    {
        List<User> user = new List<User>();
        public void addName()
        {
            //string name = "";
            Console.WriteLine("Ingrese su nombre");
            user.Add(new User(name));
        }

        public void menu ()
        {
            int options;

            Console.WriteLine("Selecciones una opción");
            Console.WriteLine("1 - Usuario");
            Console.WriteLine("2 - Registrar usuario");
            Console.WriteLine("3 - Salir");
            options = int.Parse(Console.ReadLine());

            while (options!=1 || options!=2)
            {
                if (options==1)
                {

                }
                else
                {
                    addName();
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Banco bank = new Banco();
            bank.menu();
        }


    }   
  
}
