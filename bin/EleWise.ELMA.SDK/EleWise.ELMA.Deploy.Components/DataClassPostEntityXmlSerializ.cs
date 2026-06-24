using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Components;

[Component]
[Obsolete("Временное решение сериализации для экспорта-импорта. Удалить при решении ELMA-29857")]
internal sealed class DataClassPostEntityXmlSerializer : PostEntityXmlSerializer
{
	private class TypeRefReWriter : XmlStreamingEditorBase
	{
		internal static object CPvqPw8mpwsV2FWOjqrs;

		public TypeRefReWriter(XmlReader reader, XmlWriter writer)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			sNDe438mtMIqg0c0GvXx();
			base._002Ector(reader, writer);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		protected override void TransformElement(XmlReader reader, XmlWriter writer)
		{
		}

		protected override bool ShouldTransformElement(XmlReader reader)
		{
			return IcQoC28m6oZpfVBX91lY(pFfWwG8mwDSR1QFwUT47(reader), PoSZda8m4ux0uHx8moMH(0x4785BC0D ^ 0x4783B645));
		}

		internal static void sNDe438mtMIqg0c0GvXx()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool iNlBrj8ma0VdyInYk7Tj()
		{
			return CPvqPw8mpwsV2FWOjqrs == null;
		}

		internal static TypeRefReWriter R5ts348mDbhq71KmrvdB()
		{
			return (TypeRefReWriter)CPvqPw8mpwsV2FWOjqrs;
		}

		internal static object pFfWwG8mwDSR1QFwUT47(object P_0)
		{
			return ((XmlReader)P_0).Name;
		}

		internal static object PoSZda8m4ux0uHx8moMH(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool IcQoC28m6oZpfVBX91lY(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	private static DataClassPostEntityXmlSerializer K2CsvkEsTJEZFWwJxopy;

	public override string Replace(string serializedObject)
	{
		//Discarded unreachable code: IL_0058, IL_010a, IL_0119, IL_015a, IL_0169, IL_01da, IL_01e9, IL_020a, IL_0245, IL_02bf, IL_02f3, IL_0326, IL_03c9, IL_0409, IL_0418, IL_0424, IL_0465, IL_0484, IL_04d1, IL_0509, IL_0518, IL_055c, IL_0594, IL_05ed, IL_0625, IL_0634
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		StreamReader streamReader = default(StreamReader);
		StringReader stringReader = default(StringReader);
		int num8 = default(int);
		int num14 = default(int);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = (MemoryStream)VM2bGLEsOVw5dLdoqyj9();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				MemoryStream memoryStream2 = memoryStream;
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				z71RaREs2XGXv5GGCNRY(xmlWriterSettings, true);
				XmlWriter xmlWriter = (XmlWriter)mIUJIAEseAp7FMDucWVB(memoryStream2, xmlWriterSettings);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num3 = 3;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						streamReader = new StreamReader(memoryStream, (Encoding)YtVy6WEsAO4WkYbsgp6E());
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num3 = 0;
						}
						break;
					case 3:
						try
						{
							int num7;
							if (J6UEydEs1I77AL9viCBQ(serializedObject, vVKwFZEsPpPumodIt3La()))
							{
								int num6 = 5;
								num7 = num6;
								goto IL_00c1;
							}
							goto IL_0124;
							IL_00c1:
							while (true)
							{
								switch (num7)
								{
								case 3:
									stringReader = new StringReader(serializedObject);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
									{
										num7 = 0;
									}
									continue;
								case 4:
									break;
								case 2:
								case 5:
									num8 = jMfsL3EsNn1rcQndCRLS(serializedObject, '<');
									num7 = 3;
									continue;
								default:
									try
									{
										int num9;
										if (num8 <= 0)
										{
											num9 = 11;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
											{
												num9 = 8;
											}
											goto IL_019b;
										}
										goto IL_01f4;
										IL_019b:
										while (true)
										{
											switch (num9)
											{
											case 7:
											case 8:
												frKfqVEs3wg7nWL8IGLx(stringReader);
												num9 = 10;
												continue;
											case 2:
												cZbtOVEsaD9qUKF5HUya(xmlWriter, jtyKSIEspBrH6soO4i5K(serializedObject, 0, num8));
												num9 = 3;
												continue;
											case 10:
												num14++;
												num9 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
												{
													num9 = 1;
												}
												continue;
											case 1:
											case 5:
												if (num14 < num8)
												{
													num9 = 8;
													continue;
												}
												goto case 2;
											case 3:
											case 11:
												goto IL_0282;
											case 4:
												try
												{
													TypeRefReWriter typeRefReWriter = new TypeRefReWriter(xmlTextReader, xmlWriter);
													int num10 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
													{
														num10 = 0;
													}
													switch (num10)
													{
													default:
														try
														{
															JF0TbXEsDGLmohvrjgAe(typeRefReWriter);
															int num11 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
															{
																num11 = 0;
															}
															switch (num11)
															{
															case 0:
																break;
															}
														}
														catch (Exception exception)
														{
															int num12 = 2;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
															{
																num12 = 2;
															}
															while (true)
															{
																switch (num12)
																{
																case 1:
																	result = serializedObject;
																	num12 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
																	{
																		num12 = 0;
																	}
																	break;
																case 2:
																	((ILogger)eAxvECEstdotKhRKHLqZ()).Error(exception, (string)GctMypEs4GkqkrdQLvbv(mN9e25EswmNgWxH0tsom(-521266112 ^ -521464632)));
																	num12 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
																	{
																		num12 = 1;
																	}
																	break;
																default:
																	return result;
																case 0:
																	return result;
																}
															}
														}
														break;
													}
												}
												finally
												{
													int num13;
													if (xmlTextReader == null)
													{
														num13 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
														{
															num13 = 2;
														}
														goto IL_03cd;
													}
													goto IL_03e3;
													IL_03e3:
													D3P0X3Es6apZD5SqvaBl(xmlTextReader);
													num13 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
													{
														num13 = 0;
													}
													goto IL_03cd;
													IL_03cd:
													switch (num13)
													{
													default:
														goto end_IL_03a8;
													case 1:
														break;
													case 2:
														goto end_IL_03a8;
													case 0:
														goto end_IL_03a8;
													}
													goto IL_03e3;
													end_IL_03a8:;
												}
												goto case 9;
											case 9:
												NP9uttEsHUKG802TRVwU(xmlWriter);
												num9 = 6;
												continue;
											case 6:
												goto end_IL_0175;
											}
											break;
										}
										goto IL_01f4;
										IL_0282:
										xmlTextReader = new XmlTextReader(stringReader);
										int num15 = 4;
										goto IL_0197;
										IL_01f4:
										num14 = 0;
										num15 = 5;
										goto IL_0197;
										IL_0197:
										num9 = num15;
										goto IL_019b;
										end_IL_0175:;
									}
									finally
									{
										int num16;
										if (stringReader == null)
										{
											num16 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
											{
												num16 = 0;
											}
											goto IL_0469;
										}
										goto IL_048e;
										IL_048e:
										((IDisposable)stringReader).Dispose();
										num16 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
										{
											num16 = 0;
										}
										goto IL_0469;
										IL_0469:
										switch (num16)
										{
										default:
											goto end_IL_0444;
										case 0:
											goto end_IL_0444;
										case 2:
											break;
										case 1:
											goto end_IL_0444;
										}
										goto IL_048e;
										end_IL_0444:;
									}
									goto end_IL_00c1;
								case 1:
									return result;
								}
								goto IL_0124;
								continue;
								end_IL_00c1:
								break;
							}
							goto end_IL_009f;
							IL_0124:
							result = serializedObject;
							num7 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num7 = 0;
							}
							goto IL_00c1;
							end_IL_009f:;
						}
						finally
						{
							if (xmlWriter != null)
							{
								int num17 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num17 = 0;
								}
								while (true)
								{
									switch (num17)
									{
									default:
										((IDisposable)xmlWriter).Dispose();
										num17 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
										{
											num17 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto default;
					default:
						memoryStream.Seek(0L, SeekOrigin.Begin);
						num3 = 2;
						break;
					case 1:
						try
						{
							result = (string)IaL1jsEs7Hi8PuIiZZ6H(streamReader);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num4 = 0;
							}
							return num4 switch
							{
								0 => result, 
								_ => result, 
							};
						}
						finally
						{
							if (streamReader != null)
							{
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										D3P0X3Es6apZD5SqvaBl(streamReader);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					int num18 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num18 = 0;
					}
					while (true)
					{
						switch (num18)
						{
						default:
							((IDisposable)memoryStream).Dispose();
							num18 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num18 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public DataClassPostEntityXmlSerializer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AeGglnEsx94LOAse6Get();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object VM2bGLEsOVw5dLdoqyj9()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void z71RaREs2XGXv5GGCNRY(object P_0, bool P_1)
	{
		((XmlWriterSettings)P_0).OmitXmlDeclaration = P_1;
	}

	internal static object mIUJIAEseAp7FMDucWVB(object P_0, object P_1)
	{
		return XmlWriter.Create((Stream)P_0, (XmlWriterSettings)P_1);
	}

	internal static object vVKwFZEsPpPumodIt3La()
	{
		return TypeOf<DataClassMetadata>.FullName;
	}

	internal static bool J6UEydEs1I77AL9viCBQ(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static int jMfsL3EsNn1rcQndCRLS(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static int frKfqVEs3wg7nWL8IGLx(object P_0)
	{
		return ((TextReader)P_0).Read();
	}

	internal static object jtyKSIEspBrH6soO4i5K(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static void cZbtOVEsaD9qUKF5HUya(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteRaw((string)P_1);
	}

	internal static void JF0TbXEsDGLmohvrjgAe(object P_0)
	{
		((XmlStreamingEditorBase)P_0).Process();
	}

	internal static object eAxvECEstdotKhRKHLqZ()
	{
		return Logger.Log;
	}

	internal static object mN9e25EswmNgWxH0tsom(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GctMypEs4GkqkrdQLvbv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void D3P0X3Es6apZD5SqvaBl(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void NP9uttEsHUKG802TRVwU(object P_0)
	{
		((XmlWriter)P_0).Flush();
	}

	internal static object YtVy6WEsAO4WkYbsgp6E()
	{
		return Encoding.UTF8;
	}

	internal static object IaL1jsEs7Hi8PuIiZZ6H(object P_0)
	{
		return ((TextReader)P_0).ReadToEnd();
	}

	internal static bool tir4MgEskWDXZeDSKoD4()
	{
		return K2CsvkEsTJEZFWwJxopy == null;
	}

	internal static DataClassPostEntityXmlSerializer rvNqFjEsnQyipUZtFjEx()
	{
		return K2CsvkEsTJEZFWwJxopy;
	}

	internal static void AeGglnEsx94LOAse6Get()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
