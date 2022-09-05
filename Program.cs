// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection;

namespace ReflectionPracticeProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Type c = typeof(EnterPersonDetails);

            ConstructorInfo[] constructorInfos = c.GetConstructors();

            foreach(ConstructorInfo ci in constructorInfos)
            {
                Console.WriteLine(ci.Name);
            }

            MethodInfo[] methodInfos = c.GetMethods();

            foreach(MethodInfo ci in methodInfos)

                {
                Console.WriteLine(ci);
            }
        }
    }
}