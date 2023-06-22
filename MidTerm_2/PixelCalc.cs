using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_2
{
    public class PixelCalc
    {
        public double screenWidth { get; set; }
        public double screenHeight { get; set; }
        public double daigonalSize { get; set; }

        public void calculator()
        {
            Console.WriteLine("Enter screen width: ");
            double screenWidth;
            if (!double.TryParse(Console.ReadLine(), out screenWidth))
            {
                Console.WriteLine("Enter Correct Input");
                return;
            }
            Console.WriteLine("Enter screen height: ");
            double screenHeight;
            if (!double.TryParse(Console.ReadLine(), out screenHeight))
            {
                Console.WriteLine("Enter Correct Input");
                return;
            }

            Console.WriteLine("Enter daigonal size:");
            double daigonalSize;
            if (!double.TryParse(Console.ReadLine(), out daigonalSize))
            {
                Console.WriteLine("Enter Correct Input");
                return;
            }

            double PPI = Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2)) / daigonalSize;
            double diagonalPixels = Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2));
            double dotPitch = diagonalPixels / PPI;

            Console.WriteLine("PPI: " + PPI);
            Console.WriteLine("Diagonal (in pixels): " + diagonalPixels);
            Console.WriteLine("Dot pitch: " + dotPitch);

        }
    }
}
