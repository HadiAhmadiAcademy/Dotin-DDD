using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Framework.Application;
using LoanApplications.Application;
using LoanApplications.Config.Fakes;
using LoanApplications.Config.MoveToFramework;
using LoanApplications.Domain.Model.LoanApplications;

namespace LoanApplications.Config
{
    public class LoanApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AutofacCommandBus>().As<ICommandBus>().InstancePerLifetimeScope();
            builder.RegisterType<LoanApplicationHandlers>()
                .As<ICommandHandler<PlaceLoanApplication>>()
                .InstancePerLifetimeScope();
            builder.RegisterType<InMemoryLoanApplicationRepository>()
                .As<ILoanApplicationRepository>()
                .InstancePerLifetimeScope();

            //.............

            base.Load(builder);
        }
    }
}
