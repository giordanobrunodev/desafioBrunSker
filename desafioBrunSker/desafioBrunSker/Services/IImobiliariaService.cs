using System.Collections.Generic;
using desafioBrunSker.Models;

namespace desafioBrunSker.Services
{
    public interface IImobiliariaService
    {
        List<Imobiliaria> GetAll();
        Imobiliaria GetById(int id);
        Imobiliaria Create(Imobiliaria imobiliaria);
        Imobiliaria Update(int id, Imobiliaria imobiliaria);
        void Delete(int id);
    }
}