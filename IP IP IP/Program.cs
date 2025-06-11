using System.Net.Sockets;
using System.Net;

namespace IP_IP_IP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VerkrijgIP());
        }
        static string[] VerkrijgIP()
        {
            //Verander niets aan deze code!
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString().Split(".");
                    }
                }
                return new string[] { "0", "0", "0", "0" }; //indien geen adres gevonden
            }
            catch (Exception ex)
            {
                return new string[] { "0", "0", "0", "0" };
            }
        }
    }
}
