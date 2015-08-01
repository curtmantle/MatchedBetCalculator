using System;
using System.Collections.Generic;
using System.Linq;
using Curtmantle.Betting.Library.Bets;
namespace Curtmantle.Betting.Library.Calculators
{
    /// <summary>
    /// Interface for classes that perform a calculation on a bet
    /// </summary>
    public interface IBetCalculator
    {
        int Calculate(IReadableBet bet);
    }
}
