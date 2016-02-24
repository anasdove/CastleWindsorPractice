using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace CastleWindsorPractice.PresentationLogic.Container
{
    public static class IoCContainer
    {
        #region Declarations

        private static IWindsorContainer _container;

        #endregion

        #region Public Methods

        public static void Setup()
        {
            // Run all class that inherit from IWindsor Installer
            // 1. BusinessLogicInstaller
            // 2. ControllerInstaller
            _container = new WindsorContainer().Install(FromAssembly.This());

            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        #endregion
    }
}