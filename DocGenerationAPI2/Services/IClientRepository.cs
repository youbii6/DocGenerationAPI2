using DocGenerationAPI2.Entites;

namespace DocGenerationAPI2.Services
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClientsAsync ();
        Task<Client?> GetClientByIdAsync(int id);
        Task<bool> ClientExistsAsync(int id);



    }
}
