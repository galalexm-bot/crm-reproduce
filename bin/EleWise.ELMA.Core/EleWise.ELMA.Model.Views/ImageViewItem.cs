using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

public class ImageViewItem : ViewItem, ITooltipViewItem, IViewItem, IReactive
{
	[Component(Order = 450)]
	private class ToolboxItem : CommonViewItemToolboxItem<ImageViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{B3D81227-4B5D-49F7-ABEB-81BD185FD35D}");

		public override string Name => SR.T("Изображение");

		public override string Icon => "image";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private string _003CSource_003Ek__BackingField;

	private ViewItemImageSize _003CSize_003Ek__BackingField;

	private ViewItemImageShape _003CShape_003Ek__BackingField;

	private string _003CTooltip_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Source
	{
		get
		{
			return _003CSource_003Ek__BackingField;
		}
		set
		{
			_003CSource_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemImageSize Size
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

	[DynamicProperty(false)]
	public ViewItemImageShape Shape
	{
		get
		{
			return _003CShape_003Ek__BackingField;
		}
		set
		{
			_003CShape_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string Tooltip
	{
		get
		{
			return _003CTooltip_003Ek__BackingField;
		}
		set
		{
			_003CTooltip_003Ek__BackingField = value;
		}
	}
}
