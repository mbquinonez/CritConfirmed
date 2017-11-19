using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CritConfirmed.Entities;
using CritConfirmed.Services.DTOs.Characters;

namespace CritConfirmed.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly CCDbContext _db;

        public CharacterService(CCDbContext db)
        {
            _db = db;
        }

        public CharacterDTO GetCharacter(int charId)
        {
            return _db.Characters.Where(c => c.Id == charId).Select(c => this.BuildDTO(c)).FirstOrDefault();
        }

        public List<CharacterDTO> GetCharacters()
        {
            return _db.Characters.Select(c => this.BuildDTO(c)).ToList();
        }

        private CharacterDTO BuildDTO(Character character)
        {
            return new CharacterDTO()
            {
                Id = character.Id,
                Name = character.Name,
                MetaType = character.MetaType,
                Body = character.Body,
                Agility = character.Agility,
                Reaction = character.Reaction,
                Strength = character.Strength,
                Charisma = character.Charisma,
                Intuition = character.Intuition,
                Logic = character.Logic,
                Willpower = character.Willpower,
                Essence = character.Essence,
                Edge = character.Edge,
                Magic = character.Magic,
                Resonance = character.Resonance
            };
        }
    }
}
