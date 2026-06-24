using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.XmlSerializers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal static class CacheableXmlSerializer
{
	private static Dictionary<string, EleWise.ELMA.XmlSerializers.XmlSerializer> serializers;

	private static Dictionary<string, Assembly> assemblies;

	private static CacheableXmlSerializer nvehrCBdrUFLTQgtEimw;

	public static EleWise.ELMA.XmlSerializers.XmlSerializer Create(Type type, bool useExtra)
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_012f, IL_013e, IL_0206, IL_02a4, IL_03ae, IL_03bd, IL_040b, IL_041a, IL_0425, IL_0478, IL_04ab, IL_0503, IL_0512, IL_0569, IL_05a1, IL_068f, IL_069e, IL_06aa, IL_06b9, IL_0754, IL_07b2, IL_07dd, IL_08be, IL_08dd, IL_08ec, IL_0919, IL_09d4, IL_09df
		int num = 8;
		int num2 = num;
		Type[] array = default(Type[]);
		Dictionary<string, EleWise.ELMA.XmlSerializers.XmlSerializer> dictionary = default(Dictionary<string, EleWise.ELMA.XmlSerializers.XmlSerializer>);
		bool lockTaken = default(bool);
		EleWise.ELMA.XmlSerializers.XmlSerializer result = default(EleWise.ELMA.XmlSerializers.XmlSerializer);
		EleWise.ELMA.XmlSerializers.XmlSerializer value = default(EleWise.ELMA.XmlSerializers.XmlSerializer);
		Dictionary<string, Assembly> dictionary2 = default(Dictionary<string, Assembly>);
		Type[] types = default(Type[]);
		Type[] array2 = default(Type[]);
		string key = default(string);
		bool lockTaken2 = default(bool);
		string key2 = default(string);
		Assembly value2 = default(Assembly);
		string text3 = default(string);
		string text2 = default(string);
		string text4 = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string text5 = default(string);
		string serializerHashCode = default(string);
		string current = default(string);
		string text = default(string);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 1:
				return new EleWise.ELMA.XmlSerializers.XmlSerializer(type, GetOverrides(new Type[1] { type }, array), array, null, null, null);
			case 9:
				if (!useExtra)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				obj2 = unNqCFBds5AxSA0vlQwW(Coy0hNBdj97c31UViEMh(-1870892489 ^ -1870893211), (array != null) ? array.Length : 0);
				break;
			case 2:
				try
				{
					Monitor.Enter(dictionary, ref lockTaken);
					int num3 = 13;
					while (true)
					{
						switch (num3)
						{
						case 11:
						{
							result = value;
							int num12 = 20;
							num3 = num12;
							break;
						}
						case 16:
							dictionary2 = assemblies;
							num3 = 17;
							break;
						case 22:
							types = new Type[1] { type };
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num3 = 0;
							}
							break;
						case 9:
							array2 = (Type[])M9YpqyBdcVZFRVbJgjUU(QGNJGGBdYKxSrt2Hhq0i());
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
							{
								num3 = 4;
							}
							break;
						case 8:
							if (array2 != null)
							{
								num3 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
								{
									num3 = 4;
								}
								break;
							}
							goto IL_083c;
						case 12:
							serializers[key] = value;
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num3 = 2;
							}
							break;
						case 21:
							try
							{
								Monitor.Enter(dictionary2, ref lockTaken2);
								int num4 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num4 = 9;
								}
								while (true)
								{
									switch (num4)
									{
									case 9:
										if (!assemblies.TryGetValue(key2, out value2))
										{
											int num5 = 3;
											num4 = num5;
											continue;
										}
										break;
									case 1:
										if (!LAqqYYBlouq1seK5jaYT(text3))
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto case 5;
									case 4:
										text3 = (string)EHKdiPBlBuMhX3S901Re(text2, text4);
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
										{
											num4 = 1;
										}
										continue;
									case 3:
										text2 = (string)EHKdiPBlBuMhX3S901Re(uMBberBlFLbwLFS7Ywf1(ComponentManager.Current), Coy0hNBdj97c31UViEMh(-889460160 ^ -889546556));
										num4 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
										{
											num4 = 7;
										}
										continue;
									case 12:
										enumerator = ((IEnumerable<string>)qTpdboBlGYfnahkViKEQ(text2, qhi2f0Bdz10DVJI7pnZN(text5, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105138874)))).Union((IEnumerable<string>)qTpdboBlGYfnahkViKEQ(text2, text5 + (string)Coy0hNBdj97c31UViEMh(-583745292 ^ -583683520))).GetEnumerator();
										num4 = 10;
										continue;
									case 13:
										value2 = GenerateAssembly(text3, types, array);
										num4 = 7;
										continue;
									case 7:
									case 11:
										assemblies[key2] = value2;
										num4 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
										{
											num4 = 14;
										}
										continue;
									case 8:
										serializerHashCode = GetSerializerHashCode(types, array);
										num4 = 6;
										continue;
									case 10:
										try
										{
											while (true)
											{
												int num6;
												if (!B9EwIiBlCqVLTQAItQur(enumerator))
												{
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
													{
														num6 = 0;
													}
													goto IL_0429;
												}
												goto IL_0443;
												IL_0443:
												current = enumerator.Current;
												num6 = 3;
												goto IL_0429;
												IL_0429:
												switch (num6)
												{
												case 1:
													goto IL_0443;
												case 3:
													try
													{
														File.Delete(current);
														int num7 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
														{
															num7 = 0;
														}
														switch (num7)
														{
														case 0:
															break;
														}
													}
													catch (Exception ex)
													{
														int num8 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
														{
															num8 = 0;
														}
														while (true)
														{
															switch (num8)
															{
															default:
																Cim1XCBlQ0vyYpvJKQHj(iNq5MKBlE9GCWkkMZw0v(), PR1RNQBlfKuv0gUi3YSi(Coy0hNBdj97c31UViEMh(0x57A5235E ^ 0x57A45198), current), ex);
																num8 = 0;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
																{
																	num8 = 1;
																}
																continue;
															case 1:
																break;
															}
															break;
														}
													}
													continue;
												case 2:
													continue;
												case 0:
													break;
												}
												break;
											}
										}
										finally
										{
											if (enumerator != null)
											{
												int num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
												{
													num9 = 0;
												}
												while (true)
												{
													switch (num9)
													{
													default:
														dhJ96gBlvRnqWEZeobHV(enumerator);
														num9 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
														{
															num9 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto case 13;
									case 5:
										value2 = (Assembly)EW4UESBlbUOGoX5Pum03(text3);
										num4 = 11;
										continue;
									case 6:
										text4 = (string)WnApWBBlWXK30aZ5LZCx(text5, Coy0hNBdj97c31UViEMh(0x4D1C1EE4 ^ 0x4D1C513A), serializerHashCode, Coy0hNBdj97c31UViEMh(0x53FA00CE ^ 0x53FB4474));
										num4 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
										{
											num4 = 1;
										}
										continue;
									default:
										if (j0ORf9BlhdZmIhB7jNHR(text2))
										{
											num4 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
											{
												num4 = 12;
											}
											continue;
										}
										goto case 13;
									case 14:
										break;
									}
									break;
								}
							}
							finally
							{
								int num10;
								if (!lockTaken2)
								{
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
									{
										num10 = 0;
									}
									goto IL_065f;
								}
								goto IL_0675;
								IL_0675:
								WwhBblBl82jrZS1x0lf8(dictionary2);
								int num11 = 2;
								num10 = num11;
								goto IL_065f;
								IL_065f:
								switch (num10)
								{
								case 1:
									goto end_IL_063a;
								case 2:
									goto end_IL_063a;
								}
								goto IL_0675;
								end_IL_063a:;
							}
							goto case 4;
						case 17:
							lockTaken2 = false;
							num3 = 21;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num3 = 11;
							}
							break;
						case 3:
						case 5:
							text5 = GetXmlSerializerCacheKey(type, array);
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 22;
							}
							break;
						default:
							key2 = (string)qhi2f0Bdz10DVJI7pnZN(text5, text);
							num3 = 2;
							break;
						case 2:
							if (assemblies.TryGetValue(key2, out value2))
							{
								num3 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num3 = 6;
								}
								break;
							}
							goto case 16;
						case 14:
							if (!array2.Contains(type))
							{
								goto IL_083c;
							}
							goto case 10;
						case 4:
						case 15:
							if (tHY3yDBlZaeEtV3umLtK(value2, null))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
								{
									num3 = 1;
								}
								break;
							}
							value = (EleWise.ELMA.XmlSerializers.XmlSerializer)KBsJkgBlueU1YmebJNGa(value2, type);
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num3 = 12;
							}
							break;
						case 13:
							if (serializers.TryGetValue(key, out value))
							{
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num3 = 11;
								}
								break;
							}
							goto case 9;
						case 6:
							types = array2;
							num3 = 19;
							break;
						case 7:
							result = value;
							num3 = 18;
							break;
						case 1:
							throw new InvalidOperationException(SR.T((string)Coy0hNBdj97c31UViEMh(0x7459E02 ^ 0x744ED32), type.FullName));
						case 10:
							text5 = (string)qhi2f0Bdz10DVJI7pnZN(Coy0hNBdj97c31UViEMh(0x35C0467B ^ 0x35C1341B), (array != null) ? Coy0hNBdj97c31UViEMh(-2099751081 ^ -2099698397) : "");
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num3 = 5;
							}
							break;
						case 18:
							return result;
						case 20:
							{
								return result;
							}
							IL_083c:
							num3 = 5;
							break;
						}
					}
				}
				finally
				{
					int num13;
					if (!lockTaken)
					{
						num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num13 = 0;
						}
						goto IL_08c2;
					}
					goto IL_08f7;
					IL_08f7:
					WwhBblBl82jrZS1x0lf8(dictionary);
					num13 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num13 = 0;
					}
					goto IL_08c2;
					IL_08c2:
					switch (num13)
					{
					default:
						goto end_IL_089d;
					case 0:
						goto end_IL_089d;
					case 1:
						break;
					case 2:
						goto end_IL_089d;
					}
					goto IL_08f7;
					end_IL_089d:;
				}
			case 12:
				if (YYgSbLBdUSiovoaHY15s())
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 1;
			default:
				if (serializers.TryGetValue(key, out value))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 10;
					}
				}
				else
				{
					dictionary = serializers;
					num2 = 5;
				}
				continue;
			case 5:
				lockTaken = false;
				num2 = 2;
				continue;
			case 7:
				if (!useExtra)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				obj = kXRA5DBdLVlqunwS15wt(QGNJGGBdYKxSrt2Hhq0i());
				goto IL_0a3b;
			case 3:
				key = type.AssemblyQualifiedName + text;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				obj2 = "";
				break;
			case 11:
				obj = null;
				goto IL_0a3b;
			case 6:
				return result;
			case 10:
				return value;
			case 8:
				{
					Contract.ArgumentNotNull(type, (string)Coy0hNBdj97c31UViEMh(-1459557599 ^ -1459558653));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				IL_0a3b:
				array = (Type[])obj;
				num2 = 12;
				continue;
			}
			text = (string)obj2;
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
			{
				num2 = 2;
			}
		}
	}

	private static string GetXmlSerializerCacheKey(Type type, object extraTypes)
	{
		//Discarded unreachable code: IL_00bd, IL_0129, IL_0138, IL_0144, IL_0153
		int num = 2;
		int num2 = num;
		SHA1 sHA = default(SHA1);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				sHA = SHA1.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return text;
			case 1:
				try
				{
					text = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA1, Type), string>(HR7drMBlIWWf8YsmX5ld(Encoding.UTF8, type.FullName), (sHA, type), GetXmlSerializerCacheKeyAction) + ((extraTypes != null) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538465694) : "");
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => text, 
						_ => text, 
					};
				}
				finally
				{
					int num4;
					if (sHA == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num4 = 0;
						}
						goto IL_00f9;
					}
					goto IL_010f;
					IL_010f:
					((IDisposable)sHA).Dispose();
					int num5 = 2;
					num4 = num5;
					goto IL_00f9;
					IL_00f9:
					switch (num4)
					{
					default:
						goto end_IL_00d4;
					case 1:
						break;
					case 0:
						goto end_IL_00d4;
					case 2:
						goto end_IL_00d4;
					}
					goto IL_010f;
					end_IL_00d4:;
				}
			}
		}
	}

	private static string GetXmlSerializerCacheKeyAction(object buffer, int offset, int length, (SHA1, Type) param)
	{
		var (sHA, type) = param;
		Encoding.UTF8.GetBytes(type.FullName, 0, type.FullName.Length, (byte[])buffer, offset);
		return Convert.ToBase64String(sHA.ComputeHash((byte[])buffer, offset, length)).Replace('/', '#');
	}

	private static string GetSerializerHashCode(object types, object extraTypes)
	{
		//Discarded unreachable code: IL_008a, IL_0125, IL_0186, IL_01fe, IL_0208, IL_02a8, IL_02c7, IL_02d6, IL_02f3, IL_0348, IL_0357, IL_0362, IL_040d, IL_0420, IL_0451, IL_0504, IL_0544, IL_0553, IL_055f, IL_056e, IL_057e, IL_058d, IL_0632, IL_066a, IL_06aa, IL_06b9, IL_06e6, IL_073f, IL_0777, IL_07b3, IL_0814, IL_0883
		int num = 4;
		int num2 = num;
		Type[] array = default(Type[]);
		List<Assembly> list = default(List<Assembly>);
		Type type2 = default(Type);
		int num3 = default(int);
		Type type = default(Type);
		MemoryStream memoryStream = default(MemoryStream);
		List<Assembly>.Enumerator enumerator2 = default(List<Assembly>.Enumerator);
		IEnumerator<string> enumerator3 = default(IEnumerator<string>);
		string current3 = default(string);
		SHA1 sHA = default(SHA1);
		Assembly current2 = default(Assembly);
		Type current = default(Type);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array = (Type[])extraTypes;
				num2 = 22;
				break;
			case 8:
				return text;
			case 13:
				list.Add(type2.Assembly);
				num2 = 10;
				break;
			case 16:
				type2 = array[num3];
				num2 = 21;
				break;
			default:
				type = array[num3];
				num2 = 19;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 10;
				}
				break;
			case 12:
				if (extraTypes != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 5:
				try
				{
					StreamWriter streamWriter = new StreamWriter(memoryStream);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						try
						{
							IEnumerator<Type> enumerator = ((IEnumerable<Type>)types).OrderBy((Type t) => t.AssemblyQualifiedName, (IComparer<string>)wPDgR8BlSCHj9kSF7e0a()).GetEnumerator();
							int num5 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num5 = 10;
							}
							while (true)
							{
								switch (num5)
								{
								case 9:
									enumerator2 = list.GetEnumerator();
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num5 = 2;
									}
									break;
								default:
									cpqaLOBlKXweDpVOtcFU(memoryStream, 0L, SeekOrigin.Begin);
									num5 = 5;
									break;
								case 8:
									try
									{
										while (true)
										{
											int num13;
											if (!B9EwIiBlCqVLTQAItQur(enumerator3))
											{
												num13 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
												{
													num13 = 1;
												}
												goto IL_020c;
											}
											goto IL_024c;
											IL_024c:
											current3 = enumerator3.Current;
											num13 = 3;
											goto IL_020c;
											IL_020c:
											while (true)
											{
												switch (num13)
												{
												case 2:
													goto IL_024c;
												case 3:
													streamWriter.WriteLine(current3);
													num13 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
													{
														num13 = 0;
													}
													continue;
												case 1:
													goto end_IL_0226;
												}
												break;
											}
											continue;
											end_IL_0226:
											break;
										}
									}
									finally
									{
										int num14;
										if (enumerator3 == null)
										{
											num14 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
											{
												num14 = 0;
											}
											goto IL_02ac;
										}
										goto IL_02e1;
										IL_02e1:
										dhJ96gBlvRnqWEZeobHV(enumerator3);
										num14 = 2;
										goto IL_02ac;
										IL_02ac:
										switch (num14)
										{
										default:
											goto end_IL_0287;
										case 0:
											goto end_IL_0287;
										case 1:
											break;
										case 2:
											goto end_IL_0287;
										}
										goto IL_02e1;
										end_IL_0287:;
									}
									goto case 4;
								case 5:
									sHA = (SHA1)ySb47kBlXlsQmARssaHe();
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
									{
										num5 = 7;
									}
									break;
								case 3:
									if (extraTypes == null)
									{
										num5 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
										{
											num5 = 6;
										}
										break;
									}
									goto case 1;
								case 2:
									try
									{
										while (true)
										{
											IL_0380:
											int num11;
											if (!enumerator2.MoveNext())
											{
												num11 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
												{
													num11 = 0;
												}
												goto IL_0366;
											}
											goto IL_03a6;
											IL_03a6:
											current2 = enumerator2.Current;
											num11 = 2;
											goto IL_0366;
											IL_0366:
											while (true)
											{
												switch (num11)
												{
												case 1:
													goto IL_0380;
												case 3:
													goto IL_03a6;
												case 2:
													aJVoqtBliNRtbrhGsbin(streamWriter, IwgmT7BlRssFLeUZB85s(current2));
													num11 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
													{
														num11 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
										int num12 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
										{
											num12 = 0;
										}
										switch (num12)
										{
										case 0:
											break;
										}
									}
									goto case 3;
								case 4:
								case 6:
									TIssitBlqDaBkIVmbNTw(streamWriter);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
									{
										num5 = 0;
									}
									break;
								case 10:
									try
									{
										while (true)
										{
											IL_04c4:
											int num9;
											if (!enumerator.MoveNext())
											{
												int num8 = 2;
												num9 = num8;
												goto IL_045f;
											}
											goto IL_0479;
											IL_045f:
											while (true)
											{
												switch (num9)
												{
												case 3:
													break;
												default:
													aJVoqtBliNRtbrhGsbin(streamWriter, current.FullName);
													num9 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
													{
														num9 = 0;
													}
													continue;
												case 1:
													goto IL_04c4;
												case 2:
													goto end_IL_04c4;
												}
												break;
											}
											goto IL_0479;
											IL_0479:
											current = enumerator.Current;
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
											{
												num9 = 0;
											}
											goto IL_045f;
											continue;
											end_IL_04c4:
											break;
										}
									}
									finally
									{
										int num10;
										if (enumerator == null)
										{
											num10 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
											{
												num10 = 2;
											}
											goto IL_0508;
										}
										goto IL_051e;
										IL_051e:
										dhJ96gBlvRnqWEZeobHV(enumerator);
										num10 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
										{
											num10 = 1;
										}
										goto IL_0508;
										IL_0508:
										switch (num10)
										{
										case 2:
											goto end_IL_04e3;
										case 1:
											goto end_IL_04e3;
										}
										goto IL_051e;
										end_IL_04e3:;
									}
									goto case 9;
								case 1:
									enumerator3 = (from t in (IEnumerable<Type>)extraTypes
										select t.FullName into n
										orderby n
										select n).GetEnumerator();
									num5 = 8;
									break;
								case 7:
									try
									{
										text = (string)iUupafBlkZudIdWlGYq7(Convert.ToBase64String((byte[])Ydd4mhBlTMW2J1NbeYqa(sHA, memoryStream)));
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
										{
											num6 = 0;
										}
										return num6 switch
										{
											0 => text, 
											_ => text, 
										};
									}
									finally
									{
										int num7;
										if (sHA == null)
										{
											num7 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
											{
												num7 = 0;
											}
											goto IL_066e;
										}
										goto IL_0684;
										IL_0684:
										dhJ96gBlvRnqWEZeobHV(sHA);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
										{
											num7 = 0;
										}
										goto IL_066e;
										IL_066e:
										switch (num7)
										{
										default:
											goto end_IL_0649;
										case 2:
											break;
										case 1:
											goto end_IL_0649;
										case 0:
											goto end_IL_0649;
										}
										goto IL_0684;
										end_IL_0649:;
									}
								}
							}
						}
						finally
						{
							if (streamWriter != null)
							{
								int num15 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
								{
									num15 = 1;
								}
								while (true)
								{
									switch (num15)
									{
									case 1:
										((IDisposable)streamWriter).Dispose();
										num15 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
										{
											num15 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num16 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num16 = 1;
						}
						while (true)
						{
							switch (num16)
							{
							case 1:
								dhJ96gBlvRnqWEZeobHV(memoryStream);
								num16 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
								{
									num16 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 19:
				if (!list.Contains(type.Assembly))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 6;
			case 21:
				if (list.Contains(type2.Assembly))
				{
					num2 = 18;
					break;
				}
				goto case 13;
			case 6:
				num3++;
				num2 = 20;
				break;
			case 14:
			case 15:
				if (num3 >= array.Length)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 16;
			case 11:
			case 20:
				if (num3 < array.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 4:
				list = new List<Assembly>();
				num2 = 3;
				break;
			case 2:
				num3 = 0;
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 1;
				}
				break;
			case 22:
				num3 = 0;
				num2 = 11;
				break;
			case 9:
				list.Add(type.Assembly);
				num2 = 6;
				break;
			case 7:
				memoryStream = (MemoryStream)gbnwIHBlVh6EnbniIIK0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 5;
				}
				break;
			case 10:
			case 18:
				num3++;
				num2 = 15;
				break;
			case 3:
				array = (Type[])types;
				num2 = 2;
				break;
			}
		}
	}

	private static EleWise.ELMA.XmlSerializers.XmlAttributeOverrides GetOverrides(object types, IEnumerable<Type> extraTypes)
	{
		_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		List<Type> list = new List<Type>();
		for (int j = 0; j < ((Array)types).Length; j++)
		{
			Type type = (Type)((object[])types)[j];
			if (typeof(IEnumerable).IsAssignableFrom(type) && type.IsGenericType)
			{
				Type @interface = type.GetInterface(typeof(IEnumerable<>).Name);
				if (@interface != null)
				{
					Type item = @interface.GetGenericArguments()[0];
					list.Add(item);
					continue;
				}
			}
			list.Add(type);
		}
		if (extraTypes != null)
		{
			foreach (Type extraType in extraTypes)
			{
				if (!list.Contains(extraType))
				{
					list.Add(extraType);
				}
			}
		}
		CS_0024_003C_003E8__locals0.overrides = new EleWise.ELMA.XmlSerializers.XmlAttributeOverrides();
		list.SelectMany(delegate(Type t)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1();
			CS_0024_003C_003E8__locals0.t = t;
			return from p in CS_0024_003C_003E8__locals0.t.GetReflectionProperties()
				select new
				{
					property = p,
					elementAttribute = AttributeHelper<XmlForceElementAttribute>.GetAttribute(p, inherited: true),
					forceArrayAttribute = AttributeHelper<XmlForceArrayAttribute>.GetAttribute(p, inherited: true),
					defaultValueAttribute = AttributeHelper<ForceDefaultValueAttribute>.GetAttribute(p, inherited: true)
				} into i
				where i.elementAttribute != null || i.forceArrayAttribute != null || i.defaultValueAttribute != null
				select new
				{
					type = CS_0024_003C_003E8__locals0.t,
					property = i.property,
					elementAttribute = i.elementAttribute,
					forceArrayAttribute = i.forceArrayAttribute,
					defaultValueAttribute = i.defaultValueAttribute
				};
		}).Each(i =>
		{
			EleWise.ELMA.XmlSerializers.XmlAttributes xmlAttributes = new EleWise.ELMA.XmlSerializers.XmlAttributes();
			if (i.elementAttribute != null)
			{
				xmlAttributes.XmlElements.Add(i.elementAttribute);
			}
			if (i.forceArrayAttribute != null)
			{
				xmlAttributes.XmlArray = i.forceArrayAttribute;
			}
			if (i.defaultValueAttribute != null)
			{
				xmlAttributes.XmlDefaultValue = i.defaultValueAttribute.Value;
			}
			CS_0024_003C_003E8__locals0.overrides.Add(i.type, i.property.Name, xmlAttributes);
		});
		return CS_0024_003C_003E8__locals0.overrides;
	}

	private static Assembly GenerateAssembly(object assemblyFileName, object types, object extraTypes)
	{
		//Discarded unreachable code: IL_014f, IL_015e, IL_01f2, IL_023b, IL_0317, IL_0494, IL_04c3, IL_054f, IL_058f, IL_059e, IL_05cb, IL_0603, IL_0612, IL_0622, IL_0631, IL_0641, IL_0761, IL_0770, IL_0780
		int num = 17;
		Type type3 = default(Type);
		Type[] array = default(Type[]);
		int num5 = default(int);
		int num8 = default(int);
		EleWise.ELMA.XmlSerializers.XmlTypeMapping xmlTypeMapping = default(EleWise.ELMA.XmlSerializers.XmlTypeMapping);
		EleWise.ELMA.XmlSerializers.XmlReflectionImporter xmlReflectionImporter = default(EleWise.ELMA.XmlSerializers.XmlReflectionImporter);
		Assembly result = default(Assembly);
		List<EleWise.ELMA.XmlSerializers.XmlMapping> list = default(List<EleWise.ELMA.XmlSerializers.XmlMapping>);
		CompilerParameters compilerParameters2 = default(CompilerParameters);
		DateTime dateTime = default(DateTime);
		FileStream fileStream = default(FileStream);
		string text = default(string);
		Type type2 = default(Type);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					type3 = array[num5];
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 19;
					}
					continue;
				case 29:
					num8 = 0;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 27;
					}
					continue;
				case 12:
					array = (Type[])types;
					num = 4;
					break;
				case 19:
					xmlTypeMapping = (EleWise.ELMA.XmlSerializers.XmlTypeMapping)PYPt1UBlOvZoagcP6oEZ(xmlReflectionImporter, type3, null, null);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					throw new ArgumentNullException((string)Coy0hNBdj97c31UViEMh(0x7247028A ^ 0x72470EA8));
				case 16:
					if (((Array)types).Length != 0)
					{
						num2 = 24;
						continue;
					}
					goto case 25;
				default:
					ns0kPTBlncfruGigfpj3(xmlReflectionImporter, (Type)((object[])extraTypes)[num8]);
					num2 = 26;
					continue;
				case 23:
					result = (Assembly)msh3O0BlpHN5IKrNWxDR(types, list.ToArray(), compilerParameters2);
					num2 = 22;
					continue;
				case 18:
					dateTime = o3xeYlBl3hDoaAIFNBSh();
					num2 = 23;
					continue;
				case 22:
					fileStream = (FileStream)x2MwQfBla6Pd5WIIGxwv(Path.ChangeExtension((string)assemblyFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088374722)));
					num2 = 20;
					continue;
				case 8:
					text = (string)AUs90SBleHgLjmXyOA92(assemblyFileName);
					num2 = 7;
					continue;
				case 20:
					try
					{
						StreamWriter streamWriter = new StreamWriter(fileStream);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								aJVoqtBliNRtbrhGsbin(streamWriter, unNqCFBds5AxSA0vlQwW(Coy0hNBdj97c31UViEMh(-561074844 ^ -560996720), o3xeYlBl3hDoaAIFNBSh()));
								int num4 = 12;
								while (true)
								{
									switch (num4)
									{
									case 15:
										type2 = array[num5];
										num4 = 21;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
										{
											num4 = 6;
										}
										break;
									case 3:
										array = (Type[])extraTypes;
										num4 = 16;
										break;
									case 19:
										num5++;
										num4 = 18;
										break;
									case 7:
										if (((Array)extraTypes).Length != 0)
										{
											num4 = 4;
											break;
										}
										return result;
									case 4:
										jmjb4sBlwj2hF786x8x8(streamWriter);
										num4 = 22;
										break;
									case 16:
										num5 = 0;
										num4 = 9;
										break;
									default:
										jmjb4sBlwj2hF786x8x8(streamWriter);
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
										{
											num4 = 1;
										}
										break;
									case 22:
										aJVoqtBliNRtbrhGsbin(streamWriter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108722578));
										num4 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
										{
											num4 = 0;
										}
										break;
									case 6:
										num5++;
										num4 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
										{
											num4 = 5;
										}
										break;
									case 14:
									case 18:
										if (num5 >= array.Length)
										{
											num4 = 11;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
											{
												num4 = 10;
											}
											break;
										}
										goto case 10;
									case 1:
										aJVoqtBliNRtbrhGsbin(streamWriter, Coy0hNBdj97c31UViEMh(-951514650 ^ -951550558));
										num4 = 17;
										break;
									case 13:
										aJVoqtBliNRtbrhGsbin(streamWriter, type.AssemblyQualifiedName);
										num4 = 19;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
										{
											num4 = 0;
										}
										break;
									case 21:
										aJVoqtBliNRtbrhGsbin(streamWriter, type2.AssemblyQualifiedName);
										num4 = 6;
										break;
									case 10:
										type = array[num5];
										num4 = 13;
										break;
									case 5:
									case 9:
										if (num5 >= array.Length)
										{
											num4 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
											{
												num4 = 8;
											}
											break;
										}
										goto case 15;
									case 17:
										array = (Type[])types;
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
										{
											num4 = 2;
										}
										break;
									case 2:
										num5 = 0;
										num4 = 11;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
										{
											num4 = 14;
										}
										break;
									case 11:
										if (extraTypes == null)
										{
											num4 = 20;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
											{
												num4 = 14;
											}
											break;
										}
										goto case 7;
									case 12:
										aJVoqtBliNRtbrhGsbin(streamWriter, peVDE9BltfyWJARQtui7(Coy0hNBdj97c31UViEMh(-281842504 ^ -281929554), (int)TAkpgLBlDrMcW9CH2Uqt(o3xeYlBl3hDoaAIFNBSh(), dateTime).TotalMilliseconds, Coy0hNBdj97c31UViEMh(-978351861 ^ -978387657)));
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
										{
											num4 = 0;
										}
										break;
									case 8:
										return result;
									case 20:
										return result;
									}
								}
							}
							finally
							{
								int num6;
								if (streamWriter == null)
								{
									num6 = 2;
									goto IL_0553;
								}
								goto IL_0569;
								IL_0553:
								switch (num6)
								{
								case 2:
									goto end_IL_053e;
								case 1:
									goto end_IL_053e;
								}
								goto IL_0569;
								IL_0569:
								dhJ96gBlvRnqWEZeobHV(streamWriter);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num6 = 0;
								}
								goto IL_0553;
								end_IL_053e:;
							}
						}
					}
					finally
					{
						if (fileStream != null)
						{
							int num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num7 = 1;
							}
							while (true)
							{
								switch (num7)
								{
								case 1:
									dhJ96gBlvRnqWEZeobHV(fileStream);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
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
				case 26:
					num8++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 15;
					}
					continue;
				case 3:
				case 5:
					if (num5 >= array.Length)
					{
						num2 = 8;
						continue;
					}
					goto case 28;
				case 21:
					list = new List<EleWise.ELMA.XmlSerializers.XmlMapping>();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 9;
					}
					continue;
				case 15:
				case 27:
					if (num8 >= ((Array)extraTypes).Length)
					{
						num2 = 21;
						continue;
					}
					goto default;
				case 30:
					list.Add(xmlTypeMapping);
					num2 = 10;
					continue;
				case 4:
					num5 = 0;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					return result;
				case 11:
					rZgj9fBlPQWI3PuHkvRO(text);
					num2 = 2;
					continue;
				case 17:
					if (types != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 1;
				case 7:
					if (j0ORf9BlhdZmIhB7jNHR(text))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 11;
				case 6:
					WBwj8tBl2rLgXvGpDAnF(xmlTypeMapping, type3.FullName);
					num = 30;
					break;
				case 10:
					num5++;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 25:
					throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FB737E));
				case 24:
					xmlReflectionImporter = new EleWise.ELMA.XmlSerializers.XmlReflectionImporter(GetOverrides(types, (IEnumerable<Type>)extraTypes), null);
					num2 = 13;
					continue;
				case 13:
					if (extraTypes != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 21;
				case 2:
				case 9:
				{
					CompilerParameters compilerParameters = new CompilerParameters();
					FVJcYEBl1BvB5iyV2Gxj(compilerParameters, false);
					paI3q1BlNyKXddlyQ5pp(compilerParameters, assemblyFileName);
					compilerParameters2 = compilerParameters;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 1;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	private static EleWise.ELMA.XmlSerializers.XmlSerializer Create(object asm, Type type)
	{
		return (EleWise.ELMA.XmlSerializers.XmlSerializer)gr1xFVBlHsBhshVc3dEj(Kc0AJLBl6bBArH8gscno(zH77UnBl4rZtcACFr5fI(asm)), type.FullName);
	}

	private static EleWise.ELMA.XmlSerializers.XmlSerializerImplementation GetContract(object assembly)
	{
		return (EleWise.ELMA.XmlSerializers.XmlSerializerImplementation)LB0BQpBl770wx1XOWxjT(gpbXjeBlAjXtJFEjNMLJ(assembly, Coy0hNBdj97c31UViEMh(0x17ADCCD8 ^ 0x17ACB8A2)));
	}

	private static Type GetTypeFromAssembly(object assembly, object typeName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				typeName = qhi2f0Bdz10DVJI7pnZN(Coy0hNBdj97c31UViEMh(-2112703338 ^ -2112634818), typeName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				Type type = m6kbwWBlxOVyHEOujuSg(assembly, typeName);
				if (LPJFKdBl03vfKnMbhvV8(type, null))
				{
					throw new InvalidOperationException((string)h1QfPfBlyJoEVEHVfM7g(Coy0hNBdj97c31UViEMh(--1360331293 ^ 0x51147715), typeName, SHw9wABlmEwZv0AyxrZm(assembly)));
				}
				return type;
			}
			}
		}
	}

	static CacheableXmlSerializer()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				assemblies = new Dictionary<string, Assembly>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				pGbkVFBlMfV6yvnAcFsE();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				serializers = new Dictionary<string, EleWise.ELMA.XmlSerializers.XmlSerializer>();
				num2 = 3;
				break;
			}
		}
	}

	internal static object Coy0hNBdj97c31UViEMh(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QGNJGGBdYKxSrt2Hhq0i()
	{
		return ComponentManager.Current;
	}

	internal static object kXRA5DBdLVlqunwS15wt(object P_0)
	{
		return ((ComponentManager)P_0).GetXsiTypes();
	}

	internal static bool YYgSbLBdUSiovoaHY15s()
	{
		return ComponentManager.Initialized;
	}

	internal static object unNqCFBds5AxSA0vlQwW(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object M9YpqyBdcVZFRVbJgjUU(object P_0)
	{
		return ((ComponentManager)P_0).GetXsiRoots();
	}

	internal static object qhi2f0Bdz10DVJI7pnZN(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object uMBberBlFLbwLFS7Ywf1(object P_0)
	{
		return ((ComponentManager)P_0).WorkDirectory;
	}

	internal static object EHKdiPBlBuMhX3S901Re(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object WnApWBBlWXK30aZ5LZCx(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static bool LAqqYYBlouq1seK5jaYT(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object EW4UESBlbUOGoX5Pum03(object P_0)
	{
		return Assembly.LoadFrom((string)P_0);
	}

	internal static bool j0ORf9BlhdZmIhB7jNHR(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object qTpdboBlGYfnahkViKEQ(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static object iNq5MKBlE9GCWkkMZw0v()
	{
		return Logger.Log;
	}

	internal static object PR1RNQBlfKuv0gUi3YSi(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void Cim1XCBlQ0vyYpvJKQHj(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool B9EwIiBlCqVLTQAItQur(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void dhJ96gBlvRnqWEZeobHV(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void WwhBblBl82jrZS1x0lf8(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool tHY3yDBlZaeEtV3umLtK(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object KBsJkgBlueU1YmebJNGa(object P_0, Type type)
	{
		return Create(P_0, type);
	}

	internal static bool AJ8MbRBdgvqmPc2ihAW6()
	{
		return nvehrCBdrUFLTQgtEimw == null;
	}

	internal static CacheableXmlSerializer ES4cDfBd5gPKlK43MXqy()
	{
		return nvehrCBdrUFLTQgtEimw;
	}

	internal static int HR7drMBlIWWf8YsmX5ld(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetByteCount((string)P_1);
	}

	internal static object gbnwIHBlVh6EnbniIIK0()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object wPDgR8BlSCHj9kSF7e0a()
	{
		return StringComparer.InvariantCulture;
	}

	internal static void aJVoqtBliNRtbrhGsbin(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static object IwgmT7BlRssFLeUZB85s(object P_0)
	{
		return AssemblyInfoCache.EvaluateHashCode((Assembly)P_0);
	}

	internal static void TIssitBlqDaBkIVmbNTw(object P_0)
	{
		((TextWriter)P_0).Flush();
	}

	internal static long cpqaLOBlKXweDpVOtcFU(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static object ySb47kBlXlsQmARssaHe()
	{
		return SHA1.Create();
	}

	internal static object Ydd4mhBlTMW2J1NbeYqa(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static object iUupafBlkZudIdWlGYq7(object P_0)
	{
		return ((string)P_0).Base64StringToValidFileName();
	}

	internal static void ns0kPTBlncfruGigfpj3(object P_0, Type P_1)
	{
		((EleWise.ELMA.XmlSerializers.XmlReflectionImporter)P_0).IncludeType(P_1);
	}

	internal static object PYPt1UBlOvZoagcP6oEZ(object P_0, Type P_1, object P_2, object P_3)
	{
		return ((EleWise.ELMA.XmlSerializers.XmlReflectionImporter)P_0).ImportTypeMapping(P_1, (XmlRootAttribute)P_2, (string)P_3);
	}

	internal static void WBwj8tBl2rLgXvGpDAnF(object P_0, object P_1)
	{
		((EleWise.ELMA.XmlSerializers.XmlMapping)P_0).SetKey((string)P_1);
	}

	internal static object AUs90SBleHgLjmXyOA92(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object rZgj9fBlPQWI3PuHkvRO(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static void FVJcYEBl1BvB5iyV2Gxj(object P_0, bool P_1)
	{
		((CompilerParameters)P_0).GenerateInMemory = P_1;
	}

	internal static void paI3q1BlNyKXddlyQ5pp(object P_0, object P_1)
	{
		((CompilerParameters)P_0).OutputAssembly = (string)P_1;
	}

	internal static DateTime o3xeYlBl3hDoaAIFNBSh()
	{
		return DateTime.Now;
	}

	internal static object msh3O0BlpHN5IKrNWxDR(object P_0, object P_1, object P_2)
	{
		return EleWise.ELMA.XmlSerializers.XmlSerializer.GenerateSerializer((Type[])P_0, (EleWise.ELMA.XmlSerializers.XmlMapping[])P_1, (CompilerParameters)P_2);
	}

	internal static object x2MwQfBla6Pd5WIIGxwv(object P_0)
	{
		return File.Create((string)P_0);
	}

	internal static TimeSpan TAkpgLBlDrMcW9CH2Uqt(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static object peVDE9BltfyWJARQtui7(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static void jmjb4sBlwj2hF786x8x8(object P_0)
	{
		((TextWriter)P_0).WriteLine();
	}

	internal static object zH77UnBl4rZtcACFr5fI(object P_0)
	{
		return GetContract(P_0);
	}

	internal static object Kc0AJLBl6bBArH8gscno(object P_0)
	{
		return ((EleWise.ELMA.XmlSerializers.XmlSerializerImplementation)P_0).TypedSerializers;
	}

	internal static object gr1xFVBlHsBhshVc3dEj(object P_0, object P_1)
	{
		return ((Hashtable)P_0)[P_1];
	}

	internal static Type gpbXjeBlAjXtJFEjNMLJ(object P_0, object P_1)
	{
		return GetTypeFromAssembly(P_0, P_1);
	}

	internal static object LB0BQpBl770wx1XOWxjT(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static Type m6kbwWBlxOVyHEOujuSg(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool LPJFKdBl03vfKnMbhvV8(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object SHw9wABlmEwZv0AyxrZm(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static object h1QfPfBlyJoEVEHVfM7g(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void pGbkVFBlMfV6yvnAcFsE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
