using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Cqrs.Events
{
    public abstract class Message: IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
