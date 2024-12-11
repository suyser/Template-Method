using System;

namespace ReportSystem
{
    // Класс для генерации отчета по студентам
    public class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Сбор данных о студентах...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработка данных о студентах...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Форматирование отчета по студентам...");
        }
    }
}
