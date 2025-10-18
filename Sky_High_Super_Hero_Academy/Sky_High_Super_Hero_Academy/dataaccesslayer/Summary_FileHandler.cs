using System;
using System.Collections.Generic;
using System.IO;
using Sky_High_Super_Hero_Academy.BusinessLayer;

namespace Sky_High_Super_Hero_Academy.DataAccessLayer
{
    public class Summary_FileHandler
    {
        private readonly string heroesFile = "superheroes.txt";
        private readonly string summaryFile = "summary.txt";

        public List<Hero> LoadHeroes()
        {
            var heroes = new List<Hero>();

            if (!File.Exists(heroesFile))
                throw new FileNotFoundException("The file superheroes.txt was not found.");

            foreach (var line in File.ReadAllLines(heroesFile))
            {
                var parts = line.Split('|');
                if (parts.Length >= 7)
                {
                    heroes.Add(new Hero
                    {
                        ID = parts[0],
                        Name = parts[1],
                        Age = int.Parse(parts[2]),
                        ExamScore = double.Parse(parts[4]),
                        Rank = parts[5],
                        ThreatLevel = parts[6]
                    });
                }
            }

            return heroes;
        }

        public void SaveSummary(string summaryReport)
        {
            File.AppendAllText(summaryFile, summaryReport);
        }
    }
}
