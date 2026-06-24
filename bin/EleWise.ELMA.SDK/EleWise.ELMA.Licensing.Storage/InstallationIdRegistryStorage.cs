using System;
using System.IO;
using System.Security;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing.Storages;

public class InstallationIdRegistryStorage : IInstallationIdStorage
{
	private RegistryKey _root;

	private RegistryKey _readKey;

	private RegistryKey _writeKey;

	internal static InstallationIdRegistryStorage rarKBUxL5fjKpppf7Pj;

	public InstallationIdRegistryStorage(RegistryKey root)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_008f, IL_00d4, IL_00e3, IL_0168, IL_0192, IL_01e9, IL_0240, IL_027c, IL_028b, IL_02ac, IL_03f1, IL_0448, IL_049f, IL_04db
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 5;
		string text = default(string);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num)
			{
			case 7:
				try
				{
					_readKey = (RegistryKey)rUoqgQxzGclTHPL27GV(_root, g78M5QxckCuywbLadVO(0x66F566B6 ^ 0x66F5F8B2));
					int num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 2;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							ItQneu0B1bMTsDA1E4R(_readKey);
							num2 = 3;
							continue;
						case 5:
							goto end_IL_0093;
						case 1:
							if (_readKey == null)
							{
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num2 = 5;
								}
								continue;
							}
							goto default;
						case 2:
							if (_readKey != null)
							{
								num2 = 4;
								continue;
							}
							break;
						case 6:
							break;
						case 4:
							goto end_IL_0093;
						case 3:
							goto end_IL_0093;
						}
						_readKey = (RegistryKey)la6gqA0Fsr7ZUK8VEpu(_root, g78M5QxckCuywbLadVO(-675505729 ^ -675543109));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 1;
						}
						continue;
						end_IL_0093:
						break;
					}
				}
				catch (SecurityException)
				{
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							_readKey = null;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch (IOException)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							_readKey = null;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (UnauthorizedAccessException)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							_readKey = null;
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
							{
								num5 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			case 5:
				_root = root;
				num = 6;
				continue;
			case 3:
				return;
			case 4:
				num = 7;
				continue;
			case 1:
				try
				{
					_writeKey = (RegistryKey)A2bBu50WurUfNTjCrdH(_root, g78M5QxckCuywbLadVO(-16752921 ^ -16727837), true);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num6 = 3;
					}
					while (true)
					{
						switch (num6)
						{
						case 4:
						{
							IZtkQR0blxKejh7LSvP(_writeKey, text);
							int num7 = 5;
							num6 = num7;
							break;
						}
						default:
							guid = Guid.NewGuid();
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num6 = 1;
							}
							break;
						case 3:
							if (_writeKey != null)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num6 = 0;
								}
								break;
							}
							return;
						case 2:
							vyJj0u0occTZVNKGuN2(_writeKey, text, g78M5QxckCuywbLadVO(0x63ABA4E8 ^ 0x63ABBB64));
							num6 = 4;
							break;
						case 1:
							text = guid.ToString();
							num6 = 2;
							break;
						case 5:
							return;
						}
					}
				}
				catch (IOException)
				{
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num8 = 0;
					}
					while (true)
					{
						switch (num8)
						{
						case 1:
							return;
						}
						_writeKey = null;
						num8 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num8 = 1;
						}
					}
				}
				catch (SecurityException)
				{
					int num9 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num9 = 1;
					}
					while (true)
					{
						switch (num9)
						{
						default:
							return;
						case 1:
							_writeKey = null;
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num9 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
					int num10 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num10 = 1;
					}
					while (true)
					{
						switch (num10)
						{
						default:
							return;
						case 1:
							_writeKey = null;
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num10 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 6:
				if (_root == null)
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num = 4;
				}
				continue;
			case 2:
				return;
			}
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num = 1;
			}
		}
	}

	public string Read()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (_readKey != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return (string)_readKey.GetValue((string)g78M5QxckCuywbLadVO(-1217523399 ^ -1217491189));
			}
		}
	}

	public bool Write(string value)
	{
		//Discarded unreachable code: IL_008d, IL_00e0, IL_0112, IL_0144, IL_015b, IL_016a
		int num = 3;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 2:
				if (_writeKey != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				try
				{
					vyJj0u0occTZVNKGuN2(_writeKey, g78M5QxckCuywbLadVO(0x3C5338FF ^ 0x3C53A6CD), value);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						result = true;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num3 = 1;
						}
					}
				}
				catch (IOException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (SecurityException)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				catch (UnauthorizedAccessException)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 3:
				ifDCNX0hZLBtVBAkDnl(value, g78M5QxckCuywbLadVO(-1146510045 ^ -1146491819));
				num2 = 2;
				break;
			}
		}
	}

	internal static object g78M5QxckCuywbLadVO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object rUoqgQxzGclTHPL27GV(object P_0, object P_1)
	{
		return ((RegistryKey)P_0).OpenSubKey((string)P_1);
	}

	internal static object la6gqA0Fsr7ZUK8VEpu(object P_0, object P_1)
	{
		return ((RegistryKey)P_0).CreateSubKey((string)P_1);
	}

	internal static object ItQneu0B1bMTsDA1E4R(object P_0)
	{
		return ((RegistryKey)P_0).GetValueNames();
	}

	internal static object A2bBu50WurUfNTjCrdH(object P_0, object P_1, bool P_2)
	{
		return ((RegistryKey)P_0).OpenSubKey((string)P_1, P_2);
	}

	internal static void vyJj0u0occTZVNKGuN2(object P_0, object P_1, object P_2)
	{
		((RegistryKey)P_0).SetValue((string)P_1, P_2);
	}

	internal static void IZtkQR0blxKejh7LSvP(object P_0, object P_1)
	{
		((RegistryKey)P_0).DeleteValue((string)P_1);
	}

	internal static bool cbcbuIxU0sUxFKOwA6g()
	{
		return rarKBUxL5fjKpppf7Pj == null;
	}

	internal static InstallationIdRegistryStorage YKZETuxsQ2IJRsRh242()
	{
		return rarKBUxL5fjKpppf7Pj;
	}

	internal static void ifDCNX0hZLBtVBAkDnl(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}
}
