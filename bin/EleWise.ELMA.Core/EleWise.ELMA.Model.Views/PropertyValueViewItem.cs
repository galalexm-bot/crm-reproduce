using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal class PropertyValueViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<PropertyValueViewItem>
	{
		public override Guid Uid => new Guid("{241FC673-B59C-458A-A554-BACBF3F16A38}");

		public override string Name => SR.T("Значение свойства");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}
}
