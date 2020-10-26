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
    }
}
