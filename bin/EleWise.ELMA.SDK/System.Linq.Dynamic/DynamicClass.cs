using System.Reflection;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace System.Linq.Dynamic;

public abstract class DynamicClass
{
	private static DynamicClass yQXYGsbpSfx546jttAY;

	public override string ToString()
	{
		//Discarded unreachable code: IL_01d8, IL_01e7
		int num = 12;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		PropertyInfo[] properties = default(PropertyInfo[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				a6uebUbwtN9XHE2aRu5(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138016253));
				num2 = 9;
				break;
			case 5:
				return stringBuilder.ToString();
			case 12:
				properties = Uhe6JXbtm2jHc5o0NA3(this).GetProperties(BindingFlags.Instance | BindingFlags.Public);
				num2 = 11;
				break;
			default:
				a6uebUbwtN9XHE2aRu5(stringBuilder, properties[num3].Name);
				num2 = 4;
				break;
			case 7:
				stringBuilder.Append((string)bAFjiZb6kOF3OflbMtI(0x4EDCBA32 ^ 0x4EDCB622));
				num2 = 5;
				break;
			case 2:
			case 6:
				if (num3 >= properties.Length)
				{
					num2 = 7;
					break;
				}
				goto case 8;
			case 9:
				num3 = 0;
				num2 = 2;
				break;
			case 13:
				num3++;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				a6uebUbwtN9XHE2aRu5(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112702316));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				qhp36lb4EUuPFxDXwu9(stringBuilder, properties[num3].GetValue(this, null));
				num2 = 13;
				break;
			case 8:
				if (num3 > 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 4:
				stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138157454));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				stringBuilder = new StringBuilder();
				num2 = 3;
				break;
			}
		}
	}

	protected DynamicClass()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type Uhe6JXbtm2jHc5o0NA3(object P_0)
	{
		return P_0.GetType();
	}

	internal static object a6uebUbwtN9XHE2aRu5(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object qhp36lb4EUuPFxDXwu9(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object bAFjiZb6kOF3OflbMtI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool ysS542baRrkOb8M9ptJ()
	{
		return yQXYGsbpSfx546jttAY == null;
	}

	internal static DynamicClass ujYlnNbDEhcqqL4LWDE()
	{
		return yQXYGsbpSfx546jttAY;
	}
}
