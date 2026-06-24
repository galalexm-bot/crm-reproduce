using System;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

public abstract class CommonViewItemToolboxItem : ViewItemToolboxItem
{
	public override Guid GroupUid => CommonViewItemToolboxGroup.UID;
}
public abstract class CommonViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
{
	public override Guid GroupUid => CommonViewItemToolboxGroup.UID;

	public CommonViewItemToolboxItem(IViewItemInfoService viewItemInfoService)
		: base(viewItemInfoService)
	{
	}
}
