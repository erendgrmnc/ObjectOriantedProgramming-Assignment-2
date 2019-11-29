using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ÖDEV_2_1._0
{
    class Defance : Player
    {
        Random RandomNumber1 = new Random();

        //Variables for defance players.
        int pozitioning;
        int highBall;
        int jump;

        public Defance(string iS, int f) : base(iS, f)
        {
            nameSurname = iS;
            backNumber = f;
            speed = RandomNumber1.Next(50, 100);
            stamina = RandomNumber1.Next(50, 100);
            pass = RandomNumber1.Next(50, 100);
            shoot = RandomNumber1.Next(50, 100);
            talent = RandomNumber1.Next(50, 100);
            determination = RandomNumber1.Next(50, 100);
            naturalForm = RandomNumber1.Next(50, 100);
            luck = RandomNumber1.Next(50, 100);
            pozitioning = RandomNumber1.Next(50, 90);
            highBall = RandomNumber1.Next(50, 90);
            jump = RandomNumber1.Next(50, 90);
        }

        public override bool GoalScore()
        {
            double goalScore;

            goalScore = pass * 0.3 + talent * 0.3 + stamina * 0.1 + naturalForm * 0.1 + pozitioning * 0.1 + luck * 0.1 + jump * 0.1;

            //Controls goalScore calculation to dedcide it's goal or not.
            if (goalScore > 70)
            {
                
                Console.WriteLine(nameSurname + " (" + backNumber + ") " + " GOOOOOOL");
                return true;
            }
            else
            {
                
                Console.WriteLine(nameSurname + " (" + backNumber + ") " + " Kaçırdı.");
                return false;
            }

        }

        public override bool PassScore()
        {

            double passScore;
            passScore = pass * 0.3 + talent * 0.3 + stamina * 0.1 + naturalForm * 0.1 + pozitioning * 0.1 + luck * 0.2;

            //Controls passScore calculation to decide it's a successful pass or not.
            if (passScore > 60)
            {
                
                Console.WriteLine(nameSurname + " (" + backNumber + ") " + " Pasını verdi.");
                return true;
            }
            else
            { 
              Console.WriteLine(nameSurname + " (" + backNumber + ") " + " Başarısız pas.");
                return false;
            }
        }

    }
}
