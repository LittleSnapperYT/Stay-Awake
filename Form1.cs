using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace MousyMove
{
    public partial class Form1 : Form
    {
        public Boolean lol = true;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Stay Awake";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.digitalcitizen.life/what-is-my-screen-resolution");

        }

        private async void enterButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Witch.Text) && !string.IsNullOrWhiteSpace(Lenth.Text))
            {
                enterButton.Enabled = false;
                button2.Enabled = true;

                lol = true;

                int X;
                int Y;

                
                X = Convert.ToInt32(Lenth.Text);
                Y = Convert.ToInt32(Witch.Text);

                Cursor = new Cursor(Cursor.Current.Handle);

                while (lol)
                {
                    Random rnd = new Random();
                    int gamr = rnd.Next(2, 8);
                    Cursor.Position = new Point(X / gamr, Y / gamr);
                    await Task.Delay(2500);
                }
                
            }

            else
            {
                MessageBox.Show("Enter In Resulution", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            enterButton.Enabled = true;
            button2.Enabled = false;

            lol = false;
            MessageBox.Show("Ended Prossess", "You Quitted", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }
    }
}
