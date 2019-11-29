/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2 
**				ÖĞRENCİ ADI............: SALİH EREN  DEĞİRMENCİ 
**				ÖĞRENCİ NUMARASI.......: G181210017
**              DERSİN ALINDIĞI GRUP...: D
****************************************************************************/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_ÖDEV_2_1._0
{
    class Program
    {
        static Random randomNumber = new Random();

        static public List<Player> team = new List<Player>();

        static void Main(string[] args)
        {
            //Team 
            team.Add(new Defance("Serdar Aziz", 1));
            team.Add(new Defance("Zeki Çelik", 2));
            team.Add(new MidField("Emre Belezoğlu", 3));
            team.Add(new Striker("Cenk Tosun", 4));
            team.Add(new Defance("Luyindama", 5));
            team.Add(new MidField("Badou Ndiaye", 6));
            team.Add(new Striker("Mbaye Diagne", 7));
            team.Add(new Defance("Yuto Nagatomo", 8));
            team.Add(new MidField("Felipe Melo", 9));
            team.Add(new MidField("Emre Akbaba", 10));

            int BackNumber = 0;
            Boolean goalScore = true;
            int passTemp = 40;
            int goalTemp = 50;

            BackNumber = randomNumber.Next(1, 10);
            


            //For 3 times pass loop.
                for (int i = 1; i <= 3; i++)
                {
                    //Looking for the player not pass the ball himself.If passTemp equal to new back number , back number will be assigned to a new number.
                    while (BackNumber == passTemp)
                    {
                        BackNumber = randomNumber.Next(1, 10);
                       // if not break the loop.
                        if (passTemp != BackNumber)
                        {
                            break;
                        }
                    }
                    //Run the PassScore Function for passing the ball to another player.If pass fails break the loop.
                    if (!team[BackNumber].PassScore())
                    {
                        goalScore = false;
                        break;
                    }
                    passTemp = BackNumber;

                }
                
                goalTemp = BackNumber;

                //If three passess successfuly happens the last player tries a shoot.For this goalScore boolean isn't change to false,  the loop starts.
                if (goalScore == true)
                {
                    
                    BackNumber = randomNumber.Next(1, 10);
                    //For guarante the shooter is the last one the ball has passed.
                    while (goalTemp == BackNumber)
                    {
                        BackNumber = randomNumber.Next(1, 10);
                    //If it isn't the same back number the last passer and the shooter has,break the loop.
                        if (goalTemp != BackNumber)
                        {
                            break;

                        }
                    }
                   //Run the Goalscroe function to shoot the ball.
                    team[BackNumber].GoalScore();
                    Console.WriteLine('\r');
                }
                
            
            Console.ReadKey();

        }


    }

 }








    
