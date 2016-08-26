using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    // This class is immutable. After an object is created, 
    // it cannot be modified from outside the class. It uses a 
    // constructor to initialize its properties. 

    // This class is immutable. After an object is created, 
    // it cannot be modified from outside the class. It uses a 
    // static method and private constructor to initialize its properties.    
    public class Contact2
    {
        // Read-only properties. 
        public string Name { get; private set; }
        public string Address { get; private set; }

        // Private constructor. 
        private Contact2(string contactName, string contactAddress)
        {
            Name = contactName;
            Address = contactAddress;
        }

        // Public factory method. 
        public static Contact2 CreateContact(string name, string address)
        {
            return new Contact2(name, address);
        }
    }

    /* Output:
        Terry Adams, 123 Main St.
        Fadi Fakhouri, 345 Cypress Ave.
        Hanying Feng, 678 1st Ave
        Cesar Garcia, 12 108th St.
        Debra Garcia, 89 E. 42nd St.
    */
}
