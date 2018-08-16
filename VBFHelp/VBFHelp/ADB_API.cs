using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace VBFHelp
{
    public class ADB_API
    {
        public string strCallAdbCmd;




        public void runCmd(string adbExePath, string adbCmd, out string outputLog)
        {
            strCallAdbCmd = adbCmd;

            Process p = new Process();

            p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo.FileName = ExeFileName;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;

            try
            {
                p.Start();

                p.StandardInput.WriteLine(adbCmd + "&exit");
                //p.StandardInput.AutoFlush = true;
                //Thread.Sleep(1000 * 10);
                //p.StandardInput.WriteLine("exit");
                //Thread.Sleep(1000);
                outputLog = p.StandardOutput.ReadToEnd();
                outputLog += p.StandardError.ReadToEnd();
                p.WaitForExit();
                p.Close();
            }
            catch (Exception ex)
            {
                outputLog = ex.ToString();
            }

        }

    }
}
