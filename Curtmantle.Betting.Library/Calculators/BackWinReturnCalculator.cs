using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Calculators
{
    public class BackWinReturnCalculator : IBetCalculator
    {
        public int Calculate(Curtmantle.Betting.Library.Bets.IReadableBet bet)
        {
            return (int)Math.Round(bet.Stake * (bet.Odds - 1));
        }
    }
}
