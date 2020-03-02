using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Cqrs.Commands;

namespace University.Domain.Cqrs.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
