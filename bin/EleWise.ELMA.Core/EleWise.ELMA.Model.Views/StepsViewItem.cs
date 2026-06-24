using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class StepsViewItem : RootViewItem, IViewItemWithActiveKey, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[Component(Order = 600)]
	private class ToolboxItem : CommonViewItemToolboxItem<StepsViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{3A73B8B7-1D8D-498F-BEE3-40A50526C117}");

		public override string Name => SR.T("Шаги");

		public override string Icon => "steps";

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private Guid _003CActiveKeyProperty_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private string _003CAddFunction_003Ek__BackingField;

	private DirectionType _003CDirection_003Ek__BackingField;

	private ActionWithParam<string> _003COnChange_003Ek__BackingField;

	public Guid ActiveKeyProperty
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CActiveKeyProperty_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CActiveKeyProperty_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<Guid> PropertyParents
	{
		get
		{
			return _003CPropertyParents_003Ek__BackingField;
		}
		set
		{
			_003CPropertyParents_003Ek__BackingField = value;
		}
	}

	public string AddFunction
	{
		get
		{
			return _003CAddFunction_003Ek__BackingField;
		}
		set
		{
			_003CAddFunction_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public DirectionType Direction
	{
		get
		{
			return _003CDirection_003Ek__BackingField;
		}
		set
		{
			_003CDirection_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<string> OnChange
	{
		get
		{
			return _003COnChange_003Ek__BackingField;
		}
		set
		{
			_003COnChange_003Ek__BackingField = value;
		}
	}

	public StepsViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is StepItemViewItem;
	}
}
