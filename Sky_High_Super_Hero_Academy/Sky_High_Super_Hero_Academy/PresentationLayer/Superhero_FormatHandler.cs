using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sky_High_Super_Hero_Academy.BusinessLayer
{
    internal class Superhero_FormatHandler
    {
        // The type of file is a pype delimited text file
        private const char DELIMITER = '|'; 

        // Method to format a Superhero object into a string for file storage
        public string FormatSuperheroForFile(Superhero hero)
        {
            try
            {
                // Example Format: HeroID|Name|Age|Superpower|ExamScore|Rank|ThreatLevel
                return $"{hero.HeroID}{DELIMITER}" +
                       $"{hero.Name}{DELIMITER}" +
                       $"{hero.Age}{DELIMITER}" +
                       $"{hero.Superpower}{DELIMITER}" +
                       $"{hero.ExamScore}{DELIMITER}" +
                       $"{hero.Rank}{DELIMITER}" +
                       $"{hero.ThreatLevel}";
            }
            catch (Exception ex)
            {
                throw new Exception($"Error formatting superhero: {ex.Message}");
            }
        }

        // Method to load a string from the file and create a Superhero object
        public Superhero LoadSuperheroFromFile(string line)
        {
            try
            {
                // Split the line by the delimiter
                string[] parts = line.Split(DELIMITER);

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
                // Altough Rank and ThreatLevel are stored it will be recalculated by constructor 
                // in order to ensure that they are always correct incase the rules regarding Rank and Treaht level change

                // The constructor will auto calculate rank and threat level
                return new Superhero(heroID, name, age, superpower, examScore);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading: {ex.Message}");
            }
        }

        // Method to validate superhero data before saving
        public bool IsValidSuperheroData(string heroID, string name, string ageStr,string superpower, string examScoreStr)
        {

            // To be implemented
            return true;
        }

        //Other methods to be implemented: HeroIDExists??



    }
}
