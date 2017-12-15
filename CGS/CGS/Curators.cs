using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    public class Curators:CollectionBase
    {
        public void AddCurator(Curator theCurator)
        {List.Add(theCurator); }

        public Curators this[int index]
        {
            get { return ((Curators)List[index]); }
            set { List[index] = value; }
        }

        public static bool ReadCurators()//must return a boolean value indicating success or failure
        {
            string[] Curarray = new string [1000];//issue with array size
            for (int i= 0; i< Curarray.Length; i++)
            {
                string val;
                val = Console.ReadLine();
                Curarray[i] = val;
                /*AddCurator(val)*/;//from the array, the method adds each currator to the Curators collection
            }
            return true;
        }
    }
}
