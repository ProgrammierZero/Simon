using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon
{
    class GameProperties
    {

        public string[,] ColoredMap = new string[4, 4];
        public string[,] Map = new string[2, 2];
        public GameProperties()
        {
            InitVariables();
            InitMap();

        }

         
         
        public int Difficult = 1;
        public int Score = 0;
        public ConsoleColor[,] NotesColor = { {ConsoleColor.Blue, ConsoleColor.Green }, {ConsoleColor.Red, ConsoleColor.Yellow } };


        public string[] VisualMap = new string[33];
        private void InitMap()
        {
            VisualMap[0] = "---------------------------------";
            VisualMap[1] = "|";
            VisualMap[2] = ColoredMap[0, 0];
            VisualMap[3] = "|";
            VisualMap[4] = ColoredMap[1, 0];
            VisualMap[5] = "|";
            VisualMap[6] = "|";
            VisualMap[7] = ColoredMap[0, 1] + Map[0, 0] + ColoredMap[0, 2];
            VisualMap[8] = "|";
            VisualMap[9] = ColoredMap[1, 1] + Map[0, 1] + ColoredMap[1, 2];
            VisualMap[10] = "|";
            VisualMap[11] = "|";
            VisualMap[12] = ColoredMap[0, 3];
            VisualMap[13] = "|";
            VisualMap[14] = ColoredMap[1, 3];
            VisualMap[15] = "|";
            VisualMap[16] = "|---------------|---------------|";
            VisualMap[17] = "|";
            VisualMap[18] = ColoredMap[2, 0];
            VisualMap[19] = "|";
            VisualMap[20] = ColoredMap[3, 0];
            VisualMap[21] = "|";
            VisualMap[22] = "|";
            VisualMap[23] = ColoredMap[2, 1] + Map[1, 0] + ColoredMap[2, 2];
            VisualMap[24] = "|";
            VisualMap[25] = ColoredMap[3, 1] + Map[1, 1] + ColoredMap[3, 2];
            VisualMap[26] = "|";
            VisualMap[27] = "|";
            VisualMap[28] = ColoredMap[2, 3];
            VisualMap[29] = "|";
            VisualMap[30] = ColoredMap[3, 3];
            VisualMap[31] = "|";
            VisualMap[32] = "---------------------------------";
        }
        public void InitVariables()
        {
            ColoredMap[0, 0] = "               ";
            ColoredMap[0, 1] = "       ";
            ColoredMap[0, 2] = "       ";
            ColoredMap[0, 3] = "               ";
            ColoredMap[1, 0] = "               ";
            ColoredMap[1, 1] = "       ";
            ColoredMap[1, 2] = "       ";
            ColoredMap[1, 3] = "               ";
            ColoredMap[2, 0] = "               ";
            ColoredMap[2, 1] = "       ";
            ColoredMap[2, 2] = "       ";
            ColoredMap[2, 3] = "               ";
            ColoredMap[3, 0] = "               ";
            ColoredMap[3, 1] = "       ";
            ColoredMap[3, 2] = "       ";
            ColoredMap[3, 3] = "               ";

            Map[0, 0] = "1";
            Map[0, 1] = "2";
            Map[1, 0] = "3";
            Map[1, 1] = "4";
        }
        

    }
    
}
