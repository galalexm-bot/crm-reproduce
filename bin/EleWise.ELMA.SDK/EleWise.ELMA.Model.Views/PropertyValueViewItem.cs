using System;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DisplayName(typeof(__Resources_PropertyValueViewItem), "DisplayName")]
public class PropertyValueViewItem : PropertyViewItem
{
	private static PropertyValueViewItem Ag5YK1oefq2oxra6V9Ld;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parentViewItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return kpIaPUoevsvIdew3ZdRR(parentViewItem, this);
			}
		}
	}

	public PropertyValueViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Soub9Zoe8mcv4VEua1u8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kpIaPUoevsvIdew3ZdRR(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static bool HgI1ILoeQ4m27Rtikq7G()
	{
		return Ag5YK1oefq2oxra6V9Ld == null;
	}

	internal static PropertyValueViewItem UDaMAVoeC19WgFjLlBda()
	{
		return Ag5YK1oefq2oxra6V9Ld;
	}

	internal static void Soub9Zoe8mcv4VEua1u8()
	{
		SingletonReader.PushGlobal();
	}
}
