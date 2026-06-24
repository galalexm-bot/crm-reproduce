using System.Text;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Text;

public static class EncodingCache
{
	public static UTF8Encoding UTF8WithoutEmitIdentifier;

	public static Encoding Win1251Encoding;

	private static EncodingCache uHjOYtBPRpXhFLAeJSjc;

	static EncodingCache()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				Win1251Encoding = (Encoding)lxMyU6BPTkEsOXsZtMva(1251);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				yiWgydBPX9bKGMXW7ji4();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				UTF8WithoutEmitIdentifier = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void yiWgydBPX9bKGMXW7ji4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object lxMyU6BPTkEsOXsZtMva(int P_0)
	{
		return Encoding.GetEncoding(P_0);
	}

	internal static bool LXJdaPBPq9qhXyIqWBwv()
	{
		return uHjOYtBPRpXhFLAeJSjc == null;
	}

	internal static EncodingCache k7AAXiBPKD5sQQnaIc8E()
	{
		return uHjOYtBPRpXhFLAeJSjc;
	}
}
