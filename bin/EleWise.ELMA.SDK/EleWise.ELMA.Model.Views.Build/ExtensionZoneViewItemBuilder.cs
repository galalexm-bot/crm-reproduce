using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class ExtensionZoneViewItemBuilder<TM> : ViewItemBuilder<TM, ExtensionZoneViewItem, ExtensionZoneViewItemBuilder<TM>> where TM : IEntity
{
	internal static object fsJSTEoD2D9bNVREbEZd;

	public ExtensionZoneViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal ExtensionZoneViewItemBuilder(string zoneId, ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				base.ViewItem.ZoneId = zoneId;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ExtensionZoneViewItemBuilder<TM> UseOriginalModel(bool useOriginalModel = true)
	{
		base.ViewItem.UseOriginalModel = useOriginalModel;
		return this;
	}

	internal static bool ioqKG4oDeBbrXhpAilv5()
	{
		return fsJSTEoD2D9bNVREbEZd == null;
	}

	internal static object eLLFjPoDPc7cWZNhbRZr()
	{
		return fsJSTEoD2D9bNVREbEZd;
	}
}
