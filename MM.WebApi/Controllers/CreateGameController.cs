using System;
using System.Web.Http;
using MM.Core;
using MM.WebApi.Models;

namespace MM.WebApi.Controllers
{
    public class CreateGameController : ApiController
    {
        private readonly ICodeGenerator _codeGenerator;
        private readonly GameServer _gameServer;

        public CreateGameController(ICodeGenerator cg, GameServer gameServer)
        {
            _codeGenerator = cg;
            _gameServer = gameServer;
        }

        public MasterMindGameDTO Post(CreateGameDTO newGameDTO)
        {
            var turns = newGameDTO.turns;
            var mastermindGame = new MasterMindGameDTO() {code = _codeGenerator.GenerateCode(), numOfTurns = newGameDTO.turns};
            _gameServer.AddMasterMindGame(mastermindGame.Id, mastermindGame);
            return mastermindGame;
        }

        public GameServer GameServer { get { return _gameServer; }}
    }
}