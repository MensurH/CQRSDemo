using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<BetModel>> GetAllBets()
        {
            return await _mediator.Send(new GetBetListQuery());
        }
        [HttpGet("{id}")]
        public async Task<BetModel> GetBetById(int id)
        {
            return await _mediator.Send(new GetBetByIdQuery(id));
        }

        [HttpPost]
        public async Task<BetModel> AddBet([FromBody] BetModel value)
        {
            var model = new InsertBetCommand(value.Amount);
            return await _mediator.Send(model);    
        }

    }
}
