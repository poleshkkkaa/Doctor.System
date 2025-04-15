using System;

namespace Medics
{
    public class DentalTechnician : IDisplayable
    {
        public string Name { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }
        public string Specialization { get; set; }

        public DentalTechnician(string name, int experienceYears, decimal salary, string specialization)
        {
            Name = name;
            ExperienceYears = experienceYears;
            Salary = salary;
            Specialization = specialization;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Зубний технік {Name}, спеціалізація: {Specialization}, зарплата: {Salary}$");
        }

        public void DisplayExperience()
        {
            Console.WriteLine($"{Name} має {ExperienceYears} років досвіду.");
        }
    }
}
