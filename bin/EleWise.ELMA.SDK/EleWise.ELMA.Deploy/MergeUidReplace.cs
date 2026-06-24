using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy;

internal class MergeUidReplace
{
	private IDictionary<Guid, Guid> uidReplace;

	private static MergeUidReplace bHwFUgE2jnLNjWptqGhS;

	public List<IUidReplaceExtension> UidReplaceExtensions { get; set; }

	public MergeUidReplace()
	{
		//Discarded unreachable code: IL_003a, IL_003f, IL_0088
		YaWCPgE2U22umV0RMCBA();
		uidReplace = new Dictionary<Guid, Guid>();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				if (UidReplaceExtensions != null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			case 2:
				break;
			}
			UidReplaceExtensions = ComponentManager.Current.GetExtensionPoints<IUidReplaceExtension>().ToList();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
			{
				num = 0;
			}
		}
	}

	internal void Init(XmlReader reader)
	{
		//Discarded unreachable code: IL_015f, IL_016e, IL_0205, IL_0244, IL_0253, IL_02f5, IL_0326, IL_0335, IL_0388, IL_0397, IL_03a2, IL_03f3, IL_03fd, IL_04a5, IL_04e5, IL_04f4, IL_0500, IL_0525, IL_0534, IL_05a7, IL_05c6, IL_05f2, IL_0601, IL_06f3, IL_0722, IL_0793
		int num = 2;
		Dictionary<string, Dictionary<string, object>> dictionary = default(Dictionary<string, Dictionary<string, object>>);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		Dictionary<string, object> propValuesR = default(Dictionary<string, object>);
		IEnumerator<IUidReplaceExtension> enumerator = default(IEnumerator<IUidReplaceExtension>);
		IDictionary<Guid, Guid> dictionary2 = default(IDictionary<Guid, Guid>);
		IEnumerator<Guid> enumerator2 = default(IEnumerator<Guid>);
		Guid current = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					dictionary.Add(ConfigurationImportExecutor.XmlProperty, new Dictionary<string, object>());
					num2 = 10;
					continue;
				default:
					IGO6PlEeQT8ZlWpkxpyh(reader);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 39;
					}
					continue;
				case 4:
				case 33:
					if (KdnYK5EeCnGJvaUb89VW(reader) == XmlNodeType.EndElement)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 5;
				case 12:
					if (Guid.TryParse((string)XbV0FyEehZSTmde0Pbll(reader, ASEyVBE2sTjUcT8d8ybj(-1979251663 ^ -1979234733)), out _003C_003Ec__DisplayClass6_.typeUid))
					{
						num2 = 18;
						continue;
					}
					goto default;
				case 6:
					return;
				case 28:
					reader.MoveToContent();
					num2 = 23;
					continue;
				case 25:
					if (reader.IsEmptyElement)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 17;
				case 30:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 9;
					}
					continue;
				case 10:
					dictionary = new EntityXmlSerializer().XmlEntityRead(reader, dictionary, _003C_003Ec__DisplayClass6_.typeUid);
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 40;
					}
					continue;
				case 8:
					dictionary.Add(ConfigurationImportExecutor.RegularProperty, new Dictionary<string, object>());
					num2 = 16;
					continue;
				case 5:
					if (!XtwMRUEeB7XAEdM4FAi0(reader))
					{
						num2 = 27;
						continue;
					}
					goto case 36;
				case 21:
					if (XtwMRUEeB7XAEdM4FAi0(reader))
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 7;
				case 36:
					if (!((string)cZA3agEeWcysTE0LId7v(reader) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16339A25)))
					{
						num2 = 38;
						continue;
					}
					goto case 11;
				case 1:
					return;
				case 32:
					reader.MoveToContent();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					continue;
				case 24:
					return;
				case 37:
					if (!gIdfdPEeF6aHMRFKrG88(reader))
					{
						reader.Read();
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 28;
						}
					}
					else
					{
						num2 = 24;
					}
					continue;
				case 40:
					propValuesR = dictionary[ConfigurationImportExecutor.RegularProperty];
					num2 = 20;
					continue;
				case 26:
					vpJdaaE2zexH4XYxH116(reader);
					num = 14;
					break;
				case 31:
					try
					{
						while (true)
						{
							int num3;
							if (!hLyWCSEeEQEQNg59tIwa(enumerator))
							{
								num3 = 4;
								goto IL_03a6;
							}
							goto IL_053f;
							IL_03a6:
							while (true)
							{
								switch (num3)
								{
								case 2:
									if (dictionary2 == null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 1;
								case 6:
									try
									{
										while (true)
										{
											IL_043e:
											int num4;
											if (!hLyWCSEeEQEQNg59tIwa(enumerator2))
											{
												num4 = 3;
												goto IL_0401;
											}
											goto IL_041b;
											IL_0401:
											while (true)
											{
												switch (num4)
												{
												case 2:
													break;
												default:
													goto IL_043e;
												case 1:
													SetUidReplace(current, dictionary2[current]);
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
													{
														num4 = 0;
													}
													continue;
												case 3:
													goto end_IL_043e;
												}
												break;
											}
											goto IL_041b;
											IL_041b:
											current = enumerator2.Current;
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
											{
												num4 = 1;
											}
											goto IL_0401;
											continue;
											end_IL_043e:
											break;
										}
									}
									finally
									{
										int num5;
										if (enumerator2 == null)
										{
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
											{
												num5 = 1;
											}
											goto IL_04a9;
										}
										goto IL_04bf;
										IL_04bf:
										aHpc5oEefsEwiDfrOiae(enumerator2);
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
										{
											num5 = 1;
										}
										goto IL_04a9;
										IL_04a9:
										switch (num5)
										{
										case 1:
											goto end_IL_0484;
										case 2:
											goto end_IL_0484;
										}
										goto IL_04bf;
										end_IL_0484:;
									}
									break;
								case 3:
									goto IL_053f;
								case 1:
									enumerator2 = dictionary2.Keys.GetEnumerator();
									num3 = 6;
									continue;
								case 4:
									goto end_IL_050a;
								}
								break;
							}
							continue;
							IL_053f:
							dictionary2 = enumerator.Current.Replace(propValuesR);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num3 = 2;
							}
							goto IL_03a6;
							continue;
							end_IL_050a:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num6 = 0;
							}
							goto IL_05ab;
						}
						goto IL_05d0;
						IL_05d0:
						enumerator.Dispose();
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num6 = 1;
						}
						goto IL_05ab;
						IL_05ab:
						switch (num6)
						{
						default:
							goto end_IL_0586;
						case 0:
							goto end_IL_0586;
						case 2:
							break;
						case 1:
							goto end_IL_0586;
						}
						goto IL_05d0;
						end_IL_0586:;
					}
					goto default;
				case 34:
					pJvUQ7EebMwumqp7TRvd(reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951497852));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 7;
					}
					continue;
				case 14:
				case 19:
					Ndaty3EeGOaND3Vf4JSF(reader);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (wnhBDPE2c8wIaaOMkDau(reader, ASEyVBE2sTjUcT8d8ybj(-1334993905 ^ -1335021433)))
					{
						vpJdaaE2zexH4XYxH116(reader);
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 37;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 17:
					vpJdaaE2zexH4XYxH116(reader);
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 31;
					}
					continue;
				case 35:
					if (!m2P4MvEeoW9cskyaukA1(cZA3agEeWcysTE0LId7v(reader), ASEyVBE2sTjUcT8d8ybj(-2099751081 ^ -2099508933)))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 25;
				case 7:
				case 15:
				case 29:
					reader.Skip();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 19;
					}
					continue;
				case 11:
					if (gIdfdPEeF6aHMRFKrG88(reader))
					{
						num = 22;
						break;
					}
					goto case 30;
				case 9:
				case 23:
					if (KdnYK5EeCnGJvaUb89VW(reader) == XmlNodeType.EndElement)
					{
						num2 = 6;
						continue;
					}
					goto case 21;
				case 3:
					dictionary = new Dictionary<string, Dictionary<string, object>>();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 6;
					}
					continue;
				case 13:
					Ndaty3EeGOaND3Vf4JSF(reader);
					num2 = 3;
					continue;
				case 18:
					vpJdaaE2zexH4XYxH116(reader);
					num = 13;
					break;
				case 39:
					Ndaty3EeGOaND3Vf4JSF(reader);
					num2 = 33;
					continue;
				case 20:
					enumerator = UidReplaceExtensions.Where(_003C_003Ec__DisplayClass6_._003CInit_003Eb__0).GetEnumerator();
					num2 = 31;
					continue;
				}
				break;
			}
		}
	}

	private void SetUidReplace(Guid uidFrom, Guid uidTo)
	{
		//Discarded unreachable code: IL_006c, IL_007b, IL_00a3, IL_00b2, IL_00c2, IL_00d1
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 4:
				if (aOGI6vEevtjcN43sbk9v(uidFrom, Guid.Empty))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 3:
				return;
			case 5:
				return;
			case 2:
				uidReplace.Add(uidFrom, uidTo);
				num2 = 6;
				continue;
			case 1:
				return;
			default:
				if (uidReplace.ContainsKey(uidFrom))
				{
					return;
				}
				num2 = 2;
				continue;
			case 7:
				break;
			}
			if (aOGI6vEevtjcN43sbk9v(uidTo, Guid.Empty))
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
			{
				num2 = 0;
			}
		}
	}

	internal Guid GetUidReplace(Guid uidFrom)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return uidFrom;
			case 1:
				if (uidReplace.ContainsKey(uidFrom))
				{
					return uidReplace[uidFrom];
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void YaWCPgE2U22umV0RMCBA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Qdao74E2YR41KaBHn0yF()
	{
		return bHwFUgE2jnLNjWptqGhS == null;
	}

	internal static MergeUidReplace XlbkyBE2Lvps522yGViS()
	{
		return bHwFUgE2jnLNjWptqGhS;
	}

	internal static object ASEyVBE2sTjUcT8d8ybj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool wnhBDPE2c8wIaaOMkDau(object P_0, object P_1)
	{
		return ((XmlReader)P_0).ReadToNextSibling((string)P_1);
	}

	internal static bool vpJdaaE2zexH4XYxH116(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool gIdfdPEeF6aHMRFKrG88(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static bool XtwMRUEeB7XAEdM4FAi0(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object cZA3agEeWcysTE0LId7v(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool m2P4MvEeoW9cskyaukA1(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool pJvUQ7EebMwumqp7TRvd(object P_0, object P_1)
	{
		return ((XmlReader)P_0).MoveToAttribute((string)P_1);
	}

	internal static object XbV0FyEehZSTmde0Pbll(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static XmlNodeType Ndaty3EeGOaND3Vf4JSF(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static bool hLyWCSEeEQEQNg59tIwa(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void aHpc5oEefsEwiDfrOiae(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void IGO6PlEeQT8ZlWpkxpyh(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType KdnYK5EeCnGJvaUb89VW(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool aOGI6vEevtjcN43sbk9v(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
