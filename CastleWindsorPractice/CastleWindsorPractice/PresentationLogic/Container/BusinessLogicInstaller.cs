using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsorPractice.Domain;
using CastleWindsorPractice.Repository;

namespace CastleWindsorPractice.PresentationLogic.Container
{
    public class BusinessLogicInstaller : IWindsorInstaller
    {
        #region IWindsorInstaller Members

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IMemberRepository>()
                .ImplementedBy<MemberRepository>()
                );
        }

        #endregion
    }
}