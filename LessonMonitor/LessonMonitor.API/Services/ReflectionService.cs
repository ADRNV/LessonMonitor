using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LessonMonitor.API.Services
{
    public class ReflectionService
    {
        private Dictionary<string, List<string>> _typesInfo;

        public ReflectionService()
        {
            _typesInfo = new Dictionary<string, List<string>>();
        }

        public Dictionary<string, List<string>> GetTypesInformation(string nameSpace)
        {
            
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = GetTypesInNamespace(assembly, nameSpace);

            foreach (Type type in types)
            {
                var properties = new List<string>();

                foreach (var prop in type.GetProperties())
                {
                    properties.Add(prop.Name);
                }

                _typesInfo.Add(type.Name, properties);
            }

            return _typesInfo;
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
