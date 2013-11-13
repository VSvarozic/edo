﻿using EDO.UI.WebUI.Models;
using System.Web.Mvc;
using System.Runtime.Serialization;
using System.Web;
using Microsoft.Web.Mvc;

// http://stackoverflow.com/questions/6402628/multi-step-registration-process-issues-in-asp-net-mvc-splitted-viewmodels-sing/6403485#6403485
namespace EDO.UI.WebUI.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            var wizard = new RegistrationWizard();
            wizard.Initialize();

            return View(wizard);
        }

        [HttpPost]
        public ActionResult Index([Deserialize]RegistrationWizard wizard, IRegStepViewModel step)
        {
            wizard.Steps[wizard.CurrentStepIndex] = step;

            if(ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(Request["next"]))
                {
                    wizard.CurrentStepIndex++;
                }
                else if (!string.IsNullOrEmpty(Request["prev"]))
                {
                    wizard.CurrentStepIndex--;
                }
                else
                {
                    // TODO: we have finished: all the step partial
                    // view models have passed validation => map them
                    // back to the domain model and do some processing with
                    // the results

                    return Content("thanks for filling this form", "text/plain");
                }
            }
            else if(!string.IsNullOrEmpty(Request["prev"]))
            {
                // Even if validation failed we allow the user to
                // navigate to previous steps
                wizard.CurrentStepIndex--;
            }

            return View(wizard);
        }
	}
}