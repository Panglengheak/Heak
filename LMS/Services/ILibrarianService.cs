using LMS.Models;

namespace LMS.Services
{
    public interface ILibrarianService
    {
        Task<bool> Create(Librarian librarian);
        Task<bool> Update(Librarian librarian);
        Task<bool> Delete(Librarian librarian);
        Task<List<Librarian>> GetAll();
        Task<Librarian> GetById(int LibrarianId);
    }
}
