using System;
using System.Collections.Generic;
using System.Linq;
using Curtmantle.Betting.Library.Calculators;
namespace Curtmantle.Betting.Library.Bets
{
    public class BackBet : Bet
    {
        public BackBet()
        {
            this.WinReturnCalculator = new BackWinReturnCalculator();
            this.LossAmountCalculator = new BackLossAmountCalculator();
        }

    }
}