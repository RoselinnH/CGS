using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGS;

namespace CGS
{
    using System.Collections;
    public delegate void CommissionPaidHandler(object source, EventArgs e);
     
    public class EventListener
    {
        //EL includes a new curator instance
        Curator eventCurator;

        //Constructor receives a Curator instance 
        public EventListener(Curator theCurator)
        {
            //it assigns the received instance to the local curatorn instance 
            //******& attaches the currator's Changed event in the consructor
            eventCurator = theCurator;
        }

        private void CommissionOnChanged(Curator eventCurator, EventArgs e)
        {
            Console.WriteLine("Curator " + eventCurator + " has recieved their comission.");
        }

        public void Detatch(Curator curator)
        {
            curator = null;
        }
    }
}
