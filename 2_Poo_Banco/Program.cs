using System;
using System.Collections.Generic;

//Un banco tiene la necesidad de desarrollar un sistema que le permita a 3 clientes ingresar su nombre,
//hacer depósitos, hacer retiros, calcular la cantidad de dinero que hay depositada en total en el banco
//y lo que le corresponde a cada cliente de ese total.

namespace _2_Poo_Banco
{
    public class Bank:User
    {
        List<User> ListUsers = new List<User>();

        public void AddName() //Agregar usuario
        {
            string name;
            int amount;

            User UsersBank = new User();

            Console.WriteLine("Ingrese su nombre");
            name = Console.ReadLine();
            Console.WriteLine("Ingese su monto inicial para crear cuenta");
            amount = int.Parse(Console.ReadLine());

            UsersBank.Name = name;
            UsersBank.Amount = amount;

            ListUsers.Add(UsersBank);

            Console.WriteLine("\nUsuario registrado correctamente");
        }

        public void ReadUser() //Leer usuario
        {
            string AuxName;

            Console.WriteLine("Ingrese su nombre");
            AuxName = Console.ReadLine();

            foreach (User item in ListUsers)
            {
                if (AuxName == item.Name)
                {
                    Console.WriteLine("\nBienvenido " + item.Name);
                    MenuUsers(AuxName);
                }
            }
        }

        public void MenuBank()//Menú banco
        {
            int options;

            Console.WriteLine("\nSelecciones una opción");
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
                    MenuBank();
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        public void MenuUsers(string AuxName) //Menú para usuarios
        {
            int option;

            Console.WriteLine("\nSelecciones una opción");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Retirar");
            Console.WriteLine("3 - Saldo");
            Console.WriteLine("4 - Salir");
            option = int.Parse(Console.ReadLine());

            while (option != 1 || option != 2 || option != 3)
            {
                if (option == 1)
                {
                    foreach (User item in ListUsers)
                    {
                        if (AuxName == item.Name)
                        {
                            ToDeposit(item.Amount);
                            MenuUsers(AuxName);
                        }
                    }
                    break;
                }
                else if (option == 2)
                {
                    foreach (User item in ListUsers)
                    {
                        if (AuxName == item.Name)
                        {
                            Withdraw(item.Amount);
                            MenuUsers(AuxName);
                        }
                    }
                    break;
                }
                else if (option == 3)
                {
                    foreach (User item in ListUsers)
                    {
                        if (AuxName == item.Name)
                        {
                            ShowAmount(item.Amount);
                            MenuUsers(AuxName);
                        }
                    }
                    break;
                }
                else
                {
                    MenuBank();
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