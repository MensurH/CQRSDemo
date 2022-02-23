using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAcces
{
    public class BetData : IBetData
    {
        private List<BetModel> bets = new();

        public BetData()
        {
            bets.Add(new BetModel { ID = 1, Amount = 2.5 });
            bets.Add(new BetModel { ID = 2, Amount = 3.5 });

        }
        public List<BetModel> GetBets()
        {
            return bets;
        }

        public BetModel InsertBet(double amount)
        {
            BetModel b = new() { Amount = amount };
            b.ID = bets.Max(x => x.ID) + 1;
            bets.Add(b);
            return b;

        }
    }
}
