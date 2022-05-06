using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            MainPrintFile wordFile = new MainPrintFile(new Word());
            MainPrintFile pdfFile = new MainPrintFile(new PDF());
            MainPrintFile excelFile = new MainPrintFile(new Excell());
        }
    }
}
