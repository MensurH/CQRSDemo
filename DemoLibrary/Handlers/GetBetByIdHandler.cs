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
    public class GetBetByIdHandler : IRequestHandler<GetBetByIdQuery,BetModel>
    {
        private readonly IMediator _mediator;
        public GetBetByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<BetModel> Handle(GetBetByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetBetListQuery());

            var bet = result.FirstOrDefault(x=>x.ID==request.ID);

            return bet;
        }
    }
}
