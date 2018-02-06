using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake
    {
        List<point> body;
        String sign;
        ConsoleColor color;
        public int cnt;
        public snake()
        {
            body=new List<point>();
            body.Add(new point(10,10));
            sign = "+";
            color = ConsoleColor.DarkMagenta;
            cnt = 0;
        }
        public void move(int dx, int dy)
        {
            cnt++;
            if (cnt % 20 == 0)
            {
                body.Add(new point(0, 0));
            }
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;
            if (body[0].x < 1)
            {
                body[0].x = Console.WindowWidth - 1;
            }
            if (body[0].x > Console.WindowWidth - 1)
            {
                body[0].x = 1;
            }
            if (body[0].y < 1)
            {
                body[0].y = Console.WindowHeight - 1;
            }
            if (body[0].y > Console.WindowHeight - 1)
            {
                body[0].y = 1;
            }
        }
            public void draw()
        {
            int i = 0;
            foreach(point p in body)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                i++;
            }
        }
        public bool CollisionWithWall(wall w)
        {
            foreach (point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                {
                    return true;
                }
                return false;
            }
        }
            public bool Collision()
            {
                for(int i = 1; i < body.Count; i++)
                {
                    if (body[0].x == body[i].x && body[0].y == body[i].y)
                        return true;
                }
                return false;

            }
        }

        
    }
