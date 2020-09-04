using System;
using System.Net;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient Client = new WebClient();
            try
            {
                Client.DownloadFile("http://3.bp.blogspot.com/-qXtmJRAlJcA/U413iy_YzKI/AAAAAAAAOn8/Ajr4B8h9TcE/s1600/google-logo-high-res.png", @"C:\Users\Ivan\Desktop\image.png");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address or fileName parameter is null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error! Possible causes:\n1. The URI formed by combining BaseAddress and address is invalid.\n2. filename is null or Empty.\n3. The file does not exist.\n4. An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}
