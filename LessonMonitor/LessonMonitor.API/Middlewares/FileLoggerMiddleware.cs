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

        private readonly string _path = "RequestLog.txt";
        public FileLoggerMiddleware(RequestDelegate next)
        {
            _next = next;

            _path += Environment.CurrentDirectory;
        }

        public async Task Invoke(HttpContext context, RequestDelegate next)
        {
            if(context != null)
            {
                using(FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
                {
                    string message = $"Request to {context.Request.Path} | {context.Request.Method} | {context.Request.Headers} |";
                   
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
