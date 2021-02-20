using RestWithASPNET.Model;
using RestWithASPNET.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASPNET.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _bookRepository;

        public BookBusinessImplementation(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book Create(Book book)
        {
            return _bookRepository.Create(book);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _bookRepository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _bookRepository.FindByID(id);
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}
