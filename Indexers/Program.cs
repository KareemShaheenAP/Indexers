using System.Net;

namespace Indexers
{
    public class MyCookieCollection
    {
        private static Dictionary<string, string> cookies = new Dictionary<string, string>();
        private string _user;
        public MyCookieCollection(string user)
        {
            _user = user;
        }

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
                if (_user != "mai")
                {
                    Console.WriteLine("Access denied");
                }
                else
                {
                    cookies[name] = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter username");
            string userinput = Console.ReadLine();

            var cookieCollection = new MyCookieCollection(userinput);
            cookieCollection["Username"] = userinput;

            Console.WriteLine("Please enter theme");
            userinput = Console.ReadLine();

            cookieCollection["theme"] = userinput;

            Console.WriteLine($"Username: {cookieCollection["Username"]}");
            Console.WriteLine($"Theme: {cookieCollection["theme"]}");
            Console.WriteLine($"Language:{cookieCollection["language"] ?? "Not Set"}");


        }
    }
}
