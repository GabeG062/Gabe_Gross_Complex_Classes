using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }
        
 		public int Count
		{
  			get 
			{
 				return customers.Count;
 			}
		}

	    public void fill()
	    {
		    customers = CustomerDB.GetProducts();
	    }
	    public void Save()
	    {
		    CustomerDB.SaveCustomers(customers);
	    }

	    public void Add(Customer customer)
	    {
		    customers.Add(customer);
	    }

	    public void Add(string email, string firstName, int customerId, string lastName, string phone)
	    {
		    Product p = new Product(email, firstName, customerId, lastName, phone);
		    products.Add(p);
	    }

	    public void Remove(Customer customer)
	    {
		    customers.Remove(customer);
	    }

	    public override string ToString()
	    {
		    string output = "";
		    foreach (Customer p in customers)
		    {
			    output += p.ToString() + "\n";
		    }
		    return output;
	    }

	    public Customer this[int i]
	    {
		    get
		    {
			    return customers[i];
		    }
		    set
		    {
			    customers[i] = value;
		    }
	    }

	    public Customer this[string code]
	    {
		    get
		    {
			    foreach (Customer p in customers)
			    {
				    if (p.Code == code)
					    return p;
			    }
			    return null;
		    }
	    }

	    public static CustomerList operator +(CustomerList pl, Customer p)
	    {
		    pl.Add(p);
		    return pl;
	    }

	    public static CustomerList operator -(CustomerList pl, Customer p)
	    {
		    pl.Remove(p);
		    return pl;
	    }
    }
}