using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
    public class Customer
    {
        private int id;
        private string first;
        private string last;
        private string mail;
        private string phoneNum;

        public Customer() { }

        public Customer(string email, string firstName, int customerId, string lastName, string phone )
        {
            Id = customerId;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Email
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }

        public string FirstName
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public string LastName
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

        public string Phone
        {
            get
            {
                return phoneNum;
            }
            set
            {
                phoneNum = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Id: {0} Email: {1} Firstname: {2} Lastname: {3} Phone: {4}", Id, Email, FirstName, LastName, Phone);
        }
public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
                return false;
            else
            {
                Product other = (Customer)obj;
                return other.Id == Id &&
                    other.FirstName == FirstName &&
                    other.Email == Email &&
                    other.LastName == LastName &&
                    other.Phone == Phone;
            }
        }
        
        public override int GetHashCode()
        {
            return 13 + 7 * id.GetHashCode() +
                7 * first.GetHashCode() +
                7 * last.GetHashCode() +
                7 * mail.GetHashCode() + 
                7 * phoneNum.GetHashCode();
        }
        
        
        public static bool operator ==(Customer p1, Customer p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Customer p1, Customer p2)
        {
            return !p1.Equals(p2);
        }
    }
}