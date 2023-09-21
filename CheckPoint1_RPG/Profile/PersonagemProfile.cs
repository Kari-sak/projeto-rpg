using AutoMapper;
using CheckPoint1_RPG.Data.DTOs;
using CheckPoint1_RPG.Models;

namespace CheckPoint1_RPG.Profiles
{
    public class PersonagemProfile : Profile
    {
        public PersonagemProfile()
        {
            CreateMap<CriarPersonagemDto, Personagem>();
            CreateMap<AtualizarPersonagemDto, Personagem>();
            CreateMap<Personagem, AtualizarPersonagemDto>();
            CreateMap<Personagem, LerPersonagemDto>();

        }
    }
}
