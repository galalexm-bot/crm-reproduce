using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal sealed class ColumnsLayoutViewItem : RootViewItem
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<ColumnsLayoutViewItem>
	{
		public override Guid Uid => new Guid("{B2F7FA9A-FAA9-4B98-BCD0-676DCD7E8568}");

		public override string Name => SR.T("Шаблон колонок");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is ColumnViewItem;
	}
}
