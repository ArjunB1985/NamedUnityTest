using System;
using System.Collections.Generic;
using System.Text;

namespace NamedUnityTest
{
    public class LaserPrinter : IPrintable
    {
        public void Print()
        {


            Console.WriteLine("Print from Laser Printer");
        }
    }
}
