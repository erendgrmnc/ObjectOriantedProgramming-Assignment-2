using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ÖDEV_2_1._0
{
    class Player
    {   //Variables For every player
        public string nameSurname;
        public int backNumber;
        protected int speed;
        protected int stamina;
        protected int pass;
        protected int shoot;
        protected int talent;
        protected int determination;
        protected int naturalForm;
        protected int luck;

        Random RandomNumber = new Random();

        //Constructer for Player Class.
        public Player(string iS, int f)
        {
            nameSurname = iS;
            backNumber = f;
            speed = RandomNumber.Next(50, 100);
            stamina = RandomNumber.Next(50, 100);
            pass = RandomNumber.Next(50, 100);
            shoot = RandomNumber.Next(50, 100);
            talent = RandomNumber.Next(50, 100);
            determination = RandomNumber.Next(50, 100);
            naturalForm = RandomNumber.Next(50, 100);
            luck = RandomNumber.Next(50, 100);

        }

        //Virtual GoalScore Function.
        public virtual bool GoalScore()
        {
            double goalScore;
            goalScore = talent * 0.3 + shoot * 0.2 + determination * 0.1 + naturalForm * 0.1 + speed * 0.1 + luck * 0.2;
            
            //Controls goalScore calculation to dedcide it's goal or not.
            if (goalScore > 70)
            {
                
                Console.WriteLine(nameSurname + " (" + backNumber + ") " + " GOOOOOOL");
                return true;
            }
            else
            {
                
                Console.WriteLine(nameSurname + " (" + backNumber + ") "  + " Kaçırdı.");
                return false;
            }
        }

        public virtual bool PassScore()
        {
            double passScore;
            passScore = pass * 0.3 + talent * 0.3 + stamina * 0.1 + naturalForm * 0.1 + luck * 0.2;

            //Controls passScore calculation to decide it's a successful pass or not.
            if (passScore > 60)
            {
                
                Console.WriteLine(nameSurname + " (" + backNumber +") " + " Pasını verdi.");
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
