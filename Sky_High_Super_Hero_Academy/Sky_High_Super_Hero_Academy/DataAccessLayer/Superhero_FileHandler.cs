using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sky_High_Super_Hero_Academy.BusinessLayer
{
    internal class Superhero_FileHandler
    {
        private const string fileName = "superheroes.txt";

        private string GetDataFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }

        // Formats a Superhero object into a pipe-delimited string for storage
        private string FormatSuperheroForFile(Superhero hero)
        {
            try
            {
                // Format: HeroID|Name|Age|Superpower|ExamScore|Rank|ThreatLevel
                return hero.HeroID + "|" + hero.Name + "|" + hero.Age + "|" + hero.Superpower + "|" + hero.ExamScore + "|" + hero.Rank + "|" + hero.ThreatLevel;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error formatting superhero: {ex.Message}");
            }
        }

        // Parses a line from the file and creates a Superhero object
        private Superhero LoadSuperheroFromFile(string line)
        {
            try
            {
                // Split the line by the pipe "|" delimiter
                string[] parts = line.Split('|');

                // Validate that there are the correct number of fields in the file
                if (parts.Length < 7)
                {
                    throw new Exception("Invalid data format in file.");
                }

                // Extract fields
                string heroID = parts[0].Trim();
                string name = parts[1].Trim();
                int age = int.Parse(parts[2].Trim());
                string superpower = parts[3].Trim();
                double examScore = double.Parse(parts[4].Trim());
                // Rank and ThreatLevel will be recalculated by the Superhero constructor

                return new Superhero(heroID, name, age, superpower, examScore);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading: {ex.Message}");
            }
        }

        // Method to add a new superhero to the file
        public void AddSuperhero(Superhero hero)
        {
            try
            {
                string path = GetDataFilePath();
                Directory.CreateDirectory(Path.GetDirectoryName(path) ?? AppDomain.CurrentDomain.BaseDirectory);

                string heroData = FormatSuperheroForFile(hero);

                using (StreamWriter sw = new StreamWriter(path, true)) // true = append to txt file
                {
                    sw.WriteLine(heroData);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding superhero: {ex.Message}");
            }
        }

        // Method to read all superheroes from the file
        public List<Superhero> ReadAllSuperheroes()
        {
            List<Superhero> heroes = new List<Superhero>();

            try
            {
                string path = GetDataFilePath();
                if (!File.Exists(path))
                {
                    return heroes; // No data yet
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            Superhero hero = LoadSuperheroFromFile(line);
                            if (hero != null)
                            {
                                heroes.Add(hero);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading superheroes: {ex.Message}");
            }

            return heroes;
        }

        // Method to update a superhero in the file
        public void UpdateSuperhero(string heroID, Superhero updatedHero)
        {
            try
            {
                List<Superhero> heroes = ReadAllSuperheroes();

                bool found = false;
                for (int i = 0; i < heroes.Count; i++)
                {
                    if (string.Equals(heroes[i].HeroID, heroID, StringComparison.OrdinalIgnoreCase))
                    {
                        heroes[i] = updatedHero;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    throw new Exception($"Superhero with ID {heroID} not found.");
                }

                WriteAllSuperheroes(heroes);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating superhero: {ex.Message}");
            }
        }

        // Method to delete a superhero from the file
        public void DeleteSuperhero(string heroID)
        {
            try
            {
                List<Superhero> heroes = ReadAllSuperheroes();

                Superhero heroToRemove = heroes.FirstOrDefault(h => string.Equals(h.HeroID, heroID, StringComparison.OrdinalIgnoreCase));

                if (heroToRemove == null)
                {
                    throw new Exception($"Superhero with ID {heroID} not found.");
                }

                heroes.Remove(heroToRemove);

                WriteAllSuperheroes(heroes);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting superhero: {ex.Message}");
            }
        }

        // Method to write all superheroes to the file 
        private void WriteAllSuperheroes(List<Superhero> heroes)
        {
            try
            {
                string path = GetDataFilePath();
                Directory.CreateDirectory(Path.GetDirectoryName(path) ?? AppDomain.CurrentDomain.BaseDirectory);

                using (StreamWriter sw = new StreamWriter(path, false)) // false = overwrite the .txt file
                {
                    foreach (Superhero hero in heroes)
                    {
                        string heroData = FormatSuperheroForFile(hero);
                        sw.WriteLine(heroData);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Unable to write superhero data: {ex.Message}");
            }
        }
    }
}
