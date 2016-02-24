using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CastleWindsorPractice.Domain;

namespace CastleWindsorPractice.Controllers
{
    public class HomeController : Controller
    {
        #region Declarations

        private readonly IMemberRepository m_memberRepository;

        #endregion

        #region Constructor

        // Inject dependency
        public HomeController(IMemberRepository memberRepository)
        {
            m_memberRepository = memberRepository;
        }

        #endregion

        public ActionResult Index()
        {
            m_memberRepository.Add(new Member());

            return View();
        }

    }
}
