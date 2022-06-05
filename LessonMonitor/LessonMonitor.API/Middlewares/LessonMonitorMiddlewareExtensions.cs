using LessonMonitor.API.Meddlewares;
using Microsoft.AspNetCore.Builder;

namespace LessonMonitor.API.Middlewares
{
    public static class LessonMonitorMiddlewareExtensions
    {
        public static IApplicationBuilder UseFileLogger(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<FileLoggerMiddleware>();
        }

        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddlewareComponent>();
        }
    }
}
