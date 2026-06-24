using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

internal class PropertyCalculateScriptValueContainer : IPropertyDefaultValueContainer
{
	private IPropertyValueContainer propertyValueContainer;

	internal static PropertyCalculateScriptValueContainer KPD3iKhob0rnGt8is4Wc;

	internal void SetScriptType(Type scriptType)
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
				propertyValueContainer = (IPropertyValueContainer)Activator.CreateInstance(scriptType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		return propertyValueContainer;
	}

	public PropertyCalculateScriptValueContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LGMiGuhohdqyH6xVC6v4()
	{
		return KPD3iKhob0rnGt8is4Wc == null;
	}

	internal static PropertyCalculateScriptValueContainer M3WEXEhoG4jMn3782AyR()
	{
		return KPD3iKhob0rnGt8is4Wc;
	}
}
