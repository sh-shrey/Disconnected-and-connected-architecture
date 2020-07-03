using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class list
    {
        public static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine("enter the loop:");
                Console.ReadLine();
                Console.WriteLine(intList[i]);

                //Myclass obj = new Myclass();
                //obj.X = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(obj.X);
                Console.ReadKey();
            }
        }
    }
//    class Myclass
//    {
//        private int x;
//        public int X
//        {
//            get
//            {
//                return x;
//            }
//            set
//            {
//                x = value;
//            }

//        }
 }

