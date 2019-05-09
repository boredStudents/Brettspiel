using System;
using System.IO;
using Newtonsoft.Json;

namespace BrettspielClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LocalPlayer me = new LocalPlayer("Benni", new DateTime(2000, 10, 4));

            Console.WriteLine(MessageManager.GetMessageTypeFromMessage(MessageManager.LoginMessage(me)));

            Console.WriteLine(MessageManager.MakeTotalMessage(MessageManager.LoginMessage(me),MessageManager.LoginMessage(me)));

            Console.ReadLine();
        }
    }
}
