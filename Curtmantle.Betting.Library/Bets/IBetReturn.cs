using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Bets
{
    public interface IBetReturn
    {
        /// <summary>
        /// The return if the bet wins
        /// </summary>
        int WinReturn { get; }
        /// <summary>
        /// How much is paid out if bet loses
        /// </summary>
        int LossAmount { get; }
    }
}
