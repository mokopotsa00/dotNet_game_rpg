using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNet_game_rpg.Dtos.Character;
using dotNet_game_rpg.model;

namespace dotNet_game_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private List<Character> characters = new List<Character>{
            new Character(),
            new Character{ Id = 1, Name = "Sam"}
        };
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();
            serviceResponse.Data = characters.FirstOrDefault( c => c.Id == id);
            return serviceResponse;
        }
    }
}