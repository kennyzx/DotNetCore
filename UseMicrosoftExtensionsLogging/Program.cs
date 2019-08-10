using System;
using Newtonsoft.Json;

namespace UseMicrosoftExtensionsLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel { Name = "abc", Age = 123};
            Console.WriteLine($"Hello {JsonConvert.SerializeObject(person)}!");
        }
    }
}
