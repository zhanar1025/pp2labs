using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    public class Food
    {
        public char sign;
        public Point loc;
        ConsoleColor color;
        public Food()
        {
            sign ='&';
            color = ConsoleColor.DarkMagenta;
            loc = new Point(10, 10);
        }
        public void Setrandompos(Snake s, Wall w)
        {
            int x = new Random().Next(2, Console.WindowWidth);
            int y = new Random().Next(2, Console.WindowHeight);
            bool ok = false;
            for(int i = 0; i < s.body.Count; i++)
            {
                if(x == s.body[i].x && y == s.body[i].y)
                {
                    ok = true;
                }
            }
            for(int i = 0; i < w.body.Count; i++)
            {
                if(x == w.body[i].x && y == w.body[i].y)
                {
                    ok = true;
                }
            }
            if (!ok)
            {
                loc.x = x;
                loc.y = y;
            }
            else
            {

                Setrandompos(s,w);
            }
                

        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(loc.x, loc.y);
            Console.Write(sign);
        }

        public void Serialization()
        {
            StreamWriter sw = new StreamWriter("data1.xml", false);
            XmlSerializer xs = new XmlSerializer(typeof(Food));
            xs.Serialize(sw, this);
            sw.Close();

        }
        public Food Deserialization()
        {
            FileStream nfs = new FileStream("data1.xml", FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer nxs = new XmlSerializer(typeof(Food));
            Food k= nxs.Deserialize(nfs) as Food;
            nfs.Close();
            return k;

        }
    }
}
