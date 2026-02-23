using RESTWithASPNET10.Model;
using RESTWithASPNET10.Repositories;

namespace RESTWithASPNET10.Service.Impl
{
    public class PersonServicesImpl : IPersonServices
    {
        private IPersonRepository _repository;


        public PersonServicesImpl(IPersonRepository repository) 
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }
    }
}
