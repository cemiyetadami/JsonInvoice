using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace SeansOWINRestService
    {
    public class Program
        {
        static void Main()
            {
            string baseAddress = "http://127.0.0.1:9000/";

            // Start OWIN host 
            using (WebApp.Start(url: baseAddress))
                {
                Console.WriteLine("Service Listening at " + baseAddress);

                System.Threading.Thread.Sleep(-1);
                }
            }
        }
    }