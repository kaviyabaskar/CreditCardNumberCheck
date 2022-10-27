using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardNumberCheck
{
    internal class ReverseCheck
    {


        public void ReverseNumber(long ccNum)
        {


            int[] revCCNumber = new int[16];//Array will be easy reverse
            string sNum = ccNum.ToString();//String will is a character array
            int iCount = 0;
            int sum = 0;
            int a = 0;

            for (int i = 15; i >= 0; i--)
            {
                int CCValue = Int32.Parse(sNum[i].ToString());
                revCCNumber[iCount++] = CCValue;
            }
            //print & check Array
            Console.WriteLine("After Reverse");
            for (int i = 0; i < 16; i++)
            {
                Console.Write(revCCNumber[i]);
            }
            //Get Even possition oc CCnumber
            for (int i = 1; i <= 16; i++)
            {
                if (i % 2 == 0)
                {
                    revCCNumber[i - 1] = revCCNumber[i - 1] * 2;
                }
            }
            Console.WriteLine("\n After Even position Multily by 2");
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(revCCNumber[i]);

            }
            Console.WriteLine("Adding Two Digits Values");

            for (int i = 0; i < 16; i++)
            {
                int x = revCCNumber[i] / 10;
                int y = revCCNumber[i] % 10;
                int z = x + y;

                revCCNumber[i] = z;

            }

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(revCCNumber[i]);

            }
            for (int i = 0; i < 16; i++)
            {
                sum = sum + revCCNumber[i];
            }
            Console.WriteLine(sum);
            for (int i = 0; i < 16; i++)
            {
                revCCNumber[i] = a;
                a = a % 10;

            }

            Console.WriteLine("Checking a valid number :" + a);

            for (int i = 0; i < 1; i++)
            {

                if (a == 0)
                {
                    Console.WriteLine("Its a valid Card Number");
                }
                else
                {

                    Console.WriteLine("Its invalid number");
                }
            }


        }


    }

}