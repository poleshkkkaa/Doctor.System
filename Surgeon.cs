using System;

namespace Medics
{
    public abstract class Surgeon : IDisplayable
    {
        public string Name { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }
        public string Specialization { get; set; }

        protected Surgeon(string name, int experienceYears, decimal salary, string specialization)
        {
            Name = name;
            ExperienceYears = experienceYears;
            Salary = salary;
            Specialization = specialization;
        }

        public abstract void DisplayInfo();

        public void DisplayExperience()
        {
            Console.WriteLine($"{Name} має {ExperienceYears} років досвіду.");
        }

        public abstract decimal CalculatePayment();
    }
}
