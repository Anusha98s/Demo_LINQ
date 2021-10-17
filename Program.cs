using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data.SqlTypes;
using System.Data.Common;


namespace Demo_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ implementation in c#............!");
            int[] scores = new int[] { 20, 30, 10, 40, 45,50,55 };
            string[] cities = new string[] { "Agra", "Banglr", "Chittor" };
            //IEnumerable<int> ScoreQuery =
            //  from score in scores
            //where score > 35
            //orderby score descending
            //orderby score ascending
            //select score;

            IEnumerable<string> CityQuery =
                from city in cities
                where city is "Chittor"
                select city;

            foreach(var item in CityQuery)
            {
                Console.WriteLine(item,"\n");
            }

            //foreach(var item in ScoreQuery)
            //{

                //Console.WriteLine(item + " ");
                //Console.WriteLine("value is",item);

            //}
        }
    }
}
