using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number3
{
    class Program
    {
        static void Main(string[] args)

        {

            //  string ans;
            string ans;
            do


            {
                Calculator cal1 = new Calculator();
                Console.WriteLine("Learn your squares and cubes! \n");
                Console.WriteLine("Enter an integer:  \n");


                String input = Console.ReadLine();
                int input_num = int.Parse(input);
                Console.WriteLine("Number          Squared           Cubed");
                Console.WriteLine("======           ======           ======");

                int input_num2 = input_num;
                for (int i1 = 0; i1 < input_num; i1++)
                {

                    Console.WriteLine(input_num2 + "                   " + cal1.square_cal(input_num2) + "                " + cal1.cube_cal(input_num2));


                    input_num2++;

                }
                Console.Write("Continue? (y/n):  ");
                ans = Console.ReadLine();

            }  
            while (ans == "y");
        }
    }
}
    