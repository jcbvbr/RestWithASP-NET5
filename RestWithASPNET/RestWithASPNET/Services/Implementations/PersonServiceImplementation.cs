using RestWithASPNET.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                persons.Add(new Person
                {
                    Id = IncrementAndGet(),
                    FirstName = $"FisrtName {i}",
                    LastName = $"LastName {i}",
                    Address = $"Endereço {i}",
                    Gender = "Male"
                });
            }

            return persons;
        }
        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "FisrtName",
                LastName = "LastName",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        private Person MockPerson()
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "FisrtName",
                LastName = "LastName",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }
    }
}
