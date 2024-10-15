using Microsoft.VisualBasic;
using System.IO;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteTextData();
            //ReadTextData();

            //WriteBinaryData();
            //ReadBinaryData();


            //File.Copy(@"C:\CGI2024_DotnetCore\customer.txt", @"C:\CGI2024_DotnetCore\customer_copy.txt");
            //Console.WriteLine("File copy created");

            DateTime creationTime = File.GetCreationTime(@"C:\CGI2024_DotnetCore\customer.txt");

            Console.WriteLine("File creation time:" + creationTime);            

        }
        static void WriteTextData()
        {
            if(!Directory.Exists(@"C:\CGI2024_DotnetCore\MyFolder"))
            {
                Directory.CreateDirectory(@"C:\CGI2024_DotnetCore\MyFolder");
            }

            FileStream fs = null;
            //create a filestream for writing purpose
            fs = new FileStream(@"C:\CGI2024_DotnetCore\MyFolder\notes.txt", FileMode.Create, FileAccess.Write);

            //create StreamWriter for the file stream
            StreamWriter sw=new StreamWriter(fs);

            //take user input
            Console.Write("Enter data to write to file(press EMPTY to finish:");
            string data=Console.ReadLine();
            while(data!="")
            {
                //write data using the stream writer
                sw.WriteLine(data);
                data = Console.ReadLine();
            }            
            Console.WriteLine("Data written to file");

            //close the writer and stream
            sw.Close();
            fs.Close();

        }
        static void ReadTextData() 
        {
            FileStream fs = null;
            //create filestream for reading
            fs = new FileStream(@"C:\CGI2024_DotnetCore\notes.txt", FileMode.Open, FileAccess.Read);
        
            //create stream reader for the filestream
            StreamReader sr = new StreamReader(fs);

            //read line by line
            string data=sr.ReadLine();
            while(!string.IsNullOrEmpty(data))
            {
                Console.WriteLine(data); //display on console
                data = sr.ReadLine();
            }
            //close the stream reader and file stream
            sr.Close();
            fs.Close();
        }
        static void WriteBinaryData()
        {
            int cid = 1001;
            string cname = "Ramesh";
            string city = "Bangalore";

            FileStream fs = null;
            //create filestream for writing 
            fs=new FileStream(@"C:\CGI2024_DotnetCore\customer.txt",FileMode.Create, FileAccess.Write);

            //create BinaryWriter for the file stream
            BinaryWriter bw=new BinaryWriter(fs);

            //write data to the file using Binary writer
            bw.Write(cid);
            bw.Write(cname);
            bw.Write(city);
            Console.WriteLine("Data written to file");

            //close the stream
            bw.Close();
            fs.Close();
        }
        static void ReadBinaryData()
        {
            int cid;
            string cname;
            string city;

            FileStream fs = null;
            //create filestream for reading 
            fs = new FileStream(@"C:\CGI2024_DotnetCore\customer.txt", FileMode.Open, FileAccess.Read);

            //create BinaryReader for the file stream
            BinaryReader br = new BinaryReader(fs);

            //read data from the file using binary reader
            cid = br.ReadInt32();
            cname = br.ReadString();
            city = br.ReadString();

            //display data
            Console.WriteLine($"{cid}\t{cname}\t{city}");

            //close the reader and filestream
            br.Close();
            fs.Close();
        }
    }
}
