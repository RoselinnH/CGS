using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGS;

namespace CGS
{
    public class Artpiece
    {
        //To see if .ToString is needed or it should be removes as doubles do not require a tosting
        private string _piece_ID;
        public string pieceID
        {
            get { return this._piece_ID; }
            set { this._piece_ID = value; }
        }
        private string _title;
        public string title
        {
            get { return this._title; }
            set { this._title = value; }
        }
        private string _year;
        public string year
        {
            get { return this._year; }
            set { this._year = value; }
        }
        private  double _price = 0;
        public  double price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        private static double _estimate;
        public static double estimate
        {
            get { return _estimate; }
            set { _estimate = value; }
        }
        private string _artistID;
        public string artistID
        {
            get { return this._artistID; }
            set { this._artistID = value; }
        }
        private  string _curatorID;
        public  string curatorID
        {
            get { return this._curatorID; }
            set { this._curatorID = value; }
        }
        private  char _status = 'D';
        public char status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        //price and  status SHOULD NOT be in the constructor
        public Artpiece(string I, string T, string Y, double E, string aI, string cI)
        {
            pieceID = I;
            title = T;
            year = Y;
            estimate = E;
            artistID = aI;
            curatorID = cI;
        }

        public string ToString()
        {return string.Format("Artpiece ID: {0}\nTitle: {2}\nYear: {3}\nPrice: {4:C}\nEstimate: {5:C}\nArtist Id: {6}\nCurator ID: {7}\nStatus: {8}", pieceID,title,year, price, estimate, artistID, curatorID, status); }

        public void ChangeStatus(char S)
        {
            status = S;
            status = 'S';
        }

        public  void PricePaid(double P)
        {
            price = P;
        }

        public static double CalculateComm(double price)//this value returns to SetComm in Curator class 
        {
            return (estimate - price) /0.25;  
        }
    }
}
