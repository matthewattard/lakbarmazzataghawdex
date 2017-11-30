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
        int count;
        int xLoc = 50;
        int yLoc = 10;
        SoundPlayer sp;
        MusicStaff musicStaff;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            //the music staff panel
            musicStaff = new MusicStaff();
            musicStaff.Location = new Point(10, 10);
            musicStaff.Show();
            this.Controls.Add(musicStaff);

            MusKey mk;
            BlackMusKey bmk;
            int[] whitePitch = {1, 3, 5, 6, 8, 10, 12, 13, 15, 17, 18, 20, 22, 24 };
            for (int k = 0; k < whitePitch.Length; k++)
            {
                int pitch = whitePitch[k];
                int xPos = k * 20;
                mk = new MusKey(pitch, xPos, 20);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                mk.MouseUp += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(mk);
            }
            int[] blackPitch = { 2, 4, 7, 9, 11, 14, 16, 19, 21, 23 };
            int[] xPosArray = { 10, 30, 70, 90, 110, 150, 170, 210, 230, 250 };
            for (int k = 0; k < blackPitch.Length; k++)
            {
                int pitch = blackPitch[k];
                int xPos = xPosArray[k];
                bmk = new BlackMusKey(pitch, xPos, 20);
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                bmk.MouseUp += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(bmk);
                this.panel1.Controls[this.panel1.Controls.Count - 1].BringToFront();
            }

            button1.Hide();

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            String folderpath = "C:\\Users\\Matthew\\OneDrive\\University\\Semester 1 - year 2\\OOP assigment\\Notes-Sound files\\mapped\\";
            sp = new SoundPlayer();
            foreach (MusKey mk in this.panel1.Controls)
            {
                if (sender == mk)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        timer1.Enabled= true;
                        count = 0;
                        timer1.Start();
                        sp.SoundLocation = folderpath + mk.MusicNote.ToString() + ".wav";
                        sp.Play();
                    }
                }
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            BlackMusKey bmk = new BlackMusKey(2, 1, 1);
            foreach (MusKey mk in this.panel1.Controls)
            {
                if (sender == mk)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        
                       timer1.Enabled = false;
                        sp.Stop();
                        string bNoteShape = null;
                        int duration = 0;
                        if (count >= 11)
                        {
                            bNoteShape = "SemiBreve";
                            duration = 11;
                        }
                        else if (count >= 9 && count <= 10)
                        {
                            bNoteShape = "DotMinim";
                            duration = (9 + 10) / 2;
                        }
                        else if (count >= 7 && count <= 8)
                        {
                            bNoteShape = "minim";
                            duration = (7 + 8) / 2;
                        }
                        else if (count >= 4 && count <= 6)
                        {
                            bNoteShape = "Crotchet";
                            duration = (4 + 6) / 2;
                        }
                        else if (count >= 2 && count <= 3)
                        {
                            bNoteShape = "Quaver";
                            duration = (2 + 3) / 2;
                        }
                        else
                        {
                            bNoteShape = "SemiQuaver";
                            duration = 1;
                        }

                        if (mk.GetType() == bmk.GetType())
                        {
                            bNoteShape += "Sharp";
                        }
                        MusicNote mn = new MusicNote(mk.MusicNote, duration, bNoteShape);
                        mn.Location = new Point(xLoc, yLoc);
                        musicStaff.AddNote(mn);
                        xLoc = xLoc + 40;
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
        }


        private void MusicNote_Click(object sender, MouseEventArgs e)
        {
            foreach (MusicNote mn in this.musicStaff.Controls)
            {
                if (sender == mn)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        
                    }
                }
            }
        }
    }
}
