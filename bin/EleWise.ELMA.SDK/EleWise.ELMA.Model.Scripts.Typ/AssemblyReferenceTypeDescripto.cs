using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Types.Settings;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Types;

public class AssemblyReferenceTypeDescriptor : CLRTypeDescriptor<List<AssemblyReference>, AssemblyReferenceTypeSettings>
{
	public const string UID_S = "{6D4B839B-DADA-4BA9-B163-33A771E84039}";

	public static readonly Guid UID;

	internal static AssemblyReferenceTypeDescriptor LEsPZKbT43vMrs5Evohv;

	public override Guid Uid => UID;

	public override bool Visible => false;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T((string)PIBRMUbTAslOu3oHQAdL(0x4D1C1EE4 ^ 0x4D1EDA34));

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138174650));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EEACB));
		}
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object value = property.GetValue(obj, null);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		if (value != null)
		{
			serializableDictionary[propertyMetadata.Name] = SerializeSimple(value, value.GetType(), settings);
		}
		return serializableDictionary;
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_006d, IL_00a3, IL_019e, IL_01ad, IL_01bd, IL_0210, IL_0250, IL_027c, IL_02d5, IL_030d, IL_031c
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream2 = default(MemoryStream);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				memoryStream2 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				try
				{
					MemoryStream memoryStream = (MemoryStream)DlRIa6bT7PJtuXjPhUsv();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							StreamWriter streamWriter = new StreamWriter(memoryStream);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								try
								{
									Ex4BjAbTxjmvFFjnoGVs(streamWriter, value.GetType().AssemblyQualifiedName);
									int num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num5 = 3;
									}
									while (true)
									{
										switch (num5)
										{
										case 3:
											me51V1bT0md82PfXCTE9(streamWriter);
											num5 = 5;
											continue;
										case 1:
											if (V6cpcCbTy4BJJiLFPyTF(memoryStream) <= 0)
											{
												int num6 = 2;
												num5 = num6;
												continue;
											}
											goto case 7;
										case 7:
											NAKCyKbTMXe3NTb7Ubak(memoryStream, 0L, SeekOrigin.Begin);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
											{
												num5 = 0;
											}
											continue;
										default:
											result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)V6cpcCbTy4BJJiLFPyTF(memoryStream), memoryStream, SerializeSimpleAction);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
											{
												num5 = 6;
											}
											continue;
										case 2:
											break;
										case 5:
											GofTphbTmcD4yFkiWKuo(memoryStream2, memoryStream);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
											{
												num5 = 1;
											}
											continue;
										case 4:
											break;
										case 6:
											return result;
										}
										break;
									}
								}
								finally
								{
									int num7;
									if (streamWriter == null)
									{
										num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
										{
											num7 = 1;
										}
										goto IL_0214;
									}
									goto IL_022a;
									IL_022a:
									B30w1NbTJwR5qKgw8Ss5(streamWriter);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
									{
										num7 = 0;
									}
									goto IL_0214;
									IL_0214:
									switch (num7)
									{
									default:
										goto end_IL_01ef;
									case 2:
										break;
									case 1:
										goto end_IL_01ef;
									case 0:
										goto end_IL_01ef;
									}
									goto IL_022a;
									end_IL_01ef:;
								}
								break;
							}
						}
						finally
						{
							if (memoryStream != null)
							{
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										B30w1NbTJwR5qKgw8Ss5(memoryStream);
										num8 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
						}
						break;
					}
				}
				finally
				{
					if (memoryStream2 != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								B30w1NbTJwR5qKgw8Ss5(memoryStream2);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				break;
			}
			break;
		}
		return null;
	}

	private string SerializeSimpleAction(byte[] buffer, int offset, int length, MemoryStream memoryStream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				oxpiOMbT9kJE6VeSrW8Q(memoryStream, buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)hynq6lbTlO5VhHTCmjkf(FGN5tCbTdSAVCuuuLuCs(buffer, offset, length), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477142090), "");
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		int num = 3;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					text = value.ToString();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					go4y84bTr3sFMZxrK7dS(deserializeToType, PIBRMUbTAslOu3oHQAdL(-889460160 ^ -889478204));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				case 1:
					return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(rsSfYebTgMSwdaUIT6Br(text) >> 1, text, DeserializeSimpleAction);
				}
				break;
			}
			go4y84bTr3sFMZxrK7dS(value, PIBRMUbTAslOu3oHQAdL(-629844702 ^ -629859244));
			num = 2;
		}
	}

	private object DeserializeSimpleAction(byte[] buffer, int offset, int length, string hexString)
	{
		//Discarded unreachable code: IL_008c, IL_00c7, IL_013c, IL_0174, IL_01cd, IL_01ec, IL_01fb, IL_0249, IL_0281, IL_02e0, IL_02ef, IL_02ff
		int num = 7;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		XmlReader xmlReader = default(XmlReader);
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				memoryStream = (MemoryStream)CVl7PdbTjfSPfrZlgnEK(buffer, offset, length, false);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return obj;
			case 4:
				try
				{
					StreamReader streamReader = new StreamReader(memoryStream);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						try
						{
							Type tp = QUX57BbTLFmNYWuKgjwh(MldB5jbTYJsLbLRouJdt(streamReader));
							int num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									xmlReader = (XmlReader)DboIRQbTs3yhk45xaROF(streamReader);
									num5 = 2;
									break;
								case 1:
									TNj3qrbTUR5EmFwgdLPx(streamReader);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num5 = 0;
									}
									break;
								case 2:
									try
									{
										obj = ClassSerializationHelper.DeserializeObjectByXml(tp, xmlReader);
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
										{
											num6 = 0;
										}
										return num6 switch
										{
											0 => obj, 
											_ => obj, 
										};
									}
									finally
									{
										if (xmlReader != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													B30w1NbTJwR5qKgw8Ss5(xmlReader);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
													{
														num7 = 1;
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
						}
						finally
						{
							int num8;
							if (streamReader == null)
							{
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num8 = 0;
								}
								goto IL_01d1;
							}
							goto IL_0206;
							IL_0206:
							B30w1NbTJwR5qKgw8Ss5(streamReader);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num8 = 1;
							}
							goto IL_01d1;
							IL_01d1:
							switch (num8)
							{
							default:
								goto end_IL_01ac;
							case 0:
								goto end_IL_01ac;
							case 2:
								break;
							case 1:
								goto end_IL_01ac;
							}
							goto IL_0206;
							end_IL_01ac:;
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								B30w1NbTJwR5qKgw8Ss5(memoryStream);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				buffer[offset + num3] = CO4g3BbT5urVmpC5OfPx(hexString.Substring(num3 << 1, 2), 16);
				num2 = 8;
				break;
			case 8:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				num3 = 0;
				num2 = 6;
				break;
			case 1:
			case 6:
				if (num3 < length)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public AssemblyReferenceTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AssemblyReferenceTypeDescriptor()
	{
		int num = 2;
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
				MR8w00bTc8xqU7QHIg9Z();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x638250E7));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object PIBRMUbTAslOu3oHQAdL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool naAReGbT6hRsL4Jia8t7()
	{
		return LEsPZKbT43vMrs5Evohv == null;
	}

	internal static AssemblyReferenceTypeDescriptor vRvHhRbTHVICb4dUuGmM()
	{
		return LEsPZKbT43vMrs5Evohv;
	}

	internal static object DlRIa6bT7PJtuXjPhUsv()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void Ex4BjAbTxjmvFFjnoGVs(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static void me51V1bT0md82PfXCTE9(object P_0)
	{
		((TextWriter)P_0).Flush();
	}

	internal static void GofTphbTmcD4yFkiWKuo(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static long V6cpcCbTy4BJJiLFPyTF(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static long NAKCyKbTMXe3NTb7Ubak(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void B30w1NbTJwR5qKgw8Ss5(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int oxpiOMbT9kJE6VeSrW8Q(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static object FGN5tCbTdSAVCuuuLuCs(object P_0, int P_1, int P_2)
	{
		return BitConverter.ToString((byte[])P_0, P_1, P_2);
	}

	internal static object hynq6lbTlO5VhHTCmjkf(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void go4y84bTr3sFMZxrK7dS(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int rsSfYebTgMSwdaUIT6Br(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static byte CO4g3BbT5urVmpC5OfPx(object P_0, int P_1)
	{
		return Convert.ToByte((string)P_0, P_1);
	}

	internal static object CVl7PdbTjfSPfrZlgnEK(object P_0, int offset, int length, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, offset, length, writable);
	}

	internal static object MldB5jbTYJsLbLRouJdt(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static Type QUX57BbTLFmNYWuKgjwh(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static void TNj3qrbTUR5EmFwgdLPx(object P_0)
	{
		((StreamReader)P_0).CheckAndCorrectInternalBOMSymbols();
	}

	internal static object DboIRQbTs3yhk45xaROF(object P_0)
	{
		return XmlReader.Create((TextReader)P_0);
	}

	internal static void MR8w00bTc8xqU7QHIg9Z()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
