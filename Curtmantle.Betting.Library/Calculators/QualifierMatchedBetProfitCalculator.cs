using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Curtmantle.Betting.Library.Bets;

namespace Curtmantle.Betting.Library.Calculators
{
    public class QualifierMatchedBetProfitCalculator : IMatchedBetProfitCalculator
    {
        public int CalculateLayProfit(IMatchedBet matchedBet)
        {
            var layReturn = (matchedBet.LayWinReturn * (1 - matchedBet.LayCommission)) - matchedBet.BackLossAmount;
            return (int)Math.Round(layReturn);
        }

        public int CalculateBackProfit(IMatchedBet matchedBet)
        {
            var backReturn = (matchedBet.BackWinReturn) - matchedBet.LayLossAmount;

            return backReturn;
        }
    }

}
