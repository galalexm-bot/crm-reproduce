using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Win32;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing.Storages;

public class RegistryActivationKeyStorage : IActivationKeyStorage
{
	private RegistryKey _root;

	private RegistryKey _readKey;

	private RegistryKey _writeKey;

	internal static RegistryActivationKeyStorage gYaFy00TENmwInaaXZW;

	public bool CanRead => _readKey != null;

	public bool CanWrite => _writeKey != null;

	public RegistryActivationKeyStorage(RegistryKey root)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_017e, IL_01d5, IL_022c, IL_0268, IL_0277, IL_02eb, IL_0316, IL_0325, IL_03f1, IL_0448, IL_049f, IL_04db
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		string text = default(string);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				try
				{
					_writeKey = (RegistryKey)YEwTIN01nkIpsegjENA(_root, Ll8ngy0OMhFM4aKwmJf(-538519530 ^ -538556690), true);
					int num6 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						case 2:
							xcjlbI0piDbE7NYL6tV(_writeKey, text);
							num6 = 5;
							break;
						default:
						{
							NrtW2D03NhUjLrdW29c(_writeKey, text, Ll8ngy0OMhFM4aKwmJf(-951514650 ^ -951511446));
							int num7 = 2;
							num6 = num7;
							break;
						}
						case 4:
							text = guid.ToString();
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num6 = 0;
							}
							break;
						case 1:
							guid = cEdrOX0N3pNhFeIam6Z();
							num6 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num6 = 4;
							}
							break;
						case 3:
							if (_writeKey != null)
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num6 = 1;
								}
								break;
							}
							return;
						case 5:
							return;
						}
					}
				}
				catch (IOException)
				{
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
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
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num8 = 0;
						}
					}
				}
				catch (SecurityException)
				{
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num9 = 0;
					}
					while (true)
					{
						switch (num9)
						{
						case 1:
							return;
						}
						_writeKey = null;
						num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num9 = 1;
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
					int num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num10 = 0;
					}
					while (true)
					{
						switch (num10)
						{
						case 1:
							return;
						}
						_writeKey = null;
						num10 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num10 = 1;
						}
					}
				}
			case 4:
				_root = root;
				num = 5;
				break;
			case 3:
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num = 1;
				}
				break;
			case 6:
				return;
			case 2:
				try
				{
					_readKey = (RegistryKey)vuBkME02pl7LNFFlEkk(_root, Ll8ngy0OMhFM4aKwmJf(-97972138 ^ -97939794));
					int num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 2:
							break;
						case 5:
							_readKey = (RegistryKey)Be6hmT0ehIA0RJx8P1S(_root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDC24CA));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num2 = 0;
							}
							continue;
						case 1:
							if (_readKey == null)
							{
								num2 = 5;
								continue;
							}
							break;
						case 4:
							NKEJDN0Pjc9fVJxDyW0(_readKey);
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
							{
								num2 = 2;
							}
							continue;
						default:
							if (_readKey == null)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
								{
									num2 = 2;
								}
								continue;
							}
							goto case 4;
						case 3:
							break;
						}
						break;
					}
				}
				catch (SecurityException)
				{
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							_readKey = null;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (IOException)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
				goto case 3;
			case 5:
				if (_root == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num = 2;
					}
				}
				break;
			case 0:
				return;
			}
		}
	}

	public Dictionary<Guid, string> GetActivationKeys()
	{
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
		if (_readKey == null)
		{
			return dictionary;
		}
		string[] valueNames = _readKey.GetValueNames();
		foreach (string text in valueNames)
		{
			if (!string.IsNullOrEmpty(text) && Guid.TryParse(text, out var result))
			{
				object value = _readKey.GetValue(text);
				if (value is string)
				{
					dictionary[result] = (string)value;
				}
			}
		}
		return dictionary;
	}

	public void AddActivationKey(Guid uid, string key)
	{
		//Discarded unreachable code: IL_005c, IL_008f, IL_00fc, IL_016f, IL_01c6, IL_01d5
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (_writeKey == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				NrtW2D03NhUjLrdW29c(_writeKey, uid.ToString(), key);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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
			catch (IOException exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
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
					((ILogger)USdgu10aCNtkRGCWIfu()).Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC938E), exception);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num4 = 0;
					}
				}
			}
			catch (SecurityException exception2)
			{
				int num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num5 = 0;
				}
				while (true)
				{
					switch (num5)
					{
					case 1:
						return;
					}
					((ILogger)USdgu10aCNtkRGCWIfu()).Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234340314), exception2);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num5 = 1;
					}
				}
			}
			catch (UnauthorizedAccessException ex)
			{
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num6 = 0;
				}
				while (true)
				{
					switch (num6)
					{
					case 1:
						return;
					}
					QHmHXG0DeCmnC8AHldq(USdgu10aCNtkRGCWIfu(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70004458), ex);
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num6 = 0;
					}
				}
			}
		}
	}

	public void RemoveActivationKey(Guid uid)
	{
		//Discarded unreachable code: IL_0086, IL_00ef, IL_015c, IL_01c9, IL_021a, IL_0229
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (_writeKey != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 2:
				return;
			}
			try
			{
				if (XPhBdP0tHGoR6hxICwT(_writeKey, uid.ToString()) == null)
				{
					return;
				}
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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
					_writeKey.DeleteValue(uid.ToString());
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num3 = 1;
					}
				}
			}
			catch (IOException exception)
			{
				int num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						Logger.Log.Error(Ll8ngy0OMhFM4aKwmJf(0x35C0467B ^ 0x35C0D9F3), exception);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			}
			catch (SecurityException exception2)
			{
				int num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num5 = 0;
				}
				while (true)
				{
					switch (num5)
					{
					case 1:
						return;
					}
					((ILogger)USdgu10aCNtkRGCWIfu()).Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A90B4), exception2);
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num5 = 1;
					}
				}
			}
			catch (UnauthorizedAccessException ex)
			{
				int num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num6 = 0;
				}
				while (true)
				{
					switch (num6)
					{
					case 1:
						return;
					}
					QHmHXG0DeCmnC8AHldq(USdgu10aCNtkRGCWIfu(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A77CC2), ex);
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num6 = 1;
					}
				}
			}
		}
	}

	internal static object Ll8ngy0OMhFM4aKwmJf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vuBkME02pl7LNFFlEkk(object P_0, object P_1)
	{
		return ((RegistryKey)P_0).OpenSubKey((string)P_1);
	}

	internal static object Be6hmT0ehIA0RJx8P1S(object P_0, object P_1)
	{
		return ((RegistryKey)P_0).CreateSubKey((string)P_1);
	}

	internal static object NKEJDN0Pjc9fVJxDyW0(object P_0)
	{
		return ((RegistryKey)P_0).GetValueNames();
	}

	internal static object YEwTIN01nkIpsegjENA(object P_0, object P_1, bool P_2)
	{
		return ((RegistryKey)P_0).OpenSubKey((string)P_1, P_2);
	}

	internal static Guid cEdrOX0N3pNhFeIam6Z()
	{
		return Guid.NewGuid();
	}

	internal static void NrtW2D03NhUjLrdW29c(object P_0, object P_1, object P_2)
	{
		((RegistryKey)P_0).SetValue((string)P_1, P_2);
	}

	internal static void xcjlbI0piDbE7NYL6tV(object P_0, object P_1)
	{
		((RegistryKey)P_0).DeleteValue((string)P_1);
	}

	internal static bool ET2qhE0k9EeATqAEuB8()
	{
		return gYaFy00TENmwInaaXZW == null;
	}

	internal static RegistryActivationKeyStorage GQNf8w0n1XXatQphSsx()
	{
		return gYaFy00TENmwInaaXZW;
	}

	internal static object USdgu10aCNtkRGCWIfu()
	{
		return Logger.Log;
	}

	internal static void QHmHXG0DeCmnC8AHldq(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object XPhBdP0tHGoR6hxICwT(object P_0, object P_1)
	{
		return ((RegistryKey)P_0).GetValue((string)P_1);
	}
}
