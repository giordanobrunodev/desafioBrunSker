using desafioBrunSker.Models;

namespace desafioBrunSker.Services
{
    public interface IImobiliariaService
    {
        Task<List<Imobiliaria>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Imobiliaria> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<Imobiliaria> CreateAsync(Imobiliaria imobiliaria, CancellationToken cancellationToken = default);
        Task<Imobiliaria> UpdateAsync(int id, Imobiliaria imobiliaria, CancellationToken cancellationToken = default);
        void Delete(int id);
    }
}