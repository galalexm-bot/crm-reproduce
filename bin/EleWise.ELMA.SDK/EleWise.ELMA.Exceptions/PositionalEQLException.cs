using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class PositionalEQLException : EQLException
{
	private static PositionalEQLException JjyNPXG56Hno7mMBj2L1;

	public int Position
	{
		[CompilerGenerated]
		get
		{
			return _003CPosition_003Ek__BackingField;
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
					_003CPosition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PositionalEQLException(string query, string message, int position)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		JO3homG57cXKlUWxZoPC();
		base._002Ector(query, message);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Position = position;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PositionalEQLException(int position)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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
			Position = position;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
			{
				num = 1;
			}
		}
	}

	public PositionalEQLException(string message, Exception innerException, int position)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		JO3homG57cXKlUWxZoPC();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
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
			Position = position;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
			{
				num = 1;
			}
		}
	}

	public PositionalEQLException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ivpeEFG5HNB7JFKjjKbE()
	{
		return JjyNPXG56Hno7mMBj2L1 == null;
	}

	internal static PositionalEQLException UDfa6KG5ATpg5Ah1Q9Wt()
	{
		return JjyNPXG56Hno7mMBj2L1;
	}

	internal static void JO3homG57cXKlUWxZoPC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
