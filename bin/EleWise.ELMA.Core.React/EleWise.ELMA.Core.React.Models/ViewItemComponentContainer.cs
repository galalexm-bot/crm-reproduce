using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Extensions;

namespace EleWise.ELMA.Core.React.Models;

public class ViewItemComponentContainer : ComponentContainer
{
	public override bool ReadOnly
	{
		get
		{
			if (!(ViewModel is IViewItemViewModel viewItemViewModel))
			{
				return base.ReadOnly;
			}
			GlobalScopeHelper.Push(viewItemViewModel.RenderOwner);
			try
			{
				bool? flag = (viewItemViewModel.ViewItem as ViewItem)?.IsReadOnly();
				return flag.get_HasValue() ? flag.get_Value() : base.ReadOnly;
			}
			finally
			{
				GlobalScopeHelper.Pop(viewItemViewModel.RenderOwner);
			}
		}
	}

	public override string Name
	{
		get
		{
			if (ViewModel is IViewItemViewModel viewItemViewModel)
			{
				return viewItemViewModel.ViewItem.Name;
			}
			return base.Name;
		}
	}

	public ViewItemComponentContainer(IViewModel viewModel)
		: base(viewModel)
	{
	}
}
