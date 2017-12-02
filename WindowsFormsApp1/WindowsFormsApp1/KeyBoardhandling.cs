using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Media;
using System.Drawing;




    
namespace WindowsFormsApp1
{
    public partial class KeyBoardEntries
    {
        Timer timer;
        int count;
        
        SoundPlayer sp;
        int xLoc;
        int yLoc;
        enum keys { Q, W, E, R, T, Y, U, I, O, P, A,S, D, F, G, H, J, K, L,Z, X,C,V,B };

        internal IEnumerable<MusKey> Controls { get; private set; }

        public KeyBoardEntries(Timer timer, int count, int xLoc, int yLoc)
        {
            this.count = 0;
            this.timer= null;
            this.xLoc = 0;
            this.yLoc = 0;


        }
        public void button1_KeyDown(object sender, KeyEventArgs e)

        {
            string folderpath = "C:\\Users\\Ezek_\\Documents\\C#\\OOP assigment\\Notes-Sound files\\mapped";
            sp = new SoundPlayer();
            if (e.KeyCode == Keys.Q)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "1.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.W)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "2.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.E)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "3.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.R)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "4.wav";
                sp.Play();

            }
            else if (e.KeyCode == Keys.T)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "5.wav";
                sp.Play();

            }
            else if (e.KeyCode == Keys.Y)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "6.wav";
                sp.Play();

            }
            else if (e.KeyCode == Keys.U)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "7.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.I)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "8.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.O)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "9.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.P)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "10.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.A)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "11.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.S)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "12.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.D)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "13.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.F)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "14.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.G)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "15.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.H)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "16.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.J)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "17.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.K)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "18.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.L)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "19.wav";
                sp.Play();
            }
            
            else if (e.KeyCode == Keys.OemSemicolon)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "20.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.OemQuotes)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "21.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.Z)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "22.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.X)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "23.wav";
                sp.Play();
            }
            else if (e.KeyCode == Keys.C)
            {
                timer.Enabled = true;
                count = 0;
                timer.Start();
                sp.SoundLocation = folderpath + "24.wav";
                sp.Play();
            }



        }
        //enum Try { Q,W,E, R, T, Y, U, I, O, P, A, S, D, F, G, H, J, K, L, Z, X, C, V, B };
        public void button1_KeyUp(object sender, KeyEventArgs e)
        {
           
        BlackMusKey bmk = new BlackMusKey(2, 1, 1);
            foreach (MusKey mk in this.Controls)
            {
                if (sender == mk)
                {
                    for (int i = 1; i < 24; i++) 
                       {
                          
                        if (e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E || e.KeyCode == Keys.R || e.KeyCode == Keys.T || e.KeyCode == Keys.Y || e.KeyCode == Keys.U || e.KeyCode == Keys.I || e.KeyCode == Keys.O || e.KeyCode == Keys.P || 
                            e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.J
                            || e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.B)
                        {

                            timer.Enabled = false;
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
                           
                            xLoc = xLoc + 40;
                        }
                    }
                }
            }
        }

    }
}




