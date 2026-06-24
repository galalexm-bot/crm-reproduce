using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper;

internal sealed class PropertyMap
{
	private static PropertyMap S6bnmahxBEy5dsQDyU9K;

	internal bool Ignored
	{
		[CompilerGenerated]
		get
		{
			return _003CIgnored_003Ek__BackingField;
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
					_003CIgnored_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
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

	internal PropertyInfo Property { get; }

	internal PropertyMap(PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iUvkPRhxbYLCmZ3JPDW7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				Property = propertyInfo;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num = 0;
				}
				break;
			default:
				QG9IHahxhPGXbA20GN6W(propertyInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7DCA18));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return (string)CDoRvDhxGNNemUb7kyFR(Property);
	}

	internal static void iUvkPRhxbYLCmZ3JPDW7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void QG9IHahxhPGXbA20GN6W(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool eM75OjhxWs2SLKVmOq1C()
	{
		return S6bnmahxBEy5dsQDyU9K == null;
	}

	internal static PropertyMap Aattl8hxocDc3KPhMSq9()
	{
		return S6bnmahxBEy5dsQDyU9K;
	}

	internal static object CDoRvDhxGNNemUb7kyFR(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}
}
