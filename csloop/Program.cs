﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;

            //while(start+(10000000)>DateTime.Now.Ticks)
            //{
            //    count++;
            //}

            //Console.WriteLine(count + "만큼 반복했습니다.");


            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            string input = "day6 comeback after 3days~!~!!!";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());


            string[] mem = { "박씨","김씨","강씨","윤씨"};
            Console.WriteLine(string.Join(",", mem));

            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");


                Thread.Sleep(100);
                x++;
            }            

        }
    }
}
