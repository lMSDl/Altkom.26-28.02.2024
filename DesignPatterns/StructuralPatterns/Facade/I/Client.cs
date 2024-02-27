using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Facade.I
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-32) };
            /*var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                PreserveReferencesHandling  = PreserveReferencesHandling.Objects,
                DateFormatString = "yy MM d"
            };

            var json = JsonConvert.SerializeObject(person, settings);*/

            Console.WriteLine(SerializeFacade.Serialize(person));
        }
    }
}
