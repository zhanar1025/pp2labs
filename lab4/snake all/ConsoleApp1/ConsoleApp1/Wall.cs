using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    public class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
        public void Readlevel(int level)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Zhanar\Desktop\pp2labs\lab4\level" + level + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '#')
                        body.Add(new Point(j, i));
            }
            sr.Close();
        }
        public Wall()
        {

        }
        public Wall(int level)
        {
            body = new List<Point>();
            sign = "+";
            color = ConsoleColor.Blue;
            Readlevel(level);
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        public void Serialization()
        {
            StreamWriter sw = new StreamWriter("data2.xml", false);
            XmlSerializer xs = new XmlSerializer(typeof(Wall));
            xs.Serialize(sw, this);
            sw.Close();

        }
        public Wall Deserialization()
        {
            FileStream nfs = new FileStream("data2.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer nxs = new XmlSerializer(typeof(Wall));
            Wall m = nxs.Deserialize(nfs) as Wall;
            nfs.Close();
            return m;
        }
    }
}
