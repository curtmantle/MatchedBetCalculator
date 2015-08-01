using System;
using System.Collections.Generic;
using System.Linq;
using Curtmantle.Betting.Library.Calculators;

namespace Curtmantle.Betting.Library.Bets
{
    public class MatchedBet : IMatchedBet
    {

        private IWriteableBet backBet;
        private IWriteableBet layBet;

        public MatchedBet(IMatchedBetLayStakeCalculator stakeCalculator, IMatchedBetProfitCalculator profitCalculator)
        {
            this.backBet = new BackBet();
            this.layBet = new LayBet();
            this.LayStakeCalculator = stakeCalculator;
            this.ProfitCalculator = profitCalculator;
        }

        #region Public Properties

        public IMatchedBetLayStakeCalculator LayStakeCalculator { get; set; }
        public IMatchedBetProfitCalculator ProfitCalculator { get; set; }

        public int BackStake
        {
            get { return this.backBet.Stake; }
            set { this.backBet.Stake = value; }
        }

        public int LayStake
        {
            get { return this.layBet.Stake; }
        }

        public double BackOdds
        {
            get { return this.backBet.Odds; }
            set { this.backBet.Odds = value; }
        }

        public double LayOdds
        {
            get { return this.layBet.Odds; }
            set { this.layBet.Odds = value; }
        }

        public double BackCommission
        {
            get { return this.backBet.Commission; }
            set { this.backBet.Commission = value; }
        }

        public double LayCommission
        {
            get { return this.layBet.Commission; }
            set { this.layBet.Commission = value; }
        }

        public int BackWinReturn
        {
            get { return this.backBet.WinReturn; }
        }

        public int LayWinReturn
        {
            get { return this.layBet.WinReturn; }
        }

        public int BackLossAmount
        {
            get { return this.backBet.LossAmount; }
        }

        public int LayLossAmount
        {
            get { return this.layBet.LossAmount; }
        }

        public int ProfitIfBackBetWins
        {
            get;
            private set;
        }

        public int ProfitIfLayBetWins
        {
            get;
            private set;
        }
        #endregion

        #region Public Methods

        public void Calculate()
        {
            this.layBet.Stake = this.LayStakeCalculator.Calculate(this);

            this.ProfitIfBackBetWins = this.ProfitCalculator.CalculateBackProfit(this);

            this.ProfitIfLayBetWins = this.ProfitCalculator.CalculateLayProfit(this);
        }

        #endregion
    }
}
