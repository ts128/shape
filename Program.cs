using System;
using System.Threading;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            var rhombus = new FrameRhombus(7, 1);
            var square = new FrameSquare(11, 4);            

            for (int i = 0; i < 10; i++)
            {
                //rhombus.RenderManyFramesInRow(5);
                rhombus.RenderFrames();
                Thread.Sleep(100);
                Console.Clear();
                square.RenderFrames();
                Thread.Sleep(100);
                Console.Clear();
                
            }
        }
    }
}
