using System;
using System.IO;
using System.Net.Mime;
using System.Reflection;
using System.ServiceProcess;
using System.Threading;
using TcpUdpForwarder.Model;
using TcpUdpForwarder.Controller;
using TcpUdpForwarder.View;
using TcpUdpForwarder.Services;

namespace ForwarderService
{
    class Program
    {
        static bool is_svc = true;
        
        static void Main(string[] args)
        {
            //Directory.SetCurrentDirectory(Application.StartupPath);
            Console.WriteLine("Starting ForwarderService..");
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            Logging.OpenLogFile(is_svc);
            
            ServiceBase[] servicesToRun;
            servicesToRun = new ServiceBase[] 
            { 
                new TcpUdpForwarder.Services.TcpUdpForwarder() 
            };
            ServiceBase.Run(servicesToRun);

           
            //var controller = new ForwarderController(true);
            //controller.Start();
            //Thread.Sleep(1000000000);


        }
    }
}
