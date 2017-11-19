using CritConfirmed.Services.DTOs.Characters;
using System.Collections.Generic;

namespace CritConfirmed.Services
{
    public interface ICharacterService
    {
        CharacterDTO GetCharacter(int charId);
        List<CharacterDTO> GetCharacters();
    }
}
