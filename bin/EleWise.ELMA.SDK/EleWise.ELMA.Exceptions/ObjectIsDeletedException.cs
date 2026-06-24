using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ObjectIsDeletedException : Exception
{
	private static ObjectIsDeletedException EIH1BjGjCAXnKR2WNWRn;

	public object ObjectId
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectId_003Ek__BackingField;
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
					_003CObjectId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ObjectType
	{
		[CompilerGenerated]
		get
		{
			return _003CObjectType_003Ek__BackingField;
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
					_003CObjectType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
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

	public ObjectIsDeletedException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sEoKpIGjZfD9cyZEHZ41();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ObjectIsDeletedException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		sEoKpIGjZfD9cyZEHZ41();
		base._002Ector(message);
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

	protected ObjectIsDeletedException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		sEoKpIGjZfD9cyZEHZ41();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void sEoKpIGjZfD9cyZEHZ41()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool l9ihikGjvgKbu7eElR9V()
	{
		return EIH1BjGjCAXnKR2WNWRn == null;
	}

	internal static ObjectIsDeletedException uxa5iZGj8JW9riDqNy1r()
	{
		return EIH1BjGjCAXnKR2WNWRn;
	}
}
