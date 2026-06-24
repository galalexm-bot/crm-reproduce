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

public class ScriptWebReferencesTypeDescriptor : CLRTypeDescriptor<List<ScriptWebReference>, ScriptWebReferencesTypeSettings>
{
	public const string UID_S = "{F14334F8-4964-4A0E-9846-D7687933F0A4}";

	public static readonly Guid UID;

	private static ScriptWebReferencesTypeDescriptor JrCfTSbkJPu17sgngFZr;

	public override Guid Uid => UID;

	public override bool Visible => false;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)YdEiVobkrgn0YZsckYkG(fLWVvabklMXHN6QegAhT(-35995181 ^ -36174589));

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870906615));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824374065));
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
		//Discarded unreachable code: IL_0072, IL_00a8, IL_00d7, IL_01b2, IL_01c1, IL_01d0, IL_0201, IL_0241, IL_0250, IL_027d, IL_02d6, IL_030e, IL_031d
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
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				try
				{
					MemoryStream memoryStream = (MemoryStream)vl3u6lbkgQTRfstsOf6U();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
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
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								try
								{
									vBGZP4bk5o8wQ9SkUs1m(streamWriter, value.GetType().AssemblyQualifiedName);
									int num5 = 2;
									while (true)
									{
										switch (num5)
										{
										default:
											return result;
										case 0:
											return result;
										case 6:
											result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)smwHD9bkLqgTEEVUm7Cb(memoryStream), memoryStream, SerializeSimpleAction);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
											{
												num5 = 0;
											}
											continue;
										case 4:
											WxanLsbkUd6PoJh3Z2SO(memoryStream, 0L, SeekOrigin.Begin);
											num5 = 6;
											continue;
										case 5:
											MafpDIbkYoNKppYBiBvb(memoryStream2, memoryStream);
											num5 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
											{
												num5 = 1;
											}
											continue;
										case 2:
											PWmJcZbkj2Dhs84Il6HR(streamWriter);
											num5 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
											{
												num5 = 3;
											}
											continue;
										case 7:
											if (smwHD9bkLqgTEEVUm7Cb(memoryStream) <= 0)
											{
												num5 = 3;
												continue;
											}
											goto case 4;
										case 3:
											break;
										case 1:
											break;
										}
										break;
									}
								}
								finally
								{
									int num6;
									if (streamWriter == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
										{
											num6 = 0;
										}
										goto IL_0205;
									}
									goto IL_021b;
									IL_021b:
									NUpohCbks7DFGkPqW0tb(streamWriter);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
									{
										num6 = 1;
									}
									goto IL_0205;
									IL_0205:
									switch (num6)
									{
									default:
										goto end_IL_01e0;
									case 2:
										break;
									case 0:
										goto end_IL_01e0;
									case 1:
										goto end_IL_01e0;
									}
									goto IL_021b;
									end_IL_01e0:;
								}
								break;
							}
						}
						finally
						{
							if (memoryStream != null)
							{
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										NUpohCbks7DFGkPqW0tb(memoryStream);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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
						break;
					}
				}
				finally
				{
					if (memoryStream2 != null)
					{
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num8 = 1;
						}
						while (true)
						{
							switch (num8)
							{
							case 1:
								NUpohCbks7DFGkPqW0tb(memoryStream2);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
								{
									num8 = 0;
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
				memoryStream.Read(buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return BitConverter.ToString(buffer, offset, length).Replace((string)fLWVvabklMXHN6QegAhT(0x48A7E34A ^ 0x48A7ED26), "");
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				text = value.ToString();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(PgjKD7bkzBfngkLltGAV(text) >> 1, text, DeserializeSimpleAction);
			case 2:
				EnUj4RbkcJhlQPZtVFTF(value, fLWVvabklMXHN6QegAhT(-234299632 ^ -234318234));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Contract.ArgumentNotNull(deserializeToType, (string)fLWVvabklMXHN6QegAhT(-16752921 ^ -16771229));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private object DeserializeSimpleAction(byte[] buffer, int offset, int length, string hexString)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc, IL_00fb, IL_0136, IL_01ab, IL_01d3, IL_0213, IL_0222, IL_024f, IL_02a8, IL_02e0, IL_02ef
		int num = 2;
		int num3 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		XmlReader xmlReader = default(XmlReader);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					buffer[offset + num3] = b7OoHjbnF1snugQrNybH(hexString.Substring(num3 << 1, 2), 16);
					num2 = 3;
					continue;
				case 6:
					memoryStream = (MemoryStream)xVuW6JbnBAvtkBbEPna4(buffer, offset, length, false);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return obj;
				case 3:
					break;
				case 7:
					try
					{
						StreamReader streamReader = new StreamReader(memoryStream);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								Type tp = BwDf92bnoIbt2Ng3AltY(nVwKgObnWvKuUTMlxVtU(streamReader));
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										streamReader.CheckAndCorrectInternalBOMSymbols();
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
										{
											num5 = 1;
										}
										break;
									case 1:
										xmlReader = XmlReader.Create(streamReader);
										num5 = 2;
										break;
									case 2:
										try
										{
											obj = ClassSerializationHelper.DeserializeObjectByXml(tp, xmlReader);
											int num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
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
											int num7;
											if (xmlReader == null)
											{
												num7 = 2;
												goto IL_01d7;
											}
											goto IL_01ed;
											IL_01d7:
											switch (num7)
											{
											default:
												goto end_IL_01c2;
											case 1:
												break;
											case 2:
												goto end_IL_01c2;
											case 0:
												goto end_IL_01c2;
											}
											goto IL_01ed;
											IL_01ed:
											NUpohCbks7DFGkPqW0tb(xmlReader);
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
											{
												num7 = 0;
											}
											goto IL_01d7;
											end_IL_01c2:;
										}
									}
								}
							}
							finally
							{
								if (streamReader != null)
								{
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
									{
										num8 = 1;
									}
									while (true)
									{
										switch (num8)
										{
										case 1:
											((IDisposable)streamReader).Dispose();
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
											{
												num8 = 0;
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
							int num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								case 1:
									NUpohCbks7DFGkPqW0tb(memoryStream);
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
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
				case 1:
				case 5:
					if (num3 >= length)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			num3++;
			num = 5;
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public ScriptWebReferencesTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ScriptWebReferencesTypeDescriptor()
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
				D6dtqLbnbU8HVhWCtqif();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146395951));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object fLWVvabklMXHN6QegAhT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YdEiVobkrgn0YZsckYkG(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool RgYqpcbk9IbQQTwW7LVU()
	{
		return JrCfTSbkJPu17sgngFZr == null;
	}

	internal static ScriptWebReferencesTypeDescriptor EOoXv1bkdnK1qltTnnM2()
	{
		return JrCfTSbkJPu17sgngFZr;
	}

	internal static object vl3u6lbkgQTRfstsOf6U()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void vBGZP4bk5o8wQ9SkUs1m(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static void PWmJcZbkj2Dhs84Il6HR(object P_0)
	{
		((TextWriter)P_0).Flush();
	}

	internal static void MafpDIbkYoNKppYBiBvb(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static long smwHD9bkLqgTEEVUm7Cb(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static long WxanLsbkUd6PoJh3Z2SO(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void NUpohCbks7DFGkPqW0tb(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void EnUj4RbkcJhlQPZtVFTF(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int PgjKD7bkzBfngkLltGAV(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static byte b7OoHjbnF1snugQrNybH(object P_0, int P_1)
	{
		return Convert.ToByte((string)P_0, P_1);
	}

	internal static object xVuW6JbnBAvtkBbEPna4(object P_0, int offset, int length, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, offset, length, writable);
	}

	internal static object nVwKgObnWvKuUTMlxVtU(object P_0)
	{
		return ((TextReader)P_0).ReadLine();
	}

	internal static Type BwDf92bnoIbt2Ng3AltY(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static void D6dtqLbnbU8HVhWCtqif()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
