using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Struct;
using EleWise.ELMA.Model.Views.Toolbar;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class TransformationViewItem : Transformation<ViewItem, TransformationViewItem, Guid>
{
	internal static TransformationViewItem DgJxLno1ub0GbqrS3sIn;

	protected internal override IList<ViewItem> GetSubItems(ViewItem item)
	{
		if (!(item is RootViewItem rootViewItem))
		{
			return new ViewItem[0];
		}
		return rootViewItem.Items;
	}

	protected internal override bool EqualsItems(ViewItem item, Guid? uid)
	{
		if (item != null || uid.HasValue)
		{
			if (item != null && uid.HasValue)
			{
				return item.IsUid(uid.Value);
			}
			return false;
		}
		return true;
	}

	protected internal override Guid GetUid(ViewItem item)
	{
		return item.Uid;
	}

	protected internal override bool IsHide(ViewItem item)
	{
		return qLw7R9o1SopCRY34H1c8(item);
	}

	protected internal override void SetHide(ViewItem parentItem, ViewItem item, bool hide = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				u034pjo1iq9E61na5FtA(item, hide);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected internal override ViewItem CreateCopy(ViewItem item)
	{
		return (ViewItem)ue42VFo1R1ReB3Fuj4tV(item, true);
	}

	protected internal override ViewItem Clone(ViewItem item)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (item != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return item.Clone();
			}
		}
	}

	public new static FormViewItemTransformation CreateTransformation(ViewItem item, ViewItem originalItem)
	{
		return (FormViewItemTransformation)Transformation<ViewItem, TransformationViewItem, Guid, Guid?>.Instance.TransformationCreate(item, originalItem);
	}

	protected override BaseTransformation<ViewItem, Guid> TransformationCreate(ViewItem item, ViewItem originalItem)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.originalItem = originalItem;
		CS_0024_003C_003E8__locals0.res = new FormViewItemTransformation();
		CS_0024_003C_003E8__locals0.res.Uid = CS_0024_003C_003E8__locals0.originalItem.Uid;
		FormViewItem formViewItem = item as FormViewItem;
		FormViewItem formViewItem2 = CS_0024_003C_003E8__locals0.originalItem as FormViewItem;
		if (formViewItem != null && formViewItem2 != null && (formViewItem.Toolbar != null || formViewItem2.Toolbar != null))
		{
			CS_0024_003C_003E8__locals0.res.ToolbarTransformation = Transformation<ToolbarItem, ToolbarItemTransformation, Guid, Guid?>.CreateTransformation(formViewItem.Toolbar ?? new EleWise.ELMA.Model.Views.Toolbar.Toolbar(), formViewItem2.Toolbar ?? new EleWise.ELMA.Model.Views.Toolbar.Toolbar());
		}
		CS_0024_003C_003E8__locals0.res.Items.AddRange(AddMoveTransformations(item, CS_0024_003C_003E8__locals0.originalItem).Cast<ViewItemTransformation>());
		CS_0024_003C_003E8__locals0.res.Items.AddRange(HideTransformations(item, CS_0024_003C_003E8__locals0.originalItem).Cast<ViewItemTransformation>());
		CS_0024_003C_003E8__locals0.res.Items.AddRange(ChangeTransformations(item, CS_0024_003C_003E8__locals0.originalItem, CS_0024_003C_003E8__locals0.originalItem.Root).Cast<ViewItemTransformationChange>().Where(delegate(ViewItemTransformationChange t)
		{
			//Discarded unreachable code: IL_00b2, IL_00c1
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass8_0.rEdmv3CCDEEHHioZbHjx(CS_0024_003C_003E8__locals0.res, (string)_003C_003Ec__DisplayClass8_0.Cl1EwbCCpmVRXsHltP4w(t));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					if (t.Uid == _003C_003Ec__DisplayClass8_0.dp0usvCCP43GbgT20idw(CS_0024_003C_003E8__locals0.originalItem))
					{
						num2 = 2;
						break;
					}
					goto IL_010a;
				default:
					_003C_003Ec__DisplayClass8_0.QlCxsgCCawolq2s9ylUA(CS_0024_003C_003E8__locals0.res, (string)_003C_003Ec__DisplayClass8_0.Cl1EwbCCpmVRXsHltP4w(t));
					num2 = 4;
					break;
				case 4:
					return false;
				case 6:
					if (t.PropertyName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FD3DED))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_010a;
				case 5:
					return false;
				case 2:
					{
						if (!_003C_003Ec__DisplayClass8_0.cXtFNtCC3AqrLWg8Zxdr(_003C_003Ec__DisplayClass8_0.KOKv7lCC1qkDo1CDcNtc(t), _003C_003Ec__DisplayClass8_0.IXoC43CCNjEPpuLkq1Px(-1867198571 ^ -1867203499)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num2 = 6;
							}
							break;
						}
						goto default;
					}
					IL_010a:
					return true;
				}
			}
		}));
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.res.NewFormName) && string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.res.NewFormDisplayName) && !CS_0024_003C_003E8__locals0.res.Items.Any() && CS_0024_003C_003E8__locals0.res.ToolbarTransformation == null)
		{
			return null;
		}
		return CS_0024_003C_003E8__locals0.res;
	}

	protected override IEnumerable<BaseTransformation<ViewItem, Guid>> ChangeTransformations(ViewItem viewItem, ViewItem originalItem, ViewItem originalItemRoot)
	{
		IEnumerable<BaseTransformation<ViewItem, Guid>> enumerable = base.ChangeTransformations(viewItem, originalItem, originalItemRoot);
		object obj = ViewItemTransformationChange.CheckDynamicProperties(viewItem, originalItem);
		if (obj != null)
		{
			enumerable = enumerable.Append(TransformationChange(viewItem.Uid, viewItem.GetType(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12467F76), obj));
		}
		return enumerable;
	}

	protected override BaseTransformation<ViewItem, Guid> TransformationAdd(Guid itemUid, ViewItem item, Guid? afterItem = null, Guid? beforeItem = null)
	{
		return new ViewItemTransformationAdd
		{
			Uid = itemUid,
			Item = CreateCopy(item),
			AfterItem = afterItem,
			BeforeItem = beforeItem
		};
	}

	protected override BaseTransformation<ViewItem, Guid> TransformationChange(Guid itemUid, Type type, string propertyName, object value, bool localizable = false)
	{
		return new ViewItemTransformationChange
		{
			Uid = itemUid,
			PropertyName = propertyName,
			Localizable = localizable,
			Value = value,
			TypeName = type.AssemblyQualifiedName
		};
	}

	protected override BaseTransformation<ViewItem, Guid> TransformationHide(Guid itemUid)
	{
		return new ViewItemTransformationHide
		{
			Uid = itemUid
		};
	}

	protected override BaseTransformation<ViewItem, Guid> TransformationMove(Guid itemUid, Guid moveItemUid, Guid? afterItem = null, Guid? beforeItem = null)
	{
		return new ViewItemTransformationMove
		{
			Uid = itemUid,
			MoveItemUid = moveItemUid,
			AfterItem = afterItem,
			BeforeItem = beforeItem
		};
	}

	public TransformationViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hRaQ7Yo1qQfbuJvoKmWh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qLw7R9o1SopCRY34H1c8(object P_0)
	{
		return ((ViewItem)P_0).Hide;
	}

	internal static void u034pjo1iq9E61na5FtA(object P_0, bool value)
	{
		((ViewItem)P_0).Hide = value;
	}

	internal static bool ri1pIKo1ISe1BeEOMM7e()
	{
		return DgJxLno1ub0GbqrS3sIn == null;
	}

	internal static TransformationViewItem QuKBqpo1VnqKQiDidXmj()
	{
		return DgJxLno1ub0GbqrS3sIn;
	}

	internal static object ue42VFo1R1ReB3Fuj4tV(object P_0, bool copyUid)
	{
		return ((ViewItem)P_0).CreateCopy(copyUid);
	}

	internal static void hRaQ7Yo1qQfbuJvoKmWh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
