using System;
using System.Reflection;
using Microsoft.AspNetCore.Http;

DefaultHttpContext response = new();
Console.WriteLine($"Old Response value: {response.Response}");

var responseType = response.GetType();
var oldResponse = responseType.GetField("_response", BindingFlags.Instance | BindingFlags.NonPublic);
oldResponse.SetValue(response, null);
Console.WriteLine($"New Response value: {response.Response}");

