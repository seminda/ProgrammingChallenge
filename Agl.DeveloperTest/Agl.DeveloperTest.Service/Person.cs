using System.Collections.Generic;

namespace Agl.DeveloperTest.Service
{
    internal class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
