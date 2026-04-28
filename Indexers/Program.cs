using System.Net;

namespace Indexers
{
    public class MyCookieCollection
    {
        private static Dictionary<string, string> cookies = new Dictionary<string, string>();

        public string this[string name]
        {
            get
            {
                if (cookies.ContainsKey(name))
                {
                    return cookies[name];
                   
                }
                else
                {
                    return null;
                }
            }
            set
            {
                cookies[name] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var cookieCollection = new MyCookieCollection();
            cookieCollection["Username"] = "Mai";
            cookieCollection["theme"] = "dark";

            Console.WriteLine($"Username: {cookieCollection["Username"]}");
            Console.WriteLine($"Theme: {cookieCollection["theme"]}");
            Console.WriteLine($"Language:{cookieCollection["language"] ?? "Not Set"}");


        }
    }
}
