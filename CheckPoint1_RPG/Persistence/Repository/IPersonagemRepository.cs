using CheckPoint1_RPG.Models;

namespace CheckPoint1_RPG.Persistence
{
    public interface IPersonagemRepository
    {
        Personagem GetById(int id);

        IEnumerable<Personagem> GetAll();

        void Add(Personagem entity);

        void Update(Personagem entity);

        void Delete(Personagem entity);

    }
}
