using System;

namespace ReportSystem
{
    // Класс для генерации отчета по курсам
    public class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Сбор данных о курсах...");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Обработка данных о курсах...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Форматирование отчета по курсам...");
        }
    }
}
