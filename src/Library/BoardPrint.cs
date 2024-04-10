using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    public class BoardPrint
    {
        public bool[,] board { get; set; }
    
        public BoardPrint(bool[,] board)
        {
            this.board = board;
        }
        public void BoardPrinter()
        {
            bool[,] b = board;
            int width = board.GetLength(0);
            int height = board.GetLength(1);
            Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
        }
    }
}
