using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Генерация отчета по студентам ===");
            ReportGenerator studentReport = new StudentReportGenerator();
            studentReport.GenerateReport();

            Console.WriteLine("\n=== Генерация отчета по курсам ===");
            ReportGenerator courseReport = new CourseReportGenerator();
            courseReport.GenerateReport();

            Console.ReadKey();
        }
    }
}
