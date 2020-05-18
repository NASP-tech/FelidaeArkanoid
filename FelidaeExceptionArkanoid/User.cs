using System;
using System.Windows.Forms;

namespace FelidaeExceptionArkanoid
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            
            if(name.Length == 0)
            {
                MessageBox.Show("you did not enter the name!", "Name Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //verificacion con la base de datos por si esta repetido
                
                //luego se inicia el juego
                
                Game game = new Game();
                game.Show();
                this.Close();
            }
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 Menu = new Form1();
            Menu.Show();
            this.Close();
        }
    }
}