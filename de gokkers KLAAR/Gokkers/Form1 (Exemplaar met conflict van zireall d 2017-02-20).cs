using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    public partial class Form1 : Form
    {
        public Label sietse;
        public object[] Gokkers = new object[3];
        public Greyhound[] GreyHounds = new Greyhound[7];
        
        public int finish = 700;
        public int finish2;
     
        

        public Form1()
        {
            
            InitializeComponent();

            Greyhound hond1 = new Greyhound(pictureBox2);
            Greyhound hond2 = new Greyhound(pictureBox3);
            Greyhound hond3 = new Greyhound(pictureBox4);
            Greyhound hond4 = new Greyhound(pictureBox5);
            Greyhound hond5 = new Greyhound(pictureBox6);
            Greyhound hond6 = new Greyhound(pictureBox7);

            
            this.GreyHounds[1] = hond1;
            this.GreyHounds[2] = hond2;
            this.GreyHounds[3] = hond3;
            this.GreyHounds[4] = hond4;
            this.GreyHounds[5] = hond5;
            this.GreyHounds[6] = hond6;





        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        
        }
        public int sietsemoney;
        public int lidymoney;
        public int fermoney;
        

        private void button1_Click(object sender, EventArgs e)
        {

            bool radio1;
            bool radio2;
            bool radio3;
            
            if (radio1 = true )
            {
                if (radio2 = true)
                {
                    if (radio3 = true)
                    {
                        button2.Show();
                    }
                }
            }

            // voor als fedde gokt

            if (radioButton1.Checked)
            {
                Guy fedde = new Guy(label4, radioButton1, "fedde", 15);
                decimal amount = numericUpDown1.Value;
                decimal dog = numericUpDown2.Value;
                Bet feddebet = new Bet(amount, dog, fedde);

                feddebet.bet();

                fedde.UpdateLabels(numericUpDown1,numericUpDown2,fedde);
                radio1 = true;
            }

            // voor als lidy gokt

            if (radioButton2.Checked)
            {
                Guy lidy = new Guy(label5, radioButton2, "lidy", 15);
                decimal amount = numericUpDown1.Value;
                decimal dog = numericUpDown2.Value;
                Bet lidybet = new Bet(amount, dog, lidy);

                lidybet.bet();

                lidy.UpdateLabels(numericUpDown1, numericUpDown2, lidy);
                radio2 = true;
            }
            // voor als fer gokt 

             if (radioButton3.Checked)
            {
                Guy fer = new Guy(label6, radioButton3, "fer", 15);
                decimal amount = numericUpDown1.Value;
                decimal dog = numericUpDown2.Value;
                Bet ferbet = new Bet(amount, dog, fer);

                ferbet.bet();

                fer.UpdateLabels(numericUpDown1, numericUpDown2, fer);
                radio3 = true;
            }


        }
        private void UpdateLabels()
        {

        }
        public void winner ()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            this.GreyHounds[1].TakeStartingPosition();
            this.GreyHounds[2].TakeStartingPosition();
            this.GreyHounds[3].TakeStartingPosition();
            this.GreyHounds[4].TakeStartingPosition();
            this.GreyHounds[5].TakeStartingPosition();
            this.GreyHounds[6].TakeStartingPosition();

            do
            {
               if (= true )
                {
                    winner();
                }
                this.GreyHounds[1].Run(7, finish, "1");
                this.GreyHounds[2].Run(50, finish ,"2");
                this.GreyHounds[3].Run(100, finish, "3");
                this.GreyHounds[4].Run(160, finish, "4");
                this.GreyHounds[5].Run(200, finish, "4");
                this.GreyHounds[6].Run(240, finish, "4");
                Application.DoEvents();
            }
            while (this.GreyHounds[1].MyPictureBox.Location.X != 700|| this.GreyHounds[2].MyPictureBox.Location.X != 700 || this.GreyHounds[3].MyPictureBox.Location.X != 700 || this.GreyHounds[4].MyPictureBox.Location.X != 700);

            
            button2.Show();
          


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
