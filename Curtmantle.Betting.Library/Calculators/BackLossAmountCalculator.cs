using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Calculators
{
    public class BackLossAmountCalculator : IBetCalculator
    {

        public int Calculate(Curtmantle.Betting.Library.Bets.IReadableBet bet)
        {
            return bet.Stake;
        }
    }
}
