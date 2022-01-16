using System;
using System.Linq;
using System.Threading.Tasks;
using CovidStats.Models;
using CovidStats.Services;
using CovidStats.Commands;
using CovidStats.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Data;
using System.ComponentModel;

namespace CovidStats.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        #region Ctor
        public MainViewModel()
        {
            Task.Run(this.GetCollection).Wait();

            _countriesView = CollectionViewSource.GetDefaultView(Countries);
            _countriesView.Filter = o =>
                String.IsNullOrEmpty(Filter) || ((CountryModel)o).Country.ToUpper().Contains(Filter.ToUpper());
        }
        #endregion


        #region Private fields
        private ICollectionView _countriesView;
        #endregion


        #region Props
        public ObservableCollection<CountryModel>? Countries { get; private set; }

        private CountryModel? _selectedCountry;
        public CountryModel? SelectedCountry
        {
            get => _selectedCountry;
            set => Set(ref _selectedCountry, value, nameof(SelectedCountry));
        }

        private ICommand? _updateCommand;
        public ICommand? UpdateCommand
        {
            get => _updateCommand ??= new RelayCommand(obj =>
             {
                 _selectedCountry = null;
                 Task.Run(GetCollection).Wait();
             });
        }

        private string _filter;
        public string Filter
        {
            get => _filter;
            set
            {
                if (value != _filter)
                {
                    _filter = value;
                    _countriesView.Refresh();
                    OnPropertyChanged(nameof(Filter));
                }
            }
        }
        #endregion


        #region Methods
        private async Task GetCollection()
        {
            var serivce = new StatsService();
            var summary = await serivce.GetData();
            var countries = summary.Countries;

            Countries = new ObservableCollection<CountryModel>(countries.Where(x => !string.IsNullOrWhiteSpace(x.Country)));
        }
        #endregion
    }
}
