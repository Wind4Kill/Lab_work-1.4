using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Laboratory_work_1._4
{
    public partial class Form1 : Form
    {
        System.Drawing.Pen newPen=new System.Drawing.Pen(System.Drawing.Color.Black);
        Graphics gr;
        Sound sound = new Sound();
        bool isStart = false;
        string[] paths=new string[] { "D:\\Programming C#\\Laboratory_work_1.4\\Laboratory_work_1.4\\Atlantic_Lights_Hans_Zimmer_-_Interstellar_Main_Theme__musmore.com_.wav", "D:\\Programming C#\\Laboratory_work_1.4\\Laboratory_work_1.4\\Tom-Odell-Another-Love.wav", "D:\\Programming C#\\Laboratory_work_1.4\\Laboratory_work_1.4\\surf-curse-freaks.wav", "D:\\Programming C#\\Laboratory_work_1.4\\Laboratory_work_1.4\\imagine-dragons-radioactive_mp3bit.cc_.wav", "D:\\Programming C#\\Laboratory_work_1.4\\Laboratory_work_1.4\\a-ha-take-on-me-original.wav"};


        public Form1()
        {
            InitializeComponent();

        }


        public class Sound
        {
            private MediaPlayer m_mediaPlayer;
            
            public void Play(string filename, int volume, int speed)
            {
                m_mediaPlayer = new MediaPlayer();
                
                m_mediaPlayer.Open(new Uri(filename));
                SetVolume(volume);
                SetSpeed(speed);
                m_mediaPlayer.Play();


            }

            public void Stop()
            {
               
                
                    m_mediaPlayer.Close();
                    m_mediaPlayer = null;
                
                                
            }
           
           
            public void SetVolume(int volume)
            {


                m_mediaPlayer.Volume = volume/100.0f;
            }

            public void SetSpeed(int speed)
            {
                m_mediaPlayer.SpeedRatio = speed;
            }
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem!=null)
            {
                if (button1.Text.Equals("Start"))
                {
                    
                    if (comboBox1.SelectedItem.Equals("Interstellar"))
                    {
                        isStart = true;
                        comboBox1.Enabled = false;
                        button1.Text = "Stop";
                       
                        
                        sound.Play(paths[0], 50,1);
                    }
                    if(comboBox1.SelectedItem.Equals("Another Love"))
                    {
                        isStart = true;
                        comboBox1.Enabled = false;
                        button1.Text = "Stop";
                        
                        
                        sound.Play(paths[1], 50,1);
                    }
                    if(comboBox1.SelectedItem.Equals("Surf Curse"))
                    {
                        isStart = true;
                        comboBox1.Enabled = false;
                        button1.Text = "Stop";
                        
                        
                        sound.Play(paths[2], 50,1);
                    }
                    if (comboBox1.SelectedItem.Equals("Radioactive"))
                    {
                        isStart = true;
                        comboBox1.Enabled = false;
                        button1.Text = "Stop";

                        
                        sound.Play(paths[3], 50,1);
                    }
                    if (comboBox1.SelectedItem.Equals("Take on Me"))
                    {
                        isStart = true;
                        comboBox1.Enabled = false;
                        button1.Text = "Stop";

                       
                        sound.Play(paths[4], 50,1);
                    }
                }
                else if (button1.Text.Equals("Stop"))
                {
                    isStart = false;
                    comboBox1.Enabled = true;
                    button1.Text = "Start";
                    sound.Stop();
                    
                    

                }
            }    
            else
                return;




        }

        private void penButton_MouseClick(object sender, MouseEventArgs e)
        {
            newPen.Width = 1;
            ShowShapeBox.Enabled=true;
        }

        private void bBrush_MouseClick(object sender, MouseEventArgs e)
        {
            newPen.Width = 15;
            ShowShapeBox.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Width = 5;
            ShowShapeBox.Enabled = false;

            picture.Image = null;
            Bitmap map = new Bitmap(389, 178);
            Point point1;
            point1 = ShowShapeBox.Location;
            gr = Graphics.FromImage(map);
           
            gr.DrawRectangle(newPen, point1.X + 60, point1.Y-5, point1.X + 65, point1.Y-90);
            gr.DrawRectangle(newPen, point1.X + 95, point1.Y - 60, point1.X + 65, point1.Y - 90);
            gr.DrawLine(newPen, point1.X + 60, point1.Y-5, point1.X + 95, point1.Y - 60);
            
            gr.DrawLine(newPen, point1.X + 60, point1.Y +37, point1.X+95,point1.Y-18);
            gr.DrawLine(newPen,point1.X+133,point1.Y-5, point1.X+169, point1.Y-60);
            gr.DrawLine(newPen, point1.X + 133, point1.Y + 38, point1.X + 169, point1.Y - 20);
            picture.Image = map;

        }

        private void bBlack_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color= System.Drawing.Color.Black;
        }

        private void bBlue_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Blue;
        }

        private void bGreen_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Green;
        }

        private void bCyan_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Cyan;
        }

        private void bRed_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Red;
        }

        private void bMagenta_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Magenta;
        }

        private void bYellow_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.Yellow;
        }

        private void bWhite_CheckedChanged(object sender, EventArgs e)
        {
            newPen.Color = System.Drawing.Color.White;
        }

        private void bLine_CheckedChanged(object sender, EventArgs e)
        {




            picture.Image = null;
            Bitmap map = new Bitmap(389, 178);
            Point point1;
            point1 = ShowShapeBox.Location;
            gr =Graphics.FromImage(map);

            gr.DrawLine(newPen, point1.X+25,point1.Y-25, point1.X+250,point1.Y-50);

            picture.Image = map;

            
        }

        private void bCircle_CheckedChanged(object sender, EventArgs e)
        {



            picture.Image = null;
            Bitmap map = new Bitmap(389, 178);
            Point point1;
            point1 = ShowShapeBox.Location;
            gr = Graphics.FromImage(map);
            gr.DrawEllipse(newPen, point1.X+62, point1.Y - 108, point1.X + 138, point1.Y+10);

            picture.Image = map;
        }

        private void bSquare_CheckedChanged(object sender, EventArgs e)
        {
            picture.Image = null;
            Bitmap map = new Bitmap(389, 178);
            Point point1;
            point1 = ShowShapeBox.Location;
            gr = Graphics.FromImage(map);
            gr.DrawRectangle(newPen, point1.X + 62, point1.Y - 108, point1.X + 138, point1.Y + 10);

            picture.Image = map;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null && isStart == true)
            {
                sound.SetVolume(trackBar1.Value);
            }
            else
                return;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && isStart == true)
            {
                sound.SetSpeed(trackBar2.Value);
            }
            else
                return;
        }
    }
}
