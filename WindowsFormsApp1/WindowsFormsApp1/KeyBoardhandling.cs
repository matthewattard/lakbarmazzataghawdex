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




namespace WindowsFormsApp1
{
    public partial class KeyBoardEntries : MusicStaff
    {
        MusKey mk;
        SoundPlayer sp;
        public KeyBoardEntries()
        {

            void panel1_KeyDown(object sender, KeyEventArgs e)

            {
                string folderpath = "C:\\Users\\Ezek_\\Documents\\C#\\OOP assigment\\Notes-Sound files\\mapped";
                sp = new SoundPlayer();
                if (e.KeyCode == Keys.Q)
                {

                    sp.SoundLocation = folderpath + "1.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.W)
                {
                    sp.SoundLocation = folderpath + "2.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.E)
                {
                    sp.SoundLocation = folderpath + "3.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.R)
                {
                    sp.SoundLocation = folderpath + "4.wav";
                    sp.Play();

                }
                else if (e.KeyCode == Keys.T)
                {
                    sp.SoundLocation = folderpath + "5.wav";
                    sp.Play();

                }
                else if (e.KeyCode == Keys.Y)
                {
                    sp.SoundLocation = folderpath + "6.wav";
                    sp.Play();

                }
                else if (e.KeyCode == Keys.U)
                {
                    sp.SoundLocation = folderpath + "7.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.I)
                {
                    sp.SoundLocation = folderpath + "8.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.O)
                {
                    sp.SoundLocation = folderpath + "9.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.P)
                {
                    sp.SoundLocation = folderpath + "10.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.A)
                {
                    sp.SoundLocation = folderpath + "11.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.S)
                {
                    sp.SoundLocation = folderpath + "12.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.D)
                {
                    sp.SoundLocation = folderpath + "13.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.F)
                {
                    sp.SoundLocation = folderpath + "14.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.G)
                {
                    sp.SoundLocation = folderpath + "15.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.H)
                {
                    sp.SoundLocation = folderpath + "16.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.J)
                {
                    sp.SoundLocation = folderpath + "17.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.K)
                {
                    sp.SoundLocation = folderpath + "18.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.L)
                {
                    sp.SoundLocation = folderpath + "19.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.I)
                {
                    sp.SoundLocation = folderpath + "20.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.OemSemicolon)
                {
                    sp.SoundLocation = folderpath + "21.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.OemQuotes)
                {
                    sp.SoundLocation = folderpath + "22.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.Z)
                {
                    sp.SoundLocation = folderpath + "23.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.X)
                {
                    sp.SoundLocation = folderpath + "24.wav";
                    sp.Play();
                }
                else if (e.KeyCode == Keys.C)
                {
                    sp.SoundLocation = folderpath + "25.wav";
                    sp.Play();
                }


            }
        }
    }
}




