
namespace CovidStats.Models
{
    internal class CountryModel : ObservableObject
    {
        private string? _country;
        public string? Country
        {
            get => _country;
            set => Set(ref _country, value, nameof(Country));
        }

        private string? _slug;
        public string? Slug
        {
            get => _slug;
            set => Set(ref _slug, value, nameof(Slug));
        }

        private int _newConfirmed;
        public int NewConfirmed
        {
            get => _newConfirmed;
            set => Set(ref _newConfirmed, value, nameof(NewConfirmed));
        }

        private int _totalConfirmed;
        public int TotalConfirmed
        {
            get => _totalConfirmed;
            set => Set(ref _totalConfirmed, value, nameof(TotalConfirmed));
        }

        private int _newDeaths;
        public int NewDeaths
        {
            get => _newDeaths;
            set => Set(ref _newDeaths, value, nameof(NewDeaths));
        }

        private int _totalDeaths;
        public int TotalDeaths
        {
            get => _totalDeaths;
            set => Set(ref _totalDeaths, value, nameof(TotalDeaths));
        }

        private int _newRecovered;
        public int NewRecovered
        {
            get => _newRecovered;
            set => Set(ref _newRecovered, value, nameof(NewRecovered));
        }

        private int _totalRecovered;
        public int TotalRecovered
        {
            get => _totalRecovered;
            set => Set(ref _totalRecovered, value, nameof(TotalRecovered));
        }
    }
}
