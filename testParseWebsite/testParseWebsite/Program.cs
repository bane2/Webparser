using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace testParseWebsite
{
    class Program
    {
        private static string pattern = "<div[^>]+(id|class)=[^>]*>";

        static void Main(string[] args)
        {
            WebClient client = new WebClient();

            string Quelltext = String.Empty;

            //string url = @"http://selfservice.campus-dual.de/dash/getexamstats?user=3001878&hash=d8430243f0cbcb26763eff1fc3713ddf";
            //string urlNoten = @"https://selfservice.campus-dual.de/acwork/index";
            string google = @"http://www.google.de";
            Quelltext = client.DownloadString(google);


            Console.WriteLine(Quelltext.Length);
            Console.ReadKey();

            string Quelltext1 = Remove(Quelltext);
            Console.WriteLine(Quelltext1.Length);
            Console.ReadKey();
            MatchCollection Quelltext2 = Matches(Quelltext);
            Console.WriteLine(Quelltext2.Count + " Treffer");
            foreach (Match item in Quelltext2)
            {
                Console.WriteLine(item);
                //Console.ReadKey();
            }
            Console.ReadKey();
            //Console.WriteLine(Quelltext2.Length);
            //dynamic json = JsonConvert.DeserializeObject(Quelltext);
                      
           
            
        }

        public static string Remove(string input)
        {
            return Regex.Replace(input,pattern, String.Empty);
        }
        public static MatchCollection Matches(string input)
        {
            //MatchCollection list = new MatchCollection();
            return Regex.Matches(input, pattern);
        }

    }
}
