using AutoMapper;
using CheckPoint1_RPG.Models;
using CheckPoint1_RPG.Persistence;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using CheckPoint1_RPG.Data.DTOs;

namespace CheckPoint1_RPG.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PersonagemController : ControllerBase
    {
        private OracleDbContext _context;
        private IMapper _mapper;

        public PersonagemController(OracleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarPersonagem([FromBody] CriarPersonagemDto PersonagemDto)
        {
            Personagem personagem = _mapper.Map<Personagem>(PersonagemDto);
            _context.Personagens.Add(personagem);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPersonagemById), new { id = personagem.Id }, personagem);
        }

        [HttpGet]
        public IEnumerable<LerPersonagemDto> GetAllPersonagens(
            [FromQuery] int skip = 0,
            [FromQuery] int take = 10,
            [FromQuery] string? nome = null
        )

        {
            if (nome != null)
            {
                return _mapper.Map<List<LerPersonagemDto>>(_context.Personagens.Where((personagem) => personagem.Nome == nome));   
            }

            return _mapper.Map<List<LerPersonagemDto>>(_context.Personagens.Skip(skip).Take(take));

        }

        [HttpGet("{id}")]
        public IActionResult GetPersonagemById(int id)
        {
            Personagem? personagem = _context.Personagens.FirstOrDefault((personagem) => personagem.Id == id);

            if (personagem == null)
            {
                return NotFound();
            }

            LerPersonagemDto persoDto = _mapper.Map<LerPersonagemDto>(personagem);

            return Ok(persoDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePersonagem(int id, [FromBody] AtualizarPersonagemDto persoDto)
        {
            Personagem? personagem = _context.Personagens.FirstOrDefault((personagem) => personagem.Id == id);

            if (personagem == null)
            {
                return NotFound();
            }

            _mapper.Map(persoDto, personagem);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PatchPersonagem(int id, JsonPatchDocument<AtualizarPersonagemDto> patch)
        {
            Personagem? personagem = _context.Personagens.FirstOrDefault((personagem) => personagem.Id == id);

            if (personagem == null)
            {
                return NotFound();
            }

            AtualizarPersonagemDto personagemToUpdate = _mapper.Map<AtualizarPersonagemDto>(personagem);
            patch.ApplyTo(personagemToUpdate, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!TryValidateModel(personagemToUpdate))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(personagemToUpdate, personagem);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePersonagem(int id)
        {
            Personagem? personagem = _context.Personagens.FirstOrDefault((personagem) => personagem.Id == id);

            if (personagem == null)
            {
                return NotFound();
            }

            _context.Remove(personagem);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
