using DocGenerationAPI2.DbContexts;
using DocGenerationAPI2.Entites;
using Microsoft.EntityFrameworkCore;

namespace DocGenerationAPI2.Services
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DocGenerationAPI2Context _context;

        public InvoiceRepository(DocGenerationAPI2Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Invoice?> GetInvoiceByIdAsync(int id)
        {
            return await _context.Invoices.Where(i => i.Id == id)
                .Include(i => i.InvoiceLines).ThenInclude(il=>il.Service)
                .SingleOrDefaultAsync();

        }

        public async Task<IEnumerable<Invoice>> GetInvoicesAsync()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task<bool> InvoiceExistsAsync(int id)
        {
            return await _context.Invoices.AnyAsync(c => c.Id == id);

        }
    }
}
