using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.ViewModel;

public interface IViewItemViewModel<TViewItem, TController> : IViewItemViewModel<TViewItem>, IViewItemViewModel, IViewModel
{
	new TController Controller { get; }
}
public interface IViewItemViewModel<TViewItem> : IViewItemViewModel, IViewModel
{
	new TViewItem ViewItem { get; set; }
}
public interface IViewItemViewModel : IViewModel
{
	IViewItem ViewItem { get; }
}
