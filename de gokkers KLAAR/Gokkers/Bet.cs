using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gokkers
{
    public class Bet
    {
        public decimal Amount;   //Het bedrag van de weddenschap.
        public decimal Dog;      //Het nummer van de hond waarop weddenschap is afgesloten.
        public Guy Bettor;   //De gokker die gewed heeft.
        
        public Bet(decimal amount, decimal dog,Guy bettor)
        {
            this.Amount = amount;
            this.Dog = dog;
            this.Bettor = bettor;
        }
        public string GetDescription()
        {

            //Retourneer een string die aangeeft wie de weddenschap heeft gedaan,
            //voor welk bedrag er is gewed en op welke hond er is gewed.
            //Bijv. “Sietse wedt 8 euro op hond 4”.
            //Als het bedrag 0 is, is er geen weddenschap geplaatst.
            //De string die dan geretourneerd wordt is bijv.
            //“Sietse heeft geen weddenschap geplaatst.”)
            string description =  this.Bettor.Name + " wedt € " + this.Amount + " op hamster " + this.Dog;

            return description;
        }
        public void bet()
        {
            int n = Convert.ToInt32(this.Amount);

            this.Bettor.Cash -= n;

            



        }

        public int PayOut()
        {
            this.Amount = + this.Amount;
            int geld = Convert.ToInt32(this.Amount);
            this.Bettor.Cash = + geld + geld + geld + geld ;
            //De parameter van deze methode is de winnaar van de race.
            //Als de hond gewonnen heeft, retourneer dan het bedrag dat gewed is
            //Anders, retourneer het tegengestelde van het gewedde bedrag.
            // de winnaar moet zijn inzet verdubbellen of hij verliest alles

            return 1;
        }
    }
}

