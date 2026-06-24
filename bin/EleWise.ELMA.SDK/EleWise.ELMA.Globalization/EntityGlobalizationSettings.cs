using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class EntityGlobalizationSettings
{
	private static EntityGlobalizationSettings VNnUn0Gor6PNda5ZhUMh;

	public Guid[] EntityUids
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityUids_003Ek__BackingField;
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
					_003CEntityUids_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid[] EnumUids
	{
		[CompilerGenerated]
		get
		{
			return _003CEnumUids_003Ek__BackingField;
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
					_003CEnumUids_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
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

	public EntityGlobalizationSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				EnumUids = new Guid[0];
				num = 2;
				break;
			case 2:
				return;
			case 1:
				EntityUids = new Guid[0];
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool reQYOoGogludXYAqrDOZ()
	{
		return VNnUn0Gor6PNda5ZhUMh == null;
	}

	internal static EntityGlobalizationSettings c4xYyIGo5QuZL4j3X8ox()
	{
		return VNnUn0Gor6PNda5ZhUMh;
	}
}
