using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _86_Linq
{
    class ChessPlayer
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int Rating { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Full Name: {FirstName + " " + LastName}, Rating = {Rating}, from {Country}, born in {BirthYear}";
        }

        public static ChessPlayer ParseFideCsv(string line)
        {
            string[] parts = line.Split(';');
            return new ChessPlayer()
            {
                Id = int.Parse(parts[0]),
                LastName = parts[1].Split(' ')[0].Trim(),
                FirstName = parts[1].Split(' ')[1].Trim(),
                Country = parts[3],
                Rating = int.Parse(parts[4]),
                BirthYear = int.Parse(parts[6])
            };
        }

        public static void MinMaxSumAverage(string file)
        {
            IEnumerable<ChessPlayer> list = File.ReadAllLines(file)
                                         .Skip(1)
                                         .Select(ParseFideCsv)
                                         .Where(player => player.BirthYear > 1988)
                                         .OrderByDescending(player => player.Rating)
                                         .ThenBy(player=>player.Country)
                                         .Take(10);
            //.ToList();

            Console.WriteLine($"The lowest rating in TOP 10 : {list.Min(player => player.Rating)}");
            Console.WriteLine($"The highest rating in TOP 10 : {list.Max(player => player.Rating)}");
            Console.WriteLine($"The avarage rating in TOP 10 : {list.Average(player => player.Rating)}");

            Console.WriteLine(list.First());
            Console.WriteLine(list.Last());

            Console.WriteLine(list.First(player => player.Country == "USA"));
            Console.WriteLine(list.Last(player => player.Country == "USA"));

            var firstFromBra = list.FirstOrDefault(player => player.Country == "BRA");
            var LastFromBra = list.LastOrDefault(player => player.Country == "BRA");
            if (firstFromBra != null)
            {
                Console.WriteLine(firstFromBra.LastName);
            }

            Console.WriteLine(list.Single(player => player.Country == "FRA")); // 
            Console.WriteLine(list.SingleOrDefault(player => player.Country == "FRA"));

        }
    }


    
}
