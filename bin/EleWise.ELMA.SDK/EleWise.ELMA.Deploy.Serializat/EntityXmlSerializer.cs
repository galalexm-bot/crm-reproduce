using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Serialization;

internal class EntityXmlSerializer
{
	public const string ConstXmlSerialize = "XmlSerialize";

	private List<string> fileUids;

	private static readonly string IdPropertyName;

	internal static EntityXmlSerializer zDYcnpEwfEGtSddPMSkb;

	public Func<IEntity, bool> NeedBindProperties { get; set; }

	public Func<PropertyMetadata, bool> PropertyFilter { get; set; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Свойство устарело, используйте вместо него NeedBindTablePart", true)]
	public Func<TablePartMetadata, bool> TablePartFilter { get; set; }

	public Func<ITablePartMetadata, bool> NeedBindTablePart { get; set; }

	private IDictionary<string, object> SpecialListOfSimpleTypeDescriptorSerialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings)
	{
		if (obj == null)
		{
			return null;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7AA74));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345439082));
		}
		PropertyInfo reflectionProperty = obj.GetType().GetReflectionProperty(propertyMetadata.Name);
		if (reflectionProperty == null || !reflectionProperty.CanRead)
		{
			return null;
		}
		object value = reflectionProperty.GetValue(obj, null);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		if (value != null)
		{
			string value2 = ClassSerializationHelper.SerializeObjectByXml(value);
			using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
			using StreamWriter streamWriter = new StreamWriter(memoryStream);
			streamWriter.WriteLine(value.GetType().AssemblyQualifiedName);
			streamWriter.Write(value2);
			streamWriter.Flush();
			if (memoryStream.Length > 0)
			{
				memoryStream.Seek(0L, SeekOrigin.Begin);
				string value3 = MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int)memoryStream.Length, memoryStream, SpecialListOfSimpleTypeDescriptorSerializeAction);
				serializableDictionary[propertyMetadata.Name] = value3;
				return serializableDictionary;
			}
			serializableDictionary[propertyMetadata.Name] = null;
			return serializableDictionary;
		}
		return serializableDictionary;
	}

	private string SpecialListOfSimpleTypeDescriptorSerializeAction(byte[] buffer, int offset, int length, MemoryStream memoryStream)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				T2FyQQEwvtCdhsGt2w2q(memoryStream, buffer, offset, length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)PijegnEwuegmnIg3qU3U(lxKJpxEw87ML3nTCDJJZ(buffer, offset, length), vUM8fsEwZiwH4uU1iFhF(-521266112 ^ -521268692), "");
			}
		}
	}

	public virtual void SpecialListOfSimpleTypeDescriptorDeserialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj == null || values == null)
		{
			return;
		}
		if (metadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F303188));
		}
		if (propertyMetadata == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51154B4F));
		}
		PropertyInfo propertyCached = obj.GetType().GetPropertyCached(propertyMetadata.Name);
		if (propertyCached == null || !propertyCached.CanWrite)
		{
			return;
		}
		Type propertyType = propertyCached.PropertyType;
		if (!values.TryGetValue(propertyMetadata.Name, out var value))
		{
			return;
		}
		try
		{
			object value2 = SpecialListOfSimpleTypeDescriptorDeserializeSimple(value, propertyType);
			propertyCached.SetValue(obj, value2, null);
		}
		catch
		{
		}
	}

	public object SpecialListOfSimpleTypeDescriptorDeserializeSimple(object value, Type deserializeToType)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(bxIZCSEwVKISouZYKRSy(text) >> 1, text, SpecialListOfSimpleTypeDescriptorDeserializeSimpleAction);
			case 3:
				ugh7rFEwIUytycXJwHIJ(value, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309653814));
				num2 = 2;
				break;
			default:
				text = value.ToString();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(deserializeToType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3DA6FA));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private object SpecialListOfSimpleTypeDescriptorDeserializeSimpleAction(byte[] buffer, int offset, int length, string value)
	{
		//Discarded unreachable code: IL_0093, IL_00ce, IL_0153, IL_018b, IL_01e4, IL_0224, IL_0233, IL_0260, IL_0298, IL_02a7, IL_02da, IL_02e9
		int num = 5;
		int num3 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		object result = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					buffer[offset + num3] = g30cCOEwSTDdQgQJC3gC(value.Substring(num3 << 1, 2), 16);
					num2 = 2;
					continue;
				case 2:
					num3++;
					num2 = 6;
					continue;
				case 1:
					try
					{
						StreamReader streamReader = new StreamReader(memoryStream);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								Type tp = f4o1gkEwRR7CtUNc8Z0y(streamReader.ReadLine());
								int num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										streamReader.CheckAndCorrectInternalBOMSymbols();
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
										{
											num5 = 2;
										}
										continue;
									case 2:
										xmlTextReader = new XmlTextReader(streamReader);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
										{
											num5 = 0;
										}
										continue;
									}
									try
									{
										result = ClassSerializationHelper.DeserializeObjectByXml(tp, xmlTextReader);
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
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
										if (xmlTextReader != null)
										{
											int num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													((IDisposable)xmlTextReader).Dispose();
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
													{
														num7 = 0;
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
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
									{
										num8 = 0;
									}
									goto IL_01e8;
								}
								goto IL_01fe;
								IL_01fe:
								((IDisposable)streamReader).Dispose();
								num8 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num8 = 2;
								}
								goto IL_01e8;
								IL_01e8:
								switch (num8)
								{
								default:
									goto end_IL_01c3;
								case 1:
									break;
								case 0:
									goto end_IL_01c3;
								case 2:
									goto end_IL_01c3;
								}
								goto IL_01fe;
								end_IL_01c3:;
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							int num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								case 1:
									U13vRcEwqbO12D5U6VOJ(memoryStream);
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
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
				case 5:
					break;
				case 4:
				case 6:
					if (num3 >= length)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				default:
					return result;
				case 7:
					memoryStream = (MemoryStream)oyjoxoEwiHptCUlKXBN7(buffer, offset, length, false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			num3 = 0;
			num = 4;
		}
	}

	public List<string> Serialize(object obj, XmlWriter writer, EntitySerializationSettings settings, ExportRuleList rules = null, IMetadata metadataTrunc = null)
	{
		Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475897999));
		fileUids = new List<string>();
		ConvertToXmlString(obj, writer, settings, rules, metadataTrunc);
		return fileUids;
	}

	private void WriteValues(XmlWriter writer, IDictionary<string, object> values, IEnumerable<IPostEntityXmlSerializer> postSerializerPoints, ITypeDescriptor typeDescriptor)
	{
		bool flag = false;
		bool flag2 = false;
		if (typeDescriptor != null)
		{
			flag = typeDescriptor.Uid == BinaryFileDescriptor.UID;
			flag2 = typeDescriptor.Uid == EnumDescriptor.UID;
		}
		if (values == null)
		{
			return;
		}
		foreach (KeyValuePair<string, object> value2 in values)
		{
			if (value2.Value is SerializableDictionary<string, object>)
			{
				SerializableDictionary<string, object> serializableDictionary = value2.Value as SerializableDictionary<string, object>;
				writer.WriteStartElement(value2.Key);
				writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1871120939), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633511845));
				writer.WriteString(serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477167032)].ToString());
				writer.WriteEndElement();
				if (flag && !fileUids.Contains(serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420767564)].ToString()))
				{
					fileUids.Add(serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A78CD8)].ToString());
				}
				continue;
			}
			if (value2.Value is SerializableList<object>)
			{
				writer.WriteStartElement(value2.Key);
				writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2A86487), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785A603));
				foreach (object item in value2.Value as SerializableList<object>)
				{
					if (item is SerializableDictionary<string, object>)
					{
						SerializableDictionary<string, object> serializableDictionary2 = item as SerializableDictionary<string, object>;
						writer.WriteElementString(value2.Key, serializableDictionary2[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411205569)].ToString());
					}
				}
				writer.WriteEndElement();
				continue;
			}
			if (value2.Value is byte[])
			{
				string text = BitConverter.ToString(value2.Value as byte[]).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281845036), "");
				writer.WriteStartElement(value2.Key);
				if (typeDescriptor is ListOfSimpleTypeDescriptor)
				{
					writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886878307), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C948FBA));
				}
				else
				{
					writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289927074), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EB997));
				}
				writer.WriteString(text);
				writer.WriteEndElement();
				continue;
			}
			bool flag3 = typeDescriptor is EntitySubTypeDescriptor<EntityMetadata>;
			if (value2.Value != null && (flag3 || typeDescriptor is XmlSerializableObjectTypeDescriptor))
			{
				string text2 = value2.Value.ToString();
				foreach (IPostEntityXmlSerializer postSerializerPoint in postSerializerPoints)
				{
					text2 = postSerializerPoint.Replace(text2);
				}
				writer.WriteStartElement(value2.Key);
				writer.WriteAttributeString(flag3 ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026AC8D) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269EE91C), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459556049));
				writer.WriteCData(text2);
				writer.WriteEndElement();
			}
			else if (flag2)
			{
				if (value2.Value != null)
				{
					writer.WriteStartElement(value2.Key);
					writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104939198), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521271730));
					writer.WriteString(value2.Value.ToString());
					writer.WriteEndElement();
				}
			}
			else
			{
				if (!(value2.Value is string))
				{
					continue;
				}
				try
				{
					writer.WriteElementString(value2.Key, XmlConvert.VerifyXmlChars(value2.Value.ToString()));
				}
				catch (Exception ex)
				{
					if (ex is XmlException)
					{
						writer.WriteStartElement(value2.Key);
						writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED83200), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889458610));
						string s = value2.Value.ToString();
						string value = BitConverter.ToString(Encoding.GetEncoding(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633287137)).GetBytes(s)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583741800), "");
						writer.WriteElementString(value2.Key, value);
						writer.WriteEndElement();
						continue;
					}
					throw ex;
				}
			}
		}
	}

	private void ConvertToXmlString(object obj, XmlWriter writer, EntitySerializationSettings settings, ExportRuleList rules = null, IMetadata metadataTrunc = null)
	{
		//Discarded unreachable code: IL_0149, IL_01dc, IL_01eb, IL_022f, IL_0250, IL_025f, IL_03a3, IL_03b2, IL_0660, IL_0698, IL_06a7, IL_070d, IL_0720, IL_072f, IL_075c, IL_07cb, IL_07fe, IL_083f, IL_084e, IL_08bc, IL_08cf, IL_08df, IL_08ee, IL_0988, IL_0997, IL_09a2, IL_0ad5, IL_0af8, IL_0b07, IL_0b55, IL_0c73, IL_0c82, IL_0c91, IL_0ca1, IL_0cb0, IL_0cd1, IL_0cf0, IL_0cff, IL_0d2c, IL_0d3b, IL_0e35, IL_0e44, IL_0e75
		int num = 17;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = default(_003C_003Ec__DisplayClass35_0);
		IExportRulesService serviceNotNull = default(IExportRulesService);
		IEntity entity = default(IEntity);
		ExportRuleList exportRuleList = default(ExportRuleList);
		ClassMetadata classMetadata2 = default(ClassMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass35_1 _003C_003Ec__DisplayClass35_2 = default(_003C_003Ec__DisplayClass35_1);
		object obj3 = default(object);
		PropertyInfo propertyCached = default(PropertyInfo);
		ISerializableTypeDescriptor serializableTypeDescriptor = default(ISerializableTypeDescriptor);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		string text = default(string);
		string assemblyQualifiedName = default(string);
		IDictionary<string, object> values = default(IDictionary<string, object>);
		IEnumerable<IPostEntityXmlSerializer> extensionPoints = default(IEnumerable<IPostEntityXmlSerializer>);
		IMetadataService service = default(IMetadataService);
		IEnumerator<ITablePartMetadata> enumerator2 = default(IEnumerator<ITablePartMetadata>);
		IEnumerable enumerable = default(IEnumerable);
		ITablePartMetadata current = default(ITablePartMetadata);
		IEnumerator enumerator3 = default(IEnumerator);
		IEntity obj2 = default(IEntity);
		while (true)
		{
			switch (num2)
			{
			case 18:
				classMetadata = InterfaceActivator.LoadMetadata(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MoWboyEwXoISnBUGhqwO(metadataTrunc), loadImplementation: false)) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 14:
				if (rules != null)
				{
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 12;
			case 12:
				classMetadata = null;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 17:
				_003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
				num2 = 16;
				break;
			case 13:
				_003C_003Ec__DisplayClass35_.legalPropertyUids = new List<Guid>();
				num2 = 19;
				break;
			case 22:
				serviceNotNull = Locator.GetServiceNotNull<IExportRulesService>();
				num2 = 20;
				break;
			default:
				if (classMetadata == null)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 21:
				entity = _003C_003Ec__DisplayClass35_.obj as IEntity;
				num2 = 24;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 21;
				}
				break;
			case 9:
				exportRuleList = new ExportRuleList();
				num2 = 14;
				break;
			case 2:
				return;
			case 10:
				return;
			case 11:
				return;
			case 28:
				classMetadata.Properties.ForEach(_003C_003Ec__DisplayClass35_._003CConvertToXmlString_003Eb__0);
				num2 = 8;
				break;
			case 5:
				if (classMetadata.Properties == null)
				{
					num2 = 23;
					break;
				}
				goto case 28;
			case 26:
				classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(_003C_003Ec__DisplayClass35_.obj.GetType());
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				if (entity == null)
				{
					num2 = 2;
					break;
				}
				goto case 3;
			case 27:
				try
				{
					while (true)
					{
						int num8;
						if (!enumerator.MoveNext())
						{
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num8 = 11;
							}
							goto IL_026e;
						}
						goto IL_052b;
						IL_052b:
						_003C_003Ec__DisplayClass35_2 = new _003C_003Ec__DisplayClass35_1();
						int num9 = 3;
						num8 = num9;
						goto IL_026e;
						IL_026e:
						while (true)
						{
							IDictionary<string, object> dictionary;
							switch (num8)
							{
							case 24:
								obj3 = oYqpqQEweUJc7wEv7AEK(propertyCached, _003C_003Ec__DisplayClass35_2.CS_0024_003C_003E8__locals1.obj, null);
								num8 = 28;
								continue;
							default:
								if (Gaw2BAEwnUwoSOJxbSMF(propertyCached, null))
								{
									num8 = 24;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
									{
										num8 = 38;
									}
									continue;
								}
								goto case 13;
							case 10:
								AspYVxEwpWNdVKxnTPL7(writer);
								num8 = 29;
								continue;
							case 27:
								if (exportRuleList.Any(_003C_003Ec__DisplayClass35_2._003CConvertToXmlString_003Eb__1))
								{
									num8 = 14;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
									{
										num8 = 15;
									}
									continue;
								}
								goto case 14;
							case 26:
								if (serializableTypeDescriptor != null)
								{
									num8 = 19;
									continue;
								}
								break;
							case 13:
								typeDescriptor = InterfaceActivator.Create<ITypeDescriptor>();
								num8 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
								{
									num8 = 23;
								}
								continue;
							case 12:
							case 15:
							case 20:
							case 29:
							case 35:
								break;
							case 14:
								if (classMetadata != null)
								{
									num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
									{
										num8 = 1;
									}
									continue;
								}
								goto case 31;
							case 18:
								text = (string)iO2vdlEwNqU60A1k97Ou(assemblyQualifiedName, text);
								num8 = 7;
								continue;
							case 3:
								_003C_003Ec__DisplayClass35_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass35_;
								num8 = 16;
								continue;
							case 22:
								throw new MetadataException(SR.T((string)vUM8fsEwZiwH4uU1iFhF(-234299632 ^ -234247808), txSZ1uEwa8ExwTX6BQVF(_003C_003Ec__DisplayClass35_2.propertyMetadata)));
							case 21:
								serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
								num8 = 26;
								continue;
							case 7:
							case 8:
								FsmskdEw3wh5DMgJ0AjP(writer, sl9cHsEwkRVXFdOG4PT1(_003C_003Ec__DisplayClass35_2.propertyMetadata));
								num8 = 9;
								continue;
							case 28:
								if (obj3 == null)
								{
									num8 = 12;
									continue;
								}
								goto case 4;
							case 4:
								text = ClassSerializationHelper.SerializeObjectByXml(obj3);
								num8 = 6;
								continue;
							case 31:
								propertyCached = _003C_003Ec__DisplayClass35_2.CS_0024_003C_003E8__locals1.obj.GetType().GetPropertyCached((string)sl9cHsEwkRVXFdOG4PT1(_003C_003Ec__DisplayClass35_2.propertyMetadata));
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num8 = 0;
								}
								continue;
							case 30:
								goto IL_052b;
							case 6:
								text = (string)fbE4TjEw1tcIbb6weFVj(text, 0, WCJKclEwPuyhZForHdW8(text, vUM8fsEwZiwH4uU1iFhF(0x3A5D5EF ^ 0x3A59A2F)) + 1);
								num8 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num8 = 2;
								}
								continue;
							case 9:
								writer.WriteAttributeString((string)vUM8fsEwZiwH4uU1iFhF(0x53FA00CE ^ 0x53FAB618), (string)vUM8fsEwZiwH4uU1iFhF(0x57A5235E ^ 0x57A53950));
								num8 = 37;
								continue;
							case 36:
								if (oYqpqQEweUJc7wEv7AEK(propertyCached, _003C_003Ec__DisplayClass35_2.CS_0024_003C_003E8__locals1.obj, null) != null)
								{
									num8 = 24;
									continue;
								}
								break;
							case 34:
								if (HZmpRFEw2KHUaAqkKduo(propertyCached))
								{
									num8 = 36;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
									{
										num8 = 36;
									}
									continue;
								}
								break;
							case 38:
								if (AttributeHelper<XmlExportAttribute>.GetAttribute(k5QRREEwOOUPmXqW6BQ5(propertyCached), inherited: true) != null)
								{
									num8 = 34;
									continue;
								}
								goto case 13;
							case 19:
								if (!(serializableTypeDescriptor is ListOfSimpleTypeDescriptor))
								{
									num8 = 17;
									continue;
								}
								dictionary = SpecialListOfSimpleTypeDescriptorSerialize(_003C_003Ec__DisplayClass35_2.CS_0024_003C_003E8__locals1.obj, classMetadata2, _003C_003Ec__DisplayClass35_2.propertyMetadata, settings);
								goto IL_0874;
							case 5:
								WriteValues(writer, values, extensionPoints, typeDescriptor);
								num8 = 35;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
								{
									num8 = 4;
								}
								continue;
							case 25:
								if (typeDescriptor != null)
								{
									num8 = 21;
									continue;
								}
								goto case 22;
							case 2:
								assemblyQualifiedName = obj3.GetType().AssemblyQualifiedName;
								num8 = 32;
								continue;
							case 1:
								if (!_003C_003Ec__DisplayClass35_2.CS_0024_003C_003E8__locals1.legalPropertyUids.Contains(bL9gvEEwTRQ7gkQebnEj(_003C_003Ec__DisplayClass35_2.propertyMetadata)))
								{
									num8 = 20;
									continue;
								}
								goto case 31;
							case 37:
								writer.WriteCData(text);
								num8 = 10;
								continue;
							case 16:
								_003C_003Ec__DisplayClass35_2.propertyMetadata = enumerator.Current;
								num8 = 27;
								continue;
							case 17:
								dictionary = serializableTypeDescriptor.Serialize(_003C_003Ec__DisplayClass35_2.CS_0024_003C_003E8__locals1.obj, classMetadata2, _003C_003Ec__DisplayClass35_2.propertyMetadata, settings);
								goto IL_0874;
							case 32:
								if (assemblyQualifiedName == null)
								{
									num8 = 8;
									continue;
								}
								goto case 18;
							case 23:
								typeDescriptor = null;
								num8 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num8 = 33;
								}
								continue;
							case 33:
								try
								{
									typeDescriptor = (ITypeDescriptor)sewialEwtujUYbunh7JE(service, txSZ1uEwa8ExwTX6BQVF(_003C_003Ec__DisplayClass35_2.propertyMetadata), tZrWIFEwD5gxZEJBG5oO(_003C_003Ec__DisplayClass35_2.propertyMetadata));
									int num10 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
									{
										num10 = 0;
									}
									switch (num10)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
									{
										num11 = 1;
									}
									while (true)
									{
										switch (num11)
										{
										case 1:
											UWDwMxEw4WNU300fKUuH(fT1t11EwwjudWsiWsx8Q(), ex);
											num11 = 0;
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
								}
								goto case 25;
							case 11:
								goto end_IL_03ef;
								IL_0874:
								values = dictionary;
								num8 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
								{
									num8 = 3;
								}
								continue;
							}
							break;
						}
						continue;
						end_IL_03ef:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					case 0:
						break;
					}
				}
				goto case 21;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 3;
							goto IL_08fd;
						}
						goto IL_0c4b;
						IL_08fd:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 9:
								AspYVxEwpWNdVKxnTPL7(writer);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
								{
									num3 = 11;
								}
								continue;
							case 6:
							case 8:
								enumerable = HR4TgUEwH6ZqnXGQJiSv(entity, F3KTWWEw6bWjQQXWk21M(current)) as IEnumerable;
								num3 = 4;
								continue;
							default:
								try
								{
									while (true)
									{
										IL_0a97:
										int num5;
										if (!Leai8PEwxDYPKDE4J09S(enumerator3))
										{
											num5 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
											{
												num5 = 2;
											}
											goto IL_09a6;
										}
										goto IL_09cc;
										IL_09cc:
										obj2 = (IEntity)enumerator3.Current;
										num5 = 6;
										goto IL_09a6;
										IL_09a6:
										while (true)
										{
											switch (num5)
											{
											case 5:
												break;
											default:
												AspYVxEwpWNdVKxnTPL7(writer);
												num5 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
												{
													num5 = 4;
												}
												continue;
											case 1:
												ConvertToXmlString(obj2, writer, settings);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
												{
													num5 = 0;
												}
												continue;
											case 2:
												YfOPAREw7uHpxKWMFA14(writer, vUM8fsEwZiwH4uU1iFhF(-105199646 ^ -105216640), MoWboyEwXoISnBUGhqwO(current).ToString());
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
												{
													num5 = 0;
												}
												continue;
											case 6:
												FsmskdEw3wh5DMgJ0AjP(writer, v0EMGDEwAUyTDIODA9ar(current));
												num5 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
												{
													num5 = 2;
												}
												continue;
											case 4:
												goto IL_0a97;
											case 3:
												goto end_IL_0a97;
											}
											break;
										}
										goto IL_09cc;
										continue;
										end_IL_0a97:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator3 as IDisposable;
									int num6 = 3;
									while (true)
									{
										switch (num6)
										{
										case 2:
											break;
										case 1:
											U13vRcEwqbO12D5U6VOJ(disposable);
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
											{
												num6 = 0;
											}
											continue;
										case 3:
											if (disposable == null)
											{
												num6 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
												{
													num6 = 2;
												}
												continue;
											}
											goto case 1;
										case 0:
											break;
										}
										break;
									}
								}
								goto case 9;
							case 14:
								enumerator3 = enumerable.GetEnumerator();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								YfOPAREw7uHpxKWMFA14(writer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881895112), vUM8fsEwZiwH4uU1iFhF(0x12A5FAC7 ^ 0x12A5E0C9));
								num3 = 14;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num3 = 11;
								}
								continue;
							case 13:
								if (!NeedBindTablePart(current))
								{
									num3 = 12;
									continue;
								}
								goto case 6;
							case 4:
								if (enumerable == null)
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
									{
										num3 = 10;
									}
									continue;
								}
								goto case 2;
							case 2:
								FsmskdEw3wh5DMgJ0AjP(writer, v0EMGDEwAUyTDIODA9ar(current));
								num3 = 5;
								continue;
							case 10:
							case 11:
							case 12:
								break;
							case 1:
								if (NeedBindTablePart == null)
								{
									int num4 = 8;
									num3 = num4;
									continue;
								}
								goto case 13;
							case 7:
								goto IL_0c4b;
							}
							break;
						}
						continue;
						IL_0c4b:
						current = enumerator2.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num3 = 0;
						}
						goto IL_08fd;
					}
				}
				finally
				{
					int num7;
					if (enumerator2 == null)
					{
						num7 = 2;
						goto IL_0cd5;
					}
					goto IL_0d0a;
					IL_0cd5:
					switch (num7)
					{
					default:
						goto end_IL_0cc0;
					case 2:
						goto end_IL_0cc0;
					case 1:
						break;
					case 0:
						goto end_IL_0cc0;
					}
					goto IL_0d0a;
					IL_0d0a:
					enumerator2.Dispose();
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num7 = 0;
					}
					goto IL_0cd5;
					end_IL_0cc0:;
				}
			case 20:
				exportRuleList.AddRange((IEnumerable<ExportRule>)XS63qoEwKOFLbm594r6w(serviceNotNull, _003C_003Ec__DisplayClass35_.obj as IEntity, rules));
				num2 = 12;
				break;
			case 3:
				enumerator2 = ((ITablePartContainer)classMetadata2).TableParts.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 16:
				_003C_003Ec__DisplayClass35_.obj = obj;
				num2 = 29;
				break;
			case 15:
				service = MetadataServiceContext.Service;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 6;
				}
				break;
			case 29:
				ugh7rFEwIUytycXJwHIJ(_003C_003Ec__DisplayClass35_.obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103F4AFD));
				num2 = 26;
				break;
			case 6:
				enumerator = classMetadata2.Properties.GetEnumerator();
				num2 = 27;
				break;
			case 24:
				if (!(classMetadata2 is ITablePartContainer))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 7;
			case 19:
				if (metadataTrunc == null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 25;
					}
					break;
				}
				goto case 18;
			case 4:
			case 8:
			case 23:
				extensionPoints = ComponentManager.Current.GetExtensionPoints<IPostEntityXmlSerializer>();
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public Dictionary<string, Dictionary<string, object>> XmlEntityRead(XmlReader reader, Dictionary<string, Dictionary<string, object>> propValues, Guid typeUid)
	{
		return XmlEntityRead(reader, propValues, null, null, typeUid);
	}

	public Dictionary<string, Dictionary<string, object>> XmlEntityRead(XmlReader reader, Dictionary<string, Dictionary<string, object>> propValues, MergeReplace mergeReplace, Guid typeUid)
	{
		return XmlEntityRead(reader, propValues, null, mergeReplace, typeUid);
	}

	public Dictionary<string, Dictionary<string, object>> XmlEntityRead(XmlReader reader, Dictionary<string, Dictionary<string, object>> propValues, MergeUidReplace mergeUidReplace, MergeReplace mergeReplace, Guid typeUid)
	{
		if (mergeUidReplace == null)
		{
			mergeUidReplace = new MergeUidReplace();
		}
		if (mergeReplace == null)
		{
			mergeReplace = new MergeReplace();
		}
		Contract.ArgumentNotNull(reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867153517));
		Contract.ArgumentNotNull(propValues, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088076888));
		Contract.ArgumentNotNull(propValues[ConfigurationImportExecutor.RegularProperty], z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -542024959));
		Contract.ArgumentNotNull(propValues[ConfigurationImportExecutor.XmlProperty], z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AF2C12));
		IEnumerable<IPostEntityXmlSerializer> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPostEntityXmlSerializer>();
		while (reader.NodeType != XmlNodeType.EndElement)
		{
			string nameReplaceProperty = mergeReplace.GetNameReplaceProperty(typeUid, reader.Name);
			if (!reader.IsEmptyElement)
			{
				if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939606162)) != null)
				{
					reader.MoveToElement();
					SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
					serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A59555), GetStringMergeUid(typeUid, reader.ReadString(), mergeUidReplace));
					if (!propValues[ConfigurationImportExecutor.RegularProperty].ContainsKey(nameReplaceProperty))
					{
						propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, serializableDictionary);
					}
					reader.Read();
				}
				else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F1E14C)) != null)
				{
					SerializableList<object> serializableList = new SerializableList<object>();
					reader.Read();
					while (reader.NodeType != XmlNodeType.EndElement)
					{
						reader.MoveToElement();
						SerializableDictionary<string, object> serializableDictionary2 = new SerializableDictionary<string, object>();
						serializableDictionary2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459583821), GetStringMergeUid(typeUid, reader.ReadElementString(), mergeUidReplace));
						serializableList.Add(serializableDictionary2);
						reader.Read();
					}
					propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, serializableList);
					reader.Read();
				}
				else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECADB50)) != null)
				{
					SerializableList<object> serializableList2 = new SerializableList<object>();
					reader.Read();
					reader.MoveToContent();
					Guid.TryParse(reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088321094)), out var result);
					while (reader.NodeType != XmlNodeType.EndElement)
					{
						Dictionary<string, Dictionary<string, object>> dictionary = new Dictionary<string, Dictionary<string, object>>();
						dictionary.Add(ConfigurationImportExecutor.RegularProperty, new Dictionary<string, object>());
						dictionary.Add(ConfigurationImportExecutor.XmlProperty, new Dictionary<string, object>());
						reader.Read();
						reader.MoveToContent();
						dictionary = XmlEntityRead(reader, dictionary, mergeUidReplace, mergeReplace, result);
						serializableList2.Add(dictionary[ConfigurationImportExecutor.RegularProperty]);
						reader.Read();
						reader.MoveToContent();
					}
					propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, serializableList2);
					reader.Read();
				}
				else
				{
					string attribute = reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123686838));
					string attribute2 = reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E096C9));
					if (attribute != null || attribute2 != null)
					{
						reader.MoveToElement();
						string text = reader.ReadString();
						int num = text.Length / 2;
						byte[] array = new byte[num];
						for (int i = 0; i < num; i++)
						{
							array[i] = Convert.ToByte(text.Substring(i * 2, 2), 16);
						}
						propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, array);
						reader.Read();
					}
					else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921224447)) != null)
					{
						reader.Read();
						reader.MoveToElement();
						string text2 = reader.Value;
						foreach (IPostEntityXmlSerializer item in extensionPoints)
						{
							text2 = item.UndoReplace(text2);
						}
						propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, text2);
						reader.Read();
						reader.Read();
					}
					else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740302078)) != null)
					{
						reader.Read();
						reader.MoveToElement();
						string value = reader.Value;
						Type type = Type.GetType(value.Substring(0, value.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E2344C))));
						value = value.Remove(0, value.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921218555)));
						StringBuilder stringBuilder = new StringBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921104165));
						stringBuilder.AppendLine(value);
						string xml = stringBuilder.ToString().Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20267971), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7FCEE)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606863094), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63808A4F))
							.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECE4CAE), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3324124));
						propValues[ConfigurationImportExecutor.XmlProperty].Add(nameReplaceProperty, ClassSerializationHelper.DeserializeObjectByXml(type, xml));
						reader.Read();
						reader.Read();
					}
					else if (reader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837894071)) != null)
					{
						reader.MoveToElement();
						string text3 = reader.ReadString();
						int num2 = text3.Length / 2;
						byte[] array2 = new byte[num2];
						for (int j = 0; j < num2; j++)
						{
							array2[j] = Convert.ToByte(text3.Substring(j * 2, 2), 16);
						}
						string @string = Encoding.GetEncoding(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1A6B52)).GetString(array2);
						propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, @string);
						reader.Read();
					}
					else
					{
						reader.MoveToElement();
						string value2 = reader.ReadString();
						propValues[ConfigurationImportExecutor.RegularProperty].Add(nameReplaceProperty, GetStringMergeUid(typeUid, value2, mergeUidReplace));
						reader.Read();
					}
				}
			}
			else
			{
				reader.Skip();
			}
			reader.MoveToContent();
		}
		return propValues;
	}

	public LinksDictionary Deserialize(object obj, Dictionary<string, object> serObj)
	{
		Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1C787));
		Contract.ArgumentNotNull(serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710504374));
		Guid result;
		if (serObj.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51156D8F)))
		{
			Guid.TryParse(serObj[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD53FC2)].ToString(), out result);
		}
		else
		{
			result = Guid.Empty;
		}
		Guid baseObjTypeUid = Guid.Empty;
		if (obj is IEntity)
		{
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(obj.CastAsRealType().GetType());
			if (classMetadata != null)
			{
				baseObjTypeUid = classMetadata.Uid;
			}
		}
		return ConvertFromSerializable(obj, result, baseObjTypeUid, serObj);
	}

	private LinksDictionary ConvertFromSerializable(Dictionary<string, object> serObj, Guid baseObjUid, Guid baseObjTypeUid, Type entityType, out IEntity tpItem)
	{
		Contract.ArgumentNotNull(serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A0128F));
		Contract.ArgumentNotNull(entityType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477118898));
		object obj = TryDeserializeEntityId(serObj, entityType);
		Guid? guid = TryDeserializeEntityUid(serObj, entityType);
		object obj2 = null;
		IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entityType);
		if (entityManagerOrNull != null)
		{
			if (obj != null)
			{
				obj2 = entityManagerOrNull.LoadOrNull(obj);
			}
			if (obj2 == null && guid.HasValue)
			{
				obj2 = entityManagerOrNull.LoadOrNull(guid.Value);
			}
		}
		if (obj2 == null)
		{
			obj2 = InterfaceActivator.Create(entityType);
		}
		IEntity entity = (tpItem = obj2 as IEntity);
		if (obj != null)
		{
			entity?.SetId(obj);
		}
		return ConvertFromSerializable(obj2, baseObjUid, baseObjTypeUid, serObj);
	}

	private LinksDictionary ConvertFromSerializable(object obj, Guid baseObjUid, Guid baseObjTypeUid, Dictionary<string, object> serObj)
	{
		Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AC40F5));
		Contract.ArgumentNotNull(serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195666027));
		LinksDictionary linksDictionary = new LinksDictionary();
		IEntity entity = obj as IEntity;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(obj.CastAsRealType().GetType());
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		foreach (PropertyMetadata property in classMetadata.Properties)
		{
			if (PropertyFilter != null && !PropertyFilter(property))
			{
				continue;
			}
			ITypeDescriptor typeDescriptor = serviceNotNull.GetTypeDescriptor(property.TypeUid, property.SubTypeUid);
			if (typeDescriptor == null)
			{
				throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195666043), property.TypeUid));
			}
			if (!(typeDescriptor is ISerializableTypeDescriptor serializableTypeDescriptor))
			{
				continue;
			}
			if (serializableTypeDescriptor is ListOfSimpleTypeDescriptor)
			{
				SpecialListOfSimpleTypeDescriptorDeserialize(obj, classMetadata, property, serObj);
			}
			else
			{
				serializableTypeDescriptor.Deserialize(obj, classMetadata, property, serObj);
			}
			if (obj == null || !(property.Settings is EntitySettings))
			{
				continue;
			}
			PropertyInfo propertyCached = obj.GetType().GetPropertyCached(property.Name);
			object value = propertyCached.GetValue(obj, null);
			if (!(value is IEntity) && !(value is IEnumerable))
			{
				continue;
			}
			if (value is IEntity)
			{
				if (!(value is IEntityMetadata) && ((IEntity)value).IsNew())
				{
					if (serObj != null && Guid.TryParse(value.GetType().GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42645D91)).GetValue(value, null)
						.ToString(), out var result))
					{
						linksDictionary.AddLink(new LinksDictionaryItem(baseObjUid, baseObjTypeUid, property.Name, result, property.Uid));
					}
					propertyCached.SetValue(obj, null, null);
				}
				continue;
			}
			IEnumerable enumerable = (IEnumerable)propertyCached.GetValue(obj, null);
			IUntypedCollectionProxy untypedCollectionProxy = enumerable.AsUntypedISet();
			if (untypedCollectionProxy == null)
			{
				continue;
			}
			List<IEntity> list = new List<IEntity>();
			foreach (IEntity item in enumerable)
			{
				if (item.IsNew() && !(item is IEntityMetadata))
				{
					if (serObj != null && Guid.TryParse(item.GetType().GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137990547)).GetValue(item, null)
						.ToString(), out var result2))
					{
						linksDictionary.AddLink(new LinksDictionaryItem(baseObjUid, baseObjTypeUid, property.Name, result2, property.Uid));
					}
					list.Add(item);
				}
			}
			foreach (IEntity item2 in list)
			{
				untypedCollectionProxy.Remove(item2);
			}
		}
		if (classMetadata is ITablePartContainer && entity != null)
		{
			foreach (ITablePartMetadata tablePart in ((ITablePartContainer)classMetadata).TableParts)
			{
				if (NeedBindTablePart == null || NeedBindTablePart(tablePart))
				{
					UntypedISetProxy untypedISetProxy = new UntypedISetProxy(entity.GetPropertyValue(tablePart.TablePartPropertyUid));
					if (untypedISetProxy != null && serObj != null && serObj.TryGetValue(tablePart.TablePartPropertyName, out var value2))
					{
						IEnumerable enumerable2 = value2 as IEnumerable;
						Type typeByUid = serviceNotNull.GetTypeByUid(tablePart.Uid);
						if (enumerable2 != null)
						{
							foreach (object item3 in enumerable2)
							{
								if (item3 is Dictionary<string, object> dictionary)
								{
									IEntity tpItem;
									LinksDictionary linksDictionary2 = ConvertFromSerializable(dictionary, baseObjUid, baseObjTypeUid, typeByUid, out tpItem);
									if (linksDictionary2 != null && linksDictionary2.Any())
									{
										dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53CC331), out var value3);
										Guid result3 = Guid.Empty;
										if (value3 != null)
										{
											Guid.TryParse(value3.ToString(), out result3);
										}
										foreach (LinksDictionaryItem item4 in linksDictionary2.OfType<LinksDictionaryItem>())
										{
											item4.TablePartUid = result3;
										}
										linksDictionary.AddRange(linksDictionary2);
									}
									tpItem?.SetPropertyValue(tablePart.ParentPropertyUid, entity);
									untypedISetProxy.Add(tpItem);
								}
							}
						}
					}
				}
			}
			return linksDictionary;
		}
		return linksDictionary;
	}

	protected virtual object TryDeserializeEntityId(IDictionary<string, object> dictionary, Type entityType)
	{
		if (dictionary != null && dictionary.TryGetValue(IdPropertyName, out var value))
		{
			return ModelHelper.TryConvertEntityId(entityType, value);
		}
		return null;
	}

	protected virtual Guid? TryDeserializeEntityUid(IDictionary<string, object> dictionary, Type entityType)
	{
		if (dictionary != null && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D9E61), out var value))
		{
			if (value == null)
			{
				return null;
			}
			if (Guid.TryParse(value.ToString(), out var result))
			{
				return result;
			}
		}
		return null;
	}

	private string GetStringMergeUid(Guid typeUid, string value, MergeUidReplace mergeUidReplace)
	{
		//Discarded unreachable code: IL_007c
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		Guid result = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return value;
			case 3:
				guid = ayTpDyEw0ZdqgqvxdHVV(mergeUidReplace, result);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				result = Guid.Empty;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return guid.ToString();
			default:
				if (Guid.TryParse(value, out result))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			}
		}
	}

	public EntityXmlSerializer()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		hNOyZWEwmhXePdwbNDTZ();
		fileUids = new List<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityXmlSerializer()
	{
		int num = 1;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				IdPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IEntity<object>, object>>((Expression)cLpvKtEw94aQpKBkrD1g(parameterExpression, (MethodInfo)HLED49EwJ1BEH72ntwtR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<object>).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			default:
				parameterExpression = (ParameterExpression)wHjfYsEwMLOJKLVc8019(T9L9vDEwytmIdZIFPEW4(typeof(IEntity<object>).TypeHandle), vUM8fsEwZiwH4uU1iFhF(-882126494 ^ -882157238));
				num2 = 3;
				break;
			case 1:
				hNOyZWEwmhXePdwbNDTZ();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static int T2FyQQEwvtCdhsGt2w2q(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	internal static object lxKJpxEw87ML3nTCDJJZ(object P_0, int P_1, int P_2)
	{
		return BitConverter.ToString((byte[])P_0, P_1, P_2);
	}

	internal static object vUM8fsEwZiwH4uU1iFhF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object PijegnEwuegmnIg3qU3U(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool BZdW5lEwQf2myOuDcZln()
	{
		return zDYcnpEwfEGtSddPMSkb == null;
	}

	internal static EntityXmlSerializer kJ30mpEwCA1mNp8BgQTR()
	{
		return zDYcnpEwfEGtSddPMSkb;
	}

	internal static void ugh7rFEwIUytycXJwHIJ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static int bxIZCSEwVKISouZYKRSy(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static byte g30cCOEwSTDdQgQJC3gC(object P_0, int P_1)
	{
		return Convert.ToByte((string)P_0, P_1);
	}

	internal static object oyjoxoEwiHptCUlKXBN7(object P_0, int offset, int length, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, offset, length, writable);
	}

	internal static Type f4o1gkEwRR7CtUNc8Z0y(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static void U13vRcEwqbO12D5U6VOJ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object XS63qoEwKOFLbm594r6w(object P_0, object P_1, object P_2)
	{
		return ((IExportRulesService)P_0).BaseMerge((IEntity)P_1, (ExportRuleList)P_2);
	}

	internal static Guid MoWboyEwXoISnBUGhqwO(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static Guid bL9gvEEwTRQ7gkQebnEj(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object sl9cHsEwkRVXFdOG4PT1(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool Gaw2BAEwnUwoSOJxbSMF(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Type k5QRREEwOOUPmXqW6BQ5(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool HZmpRFEw2KHUaAqkKduo(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static object oYqpqQEweUJc7wEv7AEK(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static int WCJKclEwPuyhZForHdW8(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object fbE4TjEw1tcIbb6weFVj(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object iO2vdlEwNqU60A1k97Ou(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void FsmskdEw3wh5DMgJ0AjP(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteStartElement((string)P_1);
	}

	internal static void AspYVxEwpWNdVKxnTPL7(object P_0)
	{
		((XmlWriter)P_0).WriteEndElement();
	}

	internal static Guid txSZ1uEwa8ExwTX6BQVF(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid tZrWIFEwD5gxZEJBG5oO(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object sewialEwtujUYbunh7JE(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object fT1t11EwwjudWsiWsx8Q()
	{
		return Logger.Log;
	}

	internal static void UWDwMxEw4WNU300fKUuH(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static Guid F3KTWWEw6bWjQQXWk21M(object P_0)
	{
		return ((ITablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static object HR4TgUEwH6ZqnXGQJiSv(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static object v0EMGDEwAUyTDIODA9ar(object P_0)
	{
		return ((ITablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static void YfOPAREw7uHpxKWMFA14(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteAttributeString((string)P_1, (string)P_2);
	}

	internal static bool Leai8PEwxDYPKDE4J09S(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Guid ayTpDyEw0ZdqgqvxdHVV(object P_0, Guid uidFrom)
	{
		return ((MergeUidReplace)P_0).GetUidReplace(uidFrom);
	}

	internal static void hNOyZWEwmhXePdwbNDTZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type T9L9vDEwytmIdZIFPEW4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object wHjfYsEwMLOJKLVc8019(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object HLED49EwJ1BEH72ntwtR(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object cLpvKtEw94aQpKBkrD1g(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}
}
