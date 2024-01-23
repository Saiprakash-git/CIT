using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableBilling
{
    internal class filemanipulations
    {
        public static ArrayList readfile(string filepath)
        {
            ArrayList arrayList = new ArrayList();
            if (File.Exists(filepath))
            {
                // Open the file with a StreamReader
                using (StreamReader reader = new StreamReader(filepath))
                {
                    // Read and display each line in the file
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        arrayList.Add(line);
                    }
                }
                return arrayList;
            }
            else
            {
                return null;
            }

        }
        public static string WriteTextToFile(string fileName, ArrayList lines)
        {
            try
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}
