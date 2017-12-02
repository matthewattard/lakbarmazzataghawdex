using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Threading;

namespace WindowsFormsApp1
{
    public class MusicNote : PictureBox
    {
        private static string rootFolder = "C:\\Users\\Ezek_\\source\\repos\\lakbarmazzataghawdex2\\Notes-Images";

        private int notePitch;
        private int duration;
        private string bNoteShape;
        private MusicStaff musicStaff1;
        bool isDragging = false;

        public MusicNote() : base()
        {
            notePitch = 0;
            duration = 0;
            bNoteShape = null;
        }

        public MusicNote(int notePitch, int duration, string bNoteShape) : base()
        {
            this.notePitch = notePitch;
            this.duration = duration;
            this.Size = new Size(35, 40);

            MakeImage(bNoteShape);

            this.MouseDown += new MouseEventHandler(StartDrag);
            this.MouseUp += new MouseEventHandler(StopDrag);
            this.MouseMove += new MouseEventHandler(NoteDrag);
            this.MouseClick += new MouseEventHandler(OnClick);
        }

        private void IntializeComponent()
        {
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }

        private void MakeImage(String bNoteShape)
        {
            this.bNoteShape = bNoteShape;
            Bitmap bmp = new Bitmap(rootFolder + bNoteShape + ".bmp");
            bmp.MakeTransparent();
            Image = bmp;
            BackColor = Color.Transparent;
        }

        public int NotePitch{
            get {
                return notePitch;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void StartDrag(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isDragging = true;
                //notePitch = e.Y;
                this.Location = new Point(this.Location.X, notePitch);
            }
        }

        private void StopDrag(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isDragging = false;
                //notePitch = e.Y;
            }
        }

        private void NoteDrag(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Top += (e.Y - this.notePitch);
                if(this.Bottom < 10)
                {
                    this.Top = -5;
                }
                else if(this.Top > 120)
                {
                    this.Top = 63;
                }
                else
                {
                    int rem = this.Top % 15;
                    int div = this.Top / 15;
                    if (rem >=7 && rem <13 )
                    {
                        div++;
                        this.Top = (div * 15) - 4; 
                    }
                    else if (rem < 7 && rem >= 3)
                    {
                        this.Top = (div * 15) + 3;
                    }
                    else if (rem >= 13)
                    {
                        div++;
                        this.Top = (div * 15);
                    }
                    else
                    {
                        this.Top = (div * 15);
                    }
                   
                }
            }
        }
        
        private void OnClick(object sender, MouseEventArgs e)
        {
            string[] names = {"SemiBreve","DotMinim","minim", "Crotchet", "Quaver" , "SemiQuaver"};
            if(e.Button == MouseButtons.Right)
            {
                for(int i = 0; i<names.Length; i++)
                {
                    if(bNoteShape == names[i])
                    {
                        if(i == (names.Length - 1))
                        {
                            i = 0;
                        }
                        MakeImage(names[i + 1]);
                        break;
                    }
                }
            }
            else if(e.Button == MouseButtons.Middle)
            {
                String folderpath = "C:\\Users\\Ezek_\\source\\repos\\lakbarmazzataghawdex2\\Notes-Sound files\\mapped";
                //timer1.Enabled = true;
                //count = 0;
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = folderpath + NotePitch + ".wav";
                //while (count <= mn.Duration)
                //    sp.Play();
                //timer1.Enabled = false;
                sp.Play();
                Thread.Sleep(Duration);
                sp.Stop();
            }
        }

        private void InitializeComponent()
        {
            this.musicStaff1 = new WindowsFormsApp1.MusicStaff();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // musicStaff1
            // 
            this.musicStaff1.Location = new System.Drawing.Point(0, 0);
            this.musicStaff1.Name = "musicStaff1";
            this.musicStaff1.Size = new System.Drawing.Size(800, 170);
            this.musicStaff1.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
