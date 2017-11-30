using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class BlackMusKey: MusKey
    {
        public BlackMusKey(int iNote, int x, int y) : base(iNote,x,y)
        {
            this.BackColor = Color.Black;
            this.Size = new Size(20, 40);
        }
    }
}
