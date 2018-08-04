using System;
using System.Text;
using System.Globalization;
using System.Linq;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3]; // explicitly defining my array length
            arr[0] = 23;
            string[] CustomerfirstName = {"Zee", "Adam", "Simon" };
            var employees = new[] {"Drake", "Chris", "steve"};
            object[] randomArr = {"Steve", 50, 1.234};

            Console.WriteLine(" the value of index 0 is set to: {0}", arr[0]); // string interpiluiatation used to output the array index with the value.
            Console.WriteLine(" the value of index 0 is set to: Name: {0} \n who is :{1} Years Old \n & has :{2} in his bank", randomArr); // string interpiluiatation used to output the array index with the value.

            for (int i = 0; i < randomArr.Length; i++)
            {
                Console.WriteLine("array Index: {0}, Value: {1}", i, randomArr[i]); // looping through itterations of all values within the array and returning values 
            }

            string[,] customerNames = new string[2, 2] {{" Bob", "islam"} ,{"Zee", "Adam" }};
            Console.WriteLine("Multi Dimention value:{0}",customerNames.GetValue(1,0));

            for (int i = 0; i < customerNames.GetLength(0); i++)
            {
                for (int j = 0; j < customerNames.GetLength(1); j++)
                {
                    Console.Write("Multi Dimention value:{0}\n", customerNames.GetValue(i, j));
                }
            }
            Console.ReadLine();
        }
    } 
}
