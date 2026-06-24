using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class MetadataValidationException : Exception
{
	internal static MetadataValidationException KUFtxeGgVtY2nf8JnQgC;

	private static string DefaultMessage => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69741571));

	public ValidationError[] ValidationErrors
	{
		[CompilerGenerated]
		get
		{
			return _003CValidationErrors_003Ek__BackingField;
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
					_003CValidationErrors_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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

	public MetadataValidationException(ValidationError[] validationErrors)
	{
		//Discarded unreachable code: IL_002f, IL_0034
		itQbC9GgRtGSDYQY2dgZ();
		base._002Ector((string)qwyWsMGgqBOuqgcpIYLi());
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ValidationErrors = validationErrors;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public MetadataValidationException(string message, ValidationError[] validationErrors)
	{
		//Discarded unreachable code: IL_0045, IL_004a
		itQbC9GgRtGSDYQY2dgZ();
		base._002Ector((string)O8DoGjGgXN6TP35TRQ2K(qwyWsMGgqBOuqgcpIYLi(), J17AFNGgKWOJLraJXFqg(-2106517564 ^ -2106490992), message));
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ValidationErrors = validationErrors;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected MetadataValidationException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
			ValidationErrors = (ValidationError[])K5uCvvGgTGKHUKkbQwXB(info, J17AFNGgKWOJLraJXFqg(-281842504 ^ -281819532), typeof(ValidationError[]));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
			{
				num = 1;
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				sMyDBsGgkMUjE1xXAQZb(this, info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				lXaZkgGgn6MAmWMcq9Js(info, J17AFNGgKWOJLraJXFqg(0x7247028A ^ 0x7247A846), ValidationErrors);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool J8hudsGgS5txCToG7GRx()
	{
		return KUFtxeGgVtY2nf8JnQgC == null;
	}

	internal static MetadataValidationException XRQdBAGgiXGkNlquyfLD()
	{
		return KUFtxeGgVtY2nf8JnQgC;
	}

	internal static void itQbC9GgRtGSDYQY2dgZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object qwyWsMGgqBOuqgcpIYLi()
	{
		return DefaultMessage;
	}

	internal static object J17AFNGgKWOJLraJXFqg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object O8DoGjGgXN6TP35TRQ2K(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object K5uCvvGgTGKHUKkbQwXB(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void sMyDBsGgkMUjE1xXAQZb(object P_0, object P_1, StreamingContext P_2)
	{
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	internal static void lXaZkgGgn6MAmWMcq9Js(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
