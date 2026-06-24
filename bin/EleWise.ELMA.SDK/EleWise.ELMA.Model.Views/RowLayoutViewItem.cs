using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class RowLayoutViewItem : RootViewItem
{
	internal static RowLayoutViewItem BviZemoKx8yv0V9TUNXd;

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(HorizontalAlign.Left)]
	public HorizontalAlign Align
	{
		[CompilerGenerated]
		get
		{
			return _003CAlign_003Ek__BackingField;
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
					_003CAlign_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(VerticalAlign.Top)]
	public VerticalAlign VerticalAlign
	{
		[CompilerGenerated]
		get
		{
			return _003CVerticalAlign_003Ek__BackingField;
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
					_003CVerticalAlign_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RowLayoutViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CrlxF8oKyjwqOW5nncNb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				VerticalAlign = VerticalAlign.Top;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				Align = HorizontalAlign.Left;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return siHlhUoKMXEtxhx7srWs(parentViewItem, this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	internal static void CrlxF8oKyjwqOW5nncNb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool VBAf81oK0jRmmVYMrpQM()
	{
		return BviZemoKx8yv0V9TUNXd == null;
	}

	internal static RowLayoutViewItem fONvIMoKmNZdrq5MocwM()
	{
		return BviZemoKx8yv0V9TUNXd;
	}

	internal static bool siHlhUoKMXEtxhx7srWs(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}
}
