using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.ViewModel;

public interface IViewItemInputModel : IInputModel
{
	IViewItem ViewItem { get; set; }
}
public interface IViewItemInputModel<TViewItem> : IViewItemInputModel<TViewItem, IInputs>, IInputModel<IInputs>, IInputModel, IViewItemInputModel
{
}
public interface IViewItemInputModel<TViewItem, TInputs> : IInputModel<TInputs>, IInputModel, IViewItemInputModel where TInputs : IInputs
{
	new TViewItem ViewItem { get; set; }
}
