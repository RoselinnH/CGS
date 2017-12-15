using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGS;

namespace CGS
{
    public class Curator:Person
    {
       
        //variables
        private static string _curatorId;//000000000000000000
        public static string curatorId//000000000000000000000000000
        {
            get { return _curatorId; }
            set { _curatorId = value; }
        }
        private double _commission;
        public double commission//000000000000000000000000000
        {
            get { return this._commission; }
            set { this._commission = value; }
        }

        const double commRate=0.10;

        //Constructor
        public Curator(string fName, string lName,string curID):base(fName,lName)
        { commission = 0; curatorId = curID; }


        public override string ToString()
        { return string.Format("Curator \nID: " + curatorId + "\n" + base.ToString()); }

        public static string GetId()//0000000000000000
        { return curatorId; }

        //00000000000000000000
        public void SetComm(double P)//this method uses commRate to calculate the 10% 
        {
            commission = Artpiece.CalculateComm(P)*commRate;  //commission due and assign it to the currator identified by the artpiece      
            OnChangedCommission (EventArgs.Empty);
        }



        // An event that clients can use to be notified whenever the
        // elements of the list change.
        public event CommissionPaidHandler Changed;


        //overloaded Constructor
        public Curator(string fName, string lName, string curId, double commission) : base(fName, lName)
        {

        }

        //This methode check if the CommissionPaidHandler Change is null
        //If Change is not null, it passes the current curator instance and an event argument
        public virtual void OnChangedCommission (EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        public void clearComm()
        {
            commission = 0;
            OnChangedCommission(EventArgs.Empty);
        }
   
    }
}
