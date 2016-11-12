using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebUI.Modules
{
    /// <summary>
    /// Module that shows the time of the query
    /// </summary>
    public class TimerModule:IHttpModule
    {
        private Stopwatch timer;
        public void Init(HttpApplication app)
        {
            app.BeginRequest += HandleBeginRequest;
            app.EndRequest += HandleEndRequest;
        }
        private void HandleBeginRequest(object src, EventArgs args)
        {
            timer = Stopwatch.StartNew();
        }
        private void HandleEndRequest(object src, EventArgs args)
        {
            HttpContext context = HttpContext.Current;
            context.Response.Write(string.Format(
                "<div style='color:red;'>Request Processing Time: {0:F5} second</div>",
                ((float)timer.ElapsedTicks) / Stopwatch.Frequency));
        }
        public void Dispose()
        { }
    }
}