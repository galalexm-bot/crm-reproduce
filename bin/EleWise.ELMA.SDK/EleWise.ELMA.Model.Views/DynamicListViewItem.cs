using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_DynamicListViewItem), "DisplayName")]
public class DynamicListViewItem : RootViewItem, IDynamicViewItem, IViewItemWithPropertyParents
{
	private static DynamicListViewItem PaJLKooq09oDmtxrdJdH;

	public Guid PropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

	[DefaultValue(null)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public int? HeightPercentage { get; set; }

	public DynamicListViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			PropertyParents = new List<Guid>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is DynamicSlotViewItem;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return hHvy5qoqM3rHq2V19yg2(parentViewItem, this);
			case 1:
				return true;
			case 2:
				if (parentViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyParents()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (PropertyParents != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return r48nVOoqJa6VNU6kHgOR(PropertyParents) > 0;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyUid()
	{
		return yDTGvVoq9xGXb1eHsTiy(PropertyUid, Guid.Empty);
	}

	internal static bool QClrePoqm1rGe0RUHkyo()
	{
		return PaJLKooq09oDmtxrdJdH == null;
	}

	internal static DynamicListViewItem p3gEGJoqyiVF8yAQZCmI()
	{
		return PaJLKooq09oDmtxrdJdH;
	}

	internal static bool hHvy5qoqM3rHq2V19yg2(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static int r48nVOoqJa6VNU6kHgOR(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static bool yDTGvVoq9xGXb1eHsTiy(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
