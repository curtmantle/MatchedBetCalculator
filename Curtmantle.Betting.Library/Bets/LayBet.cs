using System;
using System.Collections.Generic;
using System.Linq;
using Curtmantle.Betting.Library.Calculators;

namespace Curtmantle.Betting.Library.Bets
{
    public class LayBet : Bet
    {
        public LayBet()
        {
            this.WinReturnCalculator = new LayWinReturnCalculator();
            this.LossAmountCalculator = new LayLossAmountCalculator();
        }
    }
}