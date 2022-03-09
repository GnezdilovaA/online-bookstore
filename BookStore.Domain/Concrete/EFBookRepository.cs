using System.Collections.Generic;
using BookStore.Domain.Entities;
using BookStore.Domain.Abstract;

namespace BookStore.Domain.Concrete
{
    public class EFBookRepository : IBookRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Book> Books
        {
            get { return context.Books; }
        }
    }
}
