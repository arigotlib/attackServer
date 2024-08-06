using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace atteckServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //string filePathToRead = "C:\\_kodcode2\\riposetory\\atteckServer\\Text.txt";
            //string content = await ReadFileAsync(filePathToRead);
            //Console.WriteLine(content);

            //string result = await GetDataAsync();
            //Console.WriteLine(result);
            //Console.ReadLine();
            Task<string> TaskA = GetDataFromServiceAAsync();
            Task<string> TaskB = GetDataFromServiceBAsync();
            await Task.WhenAll(TaskA, TaskB);
            Console.WriteLine(TaskA.Result);

        }
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(1000);
            return "Recived Data";
        }
        public static async Task<string> ReadFileAsync(string filePath)
        {
            string result = await Task.Run(()=> File.ReadAllText(filePath));
            return result;
        }
        public static async Task<string> GetDataFromServiceAAsync() 
        { 
            await Task.Delay(1000);
            return "dksfjklsjd";
        }
        public static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(2000);
            return "dksfjklsjd";
        }
    }
}
