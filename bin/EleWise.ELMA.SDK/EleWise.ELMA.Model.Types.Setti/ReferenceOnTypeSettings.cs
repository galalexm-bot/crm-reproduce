using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Serializable]
public class ReferenceOnTypeSettings : SimpleTypeSettings
{
	private static ReferenceOnTypeSettings Q1lRI6oUsbP4tIWDkOma;

	[DefaultValue(false)]
	public bool ShowDirtyTypes
	{
		[CompilerGenerated]
		get
		{
			return _003CShowDirtyTypes_003Ek__BackingField;
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
					_003CShowDirtyTypes_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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

	[DefaultValue(false)]
	public bool ShowInCatalogListTypes
	{
		[CompilerGenerated]
		get
		{
			return _003CShowInCatalogListTypes_003Ek__BackingField;
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
					_003CShowInCatalogListTypes_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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

	public ReferenceOnTypeSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Hpk02YosFaY6WVaXB4Cf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ReferenceOnTypeSettings(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Hpk02YosFaY6WVaXB4Cf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool XAmfEKoUcLhyPtbaJg0G()
	{
		return Q1lRI6oUsbP4tIWDkOma == null;
	}

	internal static ReferenceOnTypeSettings sUNsjGoUzlx7lJubH3uP()
	{
		return Q1lRI6oUsbP4tIWDkOma;
	}
}
