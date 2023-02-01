using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1._02._2023
{
    internal class Program
    {
        static void EndErr(int code)
        {
            Console.WriteLine("Error Task " + code);
            Console.ReadKey();
            Environment.Exit(code);
        }

        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine("It's easy to win forgiveness for being wrong;");
            //Console.WriteLine("being right is what gets you into real trouble.");
            //Console.WriteLine("Bjarne Stroustrup\n");
            #endregion

            #region Task 2
            //double res = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Write num №{i + 1}: ");
            //    string str_2 = Console.ReadLine();

            //    double temp;
            //    if (double.TryParse(str_2, out temp)) res += temp;
            //    else EndErr(2);
            //}
            //Console.WriteLine($"Sum: {res}\n");
            #endregion

            #region Task 3
            const int len = 6;

            //Console.Write("Write num: ");
            //string str_3 = Console.ReadLine();
            //if (!int.TryParse(str_3, out int num_3)) EndErr(3);
            //if (str_3.Length != len) EndErr(3);

            //for (int i = str_3.Length - 1; i > -1; i--)
            //{
            //    Console.Write(str_3[i]);
            //}
            #endregion

            #region Task 4
            //int ai_4 = 0, bi_4 = 0;

            //Console.Write("Write num: ");
            //string str_4 = Console.ReadLine();
            //Console.Write("Write indexes: ");
            //string a_4 = Console.ReadLine();
            //string b_4 = Console.ReadLine();

            //if (!(int.TryParse(str_4, out int num_4))) EndErr(4);
            //else if (!(int.TryParse(a_4, out ai_4))) EndErr(4);
            //else if (!(int.TryParse(b_4, out bi_4))) EndErr(4);
            //else if(str_4.Length != len ||
            //    ai_4 > len || bi_4 > len ||
            //    ai_4 < 0 || bi_4 < 0) EndErr(4);

            //for (int i = 0; i < len; i++)
            //{
            //    if (i == ai_4) Console.Write(str_4[bi_4]);
            //    else if (i == bi_4) Console.Write(str_4[ai_4]);
            //    else Console.Write(str_4[i]);
            //}
            #endregion

            #region Task 5
            //int num1_5 = 0, num2_5 = 0;

            //Console.Write("Write Numbers: ");
            //string a_5 = Console.ReadLine();
            //string b_5 = Console.ReadLine();

            //if (!(int.TryParse(a_5, out num1_5))) EndErr(5);
            //else if (!(int.TryParse(b_5, out num2_5))) EndErr(5);
            //else if (num1_5 >= num2_5) EndErr(5);

            //for (int i = num1_5; i <= num2_5; i++)
            //{
            //    for (int y = 0; y < i; y++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.Write('\n');
            //}
            #endregion

            #region Task 6
            //Console.Write("Write len: ");
            //string len_6 = Console.ReadLine();
            //Console.Write("Write char: ");
            //string char_6 = Console.ReadLine();
            //Console.Write("Write dir: ");
            //string dir_6 = Console.ReadLine();

            //if (!(int.TryParse(len_6, out int num_6))) EndErr(5);
            //if (!(char.TryParse(char_6, out char ch_6))) EndErr(5);
            //else if (dir_6 != "hor" && dir_6 != "ver") EndErr(5);

            //string aut = $"{ch_6}" + (dir_6 == "hor" ? "" : "\n");
            //for (int i = 0; i < num_6; i++)
            //{
            //    Console.Write(aut);
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
