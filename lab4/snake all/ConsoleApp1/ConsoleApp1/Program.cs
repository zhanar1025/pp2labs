using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static int level = 1;
        static int score = 0;
        static int last = 0;
        static int cnt = 0;
        static int direction = 1;
        static int speed = 200;

        static Snake snake = new Snake();
        static Wall wall = new Wall(level);
        static Food food = new Food();
        public static void MoveSnake()
        {
            while (true)
            {
                switch (direction) {
                    case 1:
                        snake.Move(0, 1);
                        break;
                    case 2:
                        snake.Move(0, -1);
                        break;
                    case 3:
                        snake.Move(-1, 0);
                        break;
                    case 4:
                        snake.Move(1, 0);
                        break;

                }


                if (snake.Collisionwithwall(wall)== true || snake.Collision() == true)

                {
                    Console.Clear();

                    Console.SetCursorPosition(5, 5);

                    Console.WriteLine("GAME OVER!!!!");
                    Console.ReadKey();

                    while (true)
                    {
                        ConsoleKeyInfo k = Console.ReadKey();
                        if (k.Key == ConsoleKey.Enter)
                        {
                            
                            Console.Clear();
                            snake = new Snake();
                            wall = new Wall(level);
                            food = new Food();
                            food.Draw();
                            wall.Draw();
                            snake.Draw();
                            break;
                        }
                    }
                }
                if (snake.Eat(food))
                {
                    food.Setrandompos(snake,wall);
                    score ++;
                    cnt++;
                }
                if (cnt == 3)
                {
                    level++;
                    cnt = 0;
                    wall = new Wall(level);
                }
                snake.Draw();
                food.Draw();
                wall.Draw();
                Thread.Sleep(speed);
                if (score == level * 5)
                {
                    speed = Math.Max(1, speed - 50);
                }
                Console.SetCursorPosition(30, 20);
                Console.WriteLine("score: " + score);
                Console.SetCursorPosition(39, 20);
                Console.WriteLine("level: " + level);

            }
            

        }
        static void Main(string[] args)
        {
            snake.body.Add(new Point(10, 10));
                Console.CursorVisible = false;
                Console.SetWindowSize(80, 30);
                wall.Draw();
            Thread t = new Thread(MoveSnake);
            t.Start();
            while (true)
            {
               
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow && last!=3) {
                    last = 4; 
                    direction = 1;
                }

                if (keyInfo.Key == ConsoleKey.UpArrow && last != 4) {
                    last = 3;
                    direction = 2;
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow && last!=1)
                {
                    last = 2;
                    direction = 3;
                
                }
                if (keyInfo.Key == ConsoleKey.RightArrow && last!=2)
                {
                    last = 1;
                    direction = 4;
                
                }
                if (keyInfo.Key == ConsoleKey.S)
                {
                    t.Suspend();
                    snake.Serialization();
                    food.Serialization();
                    wall.Serialization(); 
                }
                if (keyInfo.Key == ConsoleKey.D)
                {
                    t.Resume();
                    snake = snake.Deserialization();
                    wall = wall.Deserialization();
                    food = food.Deserialization();
                    wall.Draw();
                    
                }
            }
        }
    }
}
