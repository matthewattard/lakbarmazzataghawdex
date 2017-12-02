using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MusicKeyboard musicKeyboard;

        public Form1()
        {
          InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////the music staff panel
            //musicStaff = new MusicStaff();
            //musicStaff.Location = new Point(10, 10);
            //this.Controls.Add(musicStaff);


            //the music keyboard panel
            musicKeyboard = new MusicKeyboard();
            musicKeyboard.Location = new Point(10, 250);
            


        }
    }
}
