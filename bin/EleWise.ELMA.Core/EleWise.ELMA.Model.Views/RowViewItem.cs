using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class RowViewItem : RootViewItem, IContainerViewItem
{
	[Component(Order = 150)]
	private class ToolboxItem : CommonViewItemToolboxItem<RowViewItem>
	{
		public override Guid Uid => new Guid("{913E2045-DE05-4571-90F2-E99870DF4404}");

		public override string Name => SR.T("Строка свойства");

		public override string Icon => "row";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	[NotResettable]
	[JsonIgnore]
	public CellViewItem LeftCell => base.Items[0] as CellViewItem;

	[JsonIgnore]
	[NotResettable]
	public CellViewItem RightCell => base.Items[1] as CellViewItem;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is CellViewItem;
	}
}
