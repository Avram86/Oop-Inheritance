using System;

namespace Oop_Inheritance
{
	public class File
	{
		public File(string name, string extension)
		{
			this.Name = name;
			this.Extension = extension;
		}

		public string Name
		{
			get;
		}

		public string Extension
		{
			get;
		}

		public void Open()
		{
			Console.WriteLine($"Opening file '{this.Name}.{this.Extension}'");
		}

		public void Copy(string toDestinationPath)
        {
			Console.WriteLine($"Copying file '{this.Name}.{this.Extension}' to '{toDestinationPath};");
		}

		public static void GetRootFolder()
        {
			Console.WriteLine($@"Root foder is 'C:\'");
		}
	}



}
