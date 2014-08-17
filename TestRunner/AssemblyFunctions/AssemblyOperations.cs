using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TestRunner.AssemblyFunctions
{
    public class AssemblyOperations
    {
        public Assembly Assembly;

        public AssemblyOperations()
        {
            
        }

        public AssemblyOperations(string filePath)
        {
            Assembly = Assembly.LoadFile(filePath);
        }

        public Assembly LoadAssembly(string filePath)
        {
            Assembly = Assembly.LoadFile(filePath); 
            return Assembly;
        }

        public List<Type> GetAllAssemblyTypes(string filePath)
        {
           var assembly = LoadAssembly(filePath);
           return this.Assembly.GetTypes().ToList<Type>();
        }

        public Type GetSpecifiedAssemblyType(string filePath, string typeName)
        {
            Type type = null;
            var assemblyTypes = GetAllAssemblyTypes(filePath);
            foreach (var assemblyType in assemblyTypes)
            {
                if (Regex.IsMatch(assemblyType.Name, typeName, RegexOptions.IgnoreCase))
                {
                    type = assemblyType;
                }
            }
            return type;
        }

        public List<Type> GetTypesWithSpecifiedCustomAttributes(string filePath, string customAttribute="TestFixtureAttribute")
        {
            var customAttributeTypes = new List<Type>();
            var assemblyTypes = GetAllAssemblyTypes(filePath);
            foreach (var assemblyType in assemblyTypes)
            {
                var customAttributes = assemblyType.GetCustomAttributes(false).ToList();
                foreach (var customAttr in customAttributes)
                {
                    if (Regex.IsMatch(customAttr.ToString(), customAttribute,RegexOptions.IgnoreCase))
                    {
                        customAttributeTypes.Add(assemblyType);
                    }
                }
            }
            return customAttributeTypes;
        }

        public List<string> GetNunitMethodsForSpecifiedTypeAndAttribute(Type type, string customAttribute="TestAttribute")
        {
            var tests = new List<string>();
            var typeMethods = type.GetMethods();
            foreach (var typeMethod in typeMethods)
            {
                var customAttributes = typeMethod.GetCustomAttributes(false).ToList();
                var methodHasTestAttribute = customAttributes.Exists(x => Regex.IsMatch(x.ToString(), customAttribute));
                if (methodHasTestAttribute)
                {
                    tests.Add(typeMethod.ToString());
                }
            }
            return tests;
        }
    }
}
