using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGS;
//using System.Diagnostics.Tracing;

namespace ArtGallery
{
    class ArtGallery
    {
       static string fName;
       static string lName;
       static string artistID;
       static string curatorId;
        static string artPieceID;
        static string pieceTitle;
        static string pieceYear;
        static double pieceValue;
        static double piecePrice;
        static int countVal;

//Interface 
        static void Main(string[] args)
        {
            Gallery gal = new Gallery();
            Curator curator = new Curator(fName, lName, curatorId);
            EventListener listener = new EventListener(curator);

            //interface
            Title();
            Menu();

            int maxMenuItems = 7;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems)
            {
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good)
                {
                    
                    Console.Clear();
                    switch (selector)
                    {
                        case 1:
                            //interface
                            // Adding a new artist
                            Console.WriteLine("Enter the artist's first name: ");
                            fName = Console.ReadLine();
                            Console.WriteLine("Enter the artist's last name: ");
                            lName = Console.ReadLine();
                            Console.WriteLine("Enter the artist's ID number: ");
                            artistID = Console.ReadLine();
                            gal.AddArtist(fName, lName, artistID);

                            DrawLine();
                            Console.WriteLine("The artist has been added to the list");
                            DrawLine();
                            gal.ListArtists();
                            DrawLine();
                            break;

                        case 2:

                            //Adding a new curator
                            Console.WriteLine("Enter the curator's first name: ");
                            fName = Console.ReadLine();
                            Console.WriteLine("Enter the curator's last name: ");
                            lName = Console.ReadLine();
                            Console.WriteLine("Enter the curator's ID number: ");
                            curatorId = Console.ReadLine();
                            gal.AddCurator(fName, lName, curatorId);
                            DrawLine();
                            Console.WriteLine("The curator has been added to the list");
                            DrawLine();
                            gal.ListCurators();
                            break;

                        case 3:
                            //Adding the artpiece
                            Console.WriteLine("Enter the artpiece's ID number: ");
                            artPieceID = Console.ReadLine();
                            Console.WriteLine("Enter the artpiece's Title: ");
                            pieceTitle = Console.ReadLine();
                            Console.WriteLine("Enter the artpiece's year: ");
                            pieceYear = Console.ReadLine();
                            Console.WriteLine("Enter the artpiece's value: ");
                            pieceValue = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the artpiece's artist ID number: ");
                            artistID = Console.ReadLine();
                            Console.WriteLine("Enter the artpiece's curator ID number: ");
                            curatorId = Console.ReadLine();
                            gal.AddPieces(artPieceID, pieceTitle, pieceYear, pieceValue, artistID, curatorId);
                            DrawLine();
                            Console.WriteLine("The artpiece has been added to the list.");
                            DrawLine();
                            gal.ListPieces();
                            break;

                        case 4:
                            //Display Artpiece list
                            gal.ListPieces();
                            break;

                        case 5:
                            //Selling the artpiece
                            Console.WriteLine("Enter the ID number of the artpiece being sold : ");
                            artPieceID = Console.ReadLine();
                            Console.WriteLine("Enter the price paid for the artpeice being sold: ");
                            piecePrice = Convert.ToDouble(Console.ReadLine());

                            gal.SellPieces(artPieceID, piecePrice);//sell piece sells the piece and calls for curator commission
                            curator.clearComm();// resets commission to 0

                            DrawLine();
                            Console.WriteLine("The artpiece has been sold.");
                            DrawLine();
                            gal.ListPieces();
                            DrawLine();
                            gal.ListCurators();
                            break;

                        case 6:
                            //Calling all information
                            DrawLine();
                            gal.ListArtists();
                            DrawLine();
                            gal.ListCurators();
                            DrawLine();
                            gal.ListPieces();
                            DrawLine();
                            break;

                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            if (selector != maxMenuItems)
                            {
                                ErrorMessage();
                            }
                            break;

                    }

                }
                else
                {
                    ErrorMessage();
                }
                Console.ReadKey();

            }
        }
     
        private static void ErrorMessage()
        {
            Console.WriteLine("Typing error, press any key to continue.");
        }

        private static void Title()
        {
            
            string line= "___________________________";
            Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
            Console.WriteLine(line);

            string title = "Computerized Gallery System";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
            Console.WriteLine(line);

        }
        private static void DrawLine()
        {
            Console.WriteLine("___________________________");
        }
        public static void Menu()
        {
            DrawLine();
            Console.WriteLine(" 1. Add an artist.");
            Console.WriteLine(" 2. Add a curator.");
            Console.WriteLine(" 3. Add an art piece");
            Console.WriteLine(" 4. Display all art pieces");
            Console.WriteLine(" 5. Sell an artpiece");
            Console.WriteLine(" 6. View lists");
            Console.WriteLine(" 7. Quit the application");
            DrawLine();
            Console.WriteLine("Please Enter the digit associated to the action you would like to make.");
            DrawLine();
        }
    }
}
