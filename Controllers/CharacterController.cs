using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using dotNet_game_rpg.model;
using dotNet_game_rpg.Services.CharacterService;
using System.Threading.Tasks;
using dotNet_game_rpg.Dtos.Character;

namespace dotNet_game_rpg.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [Route("GetAll")]
        public async Task<IActionResult> Get(){
            return Ok( await _characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle( int id){
            return Ok( await _characterService.GetCharacterById(id));
        }
        [HttpPost] 
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter){
            return Ok( await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut] 
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updatedCharacter){
            ServiceResponse<GetCharacterDto> response = await _characterService.UpdateCharacter(updatedCharacter);
            if( response.Data == null){
                return NotFound(response);
            }
            return Ok( response ); 
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete( int id){
            ServiceResponse<List<GetCharacterDto>> response = await _characterService.DeleteCharacter(id);
            if( response.Data == null){
                return NotFound(response);
            }
            return Ok( response ); 
        }
    }
}