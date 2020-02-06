using System;

namespace CRMBIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //create Customer
            Customer c1 = new Customer(1);
            

            CustomerRepository cr = new CustomerRepository();
            //Add Customer
            cr.Save(c1);

            //Customer Information 
            Customer c2 = cr.Retrieve(1);
            Console.WriteLine(c2.CustomerId + " " + c2.EmailAddress+" Fullname:+"c2.FullName);

            //Order History

            OrderRepository or = new OrderRepository();
            OrderDisplay od = or.RetrieveOrderDisplay(10);
            Console.WriteLine(od.FirstName+" "+od.LastName);
        }
    }
}
