using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aleha login \n\n");
            Request req = new Request();
            string[] parseAnswer = req.loginUser("PanAleha", "loveAleha1");
            
            Console.WriteLine(parseAnswer[0]);
            Console.WriteLine('\n');
            Console.WriteLine(parseAnswer[1]);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
            /*
            Console.WriteLine('\n');
            Console.WriteLine("Alex register \n\n");
            string[] registerAnswer = req.registerUser("Alex", "55555");
            registerAnswer[1] = registerAnswer[1].Substring(15);
            */
            /*
            Console.WriteLine('\n');
            Console.WriteLine("Cafe list get \n\n");
            string[] parseCafes = req.getCafes(parseAnswer[1]);
            Console.WriteLine(parseCafes[0]);
            Console.WriteLine('\n');
            Console.WriteLine(parseCafes[1]);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
            */
            /*
            Console.WriteLine('\n');
            Console.WriteLine("Add cafe \n\n");
            string[] addCafeAnswer = req.addCafe(parseAnswer[1], "Name1", "Descr1", "City1");
            Console.WriteLine(addCafeAnswer[0]);
            Console.WriteLine('\n');
            Console.WriteLine(addCafeAnswer[1]);
            */
            /*
            Console.WriteLine('\n');
            Console.WriteLine("Get cafe reviews \n\n");
            string[] getRevAnswer = req.getRevCafe(parseAnswer[1], 1);
            Console.WriteLine(getRevAnswer[0]);
            Console.WriteLine('\n');
            Console.WriteLine(getRevAnswer[1]);
            */
            Console.WriteLine('\n');
            Console.WriteLine("Add cafe review \n\n");
            string[] getAddRevAnswer = req.getRevCafe(parseAnswer[1], 1);
            Console.ReadLine();
        }
    }
}
