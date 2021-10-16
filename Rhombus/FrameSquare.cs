using System;

namespace shape
{
    class FrameSquare : Description, IFrames
    {
        public FrameSquare(int width, int shift)
        {
            Width = width;
            Shift = shift;
        }
        private void Peak(bool baseRectangle, int width)
        {
            SpaceShiftLeft();
            if (baseRectangle)
            {
                for (int k = Shift; k < width + Shift; k++)
                {
                    Console.Write("+");
                }
            }
            else
            {
                for (int k = Shift; k < width + Shift; k++)
                {
                    if (k == Shift || k == Shift + width - 1)
                        Console.Write("+");
                    else
                        Console.Write(" ");
                }
            }
        }
        private void Dale(bool baseRectangle, int width)
        {
            SpaceShiftLeft();
            if (!baseRectangle)
            {
                for (int k = Shift; k < width + Shift; k++)
                {
                    if (k == Shift || k == Shift + width - 1)
                        Console.Write("+");
                    else
                        Console.Write(" ");
                }
            }
            else
            {
                for (int k = Shift; k < width + Shift; k++)
                {
                    Console.Write("+");
                }
            }
        }
        private void SpaceShiftLeft()
        {
            for (int i = 0; i < Shift; i++)
            {
                Console.Write(" ");
            }
        }

        private void SpaceShiftDown()
        {
            SpaceShiftLeft();
            for (int i = 0; i < Width; i++)
            {
                Console.Write(" ");
            }
        }
        public void RenderFrames()
        {
            int shiftBottomRectangle = 2;

            int shiftDownRightRectangle = 6; //must be > shiftDown

            for (int i = 0; i < Width; i++)
            {
                if (i < shiftDownRightRectangle)
                {
                    if (i != 0)
                        Peak(false, Width);
                    else
                        Peak(true, Width);
                    Console.WriteLine(" ");
                }
                else
                {
                    if (i == Width - 1)
                        Dale(true, Width);
                    else
                        Dale(false, Width);

                    if (i == shiftDownRightRectangle)
                        Peak(true, Width);
                    else
                        Peak(false, Width);

                    Console.WriteLine(" ");
                }
            }

            for (int i = 0; i < Width + shiftBottomRectangle; i++)
            {
                if (i < shiftDownRightRectangle)
                {
                    if (i < shiftBottomRectangle)
                        SpaceShiftDown();
                    else if (i == shiftBottomRectangle)
                        Peak(true, Width);
                    else if (i > shiftBottomRectangle)
                        Peak(false, Width);

                    if (i < shiftDownRightRectangle - 1)
                        Dale(false, Width);
                    else if (i == shiftDownRightRectangle - 1)
                        Dale(true, Width);

                    Console.WriteLine(" ");
                }
                else
                {
                    if (i == Width + shiftBottomRectangle - 1)
                        Dale(true, Width);
                    else
                        Dale(false, Width);
                    Console.WriteLine(" ");
                }
            }

        }
    }
}
