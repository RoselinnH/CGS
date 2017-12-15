using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS
{
    //Artist
    public class Artist:Person
    {
        private string _artistID;
        public string artistID
        {
            get { return _artistID; }
            set { _artistID = value.ToString(); }
        }

        public Artist (string artId, string fName, string lName ):base(fName,lName)
        { artistID = artId;}

        public string GetId(string artistID)
        { return artistID; }

        //public string getArtistId
        //{ get { return artistID; } }

        public override string ToString()
        { return string.Format("Artist \nID: {0}", this.artistID +"\n"+ base.ToString());}
    }
}