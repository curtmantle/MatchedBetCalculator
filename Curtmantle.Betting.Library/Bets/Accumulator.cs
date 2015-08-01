using System;
using System.Collections.Generic;
using System.Linq;

namespace Curtmantle.Betting.Library.Bets
{
    /// <summary>
    /// An Accumulator uses a previous winning bet as the stake for 
    /// another bet
    /// </summary>
    public class Accumulator : IReadableBet
    {
        private IReadableBet previousBet;
        private Curtmantle.Betting.Library.Calculators.IBetCalculator winReturnCalculator;

        public Accumulator(IReadableBet bet)
        {
            this.previousBet = bet;
            this.winReturnCalculator = new Curtmantle.Betting.Library.Calculators.BackWinReturnCalculator();
        }

        public int Stake
        {
            get
            {
                return previousBet.WinReturn + previousBet.Stake;
            }

        }

        public double Odds { get; set; }

        public double Commission { get; set; }

        public int WinReturn
        {
            get { return this.winReturnCalculator.Calculate(this); }
        }

        public int LossAmount
        {
            get { return this.Stake; }
        }

    }
}