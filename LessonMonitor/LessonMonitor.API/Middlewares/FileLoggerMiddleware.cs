using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Text.Encodings;
using System.Text;

namespace LessonMonitor.API.Meddlewares
{
    public class FileLoggerMiddleware 
    {
        private RequestDelegate _next;

        private readonly string _path;
        public FileLoggerMiddleware(RequestDelegate next)
        {
            _next = next;

            _path += Environment.CurrentDirectory+"\\RequestLog.txt";
        }

        public async Task Invoke(HttpContext context)
        {
            if(context != null)
            {
                FileMode action = File.Exists(_path) ? FileMode.Append : FileMode.OpenOrCreate;

                using (FileStream fs = new FileStream(_path, action))
                {
                    string message = $"Request to {context.Request.Path} | {context.Request.Method} | {context.Request.Headers} | \n";
                   
                    byte[] buffer = Encoding.UTF8.GetBytes(message);

                    fs.Write(buffer, 0, buffer.Length);
                }

            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
