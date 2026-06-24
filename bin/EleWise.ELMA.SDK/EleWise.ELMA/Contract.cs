using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Exceptions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA;

public static class Contract
{
	private static Contract XGuSHmQwLUNwIt3wgc7;

	public static void Check<TException>(bool condition, string conditionText) where TException : Exception
	{
		CheckWithMessage<TException>(condition, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675500995), conditionText));
	}

	public static void CheckWithMessage<TException>(bool condition, string messageText) where TException : Exception
	{
		if (condition)
		{
			return;
		}
		ConstructorInfo constructorInfo = typeof(TException).GetConstructors(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(delegate(ConstructorInfo c)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return c.GetParameters()[0].ParameterType == typeof(string);
				case 1:
					if (c.GetParameters().Length != 1)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		if (constructorInfo != null)
		{
			object[] parameters = new string[1] { messageText };
			throw (TException)constructorInfo.Invoke(parameters);
		}
		throw new Exception(messageText);
	}

	public static void NotNull(object value, string valueName)
	{
		//Discarded unreachable code: IL_0054, IL_0063
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new NullReferenceException(SR.T((string)gOdGblQH8yNFh3O2n0w(-2138160520 ^ -2138146872), valueName));
			case 1:
				return;
			case 2:
				if (value != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static void NotNullOrEmpty(string value, string valueName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new NullReferenceException(SR.T((string)gOdGblQH8yNFh3O2n0w(0x92F12D5 ^ 0x92F24F7), valueName));
			case 1:
				if (!t2uZ8ZQAgiwip6Pe29k(value))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void ArgumentNotNull(object value, string argumentName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException(argumentName);
			case 1:
				if (value != null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void ArgumentNotNullOrEmpty(string value, string argumentName)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				if (!t2uZ8ZQAgiwip6Pe29k(value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			break;
		}
		throw new ArgumentException(SR.T((string)gOdGblQH8yNFh3O2n0w(0x7459E02 ^ 0x745A8A8), argumentName));
	}

	public static void CheckArgument(bool condition, string conditionText)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!condition)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112715866), conditionText));
			}
		}
	}

	public static void ServiceNotNull(object service, string serviceName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (service == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new ServiceNotFoundException(serviceName);
			}
		}
	}

	internal static object gOdGblQH8yNFh3O2n0w(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool sjitIrQ4DTTg0J9MuhM()
	{
		return XGuSHmQwLUNwIt3wgc7 == null;
	}

	internal static Contract bFNkgAQ685xf08AhZ2Z()
	{
		return XGuSHmQwLUNwIt3wgc7;
	}

	internal static bool t2uZ8ZQAgiwip6Pe29k(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
