using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

internal static class ElmaTypeDescriptorHelper
{
	private static ConcurrentDictionary<Type, TypeConverter> convertersMap;

	private static ElmaTypeDescriptorHelper EndwQ8boi4dAATFaCiV4;

	public static TypeConverter GetConverter(Type type)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass1_.type = type;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return convertersMap.GetOrAdd(_003C_003Ec__DisplayClass1_.type, _003C_003Ec__DisplayClass1_._003CGetConverter_003Eb__0);
			}
		}
	}

	static ElmaTypeDescriptorHelper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				aOYn26boKh7b8EXBaDLw();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				convertersMap = new ConcurrentDictionary<Type, TypeConverter>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool Y99KnwboRe0M7jbIbFdG()
	{
		return EndwQ8boi4dAATFaCiV4 == null;
	}

	internal static ElmaTypeDescriptorHelper BSSJuOboqN3jf0H1Wm3s()
	{
		return EndwQ8boi4dAATFaCiV4;
	}

	internal static void aOYn26boKh7b8EXBaDLw()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
