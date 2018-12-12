using System;

namespace EllersAlgorithm
{
    class Program
    {
        const int Height = 100;
        const int Width = 20;

        static void Main(string[] args)
        {
            Maze maze = new Maze();
            maze.GenerateMaze(Width, Height);

            // maze.PrintMaze();

            string[,] translatedMaze = maze.TranslateMaze();
            PrintTranslatedMaze(translatedMaze);

            Console.ReadKey();
        }

        // Prints a translated maze
        static void PrintTranslatedMaze(string[,] maze)
        {
            for (int i = 0; i < Height * 2 + 2; i++)
            {
                for (int j = 0; j < Width * 2 + 2; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine();
            }           
        }

    }
}
