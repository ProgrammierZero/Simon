using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon
{
    class GameDesign
    {
        public GameProperties proper = new GameProperties();
        public void GenerateMap(int Note)
        {
            Console.WriteLine(proper.VisualMap[0]);
            Console.Write(proper.VisualMap[1]);
            Console.BackgroundColor = Note == 1 ? GetColor(1) : GetColor(0); 
            Console.Write(proper.VisualMap[2]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(proper.VisualMap[3]);
            Console.BackgroundColor = Note == 2 ? GetColor(2) : GetColor(0);
            Console.Write(proper.VisualMap[4]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(proper.VisualMap[5]);
            Console.Write(proper.VisualMap[6]);
            Console.BackgroundColor = Note == 1 ? GetColor(1) : GetColor(0);
            Console.Write(proper.VisualMap[7]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(proper.VisualMap[8]);
            Console.BackgroundColor = Note == 2 ? GetColor(2) : GetColor(0);
            Console.Write(proper.VisualMap[9]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(proper.VisualMap[10]);
            Console.Write(proper.VisualMap[11]);
            Console.BackgroundColor = Note == 1 ? GetColor(1) : GetColor(0);
            Console.Write(proper.VisualMap[12]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(proper.VisualMap[13]);
            Console.BackgroundColor = Note == 2 ? GetColor(2) : GetColor(0);
            Console.Write(proper.VisualMap[14]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(proper.VisualMap[15]);
            Console.WriteLine(proper.VisualMap[16]);
            Console.Write(proper.VisualMap[17]);
            Console.BackgroundColor = Note == 3 ? GetColor(3) : GetColor(0);
            Console.Write(proper.VisualMap[18]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(proper.VisualMap[19]);
            Console.BackgroundColor = Note == 4 ? GetColor(4) : GetColor(0);
            Console.Write(proper.VisualMap[20]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(proper.VisualMap[21]);
            Console.Write(proper.VisualMap[22]);
            Console.BackgroundColor = Note == 3 ? GetColor(3) : GetColor(0);
            Console.Write(proper.VisualMap[23]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(proper.VisualMap[24]);
            Console.BackgroundColor = Note == 4 ? GetColor(4) : GetColor(0);
            Console.Write(proper.VisualMap[25]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(proper.VisualMap[26]);
            Console.Write(proper.VisualMap[27]);
            Console.BackgroundColor = Note == 3 ? GetColor(3) : GetColor(0);
            Console.Write(proper.VisualMap[28]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(proper.VisualMap[29]);
            Console.BackgroundColor = Note == 4 ? GetColor(4) : GetColor(0);
            Console.Write(proper.VisualMap[30]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(proper.VisualMap[31]);
            Console.Write(proper.VisualMap[32]);
        }

        ConsoleColor GetColor(int Note)
        {
            if(Note == 1)
            {
                return ConsoleColor.Blue;
            } 
            else if (Note == 2)
            {
                return ConsoleColor.DarkGreen;
            }
            else if (Note == 3)
            {
                return ConsoleColor.Red;
            }
            else if (Note == 4)
            {
                return ConsoleColor.DarkYellow;
            }
            return ConsoleColor.Black;
        }
    }
}
