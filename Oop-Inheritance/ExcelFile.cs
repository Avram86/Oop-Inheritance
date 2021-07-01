using Oop_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Inheritance
{
    public class ExcelFile:File
    {
		public ExcelFile(string name, string excelVersion) 
			//base tine locul obiectului parinte
			: base(name, "xslx")
		{
			this.ExcelVersion = excelVersion;
		}

		public string ExcelVersion
		{
			get;
		}

		public void PerformCalculation(string formula)
		{
			Console.WriteLine($"Calculating formula '{formula}' on file '{this.Name}.{this.Extension}' open in {this.ExcelVersion}");
		}
	}
}
