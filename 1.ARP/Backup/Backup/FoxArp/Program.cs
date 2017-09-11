using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FoxArp
{


    static class Program
    {

       
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //bool RunOne;
            ////Mutex must be released in the end
            //System.Threading.Mutex run = new System.Threading.Mutex(true, "UltraRun", out RunOne);
            //if (RunOne)
            //{
            //    try
            //    {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new WinForm());
                        
                    
            //    }
            //    catch (System.Exception ex)
            //    {
            //        MessageBox.Show(string.Format("Application meet an unconsidered problem and need to be closed.\r\nError Message: {0}", ex.ToString()));
            //    }
            //    finally
            //    {
            //        run.ReleaseMutex();
            //    }
            //}
            //else
            //    MessageBox.Show("UltraRun is already running.", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}


