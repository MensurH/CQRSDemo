using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetBetByIdQuery(int ID): IRequest<BetModel>;
    //internal class GetBetByIdQuery
    //{
    //}
}
