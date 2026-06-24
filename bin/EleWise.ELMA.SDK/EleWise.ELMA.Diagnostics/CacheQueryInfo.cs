using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
public abstract class CacheQueryInfo : AbstractCallInfo, IEmptyCallInfo
{
	private static CacheQueryInfo J0tNu5EBfyT0wZonbHe0;

	public string Operation
	{
		[CompilerGenerated]
		get
		{
			return _003COperation_003Ek__BackingField;
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
					_003COperation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Region
	{
		[CompilerGenerated]
		get
		{
			return _003CRegion_003Ek__BackingField;
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
					_003CRegion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
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

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return _003CKey_003Ek__BackingField;
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
					_003CKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string CallType => (string)YrThY6EB8RwxAEDR2Yec(aEyB2REBvcHNGhmnhBhI(-1858887263 ^ -1858631389), (!string.IsNullOrEmpty(Operation)) ? YrThY6EB8RwxAEDR2Yec(aEyB2REBvcHNGhmnhBhI(-398663332 ^ -398656616), Operation) : "");

	public override string Description
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c, IL_0051
			int num = 2;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				default:
					obj = "";
					break;
				case 2:
					if (!string.IsNullOrEmpty(Region))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 1:
					obj = GGyoXDEBZ1MBoghNW7hq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4264C4E1), Region, aEyB2REBvcHNGhmnhBhI(0x12441CA4 ^ 0x12403434));
					break;
				}
				break;
			}
			return (string)obj + Key;
		}
	}

	public bool IsEmpty
	{
		[CompilerGenerated]
		get
		{
			return _003CIsEmpty_003Ek__BackingField;
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
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
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

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_005f, IL_013b, IL_014a
		int num = 8;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (!o95LdnEBubVXP1WT6DGG(Operation))
					{
						num2 = 7;
						break;
					}
					goto case 1;
				case 6:
					return;
				case 4:
					return;
				case 2:
				case 3:
					if (o95LdnEBubVXP1WT6DGG(Key))
					{
						goto end_IL_0012;
					}
					goto case 5;
				default:
					SNZhVdEBI4GjI09dvUru(info, aEyB2REBvcHNGhmnhBhI(0x463A0F3C ^ 0x463E2792), Region);
					num2 = 3;
					break;
				case 5:
					info.AddValue((string)aEyB2REBvcHNGhmnhBhI(--1333735954 ^ 0x4F7F9458), Key);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (o95LdnEBubVXP1WT6DGG(Region))
					{
						num2 = 2;
						break;
					}
					goto default;
				case 7:
					SNZhVdEBI4GjI09dvUru(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51112A85), Operation);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	protected CacheQueryInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		v6AAjREBVpxoNqorS4Uj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YXJG7BEBQjEOp9NfPpva()
	{
		return J0tNu5EBfyT0wZonbHe0 == null;
	}

	internal static CacheQueryInfo zedXecEBCRALXwfCE6LN()
	{
		return J0tNu5EBfyT0wZonbHe0;
	}

	internal static object aEyB2REBvcHNGhmnhBhI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YrThY6EB8RwxAEDR2Yec(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object GGyoXDEBZ1MBoghNW7hq(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool o95LdnEBubVXP1WT6DGG(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static void SNZhVdEBI4GjI09dvUru(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void v6AAjREBVpxoNqorS4Uj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
