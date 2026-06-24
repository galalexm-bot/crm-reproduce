using System;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DisplayName(typeof(__Resources_PropertyDescriptionViewItem), "DisplayName")]
public class PropertyDescriptionViewItem : PropertyViewItem
{
	internal static PropertyDescriptionViewItem QaVmuooOygDNyB5o4STR;

	public override bool IsMainPropertyViewItem()
	{
		return false;
	}

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return parentViewItem.IsChildValid(this);
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public PropertyDescriptionViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tSIU4roO9LkamwBElrTh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool PfkAGOoOMAKrD1g5bXwE()
	{
		return QaVmuooOygDNyB5o4STR == null;
	}

	internal static PropertyDescriptionViewItem Gr65BnoOJ0s10LdlFmeJ()
	{
		return QaVmuooOygDNyB5o4STR;
	}

	internal static void tSIU4roO9LkamwBElrTh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
