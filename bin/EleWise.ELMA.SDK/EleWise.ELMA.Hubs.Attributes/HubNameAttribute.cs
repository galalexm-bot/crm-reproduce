using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Hubs.Attributes;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class HubNameAttribute : Attribute
{
	internal static HubNameAttribute g8X17bh5RB8cVhV0E6wC;

	public string HubName { get; }

	public HubNameAttribute(string hubName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iUSkRNh5XYNGHosVnOMK();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				ehA7XYh5TK9wE67TsKmM(hubName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675347229));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				HubName = hubName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void iUSkRNh5XYNGHosVnOMK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void ehA7XYh5TK9wE67TsKmM(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool PPwlFXh5qu5KKxTNOl0X()
	{
		return g8X17bh5RB8cVhV0E6wC == null;
	}

	internal static HubNameAttribute rT9tPWh5KB10FlV1t90g()
	{
		return g8X17bh5RB8cVhV0E6wC;
	}
}
