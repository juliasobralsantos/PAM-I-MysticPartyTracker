using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class ResultsViewModel : ObservableObject
    {
        private readonly RestService _restService;

        public ResultsViewModel()
        {
            _restService = new RestService();
            GerarSpellsCommand = new Command(async () => await
            GetResultsAsync());
        }

        [ObservableProperty]
        private ObservableCollection<Result> _results = new ObservableCollection<Result>();

        public ICommand GerarSpellsCommand { get; }

        public async Task GetResultsAsync()
        {
            _results = await _restService.GetResultsAsync();
        }
    }
}
