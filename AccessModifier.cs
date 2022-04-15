//TODO: Task 1 - Modify the code to invoke the class MyTextWriter from the Program.Main 
using System;
using System.IO;

namespace GlobantNamespace
{
    public class Program
    {
        public static void Main()
        {
            var _bufferlimit = 200; //Task 2
            AnotherNamespace.MyTextWriter writer = new AnotherNamespace.MyTextWriter(_bufferlimit); //Task 1
            writer.GetBufferLimit(); //Task 4
            Console.WriteLine("Hello World");
        }
    }
}

namespace AnotherNamespace
{
    internal class MyTextWriter
    {
        //TODO: Task 2 - Provide another way of assigning a value to _bufferLimit
        //TODO: Task 3 - Provide a public getter/setter for _bufferLimit
        //protected readonly int _bufferLimit = 500;
        protected readonly int _bufferLimit; //Task 2

        // public int BufferLimit { get { return _bufferLimit; } set { set_bufferLimit(value); } } //Task 3
        public int BufferLimit { get { return _bufferLimit; } } //Task 3
        //public void set_bufferLimit(int _value) => this._bufferLimit = _value; //Task 3

        private const string configurationName = "TextWriterConfiguration";

        //Constructor
        public MyTextWriter(int valBufferLimit = 500)
        {
            this._bufferLimit = valBufferLimit; //Task 2
            //this.set_bufferLimit(valBufferLimit); //Task 3
        }

        //TODO: Task 4 - Modify below code replacing the "using" block with a try-catch-finally
        public void Write(string text, out string outputText)
        {
            outputText = null;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(outputText);
                //writer...
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //if(writer.BaseStream != null)
                writer?.Dispose();
            }
            /*using(var writer = new StreamWriter(outputText))
			{
				writer.Write(text);
			}*/
        }

        public static string GetConfigurationName()
        {
            return configurationName;
        }

        //TODO: Task 5 - Explain why the GetConfigurationName() can be static but GetBufferLimit() not - Modify the code to make it work
        public int GetBufferLimit()
        {
            //return _bufferLimit;
            return this.BufferLimit;
        }
    }

}