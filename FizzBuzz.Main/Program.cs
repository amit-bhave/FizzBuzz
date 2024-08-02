using FizzBuzz.Models;
using FizzBuzz.Service;
using FizzBuzz.DAL;

using Microsoft.Extensions.DependencyInjection;
using FizzBuzz.DAL.Interfaces;

namespace FizzBuzz.Main
{
    public static class Program
    {        

        public static void Main(string[] args)
        {
            // Setting Up Dependency Injection.

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFizzBuzzService, FizzBuzzService>()
                .AddSingleton<IFizzBuzzDataRepo, FizzBuzzDataRepo>()
                .BuildServiceProvider();

            var fizzbuzzService = serviceProvider.GetRequiredService<IFizzBuzzService>();
            var fizzbuzzRepo = serviceProvider.GetRequiredService<IFizzBuzzDataRepo>();



            var resultlist = fizzbuzzService.GetFizzBuzzResults();
            
            fizzbuzzRepo.SaveFizzBuzzResults(resultlist);

            foreach (var result in resultlist) {
                Console.WriteLine($"Number: {result.FizzBuzzNumber} - Text: {result.FizzBuzzResultText}");
            }            

            Console.ReadKey();
            
        }
    }
}
