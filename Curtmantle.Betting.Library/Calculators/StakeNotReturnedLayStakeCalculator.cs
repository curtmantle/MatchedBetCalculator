using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Calculators
{
    using Curtmantle.Betting.Library.Bets;

    public class StakeNotReturnedLayStakeCalculator : IMatchedBetLayStakeCalculator
    {
        public int Calculate(IMatchedBet matchedBet)
        {
            var layStake = (matchedBet.BackWinReturn) / (matchedBet.LayOdds - matchedBet.LayCommission);

            return (int)Math.Round(layStake);
        }
    }
}
