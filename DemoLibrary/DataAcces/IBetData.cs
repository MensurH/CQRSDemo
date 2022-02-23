using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAcces
{
    public interface IBetData
    {
        List<BetModel> GetBets();
        BetModel InsertBet(double amount);
    }
}
