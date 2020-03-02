using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Cqrs.Events;

namespace University.Domain.Cqrs.Commands
{
    public abstract class Command: Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

    }
}
