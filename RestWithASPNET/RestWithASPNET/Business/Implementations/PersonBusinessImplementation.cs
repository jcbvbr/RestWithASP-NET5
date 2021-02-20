using RestWithASPNET.Data.Converter.Implementation;
using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;
using RestWithASPNET.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASPNET.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _personRepository;
        private readonly PersonConverter _converter;
        public PersonBusinessImplementation(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_personRepository.FindAll());
        }
        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_personRepository.FindByID(id));
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);            
            return _converter.Parse(_personRepository.Create(personEntity));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            return _converter.Parse(_personRepository.Update(personEntity));
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }
    }
}
