using System;
using System.Collections.Generic;

namespace XMLReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = XMLHelper.GetPeople(@"D:\Projekty\XMLReaderApp\Cars.xml");

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
