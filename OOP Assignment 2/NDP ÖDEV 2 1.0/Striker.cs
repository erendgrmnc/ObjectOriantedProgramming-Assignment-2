using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ÖDEV_2_1._0
{
    class Striker : Player

    {
        Random RandomNumber3 = new Random();

        //Variables for strikers.
        protected int finishing;
        protected int firstTouch;
        protected int highBall;
        protected int SpecialTalent;
        protected int coldBlood;

        public Striker(string iS, int f) : base(iS, f)
        {
            nameSurname = iS;
            backNumber = f;
            speed = RandomNumber3.Next(50, 100);
            stamina = RandomNumber3.Next(50, 100);
            pass = RandomNumber3.Next(50, 100);
            shoot = RandomNumber3.Next(50, 100);
            talent = RandomNumber3.Next(50, 100);
            determination = RandomNumber3.Next(50, 100);
            naturalForm = RandomNumber3.Next(50, 100);
            luck = RandomNumber3.Next(50,100);
            finishing = RandomNumber3.Next(70, 100);
            firstTouch = RandomNumber3.Next(70, 100);
            highBall = RandomNumber3.Next(70, 100);
            SpecialTalent = RandomNumber3.Next(70, 100);
            coldBlood = RandomNumber3.Next(70, 100);
        }

        public override bool GoalScore()
        {
            double goalScore;
            goalScore = talent * 0.2 + SpecialTalent * 0.2 + shoot * 0.2 + firstTouch * 0.1 + highBall * 0.1 + finishing * 0.1 + coldBlood * 0.1 + determination * 0.1 + naturalForm * 0.1 + luck * 0.1;

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

            passScore = pass * 0.3 + talent * 0.3 + SpecialTalent * 0.2 + stamina * 0.1 + naturalForm * 0.1 + luck * 0.2;

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
