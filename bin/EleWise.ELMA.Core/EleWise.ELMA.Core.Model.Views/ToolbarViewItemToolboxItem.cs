using System;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

public abstract class ToolbarViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
{
	public override Guid GroupUid => ToolbarViewItemToolboxGroup.UID;

	public ToolbarViewItemToolboxItem(IViewItemInfoService viewItemInfoService)
		: base(viewItemInfoService)
	{
	}
}
