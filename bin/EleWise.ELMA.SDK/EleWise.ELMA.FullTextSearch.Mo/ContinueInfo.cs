using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Model;

internal class ContinueInfo
{
	public class PageInfo
	{
		internal static PageInfo b5NUZ4vcQ4dAgTilH86g;

		public int Attempt
		{
			[CompilerGenerated]
			get
			{
				return _003CAttempt_003Ek__BackingField;
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
						_003CAttempt_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public int? Page { get; internal set; }

		public long? LastId { get; internal set; }

		public PageInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool vQ5sEMvcC7wWbsNRWFtN()
		{
			return b5NUZ4vcQ4dAgTilH86g == null;
		}

		internal static PageInfo gxWxTYvcvdYTYYDCmcEU()
		{
			return b5NUZ4vcQ4dAgTilH86g;
		}
	}

	public const string PageChar = "p";

	public const string LastIdChar = "i";

	public const string AttemptChar = "a";

	private readonly Dictionary<Guid, PageInfo> pagesInfo;

	private static ContinueInfo aqXCNxGRiTxLA4hCqcAI;

	public Dictionary<Guid, PageInfo> PagesInfo => pagesInfo;

	public void PrepareEmptyPages()
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_0260, IL_0298
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		KeyValuePair<Type, Guid> keyValuePair = default(KeyValuePair<Type, Guid>);
		_003C_003Ec__DisplayClass0_1 _003C_003Ec__DisplayClass0_2 = default(_003C_003Ec__DisplayClass0_1);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
			{
				List<IModuleFullTextSearchExtension> list = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>().ToList();
				_003C_003Ec__DisplayClass0_.typePairs = new List<KeyValuePair<Type, Guid>>();
				list.ForEach(_003C_003Ec__DisplayClass0_._003CPrepareEmptyPages_003Eb__0);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 4:
				try
				{
					while (true)
					{
						int num4;
						if (!r0NCXkGRXbV0CI6QjxVJ(enumerator))
						{
							int num3 = 9;
							num4 = num3;
							goto IL_00bd;
						}
						goto IL_01ae;
						IL_00bd:
						while (true)
						{
							switch (num4)
							{
							case 9:
								return;
							case 8:
								keyValuePair = _003C_003Ec__DisplayClass0_.typePairs.First(_003C_003Ec__DisplayClass0_2._003CPrepareEmptyPages_003Eb__4);
								num4 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num4 = 2;
								}
								continue;
							case 5:
								guid = Guid.Empty;
								num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num4 = 2;
								}
								continue;
							case 6:
								PagesInfo.Add(guid, new PageInfo());
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num4 = 0;
								}
								continue;
							case 3:
								guid = keyValuePair.Value;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								break;
							case 7:
								goto IL_01ae;
							case 4:
								if (_003C_003Ec__DisplayClass0_.typePairs.Any(_003C_003Ec__DisplayClass0_2._003CPrepareEmptyPages_003Eb__3))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num4 = 8;
									}
									continue;
								}
								goto default;
							default:
								if (qivIgZGRK54qbGj3SeR3(guid, Guid.Empty))
								{
									num4 = 6;
									continue;
								}
								break;
							case 1:
								_003C_003Ec__DisplayClass0_2.type = enumerator.Current;
								num4 = 5;
								continue;
							}
							break;
						}
						continue;
						IL_01ae:
						_003C_003Ec__DisplayClass0_2 = new _003C_003Ec__DisplayClass0_1();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num4 = 0;
						}
						goto IL_00bd;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								ztWMu8GRTBBDdDpyEDvH(enumerator);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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
				}
			case 2:
				enumerator = (from t in _003C_003Ec__DisplayClass0_.typePairs.Select((KeyValuePair<Type, Guid> p) => p.Key).ToList()
					where _003C_003Ec.CQjv1Wvck1Ze66pDQv6L(t, null)
					select t).Distinct().GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void AddPageInfo(Guid typeUid, int pageIndex, int attempt)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				if (NxEvLxGRktKcIatIfUCL(typeUid, Guid.Empty))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			Dictionary<Guid, PageInfo> dictionary = pagesInfo;
			PageInfo obj = new PageInfo
			{
				Page = pageIndex
			};
			r4qr9FGRnCv2VyBN4lDP(obj, attempt);
			dictionary[typeUid] = obj;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
			{
				num2 = 2;
			}
		}
	}

	public void AddIdInfo(Guid typeUid, long lastId, int attempt)
	{
		//Discarded unreachable code: IL_008a, IL_0099
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				pagesInfo[typeUid] = new PageInfo
				{
					LastId = lastId,
					Attempt = attempt
				};
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (typeUid == Guid.Empty)
				{
					return;
				}
				num2 = 2;
				break;
			case 1:
				return;
			}
		}
	}

	public void RemovePageInfo(Guid typeUid)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!NxEvLxGRktKcIatIfUCL(typeUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			case 3:
				return;
			default:
				pagesInfo.Remove(typeUid);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public ContinueInfo()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		pagesInfo = new Dictionary<Guid, PageInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qivIgZGRK54qbGj3SeR3(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool r0NCXkGRXbV0CI6QjxVJ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void ztWMu8GRTBBDdDpyEDvH(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool tVBXBfGRRAvDLsvDCl9S()
	{
		return aqXCNxGRiTxLA4hCqcAI == null;
	}

	internal static ContinueInfo q7TcpxGRqAtHSds9C2uu()
	{
		return aqXCNxGRiTxLA4hCqcAI;
	}

	internal static bool NxEvLxGRktKcIatIfUCL(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void r4qr9FGRnCv2VyBN4lDP(object P_0, int value)
	{
		((PageInfo)P_0).Attempt = value;
	}
}
