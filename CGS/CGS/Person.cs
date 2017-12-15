using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    //Common to all humen
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string fName, string lName)
        { firstName = fName; lastName = lName;}

        public string getName
        {
            get { return this.firstName + this.lastName; }
        }

        public virtual string ToString()
        { return string.Format("Name: {0} {1}", firstName, lastName); }
    }
}
