using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.TranslateData;

public class RootCodeItemCollectionTypeDescriptor : CLRTypeDescriptor<RootCodeItemCollection, RootCodeItemTypeSettings>
{
	public const string UID_S = "B996B108-7A4D-4240-B96B-C6C1D99636D7";

	public static readonly Guid UID;

	private static RootCodeItemCollectionTypeDescriptor heP9XKZzdy5blolWard;

	public override Guid Uid => UID;

	public override bool Visible => false;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)cP6H6YuopRRJcDKYqtM(gJTPikuWA1SRi78qjG9(0x5DD55050 ^ 0x5DD51978));

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398677918));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576131338));
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
		//Discarded unreachable code: IL_004f, IL_0085, IL_011a, IL_0163, IL_0172, IL_01e6, IL_0226, IL_0235, IL_0262, IL_02bb, IL_02fb, IL_030a, IL_0316, IL_0325
		int num = 2;
		int num2 = num;
		object result = default(object);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				try
				{
					MemoryStream memoryStream2 = (MemoryStream)RZABvGub6DQKco9Db84();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							StreamWriter streamWriter = new StreamWriter(memoryStream2);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								try
								{
									UR0wGyuhiQvAS40NPci(streamWriter, value.GetType().AssemblyQualifiedName);
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
									{
										num5 = 0;
									}
									while (true)
									{
										int num6;
										switch (num5)
										{
										case 7:
											return result;
										case 4:
											qVg5gwuGd3BpRnX4BoI(memoryStream, memoryStream2);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
											{
												num5 = 0;
											}
											continue;
										case 2:
											break;
										case 5:
											NCpy7suEqSs24xRFpRH(memoryStream2, 0L, SeekOrigin.Begin);
											num6 = 6;
											goto IL_00c4;
										case 1:
											streamWriter.Flush();
											num5 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
											{
												num5 = 4;
											}
											continue;
										default:
											if (memoryStream2.Length <= 0)
											{
												num5 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
												{
													num5 = 0;
												}
												continue;
											}
											goto case 5;
										case 6:
											result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)PyafcGufu5s7Jv12TFN(memoryStream2), memoryStream2, SerializeSimpleAction);
											num6 = 7;
											goto IL_00c4;
										case 3:
											break;
											IL_00c4:
											num5 = num6;
											continue;
										}
										break;
									}
								}
								finally
								{
									int num7;
									if (streamWriter == null)
									{
										num7 = 2;
										goto IL_01ea;
									}
									goto IL_0200;
									IL_01ea:
									switch (num7)
									{
									default:
										goto end_IL_01d5;
									case 1:
										break;
									case 2:
										goto end_IL_01d5;
									case 0:
										goto end_IL_01d5;
									}
									goto IL_0200;
									IL_0200:
									QB8sxDuQNYic9cnHR7k(streamWriter);
									num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
									{
										num7 = 0;
									}
									goto IL_01ea;
									end_IL_01d5:;
								}
								break;
							}
						}
						finally
						{
							if (memoryStream2 != null)
							{
								int num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										((IDisposable)memoryStream2).Dispose();
										num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
										{
											num8 = 0;
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
					int num9;
					if (memoryStream == null)
					{
						num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num9 = 1;
						}
						goto IL_02bf;
					}
					goto IL_02d5;
					IL_02d5:
					((IDisposable)memoryStream).Dispose();
					num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num9 = 0;
					}
					goto IL_02bf;
					IL_02bf:
					switch (num9)
					{
					default:
						goto end_IL_029a;
					case 2:
						break;
					case 1:
						goto end_IL_029a;
					case 0:
						goto end_IL_029a;
					}
					goto IL_02d5;
					end_IL_029a:;
				}
				goto default;
			case 2:
				memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
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
				IcU75nuCXX5IkESQYPG(memoryStream, buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)FTip4Cuvkp327kiRovI(BitConverter.ToString(buffer, offset, length), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x745906E), "");
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
				case 3:
					break;
				case 1:
					text = value.ToString();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					did6Seu8Hs28X1ctBjD(deserializeToType, gJTPikuWA1SRi78qjG9(-1487388570 ^ -1487402526));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(gnJk7cuZyJlE7RTys1D(text) >> 1, text, DeserializeSimpleAction);
				}
				break;
			}
			did6Seu8Hs28X1ctBjD(value, gJTPikuWA1SRi78qjG9(0x269E5FCA ^ 0x269E16BC));
			num = 2;
		}
	}

	private object DeserializeSimpleAction(byte[] buffer, int offset, int length, string hexString)
	{
		//Discarded unreachable code: IL_0078, IL_0087, IL_00f2, IL_011d, IL_01a2, IL_01da, IL_0223, IL_0263, IL_0272, IL_029f, IL_02be, IL_02ea, IL_02f9, IL_0309, IL_0318
		int num = 4;
		int num3 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 6:
					buffer[offset + num3] = Convert.ToByte(hexString.Substring(num3 << 1, 2), 16);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 8;
					}
					continue;
				case 1:
					memoryStream = (MemoryStream)gOtXS7uuMo8k6CdeeqI(buffer, offset, length, false);
					num = 7;
					break;
				default:
					return obj;
				case 8:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					try
					{
						StreamReader streamReader = new StreamReader(memoryStream);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								Type tp = thacRZuVgNfC6oRbIZL(DEEhdSuIuH5nosChvD9(streamReader));
								int num5 = 2;
								while (true)
								{
									switch (num5)
									{
									case 1:
										xmlTextReader = new XmlTextReader(streamReader);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
										{
											num5 = 0;
										}
										continue;
									case 2:
										streamReader.CheckAndCorrectInternalBOMSymbols();
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
										{
											num5 = 1;
										}
										continue;
									}
									try
									{
										obj = ClassSerializationHelper.DeserializeObjectByXml(tp, xmlTextReader);
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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
										if (xmlTextReader != null)
										{
											int num7 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												case 1:
													((IDisposable)xmlTextReader).Dispose();
													num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
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
								}
							}
							finally
							{
								int num8;
								if (streamReader == null)
								{
									num8 = 2;
									goto IL_0227;
								}
								goto IL_023d;
								IL_0227:
								switch (num8)
								{
								case 2:
									goto end_IL_0212;
								case 1:
									goto end_IL_0212;
								}
								goto IL_023d;
								IL_023d:
								QB8sxDuQNYic9cnHR7k(streamReader);
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num8 = 0;
								}
								goto IL_0227;
								end_IL_0212:;
							}
						}
					}
					finally
					{
						int num9;
						if (memoryStream == null)
						{
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num9 = 0;
							}
							goto IL_02a3;
						}
						goto IL_02c8;
						IL_02c8:
						((IDisposable)memoryStream).Dispose();
						num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num9 = 1;
						}
						goto IL_02a3;
						IL_02a3:
						switch (num9)
						{
						default:
							goto end_IL_027e;
						case 0:
							goto end_IL_027e;
						case 2:
							break;
						case 1:
							goto end_IL_027e;
						}
						goto IL_02c8;
						end_IL_027e:;
					}
				case 2:
				case 3:
					if (num3 < length)
					{
						num = 5;
						break;
					}
					goto case 1;
				case 4:
					num3 = 0;
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public RootCodeItemCollectionTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xrhiYKuSkn6faFmJMY0();
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

	static RootCodeItemCollectionTypeDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)gJTPikuWA1SRi78qjG9(-289714582 ^ -289732672));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object gJTPikuWA1SRi78qjG9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cP6H6YuopRRJcDKYqtM(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool YOuHwNuFGDcAlgHOWtQ()
	{
		return heP9XKZzdy5blolWard == null;
	}

	internal static RootCodeItemCollectionTypeDescriptor SADE0QuB5MBJtIo3PEs()
	{
		return heP9XKZzdy5blolWard;
	}

	internal static object RZABvGub6DQKco9Db84()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void UR0wGyuhiQvAS40NPci(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static void qVg5gwuGd3BpRnX4BoI(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static long NCpy7suEqSs24xRFpRH(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static long PyafcGufu5s7Jv12TFN(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static void QB8sxDuQNYic9cnHR7k(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int IcU75nuCXX5IkESQYPG(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static object FTip4Cuvkp327kiRovI(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void did6Seu8Hs28X1ctBjD(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int gnJk7cuZyJlE7RTys1D(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object gOtXS7uuMo8k6CdeeqI(object P_0, int offset, int length, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, offset, length, writable);
	}

	internal static object DEEhdSuIuH5nosChvD9(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static Type thacRZuVgNfC6oRbIZL(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static void xrhiYKuSkn6faFmJMY0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
