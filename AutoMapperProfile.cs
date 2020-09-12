using AutoMapper;
using dotNet_game_rpg.Dtos.Character;
using dotNet_game_rpg.model;

namespace dotNet_game_rpg
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }   
    }
}