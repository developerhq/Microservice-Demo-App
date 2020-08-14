using LibraryAPI.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.repository
{
    public interface ILibraryRepository
    {
        // api/[GET]
        Task<IEnumerable<Book>> GetAllBooks();
        // api/1/[GET]
        Task<Book> GetBook(int id);
        // api/[POST]
        Task Create(Book book);
        // api/[PUT]
        Task<bool> Update(Book book);
        // api/1/[DELETE]
        Task<bool> Delete(int id);
       // Task<long> GetNextId();
    }
}
