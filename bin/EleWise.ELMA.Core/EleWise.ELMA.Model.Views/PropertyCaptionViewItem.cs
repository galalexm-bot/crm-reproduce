using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal class PropertyCaptionViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<PropertyCaptionViewItem>
	{
		public override Guid Uid => new Guid("{DBDC9A6D-E62E-4AFB-831D-760E270E3BEB}");

		public override string Name => SR.T("Наименование свойства");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	public override bool ReadOnlyEnabled => false;

	public override bool FocusableEnabled => false;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}
