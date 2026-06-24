using System;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

internal abstract class ChartViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
{
	public override Guid GroupUid => ChartViewItemToolboxGroup.UID;

	public ChartViewItemToolboxItem(IViewItemInfoService viewItemInfoService)
		: base(viewItemInfoService)
	{
	}
}
