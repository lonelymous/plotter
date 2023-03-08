using Plotter.Core;
using Plotter.Services;

namespace Plotter.ViewModel;

public class MainViewModel : Core.ViewModel
{

    private INavigationService _navigation;
    public INavigationService Navigation 
    { 
        get => _navigation;
        set 
        {
            _navigation = value;
            OnPropertyChanged();
        }
    }

    public RelayCommand NavigateToPlotterViewCommand { get; set; }
    public MainViewModel(INavigationService navService) 
    {
        Navigation = navService;
        NavigateToPlotterViewCommand = new RelayCommand(o => true, o => { Navigation.NavigateTo<PlotterViewModel>(); });
    }
}
