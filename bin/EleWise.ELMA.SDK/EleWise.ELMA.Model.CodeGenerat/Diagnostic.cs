using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

[Serializable]
public class Diagnostic
{
	private static Diagnostic LPggwFheSGLKmNJjLLZQ;

	public DiagnosticSeverity Severity
	{
		[CompilerGenerated]
		get
		{
			return _003CSeverity_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CSeverity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Location Location
	{
		[CompilerGenerated]
		get
		{
			return _003CLocation_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CLocation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string ToString()
	{
		return (string)Lgg9YUheXIIvmZ0vBVeF(new object[6]
		{
			Location,
			N3tLgIheqfOuiul2p10i(Severity.ToString()),
			jQB0j3heKXyGZ7ExvvPc(0x463A0F3C ^ 0x463A461E),
			Id,
			jQB0j3heKXyGZ7ExvvPc(0x6DC147B0 ^ 0x6DC12FE4),
			Message
		});
	}

	public Diagnostic()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MUFedjheTX4Rg1PuYH8M();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool o9nBR9heiRlBagGWtJ5G()
	{
		return LPggwFheSGLKmNJjLLZQ == null;
	}

	internal static Diagnostic KfVcehheRxGvoFD4e0ES()
	{
		return LPggwFheSGLKmNJjLLZQ;
	}

	internal static object N3tLgIheqfOuiul2p10i(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object jQB0j3heKXyGZ7ExvvPc(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Lgg9YUheXIIvmZ0vBVeF(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static void MUFedjheTX4Rg1PuYH8M()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
