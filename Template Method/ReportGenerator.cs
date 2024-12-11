using System;

namespace ReportSystem
{
    // Абстрактный класс ReportGenerator
    public abstract class ReportGenerator
    {
        // Шаблонный метод для генерации отчета
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }

        // Абстрактные методы для реализации в подклассах
        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();

        // Метод для экспорта отчета (можно задать реализацию по умолчанию)
        protected virtual void ExportReport()
        {
            Console.WriteLine("Отчет экспортирован в файл.");
        }
    }
}
