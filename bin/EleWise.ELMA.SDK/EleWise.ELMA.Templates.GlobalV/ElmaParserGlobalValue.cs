using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator;

public abstract class ElmaParserGlobalValue : IElmaParserGlobalValue
{
	internal static ElmaParserGlobalValue jE6HWABNqADWq3vnTuSa;

	public abstract FormatedValue Parse(string[] propertyNames);

	protected virtual string ParseGuid(Guid guid)
	{
		//Discarded unreachable code: IL_005a, IL_0069
		int num = 1;
		int num2 = num;
		Func<Guid, string> value = default(Func<Guid, string>);
		string result = default(string);
		IRuntimeApplication serviceNotNull = default(IRuntimeApplication);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (value != null)
				{
					num2 = 9;
					continue;
				}
				goto case 2;
			case 9:
				result = value(guid);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				result = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return null;
			case 4:
			case 5:
				return result;
			case 3:
				result = ((IProvider)Ev7a4pBNnFoH4dXcUgia(serviceNotNull)).GuidQuerySintaxis(guid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 5;
				}
				continue;
			case 6:
				HikV27BNk8PGNMYm4TAG(IaZHsDBNTr4I96N8Vy5R(-1978478350 ^ -1978429156));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 3;
				}
				continue;
			case 7:
				if (serviceNotNull.MainProvider != null)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			}
			if (!ContextVars.TryGetValue<Func<Guid, string>>((string)IaZHsDBNTr4I96N8Vy5R(-398663332 ^ -398614350), out value))
			{
				serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 7;
				}
			}
			else
			{
				num2 = 8;
			}
		}
	}

	protected ElmaParserGlobalValue()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object IaZHsDBNTr4I96N8Vy5R(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void HikV27BNk8PGNMYm4TAG(object P_0)
	{
		ContextVars.Remove((string)P_0);
	}

	internal static object Ev7a4pBNnFoH4dXcUgia(object P_0)
	{
		return ((IRuntimeApplication)P_0).MainProvider;
	}

	internal static bool xTvRkLBNKvv4HST2hmkw()
	{
		return jE6HWABNqADWq3vnTuSa == null;
	}

	internal static ElmaParserGlobalValue zyrZd0BNXT5QbCRtIYiV()
	{
		return jE6HWABNqADWq3vnTuSa;
	}
}
