using System;
using System.ComponentModel.DataAnnotations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.RegularExpressionAttribute
{
	private static RegularExpressionAttribute QUAB9sogl8ZbuDjDZqZa;

	public RegularExpressionAttribute(string pattern)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(pattern);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			base.ErrorMessage = (string)bYdycDogjvaKMfeaFadf(ojdDg2og5I3NnIQKfTLa(-1767720453 ^ -1767729073));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
			{
				num = 0;
			}
		}
	}

	public RegularExpressionAttribute(string pattern, Type staticResourceType, string propertyName)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(pattern);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.ErrorMessageResourceType = staticResourceType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 0;
				}
				break;
			default:
				Up8eNdogYrqyIIEkHcS6(this, propertyName);
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	public RegularExpressionAttribute(string pattern, string message)
	{
		//Discarded unreachable code: IL_001b, IL_0020, IL_0047, IL_0056
		pMojkfogLVkTWZnX23Uh();
		base._002Ector(pattern);
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 4:
				if (!string.IsNullOrEmpty(message))
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num = 2;
					}
					break;
				}
				goto default;
			default:
				message = (string)bYdycDogjvaKMfeaFadf(ojdDg2og5I3NnIQKfTLa(-16752921 ^ -16744621));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 1;
				}
				break;
			case 1:
			case 2:
				g4aH0KogUdI7W803Vabi(this, message);
				num = 3;
				break;
			}
		}
	}

	internal static object ojdDg2og5I3NnIQKfTLa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bYdycDogjvaKMfeaFadf(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool vb51CoogrZIxV6jYxILb()
	{
		return QUAB9sogl8ZbuDjDZqZa == null;
	}

	internal static RegularExpressionAttribute maMYbuogglVrJ8L56yPy()
	{
		return QUAB9sogl8ZbuDjDZqZa;
	}

	internal static void Up8eNdogYrqyIIEkHcS6(object P_0, object P_1)
	{
		((ValidationAttribute)P_0).ErrorMessageResourceName = (string)P_1;
	}

	internal static void pMojkfogLVkTWZnX23Uh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void g4aH0KogUdI7W803Vabi(object P_0, object P_1)
	{
		((ValidationAttribute)P_0).ErrorMessage = (string)P_1;
	}
}
