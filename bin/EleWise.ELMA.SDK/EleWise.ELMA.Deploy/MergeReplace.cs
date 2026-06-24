using System;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

public class MergeReplace
{
	private Dictionary<Guid, Guid> uidReplaceMD;

	private Dictionary<Guid, Dictionary<Guid, Guid>> uidReplaceProperty;

	private Dictionary<Guid, Dictionary<string, string>> nameReplaceProperty;

	internal static MergeReplace HkkM1qEpbPCJZxmSUmSn;

	public void SetUidReplaceMD(Guid uidFrom, Guid uidTo)
	{
		//Discarded unreachable code: IL_0071, IL_0143, IL_0194, IL_01a3
		int num = 5;
		Dictionary<string, string> value2 = default(Dictionary<string, string>);
		Dictionary<Guid, Guid> value = default(Dictionary<Guid, Guid>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					nameReplaceProperty.Add(uidTo, value2);
					num2 = 9;
					continue;
				case 11:
					return;
				case 10:
					return;
				default:
					if (uidReplaceProperty.ContainsKey(uidTo))
					{
						num = 3;
						break;
					}
					goto case 2;
				case 5:
					if (uidReplaceMD.ContainsKey(uidFrom))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						uidReplaceMD.Add(uidFrom, uidTo);
						num2 = 13;
					}
					continue;
				case 12:
					if (nameReplaceProperty.ContainsKey(uidTo))
					{
						return;
					}
					num2 = 6;
					continue;
				case 2:
					uidReplaceProperty.Add(uidTo, value);
					num2 = 7;
					continue;
				case 4:
					return;
				case 1:
				case 3:
				case 8:
					if (!nameReplaceProperty.TryGetValue(uidFrom, out value2))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 12;
				case 9:
					nameReplaceProperty.Remove(uidFrom);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					uidReplaceProperty.Remove(uidFrom);
					num = 8;
					break;
				case 13:
					if (!uidReplaceProperty.TryGetValue(uidFrom, out value))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	public Guid GetUidReplaceMD(Guid uidFrom)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (!uidReplaceMD.TryGetValue(uidFrom, out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return value;
			}
			default:
				return uidFrom;
			}
		}
	}

	public void SetUidReplaceProperty(Guid mdUid, Guid uidFrom, Guid uidTo)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_0080, IL_008f
		int num = 4;
		int num2 = num;
		Guid key = default(Guid);
		Dictionary<Guid, Guid> value = default(Dictionary<Guid, Guid>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				return;
			case 2:
				uidReplaceProperty.Add(key, value = new Dictionary<Guid, Guid>());
				num2 = 6;
				break;
			case 1:
			case 6:
				if (value.ContainsKey(uidFrom))
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 7:
				value.Add(uidFrom, uidTo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (uidReplaceProperty.TryGetValue(key, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 4:
				key = GetUidReplaceMD(mdUid);
				num2 = 3;
				break;
			}
		}
	}

	public Guid GetUidReplaceProperty(Guid mdUid, Guid uidFrom)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		Guid value2 = default(Guid);
		Dictionary<Guid, Guid> value = default(Dictionary<Guid, Guid>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return uidFrom;
			case 2:
				return value2;
			case 1:
				if (uidReplaceProperty.TryGetValue(GetUidReplaceMD(mdUid), out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				if (value.TryGetValue(uidFrom, out value2))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public void SetNameReplaceProperty(Guid mdUid, string stringFrom, string stringTo)
	{
		int num = 5;
		int num2 = num;
		Guid key = default(Guid);
		Dictionary<string, string> value = default(Dictionary<string, string>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				key = GetUidReplaceMD(mdUid);
				num2 = 4;
				break;
			case 1:
				if (value.ContainsKey(stringFrom))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				value.Add(stringFrom, stringTo);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			case 3:
				nameReplaceProperty.Add(key, value = new Dictionary<string, string>());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (!nameReplaceProperty.TryGetValue(key, out value))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			}
		}
	}

	public string GetNameReplaceProperty(Guid mdUid, string stringFrom)
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		string value2 = default(string);
		Dictionary<string, string> value = default(Dictionary<string, string>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return stringFrom;
			default:
				return value2;
			case 1:
				if (value.TryGetValue(stringFrom, out value2))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				if (nameReplaceProperty.TryGetValue(GetUidReplaceMD(mdUid), out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public IEnumerable<KeyValuePair<Guid, Guid>> GetAllUidReplaceMd()
	{
		return uidReplaceMD;
	}

	public IEnumerable<KeyValuePair<Guid, Guid>> GetAllUidReplaceProperty()
	{
		return uidReplaceProperty.Values.SelectMany((Dictionary<Guid, Guid> d) => d);
	}

	public MergeReplace()
	{
		//Discarded unreachable code: IL_005a, IL_005f
		NhKlu6EpElLHZhHiXsTY();
		uidReplaceMD = new Dictionary<Guid, Guid>();
		uidReplaceProperty = new Dictionary<Guid, Dictionary<Guid, Guid>>();
		nameReplaceProperty = new Dictionary<Guid, Dictionary<string, string>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pKD03PEphrLvpyPXh06M()
	{
		return HkkM1qEpbPCJZxmSUmSn == null;
	}

	internal static MergeReplace JJ1u0EEpGAK3UBH2lTbL()
	{
		return HkkM1qEpbPCJZxmSUmSn;
	}

	internal static void NhKlu6EpElLHZhHiXsTY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
