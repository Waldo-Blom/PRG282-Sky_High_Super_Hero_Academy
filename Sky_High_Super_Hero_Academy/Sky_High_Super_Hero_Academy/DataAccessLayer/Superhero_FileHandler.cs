using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Sky_High_Super_Hero_Academy.PresentationLayer;

namespace Sky_High_Super_Hero_Academy.BusinessLayer
{
    internal class Superhero_FileHandler
    {
        private const string fileName = "superheroes.txt";
        private Superhero_FormatHandler formatHandler = new Superhero_FormatHandler();

        // Method to add a new superhero to the file
        public void AddSuperhero(Superhero hero)
        {
            try
            {
                string heroData = formatHandler.FormatSuperheroForFile(hero);

                using (StreamWriter sw = new StreamWriter(fileName, true)) // true = append to txt file
                {
                    sw.WriteLine(heroData);
                }

                Console.WriteLine("Added superhero successfully.");
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
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            Superhero hero = formatHandler.LoadSuperheroFromFile(line);
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
                    if (heroes[i].HeroID == heroID)
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

                Console.WriteLine("Updated superhero successfully.");
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

                Superhero heroToRemove = heroes.FirstOrDefault(h => h.HeroID == heroID);

                if (heroToRemove == null)
                {
                    throw new Exception($"Superhero with ID {heroID} not found.");
                }

                heroes.Remove(heroToRemove);

                WriteAllSuperheroes(heroes);

                Console.WriteLine("Deleted superhero successfully.");
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
                using (StreamWriter sw = new StreamWriter(fileName, false)) // false = overwrite the .txt file
                {
                    foreach (Superhero hero in heroes)
                    {
                        string heroData = formatHandler.FormatSuperheroForFile(hero);
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
