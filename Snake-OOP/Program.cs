using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int x = 150;
            Wall walls = new Wall(80, 25);
            walls.Draw();

            Point snakeTail = new Point(15, 15, 's');
            Snake snake = new Snake(snakeTail, 5, Direction.RIGHT);
            snake.Draw();
            Console.ForegroundColor = ConsoleColor.Blue;

            FoodGenerator foodGenerator = new FoodGenerator(80, 25, '¤');
            Point food = foodGenerator.GenerateFood();
            food.Draw();
            Console.ForegroundColor = ConsoleColor.DarkGray;


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodGenerator.GenerateFood();
                    food.Draw();
                    score++;
                    x = x - 10;
                }



                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKeys(key.Key);
                }
                Thread.Sleep(x);


            }
            string str_score = Convert.ToString(score);
            WriteGameOver(str_score);
            Console.ReadLine();
        }

        public static void WriteGameOver(string score)
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("--------------------------", xOffset, yOffset++);
            WriteText("        MÄNG LÄBI!       ", xOffset + 1, yOffset++);
            yOffset++;
            WriteText($" Sinu skoor {score} puntki", xOffset + 2, yOffset++);
            WriteText("", xOffset + 1, yOffset++);
            WriteText("--------------------------", xOffset, yOffset++);
        }


        public static void WriteText(string text, int xOffset, int YOffset)
        {
            Console.SetCursorPosition(xOffset, YOffset);
            Console.WriteLine(text);
        }
    }
}
