using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class level
    {
        static void main(string [] args)
        {
            int level = 1;
            Snake snake = new Snake();
            Wall wall = new wall;
            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    snake.move(0, 1);
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    snake.move(0, -1);
                }
                if (keyinfo.Key == ConsoleKey.RightArrow)
                {
                    snake.move(1, 0);
                }
                if (keyinfo.Key == ConsoleKey.LeftArrow)
                {
                    snake.move(-1, 0);
                }
                if (keyinfo.Key = ConsoleKey.R)
                {
                    level = 1;
                    snake = new Snake;
                    wall = new Wall(level);
                }
                if (snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("game over!!!!");
                    Console.ReadKey();
                    snake = new Snake;
                    level = 1;
                    wall = new Wall(level);
                }
                if(snake.cnt % 400 == 0)
                {
                    level++;
                    wall = new Wall(level);
                }
                Console.Clear();
                snake.draw();
                wall.draw();
            }
        }
    }
}
