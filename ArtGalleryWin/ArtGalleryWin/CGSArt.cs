using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CGS;
namespace ArtGalleryWin
{
    public partial class CGSArt : Form
    {
        string firstName;
        string lastName;
        string curatorId;
        string artistID;
        string artpieceID;
        string title;
        string year;
        double value;
        double price;
        char status;

        Gallery gal =new Gallery();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );


        public CGSArt()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            artPieces_panel.Visible = false;
            curator_Panel.Visible = false;
            artists_Panel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CGSArt_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Art Pieces
        private void button3_Click(object sender, EventArgs e)
        {
            artPieces_panel.Visible = true;
            curator_Panel.Visible = false;
            artists_Panel.Visible = false;

            file_label.Text = "Art Pieces Files";
        }

        private void artPieces_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void addArt_button_Click(object sender, EventArgs e)
        {
            artpieceID = ID_textBox.Text;
            title = title_textBox.Text;
            year = year_textBox.Text;
            value = Convert.ToDouble(value_textBox.Text);
            artistID = artID_textBox.Text;
            curatorId = curID_textBox.Text;
            gal.AddPieces(artpieceID, title, year, value, artistID, curatorId);

            if (display_radioButton.Checked = true)
            {
                
            }
            else if (storage_radioButton.Checked = true)
            {

            }
        }

        private void Sell_button_Click(object sender, EventArgs e)
        {
            gal.SellPieces(artpieceID, price);
        }

        private void list_button_Click(object sender, EventArgs e)
        {
            gal.ListPieces();
            
        }

        private void artPieces_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gal.ListPieces();
        }

        //Curators
        private void button1_Click(object sender, EventArgs e)
        {
            curator_Panel.Visible = true;
            artPieces_panel.Visible = false;
            artists_Panel.Visible = false;

            file_label.Text = "Curators Files";
        }
        private void curator_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCur_button_Click(object sender, EventArgs e)
        {
            firstName = curFN_textBox.Text;
            lastName = curLN_textBox.Text;
            curatorId = curID_textBox2.Text;
            gal.AddCurator(firstName,lastName,curatorId);
        }

        //Artists
        private void Artists_button_Click(object sender, EventArgs e)
        {
            artists_Panel.Visible = true;
            artPieces_panel.Visible = false;
            curator_Panel.Visible = false;

            file_label.Text = "Artists Files";
            
        }

        private void addArtist_button_Click(object sender, EventArgs e)
        {
            firstName = artFN_textBox.Text;
            lastName = artLN_textBox.Text;
            artistID = artID_textBox2.Text;

            gal.AddArtist(firstName, lastName, artistID);
        }

        private void artists_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void file_label_Click(object sender, EventArgs e)
        {
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
