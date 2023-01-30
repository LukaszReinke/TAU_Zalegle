using System;

namespace Gra5x5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();

            int[,] map = game.GetMap();
            int startX = game.GetStartX();
            int startY = game.GetStartY();
            int endX = game.GetEndX();
            int endY = game.GetEndY();
            int playerX = startX;
            int playerY = startY;

            Console.WriteLine("Mapa 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == playerY && j == playerX)
                    {
                        Console.Write("P ");
                    }
                    else if (i == endY && j == endX)
                    {
                        Console.Write("E ");
                    }
                    else if (map[i, j] == 1)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Gra wystartowała. Przejdź od punktu startowego do punktu końcowego omijając przeszkody.");

            while (playerX != endX || playerY != endY)
            {
                Console.WriteLine("Podaj kierunek ruchu (W = góra, S = dół, A = lewo, D = prawo):");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        if (playerY > 0 && map[playerY - 1, playerX] != 1)
                        {
                            playerY--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (playerY < 4 && map[playerY + 1, playerX] != 1)
                        {
                            playerY++;
                        }
                        break;
                    case ConsoleKey.A:
                        if (playerX > 0 && map[playerY, playerX - 1] != 1)
                        {
                            playerX--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (playerX < 4 && map[playerY, playerX + 1] != 1)
                        {
                            playerX++;
                        }
                        break;
                }

                Console.Clear();
                Console.WriteLine("Mapa 5x5:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == playerY && j == playerX)
                        {
                            Console.Write("P ");
                        }
                        else if (i == endY && j == endX)
                        {
                            Console.Write("E ");
                        }
                        else if (map[i, j] == 1)
                        {
                            Console.Write("X ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    Console.WriteLine();
                }
                
            }
            Console.WriteLine("Gratulacje! Udało Ci się przejść od punktu startowego do punktu końcowego omijając przeszkody.");
            Console.ReadKey();

        }
        public class Game
        {
            private int[,] map;
            private int startX;
            private int startY;
            private int endX;
            private int endY;
            private Random random;

            public Game()
            {
                map = new int[5, 5];
                random = new Random();

                startX = random.Next(0, 5);
                startY = random.Next(0, 5);
                endX = random.Next(0, 5);
                endY = random.Next(0, 5);

                while (startX == endX && startY == endY)
                {
                    endX = random.Next(0, 5);
                    endY = random.Next(0, 5);
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == startY && j == startX || i == endY && j == endX)
                        {
                            continue;
                        }

                        int r = random.Next(0, 10);
                        if (r >= 5)
                        {
                            map[i, j] = 1;
                        }
                    }
                }
            }

            public int[,] GetMap()
            {
                return map;
            }

            public int GetStartX()
            {
                return startX;
            }

            public int GetStartY()
            {
                return startY;
            }

            public int GetEndX()
            {
                return endX;
            }

            public int GetEndY()
            {
                return endY;
            }
        }
    }
}
