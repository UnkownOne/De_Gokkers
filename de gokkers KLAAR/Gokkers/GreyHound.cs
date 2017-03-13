using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    public class Greyhound 
    {

        public int RaceTrackLength;             //De lengte van de renbaan
        public PictureBox MyPictureBox = null;
        public Random Randomizer;               //Een instantie van Random (= Willekeurig) 
        public Label label;
        public bool winner;

        public Greyhound(PictureBox mypicturbox,Label label)
            {
            this.label = label;
            this.MyPictureBox = mypicturbox;
            }
        public bool Run(int start,int finishline)
             
                
        {

             
                
                Randomizer = new Random();
                int rnd = Randomizer.Next(1, 12);

                int lopen = this.MyPictureBox.Location.X;
                
                int antwoord ;

                Thread.Sleep(5);
                if (this.MyPictureBox.Location.X <= finishline)
                {
                
                    antwoord = Randomizer.Next(1, 4);
                    this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + (antwoord + antwoord + antwoord), this.MyPictureBox.Location.Y);
               
                }
                else{
                antwoord = Randomizer.Next(1, 4);
                this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + (antwoord + antwoord + antwoord), this.MyPictureBox.Location.Y);
            }
                if (this.MyPictureBox.Location.X == finishline)
                {
                winner = true;
                return winner;
               
                 }
            
            return winner;
     



         











            //Ga willekeurig 1, 2, 3 of 4 posities naar voren.
            //Werk de positie van PictureBox bij op het formulier.
            //Geef de waarde ‘true’ terug als ik de race win.
          
        }

        public void TakeStartingPosition()
        {
            this.MyPictureBox.Location = new Point(1,this.MyPictureBox.Location.Y);
            //Wijzig mijn locatie naar de startlijn.         
        }
    }
}

