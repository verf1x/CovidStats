using System;
using System.Collections.Generic;

namespace CovidStats.Models
{
    internal class SummaryModel : ObservableObject
    {
        private IEnumerable<CountryModel>? _countries;
        public IEnumerable<CountryModel>? Countries{ get => _countries; set => Set(ref _countries, value, nameof(CountryModel)); }

        private DateTime _date;
        public DateTime Date { get => _date; set => Set(ref _date, value, nameof(Date)); }
    }
}
