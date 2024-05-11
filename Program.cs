using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Variable
            #region HideRegion
            int Variable01 = 5;
            int Variable02 = 4;
            int Variable03 = 6;

            float numFloat = 0.95f;
            decimal Denum = 1.12m;
            double Dubnum = 2.24;

            char MyGrade = 'a';
            Console.WriteLine(MyGrade);
            #endregion

            bool isCharpFun = false;
            bool isFishTasty = true;
            Console.WriteLine("Is Charp Fun??");
            Console.WriteLine(isCharpFun);
            Console.WriteLine("Is Fish Tasty??");
            Console.WriteLine(isFishTasty);
            if (isCharpFun == true)
            {
                Console.WriteLine("Good Luck For You");
            }
            else
            {
                Console.WriteLine("Good For You");
            }
            int Num01 = 3;
            int Num02 = 4;
            double Num03 = 2.6;
            Num01 = Num02 + (int)Num03;
            Console.WriteLine(Num01);
            int Y = 3;
            bool result3 = (Y < 3 && Y < 5);
            Console.WriteLine(result3);
            string text = "Hello Word";
            print(text);

        }
        static void print(string text)
        {

            Console.WriteLine(text);
        }
           

	

	}
    }

