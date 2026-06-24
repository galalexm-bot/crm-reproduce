using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Script.Serialization;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

public class EntityJsonSerializer
{
	private static readonly Type OwnerType;

	private static readonly MethodInfo ConvertToSerializableCall;

	private static readonly MethodInfo ConvertFromSerializableCall;

	public const string SettingsFieldName = "__settings";

	private static readonly string IdPropertyName;

	private static EntityJsonSerializer WgwoIsBreZxYoYOUmtth;

	public Func<IEntity, bool> NeedBindProperties { get; set; }

	public Func<PropertyMetadata, bool> PropertyFilter { get; set; }

	[Obsolete("Свойство устарело, используйте вместо него NeedBindTablePart", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Func<TablePartMetadata, bool> TablePartFilter { get; set; }

	public Func<ITablePartMetadata, bool> NeedBindTablePart { get; set; }

	public object ConvertToSerializable(object obj)
	{
		return ConvertToSerializable(obj, null);
	}

	public object ConvertToSerializable(object obj, EntitySerializationSettings settings)
	{
		int num = 2;
		int num2 = num;
		ClassMetadata metadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return ConvertToSerializable(obj, metadata, settings);
			case 2:
				dtAtYPBr37LMjfr30FIk(obj, CV43EWBrNKSDAZ8S6FRi(-957824448 ^ -957849144));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				metadata = MetadataLoader.LoadMetadata(ELM1vCBrpJqE1h8INrAs(obj).GetType()) as ClassMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal object ConvertToSerializable(object obj, ClassMetadata metadata, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_0062, IL_00a3, IL_027a, IL_0289, IL_030b, IL_035f, IL_036e, IL_0410, IL_04ec, IL_056b, IL_057a, IL_0585, IL_0644, IL_0691, IL_06a0, IL_06e7, IL_0727, IL_0736, IL_0742, IL_0767, IL_0776, IL_0797, IL_0819, IL_08e9, IL_08f8, IL_092f, IL_093e, IL_094d, IL_095e, IL_0968, IL_0977, IL_098e, IL_09d6, IL_09e5, IL_09f4, IL_0a48, IL_0ade, IL_0b0e, IL_0b22, IL_0c33, IL_0c83, IL_0c92, IL_0ca2, IL_0d04, IL_0d13, IL_0d64, IL_0d73, IL_0ddb, IL_0e2f, IL_0ec1, IL_0eec, IL_0ef6, IL_0fb2, IL_0fd1, IL_0fe0, IL_100d, IL_1069, IL_1089, IL_1098, IL_10e5, IL_111a, IL_1280, IL_128f, IL_12cf, IL_12de, IL_136c, IL_137b, IL_138b, IL_13eb, IL_13fe, IL_140d, IL_14e7, IL_14f6, IL_15d0, IL_1610, IL_161f, IL_162b, IL_163a, IL_1656, IL_1660, IL_166f, IL_16a8, IL_1708, IL_1717, IL_1766, IL_17a6, IL_17b5, IL_17c1
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass6_0);
		IDisposable disposable2 = default(IDisposable);
		bool flag2 = default(bool);
		Dictionary<string, SerializableDictionary<string, object>> dictionary2 = default(Dictionary<string, SerializableDictionary<string, object>>);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		IEnumerator<ITablePartMetadata> enumerator3 = default(IEnumerator<ITablePartMetadata>);
		ITablePartContainer tablePartContainer = default(ITablePartContainer);
		ITablePartMetadata current3 = default(ITablePartMetadata);
		SerializableList<object> serializableList = default(SerializableList<object>);
		bool item3 = default(bool);
		EntitySerializationSettings settings3 = default(EntitySerializationSettings);
		IEnumerable enumerable = default(IEnumerable);
		Guid[] array = default(Guid[]);
		IEnumerator enumerator4 = default(IEnumerator);
		IEntity entity = default(IEntity);
		IEntity obj5 = default(IEntity);
		ITypeSettingsInstanceStore typeSettingsInstanceStore = default(ITypeSettingsInstanceStore);
		object result = default(object);
		IEntityManager entityManager = default(IEntityManager);
		IMetadataService metadataService = default(IMetadataService);
		bool item = default(bool);
		object obj2 = default(object);
		PropertyMetadata current = default(PropertyMetadata);
		bool item2 = default(bool);
		EntitySerializationSettings settings2 = default(EntitySerializationSettings);
		ISerializableTypeDescriptor serializableTypeDescriptor = default(ISerializableTypeDescriptor);
		EntitySerializationSettings entitySerializationSettings = default(EntitySerializationSettings);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		object value = default(object);
		bool flag = default(bool);
		IPropertyPermissionService service = default(IPropertyPermissionService);
		IEnumerator<KeyValuePair<string, object>> enumerator2 = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current2 = default(KeyValuePair<string, object>);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		string reference = default(string);
		MethodCallInfo methodCallInfo = default(MethodCallInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							try
							{
								int num4;
								if (CS_0024_003C_003E8__locals0.settings == null)
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
									{
										num4 = 3;
									}
									goto IL_00a7;
								}
								goto IL_1645;
								IL_00a7:
								while (true)
								{
									switch (num4)
									{
									case 4:
										disposable2 = (IDisposable)tBVp43BrtBxyxSSMQkj0(xWVskSBrDKR1fTolQB4W() != null || flag2);
										num4 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
										{
											num4 = 2;
										}
										continue;
									case 2:
										try
										{
											IReferenceResolver referenceResolver = (IReferenceResolver)xWVskSBrDKR1fTolQB4W();
											int num5 = 29;
											while (true)
											{
												int num6;
												object obj4;
												object obj3;
												switch (num5)
												{
												case 22:
													((IDictionary<string, object>)serializableDictionary)[(string)CV43EWBrNKSDAZ8S6FRi(-289714582 ^ -289785854)] = dictionary2;
													num5 = 51;
													continue;
												case 23:
													enumerator = CS_0024_003C_003E8__locals0.metadata.Properties.GetEnumerator();
													num5 = 6;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
													{
														num5 = 26;
													}
													continue;
												case 39:
													enumerator3 = tablePartContainer.TableParts.GetEnumerator();
													num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
													{
														num5 = 0;
													}
													continue;
												case 47:
													if (!(tablePartContainer is IEntityMetadata))
													{
														num5 = 30;
														continue;
													}
													goto case 40;
												case 1:
													try
													{
														while (true)
														{
															IL_06ab:
															int num12;
															if (!enumerator3.MoveNext())
															{
																num12 = 14;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
																{
																	num12 = 15;
																}
																goto IL_0298;
															}
															goto IL_0378;
															IL_0378:
															current3 = enumerator3.Current;
															num12 = 23;
															goto IL_0298;
															IL_0298:
															while (true)
															{
																switch (num12)
																{
																case 9:
																case 11:
																	serializableList = new SerializableList<object>();
																	num12 = 8;
																	continue;
																case 6:
																{
																	(bool, EntitySerializationSettings) tuple3 = Continue(CS_0024_003C_003E8__locals0.settings, current3, (string)SoBUMMBrjxwVcAwfuCnI(current3));
																	item3 = tuple3.Item1;
																	settings3 = tuple3.Item2;
																	num12 = 2;
																	continue;
																}
																case 17:
																	break;
																case 13:
																	settings3 = null;
																	num12 = 24;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
																	{
																		num12 = 5;
																	}
																	continue;
																case 4:
																	if (CS_0024_003C_003E8__locals0.settings.Mode == EntitySerializationMode.ChangesOnly)
																	{
																		num12 = 14;
																		continue;
																	}
																	goto case 9;
																case 22:
																	if (enumerable == null)
																	{
																		num12 = 3;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
																		{
																			num12 = 21;
																		}
																		continue;
																	}
																	goto case 5;
																case 14:
																	((IDictionary<string, object>)serializableDictionary)[current3.TablePartPropertyName] = new TablePartChangesModel(enumerable, enumerable).ToDictionary();
																	num12 = 12;
																	continue;
																case 3:
																{
																	((IDictionary<string, object>)serializableDictionary)[(string)SoBUMMBrjxwVcAwfuCnI(current3)] = serializableList;
																	int num15 = 18;
																	num12 = num15;
																	continue;
																}
																case 5:
																	if (CS_0024_003C_003E8__locals0.settings == null)
																	{
																		num12 = 9;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
																		{
																			num12 = 6;
																		}
																		continue;
																	}
																	goto case 4;
																case 16:
																	if (array != null)
																	{
																		num12 = 10;
																		continue;
																	}
																	goto case 13;
																case 2:
																	if (!item3)
																	{
																		num12 = 4;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
																		{
																			num12 = 19;
																		}
																		continue;
																	}
																	goto IL_06ab;
																case 23:
																	if (NeedBindTablePart != null)
																	{
																		num12 = 7;
																		continue;
																	}
																	goto case 16;
																case 7:
																	if (!NeedBindTablePart(current3))
																	{
																		num12 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
																		{
																			num12 = 0;
																		}
																		continue;
																	}
																	goto case 16;
																case 24:
																	if (CS_0024_003C_003E8__locals0.settings == null)
																	{
																		num12 = 20;
																		continue;
																	}
																	goto case 6;
																case 8:
																	enumerator4 = (IEnumerator)oGhD9aBrLhLkLRSGH2Mr(enumerable);
																	num12 = 1;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
																	{
																		num12 = 1;
																	}
																	continue;
																case 10:
																	if (array.Contains(iE5FM0Br5Y2AMx24nypq(current3)))
																	{
																		num12 = 13;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
																		{
																			num12 = 8;
																		}
																		continue;
																	}
																	goto IL_06ab;
																case 19:
																case 20:
																	enumerable = HyLDxABrYTNTc1q1Z0iC(entity, current3.TablePartPropertyUid) as IEnumerable;
																	num12 = 22;
																	continue;
																case 1:
																	try
																	{
																		while (true)
																		{
																			IL_05f6:
																			int num13;
																			if (!enumerator4.MoveNext())
																			{
																				num13 = 0;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
																				{
																					num13 = 0;
																				}
																				goto IL_0589;
																			}
																			goto IL_05ce;
																			IL_05ce:
																			obj5 = (IEntity)xD6YjPBrU3slIB069iFj(enumerator4);
																			num13 = 0;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
																			{
																				num13 = 2;
																			}
																			goto IL_0589;
																			IL_0589:
																			while (true)
																			{
																				switch (num13)
																				{
																				case 2:
																					serializableList.Add(ConvertToSerializable(obj5, settings3));
																					num13 = 1;
																					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
																					{
																						num13 = 0;
																					}
																					continue;
																				case 3:
																					goto IL_05ce;
																				case 1:
																					goto IL_05f6;
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
																		IDisposable disposable = enumerator4 as IDisposable;
																		int num14 = 0;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
																		{
																			num14 = 0;
																		}
																		while (true)
																		{
																			switch (num14)
																			{
																			case 2:
																				S2JZIsBrsKd90OvN4Nbg(disposable);
																				num14 = 1;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
																				{
																					num14 = 1;
																				}
																				continue;
																			default:
																				if (disposable != null)
																				{
																					num14 = 2;
																					continue;
																				}
																				break;
																			case 1:
																				break;
																			}
																			break;
																		}
																	}
																	goto case 3;
																default:
																	goto IL_06ab;
																case 15:
																	goto end_IL_06ab;
																}
																break;
															}
															goto IL_0378;
															continue;
															end_IL_06ab:
															break;
														}
													}
													finally
													{
														int num16;
														if (enumerator3 == null)
														{
															num16 = 2;
															goto IL_06eb;
														}
														goto IL_0701;
														IL_06eb:
														switch (num16)
														{
														case 2:
															goto end_IL_06d6;
														case 1:
															goto end_IL_06d6;
														}
														goto IL_0701;
														IL_0701:
														S2JZIsBrsKd90OvN4Nbg(enumerator3);
														num16 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
														{
															num16 = 1;
														}
														goto IL_06eb;
														end_IL_06d6:;
													}
													break;
												case 11:
													if (kDglQ5BrrCkM5SflOkIH(typeSettingsInstanceStore) != null)
													{
														num5 = 48;
														continue;
													}
													goto case 9;
												case 18:
													if (tablePartContainer == null)
													{
														num5 = 16;
														continue;
													}
													goto case 47;
												case 4:
													if (entity != null)
													{
														num5 = 16;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
														{
															num5 = 28;
														}
														continue;
													}
													goto case 9;
												case 33:
													if (entity == null)
													{
														num5 = 34;
														continue;
													}
													goto case 44;
												case 44:
													serializableDictionary[(string)CV43EWBrNKSDAZ8S6FRi(-195614443 ^ -195581877)] = entity.GetId();
													num5 = 38;
													continue;
												case 7:
													result = serializableDictionary;
													num6 = 46;
													goto IL_0103;
												case 24:
													obj4 = null;
													goto IL_156d;
												case 10:
													dictionary2 = ((TypeSettingsInstanceData)kDglQ5BrrCkM5SflOkIH(typeSettingsInstanceStore)).SerializeToJsonObject();
													num5 = 17;
													continue;
												case 14:
												case 41:
													if (entity == null)
													{
														num5 = 24;
														continue;
													}
													obj4 = dnj12rBrH3DsMvnkrW3a(entity.CastAsRealType().GetType());
													goto IL_156d;
												case 34:
												case 42:
													if (CS_0024_003C_003E8__locals0.settings == null)
													{
														num6 = 19;
														goto IL_0103;
													}
													goto case 49;
												case 28:
													typeSettingsInstanceStore = (ITypeSettingsInstanceStore)eu9MqaBrlpca1JPpJqtc(entity, false, false);
													num5 = 27;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
													{
														num5 = 2;
													}
													continue;
												case 2:
													if (CS_0024_003C_003E8__locals0.settings != null)
													{
														num5 = 3;
														continue;
													}
													goto case 32;
												case 48:
													if (jr59I2BrgiCr4i7MX2eS(((TypeSettingsInstanceData)kDglQ5BrrCkM5SflOkIH(typeSettingsInstanceStore)).Items) <= 0)
													{
														num5 = 9;
														continue;
													}
													goto case 10;
												case 29:
													if (referenceResolver != null && flag2)
													{
														num5 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
														{
															num5 = 5;
														}
														continue;
													}
													goto case 50;
												case 52:
													if (entity is IInheritable)
													{
														num5 = 45;
														continue;
													}
													goto case 14;
												default:
													if (entity != null)
													{
														num5 = 43;
														continue;
													}
													goto case 14;
												case 30:
													break;
												case 32:
												case 36:
													obj3 = null;
													goto IL_158e;
												case 16:
													break;
												case 35:
													obj3 = L0eTMhBrAsYS2YYDfW7c(entity);
													goto IL_158e;
												case 50:
													entity = CS_0024_003C_003E8__locals0.obj as IEntity;
													num5 = 33;
													continue;
												case 8:
													if (!QLCJI0Br4XcKqKfuNXVB(entity))
													{
														num5 = 9;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
														{
															num5 = 12;
														}
														continue;
													}
													goto case 32;
												case 3:
													if (AbjLE8BrwZsCgPlG48pi(CS_0024_003C_003E8__locals0.settings) == EntitySerializationMode.ChangesOnly)
													{
														num5 = 15;
														continue;
													}
													goto case 32;
												case 9:
												case 13:
												case 31:
												case 51:
													tablePartContainer = CS_0024_003C_003E8__locals0.metadata as ITablePartContainer;
													num5 = 18;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
													{
														num5 = 1;
													}
													continue;
												case 17:
													if (dictionary2 == null)
													{
														num5 = 13;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
														{
															num5 = 8;
														}
														continue;
													}
													goto case 22;
												case 12:
													if (entityManager == null)
													{
														num5 = 12;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
														{
															num5 = 35;
														}
														continue;
													}
													obj3 = entityManager.GetDirtyPropertyUids(entity, sRRdGoBr7eiXsaBqQb4p(CS_0024_003C_003E8__locals0.settings));
													goto IL_158e;
												case 43:
													if (!QLCJI0Br4XcKqKfuNXVB(entity))
													{
														num6 = 14;
														goto IL_0103;
													}
													goto case 52;
												case 49:
													if (AbjLE8BrwZsCgPlG48pi(CS_0024_003C_003E8__locals0.settings) != 0)
													{
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
														{
															num5 = 0;
														}
														continue;
													}
													goto case 19;
												case 37:
													metadataService = (IMetadataService)bqcpbxBrxNwAqZVwFPgd();
													num5 = 12;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
													{
														num5 = 23;
													}
													continue;
												case 26:
													try
													{
														while (true)
														{
															IL_1244:
															int num7;
															if (!enumerator.MoveNext())
															{
																num7 = 30;
																goto IL_0b30;
															}
															goto IL_0cdc;
															IL_0b30:
															while (true)
															{
																int num8;
																switch (num7)
																{
																case 52:
																	if (item)
																	{
																		num7 = 37;
																		continue;
																	}
																	goto case 57;
																case 58:
																	obj2 = D6akmUBr9N6mGgevZR6k(CS_0024_003C_003E8__locals0.obj, gIrWvBBrJH5uQ9iaduLl(current), null);
																	num7 = 26;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
																	{
																		num7 = 22;
																	}
																	continue;
																case 22:
																{
																	(bool, EntitySerializationSettings) tuple = Continue(CS_0024_003C_003E8__locals0.settings, current, (string)gIrWvBBrJH5uQ9iaduLl(current));
																	item2 = tuple.Item1;
																	settings2 = tuple.Item2;
																	num7 = 47;
																	continue;
																}
																case 35:
																	break;
																case 6:
																	if (serializableTypeDescriptor != null)
																	{
																		num7 = 56;
																		continue;
																	}
																	goto IL_1244;
																case 28:
																{
																	(bool, EntitySerializationSettings) tuple2 = Continue(CS_0024_003C_003E8__locals0.settings, current, current.Name);
																	item = tuple2.Item1;
																	entitySerializationSettings = tuple2.Item2;
																	num7 = 52;
																	continue;
																}
																case 19:
																case 27:
																	if (CS_0024_003C_003E8__locals0.settings == null)
																	{
																		num7 = 9;
																		continue;
																	}
																	goto case 24;
																case 33:
																	if (!PropertyFilter(current))
																	{
																		num7 = 59;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
																		{
																			num7 = 15;
																		}
																		continue;
																	}
																	goto case 7;
																case 55:
																	if (CS_0024_003C_003E8__locals0.settings != null)
																	{
																		num7 = 28;
																		continue;
																	}
																	goto case 57;
																case 18:
																	dictionary = serializableTypeDescriptor.Serialize(CS_0024_003C_003E8__locals0.obj, CS_0024_003C_003E8__locals0.metadata, current, entitySerializationSettings);
																	num7 = 29;
																	continue;
																case 45:
																	if (((EntitySerializationFunctions)JIbcIeBrdSCTWs6s5Vva(CS_0024_003C_003E8__locals0.settings)).Filter == null)
																	{
																		num7 = 13;
																		continue;
																	}
																	goto case 10;
																case 60:
																	((IDictionary<string, object>)serializableDictionary)[(string)gIrWvBBrJH5uQ9iaduLl(current)] = value;
																	num8 = 44;
																	goto IL_0b2c;
																case 10:
																	flag = ((EntitySerializationFunctions)JIbcIeBrdSCTWs6s5Vva(CS_0024_003C_003E8__locals0.settings)).Filter(CS_0024_003C_003E8__locals0.obj, CS_0024_003C_003E8__locals0.metadata, current, entitySerializationSettings);
																	num7 = 0;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
																	{
																		num7 = 0;
																	}
																	continue;
																case 50:
																	if (service == null)
																	{
																		num7 = 1;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
																		{
																			num7 = 0;
																		}
																		continue;
																	}
																	goto case 54;
																case 14:
																	if (JIbcIeBrdSCTWs6s5Vva(CS_0024_003C_003E8__locals0.settings) == null)
																	{
																		num7 = 20;
																		continue;
																	}
																	goto case 40;
																case 8:
																	try
																	{
																		while (true)
																		{
																			int num9;
																			if (!enumerator2.MoveNext())
																			{
																				num9 = 3;
																				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
																				{
																					num9 = 0;
																				}
																				goto IL_0efa;
																			}
																			goto IL_0f3a;
																			IL_0f3a:
																			current2 = enumerator2.Current;
																			num9 = 0;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
																			{
																				num9 = 0;
																			}
																			goto IL_0efa;
																			IL_0efa:
																			while (true)
																			{
																				switch (num9)
																				{
																				case 1:
																					break;
																				case 2:
																					goto IL_0f3a;
																				default:
																					((IDictionary<string, object>)serializableDictionary)[current2.Key] = current2.Value;
																					num9 = 0;
																					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
																					{
																						num9 = 1;
																					}
																					continue;
																				case 3:
																					goto end_IL_0f14;
																				}
																				break;
																			}
																			continue;
																			end_IL_0f14:
																			break;
																		}
																	}
																	finally
																	{
																		int num10;
																		if (enumerator2 == null)
																		{
																			num10 = 2;
																			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
																			{
																				num10 = 2;
																			}
																			goto IL_0fb6;
																		}
																		goto IL_0feb;
																		IL_0feb:
																		enumerator2.Dispose();
																		num10 = 1;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
																		{
																			num10 = 1;
																		}
																		goto IL_0fb6;
																		IL_0fb6:
																		switch (num10)
																		{
																		case 2:
																			goto end_IL_0f91;
																		case 1:
																			goto end_IL_0f91;
																		}
																		goto IL_0feb;
																		end_IL_0f91:;
																	}
																	goto IL_1244;
																case 20:
																case 46:
																case 48:
																	dictionary = serializableTypeDescriptor.Serialize(CS_0024_003C_003E8__locals0.obj, CS_0024_003C_003E8__locals0.metadata, current, entitySerializationSettings);
																	num8 = 12;
																	goto IL_0b2c;
																case 40:
																	if (((EntitySerializationFunctions)JIbcIeBrdSCTWs6s5Vva(CS_0024_003C_003E8__locals0.settings)).Serialize != null)
																	{
																		num8 = 4;
																		goto IL_0b2c;
																	}
																	goto case 20;
																case 47:
																	if (item2)
																	{
																		num7 = 31;
																		continue;
																	}
																	goto case 49;
																case 26:
																	if (obj2 != null)
																	{
																		num7 = 42;
																		continue;
																	}
																	goto case 15;
																case 36:
																	if (CS_0024_003C_003E8__locals0.settings == null)
																	{
																		num7 = 48;
																		continue;
																	}
																	goto case 14;
																case 49:
																case 51:
																	value = ConvertToSerializable(obj2, settings2);
																	num7 = 60;
																	continue;
																case 5:
																	if (CS_0024_003C_003E8__locals0.settings == null)
																	{
																		num7 = 49;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
																		{
																			num7 = 11;
																		}
																		continue;
																	}
																	goto case 22;
																case 2:
																case 23:
																case 44:
																	serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
																	num7 = 4;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
																	{
																		num7 = 6;
																	}
																	continue;
																case 12:
																case 29:
																case 53:
																	if (dictionary != null)
																	{
																		num7 = 29;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
																		{
																			num7 = 41;
																		}
																		continue;
																	}
																	goto IL_1244;
																case 21:
																	if (entity == null)
																	{
																		num7 = 32;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
																		{
																			num7 = 21;
																		}
																		continue;
																	}
																	goto case 25;
																case 38:
																	dictionary = CS_0024_003C_003E8__locals0.settings.Functions.Serialize(serializableTypeDescriptor, CS_0024_003C_003E8__locals0.obj, CS_0024_003C_003E8__locals0.metadata, current, entitySerializationSettings);
																	num7 = 53;
																	continue;
																case 17:
																	if (typeDescriptor != null)
																	{
																		num7 = 23;
																		continue;
																	}
																	goto case 58;
																case 54:
																	if (service.CheckPropertyPermission(entity, chbMOVBr6iCd0igt8IYm(current)) != PropertyPermissionType.Hide)
																	{
																		num7 = 16;
																		continue;
																	}
																	goto IL_1244;
																case 57:
																	dictionary = null;
																	num7 = 5;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
																	{
																		num7 = 36;
																	}
																	continue;
																case 15:
																	((IDictionary<string, object>)serializableDictionary)[(string)gIrWvBBrJH5uQ9iaduLl(current)] = null;
																	num7 = 2;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
																	{
																		num7 = 0;
																	}
																	continue;
																case 34:
																case 42:
																	settings2 = null;
																	num7 = 5;
																	continue;
																case 31:
																case 37:
																case 39:
																case 59:
																	goto IL_1244;
																default:
																	if (flag)
																	{
																		num7 = 38;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
																		{
																			num7 = 30;
																		}
																		continue;
																	}
																	goto case 18;
																case 25:
																	service = Locator.GetService<IPropertyPermissionService>();
																	num7 = 50;
																	continue;
																case 56:
																	entitySerializationSettings = null;
																	num7 = 55;
																	continue;
																case 41:
																	enumerator2 = dictionary.GetEnumerator();
																	num7 = 8;
																	continue;
																case 11:
																	if (array.Contains(chbMOVBr6iCd0igt8IYm(current)))
																	{
																		num7 = 19;
																		continue;
																	}
																	goto IL_1244;
																case 1:
																case 9:
																case 16:
																case 32:
																case 43:
																	typeDescriptor = (ITypeDescriptor)HbpRqlBrMZ855HvM8iS0(metadataService, V4Hof2Brm0w0WBeGuE8x(current), AIBoY6BryqQihLylklFb(current));
																	num7 = 17;
																	continue;
																case 7:
																	if (array == null)
																	{
																		num8 = 27;
																		goto IL_0b2c;
																	}
																	goto case 11;
																case 24:
																	if (!Hf97Z1Br0FSnTqEaGB1A(CS_0024_003C_003E8__locals0.settings))
																	{
																		num7 = 43;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
																		{
																			num7 = 27;
																		}
																		continue;
																	}
																	goto case 21;
																case 4:
																	flag = true;
																	num7 = 45;
																	continue;
																case 3:
																	if (PropertyFilter != null)
																	{
																		num8 = 33;
																		goto IL_0b2c;
																	}
																	goto case 7;
																case 30:
																	goto end_IL_1244;
																	IL_0b2c:
																	num7 = num8;
																	continue;
																}
																break;
															}
															goto IL_0cdc;
															IL_0cdc:
															current = enumerator.Current;
															num7 = 3;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
															{
																num7 = 1;
															}
															goto IL_0b30;
															continue;
															end_IL_1244:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator).Dispose();
														int num11 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
														{
															num11 = 0;
														}
														switch (num11)
														{
														case 0:
															break;
														}
													}
													goto case 4;
												case 19:
												case 45:
													serializableDictionary[(string)CV43EWBrNKSDAZ8S6FRi(0x3A6135BE ^ 0x3A6177DC)] = chbMOVBr6iCd0igt8IYm(CS_0024_003C_003E8__locals0.metadata);
													num5 = 41;
													continue;
												case 20:
													((IDictionary<string, object>)serializableDictionary)[(string)CV43EWBrNKSDAZ8S6FRi(-2138958856 ^ -2138872406)] = reference;
													num5 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
													{
														num5 = 7;
													}
													continue;
												case 40:
													if (entity != null)
													{
														num5 = 39;
														continue;
													}
													break;
												case 5:
													if (!referenceResolver.TryGetReference(CS_0024_003C_003E8__locals0.obj, CS_0024_003C_003E8__locals0.metadata, out reference))
													{
														num5 = 21;
														continue;
													}
													goto case 20;
												case 38:
													((IDictionary<string, object>)serializableDictionary)[(string)CV43EWBrNKSDAZ8S6FRi(-1459557599 ^ -1459511715)] = entity.ToString();
													num5 = 42;
													continue;
												case 27:
													if (typeSettingsInstanceStore == null)
													{
														num5 = 31;
														continue;
													}
													goto case 11;
												case 21:
												case 25:
													((IDictionary<string, object>)serializableDictionary)[(string)CV43EWBrNKSDAZ8S6FRi(-1633514411 ^ -1633420789)] = reference;
													num5 = 50;
													continue;
												case 15:
													if (entity == null)
													{
														num5 = 36;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
														{
															num5 = 7;
														}
														continue;
													}
													goto case 8;
												case 6:
													break;
												case 46:
													{
														return result;
													}
													IL_156d:
													entityManager = (IEntityManager)obj4;
													num5 = 2;
													continue;
													IL_0103:
													num5 = num6;
													continue;
													IL_158e:
													array = (Guid[])obj3;
													num5 = 37;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
													{
														num5 = 27;
													}
													continue;
												}
												break;
											}
										}
										finally
										{
											int num17;
											if (disposable2 == null)
											{
												num17 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
												{
													num17 = 0;
												}
												goto IL_15d4;
											}
											goto IL_15ea;
											IL_15ea:
											S2JZIsBrsKd90OvN4Nbg(disposable2);
											num17 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
											{
												num17 = 1;
											}
											goto IL_15d4;
											IL_15d4:
											switch (num17)
											{
											default:
												goto end_IL_15af;
											case 2:
												break;
											case 0:
												goto end_IL_15af;
											case 1:
												goto end_IL_15af;
											}
											goto IL_15ea;
											end_IL_15af:;
										}
										goto end_IL_007d;
									case 3:
										goto IL_167a;
									case 1:
										goto end_IL_007d;
									}
									break;
								}
								goto IL_1645;
								IL_167a:
								int num18 = 0;
								goto IL_167b;
								IL_1645:
								num18 = (IcBTPaBrajQixJIkmFEk(CS_0024_003C_003E8__locals0.settings) ? 1 : 0);
								goto IL_167b;
								IL_167b:
								flag2 = (byte)num18 != 0;
								num4 = 4;
								goto IL_00a7;
								end_IL_007d:;
							}
							catch (Exception ex)
							{
								int num19 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num19 = 0;
								}
								while (true)
								{
									switch (num19)
									{
									default:
										if (methodCallInfo != null)
										{
											num19 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
											{
												num19 = 1;
											}
											continue;
										}
										break;
									case 1:
										nYHrVXBrcHNJMSIeSIs4(methodCallInfo, ex);
										num19 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num19 = 2;
										}
										continue;
									case 2:
										break;
									}
									break;
								}
								throw;
							}
							goto case 1;
						case 1:
							result = serializableDictionary;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							return result;
						}
					}
				}
				finally
				{
					int num20;
					if (methodCallInfo == null)
					{
						num20 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num20 = 1;
						}
						goto IL_176a;
					}
					goto IL_1780;
					IL_1780:
					S2JZIsBrsKd90OvN4Nbg(methodCallInfo);
					num20 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num20 = 0;
					}
					goto IL_176a;
					IL_176a:
					switch (num20)
					{
					default:
						goto end_IL_1745;
					case 2:
						break;
					case 1:
						goto end_IL_1745;
					case 0:
						goto end_IL_1745;
					}
					goto IL_1780;
					end_IL_1745:;
				}
			case 1:
				CS_0024_003C_003E8__locals0.settings = settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			default:
				CS_0024_003C_003E8__locals0.metadata = metadata;
				num2 = 7;
				break;
			case 8:
				methodCallInfo = DiagnosticsManager.StartCall(CS_0024_003C_003E8__locals0._003CConvertToSerializable_003Eb__0);
				num2 = 4;
				break;
			case 3:
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				dtAtYPBr37LMjfr30FIk(CS_0024_003C_003E8__locals0.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939391566));
				num2 = 8;
				break;
			case 7:
				dtAtYPBr37LMjfr30FIk(CS_0024_003C_003E8__locals0.obj, CV43EWBrNKSDAZ8S6FRi(0x7459E02 ^ 0x7453D8A));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				return result;
			case 2:
				CS_0024_003C_003E8__locals0.obj = obj;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public T ConvertFromSerializable<T>(IDictionary<string, object> obj) where T : class
	{
		return (T)ConvertFromSerializable(obj, typeof(T));
	}

	public object ConvertFromSerializable(IDictionary<string, object> serObj, Type entityType, bool loadEntityIfExists = true)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.loadEntityIfExists = loadEntityIfExists;
		return ConvertFromSerializable(serObj, entityType, (object id, Type type) => CS_0024_003C_003E8__locals0.loadEntityIfExists);
	}

	public object ConvertFromSerializable(IDictionary<string, object> serObj, Type entityType, Func<object, Type, bool> loadEntityIfExistsHandler)
	{
		Contract.ArgumentNotNull(serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C524E7F));
		Contract.ArgumentNotNull(entityType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29274377));
		object obj = TryDeserializeEntityId(serObj, entityType);
		Guid? guid = TryDeserializeEntityUid(serObj);
		object obj2 = null;
		bool flag = loadEntityIfExistsHandler?.Invoke(obj, entityType) ?? true;
		if (flag)
		{
			Type entityIdType = ModelHelper.GetEntityIdType(entityType);
			IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entityType);
			if ((obj == null || entityType.IsDefaultId(entityIdType, obj)) && guid.HasValue && guid.Value != Guid.Empty)
			{
				obj2 = entityManagerOrNull?.LoadOrCreate(guid.Value);
			}
			if (obj2 == null && obj != null)
			{
				obj2 = entityManagerOrNull?.LoadOrNull(obj);
			}
		}
		if (obj2 == null)
		{
			obj2 = InterfaceActivator.Create(entityType);
		}
		IEntity entity = obj2 as IEntity;
		if (entity != null && NeedBindProperties != null && !NeedBindProperties(entity))
		{
			return entity;
		}
		if (obj != null && entity != null)
		{
			object id = entity.GetId();
			if (id == null || id.GetType() != typeof(long) || (long)id <= 0)
			{
				entity.SetId(obj);
			}
		}
		return ConvertFromSerializable(obj2, serObj, flag);
	}

	public object ConvertFromSerializable(object obj, IDictionary<string, object> serObj, bool loadEntityIfExists = true)
	{
		obj = obj.CastAsRealType();
		return ConvertFromSerializable(obj, (ClassMetadata)MetadataLoader.LoadMetadata(obj.GetType()), serObj, loadEntityIfExists);
	}

	internal object ConvertFromSerializable(object obj, ClassMetadata metadata, IDictionary<string, object> serObj, bool loadEntityIfExists = true)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.obj = obj;
		CS_0024_003C_003E8__locals0.serObj = serObj;
		CS_0024_003C_003E8__locals0.loadEntityIfExists = loadEntityIfExists;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E4BD53));
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.serObj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099699241));
		AddSerializerMarker(this);
		using MethodCallInfo methodCallInfo = DiagnosticsManager.StartCall(() => new MethodCallInfo(OwnerType, ConvertFromSerializableCall, new object[3] { CS_0024_003C_003E8__locals0.obj, CS_0024_003C_003E8__locals0.serObj, CS_0024_003C_003E8__locals0.loadEntityIfExists }));
		IEntity entity = CS_0024_003C_003E8__locals0.obj as IEntity;
		try
		{
			using (ReferenceResolverSerializer.CreateResolver(needResolver: true))
			{
				if (CS_0024_003C_003E8__locals0.serObj.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411141633), out var value))
				{
					return ReferenceResolverSerializer.CurrentResolver.ResolveReference(value.ToString());
				}
				if (CS_0024_003C_003E8__locals0.serObj.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548AD8D4), out var value2))
				{
					ReferenceResolverSerializer.CurrentResolver.AddReference(value2.ToString(), CS_0024_003C_003E8__locals0.obj);
				}
				IMetadataService service = MetadataServiceContext.Service;
				if (entity != null && CS_0024_003C_003E8__locals0.serObj.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099699393), out var value3) && value3 is IDictionary<string, object> dictionary)
				{
					Dictionary<string, IDictionary<string, object>> dictionary2 = new Dictionary<string, IDictionary<string, object>>();
					foreach (KeyValuePair<string, object> item in dictionary)
					{
						if (item.Value is IDictionary<string, object> value4)
						{
							dictionary2[item.Key] = value4;
						}
					}
					TypeSettingsInstanceData typeSettingsInstanceData = new TypeSettingsInstanceData();
					typeSettingsInstanceData.DeserializeFromJsonObject(dictionary2);
					foreach (TypeSettingsInstanceData.DataItem item2 in typeSettingsInstanceData.Items)
					{
						entity.SavePropertyInstanceSettings(item2.PropertyUid, item2.Settings);
					}
				}
				IDictionary<string, object> serObj2 = CS_0024_003C_003E8__locals0.serObj;
				foreach (PropertyMetadata property in metadata.Properties)
				{
					if ((PropertyFilter == null || PropertyFilter(property)) && property.TypeUid != Guid.Empty)
					{
						ITypeDescriptor typeDescriptor = service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid);
						if (typeDescriptor == null)
						{
							throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882202638), property.TypeUid));
						}
						if (typeDescriptor is ISerializableTypeDescriptor serializableTypeDescriptor)
						{
							serializableTypeDescriptor.Deserialize(CS_0024_003C_003E8__locals0.obj, metadata, property, serObj2);
						}
					}
				}
				if (metadata is ITablePartContainer tablePartContainer && tablePartContainer is IEntityMetadata && entity != null)
				{
					foreach (ITablePartMetadata tablePart in tablePartContainer.TableParts)
					{
						if (NeedBindTablePart != null && !NeedBindTablePart(tablePart))
						{
							continue;
						}
						object propertyValue = entity.GetPropertyValue(tablePart.TablePartPropertyUid);
						ISet val = (ISet)((propertyValue is ISet) ? propertyValue : null);
						if (val == null || serObj2 == null || !serObj2.TryGetValue(tablePart.TablePartPropertyName, out var value5))
						{
							continue;
						}
						IDictionary<string, object> dictionary3 = value5 as IDictionary<string, object>;
						IEnumerable enumerable = value5 as IEnumerable;
						Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(tablePart.Uid);
						if (dictionary3 != null)
						{
							TablePartChangesModel.FromDictionary(dictionary3).Apply(val, typeByUid, needRemoveOldItems: true);
						}
						else
						{
							if (enumerable == null)
							{
								continue;
							}
							val.Clear();
							foreach (object item3 in enumerable)
							{
								if (item3 is IDictionary<string, object> serObj3)
								{
									IEntity entity2 = (IEntity)ConvertFromSerializable(serObj3, typeByUid, CS_0024_003C_003E8__locals0.loadEntityIfExists);
									entity2?.SetPropertyValue(tablePart.ParentPropertyUid, entity);
									val.Add((object)entity2);
								}
							}
						}
					}
				}
			}
		}
		catch (Exception exception)
		{
			if (methodCallInfo != null)
			{
				methodCallInfo.Exception = exception;
			}
			throw;
		}
		InvokeActions(this);
		return CS_0024_003C_003E8__locals0.obj;
	}

	private void AddDictionaryByPath(string path, object value, Dictionary<string, object> dic)
	{
		List<string> list = path.Split(new char[1] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		string text = list[0];
		string text2 = string.Empty;
		if (list.Count > 1)
		{
			text2 = list[1];
			int num = text2.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886586003), StringComparison.InvariantCultureIgnoreCase);
			if (num > 0)
			{
				text2 = text2.Substring(0, num);
			}
		}
		list.RemoveAt(0);
		string path2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488875761), list);
		string text3 = "";
		if (text.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234345998), StringComparison.InvariantCultureIgnoreCase) > 0)
		{
			int num2 = text.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB520A), StringComparison.InvariantCultureIgnoreCase);
			int num3 = text.LastIndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x313297EE), StringComparison.InvariantCultureIgnoreCase);
			text3 = text.Substring(num2 + 1, num3 - num2 - 1);
			text = text.Substring(0, num2);
		}
		if (!string.IsNullOrWhiteSpace(text2))
		{
			_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			if (!string.IsNullOrWhiteSpace(text3) && long.TryParse(text3, out _003C_003Ec__DisplayClass12_.index))
			{
				_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass12_;
				List<Dictionary<string, object>> list2 = new List<Dictionary<string, object>>();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				CS_0024_003C_003E8__locals0.uniqueId = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112634296), (text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECEA5E8) + text3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97917250)).GetDeterministicGuid());
				if (dic.ContainsKey(text))
				{
					if (dic[text] is List<Dictionary<string, object>> list3)
					{
						Dictionary<string, object> dictionary2 = list3.FirstOrDefault((Dictionary<string, object> k) => k.ContainsKey(CS_0024_003C_003E8__locals0.uniqueId) && k[CS_0024_003C_003E8__locals0.uniqueId] is long && (long)k[CS_0024_003C_003E8__locals0.uniqueId] == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.index);
						if (dictionary2 == null)
						{
							dictionary.Add(CS_0024_003C_003E8__locals0.uniqueId, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.index);
							list3.Add(dictionary);
							AddDictionaryByPath(path2, value, dictionary);
						}
						else
						{
							AddDictionaryByPath(path2, value, dictionary2);
						}
					}
					else
					{
						list2.Add(dictionary);
					}
				}
				else
				{
					dictionary.Add(CS_0024_003C_003E8__locals0.uniqueId, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.index);
					list2.Add(dictionary);
					dic.Add(text, list2);
					AddDictionaryByPath(path2, value, dictionary);
				}
			}
			else
			{
				Dictionary<string, object> dictionary3 = (dic.ContainsKey(text) ? (dic[text] as Dictionary<string, object>) : null);
				if (dictionary3 != null)
				{
					AddDictionaryByPath(path2, value, dictionary3);
					return;
				}
				Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
				dic.Add(text, dictionary4);
				AddDictionaryByPath(path2, value, dictionary4);
			}
		}
		else
		{
			dic.Add(text, value);
		}
	}

	public object ConvertFromSerializable(object obj, NameValueCollection dict, ref Dictionary<string, Exception> errors, bool loadEntityIfExists = true)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_00a7, IL_0117, IL_014a, IL_01af, IL_0235, IL_0248, IL_0257
		int num = 1;
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (dict == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					return ConvertFromSerializable(obj, dictionary, loadEntityIfExists);
				default:
					return obj;
				case 3:
					try
					{
						while (true)
						{
							IL_01b9:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_00ab;
							}
							goto IL_00cd;
							IL_00ab:
							while (true)
							{
								switch (num3)
								{
								case 5:
									try
									{
										AddDictionaryByPath(current, text, dictionary);
										int num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
										{
											num4 = 0;
										}
										switch (num4)
										{
										case 0:
											break;
										}
									}
									catch (Exception value)
									{
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											case 2:
												errors.Add(current, value);
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
												{
													num5 = 1;
												}
												continue;
											default:
												if (errors != null)
												{
													num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
													{
														num5 = 2;
													}
													continue;
												}
												break;
											case 1:
												break;
											}
											break;
										}
									}
									goto IL_01b9;
								case 2:
									goto IL_01b9;
								case 4:
									text = (string)QW1cgeBgFPfBE44HCOUB(dict, current);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									if (!I6AyW3BgBQveuYTuRGuX(text))
									{
										num3 = 5;
										continue;
									}
									goto IL_01b9;
								case 3:
									goto end_IL_01b9;
								}
								break;
							}
							goto IL_00cd;
							IL_00cd:
							current = enumerator.Current;
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
							{
								num3 = 1;
							}
							goto IL_00ab;
							continue;
							end_IL_01b9:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 2;
				}
				break;
			}
			List<string> list = ((IEnumerable<string>)OXSpVQBrzGjIFhVUkL8o(dict)).ToList();
			list.Sort();
			dictionary = new Dictionary<string, object>();
			enumerator = list.GetEnumerator();
			num = 3;
		}
	}

	public object ConvertFromSerializable(object obj, IDictionary<string, string> dict, bool loadEntityIfExists = true)
	{
		if (dict == null)
		{
			return obj;
		}
		List<string> list = dict.Keys.ToList();
		list.Sort();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (string item in list)
		{
			string value = dict[item];
			if (!string.IsNullOrWhiteSpace(value))
			{
				AddDictionaryByPath(item, value, dictionary);
			}
		}
		return ConvertFromSerializable(obj, dictionary, loadEntityIfExists);
	}

	public string Serialize(object obj)
	{
		return Serialize(obj, null);
	}

	public string Serialize(object obj, EntitySerializationSettings settings)
	{
		int num = 2;
		int num2 = num;
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Contract.ArgumentNotNull(obj, (string)CV43EWBrNKSDAZ8S6FRi(0x571EA399 ^ 0x571E0011));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				obj2 = ConvertToSerializable(obj, settings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)RanddiBgW7lvLWxS0jHB(new JsonSerializer(), obj2);
			}
		}
	}

	public object Deserialize(string json, Type type, bool loadEntityIfExists = true)
	{
		int num = 3;
		int num2 = num;
		ExpandoObject serObj = default(ExpandoObject);
		while (true)
		{
			switch (num2)
			{
			case 2:
				dtAtYPBr37LMjfr30FIk(type, CV43EWBrNKSDAZ8S6FRi(0xE1229CF ^ 0xE1225ED));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				dtAtYPBr37LMjfr30FIk(json, CV43EWBrNKSDAZ8S6FRi(-1824388195 ^ -1824293517));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return ConvertFromSerializable(serObj, type, loadEntityIfExists);
			default:
				serObj = new JsonSerializer().Deserialize<ExpandoObject>(json);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public object Deserialize(string json, object obj, bool loadEntityIfExists = true)
	{
		int num = 3;
		int num2 = num;
		ExpandoObject serObj = default(ExpandoObject);
		while (true)
		{
			switch (num2)
			{
			default:
				serObj = new JsonSerializer().Deserialize<ExpandoObject>(json);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				dtAtYPBr37LMjfr30FIk(json, CV43EWBrNKSDAZ8S6FRi(0x7459E02 ^ 0x744E8EC));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return ConvertFromSerializable(obj, serObj, loadEntityIfExists);
			case 2:
				dtAtYPBr37LMjfr30FIk(obj, CV43EWBrNKSDAZ8S6FRi(-87337865 ^ -87296001));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ExpandoObject DeserializeJson(string json)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new JsonSerializer().Deserialize<ExpandoObject>(json);
			case 1:
				dtAtYPBr37LMjfr30FIk(json, CV43EWBrNKSDAZ8S6FRi(0x7459E02 ^ 0x744E8EC));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void AddSerializerMarker(object serializerMarker)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = default(_003C_003Ec__DisplayClass38_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass38_.serializerMarker = serializerMarker;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 3:
				_003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
				num2 = 2;
				break;
			default:
				ContextVars.GetOrAdd((string)CV43EWBrNKSDAZ8S6FRi(0x1637C429 ^ 0x1636B2D3), _003C_003Ec__DisplayClass38_._003CAddSerializerMarker_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void InvokeActions(object serializerMarker)
	{
		//Discarded unreachable code: IL_012a, IL_0139, IL_0144, IL_01d6, IL_01e9, IL_01f8, IL_0208, IL_0217, IL_0227, IL_0236
		int num = 8;
		object value2 = default(object);
		List<Action>.Enumerator enumerator = default(List<Action>.Enumerator);
		List<Action> value = default(List<Action>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (value2 == serializerMarker)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					return;
				case 8:
					if (!ContextVars.TryGetValue<object>((string)CV43EWBrNKSDAZ8S6FRi(-1638402543 ^ -1638498069), out value2))
					{
						num2 = 7;
						continue;
					}
					goto default;
				case 6:
					return;
				case 7:
					return;
				case 4:
					enumerator = value.GetEnumerator();
					num2 = 5;
					continue;
				case 1:
				case 2:
					goto end_IL_0012;
				case 3:
					if (!ContextVars.TryGetValue<List<Action>>((string)CV43EWBrNKSDAZ8S6FRi(-957824448 ^ -957762200), out value))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 9:
					break;
				case 5:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num3 = 0;
								}
								goto IL_0148;
							}
							goto IL_0184;
							IL_0184:
							TH2EQ4BgobdldpA1Pbs8(enumerator.Current);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
							{
								num3 = 2;
							}
							goto IL_0148;
							IL_0148:
							switch (num3)
							{
							case 2:
								continue;
							case 1:
								goto IL_0184;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					break;
				}
				R6qo3qBgbGBY88iOhP6S(CV43EWBrNKSDAZ8S6FRi(-2106517564 ^ -2106564372));
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			R6qo3qBgbGBY88iOhP6S(CV43EWBrNKSDAZ8S6FRi(0x34A6D230 ^ 0x34A7A4CA));
			num = 6;
		}
	}

	internal static void AddAction(Action action)
	{
		int num = 1;
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
				ContextVars.GetOrAdd((string)CV43EWBrNKSDAZ8S6FRi(-195614443 ^ -195666371), () => new List<Action>()).Add(action);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual object TryDeserializeEntityId(IDictionary<string, object> dictionary, Type entityType)
	{
		if (dictionary != null && dictionary.TryGetValue(IdPropertyName, out var value))
		{
			return ModelHelper.TryConvertEntityId(entityType, value);
		}
		return null;
	}

	protected virtual Guid? TryDeserializeEntityUid(IDictionary<string, object> dictionary)
	{
		if (dictionary != null && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978482848), out var value) && value != null && Guid.TryParse(value.ToString(), out var result))
		{
			return result;
		}
		return null;
	}

	public EntityJsonSerializer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YQHaNoBghix4E9dWAt20();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityJsonSerializer()
	{
		int num = 4;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 4:
				YQHaNoBghix4E9dWAt20();
				num2 = 3;
				continue;
			case 5:
				parameterExpression = (ParameterExpression)OM87ePBgEafJ2qSd3ad2(DLOkrDBgGaVU18Di8uRB(typeof(IEntity<object>).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767755309));
				num2 = 2;
				continue;
			case 2:
				IdPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IEntity<object>, object>>((Expression)aLMOSnBgQhfCQuutRluR(parameterExpression, (MethodInfo)rYdVrwBgfn6GkHDiK6Ot((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<object>).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 6;
				continue;
			case 3:
				OwnerType = DLOkrDBgGaVU18Di8uRB(typeof(EntityJsonSerializer).TypeHandle);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				ConvertFromSerializableCall = DLOkrDBgGaVU18Di8uRB(typeof(EntityJsonSerializer).TypeHandle).GetMethod((string)CV43EWBrNKSDAZ8S6FRi(0x3CE17B75 ^ 0x3CE00C1B), new Type[3]
				{
					typeof(object),
					typeof(IDictionary<string, object>),
					DLOkrDBgGaVU18Di8uRB(typeof(bool).TypeHandle)
				});
				num2 = 5;
				continue;
			}
			ConvertToSerializableCall = DLOkrDBgGaVU18Di8uRB(typeof(EntityJsonSerializer).TypeHandle).GetMethod((string)CV43EWBrNKSDAZ8S6FRi(-488881205 ^ -488819573), new Type[2]
			{
				typeof(object),
				DLOkrDBgGaVU18Di8uRB(typeof(EntitySerializationSettings).TypeHandle)
			});
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool j08Z3pBrPON0by2K6OOj()
	{
		return WgwoIsBreZxYoYOUmtth == null;
	}

	internal static EntityJsonSerializer oW6XAfBr1TqdlS4e6Uit()
	{
		return WgwoIsBreZxYoYOUmtth;
	}

	internal static object CV43EWBrNKSDAZ8S6FRi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void dtAtYPBr37LMjfr30FIk(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object ELM1vCBrpJqE1h8INrAs(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static bool IcBTPaBrajQixJIkmFEk(object P_0)
	{
		return ((EntitySerializationSettings)P_0).WriteReferences;
	}

	internal static object xWVskSBrDKR1fTolQB4W()
	{
		return ReferenceResolverSerializer.CurrentResolver;
	}

	internal static object tBVp43BrtBxyxSSMQkj0(bool needResolver)
	{
		return ReferenceResolverSerializer.CreateResolver(needResolver);
	}

	internal static EntitySerializationMode AbjLE8BrwZsCgPlG48pi(object P_0)
	{
		return ((EntitySerializationSettings)P_0).Mode;
	}

	internal static bool QLCJI0Br4XcKqKfuNXVB(object P_0)
	{
		return ((IEntity)P_0).IsNew();
	}

	internal static Guid chbMOVBr6iCd0igt8IYm(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object dnj12rBrH3DsMvnkrW3a(Type entityType)
	{
		return ModelHelper.GetEntityManager(entityType);
	}

	internal static object L0eTMhBrAsYS2YYDfW7c(object P_0)
	{
		return ((IEntity)P_0).GetDirtyPropertyUids();
	}

	internal static object sRRdGoBr7eiXsaBqQb4p(object P_0)
	{
		return ((EntitySerializationSettings)P_0).OriginalState;
	}

	internal static object bqcpbxBrxNwAqZVwFPgd()
	{
		return MetadataServiceContext.Service;
	}

	internal static bool Hf97Z1Br0FSnTqEaGB1A(object P_0)
	{
		return ((EntitySerializationSettings)P_0).CheckPropertyPermissions;
	}

	internal static Guid V4Hof2Brm0w0WBeGuE8x(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid AIBoY6BryqQihLylklFb(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object HbpRqlBrMZ855HvM8iS0(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object gIrWvBBrJH5uQ9iaduLl(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object D6akmUBr9N6mGgevZR6k(object P_0, object P_1, object P_2)
	{
		return P_0.GetPropertyValue((string)P_1, P_2);
	}

	internal static object JIbcIeBrdSCTWs6s5Vva(object P_0)
	{
		return ((EntitySerializationSettings)P_0).Functions;
	}

	internal static object eu9MqaBrlpca1JPpJqtc(object P_0, bool createIfNotExists, bool loadIfNotLoaded)
	{
		return ((IEntity)P_0).LoadSettingsInstanceStore(createIfNotExists, loadIfNotLoaded);
	}

	internal static object kDglQ5BrrCkM5SflOkIH(object P_0)
	{
		return ((ITypeSettingsInstanceStore)P_0).Settings;
	}

	internal static int jr59I2BrgiCr4i7MX2eS(object P_0)
	{
		return ((List<TypeSettingsInstanceData.DataItem>)P_0).Count;
	}

	internal static Guid iE5FM0Br5Y2AMx24nypq(object P_0)
	{
		return ((ITablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static object SoBUMMBrjxwVcAwfuCnI(object P_0)
	{
		return ((ITablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static object HyLDxABrYTNTc1q1Z0iC(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static object oGhD9aBrLhLkLRSGH2Mr(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object xD6YjPBrU3slIB069iFj(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static void S2JZIsBrsKd90OvN4Nbg(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void nYHrVXBrcHNJMSIeSIs4(object P_0, object P_1)
	{
		((AbstractCallInfo)P_0).Exception = (Exception)P_1;
	}

	internal static object OXSpVQBrzGjIFhVUkL8o(object P_0)
	{
		return ((NameValueCollection)P_0).AllKeys;
	}

	internal static object QW1cgeBgFPfBE44HCOUB(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static bool I6AyW3BgBQveuYTuRGuX(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object RanddiBgW7lvLWxS0jHB(object P_0, object P_1)
	{
		return ((JavaScriptSerializer)P_0).Serialize(P_1);
	}

	internal static void TH2EQ4BgobdldpA1Pbs8(object P_0)
	{
		P_0();
	}

	internal static void R6qo3qBgbGBY88iOhP6S(object P_0)
	{
		ContextVars.Remove((string)P_0);
	}

	internal static void YQHaNoBghix4E9dWAt20()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type DLOkrDBgGaVU18Di8uRB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object OM87ePBgEafJ2qSd3ad2(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object rYdVrwBgfn6GkHDiK6Ot(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object aLMOSnBgQhfCQuutRluR(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}
}
