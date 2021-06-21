using System;
using System.Reflection;
using BindingFlags = System.Reflection.BindingFlags;

namespace d04_ex03
{
    public class TypeFactory
    {
        public static T CreateWithConstructor<T>() where T : class
        {
            return (T)typeof(T).GetConstructor(new Type[0]).Invoke(null);
        }

        public static T CreateWithActivator<T>() where T : class
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public static T CreateWithParameters<T>(object[] massivOfObjects)
        {
            return (T) Activator.CreateInstance(typeof(T), massivOfObjects);
        }
    }
}