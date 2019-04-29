using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class PersonCollection : IEnumerable<Person>
    {
        private List<Person> persons;

        public PersonCollection()
        {
            persons = new List<Person>();
        }

        public void Add(Person person)
        {
            persons.Add(person);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            foreach (var person in persons)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
