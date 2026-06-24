using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing;

public static class ActivationKeyHelper
{
	private class ActivationKeyInfo
	{
		internal static object oCAUuRfrr3KPXqLG9sMo;

		public string ModuleHash
		{
			[CompilerGenerated]
			get
			{
				return _003CModuleHash_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						_003CModuleHash_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public string ActivationKey
		{
			[CompilerGenerated]
			get
			{
				return _003CActivationKey_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CActivationKey_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ActivationKeyInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			V4RyK6frjIXggVZjdl55();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool jn8b1CfrgBj0oBr7541H()
		{
			return oCAUuRfrr3KPXqLG9sMo == null;
		}

		internal static ActivationKeyInfo pak4NCfr5EZtmNW9g5vc()
		{
			return (ActivationKeyInfo)oCAUuRfrr3KPXqLG9sMo;
		}

		internal static void V4RyK6frjIXggVZjdl55()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly ConcurrentDictionary<string, IEnumerable<ActivationKeyInfo>> cache;

	private static ActivationKeyHelper rrrS93ASvMLNPnu9Yfd;

	public static string GetUnitActivationKey(string activationKey, Guid unitUid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		ActivationKeyInfo activationKeyInfo = default(ActivationKeyInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass0_.unitHash = iHCRfGAqHQMrkXpQSyK(unitUid).ToString();
				num2 = 4;
				break;
			case 4:
				activationKeyInfo = GetActivationKeyInfos(activationKey).FirstOrDefault(_003C_003Ec__DisplayClass0_._003CGetUnitActivationKey_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (activationKeyInfo == null)
				{
					num2 = 3;
					break;
				}
				return (string)xHNZ4MAKjAyyLUY6ltA(activationKeyInfo);
			case 2:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return null;
			}
		}
	}

	public static string[] GetUnitActivationKeys(string activationKey, Guid unitUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass1_.unitHash = iHCRfGAqHQMrkXpQSyK(unitUid).ToString();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (from i in GetActivationKeyInfos(activationKey).Where(_003C_003Ec__DisplayClass1_._003CGetUnitActivationKeys_003Eb__0)
					select (string)_003C_003Ec.fUoRsRfgCbCjSxtM8HC6(i)).ToArray();
			}
		}
	}

	public static uint GetUnitHashCode(Guid uid)
	{
		return MF95YnATfcWQAOrefWv(hRoS2EAXnDFt1TLGLtA(uid.GetHashCode()), 0);
	}

	private static IEnumerable<ActivationKeyInfo> GetActivationKeyInfos(object actKey)
	{
		if (actKey != null)
		{
			actKey = ((string)actKey).Trim(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x724795A0).ToCharArray());
		}
		if (string.IsNullOrEmpty((string)actKey) || !((string)actKey).StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B363C3B)))
		{
			return new ActivationKeyInfo[0];
		}
		try
		{
			byte[] array = Convert.FromBase64String(((string)actKey).Substring(3));
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = Convert.ToString(array2[i], 16).ToUpper();
				if (text.Length < 2)
				{
					text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F30673A) + text;
				}
				stringBuilder.Append(text);
			}
			string text2 = stringBuilder.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870909061), "");
			List<ActivationKeyInfo> list = new List<ActivationKeyInfo>();
			string[] array3 = text2.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217493499).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array3.Length; i++)
			{
				string[] array4 = array3[i].Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870862987).ToCharArray());
				list.Add(new ActivationKeyInfo
				{
					ModuleHash = array4[0],
					ActivationKey = array4[1]
				});
			}
			cache[(string)actKey] = list;
			return list;
		}
		catch
		{
			cache[(string)actKey] = new ActivationKeyInfo[0];
			return new ActivationKeyInfo[0];
		}
	}

	static ActivationKeyHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				cache = new ConcurrentDictionary<string, IEnumerable<ActivationKeyInfo>>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				spNbQuAkWYhfyct8dLS();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static uint iHCRfGAqHQMrkXpQSyK(Guid uid)
	{
		return GetUnitHashCode(uid);
	}

	internal static object xHNZ4MAKjAyyLUY6ltA(object P_0)
	{
		return ((ActivationKeyInfo)P_0).ActivationKey;
	}

	internal static bool F6L1DFAidXPoyQ23gif()
	{
		return rrrS93ASvMLNPnu9Yfd == null;
	}

	internal static ActivationKeyHelper Y7o917ARiV6GNFSfIwk()
	{
		return rrrS93ASvMLNPnu9Yfd;
	}

	internal static object hRoS2EAXnDFt1TLGLtA(int P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	internal static uint MF95YnATfcWQAOrefWv(object P_0, int P_1)
	{
		return BitConverter.ToUInt32((byte[])P_0, P_1);
	}

	internal static void spNbQuAkWYhfyct8dLS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
