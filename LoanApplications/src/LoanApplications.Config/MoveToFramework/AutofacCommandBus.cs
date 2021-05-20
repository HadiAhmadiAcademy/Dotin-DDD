using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Framework.Application;

namespace LoanApplications.Config.MoveToFramework
{
    public class AutofacCommandBus : ICommandBus
    {
        private readonly ILifetimeScope _scope;
        public AutofacCommandBus(ILifetimeScope scope)
        {
            _scope = scope;
        }
        public async Task Dispatch<T>(T command) where T : ICommand
        {
            var handler = _scope.Resolve<ICommandHandler<T>>();
            await handler.Handle(command);
        }
    }
}
