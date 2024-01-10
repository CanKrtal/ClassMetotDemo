namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.name = "Can";
            customer1.surname = "Kartal";
            customer1.tcNumber = "3123124124";

            Customer customer2 = new Customer();
            customer2.name = "Ahmet";
            customer2.surname = "Uçar";
            customer2.tcNumber = "12451252124";

            Customer customer3 = new Customer();
            customer3.name = "Cansu";
            customer3.surname = "Yıldız";
            customer3.tcNumber = "215437345234";

            Customer[] customers = new Customer[] { customer1, customer2, customer3};
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.CustomerList(customers);

        }
    }
}
