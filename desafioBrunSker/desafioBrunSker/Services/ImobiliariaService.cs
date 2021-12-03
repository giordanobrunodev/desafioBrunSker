using System.Collections.Generic;
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

        public Imobiliaria Create(Imobiliaria imobiliaria)
        {
            return _repository.Create(imobiliaria);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Imobiliaria> GetAll()
        {
            return _repository.GetAll();
        }

        public Imobiliaria GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Imobiliaria Update(int id, Imobiliaria imobiliaria)
        {
           return _repository.Update(id, imobiliaria);
        }
    }
}