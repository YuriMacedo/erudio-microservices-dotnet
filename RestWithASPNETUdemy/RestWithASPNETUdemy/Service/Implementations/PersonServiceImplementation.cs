using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Service.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long personId)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0;i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }


        public Person FindById(long personId)
        {
            return new Person 
            { 
                Id = IncrementAndGet(),
                FirstName = "Yuri",
                SecondName = "Macedo",
                Address = "Rio de Janeiro - Rio de Janeiro - Brasil",
                Gender = "Male"
            };
        }

        public Person UpdatePerson(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                SecondName = "Person Last Name" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
