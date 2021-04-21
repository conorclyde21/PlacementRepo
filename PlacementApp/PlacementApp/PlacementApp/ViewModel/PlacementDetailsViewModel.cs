using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PlacementApp.Models;
using PlacementApp.Utils;

namespace PlacementApp.ViewModels
{
    public class PlacementDetailsViewModel : INotifyPropertyChanged
    {
        private List<Schedule> _schedules;
        private Schedule _selectedSchedule;
        private bool _isRefreshing;

        public List<Schedule> Schedules
        {
            get
            {
                return _schedules;
            }
            set
            {
                _schedules = value;
                OnPropertyChanged(nameof(Schedules));
            }
        }
        public Schedule SelectedSchedule
        {
            get
            {
                return _selectedSchedule;
            }
            set
            {
                _selectedSchedule = value;
                OnPropertyChanged(nameof(SelectedSchedule));
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand { get; set; }

        public PlacementDetailsViewModel()
        {
            Schedules = DummyScheduleData.GetSchedules();
            RefreshCommand = new Command(CmdRefresh);
        }

        private async void CmdRefresh()
        {
            IsRefreshing = true;
            await Task.Delay(3000);
            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}