using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class StringUriConvertTypeWrapper : IConvertTypeWrapper
{
	internal static StringUriConvertTypeWrapper YBDFCbbb8cF7SI8K98Ci;

	public Type OriginalType => typeof(string);

	public Type ConvertType => typeof(Uri);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_0072, IL_00a4, IL_00dc, IL_00eb
		int num = 1;
		int num2 = num;
		object obj2 = default(object);
		string uriString = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return obj2;
			case 1:
				uriString = (string)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				obj2 = new Uri(uriString, UriKind.RelativeOrAbsolute);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => obj2, 
					_ => obj2, 
				};
			}
			catch (Exception)
			{
				int num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						return obj2;
					case 0:
						return obj2;
					case 1:
						obj2 = null;
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public StringUriConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nM1fbqbbIwybObfSri1K();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TYnsDZbbZ4j51SLjS8yM()
	{
		return YBDFCbbb8cF7SI8K98Ci == null;
	}

	internal static StringUriConvertTypeWrapper EOcpAsbbubLtbCRJqUbh()
	{
		return YBDFCbbb8cF7SI8K98Ci;
	}

	internal static void nM1fbqbbIwybObfSri1K()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
