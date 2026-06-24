using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class UriStringConvertTypeWrapper : IConvertTypeWrapper
{
	internal static UriStringConvertTypeWrapper opH4EIbbV7MN4Je0afdO;

	public Type OriginalType => TG7B3obbRxlBVjFgevyf(typeof(Uri).TypeHandle);

	public Type ConvertType => TG7B3obbRxlBVjFgevyf(typeof(string).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_003f, IL_004e
		int num = 3;
		int num2 = num;
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return string.Empty;
			default:
				return uri.OriginalString;
			case 2:
				if (!FxresJbbq6oanc41hXJG(uri, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				uri = (Uri)obj;
				num2 = 2;
				break;
			}
		}
	}

	public UriStringConvertTypeWrapper()
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

	internal static Type TG7B3obbRxlBVjFgevyf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool FxresJbbq6oanc41hXJG(object P_0, object P_1)
	{
		return (Uri)P_0 == (Uri)P_1;
	}

	internal static bool DgdTqjbbSctOfDXru9Jo()
	{
		return opH4EIbbV7MN4Je0afdO == null;
	}

	internal static UriStringConvertTypeWrapper awKtjnbbiIPf82Qmon6t()
	{
		return opH4EIbbV7MN4Je0afdO;
	}
}
