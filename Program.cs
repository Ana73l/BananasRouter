using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace BananasRouter
{
    class Program
    {
        static string GetHtml(string content, int pageNum)
        {
            string sUrl = "http://zamunda.net/bananas?c42=1&c25=1&c35=1&c46=1&c20=1&c19=1&c5=1&c24=1&c31=1&c28=1&c7=1&c33=1&c39=1&c4=1&c21=1&c17=1&c40=1&c12=1&c6=1&c30=1&c29=1&c51=1&c34=1&c38=1&c1=1&c22=1&c43=1&c41=1&c36=1&c52=1&c53=1&c26=1&c23=1&c32=1&c37=1&search=" + string.Join("+", content.Split().ToArray()) + "&page=" + (pageNum - 1);
            WebRequest request = WebRequest.Create(sUrl);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            response.Close();

            return result;
        }

        static void Main(string[] args)
        {
            string content = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(GetHtml(content, index));
            System.IO.File.WriteAllText("text.txt", result);

            Console.ReadKey();
        }
    }
}
