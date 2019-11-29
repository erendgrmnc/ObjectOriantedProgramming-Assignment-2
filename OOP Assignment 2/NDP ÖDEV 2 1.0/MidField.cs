using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ÖDEV_2_1._0
{
    class MidField : Player
    {
        Random RandomNumber2 = new Random();
        //Variables for mid field players.
        int longBall;
        int firstTouch;
        int productivity;
        int drippling;
        int specialTalent;

        public MidField(string iS, int f) : base(iS, f)
        {
            nameSurname = iS;
            backNumber = f;
            speed = RandomNumber2.Next(50, 100);
            stamina = RandomNumber2.Next(50, 100);
            pass = RandomNumber2.Next(50, 100);
            shoot = RandomNumber2.Next(50, 100);
            talent = RandomNumber2.Next(50, 100);
            determination = RandomNumber2.Next(50, 100);
            naturalForm = RandomNumber2.Next(50, 100);
            luck = RandomNumber2.Next(50, 100);
            longBall = RandomNumber2.Next(60, 100);
            firstTouch = RandomNumber2.Next(60, 100);
            productivity = RandomNumber2.Next(60, 100);
            drippling = RandomNumber2.Next(60, 100);
            specialTalent = RandomNumber2.Next(60, 100);

        }

        public override bool GoalScore()
        {
            double goalScore;
            goalScore = talent * 0.3 + specialTalent * 0.3 + shoot * 0.2 + firstTouch * 0.1 + determination * 0.1 + naturalForm * 0.1 + luck * 0.1;

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
            passScore = pass * 0.3 + talent * 0.3 + stamina * 0.1 + naturalForm * 0.1 + longBall * 0.1 + drippling * 0.1 + luck * 0.2;

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
