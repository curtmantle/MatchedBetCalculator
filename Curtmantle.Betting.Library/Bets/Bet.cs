using System;
using System.Collections.Generic;
using System.Linq;
using Curtmantle.Betting.Library.Calculators;

namespace Curtmantle.Betting.Library.Bets
{
    public abstract class Bet : IReadableBet, IWriteableBet
    {

        protected Bet()
        {

        }

        public int Stake { get; set; }

        public double Odds { get; set; }

        public double Commission { get; set; }

        public int WinReturn
        {
            get
            {
                if (this.WinReturnCalculator == null)
                    return 0;

                return this.WinReturnCalculator.Calculate(this);
            }
        }

        public int LossAmount
        {
            get
            {
                if (this.LossAmountCalculator == null)
                    return 0;

                return this.LossAmountCalculator.Calculate(this);
            }
        }

        protected IBetCalculator WinReturnCalculator { get; set; }

        protected IBetCalculator LossAmountCalculator { get; set; }

    }
}
