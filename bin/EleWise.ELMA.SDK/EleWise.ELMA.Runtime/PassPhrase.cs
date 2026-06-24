using System;
using System.Configuration;
using System.IO;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime;

public class PassPhrase
{
	private static string configPath;

	private readonly string passPhraseFilename;

	private string passPhrase;

	private static PassPhrase UkNjJVWovmyZAhCXgQUp;

	public string AbsolutePath => passPhraseFilename;

	private static string ConfigPath
	{
		get
		{
			//Discarded unreachable code: IL_00cb
			int num = 3;
			string text = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					string text2;
					switch (num2)
					{
					default:
						return configPath;
					case 2:
						text = (string)blolojWo2VCOKHRJUWRH(((ConnectionStringSettingsCollection)zyV2qZWoOdgCRCU33Vc4())[(string)Cpq2a3WoVCgYhjSTY2wP(0x76DD48E ^ 0x76C5BC0)]);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						if (WV5lmqWoeQNMLAGjLAdK(text))
						{
							text2 = text;
							break;
						}
						goto end_IL_0012;
					case 3:
						if (configPath == null)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto default;
					case 4:
						text2 = Path.Combine((string)TT6ToxWo1nTPNgR4IbWw(wMwuMbWoPqR0u3NwdEyU()), text);
						break;
					}
					configPath = (string)kY0p4DWoNBT2LaDDula6(text2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 4;
			}
		}
	}

	public PassPhrase(string path)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		bjalkHWoukERhy1eZLDE();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				throw new ArgumentException(SR.T((string)Cpq2a3WoVCgYhjSTY2wP(-1088304168 ^ -1088404210)));
			case 3:
				if (!CYN4WHWoIWE4ZfufNjIF(path))
				{
					passPhraseFilename = (string)hm9E3YWoS8nto2UQL3d9(ConfigPath, Cpq2a3WoVCgYhjSTY2wP(0x5DD55050 ^ 0x5DD4DF6E), path);
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num = 0;
					}
				}
				break;
			case 1:
				Generate();
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public void Generate()
	{
		//Discarded unreachable code: IL_00e7, IL_0144, IL_0163, IL_0172, IL_019f, IL_01ae
		int num = 1;
		string directoryName = default(string);
		StreamWriter streamWriter = default(StreamWriter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					directoryName = Path.GetDirectoryName(passPhraseFilename);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					return;
				case 4:
					break;
				case 1:
					passPhrase = qDtihLWoih2LFRsYJZXY().ToString((string)Cpq2a3WoVCgYhjSTY2wP(0x8317432 ^ 0x831043C));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					try
					{
						kvvxZ1WoKfSdlybyL6FZ(streamWriter, passPhrase);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							}
							streamWriter.Flush();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num3 = 0;
							}
						}
					}
					finally
					{
						int num4;
						if (streamWriter == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num4 = 1;
							}
							goto IL_0148;
						}
						goto IL_017d;
						IL_017d:
						WSYP7jWoXYY2GQX1cAQm(streamWriter);
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num4 = 2;
						}
						goto IL_0148;
						IL_0148:
						switch (num4)
						{
						case 1:
							goto end_IL_0123;
						case 2:
							goto end_IL_0123;
						}
						goto IL_017d;
						end_IL_0123:;
					}
				case 6:
					PpqZl4WoRa04G2UIRhPZ(directoryName);
					num2 = 4;
					continue;
				case 2:
					if (!Directory.Exists(directoryName))
					{
						num2 = 6;
						continue;
					}
					break;
				}
				break;
			}
			streamWriter = (StreamWriter)TIsV2BWoqUr2TfZSPAVS(passPhraseFilename);
			num = 5;
		}
	}

	public bool IsValid(string value)
	{
		return mXwwPhWoTm0DAmGLQexj(passPhrase, value);
	}

	public void Delete()
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (!YiittNWok3XpKGATBc95(passPhraseFilename))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 1:
				break;
			}
			ihuUXMWonfi3qtHKaxBU(passPhraseFilename);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void bjalkHWoukERhy1eZLDE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool CYN4WHWoIWE4ZfufNjIF(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Cpq2a3WoVCgYhjSTY2wP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hm9E3YWoS8nto2UQL3d9(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static bool MCm9HmWo8gkFt8AFnZEZ()
	{
		return UkNjJVWovmyZAhCXgQUp == null;
	}

	internal static PassPhrase elFxhIWoZ6GQadk5O5ON()
	{
		return UkNjJVWovmyZAhCXgQUp;
	}

	internal static Guid qDtihLWoih2LFRsYJZXY()
	{
		return Guid.NewGuid();
	}

	internal static object PpqZl4WoRa04G2UIRhPZ(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object TIsV2BWoqUr2TfZSPAVS(object P_0)
	{
		return File.CreateText((string)P_0);
	}

	internal static void kvvxZ1WoKfSdlybyL6FZ(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static void WSYP7jWoXYY2GQX1cAQm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool mXwwPhWoTm0DAmGLQexj(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool YiittNWok3XpKGATBc95(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void ihuUXMWonfi3qtHKaxBU(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object zyV2qZWoOdgCRCU33Vc4()
	{
		return ConfigurationManager.ConnectionStrings;
	}

	internal static object blolojWo2VCOKHRJUWRH(object P_0)
	{
		return ((ConnectionStringSettings)P_0).ConnectionString;
	}

	internal static bool WV5lmqWoeQNMLAGjLAdK(object P_0)
	{
		return Path.IsPathRooted((string)P_0);
	}

	internal static object wMwuMbWoPqR0u3NwdEyU()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object TT6ToxWo1nTPNgR4IbWw(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static object kY0p4DWoNBT2LaDDula6(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}
}
