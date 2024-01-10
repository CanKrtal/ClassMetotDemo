using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.name + " " + customer.surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.name + " " + customer.surname);
        }
        public void CustomerList(Customer[] customers) 
        {
            Console.WriteLine("Müşteriler Listelendi : ");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.name + " " + customer.surname);
            }
        }  
    }
}
