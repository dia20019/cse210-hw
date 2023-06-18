using System.IO;

namespace classes
{
    public class File 
    {
        public void WriteFile(string text)
        {
            Console.WriteLine("Write a name for the new entry (with .txt extension):");
            string _fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
            outputFile.WriteLine(text);
            }
        }
        public void LoadFile(){
            Console.WriteLine("Name of the entry you want to Load:");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                foreach (string part in parts)
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}