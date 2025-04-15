using System;

namespace Medics
{
    public abstract class DentalDoctor : IDisplayable
    {
        public string Name { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }
        public string TreatmentType { get; set; }

        protected DentalDoctor(string name, int experienceYears, decimal salary, string treatmentType)
        {
            Name = name;
            ExperienceYears = experienceYears;
            Salary = salary;
            TreatmentType = treatmentType;
        }

        public abstract void DisplayInfo();

        public void DisplayExperience()
        {
            Console.WriteLine($"{Name} має {ExperienceYears} років досвіду.");
        }

        public abstract decimal CalculatePayment();
    }
}
