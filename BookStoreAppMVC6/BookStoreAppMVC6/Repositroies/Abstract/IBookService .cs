using BookStoreAppMVC6.Models.Domain;

namespace BookStoreAppMVC6.Repositroies.Abstract
{
    public interface IBookService
    {
        bool Add(Book model);
        bool Update(Book model);
        bool Delete(int id);
        Book FindById(int id);
        IEnumerable<Book> GetAll();
    }
}
