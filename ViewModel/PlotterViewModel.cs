using Plotter.Core;
using Plotter.Services;

namespace Plotter.ViewModel;

public class PlotterViewModel : Core.ViewModel
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

    public RelayCommand NavigateToLoginViewCommand { get; set; }

    public PlotterViewModel(INavigationService navigation) 
    {
        Navigation = navigation;
    }
}
