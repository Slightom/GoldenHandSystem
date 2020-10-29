using GoldenHand.Models;
using GoldenHand.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenHand.Helpers
{
    public class MappingHelper
    {
        public static IList<FormViewModel> MapFormModelToFormViewModel(IList<Form> formModels)
        {
            IList<FormViewModel> formViewModels = new List<FormViewModel>();
            FormViewModel fd;

            foreach (var d in formModels)
            {
                fd = new FormViewModel();
                fd.FormId = d.FormId;
                fd.Lp = d.Lp;
                fd.Info = d.Info;
                fd.SeniorName = d.Senior.Name;
                fd.SeniorAddress = d.Senior.Address;
                fd.SeniorPhoneNumber = d.Senior.PhoneNumber;
                fd.FormStatusName = d.FormStatus.ToString();
                fd.WorkerName = d.Worker.Name;
                fd.RegistrationDate = d.RegistrationDate;
                fd.RepairDate = d.RepairDate;
                formViewModels.Add(fd);
            }

            return formViewModels;
        }

        public static IList<SeniorViewModel> MapSeniorModelToSeniorViewModel(List<Senior> seniorList)
        {
            IList<SeniorViewModel> seniorViewModels = new List<SeniorViewModel>();
            SeniorViewModel sv;
            List<Form> seniorForms;

            foreach(var s in seniorList)
            {
                sv = new SeniorViewModel();
                sv.SeniorId = s.SeniorId;
                sv.Name = s.Name;
                sv.Address = s.Address;
                sv.PhoneNumber = s.PhoneNumber;
                sv.SeniorShortcut = s.SeniorShortcut;
                seniorForms = GoldenHandContext.Instance.Forms.Where(x => x.SeniorId == s.SeniorId).ToList();
                sv.FormsAll = seniorForms.Count();
                sv.FormsFinished = seniorForms.Where(x => x.FormStatus.Name == Helpers.FormStatusName.FINISHED).Count();
                sv.FormsRegisted = seniorForms.Where(x => x.FormStatus.Name == Helpers.FormStatusName.REGISTED).Count();
                sv.FormsRejected = seniorForms.Where(x => x.FormStatus.Name == Helpers.FormStatusName.REJECTED).Count();
                seniorViewModels.Add(sv);
            }

            return seniorViewModels;
        }
    }
}
