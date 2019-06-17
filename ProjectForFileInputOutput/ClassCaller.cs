using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForFileInputOutput
{
    /*
        We try to study System.IO  namespaces's classes. We will see these classes's methods and attributes. We use these methods and attributes to make file operations. 
        StreamReader and SreamWriter classes are inherited from  Stream abstract base class. 
        StreamReader And StreamWriter classes are used  for reading from  and  writing data to text files. 
        StreamReader class inherite from the abstract class TextReader. 
        StreamWriter class inherite from the abstract class TextWriter.  
    */
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello File I/O In C#..");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Using FileStream Class..");
            Console.WriteLine("--------------------------");
            OpenOrCreateFileAndReadToTheConsole();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Using StreamReader Class..");
            Console.WriteLine("--------------------------");
            ReadFromFile();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Using StreamWriter Class..");
            Console.WriteLine("--------------------------");
            WriteTextDataToFile();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Using BinaryWriter/Reader Class..");
            Console.WriteLine("--------------------------");
            WriteAndReadBinaryDataFromFile();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Using FileInfo/DirectoryInfo Classes..");
            Console.WriteLine("--------------------------");
            ShowWindowsFilesDetails();

            Console.ReadKey();
        }

        public static void OpenOrCreateFileAndReadToTheConsole()
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //first write to the file 
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
        }

        public static void ReadFromFile()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("D:/jamaica.txt"))
                {
                    string line;
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong..
                Console.WriteLine("The File Could not be read:");
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        public static void WriteTextDataToFile()
        {
            string[] names = new String[] { "Zara Ali", "Nuha Ali" };

            try
            {
                using (StreamWriter sw = new StreamWriter("D:/jamaica.txt"))
                {
                    foreach (var name in names)
                    {
                        sw.WriteLine(name);
                    } 
                }
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("D:/jamaica.txt"))
                {
                    string line;
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong..
                Console.WriteLine("The File Could not be read:");
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        public static void WriteAndReadBinaryDataFromFile()
        {
            BinaryWriter bw;
            BinaryReader br;

            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            //create a new file
            try
            {
                bw = new BinaryWriter(new FileStream("D:/mydata", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            //writing into the file 
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();

            //reading from the file 
            try
            {
                br = new BinaryReader(new FileStream("D:/mydata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }

            try
            {
                Console.WriteLine("Integer data: {0}", br.ReadInt32());
                Console.WriteLine("Double  data: {0}", br.ReadDouble());
                Console.WriteLine("Boolean data: {0}", br.ReadBoolean());
                Console.WriteLine("String  data: {0}", br.ReadString());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
        }

        public static void ShowWindowsFilesDetails()
        {
            //creating a DirectoryInfo object
            DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");
            // getting the files in the directory, their names and size
            FileInfo[] files = mydir.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine("File Name: {0} File Size: {1}", file.Name, file.Length);   
            }
        }
    }
}
