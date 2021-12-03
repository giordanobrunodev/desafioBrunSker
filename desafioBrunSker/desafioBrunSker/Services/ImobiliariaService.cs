using desafioBrunSker.Models;
using desafioBrunSker.Repositories;

namespace desafioBrunSker.Services
{
    public class ImobiliariaService : IImobiliariaService
    {
        private readonly IImobiliariaRepository _repository;

        public ImobiliariaService(IImobiliariaRepository repository)
        {
            _repository = repository;
        }

        public async Task<Imobiliaria> CreateAsync(Imobiliaria imobiliaria, CancellationToken cancellationToken = default)
        {
            return _repository.Create(imobiliaria);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public async Task<List<Imobiliaria>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return _repository.GetAll();
        }

        public async Task<Imobiliaria> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return _repository.GetById(id);
        }

        public async Task<Imobiliaria> UpdateAsync(int id, Imobiliaria imobiliaria, CancellationToken cancellationToken = default)
        {
           return _repository.Update(id, imobiliaria);
        }
    }
}