using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MM.Core;
using MM.WebApi.Models;

namespace MM.WebApi.Controllers
{
    public class GameController : ApiController
    {
        private GameServer _gameServer;

        public GameController(GameServer gameServer)
        {
            _gameServer = gameServer;
        }

        public MasterMindGameDTO Put(Guid id, GameDTO gameDto)
        {
            var fb = new Feedback();

            var masterMindGameDto = _gameServer.GetMasterMindGameByGuid(id);

            masterMindGameDto.guess = gameDto.guess;

            masterMindGameDto.gameFeedback = fb.getFeedback(masterMindGameDto.guess, masterMindGameDto.code);

            if (masterMindGameDto.turnNumber == (masterMindGameDto.numOfTurns - 1))
            {
                masterMindGameDto.isLoss = true;
                masterMindGameDto.gameFeedback = "Game Over!\n Code: " + masterMindGameDto.code;
            }
            if (masterMindGameDto.code == masterMindGameDto.guess)
            {
                masterMindGameDto.isWin = true;
            }

            masterMindGameDto.IncrementTurnNumber();

            return masterMindGameDto;
        }
    }
}
