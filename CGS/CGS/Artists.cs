using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CGS
{
    public class Artists : CollectionBase
    {
        public void AddArtists(Artist theArtist)
        { List.Add(theArtist); }

        public Artists this[int index]
        {
            get { return ((Artists)List[index]); }
            set { List[index] = value; }
        }
    }
}

