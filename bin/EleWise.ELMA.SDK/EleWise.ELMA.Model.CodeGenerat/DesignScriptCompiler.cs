using System;
using System.IO;
using EleWise.ELMA.Design;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class DesignScriptCompiler : ScriptCompiler
{
	private static DesignScriptCompiler qrslWkh15ZkCJv7QbZx6;

	public DesignScriptCompiler(IScriptModule scriptModule)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(scriptModule);
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
				base.AssemblyName = (string)o79c5Hh1LRMP6e5vuS4M(scriptModule);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void AddAllElmaReferences()
	{
		//Discarded unreachable code: IL_00cf
		int num = 7;
		int num3 = default(int);
		FileInfo fileInfo = default(FileInfo);
		FileInfo[] array = default(FileInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					num3++;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					break;
				case 6:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 4:
					SrSdU0hNB89YE2VgfgbQ(this, HKyeVRhNFHKRYa3qHx45(fileInfo));
					num2 = 3;
					continue;
				case 5:
					fileInfo = array[num3];
					num2 = 4;
					continue;
				case 1:
				case 2:
					if (num3 >= array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				}
				break;
			}
			array = (FileInfo[])SjEN4Uh1zA20QRlBD7TE(new DirectoryInfo((string)G8aofRh1UTsu0XCaIwqr()), nNDOKjh1cgUKphuHUp9j(qGxwoXh1sxrGacBdeZss(-1317790512 ^ -1317709802), Array.Empty<object>()));
			num = 6;
		}
	}

	internal static object o79c5Hh1LRMP6e5vuS4M(object P_0)
	{
		return ((IScriptModule)P_0).AssemblyName;
	}

	internal static bool ftQ7krh1j8aeVKHq4ASw()
	{
		return qrslWkh15ZkCJv7QbZx6 == null;
	}

	internal static DesignScriptCompiler UqI07qh1YKxXRtNUonpo()
	{
		return qrslWkh15ZkCJv7QbZx6;
	}

	internal static object G8aofRh1UTsu0XCaIwqr()
	{
		return DesignEnvironment.LibsDir;
	}

	internal static object qGxwoXh1sxrGacBdeZss(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nNDOKjh1cgUKphuHUp9j(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object SjEN4Uh1zA20QRlBD7TE(object P_0, object P_1)
	{
		return ((DirectoryInfo)P_0).GetFiles((string)P_1);
	}

	internal static object HKyeVRhNFHKRYa3qHx45(object P_0)
	{
		return ((FileSystemInfo)P_0).FullName;
	}

	internal static void SrSdU0hNB89YE2VgfgbQ(object P_0, object P_1)
	{
		((AssemblyBuilder)P_0).AddReference((string)P_1);
	}
}
