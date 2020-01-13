using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();

            Type exampleType = Type.GetType(nameof(example));

            var classAttributes = typeof(Example).GetCustomAttributes(typeof(BugFixedAttribute), false);
            foreach (var item in classAttributes)
            {
                Console.WriteLine(item);
            }

            MethodInfo[] methodInfos = example.GetType().GetMethods(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static |
                BindingFlags.DeclaredOnly);
            foreach (var mi in methodInfos)
            {
                Console.WriteLine(mi);
                var methodAttributes = mi.GetCustomAttributes();
                foreach (var mAttr in methodAttributes)
                {
                    Console.WriteLine($"\t {mAttr}");
                }
            }

            Console.ReadLine();
        }
    }
}
