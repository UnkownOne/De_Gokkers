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
        public Guy[] Gokkers = new Guy[4];
        public Greyhound[] GreyHounds = new Greyhound[7];
        public Bet[] Bet = new Bet[4];
        
        public int finish = 700;
        public int finish2;
        public bool radio1;
        public bool radio2;
        public bool radio3;

      
       public bool winner1;
        public bool winner2;
       public bool winner3;
       public bool winner4;
       public bool winner5;
       public bool winner6;



        public Form1()
        {
            
            InitializeComponent();

            Greyhound Pietje = new Greyhound(pictureBox2,label7);
            Greyhound Jantje = new Greyhound(pictureBox3, label7);
            Greyhound Peter = new Greyhound(pictureBox4, label7);
            Greyhound Kjeld = new Greyhound(pictureBox5, label7);
            Greyhound Robbe = new Greyhound(pictureBox6, label7);
            Greyhound Seraphina = new Greyhound(pictureBox7, label7);

            
            this.GreyHounds[1] = Pietje;
            this.GreyHounds[2] = Jantje;
            this.GreyHounds[3] = Peter;
            this.GreyHounds[4] = Kjeld;
            this.GreyHounds[5] = Robbe;
            this.GreyHounds[6] = Seraphina;





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
        
        private void welcome()
        {
            Gokkers[1].dog = 0;
            Gokkers[2].dog = 0;
            Gokkers[3].dog = 0;
            this.winner1 = false;
            this.winner2 = false;
            this.winner3 = false;
            this.winner4 = false;
            this.winner5 = false;
            this.winner6 = false;
            this.GreyHounds[1].winner = false;
            this.GreyHounds[2].winner = false;
            this.GreyHounds[3].winner = false;
            this.GreyHounds[4].winner = false;
            this.GreyHounds[5].winner = false;
            this.GreyHounds[6].winner = false;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            
            if (radio1 == true )
            {
                if (radio2 == true)
                {
                    if (radio3 == true)
                    {
                        button2.Show();
                    }
                }
            }

            // voor als fedde gokt

            if (radioButton1.Checked)
            {
                Guy fedde = new Guy(label4, radioButton1, "fedde", 100);
                decimal amount = numericUpDown1.Value;
                decimal dog = numericUpDown2.Value;
                Bet feddebet = new Bet(amount, dog, fedde);
                this.Bet[1] = feddebet;
                this.Gokkers[1] = fedde;

                fedde.assigndog(dog);               
                feddebet.bet();

                fedde.UpdateLabels(numericUpDown1,numericUpDown2,fedde);
                radio1 = true;
            }

            // voor als lidy gokt

            if (radioButton2.Checked)
            {
                decimal amount = numericUpDown1.Value;
                decimal dog = numericUpDown2.Value;
               
                Guy lidy = new Guy(label5, radioButton2, "lidy", 100);
                Bet lidybet = new Bet(amount, dog, lidy);

                this.Bet[2] = lidybet;

                this.Gokkers[2] = lidy;

                lidy.assigndog(dog);

                lidybet.bet();

                lidy.UpdateLabels(numericUpDown1, numericUpDown2, lidy);
                radio2 = true;
            }
            // voor als fer gokt 

             if (radioButton3.Checked)
            {
                Guy fer = new Guy(label6, radioButton3, "fer", 100);
                decimal amount = numericUpDown1.Value;
                decimal dog = numericUpDown2.Value;

                Bet ferbet = new Bet(amount, dog, fer);

                this.Bet[3] = ferbet;
                this.Gokkers[3] = fer;

                fer.assigndog(dog);

                ferbet.bet();

                fer.UpdateLabels(numericUpDown1, numericUpDown2, fer);
                radio3 = true;
            }


        }
        
        public void winner (decimal winnerr)
        {
           
            button2.Hide();
            string winner = winnerr.ToString();
            string wiener = winner + " is de winnaar";
            this.label7.Text = wiener;
            if (this.Gokkers[1].dog == winnerr)
            {
                this.Bet[1].PayOut();
               
            }
             if (this.Gokkers[1].dog != winnerr)
            {
                int geld = Convert.ToInt32(this.Bet[1].Amount);
                this.Gokkers[1].Cash -= geld;
            }
             if (this.Gokkers[2].dog == winnerr)
            {
                this.Bet[2].PayOut();
            }
             if (this.Gokkers[2].dog != winnerr)
            {
                int geld = Convert.ToInt32(this.Bet[2].Amount);
                this.Gokkers[2].Cash -= geld;
            }
             if (this.Gokkers[3].dog == winnerr)
            {
                this.Bet[3].PayOut();
            }
             if (this.Gokkers[3].dog != winnerr)
            {
                int geld = Convert.ToInt32(this.Bet[3].Amount);
                this.Gokkers[3].Cash -= geld;
            }
            this.Gokkers[1].UpdateLabels();
            this.Gokkers[2].UpdateLabels();
            this.Gokkers[3].UpdateLabels();
            welcome();
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


                bool checkeen = this.GreyHounds[1].Run(7, finish);
                bool checktwee =  this.GreyHounds[2].Run(50, finish);
                bool checkdrie = this.GreyHounds[3].Run(100, finish);
                bool checkvier = this.GreyHounds[4].Run(160, finish);
                bool checkvijf = this.GreyHounds[5].Run(200, finish);
                bool checkzes = this.GreyHounds[6].Run(240, finish);
                this.winner1 = checkeen;
                this.winner2 = checktwee;
                this.winner3 = checkdrie;
                this.winner4 = checkvier;
                this.winner5 = checkvijf;
                this.winner6 = checkzes;

                if (this.winner1 == true)
                {
                  
                    winner(1);
                    this.winner1 = false;
                    break;
                }
                if (this.winner2 == true)
                {
                    winner(2);
                    this.winner2 = false;
                    break;
                }
                if (this.winner3 == true)
                {
                    winner(3);
                    this.winner3 = false;
                    break;
                }
                if (this.winner4 == true)
                {
                    winner(4);
                    this.winner4 = false;
                    break;
                  

                }
                if (this.winner5 == true)
                {
                    winner(5);
                    this.winner5 = false;
                    break;

                }
                if (this.winner6 == true)
                {
                    winner(6);
                    this.winner6 = false;
                    break;
                }



                Application.DoEvents();
            }
            while (this.GreyHounds[1].winner == false || this.GreyHounds[2].winner == false || this.GreyHounds[3].winner == false || this.GreyHounds[4].winner == false || this.GreyHounds[5].winner == false || this.GreyHounds[6].winner == false);
            //this.GreyHounds[1].MyPictureBox.Location.X != 700|| this.GreyHounds[2].MyPictureBox.Location.X != 700 || this.GreyHounds[3].MyPictureBox.Location.X != 700 || this.GreyHounds[4].MyPictureBox.Location.X != 700
          

            button2.Show();
          


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
