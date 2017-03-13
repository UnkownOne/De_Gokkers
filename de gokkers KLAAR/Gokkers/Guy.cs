using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    public class Guy
    {
        public string Name;  // De naam van de gokker
        public Bet MyBet;    // Een instantie van Bet()
        public int Cash;     // Het saldo van de gokker

        //Deze twee velden zijn de gokkers GUI controls op het formulier
        public RadioButton MyRadiobutton;
        public Label MyLabel;
        public decimal dog;

      
        public Guy(Label mylabel,RadioButton myradio, string name, int cash) 
            {
            this.Cash = cash;
            this.Name = name;
            this.MyLabel = mylabel;
            this.MyRadiobutton = myradio;
            
            
            }
        public void initializebetting(Bet bet)
            {
            this.MyBet = bet;
            }
        public void UpdateLabels()
        {
           
            this.MyRadiobutton.Text = this.Name + "heeft € " + this.Cash;
        }
        public void assigndog(decimal dog)
        {
            this.dog = dog;
        }
        public void UpdateLabels(NumericUpDown numericbet,NumericUpDown numericdog, Guy bettor)
        {
            
            decimal amount = numericbet.Value;
            decimal dog = numericdog.Value;
            


            Bet bet = new Bet(amount, dog,bettor);
            
           string description = bet.GetDescription();
            

            this.MyLabel.Text = description ;
                
            this.MyRadiobutton.Text = this.Name + " heeft € " + this.Cash;
            
            //Verander mijn label in de omschrijving van mijn weddenschap.
            //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.
            //(Bijv. “Lidy heeft 43 euro.”)

            
            
        }



        public void ClearBet()
        {
            //Maak de weddenschap leeg.

        }

        public void Collect(int Winner)
        {
            //Betaal mijn weddenschap uit.
            //Maak mijn weddenschap leeg.
            //Werk mijn labels bij.
        }

    }
}

