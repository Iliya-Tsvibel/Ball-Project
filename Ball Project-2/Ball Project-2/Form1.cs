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

namespace Ball_Project_2
{
    public partial class Form1 : Form
    {
        int dx = 1;
        int dy = 1;

        public Form1()
        {
            InitializeComponent();
            Moon.Visible = false;
        }



        private void Run_Moon_Faster(object sender, EventArgs e)
        {
            Action run = () => { Moon.Location = new Point(Moon.Location.X + dx, Moon.Location.Y + dy); };
            Moon.Visible = true;

            //updating coordinates
            
                Task.Run(() =>
                {
                    while (true)
                    {
                        if (Moon.Location.X + dx <= 0 || Moon.Location.X + dx >= ClientSize.Width - Moon.Width)
                        {
                            dx = -dx;
                            Boing();
                        }

                        if (Moon.Location.Y + dy <= 0 || Moon.Location.Y + dy >= ClientSize.Height - Moon.Height)
                        {
                            dy = -dy;
                            Boing();
                        }


                        Moon.BeginInvoke(run);
                        Thread.Sleep(10);

                    }
                    
                });
           
            
    
        }
 
        private void Boing()
        {
            using (SoundPlayer player = new SoundPlayer(Properties.Resources.chord))
            {
                if (Moon.Visible)
                {
                    player.Play();
                }

                else
                    player.Stop();
            }
        }

        private void ClearAll(object sender, EventArgs e)
        {
            Moon.Visible = false;
        }

    }
}
