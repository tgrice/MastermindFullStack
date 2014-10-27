using System;
using System.Collections.Generic;

namespace MM.Core
{
    public class GameServer
    {
        private readonly IDictionary<Guid, MasterMindGameDTO> _games;

        public GameServer()
        {
            _games = new Dictionary<Guid, MasterMindGameDTO>(); 
        } 

        public void AddMasterMindGame(Guid id, MasterMindGameDTO mmGameDto)
        {
            _games.Add(id, mmGameDto);
        }

        public MasterMindGameDTO GetMasterMindGameByGuid(Guid id)
        {
            return _games[id];
        }
    }
}
