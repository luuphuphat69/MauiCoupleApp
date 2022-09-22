using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiToDoList.ViewModels
{
    public partial class DateViewModel: ObservableObject
    {
        public string DisplayDate => $"Các bạn đã quen được {TotalDay} ngày";
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DisplayDate))]
        public double? totalDay = 0;

        [ObservableProperty]
        DateTime startDate;

        [ObservableProperty]
        DateTime endDate;

        [RelayCommand]
        public async void OnCaculateDate()
        {
            try
            {
                if (StartDate > DateTime.MinValue && EndDate < DateTime.Now)
                    TotalDay = (EndDate.Date - StartDate.Date).TotalDays;
                else
                {
                    await Shell.Current.DisplayAlert("Error", "Wrong Date", "OK");
                }
            }
            catch(Exception e)
            {
                 await Shell.Current.DisplayAlert("Error", $"Unable to calculate {e}", "OK");
            }
        }
    }
}
    