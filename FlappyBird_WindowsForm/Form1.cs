using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_WindowsForm
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
         int score =0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            // next two lines of code is what  brings the pipes from the right side to the left.
            pipeBottom.Left -= pipeSpeed; 
            pipeTop.Left -= pipeSpeed;
            lblScoreText.Text = "Score :" + score;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || (flappyBird.Top < -25));
            {
                endGame();
            }
            if(score > 5)
            {
                pipeSpeed = 15;
            }
            
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Space);
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) ;
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            lblScoreText.Text += "Game Over!!!";
        }
    }
}
