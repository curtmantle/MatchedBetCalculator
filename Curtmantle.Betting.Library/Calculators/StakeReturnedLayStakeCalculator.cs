using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Calculators
{
    using Curtmantle.Betting.Library.Bets;

    public class StakeReturnedLayStakeCalculator : IMatchedBetLayStakeCalculator
    {
        public int Calculate(IMatchedBet matchedBet)
        {
            var layStake = (matchedBet.BackWinReturn + matchedBet.BackStake) / (matchedBet.LayOdds - matchedBet.LayCommission);

            return (int)Math.Round(layStake);
        }
    }
}