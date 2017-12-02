﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MusicKeyboard: MusicStaff
    {
        private Timer timer1;
        private System.ComponentModel.Container components;

        private int count;
        private int xLoc;
        private int yLoc;
        SoundPlayer sp;
        

        public MusicKeyboard() : base()
        {
            timer1 = new Timer();
            MusKey mk;
            BlackMusKey bmk;
            KeyBoardEntries ke;
            int[] whitePitch = { 1, 3, 5, 6, 8, 10, 12, 13, 15, 17, 18, 20, 22, 24 };
            for (int k = 0; k < whitePitch.Length; k++)
            {
                
                int pitch = whitePitch[k];
                int xPos = k * 20;
                mk = new MusKey(pitch, xPos, 20);
                ke = new KeyBoardEntries(timer1, count,xLoc,yLoc);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                mk.MouseUp += new MouseEventHandler(this.button1_MouseUp);
               mk.KeyDown += new KeyEventHandler(ke.button1_KeyDown);
               mk.KeyUp += new KeyEventHandler(ke.button1_KeyUp);
                this.Controls.Add(mk);
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
                this.Controls.Add(bmk);
                this.Controls[this.Controls.Count - 1].BringToFront();
            }

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            BlackMusKey bmk = new BlackMusKey(2, 1, 1);
            foreach (MusKey mk in this.Controls)
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
                        AddNote(mn);
                        xLoc = xLoc + 40;
                    }
                }
            }

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            String folderpath = "C:\\Users\\Ezek_\\source\\repos\\lakbarmazzataghawdex2\\Notes-Sound files";
            sp = new SoundPlayer();
            foreach (Object obj in this.Controls)
            {
             //   if(obj.GetType() =MusKey.getType())
               // {

              //  }
                MusKey mk = new MusKey();
                if (sender == mk)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        timer1.Enabled = true;
                        count = 0;
                        timer1.Start();
                        sp.SoundLocation = folderpath + mk.MusicNote.ToString() + ".wav";
                        sp.Play();
                    }
                }   
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
        }

        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            this.ResumeLayout(false); 
        } 
       

        
    }
}
