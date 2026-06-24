using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class PropertyNotFoundEQLException : PositionalEQLException
{
	internal static PropertyNotFoundEQLException o7qVGcG5xhZSwZ9tkDaR;

	public string Property
	{
		[CompilerGenerated]
		get
		{
			return _003CProperty_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CProperty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected PropertyNotFoundEQLException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		voQ5gNG5ywYRmKxZiGhg();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PropertyNotFoundEQLException(int position, string property)
	{
		//Discarded unreachable code: IL_0054, IL_0059
		voQ5gNG5ywYRmKxZiGhg();
		base._002Ector(null, SR.T((string)T6QncPG5MLst99dM4cHo(-740338220 ^ -740602566), property, position), position);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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
				Property = property;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PropertyNotFoundEQLException(string query, string message, int position, string property)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(query, message, position);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
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
			Property = property;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool OsgKH5G50xwKs3sQcbsw()
	{
		return o7qVGcG5xhZSwZ9tkDaR == null;
	}

	internal static PropertyNotFoundEQLException rgwy16G5m4bYUJMQ3NEG()
	{
		return o7qVGcG5xhZSwZ9tkDaR;
	}

	internal static void voQ5gNG5ywYRmKxZiGhg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object T6QncPG5MLst99dM4cHo(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
