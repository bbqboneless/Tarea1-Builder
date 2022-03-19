using System;

namespace Tarea1_computer
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea 1 _ Sam-->Ordenadores\n\n");

            //Computadora 1
            Director director = new Director();
            Builder builder1 = new MyComputer();
            director.Construct(builder1);
            Computer computer1 = builder1.BuildComputer();
            Console.WriteLine(computer1);

            //Computadora 2
            Director director2 = new Director();
            Builder builder2 = new MyComputer2();
            director.Construct(builder2);
            Computer computer2 = builder2.BuildComputer();
            Console.WriteLine(computer2);

        }
    }
}
