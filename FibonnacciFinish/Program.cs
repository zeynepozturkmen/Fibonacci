using System;
using System.Collections.Generic;

namespace FibonnacciFinish
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var givenNumber = Convert.ToInt32(Console.ReadLine());

            //Fibonnacci hesaplaması (algoritması)
            var number_1 = 0;
            var number_2 = 1;
            var sum = 0;

            var fibonacciList = new List<int>();

            //0,1,1,2,3,5,
            //Baslangıcta bir kez atılmalı
            fibonacciList.Add(number_1);
            fibonacciList.Add(number_2);

            var result = 0;

            for (var i = 0; i < givenNumber; i++)
            {
                sum = number_1 + number_2;

                fibonacciList.Add(sum);
                number_1 = number_2;
                number_2 = sum;

                if (fibonacciList[i] > givenNumber)
                {
                    result = fibonacciList[i];
                    break;
                }

            }

            Console.WriteLine("İstenen sayı: " + givenNumber + " bu sayıdan büyük;en küçük fibonacci sayısı: " + result);

        }
    }
}
