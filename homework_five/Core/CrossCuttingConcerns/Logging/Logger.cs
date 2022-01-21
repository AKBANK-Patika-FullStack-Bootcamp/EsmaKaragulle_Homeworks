using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class Logger
    {
        string _path = @"C:\Users\ESMA\source\repos\Airliness\Airliness\Log\";
        string _fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
        public void createLog(string message)
        {
            FileStream filesTream = new FileStream(_path + _fileName, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(filesTream);
            streamWriter.WriteLine(DateTime.Now.ToString() + ":" + message);
            streamWriter.Flush();
            streamWriter.Close();
            filesTream.Close();
        }
    }
}
