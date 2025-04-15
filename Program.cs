using System;
using System.Text;

namespace Medics
{
  
    public class Stomatologist : DentalDoctor
    {
        public Stomatologist(string name, int experienceYears, decimal salary, string treatmentType): base(name, experienceYears, salary, treatmentType)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Стоматолог {Name}, тип лікування: {TreatmentType}, зарплата: {Salary}$");
        }

        public override decimal CalculatePayment()
        {
            return 350m;
        }
    }

    public class Dentist : DentalDoctor
    {
        public Dentist(string name, int experienceYears, decimal salary, string treatmentType): base(name, experienceYears, salary, treatmentType)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Дантист {Name}, тип лікування: {TreatmentType}, зарплата: {Salary}$");
        }

        public override decimal CalculatePayment()
        {
            return 80m;
        }
    }

    public class PlasticSurgeon : Surgeon
    {
        public string ProcedureType { get; set; }

        public PlasticSurgeon(string name, int experienceYears, decimal salary, string procedureType)  : base(name, experienceYears, salary, "Пластична хірургія")
        {
            ProcedureType = procedureType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Хірург {Name}, спеціалізація: {Specialization}, зарплата: {Salary}$");
            Console.WriteLine($"Вид пластики: {ProcedureType}");
        }

        public override decimal CalculatePayment()
        {
            return 3100m;
        }
    }

    public class Neurosurgeon : Surgeon
    {
        public string SurgeryType { get; set; }

        public Neurosurgeon(string name, int experienceYears, decimal salary, string surgeryType) : base(name, experienceYears, salary, "Нейрохірургія")
        {
            SurgeryType = surgeryType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Хірург {Name}, спеціалізація: {Specialization}, зарплата: {Salary}$");
            Console.WriteLine($"Вид хірургії: {SurgeryType}");
        }

        public override decimal CalculatePayment()
        {
            return 150m;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Stomatologist stomatologist = new Stomatologist("Марія Сидорова", 10, 1500m, "Імплантація");
            Dentist dentist = new Dentist("Сергій Чорний", 5, 1200m, "видалення запалених нервів зуба");
            PlasticSurgeon plasticSurgeon = new PlasticSurgeon("Катерина Зелена", 12, 10000m, "Ринопластика");
            Neurosurgeon neurosurgeon = new Neurosurgeon("Олексій Коваль", 20, 900m, "Травма головного мозку");
            DentalTechnician dentalTechnician = new DentalTechnician("Андрій Білий", 8, 1000m, "права рука стоматолога");

            stomatologist.DisplayInfo();
            stomatologist.DisplayExperience();
            Console.WriteLine($"Оплата за послугу: {stomatologist.CalculatePayment()}$\n");
            dentist.DisplayInfo();
            dentist.DisplayExperience();
            Console.WriteLine($"Оплата за послугу: {dentist.CalculatePayment()}$\n");
            plasticSurgeon.DisplayInfo();
            plasticSurgeon.DisplayExperience();
            Console.WriteLine($"Оплата за послугу: {plasticSurgeon.CalculatePayment()}$\n");
            neurosurgeon.DisplayInfo();
            neurosurgeon.DisplayExperience();
            Console.WriteLine($"Оплата за послугу: {neurosurgeon.CalculatePayment()}$\n");
            dentalTechnician.DisplayInfo();
            dentalTechnician.DisplayExperience();

        }
    }
}
