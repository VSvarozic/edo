using EDO.Model.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EDO.UI.WebUI.Models
{
    public interface IRegStepViewModel { }

    [Serializable]
    public class RegStep1ViewModel : IRegStepViewModel
    {
        //[Required]
        public IList<BussinessType> BussinessType { get; set; }

    }

    [Serializable]
    public class RegStep2ViewModel : IRegStepViewModel
    {

    }

    [Serializable]
    public class RegStep3ViewModel : IRegStepViewModel
    {

    }
    
    [Serializable]
    public class RegistrationWizard
    {        
        public int CurrentStepIndex { get; set; }
        public IList<IRegStepViewModel> Steps { get; set; }

        public void Initialize()
        {
            Steps = typeof(IRegStepViewModel)
                        .Assembly
                        .GetTypes()
                        .Where(t => !t.IsAbstract && typeof(IRegStepViewModel).IsAssignableFrom(t))
                        .Select(t => (IRegStepViewModel)Activator.CreateInstance(t))
                        .ToList();
        }
    }
}