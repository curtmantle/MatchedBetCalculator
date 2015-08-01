using Curtmantle.Betting.Library.Bets;
using Curtmantle.Betting.Library.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MatchedBetCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var matchedBet = new MatchedBet(new StakeReturnedLayStakeCalculator(), new QualifierMatchedBetProfitCalculator())
            {
                BackStake = 1000,
                BackOdds = 5.6,
                LayOdds = 5.6,
                LayCommission = 0.05
            };

            matchedBet.Calculate();

            Console.WriteLine("Lay Stake is {0} and Liability is {1}", matchedBet.LayStake / 100.0d, matchedBet.LayLossAmount / 100.0d);
            Console.WriteLine("Profit if back back wins = {0} Profit if lay bet wins = {1}", matchedBet.ProfitIfBackBetWins/100.0, matchedBet.ProfitIfLayBetWins/100.0);
        }
    }
}
