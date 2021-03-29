using System;

namespace CloudflareDynDNS
/*
Created by Valentino Duval
This will autoupdate a cloudflare zone DNS entry with the current IP of the machine it is running on.
Useful for cases when you want reverse DNS functionality without the need for a seperate service as long as you have a cloudflare activated domain.
*/
{

    static class Constants
    {
        public const string cFlareAPIKey = ""; // Key must have Zone DNS editing permissions
        public const int sleepInMS = 300000; // (1 Min = 60000)
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class ProgFuncs
    {
        

        public string getIPv4()
        {
            string ip = null;





            return ip;
        }
    }
}
