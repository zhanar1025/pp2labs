using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Snake
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
        public int cnt;
        public Snake()
        {
            body = new List<Point>();
            sign = "O";
            color = ConsoleColor.Green;
            cnt = 0;
        }
        public void Move(int dx,int dy)
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(" ");
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
            if (body[0].x > Console.WindowWidth-1)
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

        public void Draw()
        {
            int index = 0;
          
            foreach (Point p in body)
            {
               
                if (index == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = color;
                }
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }

        }

        public bool Eat(Food f)
        {
            if (body[0].x == f.loc.x && body[0].y == f.loc.y)
            {
                body.Add(new Point(0,0));
                return true;
            }
            else
                return false;
        }
        public bool Collisionwithwall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Collision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                {
                    return true;
                }
            }
            return false;
        }
        public void Serialization()
        {
            StreamWriter sw = new StreamWriter("data.xml", false);
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            xs.Serialize(sw, this);
            sw.Close();

        }
        public Snake Deserialization()
        {
            FileStream nfs = new FileStream("data.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer nxs = new XmlSerializer(typeof(Snake));
            Snake n = nxs.Deserialize(nfs) as Snake;
            nfs.Close();
            return n;
            
        }

    
    }
}
