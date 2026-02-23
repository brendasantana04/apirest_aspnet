using RESTWithASPNET10.Model;

namespace RESTWithASPNET10.Service
{
    public interface IPersonServices
    {
        Person Create (Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update (Person person);
        void Delete(long id);
    }
}
