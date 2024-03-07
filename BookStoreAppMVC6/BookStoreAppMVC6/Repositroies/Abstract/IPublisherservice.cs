using BookStoreAppMVC6.Models.Domain;

namespace BookStoreAppMVC6.Repositroies.Abstract
{
    public interface IPublisherservice
    {
        bool Add(Publisher model);
        bool Update(Publisher model);
        bool Delete(int id);
        Publisher FindById(int id);
        IEnumerable<Publisher> GetAll();
    }
}
