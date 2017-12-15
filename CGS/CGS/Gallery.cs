using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGS;

namespace CGS
{
    public class Gallery
    {
        Artists ArtistList = new Artists();
        Curators CuratorList = new Curators();
        Pieces ArtPiecesList = new Pieces();
        string display = "";
        bool success = true;
        bool failure = false;

        //Artists
        public void AddArtist(string fName, string lName, string artId)
        {
            Artist theArtist = new Artist(artId, fName, lName);//new Artist
            ArtistList.AddArtists(theArtist);
        }   
        public void ListArtists()
        {
            int i = 0;
            foreach (Artist theArtist in ArtistList)
            { i++;  display += theArtist.ToString() + "\n"; Console.WriteLine(display); }//*To Review*//will it tostring Artists
        }

        //Curator
        public void AddCurator(string fName, string lName, string curId)
        {
            Curator theCurator = new Curator(fName, lName, curId);
            CuratorList.AddCurator(theCurator);
        }
         public void ListCurators()
        {
            int i = 0;
            foreach (Curator curator in CuratorList)
            { i++;  display += curator.ToString() + "\n"; Console.WriteLine(display); }//*To review if the tostring method overrides
        }

        public bool WriteCurators()//must return a boolean value indicating success or failure
        {
            foreach (Curator curator in CuratorList)
            {
                for (int i = 0; i < CuratorList.Count; i++)
                {
                    display += curator.ToString(); Console.WriteLine(display);
                    
                    while(i != CuratorList.Count)
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
            return success;
        }

        public static bool GetCurators()//must return a boolean value indicating success or failure
        {
            Curators.ReadCurators();
            return true;
        }

        //ArtPieces
        public void AddPieces(string I, string T, string Y, double E, string aI, string cI)
        {
            Artpiece thePiece = new Artpiece(I, T, Y, E, aI, cI);//Artpiece thePiece has been created 
            ArtPiecesList.AddArtPiece(thePiece);//Artpiece thePiece has been stored into Piece ArtPiecesList list 
        }
        public void ListPieces() 
        {
            int i = 0;
            foreach (Artpiece thePiece in ArtPiecesList)
            { i++;  display += thePiece.ToString() + "\n"; Console.WriteLine(display);}

        }
        //step 4.c. This is a methode that is sapose to iterate though the the pieces to match the ID the client has entered to an id in the system

        public bool SellPieces(string ID, double P)
        {
            foreach (Artpiece piece in ArtPiecesList)
            {//not sure about this "Static"
                if (ID == piece.pieceID)
                {
                    if (piece.status == 'S')
                    { return false; }//SALE COULDNT BE COMPLEATED
                    else if (piece.status == 'D')
                    {
                        string curID = Curator.GetId();
                        piece.ChangeStatus('S');//CHANGED (pieces.status)
                        piece.PricePaid(P);
                        //pieces.CalculateComm(P);

                        //for (int i = 0; i < CuratorList.Count; i++)
                        foreach (Curator curator in CuratorList)
                        {
                            if (curID == Curator.curatorId)
                            {
                                curator.SetComm(P);
                            }
                        }
                        return true;
                    }

                }
            }
            return true;
        }
        
        public bool SetStatus(Artpiece piece,char S)
        {
            if (S == 'D')
            {
                piece.status = 'D';
            }
            piece.ChangeStatus(S);
            return success;
        }
    }
} 

