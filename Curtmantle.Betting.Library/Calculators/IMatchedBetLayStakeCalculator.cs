using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Calculators
{
    using Curtmantle.Betting.Library.Bets;

    public interface IMatchedBetLayStakeCalculator
    {
        int Calculate(IMatchedBet matchedBet);
    }
}