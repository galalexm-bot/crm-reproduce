using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 650)]
public class DataClassDescriptor : RefTypeDescriptor<IDataClass, DataClassSettings>
{
	public const string typeRef = "$t";

	public const string UID_S = "{44AB0155-A95C-4962-9504-8C6B26DD7652}";

	public static readonly Guid UID;

	private static readonly ConcurrentDictionary<string, (Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid)> DtoTypes;

	private static readonly (Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid) EmptyType;

	private static string loadFromMetadataItemHeaderQuery;

	private static string loadFromModuleReferenceQuery;

	private static readonly XmlObjectSerializableType xmlObjSerType;

	internal static DataClassDescriptor zOwu5po6qZjM4am1qQuq;

	[XmlIgnore]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EntityDescriptor EntityDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityDescriptor_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CEntityDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override Guid Uid => UID;

	public override string Name => SR.T((string)eSprIwo6TamAeViS3ORw(0x63ABA4E8 ^ 0x63A9D8B2));

	public override Guid ParentUid => Guid.Empty;

	public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		return Enumerable.Empty<ITypeDescriptor>();
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return new PropertyValueContainer<object>();
	}

	public override IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings serializationSettings)
	{
		if (obj == null)
		{
			return null;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675491711));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A63F4D));
		Contract.CheckArgument(propertyMetadata.Settings is DataClassSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978618756));
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		bool flag = serializationSettings?.WriteReferences ?? false;
		using (ReferenceResolverSerializer.CreateResolver(ReferenceResolverSerializer.CurrentResolver != null || flag))
		{
			object value = property.GetValue(obj, null);
			SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
			if (value != null)
			{
				switch (((DataClassSettings)propertyMetadata.Settings).RelationType)
				{
				case RelationType.OneToOne:
					serializableDictionary[propertyMetadata.Name] = SerializeSimple(value, value.GetType(), serializationSettings);
					break;
				case RelationType.OneToMany:
				case RelationType.ManyToMany:
				case RelationType.ManyToManyInverse:
				{
					if (!(value is IEnumerable enumerable))
					{
						break;
					}
					SerializableList<object> serializableList = new SerializableList<object>();
					try
					{
						foreach (object item in enumerable)
						{
							serializableList.Add((item == null) ? null : SerializeSimple(item, item.GetType(), serializationSettings));
						}
						serializableDictionary[propertyMetadata.Name] = serializableList;
					}
					catch (Exception ex)
					{
						base.Logger.Log(LogLevel.Error, ex, ex.Message);
					}
					break;
				}
				}
			}
			else
			{
				serializableDictionary[propertyMetadata.Name] = null;
			}
			return serializableDictionary;
		}
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_008b, IL_009a, IL_00f4, IL_011c, IL_0159, IL_0168, IL_01f5, IL_0204, IL_02b7, IL_02c6, IL_0389, IL_0398, IL_0415, IL_044d, IL_0490, IL_04af, IL_04be, IL_04db, IL_04ea, IL_0594, IL_05cc, IL_05db, IL_05ee, IL_0603
		int num = 4;
		int num2 = num;
		DataClass dataClass = default(DataClass);
		IDisposable disposable = default(IDisposable);
		bool flag = default(bool);
		IEnumerator<DataClassMetadata> enumerator = default(IEnumerator<DataClassMetadata>);
		DataClassMetadata current = default(DataClassMetadata);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		IEnumerator<KeyValuePair<string, object>> enumerator2 = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current2 = default(KeyValuePair<string, object>);
		SerializableDictionary<string, object> serializableDictionary = default(SerializableDictionary<string, object>);
		string key = default(string);
		object result = default(object);
		while (true)
		{
			int num11;
			switch (num2)
			{
			case 7:
				return null;
			case 3:
				if ((object)(dataClass = value as DataClass) != null)
				{
					num2 = 2;
					continue;
				}
				goto case 8;
			default:
				disposable = (IDisposable)RFxlNDo6n5QlX9P3QVPp(yHwM9Jo6kJNPvqmt1wFA() != null || flag);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 2;
				}
				continue;
			case 5:
				try
				{
					HashSet<Guid> orAdd = ContextVars.GetOrAdd((string)eSprIwo6TamAeViS3ORw(0x7E6E5A0B ^ 0x7E6E84C3), () => new HashSet<Guid>());
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						default:
							try
							{
								while (true)
								{
									IL_01c9:
									int num4;
									if (!RnSriio63Z3R8nInpuiY(enumerator))
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
										{
											num4 = 0;
										}
										goto IL_012a;
									}
									goto IL_018c;
									IL_018c:
									current = enumerator.Current;
									int num5 = 4;
									num4 = num5;
									goto IL_012a;
									IL_012a:
									while (true)
									{
										switch (num4)
										{
										case 4:
											orAdd.Add(uNt6Lko62Woh6Ojggfjo(current));
											num4 = 6;
											continue;
										case 2:
											break;
										case 6:
											if ((dictionary = new EntityJsonSerializer().ConvertToSerializable(dataClass, current, settings) as IDictionary<string, object>) == null)
											{
												num4 = 3;
												continue;
											}
											goto default;
										case 3:
										case 7:
											goto IL_01c9;
										case 5:
											try
											{
												while (true)
												{
													IL_0314:
													int num6;
													if (!enumerator2.MoveNext())
													{
														num6 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
														{
															num6 = 1;
														}
														goto IL_0213;
													}
													goto IL_02fd;
													IL_02fd:
													current2 = enumerator2.Current;
													int num7 = 8;
													num6 = num7;
													goto IL_0213;
													IL_0213:
													while (true)
													{
														switch (num6)
														{
														case 7:
															serializableDictionary[key] = current2.Value;
															num6 = 6;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
															{
																num6 = 2;
															}
															continue;
														case 2:
															result = new SerializableDictionary<string, object> { 
															{
																(string)eSprIwo6TamAeViS3ORw(--1867379187 ^ 0x6F4C87A1),
																current2.Value
															} };
															num6 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
															{
																num6 = 3;
															}
															continue;
														case 5:
															if (Unx6Iao6e3ICR970CKAd(key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751229006)))
															{
																num6 = 2;
																continue;
															}
															goto case 4;
														case 9:
															break;
														case 6:
														case 10:
															goto IL_0314;
														case 8:
															key = current2.Key;
															num6 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
															{
																num6 = 5;
															}
															continue;
														case 4:
															if (key == (string)eSprIwo6TamAeViS3ORw(-812025778 ^ -812118512))
															{
																num6 = 7;
																continue;
															}
															goto default;
														default:
															serializableDictionary[(string)fTTPMvo61fGJFAhNab7d(RvBNNZo6P3NCSaRhc0GC(current), eSprIwo6TamAeViS3ORw(0x7C1EE318 ^ 0x7C1EB7FA), key)] = current2.Value;
															num6 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
															{
																num6 = 10;
															}
															continue;
														case 1:
															goto end_IL_0314;
														case 3:
															return result;
														}
														break;
													}
													goto IL_02fd;
													continue;
													end_IL_0314:
													break;
												}
											}
											finally
											{
												if (enumerator2 != null)
												{
													int num8 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
													{
														num8 = 0;
													}
													while (true)
													{
														switch (num8)
														{
														case 1:
															h1rS5Do6NjXJMcQLaALk(enumerator2);
															num8 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
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
											goto IL_01c9;
										default:
											enumerator2 = dictionary.GetEnumerator();
											num4 = 5;
											continue;
										case 1:
											goto end_IL_01c9;
										}
										break;
									}
									goto IL_018c;
									continue;
									end_IL_01c9:
									break;
								}
							}
							finally
							{
								int num9;
								if (enumerator == null)
								{
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
									{
										num9 = 1;
									}
									goto IL_0494;
								}
								goto IL_04c9;
								IL_04c9:
								h1rS5Do6NjXJMcQLaALk(enumerator);
								num9 = 2;
								goto IL_0494;
								IL_0494:
								switch (num9)
								{
								case 1:
									goto end_IL_046f;
								case 2:
									goto end_IL_046f;
								}
								goto IL_04c9;
								end_IL_046f:;
							}
							goto case 1;
						case 4:
							serializableDictionary = new SerializableDictionary<string, object> { 
							{
								z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542849677),
								oEXoDIo6ObLmu3vYAwMm((DataClass)value)
							} };
							num3 = 3;
							break;
						case 3:
							enumerator = dataClass.GetIncludes(onlyFilled: true).GetEnumerator();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							result = serializableDictionary;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							return result;
						}
					}
				}
				finally
				{
					if (disposable != null)
					{
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num10 = 0;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								h1rS5Do6NjXJMcQLaALk(disposable);
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
								{
									num10 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 6:
				return result;
			case 1:
				num11 = (settings.WriteReferences ? 1 : 0);
				break;
			case 8:
				return null;
			case 2:
				if (settings != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num11 = 0;
				break;
			case 4:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 7;
			}
			flag = (byte)num11 != 0;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
			{
				num2 = 0;
			}
		}
	}

	public override void Deserialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.obj = obj;
		_003C_003Ec__DisplayClass17_._003C_003E4__this = this;
		if (_003C_003Ec__DisplayClass17_.obj == null || values == null)
		{
			return;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63ABEDD6));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867807970));
		Contract.CheckArgument(propertyMetadata.Settings is DataClassSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740480678));
		_003C_003Ec__DisplayClass17_.obj = _003C_003Ec__DisplayClass17_.obj.CastAsRealType();
		_003C_003Ec__DisplayClass17_.propInfo = _003C_003Ec__DisplayClass17_.obj.GetProperty(metadata, propertyMetadata);
		if (_003C_003Ec__DisplayClass17_.propInfo == null || !_003C_003Ec__DisplayClass17_.propInfo.CanWrite || !values.TryGetValue(propertyMetadata.Name, out var value))
		{
			return;
		}
		using (ReferenceResolverSerializer.CreateResolver(needResolver: true))
		{
			object serializerMarker = new object();
			EntityJsonSerializer.AddSerializerMarker(serializerMarker);
			switch (((DataClassSettings)propertyMetadata.Settings).RelationType)
			{
			case RelationType.OneToOne:
			{
				_003C_003Ec__DisplayClass17_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass17_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass17_;
				CS_0024_003C_003E8__locals1.dataClassType = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propInfo.PropertyType;
				object obj3 = DeserializeSimple(value, CS_0024_003C_003E8__locals1.dataClassType);
				if ((CS_0024_003C_003E8__locals1.func = obj3 as Func<object>) != null)
				{
					EntityJsonSerializer.AddAction(delegate
					{
						int num = 2;
						int num2 = num;
						object obj4 = default(object);
						while (true)
						{
							switch (num2)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								obj4 = CS_0024_003C_003E8__locals1.func();
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
								{
									num2 = 1;
								}
								break;
							case 1:
								_003C_003Ec__DisplayClass17_1.lGLqSaCuVi4j43ahi4fl(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propInfo, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.obj, _003C_003Ec__DisplayClass17_1.CGCclTCuIohIr0KTrlyR((DataClass)obj4, CS_0024_003C_003E8__locals1.dataClassType) ?? obj4, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num2 = 0;
								}
								break;
							}
						}
					});
				}
				else if (obj3 != null)
				{
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propInfo.SetValue(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.obj, obj3, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
				}
				break;
			}
			case RelationType.OneToMany:
			case RelationType.ManyToMany:
			case RelationType.ManyToManyInverse:
			{
				if (!(value is IEnumerable source))
				{
					break;
				}
				IEnumerable<object> enumerable = source.Cast<object>();
				int length = enumerable.Count();
				if (_003C_003Ec__DisplayClass17_.propInfo.PropertyType.IsArray)
				{
					_003C_003Ec__DisplayClass17_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_2();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass17_;
					CS_0024_003C_003E8__locals0.elementType = EnumerableExtensions.GetElementType(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.propInfo.PropertyType);
					CS_0024_003C_003E8__locals0.array = Array.CreateInstance(CS_0024_003C_003E8__locals0.elementType, length);
					enumerable.ForEach(delegate(object item, int index)
					{
						int num5 = 7;
						int num6 = num5;
						_003C_003Ec__DisplayClass17_3 _003C_003Ec__DisplayClass17_5 = default(_003C_003Ec__DisplayClass17_3);
						Func<object> func = default(Func<object>);
						object obj6 = default(object);
						while (true)
						{
							switch (num6)
							{
							case 8:
								_003C_003Ec__DisplayClass17_5.index = index;
								num6 = 5;
								break;
							case 6:
								_003C_003Ec__DisplayClass17_5.CS_0024_003C_003E8__locals3 = CS_0024_003C_003E8__locals0;
								num6 = 8;
								break;
							case 3:
								return;
							case 2:
								if (func == null)
								{
									DataClassDescriptor._003C_003Ec__DisplayClass17_2.LJlwbgCuXqHhk2qhlVwc(CS_0024_003C_003E8__locals0.array, _003C_003Ec__DisplayClass17_5.index, obj6);
									num6 = 4;
								}
								else
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num6 = 1;
									}
								}
								break;
							case 4:
								return;
							case 7:
								_003C_003Ec__DisplayClass17_5 = new _003C_003Ec__DisplayClass17_3();
								num6 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
								{
									num6 = 0;
								}
								break;
							default:
								func = (_003C_003Ec__DisplayClass17_5.func = obj6 as Func<object>);
								num6 = 2;
								break;
							case 1:
								DataClassDescriptor._003C_003Ec__DisplayClass17_2.yJcV36CuKmHSvnQgJUZt(new Action(_003C_003Ec__DisplayClass17_5._003CDeserialize_003Eb__2));
								num6 = 3;
								break;
							case 5:
								obj6 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2._003C_003E4__this.DeserializeSimple(item, CS_0024_003C_003E8__locals0.elementType);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num6 = 0;
								}
								break;
							}
						}
					});
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.propInfo.SetValue(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.obj, CS_0024_003C_003E8__locals0.array, null);
					break;
				}
				_003C_003Ec__DisplayClass17_4 _003C_003Ec__DisplayClass17_2 = new _003C_003Ec__DisplayClass17_4();
				_003C_003Ec__DisplayClass17_2.propValue = (IList)_003C_003Ec__DisplayClass17_.propInfo.GetValue(_003C_003Ec__DisplayClass17_.obj, null);
				_003C_003Ec__DisplayClass17_2.propValue.Clear();
				_003C_003Ec__DisplayClass17_2.dataClassType = _003C_003Ec__DisplayClass17_.propInfo.PropertyType.GetGenericArguments()[0];
				foreach (object item in enumerable)
				{
					_003C_003Ec__DisplayClass17_5 _003C_003Ec__DisplayClass17_3 = new _003C_003Ec__DisplayClass17_5();
					_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals4 = _003C_003Ec__DisplayClass17_2;
					object obj2 = DeserializeSimple(item, _003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals4.dataClassType);
					if ((_003C_003Ec__DisplayClass17_3.func = obj2 as Func<object>) != null)
					{
						_003C_003Ec__DisplayClass17_6 _003C_003Ec__DisplayClass17_4 = new _003C_003Ec__DisplayClass17_6();
						_003C_003Ec__DisplayClass17_4.CS_0024_003C_003E8__locals5 = _003C_003Ec__DisplayClass17_3;
						_003C_003Ec__DisplayClass17_4.index = _003C_003Ec__DisplayClass17_4.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.propValue.Count;
						EntityJsonSerializer.AddAction(delegate
						{
							int num3 = 1;
							int num4 = num3;
							object obj5 = default(object);
							while (true)
							{
								switch (num4)
								{
								case 1:
									_003C_003Ec__DisplayClass17_6.GEW09RCuHxZ1VBFtGxkc(_003C_003Ec__DisplayClass17_4.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.propValue, _003C_003Ec__DisplayClass17_4.index);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
									{
										num4 = 0;
									}
									break;
								case 2:
									return;
								default:
									obj5 = _003C_003Ec__DisplayClass17_4.CS_0024_003C_003E8__locals5.func();
									num4 = 3;
									break;
								case 3:
									_003C_003Ec__DisplayClass17_6.jn9NCWCu7lkfCjjUeiXN(_003C_003Ec__DisplayClass17_4.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.propValue, _003C_003Ec__DisplayClass17_4.index, _003C_003Ec__DisplayClass17_6.NFfhXCCuAggx395kqXN5((DataClass)obj5, _003C_003Ec__DisplayClass17_4.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.dataClassType) ?? obj5);
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						});
						_003C_003Ec__DisplayClass17_4.CS_0024_003C_003E8__locals5.CS_0024_003C_003E8__locals4.propValue.Add(null);
					}
					else
					{
						_003C_003Ec__DisplayClass17_3.CS_0024_003C_003E8__locals4.propValue.Add(obj2);
					}
				}
				break;
			}
			}
			EntityJsonSerializer.InvokeActions(serializerMarker);
		}
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		//Discarded unreachable code: IL_0190, IL_019f, IL_0273, IL_0282, IL_028d, IL_031c, IL_032b, IL_03d1, IL_0409, IL_0418, IL_0428, IL_0437, IL_0446, IL_0456, IL_04c9, IL_04d3, IL_0526, IL_06b6, IL_06c5, IL_06d5, IL_06e4, IL_077d, IL_07b5, IL_07c4, IL_081c, IL_082b, IL_08ac, IL_08bb, IL_0980, IL_09b0, IL_09bf, IL_09cb, IL_09de, IL_09ed
		int num = 5;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		object result = default(object);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		Func<object> func = default(Func<object>);
		object value2 = default(object);
		DataClass dataClass = default(DataClass);
		IEnumerator<DataClassMetadata> enumerator2 = default(IEnumerator<DataClassMetadata>);
		DataClass.ValueContainer valueContainer = default(DataClass.ValueContainer);
		DataClassMetadata current2 = default(DataClassMetadata);
		Dictionary<string, object> value4 = default(Dictionary<string, object>);
		string text = default(string);
		Dictionary<string, Dictionary<string, object>> dictionary2 = default(Dictionary<string, Dictionary<string, object>>);
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		string[] array = default(string[]);
		Dictionary<string, object> value3 = default(Dictionary<string, object>);
		string key = default(string);
		string key2 = default(string);
		object obj3 = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				disposable = (IDisposable)RFxlNDo6n5QlX9P3QVPp(needResolver: true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return result;
			case 5:
				qIORXYo6pVqlOJ8HkgXK(deserializeToType, eSprIwo6TamAeViS3ORw(-35995181 ^ -36009897));
				num2 = 4;
				break;
			case 4:
				if ((dictionary = value as IDictionary<string, object>) != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				try
				{
					object obj = new object();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num3 = 2;
					}
					while (true)
					{
						object obj2;
						int num4;
						object obj4;
						switch (num3)
						{
						case 8:
							return result;
						case 12:
							return result;
						case 20:
							return result;
						case 28:
							return result;
						case 30:
							result = func;
							num3 = 20;
							continue;
						case 3:
							if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675418131)))
							{
								num3 = 18;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num3 = 19;
								}
								continue;
							}
							goto case 5;
						default:
							result = null;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
							{
								num3 = 28;
							}
							continue;
						case 22:
							if (dictionary.TryGetValue((string)eSprIwo6TamAeViS3ORw(-1765851862 ^ -1765981756), out value2))
							{
								num3 = 14;
								continue;
							}
							goto case 24;
						case 31:
							obj2 = YHsLC3o6DZurQ8J3y6Tk(dataClass, deserializeToType);
							if (obj2 == null)
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
								{
									num3 = 17;
								}
								continue;
							}
							break;
						case 18:
							JR0gglo6HyS6MUDp9RUY(obj);
							num3 = 31;
							continue;
						case 21:
							enumerator2 = dataClass.GetIncludes(onlyFilled: false).GetEnumerator();
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num3 = 3;
							}
							continue;
						case 24:
						case 26:
							if (valueContainer != null)
							{
								num4 = 9;
								goto IL_00b5;
							}
							goto case 16;
						case 7:
							try
							{
								while (true)
								{
									IL_0336:
									int num7;
									if (!enumerator2.MoveNext())
									{
										num7 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num7 = 6;
										}
										goto IL_0291;
									}
									goto IL_02bb;
									IL_02bb:
									current2 = enumerator2.Current;
									num7 = 5;
									goto IL_0291;
									IL_0291:
									while (true)
									{
										switch (num7)
										{
										case 1:
											break;
										case 3:
											value4[(string)eSprIwo6TamAeViS3ORw(-643786247 ^ -643698777)] = text;
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
											{
												num7 = 0;
											}
											continue;
										case 4:
											if (!MY1vipo6603cpu1dcuhV(text))
											{
												num7 = 3;
												continue;
											}
											goto default;
										case 2:
										case 7:
											goto IL_0336;
										case 5:
											if (!dictionary2.TryGetValue((string)RvBNNZo6P3NCSaRhc0GC(current2), out value4))
											{
												num7 = 7;
												continue;
											}
											goto case 4;
										default:
											new EntityJsonSerializer().ConvertFromSerializable(YHsLC3o6DZurQ8J3y6Tk(dataClass, deserializeToType) ?? dataClass, current2, value4, loadEntityIfExists: false);
											num7 = 2;
											continue;
										case 6:
											goto end_IL_0336;
										}
										break;
									}
									goto IL_02bb;
									continue;
									end_IL_0336:
									break;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num8 = 0;
									}
									while (true)
									{
										switch (num8)
										{
										default:
											h1rS5Do6NjXJMcQLaALk(enumerator2);
											num8 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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
							goto case 18;
						case 32:
							dataClass = new DataClass(valueContainer);
							num4 = 4;
							goto IL_00b5;
						case 2:
							aO8NYro6a2VBaBDb9Z2n(obj);
							num3 = 3;
							continue;
						case 5:
							valueContainer = null;
							num3 = 22;
							continue;
						case 29:
							valueContainer = (DataClass.ValueContainer)e3Cwh2o6tPS44J5ZfkX3(this, value2.ToString());
							num4 = 24;
							goto IL_00b5;
						case 4:
							dictionary2 = new Dictionary<string, Dictionary<string, object>>();
							num3 = 10;
							continue;
						case 1:
							try
							{
								while (true)
								{
									int num5;
									if (!RnSriio63Z3R8nInpuiY(enumerator))
									{
										num5 = 9;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
										{
											num5 = 9;
										}
										goto IL_04d7;
									}
									goto IL_0638;
									IL_0638:
									current = enumerator.Current;
									num5 = 10;
									goto IL_04d7;
									IL_04d7:
									while (true)
									{
										switch (num5)
										{
										case 5:
											if (array.Length == 2)
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
												{
													num5 = 0;
												}
												continue;
											}
											goto case 8;
										case 14:
											value3 = (dictionary2[key] = new Dictionary<string, object>());
											num5 = 2;
											continue;
										case 12:
											if (Unx6Iao6e3ICR970CKAd(current.Key, eSprIwo6TamAeViS3ORw(-1876063057 ^ -1876100367)))
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
												{
													num5 = 6;
												}
												continue;
											}
											goto case 3;
										default:
											key = array[0];
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
											{
												num5 = 4;
											}
											continue;
										case 4:
											key2 = array[1];
											num5 = 10;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
											{
												num5 = 11;
											}
											continue;
										case 6:
											text = current.Value.ToString();
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
											{
												num5 = 1;
											}
											continue;
										case 1:
										case 7:
											break;
										case 13:
											goto IL_0638;
										case 2:
										case 15:
											value3[key2] = current.Value;
											num5 = 7;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
											{
												num5 = 7;
											}
											continue;
										case 10:
											if (!Unx6Iao6e3ICR970CKAd(current.Key, eSprIwo6TamAeViS3ORw(-488881205 ^ -488751323)))
											{
												num5 = 12;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
												{
													num5 = 12;
												}
												continue;
											}
											break;
										case 8:
											throw new Exception((string)aamLuio64TfHDKEK2oiB(eSprIwo6TamAeViS3ORw(-2112703338 ^ -2112829344)));
										case 11:
											if (dictionary2.TryGetValue(key, out value3))
											{
												num5 = 15;
												continue;
											}
											goto case 14;
										case 3:
											array = current.Key.Split('$');
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
											{
												num5 = 5;
											}
											continue;
										case 9:
											goto end_IL_0612;
										}
										break;
									}
									continue;
									end_IL_0612:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
									{
										num6 = 0;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											h1rS5Do6NjXJMcQLaALk(enumerator);
											num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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
							goto case 21;
						case 23:
							valueContainer = (DataClass.ValueContainer)iW4aELo6wA15LSXnWu8Q(deserializeToType);
							num3 = 27;
							continue;
						case 10:
							text = null;
							num3 = 15;
							continue;
						case 13:
							if ((func = obj3 as Func<object>) == null)
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 30;
						case 9:
						case 27:
							if (valueContainer == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 32;
						case 14:
							if (value2 == null)
							{
								num3 = 26;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto case 29;
						case 19:
							obj3 = new EntityJsonSerializer().ConvertFromSerializable(new object(), null, dictionary, loadEntityIfExists: false);
							num3 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num3 = 13;
							}
							continue;
						case 15:
							enumerator = dictionary.GetEnumerator();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 1;
							}
							continue;
						case 16:
							if (TypeOf<IDataClass>.Raw.IsAssignableFrom(deserializeToType))
							{
								num3 = 23;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto case 9;
						case 6:
						case 11:
							obj4 = YHsLC3o6DZurQ8J3y6Tk((DataClass)obj3, deserializeToType);
							if (obj4 != null)
							{
								goto IL_093c;
							}
							num4 = 25;
							goto IL_00b5;
						case 25:
							obj4 = obj3;
							goto IL_093c;
						case 17:
							{
								obj2 = dataClass;
								break;
							}
							IL_093c:
							result = obj4;
							num4 = 12;
							goto IL_00b5;
							IL_00b5:
							num3 = num4;
							continue;
						}
						result = obj2;
						num3 = 8;
					}
				}
				finally
				{
					int num9;
					if (disposable == null)
					{
						num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num9 = 0;
						}
						goto IL_0984;
					}
					goto IL_099a;
					IL_099a:
					h1rS5Do6NjXJMcQLaALk(disposable);
					num9 = 2;
					goto IL_0984;
					IL_0984:
					switch (num9)
					{
					default:
						goto end_IL_095f;
					case 1:
						break;
					case 0:
						goto end_IL_095f;
					case 2:
						goto end_IL_095f;
					}
					goto IL_099a;
					end_IL_095f:;
				}
			}
		}
	}

	private static (Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid) GetDtoUids(object typeRef)
	{
		return DtoTypes.GetOrAdd((string)typeRef, delegate(string key)
		{
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
			CS_0024_003C_003E8__locals0.reference = Locator.GetServiceNotNull<IDataClassTypeReferenceManager>().LoadOrNull(key);
			if (CS_0024_003C_003E8__locals0.reference == null)
			{
				return EmptyType;
			}
			ModuleReference moduleReference = Locator.GetServiceNotNull<IModuleReferenceManager>().LoadOrNull(CS_0024_003C_003E8__locals0.reference.MetadataUid);
			if (moduleReference == null)
			{
				return EmptyType;
			}
			if (moduleReference.ModuleUid == Guid.Empty)
			{
				if (ComponentMetadataItemManager.Instance.LoadOrNull(CS_0024_003C_003E8__locals0.reference.ItemUid) == null)
				{
					return (Guid.Empty, Guid.Empty, Guid.Empty, CS_0024_003C_003E8__locals0.reference.MetadataUid);
				}
				return (Guid.Empty, Guid.Empty, CS_0024_003C_003E8__locals0.reference.ItemUid, CS_0024_003C_003E8__locals0.reference.MetadataUid);
			}
			ModuleVersion specificModuleVersion = Locator.GetServiceNotNull<IModuleMetadataLoader>().GetSpecificModuleVersion(moduleReference.ModuleUid, CS_0024_003C_003E8__locals0.reference.ItemUid);
			if (specificModuleVersion == null)
			{
				throw new NullReferenceException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD0CB92), CS_0024_003C_003E8__locals0.reference.ItemUid, key));
			}
			ModuleInfoMetadata metadata = specificModuleVersion.Metadata;
			if (metadata.DataClasses.Find((DataClassMetadata a) => _003C_003Ec__DisplayClass21_0.e8T2SQCu9Tb0FEsxRI2F(_003C_003Ec__DisplayClass21_0.USYSZNCuM4eTqj6eyPUE(a), _003C_003Ec__DisplayClass21_0.y0q1LoCuJqDF1n3BJZmo(CS_0024_003C_003E8__locals0.reference))) != null)
			{
				return (specificModuleVersion.Header.HeaderUid, CS_0024_003C_003E8__locals0.reference.ItemUid, Guid.Empty, CS_0024_003C_003E8__locals0.reference.MetadataUid);
			}
			foreach (ComponentMetadata component in metadata.Components)
			{
				if (component.DataClasses.Find((DataClassMetadata a) => _003C_003Ec__DisplayClass21_0.e8T2SQCu9Tb0FEsxRI2F(_003C_003Ec__DisplayClass21_0.USYSZNCuM4eTqj6eyPUE(a), _003C_003Ec__DisplayClass21_0.y0q1LoCuJqDF1n3BJZmo(CS_0024_003C_003E8__locals0.reference))) != null)
				{
					return (specificModuleVersion.Header.HeaderUid, CS_0024_003C_003E8__locals0.reference.ItemUid, component.Uid, CS_0024_003C_003E8__locals0.reference.MetadataUid);
				}
			}
			return EmptyType;
		});
	}

	internal virtual DataClass.ValueContainer GetValueContainer(string typeRef)
	{
		//Discarded unreachable code: IL_00c5, IL_00d4
		int num = 3;
		int num2 = num;
		Guid item = default(Guid);
		Guid item2 = default(Guid);
		Guid item3 = default(Guid);
		Guid item4 = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return DataClass.ValueContainer.Create(item);
			case 5:
				return DataClass.ValueContainer.Create(item2, item3, item4, item);
			default:
				return null;
			case 3:
			{
				(Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid) dtoUids = GetDtoUids(typeRef);
				item2 = dtoUids.moduleUid;
				item3 = dtoUids.moduleItemUid;
				item4 = dtoUids.componentUid;
				item = dtoUids.metadataUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			case 2:
				if (!e91vZVo6AYoAkPU6LEVm(item, Guid.Empty))
				{
					if (item2 != Guid.Empty)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				break;
			}
			if (oXvNXTo6711HMygSBoIj(item4, Guid.Empty))
			{
				break;
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num2 = 1;
			}
		}
		return (DataClass.ValueContainer)lq81quo6xbfW094BMLe7(item4, item);
	}

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		return GetPropertyTypeReferenceInnerLogic(classMetadata, propertyMetadata, forFilter);
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return GetPropertyInitExpressionInnerLogic(classMetadata, propertyMetadata, forFilter);
	}

	public override string GetTypeDisplayName(Guid subTypeUid)
	{
		int num = 1;
		int num2 = num;
		DataClassMetadata metadataByUid = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				metadataByUid = GetMetadataByUid(subTypeUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)IQEco7o6yxxD9sbn9Qu0(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870790397), aamLuio64TfHDKEK2oiB(jqdQ9uo60rJeCDVkQnML(metadataByUid)), lMNmTuo6m1MkcbH9IcgU(metadataByUid));
			}
		}
	}

	protected override string GetTypeName(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		DataClassMetadata metadataByUid = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				metadataByUid = GetMetadataByUid(CUg7FMo6MALecOqpI86w(propertyMetadata));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			default:
				throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398550016), XP4tsio6Ji8bXqbtYinZ(typeof(DataClassMetadata).TypeHandle)));
			case 1:
				return (string)V4CxDZo69U7VMMAgFUJ9(metadataByUid);
			case 2:
				if (metadataByUid != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static Guid GetSubtypeUid(Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				UidAttribute attribute = AttributeHelper<UidAttribute>.GetAttribute(type, inherited: true);
				if (attribute == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return attribute.Uid;
			}
			case 2:
				return Guid.Empty;
			}
			if (MY1vipo6603cpu1dcuhV(type.FullName))
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return O0TajRo6dUNm4WmmPkIJ(type.FullName);
		}
	}

	internal DataClassMetadata GetMetadataByUid(Guid typeUid)
	{
		//Discarded unreachable code: IL_0105, IL_038d, IL_03b0, IL_03bf, IL_03cf, IL_03de, IL_045c, IL_049c, IL_04ab, IL_04b7, IL_04ee, IL_0511, IL_0520, IL_0530, IL_05ca, IL_05fa, IL_0609, IL_0615, IL_0624, IL_0669
		int num = 1;
		IDataReader dataReader2 = default(IDataReader);
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
		IDataReader dataReader = default(IDataReader);
		string text7 = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text11 = default(string);
		string text12 = default(string);
		string text13 = default(string);
		string text14 = default(string);
		string text15 = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text4 = default(string);
		string text = default(string);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		DataClassMetadata result = default(DataClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 13:
					dataReader2 = ((ITransformationProvider)NnUBxMo6lRtRYFPjwSvO(base.RuntimeApplication)).ExecuteQuery(loadFromMetadataItemHeaderQuery, new Dictionary<string, object> { [z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD70950)] = _003C_003Ec__DisplayClass28_.typeUid });
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 10;
					}
					continue;
				case 15:
				case 16:
					dataReader = ((ITransformationProvider)NnUBxMo6lRtRYFPjwSvO(base.RuntimeApplication)).ExecuteQuery(loadFromModuleReferenceQuery, new Dictionary<string, object> { [z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97826474)] = _003C_003Ec__DisplayClass28_.typeUid });
					num2 = 9;
					continue;
				case 11:
					loadFromModuleReferenceQuery = (string)LARSpUo6jci4MIEfiJZl(new string[21]
					{
						(string)eSprIwo6TamAeViS3ORw(-138018305 ^ -138117125),
						text7,
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672035709),
						text8,
						(string)eSprIwo6TamAeViS3ORw(-583745292 ^ -583614908),
						text9,
						(string)eSprIwo6TamAeViS3ORw(0x638095EB ^ 0x6382EB39),
						text10,
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870787375),
						text11,
						(string)eSprIwo6TamAeViS3ORw(0x1C9495B4 ^ 0x1C952C7E),
						text12,
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A75E98B),
						text13,
						(string)eSprIwo6TamAeViS3ORw(-1867198571 ^ -1867075131),
						text14,
						(string)eSprIwo6TamAeViS3ORw(0x571EA399 ^ 0x571CDD69),
						text15,
						(string)eSprIwo6TamAeViS3ORw(-1870892489 ^ -1870889411),
						(string)qlQg8no65FUBh2VPDM7C(NnUBxMo6lRtRYFPjwSvO(base.RuntimeApplication)),
						(string)eSprIwo6TamAeViS3ORw(0x4DC2B14D ^ 0x4DC0E84D)
					});
					num2 = 15;
					continue;
				case 3:
				{
					object obj = YMkIZAo6rdlJlKByKdxN(NnUBxMo6lRtRYFPjwSvO(base.RuntimeApplication));
					text2 = (string)eHMQMFo6gtnQQg0bawi7(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139066780));
					text3 = (string)eHMQMFo6gtnQQg0bawi7(obj, eSprIwo6TamAeViS3ORw(--1333735954 ^ 0x4F7D4FC4));
					text5 = (string)eHMQMFo6gtnQQg0bawi7(obj, eSprIwo6TamAeViS3ORw(0x53CACA3 ^ 0x53C015F));
					text6 = (string)eHMQMFo6gtnQQg0bawi7(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3B21B));
					text4 = (string)eHMQMFo6gtnQQg0bawi7(obj, eSprIwo6TamAeViS3ORw(-2107978722 ^ -2108011200));
					text = (string)eHMQMFo6gtnQQg0bawi7(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE129F0D));
					num2 = 12;
					continue;
				}
				case 14:
					dataClassMetadata = LoadFromRuntime(_003C_003Ec__DisplayClass28_.typeUid);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					if (dataClassMetadata != null)
					{
						num2 = 4;
						continue;
					}
					if (loadFromMetadataItemHeaderQuery != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 3;
				case 4:
					return dataClassMetadata;
				case 10:
					try
					{
						int num5;
						if (!dataReader2.Read())
						{
							num5 = 3;
							goto IL_0391;
						}
						goto IL_03e9;
						IL_0391:
						switch (num5)
						{
						default:
							goto end_IL_0377;
						case 3:
							goto end_IL_0377;
						case 2:
							break;
						case 0:
							goto end_IL_0377;
						case 1:
							return result;
						}
						goto IL_03e9;
						IL_03e9:
						result = zXflKto6YrTGjlOWtLI2(xmlObjSerType, (DbDataReader)dataReader2, new string[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A75588) }, null, null) as DataClassMetadata;
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num5 = 1;
						}
						goto IL_0391;
						end_IL_0377:;
					}
					finally
					{
						int num6;
						if (dataReader2 == null)
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num6 = 0;
							}
							goto IL_0460;
						}
						goto IL_0476;
						IL_0476:
						h1rS5Do6NjXJMcQLaALk(dataReader2);
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num6 = 0;
						}
						goto IL_0460;
						IL_0460:
						switch (num6)
						{
						default:
							goto end_IL_043b;
						case 2:
							break;
						case 1:
							goto end_IL_043b;
						case 0:
							goto end_IL_043b;
						}
						goto IL_0476;
						end_IL_043b:;
					}
					goto case 8;
				default:
					_003C_003Ec__DisplayClass28_.typeUid = typeUid;
					num2 = 14;
					continue;
				case 9:
					try
					{
						int num3;
						if (!omS3Qco6LhXrDIP11OkC(dataReader))
						{
							num3 = 2;
							goto IL_04f2;
						}
						goto IL_053a;
						IL_04f2:
						switch (num3)
						{
						case 2:
							goto end_IL_04d8;
						case 3:
							goto end_IL_04d8;
						case 1:
							return result;
						}
						goto IL_053a;
						IL_053a:
						result = (zXflKto6YrTGjlOWtLI2(xmlObjSerType, (DbDataReader)dataReader, new string[1] { (string)eSprIwo6TamAeViS3ORw(0x3A5D5EF ^ 0x3A5632D) }, null, null) as ModuleInfoMetadata).DataClasses.Find(_003C_003Ec__DisplayClass28_._003CGetMetadataByUid_003Eb__0);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num3 = 1;
						}
						goto IL_04f2;
						end_IL_04d8:;
					}
					finally
					{
						int num4;
						if (dataReader == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num4 = 0;
							}
							goto IL_05ce;
						}
						goto IL_05e4;
						IL_05e4:
						h1rS5Do6NjXJMcQLaALk(dataReader);
						num4 = 2;
						goto IL_05ce;
						IL_05ce:
						switch (num4)
						{
						default:
							goto end_IL_05a9;
						case 1:
							break;
						case 0:
							goto end_IL_05a9;
						case 2:
							goto end_IL_05a9;
						}
						goto IL_05e4;
						end_IL_05a9:;
					}
					break;
				case 8:
					if (loadFromModuleReferenceQuery != null)
					{
						num2 = 16;
						continue;
					}
					goto end_IL_0012;
				case 1:
					_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					goto end_IL_0012;
				case 12:
					loadFromMetadataItemHeaderQuery = (string)LARSpUo6jci4MIEfiJZl(new string[15]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824492135),
						text,
						(string)eSprIwo6TamAeViS3ORw(-1858887263 ^ -1858988007),
						text2,
						(string)eSprIwo6TamAeViS3ORw(-105199646 ^ -105334280),
						text3,
						(string)eSprIwo6TamAeViS3ORw(0x6DC147B0 ^ 0x6DC3398C),
						text4,
						(string)eSprIwo6TamAeViS3ORw(-1334993905 ^ -1334844833),
						text5,
						(string)eSprIwo6TamAeViS3ORw(0x4A1640F ^ 0x4A31A55),
						text6,
						(string)eSprIwo6TamAeViS3ORw(-643786247 ^ -643787277),
						(string)qlQg8no65FUBh2VPDM7C(NnUBxMo6lRtRYFPjwSvO(base.RuntimeApplication)),
						(string)eSprIwo6TamAeViS3ORw(-1088304168 ^ -1088187688)
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					break;
				}
				throw new Exception(SR.T((string)eSprIwo6TamAeViS3ORw(-2138958856 ^ -2139067152), _003C_003Ec__DisplayClass28_.typeUid));
				continue;
				end_IL_0012:
				break;
			}
			object obj2 = YMkIZAo6rdlJlKByKdxN(NnUBxMo6lRtRYFPjwSvO(base.RuntimeApplication));
			text8 = (string)eSprIwo6TamAeViS3ORw(--1360331293 ^ 0x511745F7);
			text9 = (string)eHMQMFo6gtnQQg0bawi7(obj2, eSprIwo6TamAeViS3ORw(0x3CE17B75 ^ 0x3CE330C9));
			text12 = ((Dialect)obj2).QuoteIfNeeded((string)eSprIwo6TamAeViS3ORw(-1978478350 ^ -1978618240));
			text15 = (string)eHMQMFo6gtnQQg0bawi7(obj2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112815974));
			text11 = (string)eHMQMFo6gtnQQg0bawi7(obj2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16374525));
			text10 = (string)eHMQMFo6gtnQQg0bawi7(obj2, eSprIwo6TamAeViS3ORw(-1978478350 ^ -1978482848));
			text14 = ((Dialect)obj2).QuoteIfNeeded((string)eSprIwo6TamAeViS3ORw(0x3C5338FF ^ 0x3C514665));
			text13 = ((Dialect)obj2).QuoteIfNeeded((string)eSprIwo6TamAeViS3ORw(-195614443 ^ -195581877));
			text7 = (string)eHMQMFo6gtnQQg0bawi7(obj2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106482426));
			num = 11;
		}
	}

	private ISyntaxNode GetPropertyTypeReferenceInnerLogic(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		int num = 4;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 4:
				qIORXYo6pVqlOJ8HkgXK(propertyMetadata, eSprIwo6TamAeViS3ORw(-1751176224 ^ -1751162190));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 3;
				}
				break;
			default:
				aVDoEWo6UCI8jaify4UX(propertyMetadata.Settings is DataClassSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124663C8));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				qIORXYo6pVqlOJ8HkgXK(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E830F));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return TypeOf.ICollection.Raw.CreateTypeSyntax(syntaxNode);
			case 2:
			{
				RelationType num3 = tUgChRo6c2MITFprWP0B((DataClassSettings)JJ48YKo6soAN5G2vqksH(propertyMetadata));
				syntaxNode = (ISyntaxNode)yQTURsoHFg7449LjgXuQ(vdOclno6zmcafVQlhx7m(this, classMetadata, propertyMetadata, forFilter));
				if (num3 == RelationType.OneToOne)
				{
					return syntaxNode;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			}
			}
		}
	}

	private ISyntaxNode GetPropertyInitExpressionInnerLogic(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		int num = 2;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				qIORXYo6pVqlOJ8HkgXK(propertyMetadata, eSprIwo6TamAeViS3ORw(-1146510045 ^ -1146491791));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				qIORXYo6pVqlOJ8HkgXK(JJ48YKo6soAN5G2vqksH(propertyMetadata), eSprIwo6TamAeViS3ORw(0x20261A4F ^ 0x20263AD9));
				num2 = 3;
				break;
			case 3:
				Contract.CheckArgument(propertyMetadata.Settings is DataClassSettings, (string)eSprIwo6TamAeViS3ORw(0x34185E55 ^ 0x341A2139));
				num2 = 5;
				break;
			case 4:
				return TypeOf.List.Raw.CreateTypeSyntax(syntaxNode).ObjectCreationExpression();
			default:
				return null;
			case 5:
				if (tUgChRo6c2MITFprWP0B((DataClassSettings)propertyMetadata.Settings) != 0)
				{
					syntaxNode = ((string)vdOclno6zmcafVQlhx7m(this, classMetadata, propertyMetadata, forFilter)).CreateTypeSyntax();
					num2 = 4;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private DataClassMetadata LoadFromRuntime(Guid typeUid)
	{
		//Discarded unreachable code: IL_0052, IL_0084, IL_00bc, IL_00cb
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		switch (1)
		{
		case 1:
			try
			{
				dataClassMetadata = ((IMetadataService)ADFnaLoHBWWhfED46DkR()).GetMetadata(typeUid, loadImplementation: true) as DataClassMetadata;
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => dataClassMetadata, 
					_ => dataClassMetadata, 
				};
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return dataClassMetadata;
					}
					dataClassMetadata = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
				}
			}
		default:
			return dataClassMetadata;
		}
	}

	public DataClassDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		g8Ax4eoHW9IV5RoIitVr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DataClassDescriptor()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				g8Ax4eoHW9IV5RoIitVr();
				num2 = 2;
				break;
			default:
				DtoTypes = new ConcurrentDictionary<string, (Guid, Guid, Guid, Guid)>();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195733805));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				EmptyType = (Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				xmlObjSerType = new XmlObjectSerializableType();
				num2 = 5;
				break;
			case 5:
				return;
			}
		}
	}

	internal static bool kpvIPVo6Kf3lb7FVdbgR()
	{
		return zOwu5po6qZjM4am1qQuq == null;
	}

	internal static DataClassDescriptor S41pTgo6XoQuv4OYumvc()
	{
		return zOwu5po6qZjM4am1qQuq;
	}

	internal static object eSprIwo6TamAeViS3ORw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object yHwM9Jo6kJNPvqmt1wFA()
	{
		return ReferenceResolverSerializer.CurrentResolver;
	}

	internal static object RFxlNDo6n5QlX9P3QVPp(bool needResolver)
	{
		return ReferenceResolverSerializer.CreateResolver(needResolver);
	}

	internal static object oEXoDIo6ObLmu3vYAwMm(object P_0)
	{
		return ((DataClass)P_0).TypeRef;
	}

	internal static Guid uNt6Lko62Woh6Ojggfjo(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static bool Unx6Iao6e3ICR970CKAd(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object RvBNNZo6P3NCSaRhc0GC(object P_0)
	{
		return ((DataClassMetadata)P_0).TypeRef;
	}

	internal static object fTTPMvo61fGJFAhNab7d(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void h1rS5Do6NjXJMcQLaALk(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool RnSriio63Z3R8nInpuiY(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void qIORXYo6pVqlOJ8HkgXK(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void aO8NYro6a2VBaBDb9Z2n(object P_0)
	{
		EntityJsonSerializer.AddSerializerMarker(P_0);
	}

	internal static object YHsLC3o6DZurQ8J3y6Tk(object P_0, Type type)
	{
		return ((DataClass)P_0).As(type);
	}

	internal static object e3Cwh2o6tPS44J5ZfkX3(object P_0, object P_1)
	{
		return ((DataClassDescriptor)P_0).GetValueContainer((string)P_1);
	}

	internal static object iW4aELo6wA15LSXnWu8Q(Type type)
	{
		return DataClass.ValueContainer.Create(type);
	}

	internal static object aamLuio64TfHDKEK2oiB(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool MY1vipo6603cpu1dcuhV(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void JR0gglo6HyS6MUDp9RUY(object P_0)
	{
		EntityJsonSerializer.InvokeActions(P_0);
	}

	internal static bool e91vZVo6AYoAkPU6LEVm(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool oXvNXTo6711HMygSBoIj(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object lq81quo6xbfW094BMLe7(Guid componentUid, Guid metadataUid)
	{
		return DataClass.ValueContainer.Create(componentUid, metadataUid);
	}

	internal static object jqdQ9uo60rJeCDVkQnML(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object lMNmTuo6m1MkcbH9IcgU(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object IQEco7o6yxxD9sbn9Qu0(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static Guid CUg7FMo6MALecOqpI86w(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static Type XP4tsio6Ji8bXqbtYinZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object V4CxDZo69U7VMMAgFUJ9(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static Guid O0TajRo6dUNm4WmmPkIJ(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static object NnUBxMo6lRtRYFPjwSvO(object P_0)
	{
		return ((IRuntimeApplication)P_0).TransformationProvider;
	}

	internal static object YMkIZAo6rdlJlKByKdxN(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object eHMQMFo6gtnQQg0bawi7(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object qlQg8no65FUBh2VPDM7C(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object LARSpUo6jci4MIEfiJZl(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object zXflKto6YrTGjlOWtLI2(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((XmlSerializableType<object>)P_0).NullSafeGet((DbDataReader)P_1, (string[])P_2, (ISessionImplementor)P_3, P_4);
	}

	internal static bool omS3Qco6LhXrDIP11OkC(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static void aVDoEWo6UCI8jaify4UX(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object JJ48YKo6soAN5G2vqksH(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static RelationType tUgChRo6c2MITFprWP0B(object P_0)
	{
		return ((DataClassSettings)P_0).RelationType;
	}

	internal static object vdOclno6zmcafVQlhx7m(object P_0, object P_1, object P_2, bool P_3)
	{
		return ((RefTypeDescriptor<IDataClass, DataClassSettings>)P_0).GetTypeName((ClassMetadata)P_1, (PropertyMetadata)P_2, P_3);
	}

	internal static object yQTURsoHFg7449LjgXuQ(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static object ADFnaLoHBWWhfED46DkR()
	{
		return MetadataServiceContext.Service;
	}

	internal static void g8Ax4eoHW9IV5RoIitVr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
