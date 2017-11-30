using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public class MusicStaff:Panel
    {
        private ArrayList musicNotes;
        private Button play;
        private Button clear;
        private MusicNote mn= new MusicNote();

        public MusicStaff():base()
        {
            musicNotes = new ArrayList();
            AddButtons();
            this.Paint += MusicStaff_Paint;
            this.Size = new Size(800, 170);
        }

        private void AddButtons()
        {
            play = new Button();
            play.Location = new Point(700, 10);
            play.Text = "Play";
            play.MouseClick += Play_MouseClick;
            clear = new Button();
            clear.Location = new Point(700, 40);
            clear.Text = "Clear";
            clear.MouseClick += Clear_MouseClick;
            this.Controls.Add(play);
            this.Controls.Add(clear);
        }

        private void Clear_MouseClick(object sender, MouseEventArgs e)
        {
            musicNotes.Clear();
            this.Controls.Clear();
            AddButtons();
        }

        private void Play_MouseClick(object sender, MouseEventArgs e)
        {
            String folderpath = "C:\\Users\\Matthew\\OneDrive\\University\\Semester 1 - year 2\\OOP assigment\\Notes-Sound files\\mapped\\";
            SoundPlayer sp = new SoundPlayer();
            foreach(Object obj in this.Controls)
            {
                if(obj.GetType() == mn.GetType())
                {
                    MusicNote musicNote = (MusicNote) obj;
                    sp.SoundLocation = folderpath + musicNote.NotePitch + ".wav";
                    sp.Play();
                    Thread.Sleep(musicNote.Duration);
                }
            }
        }

        private void MusicStaff_Paint(object sender, PaintEventArgs e)
        {
            Pen blackpen = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;
            for (int k = 2; k <= 6; k++)
                g.DrawLine(blackpen, this.Left, k * 15, 650, k * 15);
            g.Dispose();
        }

        private void AddNote(MusicNote musicNote)
        {
            musicNotes.Add(musicNote);
            this.Controls.Add(musicNote);
        }
    }
}
