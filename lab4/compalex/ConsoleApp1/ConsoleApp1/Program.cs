using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string c = s.Split(' ')[0];
            string d = s.Split(' ')[1];
            int a = int.Parse(c.Split('/')[0]);
            int b = int.Parse(c.Split('/')[1]);
            int a1 = int.Parse(d.Split('/')[0]);
            int b1 = int.Parse(d.Split('/')[1]);
            complexnum q = new complexnum(a, b);
            complexnum w = new complexnum(a1, b1);
            complexnum res = q + w;
            Console.WriteLine(res);
           // Console.ReadKey();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,res);
            fs.Close();
            bf = new BinaryFormatter();
            FileStream fss = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            complexnum v = bf.Deserialize(fss) as complexnum;
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
