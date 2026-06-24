using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator;

[Component]
public class ElmaActionParserGlobalValue : ElmaParserGlobalValue
{
	private IRuntimeApplication _provider;

	private IEnumerable<IMetadata> _metadataList;

	private Func<IMetadata, bool> _metadataFilter;

	private string _enumE;

	private string _enumA;

	private static ElmaActionParserGlobalValue m09d2qBNOmlvqthZiCKE;

	private Guid FindEntity(Guid entityGuid)
	{
		//Discarded unreachable code: IL_005e, IL_014a, IL_0159, IL_01fb, IL_022d, IL_02a9, IL_02b3, IL_035b, IL_036a, IL_0394, IL_03a3, IL_03d4, IL_0443, IL_0456, IL_0465, IL_0513, IL_0543, IL_0552, IL_055e, IL_056d
		int num = 1;
		int num2 = num;
		IEnumerator<IMetadata> enumerator = default(IEnumerator<IMetadata>);
		IMetadata current = default(IMetadata);
		Guid result = default(Guid);
		EntityMetadata entityMetadata = default(EntityMetadata);
		Guid guid = default(Guid);
		List<EnumValueMetadata>.Enumerator enumerator2 = default(List<EnumValueMetadata>.Enumerator);
		EnumValueMetadata current2 = default(EnumValueMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = _metadataList.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			default:
				try
				{
					while (true)
					{
						IL_01ad:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num3 = 5;
							}
							goto IL_006c;
						}
						goto IL_00f9;
						IL_00f9:
						current = enumerator.Current;
						num3 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 21;
						}
						goto IL_006c;
						IL_006c:
						while (true)
						{
							int num6;
							switch (num3)
							{
							case 8:
								return result;
							case 5:
								if (((EnumMetadata)vLfqeUBNpYAHTmGvFPOI(entityMetadata)).Values != null)
								{
									num3 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num3 = 11;
									}
									continue;
								}
								goto default;
							case 4:
								break;
							case 16:
								guid = FindEntity(M6xx1wBNtH9F2WRDoWLK(entityMetadata));
								num3 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num3 = 7;
								}
								continue;
							case 10:
								if (!_metadataFilter(current))
								{
									goto IL_01ad;
								}
								num6 = 14;
								goto IL_0068;
							case 3:
								if (!maaSxPBNNlQcVheXglUh(entityGuid, Guid.Empty))
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto case 12;
							case 7:
							case 15:
							case 17:
								goto IL_01ad;
							case 2:
								if (entityMetadata == null)
								{
									goto IL_01ad;
								}
								num6 = 10;
								goto IL_0068;
							case 20:
								result = guid;
								num3 = 8;
								continue;
							case 21:
								entityMetadata = current as EntityMetadata;
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num3 = 0;
								}
								continue;
							case 18:
								enumerator2 = ((EnumMetadata)vLfqeUBNpYAHTmGvFPOI(entityMetadata)).Values.GetEnumerator();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num3 = 1;
								}
								continue;
							default:
								if (!maaSxPBNNlQcVheXglUh(entityMetadata.BaseClassUid, Guid.Empty))
								{
									num3 = 15;
									continue;
								}
								goto case 16;
							case 13:
								if (maaSxPBNNlQcVheXglUh(guid, Guid.Empty))
								{
									num3 = 20;
									continue;
								}
								goto IL_01ad;
							case 1:
								try
								{
									while (true)
									{
										IL_03de:
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
											{
												num4 = 9;
											}
											goto IL_02b7;
										}
										goto IL_031e;
										IL_031e:
										current2 = enumerator2.Current;
										num4 = 5;
										goto IL_02b7;
										IL_02b7:
										while (true)
										{
											switch (num4)
											{
											case 6:
												return result;
											case 3:
												if (L5eV74BN1ygeMG6twHTj(xoF9QwBNaQUp7JqE97WG(current2), _enumA))
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
													{
														num4 = 1;
													}
													continue;
												}
												goto IL_03de;
											case 4:
												break;
											case 1:
												if (_provider == null)
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto case 8;
											case 8:
												if (det8xCBNDwDqyhYFDFq9(_provider) == null)
												{
													num4 = 10;
													continue;
												}
												goto case 7;
											case 5:
												if (current2 != null)
												{
													num4 = 3;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
													{
														num4 = 3;
													}
													continue;
												}
												goto IL_03de;
											default:
												goto IL_03de;
											case 7:
												result = AtPpgWBN3f38yA70oYj0(current2);
												num4 = 6;
												continue;
											case 9:
												goto end_IL_03de;
											}
											break;
										}
										goto IL_031e;
										continue;
										end_IL_03de:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								goto default;
							case 6:
								if (L5eV74BN1ygeMG6twHTj(entityMetadata.Name, _enumE))
								{
									num3 = 19;
									continue;
								}
								goto case 3;
							case 9:
							case 19:
								if (vLfqeUBNpYAHTmGvFPOI(entityMetadata) != null)
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num3 = 5;
									}
									continue;
								}
								goto default;
							case 14:
								if (Amb9DQBNPplwVpRiEAe0(entityGuid, Guid.Empty))
								{
									num3 = 6;
									continue;
								}
								goto case 3;
							case 12:
								if (Amb9DQBNPplwVpRiEAe0(AtPpgWBN3f38yA70oYj0(entityMetadata), entityGuid))
								{
									num3 = 9;
									continue;
								}
								goto IL_01ad;
							case 11:
								goto end_IL_01ad;
								IL_0068:
								num3 = num6;
								continue;
							}
							break;
						}
						goto IL_00f9;
						continue;
						end_IL_01ad:
						break;
					}
				}
				finally
				{
					int num7;
					if (enumerator == null)
					{
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num7 = 0;
						}
						goto IL_0517;
					}
					goto IL_052d;
					IL_052d:
					CwxdWoBNw8NvdP3eZ4qk(enumerator);
					num7 = 2;
					goto IL_0517;
					IL_0517:
					switch (num7)
					{
					case 1:
						goto end_IL_04f2;
					case 2:
						goto end_IL_04f2;
					}
					goto IL_052d;
					end_IL_04f2:;
				}
				break;
			}
			break;
		}
		return Guid.Empty;
	}

	public override FormatedValue Parse(string[] propertyNames)
	{
		//Discarded unreachable code: IL_00b9, IL_00db, IL_00ea, IL_00f9, IL_0233, IL_0246, IL_0255, IL_032c, IL_033b, IL_0385, IL_0394, IL_044c, IL_045b, IL_046a, IL_0507, IL_0542
		int num = 15;
		string enumA = default(string);
		string text = default(string);
		Guid guid = default(Guid);
		IMetadataService metadataService = default(IMetadataService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_enumA = propertyNames[2];
					num2 = 17;
					continue;
				case 9:
					if ((string)Xi2lpuBN6HGHEQyjbEfe(propertyNames[0]) == (string)s34YoeBNHGuxwQgsviIs(0x53FA00CE ^ 0x53FB193A))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 8;
				case 16:
					if (!L5eV74BN1ygeMG6twHTj(enumA, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146558697)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 31;
				case 20:
					if (JT5129BN4FF5VDGXOboO(propertyNames[0]))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 9;
				case 4:
					if (!L5eV74BN1ygeMG6twHTj(enumA, s34YoeBNHGuxwQgsviIs(0x49E27B8A ^ 0x49E238A6)))
					{
						num2 = 21;
						continue;
					}
					goto case 33;
				case 12:
					return null;
				case 15:
					if (propertyNames != null)
					{
						num2 = 14;
						continue;
					}
					goto case 8;
				case 14:
					if (propertyNames.Count() == 3)
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 8;
				case 33:
					text = (string)R6Nw4qBN7xZJ2WcPf6VC(this, DefaultEntityActions.DeleteGuid);
					num = 28;
					break;
				case 3:
					_enumE = propertyNames[1];
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 27:
					if (string.IsNullOrWhiteSpace(propertyNames[2]))
					{
						num2 = 18;
						continue;
					}
					goto case 3;
				default:
					if (!jbfFd9BNxlDVrnJEdO0e(text, ""))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 29;
				case 2:
					enumA = _enumA;
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 31;
					}
					continue;
				case 29:
				{
					FormatedValue formatedValue = new FormatedValue();
					MpehZdBN0tdxCPGH0YsV(formatedValue, text);
					return formatedValue;
				}
				case 24:
					guid = FindEntity(Guid.Empty);
					num2 = 10;
					continue;
				case 34:
					return null;
				case 19:
					metadataService = (IMetadataService)fFsBVLBNAYpFfQfYyOqZ();
					num2 = 37;
					continue;
				case 22:
					if (JT5129BN4FF5VDGXOboO(propertyNames[1]))
					{
						num2 = 30;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 27;
				case 17:
					if (_provider != null)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 34;
				case 11:
					text = "";
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 36:
					if (L5eV74BN1ygeMG6twHTj(enumA, s34YoeBNHGuxwQgsviIs(0x66F566B6 ^ 0x66F524C2)))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 4;
				case 21:
					if (!L5eV74BN1ygeMG6twHTj(enumA, s34YoeBNHGuxwQgsviIs(-1217523399 ^ -1217440995)))
					{
						num2 = 16;
						continue;
					}
					goto case 25;
				case 25:
					text = (string)R6Nw4qBN7xZJ2WcPf6VC(this, DefaultEntityActions.UpdateGuid);
					num2 = 23;
					continue;
				case 10:
					if (!maaSxPBNNlQcVheXglUh(guid, Guid.Empty))
					{
						num2 = 35;
						continue;
					}
					goto case 26;
				case 26:
					text = (string)R6Nw4qBN7xZJ2WcPf6VC(this, guid);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
				case 35:
				{
					FormatedValue formatedValue2 = new FormatedValue();
					MpehZdBN0tdxCPGH0YsV(formatedValue2, text);
					return formatedValue2;
				}
				case 8:
				case 18:
				case 30:
					return null;
				case 31:
					text = (string)R6Nw4qBN7xZJ2WcPf6VC(this, DefaultEntityActions.ViewGuid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
				case 13:
					text = (string)R6Nw4qBN7xZJ2WcPf6VC(this, DefaultEntityActions.CreateGuid);
					num2 = 32;
					continue;
				case 37:
					if (metadataService != null)
					{
						_metadataList = metadataService.GetMetadataList();
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 11;
						}
						continue;
					}
					num = 12;
					break;
				}
				break;
			}
		}
	}

	public ElmaActionParserGlobalValue()
	{
		//Discarded unreachable code: IL_006c, IL_0071
		bUDjqDBNmux3VwGI9Pcb();
		_provider = Locator.GetServiceNotNull<IRuntimeApplication>();
		_metadataFilter = (IMetadata m) => m is EntityMetadata;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Amb9DQBNPplwVpRiEAe0(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool L5eV74BN1ygeMG6twHTj(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool maaSxPBNNlQcVheXglUh(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid AtPpgWBN3f38yA70oYj0(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object vLfqeUBNpYAHTmGvFPOI(object P_0)
	{
		return ((EntityMetadata)P_0).Actions;
	}

	internal static object xoF9QwBNaQUp7JqE97WG(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object det8xCBNDwDqyhYFDFq9(object P_0)
	{
		return ((IRuntimeApplication)P_0).MainProvider;
	}

	internal static Guid M6xx1wBNtH9F2WRDoWLK(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static void CwxdWoBNw8NvdP3eZ4qk(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool toOgoNBN28eoheRFW227()
	{
		return m09d2qBNOmlvqthZiCKE == null;
	}

	internal static ElmaActionParserGlobalValue JXnJZGBNeBX4UtqxUOYk()
	{
		return m09d2qBNOmlvqthZiCKE;
	}

	internal static bool JT5129BN4FF5VDGXOboO(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object Xi2lpuBN6HGHEQyjbEfe(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object s34YoeBNHGuxwQgsviIs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fFsBVLBNAYpFfQfYyOqZ()
	{
		return MetadataServiceContext.ServiceOrNull;
	}

	internal static object R6Nw4qBN7xZJ2WcPf6VC(object P_0, Guid guid)
	{
		return ((ElmaParserGlobalValue)P_0).ParseGuid(guid);
	}

	internal static bool jbfFd9BNxlDVrnJEdO0e(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void MpehZdBN0tdxCPGH0YsV(object P_0, object P_1)
	{
		((FormatedValue)P_0).Value = P_1;
	}

	internal static void bUDjqDBNmux3VwGI9Pcb()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
