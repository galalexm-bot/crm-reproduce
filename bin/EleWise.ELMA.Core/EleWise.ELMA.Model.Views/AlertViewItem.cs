using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class AlertViewItem : RootViewItem
{
	[Component(Order = 360)]
	private class ToolboxItem : CommonViewItemToolboxItem<AlertViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{0A3B19C0-F68B-45D1-A74B-67D1D79461D9}");

		public override string Name => SR.T("Информационный блок");

		public override string Icon => "info-circle";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private AlertType _003CAlertType_003Ek__BackingField;

	private bool _003CClosable_003Ek__BackingField;

	private DefaultAction _003COnClose_003Ek__BackingField;

	[DynamicProperty(false)]
	public AlertType AlertType
	{
		get
		{
			return _003CAlertType_003Ek__BackingField;
		}
		set
		{
			_003CAlertType_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Closable
	{
		get
		{
			return _003CClosable_003Ek__BackingField;
		}
		set
		{
			_003CClosable_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public DefaultAction OnClose
	{
		get
		{
			return _003COnClose_003Ek__BackingField;
		}
		set
		{
			_003COnClose_003Ek__BackingField = value;
		}
	}

	public AlertViewItem()
	{
		AlertType = AlertType.Information;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
