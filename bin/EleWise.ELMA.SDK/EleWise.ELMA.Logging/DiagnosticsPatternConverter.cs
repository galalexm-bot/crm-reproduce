using System;
using System.IO;
using EleWise.ELMA.Diagnostics;
using j3AmrhgkCleVTGdEwA;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

internal class DiagnosticsPatternConverter : PatternConverter
{
	internal static DiagnosticsPatternConverter wI8VadhJjcD1RC8ofsDt;

	protected override void Convert(TextWriter writer, object state)
	{
		//Discarded unreachable code: IL_0083
		int num = 1;
		Guid? currentCallContextUid = default(Guid?);
		long? currentCallId = default(long?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					currentCallContextUid = DiagnosticsManager.GetCurrentCallContextUid();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					currentCallId = DiagnosticsManager.GetCurrentCallId();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				case 3:
					break;
				case 7:
					writer.Write((string)beO6gNhJsvGRtXVIwPFd(VU92OthJUCSardiWIH3J(-1858887263 ^ -1859112205), currentCallContextUid.Value, VU92OthJUCSardiWIH3J(-521266112 ^ -521213272)));
					num2 = 6;
					continue;
				case 2:
					if (currentCallId.HasValue)
					{
						num2 = 3;
						continue;
					}
					return;
				case 5:
					return;
				default:
					if (!currentCallContextUid.HasValue)
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				}
				break;
			}
			tW2A4qhJcjVBOp0KedsG(writer, beO6gNhJsvGRtXVIwPFd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4267A175), currentCallId.Value, VU92OthJUCSardiWIH3J(-1870892489 ^ -1870887713)));
			num = 5;
		}
	}

	public DiagnosticsPatternConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		((PatternConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object VU92OthJUCSardiWIH3J(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object beO6gNhJsvGRtXVIwPFd(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static void tW2A4qhJcjVBOp0KedsG(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static bool O506X3hJYRXiQSl1Wmg1()
	{
		return wI8VadhJjcD1RC8ofsDt == null;
	}

	internal static DiagnosticsPatternConverter Jo5CwZhJLkg7eWEcAkcf()
	{
		return wI8VadhJjcD1RC8ofsDt;
	}
}
