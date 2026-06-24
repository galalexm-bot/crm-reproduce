using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Serialization;

[DataContract]
public sealed class EntityTypeSerializationSettings
{
	internal static EntityTypeSerializationSettings w5ihAxB9IWyeycl3kXnm;

	[DataMember]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
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

	[DataMember]
	public List<string> Properties { get; set; }

	public EntityTypeSerializationSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LX9QemB9ii3mJthe3MMe();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Properties = new List<string>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void LX9QemB9ii3mJthe3MMe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool k90IdIB9VENPOVjQQyYt()
	{
		return w5ihAxB9IWyeycl3kXnm == null;
	}

	internal static EntityTypeSerializationSettings XOZfvnB9SkmIDxefllGk()
	{
		return w5ihAxB9IWyeycl3kXnm;
	}
}
