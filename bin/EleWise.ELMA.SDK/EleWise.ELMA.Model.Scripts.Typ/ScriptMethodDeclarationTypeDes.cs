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

public class ScriptMethodDeclarationTypeDescriptor : CLRTypeDescriptor<List<ScriptMethodDeclaration>, ScriptMethodDeclarationTypeSettings>
{
	public const string UID_S = "{D6E0683F-B70F-4D65-B3FF-E1987CBD40A5}";

	public static readonly Guid UID;

	internal static ScriptMethodDeclarationTypeDescriptor wJMt2PbTS97aQBqnlb0p;

	public override Guid Uid => UID;

	public override bool Visible => false;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => (string)Tk5isJbTKuAAynbVN3t0(viY0t0bTqLbSlXr95T7a(-1487388570 ^ -1487240152));

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998520828));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BE7D8));
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
		//Discarded unreachable code: IL_004f, IL_0085, IL_00b4, IL_016b, IL_017a, IL_01ab, IL_0204, IL_0244, IL_0253, IL_02b4, IL_02c3, IL_02cf, IL_02de
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
					MemoryStream memoryStream2 = (MemoryStream)B5eMnGbTX9yj5MfTUQkn();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
									vpOi25bTTnpt8ayH4CaV(streamWriter, value.GetType().AssemblyQualifiedName);
									int num5 = 5;
									while (true)
									{
										switch (num5)
										{
										case 2:
											return result;
										case 3:
											LjQYlebTOwXx7Ib0PCPu(memoryStream2, 0L, SeekOrigin.Begin);
											num5 = 4;
											continue;
										case 5:
											streamWriter.Flush();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
											{
												num5 = 0;
											}
											continue;
										case 6:
											if (cD24y4bTn5YuyS9Fkfxk(memoryStream2) > 0)
											{
												num5 = 3;
												continue;
											}
											break;
										default:
											T98eKUbTkmsIG9GEIIVm(memoryStream, memoryStream2);
											num5 = 6;
											continue;
										case 4:
											result = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)cD24y4bTn5YuyS9Fkfxk(memoryStream2), memoryStream2, SerializeSimpleAction);
											num5 = 2;
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								finally
								{
									if (streamWriter != null)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												CTk2q5bT2htU12fHTt0d(streamWriter);
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
												{
													num6 = 1;
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
							int num7;
							if (memoryStream2 == null)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num7 = 1;
								}
								goto IL_0208;
							}
							goto IL_021e;
							IL_021e:
							CTk2q5bT2htU12fHTt0d(memoryStream2);
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num7 = 0;
							}
							goto IL_0208;
							IL_0208:
							switch (num7)
							{
							default:
								goto end_IL_01e3;
							case 2:
								break;
							case 1:
								goto end_IL_01e3;
							case 0:
								goto end_IL_01e3;
							}
							goto IL_021e;
							end_IL_01e3:;
						}
						break;
					}
				}
				finally
				{
					int num8;
					if (memoryStream == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num8 = 0;
						}
						goto IL_0284;
					}
					goto IL_029a;
					IL_029a:
					((IDisposable)memoryStream).Dispose();
					int num9 = 2;
					num8 = num9;
					goto IL_0284;
					IL_0284:
					switch (num8)
					{
					default:
						goto end_IL_025f;
					case 1:
						break;
					case 0:
						goto end_IL_025f;
					case 2:
						goto end_IL_025f;
					}
					goto IL_029a;
					end_IL_025f:;
				}
				goto default;
			case 2:
				memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
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
				memoryStream.Read(buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)JrOgi3bTemA6672yaC0L(BitConverter.ToString(buffer, offset, length), viY0t0bTqLbSlXr95T7a(-218496594 ^ -218492990), "");
			}
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				text = value.ToString();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				QDMYssbTPIxRAo21WNZ6(value, viY0t0bTqLbSlXr95T7a(-105199646 ^ -105214316));
				num2 = 2;
				break;
			case 2:
				QDMYssbTPIxRAo21WNZ6(deserializeToType, viY0t0bTqLbSlXr95T7a(-1979251663 ^ -1979232843));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(DLsaFWbT1BHjcZkZSyq2(text) >> 1, text, DeserializeSimpleAction);
			}
		}
	}

	private object DeserializeSimpleAction(byte[] buffer, int offset, int length, string hexString)
	{
		//Discarded unreachable code: IL_0065, IL_0074, IL_00a3, IL_00de, IL_0153, IL_018b, IL_01d4, IL_0214, IL_0223, IL_0250, IL_0280, IL_028f, IL_029b, IL_02ae, IL_02bd
		int num = 8;
		int num3 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		XmlReader xmlReader = default(XmlReader);
		object result = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					try
					{
						StreamReader streamReader = new StreamReader(memoryStream);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								Type type = Type.GetType(streamReader.ReadLine());
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 2:
										xmlReader = (XmlReader)kXayaBbT3V7riv3E4tad(streamReader);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
										{
											num5 = 0;
										}
										continue;
									case 1:
										streamReader.CheckAndCorrectInternalBOMSymbols();
										num5 = 2;
										continue;
									}
									try
									{
										result = ClassSerializationHelper.DeserializeObjectByXml(type, xmlReader);
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
										{
											num6 = 0;
										}
										return num6 switch
										{
											0 => result, 
											_ => result, 
										};
									}
									finally
									{
										if (xmlReader != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													CTk2q5bT2htU12fHTt0d(xmlReader);
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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
							finally
							{
								int num8;
								if (streamReader == null)
								{
									num8 = 2;
									goto IL_01d8;
								}
								goto IL_01ee;
								IL_01d8:
								switch (num8)
								{
								default:
									goto end_IL_01c3;
								case 1:
									break;
								case 2:
									goto end_IL_01c3;
								case 0:
									goto end_IL_01c3;
								}
								goto IL_01ee;
								IL_01ee:
								CTk2q5bT2htU12fHTt0d(streamReader);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num8 = 0;
								}
								goto IL_01d8;
								end_IL_01c3:;
							}
						}
					}
					finally
					{
						int num9;
						if (memoryStream == null)
						{
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num9 = 1;
							}
							goto IL_0254;
						}
						goto IL_026a;
						IL_026a:
						((IDisposable)memoryStream).Dispose();
						num9 = 2;
						goto IL_0254;
						IL_0254:
						switch (num9)
						{
						case 1:
							goto end_IL_022f;
						case 2:
							goto end_IL_022f;
						}
						goto IL_026a;
						end_IL_022f:;
					}
				case 8:
					goto end_IL_0012;
				default:
					if (num3 < length)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 5:
					return result;
				case 4:
				case 6:
					buffer[offset + num3] = Convert.ToByte((string)HV4ltgbTNMn3B9CnoRoH(hexString, num3 << 1, 2), 16);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					break;
				}
				memoryStream = MemoryHelper.GetMemoryStream(buffer, offset, length, writable: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num3 = 0;
			num = 7;
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return new ColumnType(DbType.Binary);
	}

	public ScriptMethodDeclarationTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nwnQD9bTpgNB2ot7oxCj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ScriptMethodDeclarationTypeDescriptor()
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
			case 1:
				UID = new Guid((string)viY0t0bTqLbSlXr95T7a(-1123633026 ^ -1123779330));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object viY0t0bTqLbSlXr95T7a(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Tk5isJbTKuAAynbVN3t0(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool TQuesabTiVO6N1frSm8m()
	{
		return wJMt2PbTS97aQBqnlb0p == null;
	}

	internal static ScriptMethodDeclarationTypeDescriptor DY5o4qbTRWoBpZ0xFZWI()
	{
		return wJMt2PbTS97aQBqnlb0p;
	}

	internal static object B5eMnGbTX9yj5MfTUQkn()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void vpOi25bTTnpt8ayH4CaV(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static void T98eKUbTkmsIG9GEIIVm(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	internal static long cD24y4bTn5YuyS9Fkfxk(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static long LjQYlebTOwXx7Ib0PCPu(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void CTk2q5bT2htU12fHTt0d(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object JrOgi3bTemA6672yaC0L(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void QDMYssbTPIxRAo21WNZ6(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int DLsaFWbT1BHjcZkZSyq2(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object HV4ltgbTNMn3B9CnoRoH(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object kXayaBbT3V7riv3E4tad(object P_0)
	{
		return XmlReader.Create((TextReader)P_0);
	}

	internal static void nwnQD9bTpgNB2ot7oxCj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
