//TODO: Task 1 - Modify the code to invoke the class MyTextWriter from the Program.Main 
using System;
using System.IO;

// namespace GlobantNamespace
// {
// 	public class Program
// 	{
// 		public static void Main()
// 		{
// 			Console.WriteLine("Hello World");
// 		}
// 	}
// }

// namespace AnotherNamespace
// {	
// 	internal class MyTextWriter
// 	{
// 		//TODO: Task 2 - Provide another way of assigning a value to _bufferLimit
// 		//TODO: Task 3 - Provide a public getter/setter for _bufferLimit
// 		protected readonly int _bufferLimit = 500;
		
		
// 		private const string configurationName = "TextWriterConfiguration";
		
// 		//Constructor
// 		public MyTextWriter()
// 		{
			
// 		}
		
// 		//TODO: Task 4 - Modify below code replacing the "using" block with a try-catch-finally
// 		public void Write(string text, out string outputText)
// 		{
// 			outputText = null;
// 			using(var writer = new StreamWriter(outputText))
// 			{
// 				writer.Write(text);
// 			}
// 		}
		
// 		public static string GetConfigurationName()
// 		{
// 			return configurationName;
// 		}
		
// 		//TODO: Task 5 - Explain why the GetConfigurationName() can be static but GetBufferLimit() not - Modify the code to make it work
// 		public static int GetBufferLimit()
// 		{
// 			return _bufferLimit;
// 		}
// 	}
	
// }