using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FilesExercise
{
    // Custom exception
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {
            Console.WriteLine("Error: " + message);
        }
    }

    internal class FileManager
    {
        private string filePath;

        // Constructor
        public FileManager()
        {
            this.filePath = string.Empty;
        }

        // Constructor
        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadWords()
        {
            string content = string.Empty;
            try
            {
                content = ReadFile();
            }
            catch (WordListNotFoundException ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            return content;
        }

        /* Method reads file from a local 
         * directory path.
         */
        private string ReadFile()
        {
            if (!File.Exists(filePath))
            {
                // Throw exception if file does not exists
                throw new WordListNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}
