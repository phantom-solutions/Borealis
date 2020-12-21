using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;

namespace Borealis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //THIS CREATES THE WEBSITE FRONT-END
            //CreateHostBuilder(args).Build().Run();  

            //FIGURE OUT HOW TO RUN BOTH OF THESE SIMULTANIOUSLY

            //THIS HANDLES CREATING THE DATA TRANSFER SYSTEM BETWEEN THE AGENT AND THE CONTROL PANEL
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 1234);
            TcpListener listener = new TcpListener(ep);
            listener.Start();

            Console.WriteLine("Borealis Server Manager - Listening for Requests at {0}:{1}", ep.Address, ep.Port);

            // Run the loop continously; this is the server.
            while (true)
            {
                const int bytesize = 1024 * 1024;

                string message = null;
                byte[] buffer = new byte[bytesize];

                var sender = listener.AcceptTcpClient();
                sender.GetStream().Read(buffer, 0, bytesize);

                // Read the message, and perform different actions
                message = cleanMessage(buffer);

                // Save the data sent by the client;
                Person agent = JsonConvert.DeserializeObject<Person>(message); // Deserialize
                byte[] bytes = System.Text.Encoding.Unicode.GetBytes("[SERVER RESPONSE] Payload Received from " + agent.Hostname);
                sender.GetStream().Write(bytes, 0, bytes.Length); // Send the response
                Console.WriteLine("[AGENT: {0} | IP ADDRESS: {1}] | JSON_JATA01: {2}, JSON_JATA02: {3}, JSON_JATA03: {4}", agent.Hostname, agent.Agent_IP, agent.JSON_DATA01, agent.JSON_DATA02, agent.JSON_DATA03);
            }
        }

        private static string cleanMessage(byte[] bytes)
        {
            string message = System.Text.Encoding.Unicode.GetString(bytes);

            string messageToPrint = null;
            foreach (var nullChar in message)
            {
                if (nullChar != '\0')
                {
                    messageToPrint += nullChar;
                }
            }
            return messageToPrint;
        }

        // Sends the message string using the bytes provided.
        private static void sendMessage(byte[] bytes, TcpClient client)
        {
            client.GetStream()
                .Write(bytes, 0,
                bytes.Length); // Send the stream
        }

    class Person
    {
        public string Hostname { get; set; }
        public string Agent_IP { get; set; }
        public string JSON_DATA01 { get; set; }
        public string JSON_DATA02 { get; set; }
        public string JSON_DATA03 { get; set; }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
