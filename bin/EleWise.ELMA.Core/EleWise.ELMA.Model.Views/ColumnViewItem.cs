using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class ColumnViewItem : RootViewItem, IContainerViewItem
{
	[Component(Order = 100)]
	private class ToolboxItem : CommonViewItemToolboxItem<ColumnViewItem>
	{
		public override Guid Uid => new Guid("{EF771ED8-38C0-4926-9151-A8DA9C2933E5}");

		public override string Name => SR.T("Колонка");

		public override string Icon => "col";

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	private ViewItemColumnSize _003CSize_003Ek__BackingField;

	[DynamicProperty(false)]
	public ViewItemColumnSize Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		set
		{
			_003CSize_003Ek__BackingField = value;
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
