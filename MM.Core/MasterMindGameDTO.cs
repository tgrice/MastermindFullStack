using System;
using System.Collections.Generic;

namespace MM.Core
{
    public class MasterMindGameDTO
    {
        public MasterMindGameDTO()
        {
            Id = Guid.NewGuid();
            turnNumber = 0;
            numOfTurns = 0;
            code = "";
            guess = "";
            gameFeedback = "";
            isWin = false;
            isLoss = false;
        }

        public Guid Id { get; set; }
        public int turnNumber { get; set; }
        public int numOfTurns { get; set; }
        public string code { get; set; }
        public string guess { get; set; }
        public string gameFeedback { get; set; }
        public bool isWin { get; set; }
        public bool isLoss { get; set; }

        public void IncrementTurnNumber()
        {
            turnNumber++;
        }
    
    }
}