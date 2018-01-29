using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_1
{
    class Program
    {
        static void Show(DirectoryInfo d,int k)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] f = d.GetFileSystemInfos();
            for(int i = 0; i < f.Length; i++)
            {
                FileSystemInfo a = f[i];
                if (i == k)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                Console.WriteLine(a.Name);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d =new DirectoryInfo(@"C:\Users\Zhanar\Desktop\pp2labs");
            int k = 0;
            int n = d.GetFileSystemInfos().Length;
            Show(d, k);
            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    k++;
                    if (k == n)
                        k = 0;
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    k--;
                    if (k == -1)
                        k = n-1;
                }
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    if (d.GetFileSystemInfos()[k].GetType() == typeof(DirectoryInfo))
                        {
                        d = new DirectoryInfo(d.GetFileSystemInfos()[k].FullName);
                        k = 0;
                        n = d.GetFileSystemInfos().Length;

                    }
                    else
                    {
                        StreamReader sr = new StreamReader(d.GetFileSystemInfos()[k].FullName);
                        string s = sr.ReadToEnd();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }
                }
                if (keyinfo.Key == ConsoleKey.Escape)
                {
                    if (d.Parent != null)
                    {
                        d = d.Parent;
                        k = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    else
                        break;
                }
                Show(d, k);
   
            }
        }
    }
}
