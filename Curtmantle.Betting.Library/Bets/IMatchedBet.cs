using System;
using System.Collections.Generic;
using System.Linq;
using Curtmantle.Betting.Library.Calculators;

namespace Curtmantle.Betting.Library.Bets
{
    public interface IMatchedBet
    {
        IMatchedBetLayStakeCalculator LayStakeCalculator { get; set; }

        int BackStake { get; set; }
        double BackOdds { get; set; }
        double BackCommission { get; set; }
        int BackWinReturn { get; }
        int BackLossAmount { get; }

        int LayStake { get; }
        double LayOdds { get; set; }
        double LayCommission { get; set; }
        int LayWinReturn { get; }
        int LayLossAmount { get; }

        int ProfitIfBackBetWins { get; }
        int ProfitIfLayBetWins { get; }

        void Calculate();
    }
}
