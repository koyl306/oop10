using System;
using System.Collections.Generic;
using System.Linq;

namespace _10pr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sites = new List<string>
            {
                "google.com",
                "google.com.ua",
                "google.de",
                "google.fr",
                "gmail.com",
                "github.com",
                "ukr.net",
                "bulbapedia.net",
                "wikipedia.org",
                "stackoverflow.com"
            };
    
            var googleSites = sites.Where(s => s.StartsWith("google"));
    
            Console.WriteLine("Починаються з 'google':");
            foreach (var site in googleSites)
            {
                Console.WriteLine(site);
            }
        }
    }
}