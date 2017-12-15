using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGS;

namespace CGS
{
    public class Pieces : CollectionBase
    {

        public void AddArtPiece(Artpiece thePiece)
        { List.Add(thePiece); }

        public Pieces this[int index]
        {
            get { return ((Pieces)List[index]); }
            set { List[index] = value; }
        }

        
    }           
}

