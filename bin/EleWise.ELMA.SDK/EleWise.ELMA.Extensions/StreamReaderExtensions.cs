using System.ComponentModel;
using System.IO;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class StreamReaderExtensions
{
	private static StreamReaderExtensions bB6sJXG3JyDuDqWEdlQ0;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void CheckAndCorrectInternalBOMSymbols(this StreamReader streamReader)
	{
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (num3 != 65279)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				EtKRcdG35kCBaqu7958n(streamReader);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				num3 = L2owD2G3gXX6Rdx4nqGc(streamReader);
				num2 = 2;
				break;
			case 1:
				return;
			case 3:
				if (num3 != 65534)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				XhRbLsG3rifkrdreVcnx(streamReader, l4QKiTG3l1nctrdQ3gWe(-1852837372 ^ -1853094750));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object l4QKiTG3l1nctrdQ3gWe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XhRbLsG3rifkrdreVcnx(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int L2owD2G3gXX6Rdx4nqGc(object P_0)
	{
		return ((TextReader)P_0).Peek();
	}

	internal static int EtKRcdG35kCBaqu7958n(object P_0)
	{
		return ((TextReader)P_0).Read();
	}

	internal static bool CIQHjqG39JXYYY0QogrN()
	{
		return bB6sJXG3JyDuDqWEdlQ0 == null;
	}

	internal static StreamReaderExtensions os5BeBG3dQ36adCTsupd()
	{
		return bB6sJXG3JyDuDqWEdlQ0;
	}
}
