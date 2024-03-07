using BookStoreAppMVC6.Models.Domain;
using BookStoreAppMVC6.Repositroies.Abstract;

namespace BookStoreAppMVC6.Repositroies.Implementation
{
    public class Publisherservice : IPublisherservice
    {
        private readonly DatabaseContext context;
        public Publisherservice(DatabaseContext context)
        {
            this.context = context;
        }
        public bool Add(Publisher model)
        {
            try
            {
                context.Publisher.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                context.Publisher.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Publisher FindById(int id)
        {
            return context.Publisher.Find(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return context.Publisher.ToList();
        }

        public bool Update(Publisher model)
        {
            try
            {
                context.Publisher.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Genre IPublisherService.FindById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
