using System;
using System.Collections.Generic;

//Un banco tiene la necesidad de desarrollar un sistema que le permita a 3 clientes ingresar su nombre,
//hacer depósitos, hacer retiros, calcular la cantidad de dinero que hay depositada en total en el banco
//y lo que le corresponde a cada cliente de ese total.

namespace _2_Poo_Banco
{
    //class Client
    //{
    //    public string name; //Nombre del cliente
    //    private int amount; //Monto del cliente

    //    public Client(string names)
    //    {
    //        name = names;
    //        amount = 0;
    //    }

    //    public void ToDeposit (int amounts) //Deposito
    //    {
    //        amount += amounts;
    //    }

    //    public void Withdraw (int withdraws) //Retirar
    //    {
    //        amount -= withdraws;
    //    }  
        
    //    public void ShowAmount () //Mostrar monto
    //    {
    //        Console.Write("El dinero en la cuenta es: " + amount);
    //    }

    //    class Bank
    //    {
    //        Client client1, client2, client3;

    //        public Bank()
    //        {
    //            client1 = new Client("Jean");
    //            client2 = new Client("Pierre");
    //            client3 = new Client("Juan");
    //        }
    //    }

    //    public void Menu()
    //    {
    //        int options;

    //        Console.WriteLine("Selecciones una opción");
    //        Console.WriteLine("1 - Depositar");
    //        Console.WriteLine("2 - Retirar");
    //        Console.WriteLine("3 - Saldo");
    //        options = int.Parse(Console.ReadLine());

    //        while (options != 1 || options != 2 || options != 3)
    //        {
    //            if (options == 1)
    //            {
    //                Bank bnk = new Bank();
    //                bnk.
    //            }
    //            else if (options == 3)
    //            {

    //            }
    //            else
    //            {
    //                break;
    //            }
    //        }
    //    }

        //class Bank
        //{
        //    Client client1, client2, client3;

        //    public Bank()
        //    {
        //        client1 = new Client("Jean");
        //        client2 = new Client("Pierre");
        //        client3 = new Client("Juan");
        //    }

        //    static void Main(string[] args)
        //    {
        //        Bank bnk = new Bank();
        //        Console.WriteLine("Nombre del cliente 1: " + bnk.client1.name);
        //        Console.WriteLine("Nombre del cliente 2: " + bnk.client2.name);
        //        Console.WriteLine("Nombre del cliente 3: " + bnk.client3.name);

        //        bnk.client1.ShowAmount(); //Mostrar monto
        //        bnk.client1.ToDeposit(200); //Depositar monto
        //        bnk.client1.ShowAmount(); //Mostrar monto
        //    }
        //}        
    }

class User
{
    public string Name { get; set; }    

    public User(string _name)
    {
        this.Name = _name;
    }
}

class Banco
{
    List<User> Users = new List<User>();
    public void addName() //Agregar usuario
    {
        string name = "";
        Console.WriteLine("Ingrese su nombre");
        name = Console.ReadLine();
        Users.Add(new User(name));
    }

    public void MenuUsers ()
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
                Console.WriteLine("Ingrese cuanto dinero va a depositar");
                //Users.Add (new User);
            }
            else if (options == 2)
            {
                Console.WriteLine("Ingrese el monto a retirar");
            }
            else
            {
                Console.WriteLine("Su saldo es: ");                
            }
        }
    }

    public void MenuBank()
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
                Console.WriteLine("Ingrese su nombre");
            }
            else
            {
                addName();
                MenuUsers();
                break;
            }
        }
    }
    static void Main(string[] args)
    {
        Banco bank = new Banco();
        bank.MenuBank();
    }

}   