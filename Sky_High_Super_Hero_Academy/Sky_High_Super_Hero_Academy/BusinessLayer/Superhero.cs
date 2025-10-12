using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sky_High_Super_Hero_Academy.BusinessLayer
{
    internal class Superhero
    {
        //fields
        string heroID, name, superpower,rank,threatLevel;
        int age;
        double examScore;

        //properties
        public string HeroID { get => heroID; set => heroID = value; }
        public string Name { get => name; set => name = value; }
        public string Superpower { get => superpower; set => superpower = value; }
        public string Rank { get => rank; private set => rank = value; }
        public string ThreatLevel { get => threatLevel; private set => threatLevel = value; }
        public int Age
        {
            get => age;
            set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Age must be a positive value."); //Testing for integer will be done in the Presentation Layer

                }
                age = value;
            }
        }

        public double ExamScore
        {
            get => examScore;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Exam Score must be between 0 and 100");
                }
                examScore = value;
            }
        }

        public Superhero(string id, string n, int a, string s, double e)
        {
            this.heroID = id;
            this.name = n;
            this.Age = a; // Assign to the property to trigger validation
            this.superpower = s;
            this.ExamScore = e; //Assign to the property to trigger validation

            CalculateRank();
            CalculateThreatLevel();
        }

        // Method to calculate rank
        public void CalculateRank()
        {
            if (examScore >= 81 && examScore <= 100)
            {
                Rank = "S-Rank";
            }
            else if (examScore >= 61 && examScore <=80)
            {
                Rank = "A-Rank";
            }
            else if (examScore >= 41 && examScore <= 60)
            {
                Rank = "B-Rank";
            }
            else if (examScore >= 0 && examScore <= 40)
            {
                Rank = "C-Rank";
            }
        }

        //Method to calculate threat level based on rank
        public void CalculateThreatLevel()
        {
            if (Rank == "S-Rank")
            {
                ThreatLevel = "Catastrophic";
            }
            else if (Rank == "A-Rank")
            {
                ThreatLevel = "High";
            }
            else if (Rank == "B-Rank")
            {
                ThreatLevel = "Moderate";
            }
            else if (Rank == "C-Rank")
            {
                ThreatLevel = "Low";
            }
            else
            {
                ThreatLevel = "Unknown";
            }
        }

    }
}
