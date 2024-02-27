using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public Person Parent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Address Address { get; set; }
        public IEnumerable<Person>? Children { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();
            //clone.Children = Children.Select(x => (Person)x.Clone()).ToList(); //głębokie klonowanie spowoduje zdublowanie dzieci
            clone.Children = Children?.ToList();
            //clone.Parent = (Person)Parent.Clone(); //nie chcemy zdublować rodzica
            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
