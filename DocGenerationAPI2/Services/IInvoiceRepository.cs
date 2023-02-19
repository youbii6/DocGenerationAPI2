using DocGenerationAPI2.Entites;

namespace DocGenerationAPI2.Services
{
    public interface IInvoiceRepository
    {
        Task<IEnumerable<Invoice>> GetInvoicesAsync();
        Task<Invoice?> GetInvoiceByIdAsync(int id);
        Task<bool> InvoiceExistsAsync(int id);

        
    }
}
