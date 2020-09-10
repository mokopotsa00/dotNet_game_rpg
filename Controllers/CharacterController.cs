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
    }
}