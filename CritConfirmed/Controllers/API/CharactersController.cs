using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CritConfirmed.Services;
using CritConfirmed.Services.DTOs.Characters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CritConfirmed.Controllers.API
{
    [Route("api/Characters")]
    public class CharactersController : Controller
    {
        private readonly ICharacterService _characterService;

        public CharactersController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            List<CharacterDTO> characters = _characterService.GetCharacters();
            return new ObjectResult(characters) { StatusCode = 200 };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CharacterDTO character = _characterService.GetCharacter(id);
            return new ObjectResult(character) { StatusCode = 200 };
        }
    }
}
