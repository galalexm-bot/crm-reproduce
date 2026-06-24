using System;
using System.Web;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class HtmlStringWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static HtmlStringWrapperDescriptor X7B3WWbba6BBg4RhA08N;

	public Type OriginalType => u10x1Kbbw4oeWKvXeeHN(typeof(HtmlString).TypeHandle);

	public Type WrapperType => u10x1Kbbw4oeWKvXeeHN(typeof(HtmlStringWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new HtmlStringWrapper((HtmlString)obj);
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return fr0hLqbb4jUXhQDA6vSj((HtmlStringWrapper)wrapper);
			case 2:
				if (wrapper is HtmlStringWrapper)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public HtmlStringWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FBMxUmbb6VpCaxk51QYv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type u10x1Kbbw4oeWKvXeeHN(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool LqxGfrbbDY635u2HFsE6()
	{
		return X7B3WWbba6BBg4RhA08N == null;
	}

	internal static HtmlStringWrapperDescriptor qBJHRFbbtm8N8yp9xxtr()
	{
		return X7B3WWbba6BBg4RhA08N;
	}

	internal static object fr0hLqbb4jUXhQDA6vSj(object P_0)
	{
		return ((HtmlStringWrapper)P_0).Value;
	}

	internal static void FBMxUmbb6VpCaxk51QYv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
