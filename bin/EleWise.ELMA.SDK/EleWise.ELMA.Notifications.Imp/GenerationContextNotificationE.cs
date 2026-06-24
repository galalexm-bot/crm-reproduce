using EleWise.TemplateGenerator;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator;

public static class GenerationContextNotificationExtensions
{
	private static GenerationContextNotificationExtensions RA07Sd6xaLQL9uuNeP1;

	public static int GetTextCaptionMaxLength(this GenerationContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (!context.ExtendedProperties.TryGetValue((string)QG0pee6y5XmhXQI8Gt5(-1876063057 ^ -1876091425), out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (int)value;
			}
			default:
				return 0;
			}
		}
	}

	public static void SetTextCaptionMaxLength(this GenerationContext context, int length)
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
				context.ExtendedProperties[(string)QG0pee6y5XmhXQI8Gt5(0xA592A41 ^ 0xA59BB31)] = length;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object QG0pee6y5XmhXQI8Gt5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool hTG6P660aNEPt7U4Qle()
	{
		return RA07Sd6xaLQL9uuNeP1 == null;
	}

	internal static GenerationContextNotificationExtensions Ff2o3k6mAoubIL9pZ3s()
	{
		return RA07Sd6xaLQL9uuNeP1;
	}
}
