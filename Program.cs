using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    // The rectangle class
    class Rectangle
    {
        // member variables
        public readonly int Height;
        public readonly int Width;

        // contructor
        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }
        // method to draw the rectangle
        public void draw()
        {
            //Display lines
            for (int i = 1; i <= Height; i++)
            { // specify the char to be used
                char c = ' ';
                // Write horizontal lines
                if (i == 1 || i == Height)
                {
                    for (int y = 1; y <= Width; y++)
                    {
                        if (y == 1 || y == Width) c = '+';
                        else c = '-';
                        Console.Write(c);
                    }
                }
                else
                { // write vertical lines
                    for (int y = 1; y <= Width; y++)
                    {
                        if (y == 1 || y == Width) c = '|';
                        else c = ' ';
                        Console.Write(c);
                    }
                }
                //Go to the next line
                Console.WriteLine();
            }
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            char quit = 'y'; // used to exit
            while (quit == 'y' || quit == 'Y')
            {
                Console.Write("Enter the height of the rectangle: ");
                int Height = int.Parse(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                int Width = int.Parse(Console.ReadLine());

                Rectangle r = new Rectangle(Height, Width);
                r.draw();

                //prompt user to draw another
                Console.Write("Enter \"Y\" if they would like to draw another one or \"N\" to quit: ");
                quit = Console.ReadLine()[0];
            }

        }
    }
}
