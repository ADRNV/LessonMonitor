using LessonMonitor.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("Reflection")]
    public class ReflectController : ControllerBase
    {
        private ReflectionService _reflectionService;
        public ReflectController()
        {
            _reflectionService = new ReflectionService();
        }

        [HttpGet("Types/{nameSpace}")]
        public Dictionary<string, List<string>> TypesInformation(string nameSpace)
        {
            return _reflectionService.GetTypesInformation(nameSpace);
        }

        [HttpGet("Types/{nameSpace}/{typeName}")]
        public List<string> TypeInformation(string nameSpace, string typeName)
        {
            return _reflectionService.GetTypesInformation(nameSpace)[typeName];
        }
    }
}
