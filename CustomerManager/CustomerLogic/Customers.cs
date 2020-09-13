using ConsoleTables;
using CustomerManager.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CustomerManager.CustomerLogic
{
    class Customers
    {

        List<Customer> customers = new List<Customer>();

        public List<Customer> MyProperty { get; set; }

        

        public Customers()
        {
            
            CustomerList();
        }

        private void CustomerList()
        {
            customers.Add(new Customer() { Id = 1, FirstName = "Jack", MiddleName = "David", LastName = "Taylor", Address = "12 Kings Street", PhoneNumber = 01283123123, Email = "jack@gmail.com", DateCreated = "9/09/2020" });
            customers.Add(new Customer() { Id = 2, FirstName = "Tom", MiddleName = "Harry", LastName = "Williams", Address = "92 Regent Street", PhoneNumber = 01509453923, Email = "tom@gmail.com", DateCreated = "8/09/2020" });
            customers.Add(new Customer() { Id = 3, FirstName = "Sally", MiddleName = "Jane", LastName = "Howard", Address = "4 Park Road", PhoneNumber = 036493012, Email = "sally@gmail.com", DateCreated = "8/09/2020" });
            customers.Add(new Customer() { Id = 4, FirstName = "Helen", MiddleName = "Mary", LastName = "Parker", Address = "103 Grace Street", PhoneNumber = 0605333888, Email = "helen@gmail.com", DateCreated = "10/09/2020" });
            customers.Add(new Customer() { Id = 5, FirstName = "Zack", MiddleName = "John", LastName = "Loomer", Address = "17 Leaf Way", PhoneNumber = 01283782551, Email = "zack@gmail.com", DateCreated = "10/09/2020" });

            
        }

        //public Customers()
        //{
        //    customers.Add(new Customer() { Id = 1, FirstName = "Jack", MiddleName = "David", LastName = "Taylor", Address = "12 Kings Street", PhoneNumber = 01283123123, Email = "jack@gmail.com", DateCreated = "9/09/2020" });
        //    customers.Add(new Customer() { Id = 2, FirstName = "Tom", MiddleName = "Harry", LastName = "Williams", Address = "92 Regent Street", PhoneNumber = 01509453923, Email = "tom@gmail.com", DateCreated = "8/09/2020" });
        //    customers.Add(new Customer() { Id = 3, FirstName = "Sally", MiddleName = "Jane", LastName = "Howard", Address = "4 Park Road", PhoneNumber = 036493012, Email = "sally@gmail.com", DateCreated = "8/09/2020" });
        //    customers.Add(new Customer() { Id = 4, FirstName = "Helen", MiddleName = "Mary", LastName = "Parker", Address = "103 Grace Street", PhoneNumber = 0605333888, Email = "helen@gmail.com", DateCreated = "10/09/2020" });
        //    customers.Add(new Customer() { Id = 5, FirstName = "Zack", MiddleName = "John", LastName = "Loomer", Address = "17 Leaf Way", PhoneNumber = 01283782551, Email = "zack@gmail.com", DateCreated = "10/09/2020" });
        //}
        public void AddCustomer(Customer customer)
        {
            bool validEmailAddress = ValidateEmail(customer.Email);
            var result = customers.Find(m => m.Email == customer.Email);

            if (result != null)
            {
                Console.WriteLine("Entry already exists");
            }

            if (validEmailAddress == false)
            {
                Console.WriteLine("Email address is invalid");
            }

            if (result == null && validEmailAddress == true)
            {
                customers.Add(customer);
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            var result = customers.Find(m => m.Id == customer.Id);

            if (result != null)
            {
                customers.Remove(result);
            }
            else
            {
                Console.WriteLine("Customer was not found");
            }
        }

        public bool ValidateEmail(string customerEmail)
        {
            return Regex.IsMatch(customerEmail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public void PrintCustomers()
        {
            var table = new ConsoleTable("Id", "Firstname", "Middlename", "Lastname", "Address", "Email", "PhoneNumber", "DateCreated");

            foreach (Customer cust in customers)
            {
                table.AddRow(cust.Id, cust.FirstName, cust.MiddleName, cust.LastName, cust.Address, cust.Email, cust.PhoneNumber, cust.DateCreated);
            }
            Console.WriteLine(table);
        }


    }
}
