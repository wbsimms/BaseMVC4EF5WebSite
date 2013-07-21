using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stub.Models;
using StubDataAccess;
using StubDataAccess.Entities;
using StubDataAccess.Repositories;
using StubDataAccess.Types;
using StubDataAccess.Utils;

namespace Stub.Controllers
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [Import(typeof(IRepositoryCollection))]
        public IRepositoryCollection Repositories { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddReview(MainModel model)
        {
            if (ShouldSave(model))
            {
                Repositories.ReviewRepository.AddReview(new Review()
                {
                    Subject = new Subject(){Name = model.Subject, SubjectType = EnumHelper<SubjectType>.StringToEnum(model.SelectedType)},
                    TwoWordReview = model.TwoWordReview,
                });
            }
            return View("AddReview", new MainModel());
        }

        public bool ShouldSave(MainModel model)
        {
            if (string.IsNullOrEmpty(model.Subject) || string.IsNullOrEmpty(model.TwoWordReview) ||
                string.IsNullOrEmpty(model.SelectedType)) return false;
            return true;
        }

    }
}
