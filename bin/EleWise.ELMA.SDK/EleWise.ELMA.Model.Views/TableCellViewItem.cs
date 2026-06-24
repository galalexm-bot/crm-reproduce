using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TableCellViewItem), "DisplayName")]
public class TableCellViewItem : RootViewItem, ILayoutItemViewItem, IContainerViewItem
{
	private static TableCellViewItem Wt3K9roeeGf4u61O25kG;

	[DefaultValue(1)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public int RowSpan
	{
		[CompilerGenerated]
		get
		{
			return _003CRowSpan_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CRowSpan_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(1)]
	public int ColSpan
	{
		[CompilerGenerated]
		get
		{
			return _003CColSpan_003Ek__BackingField;
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
					_003CColSpan_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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

	public TableCellViewItem()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		hpqiUgoeNdHL0hGrpV9u();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				ColSpan = 1;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 1;
				}
				break;
			case 2:
				RowSpan = 1;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return parentViewItem is TableRowViewItem;
			case 1:
				return true;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	internal static void hpqiUgoeNdHL0hGrpV9u()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool J8kR54oePqXoBT4OBbEv()
	{
		return Wt3K9roeeGf4u61O25kG == null;
	}

	internal static TableCellViewItem dBaTuboe1w97F455XETQ()
	{
		return Wt3K9roeeGf4u61O25kG;
	}
}
