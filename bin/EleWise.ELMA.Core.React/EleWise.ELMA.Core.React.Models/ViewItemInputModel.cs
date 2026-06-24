using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Models;

internal sealed class ViewItemInputModel<TViewItem, TInputs> : InputModel<TInputs>, IReactViewItemInputModel<TViewItem, TInputs>, IViewItemInputModel<TViewItem, TInputs>, IInputModel<TInputs>, IInputModel, IViewItemInputModel, IReactInputModel<TInputs>, IReactInputModel, IDataExtension, IReactViewItemInputModel where TViewItem : IViewItem where TInputs : IInputs
{
	private TViewItem _003CViewItem_003Ek__BackingField;

	public TViewItem ViewItem
	{
		get
		{
			return _003CViewItem_003Ek__BackingField;
		}
		set
		{
			_003CViewItem_003Ek__BackingField = value;
		}
	}

	IViewItem IViewItemInputModel.ViewItem
	{
		get
		{
			return ViewItem;
		}
		set
		{
			ViewItem = (TViewItem)value;
		}
	}
}
