using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class EQLException : Exception
{
	private static EQLException oYBYdKG5DxsmpEbrlIx9;

	public string Query
	{
		[CompilerGenerated]
		get
		{
			return _003CQuery_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CQuery_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public EQLException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a9PCY0G54fvDPTjanZTh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EQLException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		a9PCY0G54fvDPTjanZTh();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected EQLException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		a9PCY0G54fvDPTjanZTh();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EQLException(string query, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Query = query;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool g0M57PG5t4rVIwJdRjUA()
	{
		return oYBYdKG5DxsmpEbrlIx9 == null;
	}

	internal static EQLException nJnM1YG5wTL1J8ThIL7S()
	{
		return oYBYdKG5DxsmpEbrlIx9;
	}

	internal static void a9PCY0G54fvDPTjanZTh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
