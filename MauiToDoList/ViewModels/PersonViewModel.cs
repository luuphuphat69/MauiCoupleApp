using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiToDoList.ViewModels
{
    public partial class PersonViewModel: ObservableObject
    {
        PersonModel person = new();             // Save data
        PersonModel person2 = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DisplayName))]
        string name;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DisplayName))]
        string name2;
        public string DisplayName { get; set; }
        [RelayCommand]
        async Task GetPersonAsync()
        {
            person.name = Name;
            person2.name = Name2;
            try
            {

                if(Name.Length > 0 && Name2.Length == 0)
                {
                    Name2 = "Lonely";;
                    person2.name = Name2;
                }else if(Name.Length == 0 && Name2.Length > 0)
                {
                    Name = "Lonely";
                    person.name = Name;
                }
                DisplayName = $"Hello, {Name} and {Name2}";
                await Shell.Current.DisplayAlert("Submit Info", "Submit success", "OK");
                ClearFields();
            }catch(Exception e)
            {
                Console.WriteLine(e);
                await Shell.Current.DisplayAlert("Error", $"Unable to get person: {e}", "OK");
            }
        }
        void ClearFields()
        {
            Name = String.Empty;
            Name2 = String.Empty;
        }
    }
}
