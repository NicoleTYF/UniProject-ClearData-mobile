﻿using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearData.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClearData
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogsPage : ContentPage
    {
        LogsViewModel _viewModel;
        public LogsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new LogsViewModel();
			
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private async void OnDataTypesPushed(object sender, System.EventArgs e)
        {
            await _viewModel.UpdateToDataTypesDisplay();
        }

        private async void OnServicePushed(object sender, System.EventArgs e)
        {
            await _viewModel.UpdateToServicesDisplay();
        }
    }
}
