// See https://aka.ms/new-console-template for more information
using AreaShapeCalculator.Util;
using log4net;
using log4net.Config;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

        Console.WriteLine("Welcome to Shape Area Calculator.");
        Console.WriteLine("To Get Help type /?");
        string cLine = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrEmpty(cLine)) { cLine = "/?"; };

        while (cLine.ToLower() != "exit")
        {
            AppLog<Program>.Log("Command : " + cLine);
            if (cLine == "/?")
            {
                Console.WriteLine("This program calculate the area of various kind of shapes.");
                Console.WriteLine("To use the AreaShapeCalculator enter name of shape and dimension(s)");
                Console.WriteLine("For Example : ");
                Console.WriteLine("Square 10");
                Console.WriteLine("Triangle 5 19");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("To Exit type Exit");
                Console.WriteLine("P.S : The name of shape is not case-sensitive!");
            }
            else
            {
                CommandParser.Instance.Parse(cLine);
            }
            Console.WriteLine("New Command : ");
            cLine = Console.ReadLine() ?? string.Empty;
        }

        Console.WriteLine("Enter any key to exit..");
        Console.ReadLine();
    }
}