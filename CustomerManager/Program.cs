using CustomerManager.CustomerLogic;
using CustomerManager.Models;
using System;

namespace CustomerManager
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initalise 5 customers and print to console
            Console.WriteLine("Initialise list with 5 customers");
            Customers customer = new Customers();
            customer.PrintCustomers();

            Console.ReadLine();
            Console.Clear();

            // Add new customer
            Console.WriteLine("Add new customer");
            var editCustomer = new Customer();

            editCustomer.Id = 6;
            editCustomer.FirstName = "William";
            editCustomer.MiddleName = "Fredrick";
            editCustomer.LastName = "Taylor";
            editCustomer.Address = "62 Forest Road";
            editCustomer.PhoneNumber = 0509563912;
            editCustomer.Email = "william@gmail.com";
            editCustomer.DateCreated = DateTime.Now.ToShortDateString();

            customer.AddCustomer(editCustomer);
            customer.PrintCustomers();

            Console.ReadLine();
            Console.Clear();

            // Delete Customer
            Console.WriteLine("Delete customer");

            editCustomer.Id = 6;
            customer.DeleteCustomer(editCustomer);
            customer.PrintCustomers();






        }
    }
}
