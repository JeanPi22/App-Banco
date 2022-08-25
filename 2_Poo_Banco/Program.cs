using System;
using System.Collections.Generic;

//Un banco tiene la necesidad de desarrollar un sistema que le permita a 3 clientes ingresar su nombre,
//hacer depósitos, hacer retiros, calcular la cantidad de dinero que hay depositada en total en el banco
//y lo que le corresponde a cada cliente de ese total.

namespace _2_Poo_Banco
{  
    public class Bank
    {
        List<User> ListUsers = new List<User>();

        public void AddName() //Agregar usuario
        {
            User UsersBank = new User();

            Console.WriteLine("Ingrese su nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Ingese su monto inicial para crear cuenta");
            int amount = int.Parse(Console.ReadLine());

            UsersBank.Name = name;
            UsersBank.Amount = amount;

            ListUsers.Add(UsersBank);

            Console.WriteLine("\nUsuario registrado correctamente");
        }

        public void ReadUser() //Leer usuario
        {
            foreach (User item in ListUsers)
            {
                Console.WriteLine(item.Name);
                //Console.WriteLine(item.Amount);
            }
        }

        public void MenuUsers() //Menú para usuarios
        {
            int options;

            Console.WriteLine("Selecciones una opción");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Retirar");
            Console.WriteLine("3 - Saldo");
            Console.WriteLine("4 - Salir");
            options = int.Parse(Console.ReadLine());

            while (options != 1 || options != 2 || options != 3)
            {
                if (options == 1)
                {
                    
                    break;
                }
                else if (options == 2)
                {
                    
                    break;
                }
                else if (options == 3)
                {
                    break;
                }
                else
                {
                    MenuBank();
                    break;
                }
            }
        }

        public void MenuBank() //Menú banco
        {           
            int options;

            Console.WriteLine("Selecciones una opción");
            Console.WriteLine("1 - Usuario");
            Console.WriteLine("2 - Registrar usuario");
            Console.WriteLine("3 - Salir");
            options = int.Parse(Console.ReadLine());

            while (options != 1 || options != 2)
            {
                if (options == 1)
                {
                    ReadUser();
                    break;
                }
                else if (options == 2)
                {
                    AddName();
                    MenuUsers();
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.MenuBank();
        }

    }
}   