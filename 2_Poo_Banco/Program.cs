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

//class User
//{
//    public string Name { get; set; }

//    public User(string _name)
//    {
//        this.Name = _name;
//    }
//}

public class User
{
    public string name { get; set; }
    public int Amount { get; set; }

    //public User(string _name, int _amount)
    //{
    //    this.name = _name;
    //    this.Amount = _amount;
    //}
}

class Bank
{
    List<User> Users = new List<User>();

    public void AddName() //Agregar usuario
    {      
        Console.WriteLine("Ingrese su nombre");
        string name = Console.ReadLine();
        Console.WriteLine("Ingese su monto inicial para crear cuenta");
        int amount = int.Parse(Console.ReadLine());

        User UsersBank = new User();
        UsersBank.name = name;
        UsersBank.Amount = amount;

        Users.Add(UsersBank);

        Console.WriteLine("\nUsuario registrado correctamente");
    }

    public void ReadUser() //Leer usuario
    {
        foreach (User item in Users)
        {
            Console.WriteLine(item.name);
            Console.WriteLine(item.Amount);           
        }
        //for (int i = 0; i < Users.Count; i++)
        //{
        //    MenuUsers();
        //}
    }

    public void ToDeposit (User Users) //Depositar
    {
        //amount += amounts;
    }

    public void Withdraw(User Users) //Retirar
    {
        //amount -= withdraws;
    }

    public void ShowAmount(User Users) //Mostrar monto
    {
        //Console.Write("El dinero en la cuenta es: " + amount);
    }

    public void MenuUsers () //Menú para usuarios
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
                break;
            }
            else if (options == 2)
            {
                Console.WriteLine("Ingrese el monto a retirar");
                break;
            }
            else if (options == 3)
            {
                break;
            }
            else
            {
                MenuBank();          
            }
        }
    }

    static void MenuBank() //Menú banco
    {
        Bank bank = new Bank();

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
                bank.ReadUser();
                //break;
            }
            else
            {
                bank.AddName();
                bank.MenuUsers();
                break;
            }
        }
    }
    static void Main(string[] args)
    {
        MenuBank();
    }

}   