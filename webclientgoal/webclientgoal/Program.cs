using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace webclientgoal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path= @"C:\Users\Queen\My Documents\mytxt.txt";
            WebClient myclient = new WebClient();
            string view=myclient.DownloadString("http://www.nairaland.com");
            Console.WriteLine(view);
            File.WriteAllText(path, view);
            Console.ReadKey();
            

        }
    }
}
