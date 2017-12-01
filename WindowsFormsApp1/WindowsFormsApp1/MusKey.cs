using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MusKey:Button
    {
        private int musicNote;
        
        public MusKey(int iNote, int x, int y): base() {
            musicNote = iNote;
            this.Location = new Point(x,y);
            this.Size = new Size(20, 80);
            this.Visible = true;
            this.BackColor = Color.White;
        }

        public MusKey() : base()
        {

        }

        public int MusicNote
        {
            get
            {
                return musicNote;
            }
        }
    }
}
