using System.Collections.Generic;
using desafioBrunSker.Models;

namespace desafioBrunSker.Repositories
{
    public interface IImobiliariaRepository
    {
        List<Imobiliaria> GetAll();
        Imobiliaria GetById(int id);
        Imobiliaria Create(Imobiliaria imobiliaria);
        Imobiliaria Update(int id, Imobiliaria imobiliaria);
        void Delete(int id);
    }
}