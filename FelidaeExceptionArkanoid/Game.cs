using System;
using System.Drawing;
using System.Windows.Forms;

namespace FelidaeExceptionArkanoid
{
    public partial class Game : Form
    {
          bool left;
          bool right;
          bool gameOver;
          private int score;
          int ballX;
          int ballY;
          int playerSpeed;

           Random random = new Random();
           public Game()
           {
               InitializeComponent();
               setupGame();
           }


           private void setupGame()
           {
               score = 0;
               ballX = 5;
               ballY = 5;
               playerSpeed = 12;
               txtScore.Text = "Score: " + score;

               gameTimer.Start();
               
               foreach(Control x in this.Controls)
                   if (x is PictureBox && (string) x.Tag == "blocks")
                       x.BackColor = Color.FromArgb(random.Next(256),random.Next(256),random.Next(256));
               

           }
          
          
        

         

          private void gameTimerEvent(object sender, EventArgs e)
          {
              throw new System.NotImplementedException();
          }

          private void keyisDown(object sender, KeyEventArgs e)
          {
              throw new System.NotImplementedException();
          }

          private void keyisUp(object sender, KeyEventArgs e)
          {
              throw new System.NotImplementedException();
          }


          
    }
}