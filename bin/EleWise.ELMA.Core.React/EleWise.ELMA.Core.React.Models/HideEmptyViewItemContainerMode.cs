using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Models;

public class HideEmptyViewItemContainerModel : IHideEmptyViewItemContainerModel
{
	private readonly ViewModel model;

	private readonly Func<IViewItem> getViewItemFunc;

	private IDictionary<IViewItem, IHideEmptyContainerModel> hideEmptyModels;

	public HideEmptyViewItemContainerModel(ViewModel viewModel, Func<IViewItem> getViewItemFunc)
	{
		hideEmptyModels = (IDictionary<IViewItem, IHideEmptyContainerModel>)(object)new Dictionary<IViewItem, IHideEmptyContainerModel>();
		model = viewModel;
		this.getViewItemFunc = getViewItemFunc;
	}

	public void AddHideEmpty(IViewItem viewItem, IHideEmptyContainerModel hideEmptyModel)
	{
		if (hideEmptyModels != null)
		{
			hideEmptyModels.Add(viewItem, hideEmptyModel);
		}
	}

	public void RemoveHideEmpty(IViewItem viewItem)
	{
		if (hideEmptyModels != null)
		{
			hideEmptyModels.Remove(viewItem);
		}
	}

	public IHideEmptyContainerModel FindOwner(IViewItem viewItem)
	{
		if (viewItem is ViewItem viewItem2 && viewItem2.Parent != null)
		{
			IHideEmptyContainerModel result = default(IHideEmptyContainerModel);
			if (hideEmptyModels != null && hideEmptyModels.TryGetValue((IViewItem)viewItem2.Parent, ref result))
			{
				return result;
			}
		}
		else if (model.RenderOwner is IHideEmptyViewItemContainer hideEmptyViewItemContainer)
		{
			IViewItem viewItem3 = getViewItemFunc.Invoke();
			return hideEmptyViewItemContainer.HideEmptyViewItemContainer.FindHideEmpty(viewItem3);
		}
		return null;
	}

	public void Destroy()
	{
		hideEmptyModels = null;
	}

	public bool IsHideEmpty(IViewItem viewItem)
	{
		if (viewItem is IHideEmptyViewItem hideEmptyViewItem)
		{
			if (hideEmptyViewItem.HideEmpty == HideEmptyEnum.HideEmpty)
			{
				return true;
			}
			if (hideEmptyViewItem.HideEmpty == HideEmptyEnum.Inherit && viewItem is ViewItem viewItem2)
			{
				if (viewItem2.Parent != null)
				{
					return IsHideEmpty(viewItem2.Parent);
				}
				if (model.RenderOwner is IHideEmptyViewItemContainer hideEmptyViewItemContainer)
				{
					IHideEmptyViewItemContainerModel hideEmptyViewItemContainer2 = hideEmptyViewItemContainer.HideEmptyViewItemContainer;
					IViewItem viewItem3 = getViewItemFunc.Invoke();
					if (viewItem3 != null)
					{
						return hideEmptyViewItemContainer2.IsHideEmpty(viewItem3);
					}
				}
			}
		}
		return false;
	}

	public IHideEmptyContainerModel FindHideEmpty(IViewItem viewItem)
	{
		IHideEmptyContainerModel result = default(IHideEmptyContainerModel);
		if (hideEmptyModels.TryGetValue(viewItem, ref result))
		{
			return result;
		}
		return FindOwner(viewItem);
	}
}
