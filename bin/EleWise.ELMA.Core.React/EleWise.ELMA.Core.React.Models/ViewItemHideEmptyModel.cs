using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

internal sealed class ViewItemHideEmptyModel : HideEmptyModel
{
	private readonly IHideable hideable;

	private readonly IViewModel renderOwner;

	public ViewItemHideEmptyModel(IViewModel renderOwner, IHideable hideable, IHideEmptyContainerModel hideEmptyModel)
		: base(hideEmptyModel)
	{
		this.hideable = hideable;
		this.renderOwner = renderOwner;
	}

	protected override bool GetHiddenValue()
	{
		GlobalScopeHelper.Push(renderOwner);
		try
		{
			return hideable.IsHidden();
		}
		finally
		{
			GlobalScopeHelper.Pop(renderOwner);
		}
	}
}
