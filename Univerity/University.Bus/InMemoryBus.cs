using MediatR;
using System;
using System.Threading.Tasks;
using University.Domain.Cqrs.Bus;
using University.Domain.Cqrs.Commands;

namespace University.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
