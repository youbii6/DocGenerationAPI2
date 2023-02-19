using DocGenerationAPI2.DbContexts;
using DocGenerationAPI2.Entites;
using Microsoft.EntityFrameworkCore;

namespace DocGenerationAPI2.Services
{
    public class ClientRepository : IClientRepository
    {
        private readonly DocGenerationAPI2Context _context;

        public ClientRepository(DocGenerationAPI2Context context) 
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> ClientExistsAsync(int id)
        {
          return await _context.Clients.AnyAsync(c => c.Id == id);
        }

        public async Task<Client?> GetClientByIdAsync(int id)
        {
            return await _context.Clients.Where(c=> c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
           return await _context.Clients.ToListAsync();
        }
    }
}
