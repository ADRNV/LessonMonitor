using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("reflect")]
    public class ReflectController : ControllerBase
    {
        ReflectController()
        {

        }

        [HttpGet]
        public Type[] Reflection()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = GetTypesInNamespace(assembly, "LessonMonitor.API.Models");

            return types;
        }

        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();
        }
    }
}
