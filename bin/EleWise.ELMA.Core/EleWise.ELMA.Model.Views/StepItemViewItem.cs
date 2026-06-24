using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

internal sealed class StepItemViewItem : ViewItem
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<StepItemViewItem>
	{
		public override Guid Uid => new Guid("{09BBB06F-5606-4D5D-A3B2-907AD54A4264}");

		public override string Name => SR.T("Элемент шага");

		public override bool Visible => false;

		public ToolboxItem(ViewItemInfoService viewItemInfoService)
			: base((IViewItemInfoService)viewItemInfoService)
		{
		}
	}

	private string _003CTitle_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private short _003CStepNumber_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			_003CTitle_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		set
		{
			_003CDescription_003Ek__BackingField = value;
		}
	}

	public short StepNumber
	{
		get
		{
			return _003CStepNumber_003Ek__BackingField;
		}
		set
		{
			_003CStepNumber_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem != null)
		{
			return parentViewItem is StepsViewItem;
		}
		return true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
