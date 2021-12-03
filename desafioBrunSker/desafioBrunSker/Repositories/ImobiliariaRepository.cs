using desafioBrunSker.Models;
using System.Linq;

namespace desafioBrunSker.Repositories
{
    public class ImobiliariaRepository : IImobiliariaRepository
    {

        private readonly MysqlContext _dbContext;

        public ImobiliariaRepository(MysqlContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Imobiliaria Create(Imobiliaria imobiliaria)
        {
            _dbContext.Imobiliarias.Add(imobiliaria);
            _dbContext.SaveChanges();

            return imobiliaria;
        }

        public void Delete(int id)
        {
            _dbContext.Remove(_dbContext.Imobiliarias.SingleOrDefault(imobiliaria => imobiliaria.Id.Equals(id)));
            _dbContext.SaveChanges();
        }

        public List<Imobiliaria> GetAll()
        {
            return _dbContext.Imobiliarias.ToList();
        }

        public Imobiliaria GetById(int id)
        {
            return _dbContext.Imobiliarias.SingleOrDefault(imobiliaria => imobiliaria.Id.Equals(id));
        }

        public Imobiliaria Update(int id, Imobiliaria imobiliaria)
        {
            var imobiliariaUpdate = GetById(id);

            if (imobiliariaUpdate != null)
            {
                try
                {
                    _dbContext.Entry(imobiliariaUpdate).CurrentValues.SetValues(imobiliaria);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return imobiliaria;
            }

            return null;
        }
    }
}