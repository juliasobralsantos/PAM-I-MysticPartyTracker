using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.Views;

public partial class ResultView : ContentPage
{
	public ResultView()
	{
		BindingContext = new ResultsViewModel();
		InitializeComponent();
	}
}