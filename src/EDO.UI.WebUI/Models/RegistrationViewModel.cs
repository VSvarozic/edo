using EDO.UI.WebUI.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDO.UI.WebUI.Models
{
    [Serializable]
    public class RegistrationViewModel
    {
        private ChooseAccountType _firstStep;

        public int CurrentStepIndex { get; set; }
        public IList<IRegistrationStepVM> Steps { get; set; }
        public IList<string> StepTitles { get; set; }
        
        public RegistrationViewModel()
        {
            CurrentStepIndex = 0;
            Steps = new List<IRegistrationStepVM>();
            StepTitles = new List<string>();

            _firstStep = (ChooseAccountType)TruncateToFirstStep();

            // Пока руками инициализируем
            _firstStep.AccountType = new AccountTypeVM
            {
                Id = 1,
                Title = "Индивидуальный Пр",
                Code = "individual"
            };
        }

        public IRegistrationStepVM GetNextStep()
        {
            if(CurrentStepIndex > 0 && !IsTypeOk(CurrentStepIndex))
            {
                return TruncateToFirstStep();
            }

            var nextStep = GetNextStepByAccountType(CurrentStepIndex + 1);

            if(nextStep == null)
            {
                return Steps.ElementAt(CurrentStepIndex);
            }

            ++CurrentStepIndex;

            return nextStep;
        }

        public IRegistrationStepVM GetPreviousStep()
        {
            if(CurrentStepIndex <= 1) 
            {
                CurrentStepIndex = 0;
                return _firstStep;
            }

            var previous = Steps.ElementAtOrDefault(CurrentStepIndex - 1);
            if(previous == null) 
            {
                return TruncateToFirstStep();
            }

            --CurrentStepIndex;
            return previous;
        }


        private IRegistrationStepVM TruncateToFirstStep()
        {
            CurrentStepIndex = 0;
            Steps.Clear();
            Steps.Add(new ChooseAccountType());

            StepTitles.Clear();
            StepTitles.Add("Выбор типа аккаунта");

            return Steps.ElementAt(0);
        }

        private bool IsTypeOk(int stepIndex)
        {
            var currentStep = Steps.ElementAtOrDefault(stepIndex);

            switch (_firstStep.AccountType.Code.ToLower())
            {
                case "individual"   : return currentStep is IIndividualRegStep;
                case "business"     : return currentStep is IBusinessRegStep;  
                case "private"      : return currentStep is IPrivateRegStep;   
            }

            return false;
        }

        protected IRegistrationStepVM GetNextStepByAccountType(int stepIndex)
        {
            // Проверим что след шаг наличиствует и если он соответствует типу - возвращаем его
            var step = Steps.ElementAtOrDefault(stepIndex);

            if(step != null && IsTypeOk(stepIndex))
            {
                return step;
            }

            var stepTitle = "";

            switch (_firstStep.AccountType.Code.ToLower())
            {
                case "individual" :
                    {
                        switch(stepIndex)
                        {
                            case 1: step = new IndividualBase(); stepTitle = "Основные данные ИП"; break;
                        }
                    }; break;
                case "business":
                    {
                        switch(stepIndex)
                        {
                            case 1: step = new BusinessBase(); stepTitle = "Основные данные организации";  break;
                        }
                    }; break;
                case "private":
                    {
                        switch(stepIndex)
                        {
                            case 1: step = new PrivateBase(); stepTitle = "Основные данные физического лица";  break;
                        }
                    }; break;
            }

            Steps.Add(step);
            StepTitles.Add(stepTitle);

            return step;
        }
    }
}