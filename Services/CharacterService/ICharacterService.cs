
using System.Collections.Generic;
using System.Threading.Tasks;
using dotNet_game_rpg.Dtos.Character;
using dotNet_game_rpg.model;

namespace dotNet_game_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

    }
}