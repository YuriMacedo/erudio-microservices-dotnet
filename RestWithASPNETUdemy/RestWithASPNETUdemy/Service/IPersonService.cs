using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Service
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long personId);
        List<Person> FindAll();
        Person UpdatePerson(Person person);
        void Delete(long personId);

    }
}
