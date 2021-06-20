using System;
using System.Linq;
using System.Reflection;
using System.Xml;
using Microsoft.AspNetCore.Http;

DefaultHttpContext peremDefaultHttpContext = new();
var type = peremDefaultHttpContext.GetType();
Console.WriteLine($"Type: {type.FullName}");
Console.WriteLine($"Assembly: {type.Assembly.FullName}");
Console.WriteLine($"Based on: {type.BaseType}");

Console.WriteLine("\nFields:");
var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
foreach (var field in fields)
{
    Console.WriteLine($"{field.FieldType.FullName} {field.Name}");
}

Console.WriteLine("\nProperties:");
var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
foreach (var property in properties)
{
    Console.WriteLine($"{property.PropertyType.FullName} {property.Name}");
}

Console.WriteLine("\nMethods:");
var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
foreach (var method in methods)
{
    var arrayParameters = method.GetParameters().ToList()
        .Select(parameter => parameter.ParameterType.Name + " " + parameter.Name).ToArray();
    Console.WriteLine($"{method.ReturnType.Name} {method.Name} ({string.Join(", ", arrayParameters)})");
}
