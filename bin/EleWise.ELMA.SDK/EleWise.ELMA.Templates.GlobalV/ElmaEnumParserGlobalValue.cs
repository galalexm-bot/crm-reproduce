using System;
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
public class ElmaEnumParserGlobalValue : ElmaParserGlobalValue
{
	internal static ElmaEnumParserGlobalValue eMQFVRB3CqTsobr3Zcu5;

	public override FormatedValue Parse(string[] propertyNames)
	{
		//Discarded unreachable code: IL_0116, IL_0125, IL_0130, IL_018b, IL_019a, IL_022f, IL_0239, IL_02ea, IL_02f9, IL_0309, IL_0318, IL_0328, IL_0337, IL_0385, IL_0394, IL_0465, IL_0478, IL_049d, IL_04ac, IL_0508, IL_0540, IL_054f, IL_055f, IL_0573, IL_0582, IL_0591, IL_063d, IL_064c
		int num = 15;
		IMetadataService metadataService = default(IMetadataService);
		Func<IMetadata, bool> func = default(Func<IMetadata, bool>);
		IEnumerator<IMetadata> enumerator = default(IEnumerator<IMetadata>);
		List<EnumValueMetadata>.Enumerator enumerator2 = default(List<EnumValueMetadata>.Enumerator);
		EnumMetadata enumMetadata = default(EnumMetadata);
		EnumMetadataType enumMetadataType = default(EnumMetadataType);
		string text3 = default(string);
		IMetadata current2 = default(IMetadata);
		int? intValue = default(int?);
		EnumValueMetadata current = default(EnumValueMetadata);
		string text2 = default(string);
		FormatedValue result = default(FormatedValue);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					if (propertyNames != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 14;
						}
						break;
					}
					goto default;
				case 2:
					if (!cMmHwnB3VgPCRILOlZbw(em1rb2B3uCsoJbBcqeKk(propertyNames[0]), u1xhFaB3Ia4bD1EwmmAu(--1418440330 ^ 0x548AECD8)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 16:
					if (hQCJK7B3ZFpcv7dl7HF6(propertyNames[2]))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 12;
				case 3:
					if (hQCJK7B3ZFpcv7dl7HF6(propertyNames[0]))
					{
						num2 = 13;
						break;
					}
					goto case 2;
				case 10:
				{
					if (metadataService == null)
					{
						goto end_IL_0012;
					}
					IEnumerable<IMetadata> metadataList = metadataService.GetMetadataList();
					func = delegate(IMetadata m)
					{
						//Discarded unreachable code: IL_002d, IL_003c
						int num7 = 2;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							default:
								return _003C_003Ec.lkfVCiQKC7n3fbQq3aRX((EnumMetadata)m);
							case 1:
								return false;
							case 2:
								if (!(m is EnumMetadata))
								{
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
									{
										num8 = 0;
									}
									break;
								}
								goto default;
							}
						}
					};
					enumerator = metadataList.GetEnumerator();
					num2 = 4;
					break;
				}
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_0134;
							}
							goto IL_04b7;
							IL_0134:
							while (true)
							{
								switch (num3)
								{
								case 3:
									enumerator2 = enumMetadata.Values.GetEnumerator();
									num3 = 4;
									continue;
								case 11:
									if (enumMetadata == null)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
										{
											num3 = 9;
										}
										continue;
									}
									goto case 8;
								case 6:
									enumMetadataType = Qy61GCB3R9NA246iEm95(enumMetadata);
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num3 = 3;
									}
									continue;
								case 1:
									if (cMmHwnB3VgPCRILOlZbw(e4BK4cB3ibfDt44Wg5pY(enumMetadata), text3))
									{
										num3 = 6;
										continue;
									}
									break;
								case 5:
									enumMetadata = current2 as EnumMetadata;
									num3 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
									{
										num3 = 5;
									}
									continue;
								case 4:
									try
									{
										while (true)
										{
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 7;
												goto IL_023d;
											}
											goto IL_03d9;
											IL_023d:
											while (true)
											{
												switch (num4)
												{
												case 13:
													intValue = current.IntValue;
													num4 = 5;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
													{
														num4 = 1;
													}
													continue;
												case 1:
												case 8:
													break;
												case 6:
												case 12:
												case 14:
												{
													FormatedValue formatedValue = new FormatedValue();
													RgrMWSB3KKfUTEejinm6(formatedValue, text2);
													result = formatedValue;
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
													{
														num4 = 0;
													}
													continue;
												}
												case 2:
													if (!((string)e4BK4cB3ibfDt44Wg5pY(current) == text))
													{
														num4 = 8;
														continue;
													}
													goto case 10;
												case 9:
													if (enumMetadataType != 0)
													{
														num4 = 4;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
														{
															num4 = 11;
														}
														continue;
													}
													goto case 13;
												case 5:
													text2 = intValue.ToString();
													num4 = 6;
													continue;
												case 10:
													text2 = "";
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
													{
														num4 = 9;
													}
													continue;
												case 4:
													goto IL_03d9;
												case 3:
													text2 = (string)CTY1hhB3qHrtPwZMJVWN(this, current.Uid);
													num4 = 8;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
													{
														num4 = 14;
													}
													continue;
												case 11:
													if ((uint)(enumMetadataType - 1) > 1u)
													{
														num4 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
														{
															num4 = 12;
														}
														continue;
													}
													goto case 3;
												case 7:
													goto end_IL_02a6;
												default:
													return result;
												case 0:
													return result;
												}
												break;
											}
											continue;
											IL_03d9:
											current = enumerator2.Current;
											num4 = 2;
											goto IL_023d;
											continue;
											end_IL_02a6:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
										{
											num5 = 0;
										}
										switch (num5)
										{
										case 0:
											break;
										}
									}
									break;
								case 7:
								case 9:
								case 10:
									break;
								default:
									goto IL_04b7;
								case 8:
									if (!func(current2))
									{
										num3 = 10;
										continue;
									}
									goto case 1;
								case 2:
									goto end_IL_0482;
								}
								break;
							}
							continue;
							IL_04b7:
							current2 = enumerator.Current;
							num3 = 5;
							goto IL_0134;
							continue;
							end_IL_0482:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									Apu1iRB3X4OdYIGG0HoE(enumerator);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto default;
				default:
					return null;
				case 7:
					text = propertyNames[2];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					break;
				case 14:
					if (propertyNames.Count() == 3)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto default;
				case 12:
					text3 = propertyNames[1];
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 4;
					}
					break;
				case 5:
					if (hQCJK7B3ZFpcv7dl7HF6(propertyNames[1]))
					{
						num2 = 8;
						break;
					}
					goto case 16;
				case 1:
					metadataService = (IMetadataService)dlXmL1B3SGoLZLLUqHjc();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 10;
					}
					break;
				case 11:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public ElmaEnumParserGlobalValue()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DI7W9jB3TuACSka2ZaO2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hQCJK7B3ZFpcv7dl7HF6(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object em1rb2B3uCsoJbBcqeKk(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object u1xhFaB3Ia4bD1EwmmAu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool cMmHwnB3VgPCRILOlZbw(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object dlXmL1B3SGoLZLLUqHjc()
	{
		return MetadataServiceContext.ServiceOrNull;
	}

	internal static object e4BK4cB3ibfDt44Wg5pY(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static EnumMetadataType Qy61GCB3R9NA246iEm95(object P_0)
	{
		return ((EnumMetadata)P_0).Type;
	}

	internal static object CTY1hhB3qHrtPwZMJVWN(object P_0, Guid guid)
	{
		return ((ElmaParserGlobalValue)P_0).ParseGuid(guid);
	}

	internal static void RgrMWSB3KKfUTEejinm6(object P_0, object P_1)
	{
		((FormatedValue)P_0).Value = P_1;
	}

	internal static void Apu1iRB3X4OdYIGG0HoE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool F5GYgZB3vnHXPFABJ0JZ()
	{
		return eMQFVRB3CqTsobr3Zcu5 == null;
	}

	internal static ElmaEnumParserGlobalValue DjKxGJB387a5REbiW77k()
	{
		return eMQFVRB3CqTsobr3Zcu5;
	}

	internal static void DI7W9jB3TuACSka2ZaO2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
