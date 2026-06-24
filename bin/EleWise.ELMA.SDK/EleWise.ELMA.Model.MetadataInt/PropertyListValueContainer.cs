using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

internal sealed class PropertyListValueContainer : PropertyCollectionValueContainer, IPropertyDefaultValueContainer
{
	private class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer
	{
		private static object y1hxBoCdz6WgbxxSqHab;

		IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
		{
			return new PropertyValueContainer<List<T>>(new List<T>());
		}

		public NestedDefaultValueContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool xxlO1dClF5Pnrl1GLSbp()
		{
			return y1hxBoCdz6WgbxxSqHab == null;
		}

		internal static object WUDpKYClBpS8OiYCoN5J()
		{
			return y1hxBoCdz6WgbxxSqHab;
		}
	}

	private static PropertyListValueContainer zyUim8hWmY24q73Xp3tf;

	public PropertyListValueContainer(Type tTarget)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		tvf7eNhWJN4tWXcpSWZA();
		base._002Ector(tTarget);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return (IPropertyValueContainer)ei452lhWd64yiK8egK1A(propContainer);
			case 3:
				propContainer = (IPropertyDefaultValueContainer)Activator.CreateInstance(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (propContainer == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				type = Y4tdU7hW9d9Vtl0IQ1NA(typeof(NestedDefaultValueContainer<>).TypeHandle).MakeGenericType(tTarget);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void tvf7eNhWJN4tWXcpSWZA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool diuBgYhWyXviH4RGZx4I()
	{
		return zyUim8hWmY24q73Xp3tf == null;
	}

	internal static PropertyListValueContainer r4aoSuhWMACw83NhMMMe()
	{
		return zyUim8hWmY24q73Xp3tf;
	}

	internal static Type Y4tdU7hW9d9Vtl0IQ1NA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ei452lhWd64yiK8egK1A(object P_0)
	{
		return ((IPropertyDefaultValueContainer)P_0).Initialize();
	}
}
