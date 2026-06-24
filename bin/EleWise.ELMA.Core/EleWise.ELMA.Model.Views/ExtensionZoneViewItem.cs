using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal sealed class ExtensionZoneViewItem : ViewItem
{
	private class ToolboxItem : AdditionalViewItemToolboxItem<ExtensionZoneViewItem>
	{
		public override string Name => SR.T("Зона для расширений");

		public override Guid Uid => new Guid("{09CA55AD-B25A-479F-896A-F8AA036FA78E}");

		public override bool Visible => false;

		public ToolboxItem(IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
		}
	}

	private string _003CZoneId_003Ek__BackingField;

	private bool _003CUseOriginalModel_003Ek__BackingField;

	private bool _003CSupportInColumnRender_003Ek__BackingField;

	public string ZoneId
	{
		get
		{
			return _003CZoneId_003Ek__BackingField;
		}
		set
		{
			_003CZoneId_003Ek__BackingField = value;
		}
	}

	public bool UseOriginalModel
	{
		get
		{
			return _003CUseOriginalModel_003Ek__BackingField;
		}
		set
		{
			_003CUseOriginalModel_003Ek__BackingField = value;
		}
	}

	public bool SupportInColumnRender
	{
		get
		{
			return _003CSupportInColumnRender_003Ek__BackingField;
		}
		set
		{
			_003CSupportInColumnRender_003Ek__BackingField = value;
		}
	}

	public ExtensionZoneViewItem()
	{
		UseOriginalModel = true;
	}
}
