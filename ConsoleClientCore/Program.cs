using Microsoft.Extensions.DependencyInjection;
using NamedUnityTest;
using System;
using Unity;

namespace ConsoleClientCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UnityContainer unityContainer = new UnityContainer();

         
            unityContainer.RegisterInstance(typeof(IPrintable), "dotmatrix", new DotMatrixPrinter());
            unityContainer.RegisterInstance(typeof(IPrintable), "laser", new LaserPrinter());
            

             unityContainer.Resolve<IPrintable>("dotmatrix").Print();
            unityContainer.Resolve<IPrintable>("laser").Print();

            Console.ReadKey();


        }
    }
}
