using CheckPoint1_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckPoint1_RPG.Persistence.Repository
{
    public class PersonagemRepository : IPersonagemRepository
    {
        private readonly OracleDbContext _dbContext;

        public PersonagemRepository(OracleDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Personagem> GetAll()
        {
            return _dbContext.Personagens.ToList();
        }

        public Personagem GetById(int id)
        {
            return _dbContext.Personagens.Find(id);
        }

        public void Add(Personagem entity)
        {
            _dbContext.Personagens.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Personagem entity)
        {
            _dbContext.Personagens.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Personagem entity)
        {
            _dbContext.Personagens.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
