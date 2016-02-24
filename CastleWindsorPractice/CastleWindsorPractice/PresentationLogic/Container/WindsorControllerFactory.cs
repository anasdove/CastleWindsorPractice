using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.MicroKernel;

namespace CastleWindsorPractice.PresentationLogic.Container
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        #region Declarations

        private readonly IKernel m_kernel;

        #endregion

        #region Constructor

        public WindsorControllerFactory(IKernel kernel)
        {
            m_kernel = kernel;
        }

        #endregion

        #region Override Methods

        public override void ReleaseController(IController controller)
        {
            m_kernel.ReleaseComponent(controller);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(404, string.Format("The controller for path '{0}' could not be found.", 
                    requestContext.HttpContext.Request.Path));
            }

            return (IController) m_kernel.Resolve(controllerType);
        }

        #endregion
    }
}