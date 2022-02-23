using DemoLibrary.Commands;
using DemoLibrary.DataAcces;
using DemoLibrary.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertBetHandler : IRequestHandler<InsertBetCommand, BetModel>
    {
        private readonly IBetData _data;

        public InsertBetHandler(IBetData data)
        {
            _data = data;
        }
        public Task<BetModel> Handle(InsertBetCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertBet(request.amount));
        }
    }
}
