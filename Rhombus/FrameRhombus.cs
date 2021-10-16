using System;

namespace shape
{
    class FrameRhombus : Description, IFrames
    {

        public FrameRhombus(int width, int shift)
        {
            Width = width;
            Shift = shift;
        }

        private void  Peak(int index, int width)
        {
            for (int k = width + Shift; k > index; k--)
            {
                Console.Write(" ");
            }
            Console.Write("+");

            for (int k = 1; k < index * 2; k++)
            {
                Console.Write(" ");
            }
            if (index != 0)
                Console.Write("+");

            for (int k = width; k > index; k--)
            {
                Console.Write(" ");
            }
        }
        private void Dale(int index, int width)
        {
            for (int k = 0; k < index + 1 + Shift; k++)
            {
                Console.Write(" ");
            }
            Console.Write("+");

            for (int k = width * 2 - 3; k > index * 2; k--)
            {
                Console.Write(" ");
            }
            if (index != width -1)
                Console.Write("+");
            for (int k = 0; k <= index; k++)
            { 
                Console.Write(" ");
            }
        }

        public void RenderFrames()
        {
   
            for (int i = 0; i < Width * 2 - 1; i++)
            {
                if (i < Width - 1)
                {
                    Peak(i, Width);
                    Console.WriteLine(" ");
                }
                else
                {
                    Dale(i - Width + 1, Width);
                    Peak(i - Width + 1, Width);
                    Console.WriteLine(" ");
                }
            }

            for (int i = 0; i < Width * 2 - 1; i++)
            {
                if (i < Width - 1)
                {
                    Peak(i, Width);
                    Dale(i + 1, Width);
                    Console.WriteLine(" ");
                }
                else
                {
                    Dale(i - Width + 1, Width);
                    Console.WriteLine(" ");
                }
            }
        }
        public void RenderManyFramesInRow(int numberOfRhombus)
        {
            for (int i = 0; i < Width * 2 - 1; i++)
            {
                if (i < Width - 1)
                {
                    for (int k = 0; k < numberOfRhombus; k++)
                    {
                        Peak(i, Width);
                    }
                    Console.WriteLine(" ");
                }
                else
                {
                    for (int k = 0; k < numberOfRhombus; k++)
                    {
                        Dale(i - Width + 1, Width);
                    }
                    Console.WriteLine(" ");
                }
            }

        }
    }
}
