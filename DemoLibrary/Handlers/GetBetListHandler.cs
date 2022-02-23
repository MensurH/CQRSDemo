using DemoLibrary.DataAcces;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetBetListHandler : IRequestHandler<GetBetListQuery, List<BetModel>>
    {
        private readonly IBetData _data;
        public GetBetListHandler(IBetData data)
        {
            _data = data;
        }
        public Task<List<BetModel>> Handle(GetBetListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetBets());
        }
    }
}
