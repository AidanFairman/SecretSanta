using System.Collections.Generic;
using System.Security.Claims;
using SecretSanta.Controllers;
using SecretSanta.Games.Dto;
using Microsoft.AspNetCore.Mvc;

namespace SecretSanta.Games{
    public class GameController : BaseController{
        [HttpGet]
        public List<GameSummaryResponse> MyGames(){
            
        }

        [HttpGet("id/{gameId:long}")]
        public GameResponse GetGame(long gameId){
            
        }

        [HttpPost]
        public GameResponse CreateGame([FromBody] NewGameRequest newGame){
            
        }

        [HttpPut("id/{gameId:long}")]
        public GameResponse UpdateGame(long gameId, [FromBody] GameUpdateRequest gameUpdate){

        }

        [HttpPut("/start/id/{gameId:long}")]
        public GameResponse StartGame(long gameId){
            
        }
    }
}