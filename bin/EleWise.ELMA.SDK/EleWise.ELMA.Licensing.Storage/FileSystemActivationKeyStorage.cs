using System;
using System.Collections.Generic;
using System.IO;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing.Storages;

public class FileSystemActivationKeyStorage : IActivationKeyStorage
{
	private string _path;

	private bool _canRead;

	private bool _canWrite;

	private static FileSystemActivationKeyStorage Ab2WdB0GQB9HSqf9BAY;

	public bool CanRead => _canRead;

	public bool CanWrite => _canWrite;

	public FileSystemActivationKeyStorage(string path)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00c0, IL_00f3, IL_014a, IL_0187, IL_0248, IL_029f, IL_02ae, IL_02f1, IL_0324, IL_037b, IL_038a
		xZw6km0QCEu5HVofb8P();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 4;
		}
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 5:
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num = 1;
				}
				break;
			case 7:
				return;
			case 1:
				try
				{
					GGhEXl0vB4GteRpkmh0(path);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex2)
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 1:
							wEBg5e0CBRa6WtuI9HR(tH1gTX08wPrRQZDr5GQ(), (string)mnNS2F0ZYar4yq4LKan(-1217523399 ^ -1217491551) + path, ex2);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num5 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				goto case 3;
			case 3:
				_canRead = true;
				num = 6;
				break;
			case 6:
				try
				{
					Guid guid = Eg8QRl0uxogAqnaC8e4();
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							text = guid.ToString();
							num2 = 3;
							break;
						case 3:
						{
							object obj = cNCLys0V0swVf7GADYJ(path, NtdZOC0IfsKFByCctQI(text, mnNS2F0ZYar4yq4LKan(-309639236 ^ -309601444)));
							HFq6JI0SlOIUnPhI2bp(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921198001));
							TlUPRU0ibaqCONRCIfn(obj);
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num2 = 0;
							}
							break;
						}
						case 1:
							_canWrite = true;
							num2 = 2;
							break;
						case 2:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							wEBg5e0CBRa6WtuI9HR(tH1gTX08wPrRQZDr5GQ(), NtdZOC0IfsKFByCctQI(mnNS2F0ZYar4yq4LKan(-1921202237 ^ -1921230033), path), ex);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num3 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 2:
				if (!Directory.Exists(path))
				{
					num = 8;
					break;
				}
				goto case 5;
			case 0:
				return;
			case 8:
				try
				{
					Directory.CreateDirectory(path);
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex3)
				{
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							return;
						}
						wEBg5e0CBRa6WtuI9HR(Logger.Log, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138927148) + path, ex3);
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num7 = 1;
						}
					}
				}
				goto case 5;
			case 4:
				if (!string.IsNullOrEmpty(path))
				{
					_path = path;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num = 2;
					}
				}
				else
				{
					num = 7;
				}
				break;
			}
		}
	}

	public Dictionary<Guid, string> GetActivationKeys()
	{
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
		if (!_canRead)
		{
			return dictionary;
		}
		try
		{
			string[] files = Directory.GetFiles(_path);
			foreach (string text in files)
			{
				if (Guid.TryParse(Path.GetFileNameWithoutExtension(Path.GetFileName(text)), out var result))
				{
					try
					{
						dictionary[result] = File.ReadAllText(text);
					}
					catch (Exception exception)
					{
						Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889490414) + text, exception);
					}
				}
			}
			return dictionary;
		}
		catch (Exception exception2)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE64F2) + _path, exception2);
			return dictionary;
		}
	}

	public void AddActivationKey(Guid uid, string key)
	{
		//Discarded unreachable code: IL_004f, IL_0082, IL_00e0
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				if (_canWrite)
				{
					text = (string)cNCLys0V0swVf7GADYJ(_path, NtdZOC0IfsKFByCctQI(uid.ToString(), mnNS2F0ZYar4yq4LKan(0x638095EB ^ 0x6380090B)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
				}
				continue;
			case 3:
				return;
			}
			try
			{
				HFq6JI0SlOIUnPhI2bp(text, key);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			catch (Exception ex)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return;
					}
					wEBg5e0CBRa6WtuI9HR(tH1gTX08wPrRQZDr5GQ(), NtdZOC0IfsKFByCctQI(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195577959), text), ex);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	public void RemoveActivationKey(Guid uid)
	{
		//Discarded unreachable code: IL_00b7, IL_00f7, IL_0122, IL_017a, IL_0189
		int num = 1;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 0:
					return;
				case 1:
					if (!_canWrite)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					try
					{
						int num3;
						if (!WHSVuK0ReKbFooWHZxH(text))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
							{
								num3 = 1;
							}
							goto IL_00bb;
						}
						goto IL_00d1;
						IL_00d1:
						File.Delete(text);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num3 = 0;
						}
						goto IL_00bb;
						IL_00bb:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							return;
						case 2:
							break;
						}
						goto IL_00d1;
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							}
							wEBg5e0CBRa6WtuI9HR(tH1gTX08wPrRQZDr5GQ(), NtdZOC0IfsKFByCctQI(mnNS2F0ZYar4yq4LKan(-787452571 ^ -787418207), text), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num4 = 0;
							}
						}
					}
				}
				break;
			}
			text = (string)cNCLys0V0swVf7GADYJ(_path, NtdZOC0IfsKFByCctQI(uid.ToString(), mnNS2F0ZYar4yq4LKan(-643786247 ^ -643824359)));
			num = 3;
		}
	}

	internal static void xZw6km0QCEu5HVofb8P()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void wEBg5e0CBRa6WtuI9HR(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object GGhEXl0vB4GteRpkmh0(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static object tH1gTX08wPrRQZDr5GQ()
	{
		return Logger.Log;
	}

	internal static object mnNS2F0ZYar4yq4LKan(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid Eg8QRl0uxogAqnaC8e4()
	{
		return Guid.NewGuid();
	}

	internal static object NtdZOC0IfsKFByCctQI(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object cNCLys0V0swVf7GADYJ(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void HFq6JI0SlOIUnPhI2bp(object P_0, object P_1)
	{
		File.WriteAllText((string)P_0, (string)P_1);
	}

	internal static void TlUPRU0ibaqCONRCIfn(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static bool JtQtwg0E3LWhx2Ud7mA()
	{
		return Ab2WdB0GQB9HSqf9BAY == null;
	}

	internal static FileSystemActivationKeyStorage L2x9r10fmyC0aIh4lL5()
	{
		return Ab2WdB0GQB9HSqf9BAY;
	}

	internal static bool WHSVuK0ReKbFooWHZxH(object P_0)
	{
		return File.Exists((string)P_0);
	}
}
