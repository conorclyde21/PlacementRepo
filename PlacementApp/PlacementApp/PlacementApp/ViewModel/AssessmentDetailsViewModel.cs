﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PlacementApp.Models;
using PlacementApp.Utils;

namespace PlacementApp.ViewModels
{
    public class AssessmentDetailsViewModel : INotifyPropertyChanged
    {
        private List<Assessment> _assessments;
        private Assessment _selectedAssessment;
        private bool _isRefreshing;

        public List<Assessment> Assessments
        {
            get
            {
                return _assessments;
            }
            set
            {
                _assessments = value;
                OnPropertyChanged(nameof(Assessments));
            }
        }
        public Assessment SelectedAssessment
        {
            get
            {
                return _selectedAssessment;
            }
            set
            {
                _selectedAssessment = value;
                OnPropertyChanged(nameof(SelectedAssessment));
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

        public AssessmentDetailsViewModel()
        {
            Assessments = DummyAssessmentData.GetAssessments();
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