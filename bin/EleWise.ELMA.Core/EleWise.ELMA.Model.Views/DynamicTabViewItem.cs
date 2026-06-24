using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class DynamicTabViewItem : TabViewItem, IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<DynamicTabViewItem>
	{
		public override Guid Uid => new Guid("{F9A83BFA-C76A-4F64-88F4-7347717E46C6}");

		public override string Name => SR.T("Динамическая вкладка");

		public override bool Visible => false;

		public ToolboxItem(IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
		}

		public override string GetSlotName(Guid uid)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			string result = base.GetSlotName(uid);
			if (uid == TabCaptionSlotUid)
			{
				result = SR.T("Заголовок динамической вкладки");
			}
			if (uid == TabContentSlotUid)
			{
				result = SR.T("Контент динамической вкладки");
			}
			return result;
		}
	}

	public static Guid TabCaptionSlotUid = new Guid("8FFC2E63-C532-4948-A323-35F0E39E7218");

	public static Guid TabContentSlotUid = new Guid("44CEE64A-AF71-4BF6-8B9E-2DE3DD98C6BB");

	private Guid _003CPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

	private DefaultAction _003COnRemoveTab_003Ek__BackingField;

	public Guid PropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CPropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CPropertyUid_003Ek__BackingField = value;
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

	[JsonIgnore]
	[DynamicProperty(true)]
	public DefaultAction OnRemoveTab
	{
		get
		{
			return _003COnRemoveTab_003Ek__BackingField;
		}
		set
		{
			_003COnRemoveTab_003Ek__BackingField = value;
		}
	}

	public DynamicTabViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}
}
