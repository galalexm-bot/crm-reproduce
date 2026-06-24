using System;
using System.IO;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

public static class SystemFileNHManagerExtensions
{
	private static SystemFileNHManagerExtensions g2OsJFGXov00rWaVUyfJ;

	public static SystemFile LoadFileRequired(this SystemFileNHManager manager, Guid uid)
	{
		//Discarded unreachable code: IL_0093, IL_00a2
		int num = 3;
		int num2 = num;
		SystemFile systemFile = default(SystemFile);
		while (true)
		{
			switch (num2)
			{
			case 3:
				systemFile = (SystemFile)D0lw6YGXG7RaaooCSwhZ(manager, uid);
				num2 = 2;
				break;
			case 2:
				if (systemFile != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				throw new FileNotFoundException(SR.T((string)jElshJGXEauWaXZxrC70(-812025778 ^ -812067828), uid));
			case 1:
				return systemFile;
			}
		}
	}

	internal static object D0lw6YGXG7RaaooCSwhZ(object P_0, Guid uid)
	{
		return ((SystemFileNHManager)P_0).LoadFile(uid);
	}

	internal static object jElshJGXEauWaXZxrC70(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool lcl7xlGXb7hHOvnNmjyK()
	{
		return g2OsJFGXov00rWaVUyfJ == null;
	}

	internal static SystemFileNHManagerExtensions BN3NdoGXhgBI0I3ivU0l()
	{
		return g2OsJFGXov00rWaVUyfJ;
	}
}
