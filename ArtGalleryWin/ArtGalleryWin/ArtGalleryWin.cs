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

namespace ArtGalleryWin
{
    public partial class ArtGalleryWin : Form
    {
        //Round form edges
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


        public ArtGalleryWin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || usernameTextBox.Text != "CGS")
            {
                MessageBox.Show("The username you entered is incorrect.");
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Text) || passwordTextBox.Text != "admin")
            {
                MessageBox.Show("The password you entered is incorrect.");
            }
            else
            {
                CGSArt cgsArt = new CGSArt();
                cgsArt.Visible = true;
                cgsArt.Activate();
            }

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArtGalleryWin_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
