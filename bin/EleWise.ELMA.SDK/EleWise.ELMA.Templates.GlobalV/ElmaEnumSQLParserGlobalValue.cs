using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator;

[Component]
public class ElmaEnumSQLParserGlobalValue : ElmaParserGlobalValue
{
	private static ElmaEnumSQLParserGlobalValue nJBrAJBNUhAu4V0xYXrn;

	public override FormatedValue Parse(string[] propertyNames)
	{
		//Discarded unreachable code: IL_0083, IL_00a6, IL_00b5, IL_0176, IL_0180, IL_01c0, IL_01cf, IL_0225, IL_0234, IL_02f3, IL_0302, IL_0381, IL_0390, IL_03c7, IL_03da, IL_03e9, IL_03f9, IL_0408, IL_0536, IL_056e
		int num = 6;
		int num2 = num;
		IMetadataService metadataService = default(IMetadataService);
		Func<IMetadata, bool> func = default(Func<IMetadata, bool>);
		IEnumerator<IMetadata> enumerator = default(IEnumerator<IMetadata>);
		string text2 = default(string);
		List<EnumValueMetadata>.Enumerator enumerator2 = default(List<EnumValueMetadata>.Enumerator);
		FormatedValue result = default(FormatedValue);
		int? intValue = default(int?);
		EnumValueMetadata current2 = default(EnumValueMetadata);
		string value = default(string);
		EnumMetadataType type = default(EnumMetadataType);
		EnumMetadata enumMetadata = default(EnumMetadata);
		string text = default(string);
		IMetadata current = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 5:
			case 9:
				return null;
			case 14:
				metadataService = (IMetadataService)aTcQAZB3ogh2wTs1CYgs();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				if (propertyNames == null)
				{
					num2 = 5;
					break;
				}
				goto case 12;
			case 8:
				if (pLsHOhB3We9UrfctqFfV(CQrkKQB3FpDrvGWE6mSj(propertyNames[0]), J5nlWAB3Bhfrp3yHKX2V(0x6DC147B0 ^ 0x6DC005F0)))
				{
					num2 = 11;
					break;
				}
				goto case 2;
			case 4:
			{
				if (metadataService == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
				IEnumerable<IMetadata> metadataList = metadataService.GetMetadataList();
				func = delegate(IMetadata m)
				{
					//Discarded unreachable code: IL_0060, IL_006f
					int num8 = 1;
					int num9 = num8;
					while (true)
					{
						switch (num9)
						{
						case 2:
							return _003C_003Ec.oIgy6kQKh9pEkXImgJEr((EnumMetadata)m);
						default:
							return false;
						case 1:
							if (!(m is EnumMetadata))
							{
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num9 = 0;
								}
								break;
							}
							goto case 2;
						}
					}
				};
				enumerator = metadataList.GetEnumerator();
				num2 = 3;
				break;
			}
			case 11:
				if (!bCK40OBNziBN8QMP6aFZ(propertyNames[1]))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 2;
			case 13:
				text2 = propertyNames[2];
				num2 = 14;
				break;
			case 7:
				if (!bCK40OBNziBN8QMP6aFZ(propertyNames[0]))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 2;
			case 3:
				try
				{
					while (true)
					{
						IL_04d2:
						int num3;
						if (!LEZvUCB3EEyTYTbtMRb3(enumerator))
						{
							num3 = 8;
							goto IL_0184;
						}
						goto IL_0413;
						IL_0184:
						while (true)
						{
							switch (num3)
							{
							case 4:
								try
								{
									while (true)
									{
										IL_0275:
										int num5;
										if (!enumerator2.MoveNext())
										{
											int num4 = 6;
											num5 = num4;
											goto IL_01de;
										}
										goto IL_0262;
										IL_01de:
										while (true)
										{
											switch (num5)
											{
											case 8:
												return result;
											default:
												intValue = current2.IntValue;
												num5 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
												{
													num5 = 3;
												}
												continue;
											case 4:
												break;
											case 1:
												goto IL_0275;
											case 9:
												value = "";
												num5 = 2;
												continue;
											case 5:
												if ((uint)(type - 1) > 1u)
												{
													num5 = 12;
													continue;
												}
												goto case 7;
											case 2:
												if (type != 0)
												{
													num5 = 5;
													continue;
												}
												goto default;
											case 7:
												value = (string)TeSyfZB3GkgtRcdmKfMs(this, n1aUuQB3hERUUeGBIkLp(current2));
												num5 = 11;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
												{
													num5 = 0;
												}
												continue;
											case 3:
												value = intValue.ToString();
												num5 = 13;
												continue;
											case 10:
												if (pLsHOhB3We9UrfctqFfV(Ecq48dB3b6FoPiyfcCYZ(current2), text2))
												{
													num5 = 6;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
													{
														num5 = 9;
													}
													continue;
												}
												goto IL_0275;
											case 11:
											case 12:
											case 13:
												result = new FormatedValue
												{
													Value = value
												};
												num5 = 8;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
												{
													num5 = 5;
												}
												continue;
											case 6:
												goto end_IL_0275;
											}
											break;
										}
										goto IL_0262;
										IL_0262:
										current2 = enumerator2.Current;
										num5 = 10;
										goto IL_01de;
										continue;
										end_IL_0275:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								goto IL_04d2;
							case 2:
								break;
							case 3:
								if (enumMetadata == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 1;
							case 5:
								enumerator2 = enumMetadata.Values.GetEnumerator();
								num3 = 4;
								continue;
							case 7:
								if (pLsHOhB3We9UrfctqFfV(enumMetadata.Name, text))
								{
									num3 = 9;
									continue;
								}
								goto IL_04d2;
							case 6:
								enumMetadata = current as EnumMetadata;
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num3 = 3;
								}
								continue;
							case 9:
								type = enumMetadata.Type;
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num3 = 5;
								}
								continue;
							default:
								goto IL_04d2;
							case 1:
								if (func(current))
								{
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto IL_04d2;
							case 8:
								goto end_IL_04d2;
							}
							break;
						}
						goto IL_0413;
						IL_0413:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num3 = 6;
						}
						goto IL_0184;
						continue;
						end_IL_04d2:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								joN837B3fMbYPCfXInHO(enumerator);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num7 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 2;
			case 10:
				if (bCK40OBNziBN8QMP6aFZ(propertyNames[2]))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 12:
				if (propertyNames.Count() == 3)
				{
					num2 = 7;
					break;
				}
				goto case 2;
			default:
				text = propertyNames[1];
				num2 = 13;
				break;
			case 1:
				return null;
			}
		}
	}

	public ElmaEnumSQLParserGlobalValue()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		h3AU0EB3QbAtXNDnL8OB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool bCK40OBNziBN8QMP6aFZ(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object CQrkKQB3FpDrvGWE6mSj(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object J5nlWAB3Bhfrp3yHKX2V(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool pLsHOhB3We9UrfctqFfV(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object aTcQAZB3ogh2wTs1CYgs()
	{
		return MetadataServiceContext.ServiceOrNull;
	}

	internal static object Ecq48dB3b6FoPiyfcCYZ(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid n1aUuQB3hERUUeGBIkLp(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object TeSyfZB3GkgtRcdmKfMs(object P_0, Guid guid)
	{
		return ((ElmaParserGlobalValue)P_0).ParseGuid(guid);
	}

	internal static bool LEZvUCB3EEyTYTbtMRb3(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void joN837B3fMbYPCfXInHO(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool eHUc7wBNsSFLDGWdKhis()
	{
		return nJBrAJBNUhAu4V0xYXrn == null;
	}

	internal static ElmaEnumSQLParserGlobalValue MmeWmDBNcBc5Ds65Banp()
	{
		return nJBrAJBNUhAu4V0xYXrn;
	}

	internal static void h3AU0EB3QbAtXNDnL8OB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
