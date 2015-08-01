using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Bets
{
    public interface IReadableBet : IBetReturn
    {
        /// <summary>
        /// The amount being staked
        /// </summary>
        int Stake { get; }

        /// <summary>
        /// The odds of the bet
        /// </summary>
        double Odds { get; }

        /// <summary>
        /// How much commission is paid for wins
        /// </summary>
        double Commission { get; }
    }
}
