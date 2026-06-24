using System;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

public abstract class AdditionalViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
{
	public override Guid GroupUid => AdditionalViewItemToolboxGroup.UID;

	public AdditionalViewItemToolboxItem(IViewItemInfoService viewItemInfoService)
		: base(viewItemInfoService)
	{
	}
}
