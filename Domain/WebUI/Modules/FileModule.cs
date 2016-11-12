using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebUI.Modules
{
    /// <summary>
    /// Module that write the date of entry user to site in txt file
    /// </summary>

    public class FileModule:IHttpModule
    {
        private StreamWriter _writer;
        public void Init(HttpApplication context)
        {
            context.BeginRequest += (new EventHandler(this.Application_BeginRequest));
        }

        private void Application_BeginRequest(object sender, EventArgs e)
        {
            if (!File.Exists("File.txt"))
            {
                _writer = new StreamWriter(@""); //Enter path
            }
            else
            {
                _writer = File.AppendText("File.txt");
            }
            _writer.WriteLine("User Sends Request at {0}",DateTime.Now);
            _writer.Close();
        }

        public void Dispose()
        { }
    }
}