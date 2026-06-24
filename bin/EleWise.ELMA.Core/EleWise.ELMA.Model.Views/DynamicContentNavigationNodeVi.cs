using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal sealed class DynamicContentNavigationNodeViewItem : ContentNavigationNodeViewItem, IDynamicViewItem, IViewItemWithPropertyParents, IViewItem, IReactive
{
	[Component]
	private class ToolboxItem : CommonViewItemToolboxItem<DynamicContentNavigationNodeViewItem>
	{
		public override Guid Uid => new Guid("{86BE9660-1673-4154-8600-34B90AACC838}");

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
			if (uid == NodeCaptionSlotUid)
			{
				result = SR.T("Заголовок динамической вкладки");
			}
			if (uid == NodeContentSlotUid)
			{
				result = SR.T("Контент динамической вкладки");
			}
			return result;
		}
	}

	public static Guid NodeCaptionSlotUid = new Guid("3E2871F2-64A1-45D8-B9DF-9661D4FEB3CF");

	public static Guid NodeContentSlotUid = new Guid("08EA4445-E9A8-4C9A-8090-F975777E56E5");

	private Guid _003CPropertyUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<Guid> _003CPropertyParents_003Ek__BackingField;

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

	public DynamicContentNavigationNodeViewItem()
	{
		PropertyParents = new ReactiveCollection<Guid>();
	}
}
