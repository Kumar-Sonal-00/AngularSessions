using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace UserDefinedExceptionDemo
{
    internal class ErrorLogger
    {
        public static void LogError(Exception ex)
        {
            //file operation to write the errors to file
            FileStream fs = null;
            try
            {
                fs=new FileStream("error_log.txt",FileMode.Append,FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine("Error:" + ex.Message);
                sr.WriteLine("Date and Time:" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
                sr.WriteLine("================================================================");
                sr.Close();
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
