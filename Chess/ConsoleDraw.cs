using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class ConsoleDraw
    {
        //Specific console draw methods

        public const int WINDOW_WIDTH = 40;
        public const int WINDOW_HEIGHT = 20;

        public static void DrawFramePoint(int crsrRow, int crsrColumn, int frameWidth, int frameHeight)  //Drawing a frame of a given size
        {
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            ConsoleColor oldForeColor = Console.ForegroundColor;
            ConsoleColor oldBackColor = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleView.ToConsoleColor(VisualBoard.FRAME_COLOR); ;    //Set color of the board frame
            Console.BackgroundColor = ConsoleView.ToConsoleColor(VisualBoard.BACKDROP_COLOR);   //Set color of the board backdrop

            Console.SetCursorPosition(crsrColumn, crsrRow);          //╔ Starting point for drawing of the frame

            Console.Write("╔");
            for (int i = crsrColumn + 1; i <= crsrColumn + frameWidth - 2; ++i)
            {
                Console.SetCursorPosition(i, crsrRow);
                Console.Write("═");
            }
            Console.Write("╗");

            for (int i = crsrRow + 1; i < crsrRow + frameHeight - 1; ++i)  
            {
                Console.SetCursorPosition(crsrColumn + frameWidth - 1, i);
                Console.Write("║");
            }
            Console.SetCursorPosition(crsrColumn + frameWidth - 1, crsrRow + frameHeight - 1);  //+1
            Console.Write("╝");

            for (int i = crsrColumn + frameWidth - 2; i >= crsrColumn + 1; --i)
            {
                Console.SetCursorPosition(i, crsrRow + frameHeight - 1);  
                Console.Write("═");
            }
            Console.SetCursorPosition(crsrColumn, crsrRow + frameHeight - 1);  //+ 1
            Console.Write("╚");

            for (int i = crsrRow + frameHeight - 2; i >= crsrRow + 1; --i)  //-1 add
            {
                Console.SetCursorPosition(crsrColumn, i);
                Console.Write("║");
            }

            Console.ForegroundColor = oldForeColor;
            Console.BackgroundColor = oldBackColor;
            Console.SetCursorPosition(crsrColumn+1, crsrRow+1);
        }

    }
}
