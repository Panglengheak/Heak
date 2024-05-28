using Microsoft.EntityFrameworkCore;
using LMS.Data;
using LMS.Models;

namespace LMS.Services
{
    public class LibrarianServiceImp : ILibrarianService
    {
        private readonly EntityDbContext _context;
        public LibrarianServiceImp(EntityDbContext context)
        {
            this._context = context;
        }
        public async Task<bool> Create(Librarian librarian)
        {
            _context.Librarians.Add(librarian);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Librarian librarian)
        {
           _context.Librarians.Remove(librarian);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Librarian>> GetAll()
        {
            var result = _context.Librarians;
            return await result.ToListAsync();
        }

        public Task<Librarian> GetById(int LibrarianId)
        {
            var librarian = _context.Librarians.FirstOrDefaultAsync(x => x.LibrarianId == LibrarianId);
            return librarian;
        }

        public async Task<bool> Update(Librarian librarian)
        {
           _context.Librarians.Update(librarian);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
