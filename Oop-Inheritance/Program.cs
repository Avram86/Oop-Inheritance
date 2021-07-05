using System;


namespace Oop_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExcelFile spreadSheet1 = new ExcelFile("Stat de plata", "Excel 2019");
            //         spreadSheet1.Open();
            //         spreadSheet1.PerformCalculation("A=B+C");

            //         PdfFile pdf1 = new PdfFile("Book1", false);
            //         pdf1.Open();
            //         pdf1.AttemptEdit();

            //PdfFile pdf2 = new PdfFile("Declaratie", true);
            //         pdf2.Open();
            //         pdf2.AttemptEdit();

            //         FileManager.BulkCopy(@"C:\Temp", spreadSheet1, pdf1, pdf2);

            //         File.GetRootFolder();

            Shape t = new Triangle(new Point(15, 15), new Point(23, 30), new Point(50, 25));
            RotateAndPrintAShape(t);

            Shape r = new Square(new Point(10, 10), 20, 10);
            RotateAndPrintAShape(r);
        }

        public static void RotateAndPrintAShape(Shape s)
        {
            Console.WriteLine($"{s.Name} Area {s.Area}");
            s.Rotate(45);
            Console.WriteLine($"{s.Name} Area after rotation {s.Area}");
        }

    }
}
