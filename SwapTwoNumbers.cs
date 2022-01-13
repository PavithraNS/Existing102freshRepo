using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshTest102Project
{
    //Each word 1st letter has to start with UpperCase //Pascal case
    //Pascal will follow for classname and method name
    class SwapTwoNumbers
    {
        public static void SwapingNumbers()
        {
            //Camel case for local variables and method parameter
            int firstNum, secondNum,temp=0;
            Console.WriteLine("Please enter first Number");
            firstNum= Convert.ToInt32(Console.ReadLine()); //10
            Console.WriteLine("Please enter second Number");
            secondNum = Convert.ToInt32(Console.ReadLine()); //20

            Console.WriteLine("Before exchanging values: first={0},second={1}", firstNum, secondNum);
            temp = firstNum; //10
            firstNum = secondNum; //20
            secondNum = temp;//10
            Console.WriteLine("After exchanging values: first={0},second={1}", firstNum, secondNum);
        }
    }
}
