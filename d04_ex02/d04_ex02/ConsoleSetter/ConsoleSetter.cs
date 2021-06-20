using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using d04_ex02.Attributes;

namespace d04_ex02.ConsoleSetter
{
    public class ConsoleSetter
    {
        public void SetValues<T>(T input) where T : class
        {
            var type = input.GetType();
            Console.WriteLine($"Let's set {type.Name}!");
            
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in properties)
            {
                // Using reflection
                System.Attribute[] attrs = System.Attribute.GetCustomAttributes(property);
                bool isNoDisplayAttribute = attrs.ToList().Any(attr => attr.GetType() == typeof(NoDisplayAttribute));
                if (!isNoDisplayAttribute)
                {
                    var attrDescriptionAttribute = attrs.ToList().Find(a=>a.GetType() == typeof(DescriptionAttribute));
                    Console.WriteLine($"Set {((DescriptionAttribute)attrDescriptionAttribute).Description}:");
                    var line = Console.ReadLine();
                    if (line == "")
                    {
                        var attributeDefaultValueAttribute = attrs.ToList().Find(a => a.GetType() == typeof(DefaultValueAttribute));
                        if (attributeDefaultValueAttribute != null)
                        {
                            line = (string)((DefaultValueAttribute)attributeDefaultValueAttribute).Value;
                            property.SetValue(input, line);
                        }
                    }
                    else
                    {
                        property.SetValue(input, line);
                    }
                }
            }
            Console.WriteLine($"We've set our instance!");
            Console.WriteLine(input);
        }
    }
}