using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace BookManagement
{

    public partial class FrmDetails: Form
    {
        //var Move form without border
        int move;
        int movex;
        int movey;
        
        public FrmDetails()
        {
            InitializeComponent();
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
