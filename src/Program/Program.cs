using System;
using System.Threading;
namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardReader boardReader = new BoardReader();
            Board board = new Board();
            board.board = boardReader.ReadBoard("C:\\Users\\Santiago\\Desktop\\programacion2\\EjExpert\\gameOfLife\\assets\\board.txt");
            GameLogic gameLogic = new GameLogic(board.board);
            while (true)
            {
                board.board = gameLogic.NextGen();
                BoardPrint boardPrint = new BoardPrint(board.board);
                boardPrint.BoardPrinter();
                Thread.Sleep(3000);
            }

        }
    }
}
