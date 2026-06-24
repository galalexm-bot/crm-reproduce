using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ClassNotFoundEQLException : PositionalEQLException
{
	private static ClassNotFoundEQLException BZrH6EG5JhF1bUjqlcR0;

	public string Class
	{
		[CompilerGenerated]
		get
		{
			return _003CClass_003Ek__BackingField;
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
					_003CClass_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected ClassNotFoundEQLException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		GESY9GG5lYAuaGhd3sZf();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ClassNotFoundEQLException(int position, string @class)
	{
		//Discarded unreachable code: IL_005a, IL_005f
		GESY9GG5lYAuaGhd3sZf();
		base._002Ector(null, SR.T((string)Ju7uRFG5rbt0tqZbkd0W(-1765851862 ^ -1766120328), @class, position), position);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
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
			Class = @class;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
			{
				num = 1;
			}
		}
	}

	public ClassNotFoundEQLException(string query, string message, int position, string @class)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		GESY9GG5lYAuaGhd3sZf();
		base._002Ector(query, message, position);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
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
			Class = @class;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool JCxpeSG59ZhLQImsjcRW()
	{
		return BZrH6EG5JhF1bUjqlcR0 == null;
	}

	internal static ClassNotFoundEQLException n1vNAKG5dEWfs1Oi4qnj()
	{
		return BZrH6EG5JhF1bUjqlcR0;
	}

	internal static void GESY9GG5lYAuaGhd3sZf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Ju7uRFG5rbt0tqZbkd0W(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
