using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.UserDefinedList;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.UserDefinedList;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts.Services;

[Service]
internal class UserDefinedListService : IUserDefinedListService
{
	private class DictionaryResultTransformer : IResultTransformer
	{
		private static object IvULU1fYxObIZ0E9Mb1c;

		public object TransformTuple(object[] tuple, string[] aliases)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					_003C_003Ec__DisplayClass0_.tuple = tuple;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return new UDLDynamicObject(aliases.Select(_003C_003Ec__DisplayClass0_._003CTransformTuple_003Eb__0).ToDictionary((KeyValuePair<string, object> p) => p.Key, (KeyValuePair<string, object> p) => p.Value));
				}
			}
		}

		public IList TransformList(IList collection)
		{
			return collection;
		}

		public DictionaryResultTransformer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			DC5x7ufYyPSsbYORBBgi();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ELIccCfY0guSa7TEruqG()
		{
			return IvULU1fYxObIZ0E9Mb1c == null;
		}

		internal static DictionaryResultTransformer qgKep1fYmJYnZ1u5Y54t()
		{
			return (DictionaryResultTransformer)IvULU1fYxObIZ0E9Mb1c;
		}

		internal static void DC5x7ufYyPSsbYORBBgi()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private readonly NestedScopeComponents<IEntityManagerBehavior> behaviors;

	private readonly ISessionProvider sessionProvider;

	private readonly ILogger logger;

	private static UserDefinedListService gT23erLe4xq53Drsw4N;

	public UserDefinedListService(ISessionProvider sessionProvider)
	{
		//Discarded unreachable code: IL_0055, IL_005a
		POVZIPLNrdF5mD4OGJI();
		behaviors = new NestedScopeComponents<IEntityManagerBehavior>(ServiceScope.Shell);
		logger = (ILogger)mHqXrBLpHigmZ7RuxCs(A1DnkJL31cuZUAeXSts(typeof(UserDefinedListService).TypeHandle));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.sessionProvider = sessionProvider;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
			{
				num = 1;
			}
		}
	}

	public IEnumerable<object> GetUserDefinedList(UserDefinedListInfo preparationDataInfo)
	{
		List<object> list = new List<object>();
		if (preparationDataInfo.SubTypeUid == Guid.Empty)
		{
			return list;
		}
		IEnumerable<object> entities = GetEntities(preparationDataInfo);
		if (!entities.Any())
		{
			return list;
		}
		ClassMetadata metadata = GetMetadata(preparationDataInfo);
		if (metadata == null)
		{
			return list;
		}
		EntitySerializationSettings settings = new EntitySerializationSettings();
		EntityJsonSerializer entityJsonSerializer = new EntityJsonSerializer();
		foreach (object item in entities)
		{
			SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
			UDLDynamicObject uDLDynamicObject = (UDLDynamicObject)item;
			foreach (PropertyMetadata property in metadata.Properties)
			{
				object obj = uDLDynamicObject.TryGetValue(property.Name);
				if (obj != null)
				{
					ISerializableTypeDescriptor serializableTypeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) as ISerializableTypeDescriptor;
					object obj2 = null;
					try
					{
						obj2 = ((!IsSimpleType(property.Settings)) ? entityJsonSerializer.ConvertToSerializable(obj, metadata, settings) : serializableTypeDescriptor.SerializeSimple(obj, obj.GetType()));
					}
					catch (Exception exception)
					{
						logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629831826)), exception);
					}
					if (obj2 != null)
					{
						((IDictionary<string, object>)serializableDictionary)[property.Name] = obj2;
					}
				}
			}
			list.Add(serializableDictionary);
		}
		return list;
	}

	private bool IsSimpleType(TypeSettings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(settings is EntitySettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return !(settings is PropertySettings);
			}
		}
	}

	private ClassMetadata GetMetadata(UserDefinedListInfo userDefinedListInfo)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_01ab, IL_01b5, IL_02a5, IL_02eb, IL_02fa, IL_0375, IL_0388, IL_0397, IL_041e, IL_042d, IL_04c9, IL_0501, IL_06f2, IL_072c, IL_073f, IL_074e, IL_0782, IL_097f, IL_09f1, IL_0a00, IL_0ab5, IL_0b8a, IL_0b9d, IL_0bac, IL_0bfb, IL_0c0e, IL_0c1e, IL_0d21, IL_0d48, IL_0d57, IL_0dad, IL_0dd2, IL_0de0, IL_0e9d, IL_0eb0, IL_0ebf, IL_0ecf, IL_0ede, IL_0fc8, IL_0fd7, IL_0fe2, IL_1029, IL_106d, IL_1119, IL_1199, IL_11ac, IL_11bb, IL_1349, IL_135c, IL_136b, IL_13b8
		int num = 11;
		int num2 = num;
		List<GroupingProperty>.Enumerator enumerator5 = default(List<GroupingProperty>.Enumerator);
		List<AggregationProperty>.Enumerator enumerator4 = default(List<AggregationProperty>.Enumerator);
		IPropertyMetadata propertyMetadata10 = default(IPropertyMetadata);
		_003C_003Ec__DisplayClass9_4 _003C_003Ec__DisplayClass9_5 = default(_003C_003Ec__DisplayClass9_4);
		PropertyMetadata propertyMetadata8 = default(PropertyMetadata);
		IPropertyMetadata propertyMetadata9 = default(IPropertyMetadata);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		List<Guid>.Enumerator enumerator3 = default(List<Guid>.Enumerator);
		string text4 = default(string);
		IPropertyMetadata propertyMetadata12 = default(IPropertyMetadata);
		_003C_003Ec__DisplayClass9_5 _003C_003Ec__DisplayClass9_6 = default(_003C_003Ec__DisplayClass9_5);
		ClassMetadata classMetadata4 = default(ClassMetadata);
		ClassMetadata classMetadata3 = default(ClassMetadata);
		ClassMetadata classMetadata = default(ClassMetadata);
		_003C_003Ec__DisplayClass9_3 _003C_003Ec__DisplayClass9_4 = default(_003C_003Ec__DisplayClass9_3);
		IEnumerable<IPropertyMetadata> source = default(IEnumerable<IPropertyMetadata>);
		IEnumerable<IPropertyMetadata> properties = default(IEnumerable<IPropertyMetadata>);
		IPropertyMetadata propertyMetadata6 = default(IPropertyMetadata);
		_003C_003Ec__DisplayClass9_2 _003C_003Ec__DisplayClass9_3 = default(_003C_003Ec__DisplayClass9_2);
		PropertyMetadata propertyMetadata5 = default(PropertyMetadata);
		List<int>.Enumerator enumerator2 = default(List<int>.Enumerator);
		List<int> datePartTypes2 = default(List<int>);
		string text3 = default(string);
		int current2 = default(int);
		List<IncludedProperty>.Enumerator enumerator = default(List<IncludedProperty>.Enumerator);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		IPropertyMetadata propertyMetadata2 = default(IPropertyMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		string text2 = default(string);
		string text = default(string);
		int current = default(int);
		IPropertyMetadata propertyMetadata3 = default(IPropertyMetadata);
		_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_2 = default(_003C_003Ec__DisplayClass9_1);
		ClassMetadata classMetadata2 = default(ClassMetadata);
		List<int> datePartTypes = default(List<int>);
		IEntityMetadata entityMetadata = default(IEntityMetadata);
		while (true)
		{
			IEnumerable<IPropertyMetadata> enumerable;
			switch (num2)
			{
			case 9:
				enumerator5 = userDefinedListInfo.GroupingProperties.GetEnumerator();
				num2 = 13;
				continue;
			case 1:
				try
				{
					while (true)
					{
						int num16;
						if (!enumerator4.MoveNext())
						{
							num16 = 3;
							goto IL_0093;
						}
						goto IL_04a3;
						IL_0093:
						while (true)
						{
							int num17;
							switch (num16)
							{
							case 22:
								if (propertyMetadata10 == null)
								{
									num16 = 8;
									continue;
								}
								goto case 9;
							case 15:
								if (_003C_003Ec__DisplayClass9_5.includedProperty == null)
								{
									num16 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
									{
										num16 = 20;
									}
									continue;
								}
								goto case 23;
							case 21:
								AI0UVyLxlggDZZG3qd2(propertyMetadata8, WG5jVyLri4qaFgx39xi(propertyMetadata9));
								num16 = 16;
								continue;
							case 19:
								propertyMetadata10 = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass9_5._003CGetMetadata_003Eb__6);
								num16 = 22;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num16 = 15;
								}
								continue;
							case 1:
								try
								{
									while (true)
									{
										IL_02af:
										int num18;
										if (!enumerator3.MoveNext())
										{
											num18 = 7;
											goto IL_01b9;
										}
										goto IL_0305;
										IL_01b9:
										while (true)
										{
											switch (num18)
											{
											default:
												text4 += propertyMetadata12.Name;
												num18 = 11;
												continue;
											case 3:
												_003C_003Ec__DisplayClass9_6.parentUid = enumerator3.Current;
												num18 = 6;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
												{
													num18 = 5;
												}
												continue;
											case 5:
												classMetadata4 = (ClassMetadata)MetadataLoader.LoadMetadata(ModelHelper.GetEntityType(mZhagXLtvOSNt22f2d4(propertyMetadata12)));
												num18 = 8;
												continue;
											case 6:
												propertyMetadata12 = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass9_6._003CGetMetadata_003Eb__5);
												num18 = 5;
												continue;
											case 1:
												if (entityMetadata3 == null)
												{
													num18 = 4;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
													{
														num18 = 0;
													}
													continue;
												}
												goto IL_02af;
											case 4:
												break;
											case 10:
												goto IL_02af;
											case 8:
												if (classMetadata4 == null)
												{
													num18 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
													{
														num18 = 2;
													}
													continue;
												}
												goto default;
											case 2:
												break;
											case 9:
												goto IL_0305;
											case 11:
												entityMetadata3 = classMetadata4 as EntityMetadata;
												num18 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
												{
													num18 = 0;
												}
												continue;
											case 7:
												break;
											}
											break;
										}
										break;
										IL_0305:
										_003C_003Ec__DisplayClass9_6 = new _003C_003Ec__DisplayClass9_5();
										num18 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
										{
											num18 = 3;
										}
										goto IL_01b9;
									}
								}
								finally
								{
									((IDisposable)enumerator3).Dispose();
									int num19 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
									{
										num19 = 0;
									}
									switch (num19)
									{
									case 0:
										break;
									}
								}
								goto case 6;
							case 24:
								propertyMetadata8 = null;
								num16 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num16 = 17;
								}
								continue;
							case 16:
								vmCAHjLyntHQkpbGCnx(propertyMetadata8, mZhagXLtvOSNt22f2d4(propertyMetadata9));
								num16 = 11;
								continue;
							case 6:
								if (entityMetadata3 != null)
								{
									num16 = 19;
									continue;
								}
								break;
							case 17:
								if (propertyMetadata9 == null)
								{
									num17 = 26;
									goto IL_008f;
								}
								goto case 32;
							case 23:
								if ((entityMetadata3 = classMetadata3 as EntityMetadata) != null)
								{
									num16 = 18;
									continue;
								}
								break;
							case 7:
							case 8:
							case 10:
							case 14:
							case 20:
								break;
							case 12:
							case 28:
								classMetadata.Properties.Add(propertyMetadata8);
								num16 = 10;
								continue;
							case 2:
								if (dqqX23LD9MKaMZVABlN(_003C_003Ec__DisplayClass9_4.aggregation.OriginalPropertyUid, Guid.Empty))
								{
									num16 = 7;
									continue;
								}
								goto case 25;
							case 4:
								_003C_003Ec__DisplayClass9_4.aggregation = enumerator4.Current;
								num16 = 2;
								continue;
							case 5:
								goto IL_04a3;
							case 31:
								_003C_003Ec__DisplayClass9_5.includedProperty = userDefinedListInfo.IncludedProperties.FirstOrDefault(_003C_003Ec__DisplayClass9_4._003CGetMetadata_003Eb__4);
								num16 = 15;
								continue;
							case 30:
								classMetadata.Properties.Add(propertyMetadata8);
								num16 = 14;
								continue;
							case 25:
								propertyMetadata9 = source.FirstOrDefault(_003C_003Ec__DisplayClass9_4._003CGetMetadata_003Eb__3);
								num16 = 24;
								continue;
							case 26:
								_003C_003Ec__DisplayClass9_5 = new _003C_003Ec__DisplayClass9_4();
								num16 = 31;
								continue;
							case 13:
								enumerator3 = _003C_003Ec__DisplayClass9_5.includedProperty.PropertyParents.GetEnumerator();
								num16 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num16 = 1;
								}
								continue;
							case 27:
								AI0UVyLxlggDZZG3qd2(propertyMetadata8, Int32Descriptor.UID);
								num16 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num16 = 0;
								}
								continue;
							case 18:
								text4 = string.Empty;
								num17 = 13;
								goto IL_008f;
							case 11:
								hTNkrKL0lC24SPqI8x5(propertyMetadata8, d23bYXLMdPAlme5Viru(propertyMetadata9));
								num16 = 12;
								continue;
							default:
								hTNkrKL0lC24SPqI8x5(propertyMetadata8, new Int32Settings());
								num17 = 28;
								goto IL_008f;
							case 29:
								if (KAPY9bLlhSDfdZs87Gt(_003C_003Ec__DisplayClass9_4.aggregation) == AggregationType.Count)
								{
									num16 = 27;
									continue;
								}
								goto case 21;
							case 9:
							{
								PropertyMetadata propertyMetadata11 = new PropertyMetadata();
								nTWd7hL6nYRn78RFmD6(propertyMetadata11, oJxDA0LdwuZHQc6Mow3(propertyMetadata10));
								mN2SV9LmdOHVX2ju2Om(propertyMetadata11, GetAggregationName((string)rbs4B9L4BYm3530SLd2(fFxNmQLAEJlD88S2B9f(-1765851862 ^ -1765806086), text4), (string)zqlmiTLwLLi9Jl0hijy(propertyMetadata10), KAPY9bLlhSDfdZs87Gt(_003C_003Ec__DisplayClass9_4.aggregation)));
								AI0UVyLxlggDZZG3qd2(propertyMetadata11, propertyMetadata9.TypeUid);
								propertyMetadata11.SubTypeUid = mZhagXLtvOSNt22f2d4(propertyMetadata9);
								hTNkrKL0lC24SPqI8x5(propertyMetadata11, d23bYXLMdPAlme5Viru(propertyMetadata9));
								propertyMetadata8 = propertyMetadata11;
								num16 = 30;
								continue;
							}
							case 32:
								propertyMetadata8 = new PropertyMetadata
								{
									Uid = bBxgn6L9i0fQVvww6tM(_003C_003Ec__DisplayClass9_4.aggregation),
									Name = GetAggregationName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542741683), (string)zqlmiTLwLLi9Jl0hijy(propertyMetadata9), KAPY9bLlhSDfdZs87Gt(_003C_003Ec__DisplayClass9_4.aggregation))
								};
								num16 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
								{
									num16 = 29;
								}
								continue;
							case 3:
								goto end_IL_0438;
								IL_008f:
								num16 = num17;
								continue;
							}
							break;
						}
						continue;
						IL_04a3:
						_003C_003Ec__DisplayClass9_4 = new _003C_003Ec__DisplayClass9_3();
						num16 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num16 = 0;
						}
						goto IL_0093;
						continue;
						end_IL_0438:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator4).Dispose();
					int num20 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num20 = 0;
					}
					switch (num20)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			default:
				properties = classMetadata3.Properties;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 7;
				}
				continue;
			case 13:
				try
				{
					while (true)
					{
						int num10;
						if (!enumerator5.MoveNext())
						{
							num10 = 23;
							goto IL_0794;
						}
						goto IL_0a3f;
						IL_0794:
						while (true)
						{
							int num14;
							switch (num10)
							{
							case 9:
								propertyMetadata6 = source.FirstOrDefault(_003C_003Ec__DisplayClass9_3._003CGetMetadata_003Eb__2);
								num10 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num10 = 1;
								}
								continue;
							case 11:
								AI0UVyLxlggDZZG3qd2(propertyMetadata5, StringDescriptor.UID);
								num10 = 16;
								continue;
							case 22:
								enumerator2 = datePartTypes2.GetEnumerator();
								num14 = 4;
								goto IL_0790;
							case 16:
								hTNkrKL0lC24SPqI8x5(propertyMetadata5, new StringSettings());
								num10 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num10 = 17;
								}
								continue;
							case 6:
							case 15:
								break;
							case 13:
								if (propertyMetadata6 != null)
								{
									num10 = 8;
									continue;
								}
								break;
							default:
								propertyMetadata5.Name = GetName((string)fFxNmQLAEJlD88S2B9f(-2106517564 ^ -2106473210), (string)zqlmiTLwLLi9Jl0hijy(propertyMetadata6));
								num10 = 19;
								continue;
							case 12:
								vmCAHjLyntHQkpbGCnx(propertyMetadata5, mZhagXLtvOSNt22f2d4(propertyMetadata6));
								num14 = 7;
								goto IL_0790;
							case 14:
							case 19:
								classMetadata.Properties.Add(propertyMetadata5);
								num14 = 6;
								goto IL_0790;
							case 21:
								text3 = string.Empty;
								num10 = 13;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
								{
									num10 = 22;
								}
								continue;
							case 5:
								_003C_003Ec__DisplayClass9_3.grouping = enumerator5.Current;
								num10 = 20;
								continue;
							case 8:
							{
								PropertyMetadata propertyMetadata7 = new PropertyMetadata();
								nTWd7hL6nYRn78RFmD6(propertyMetadata7, bBxgn6L9i0fQVvww6tM(_003C_003Ec__DisplayClass9_3.grouping));
								propertyMetadata5 = propertyMetadata7;
								num10 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num10 = 1;
								}
								continue;
							}
							case 17:
								mN2SV9LmdOHVX2ju2Om(propertyMetadata5, GetName((string)rbs4B9L4BYm3530SLd2(fFxNmQLAEJlD88S2B9f(0x7E6E5A0B ^ 0x7E6E88C9), text3), propertyMetadata6.Name));
								num10 = 14;
								continue;
							case 3:
							case 10:
								AI0UVyLxlggDZZG3qd2(propertyMetadata5, propertyMetadata6.TypeUid);
								num10 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
								{
									num10 = 4;
								}
								continue;
							case 20:
								if (dqqX23LD9MKaMZVABlN(xNAYNyLJr08A25GN1KT(_003C_003Ec__DisplayClass9_3.grouping), Guid.Empty))
								{
									num10 = 15;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
									{
										num10 = 1;
									}
									continue;
								}
								goto case 9;
							case 2:
								goto IL_0a3f;
							case 18:
								if (AV031dLHIbW5OWVonix(datePartTypes2) >= 3)
								{
									num10 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num10 = 9;
									}
									continue;
								}
								goto case 21;
							case 7:
								hTNkrKL0lC24SPqI8x5(propertyMetadata5, d23bYXLMdPAlme5Viru(propertyMetadata6));
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
								{
									num10 = 0;
								}
								continue;
							case 4:
								try
								{
									while (true)
									{
										int num11;
										if (!enumerator2.MoveNext())
										{
											num11 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
											{
												num11 = 1;
											}
											goto IL_0ac7;
										}
										goto IL_0b3b;
										IL_0b3b:
										current2 = enumerator2.Current;
										num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
										{
											num11 = 0;
										}
										goto IL_0ac7;
										IL_0ac7:
										while (true)
										{
											switch (num11)
											{
											case 3:
												break;
											default:
											{
												text3 = (string)jjG8uRL7CViqg5tDhjc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234316526), text3, (DatePartType)current2);
												int num12 = 3;
												num11 = num12;
												continue;
											}
											case 2:
												goto IL_0b3b;
											case 1:
												goto end_IL_0ae1;
											}
											break;
										}
										continue;
										end_IL_0ae1:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num13 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
									{
										num13 = 0;
									}
									switch (num13)
									{
									case 0:
										break;
									}
								}
								goto case 11;
							case 1:
								datePartTypes2 = _003C_003Ec__DisplayClass9_3.grouping.DatePartTypes;
								num10 = 18;
								continue;
							case 23:
								goto end_IL_0881;
								IL_0790:
								num10 = num14;
								continue;
							}
							break;
						}
						continue;
						IL_0a3f:
						_003C_003Ec__DisplayClass9_3 = new _003C_003Ec__DisplayClass9_2();
						num10 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num10 = 1;
						}
						goto IL_0794;
						continue;
						end_IL_0881:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator5).Dispose();
					int num15 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num15 = 0;
					}
					switch (num15)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 18;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num3 = 0;
							}
							goto IL_0c2c;
						}
						goto IL_125e;
						IL_125e:
						_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
						num3 = 7;
						goto IL_0c2c;
						IL_0c2c:
						while (true)
						{
							int num8;
							switch (num3)
							{
							case 28:
								propertyMetadata2 = entityMetadata2.GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass9_._003CGetMetadata_003Eb__1);
								num3 = 27;
								continue;
							case 6:
								enumerator3 = _003C_003Ec__DisplayClass9_.includedProperty.PropertyParents.GetEnumerator();
								num3 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num3 = 11;
								}
								continue;
							case 4:
							case 21:
								classMetadata.Properties.Add(propertyMetadata);
								num3 = 9;
								continue;
							case 14:
								propertyMetadata.Settings = (TypeSettings)d23bYXLMdPAlme5Viru(propertyMetadata2);
								num3 = 21;
								continue;
							case 29:
								if (!dqqX23LD9MKaMZVABlN(_003C_003Ec__DisplayClass9_.includedProperty.OriginalPropertyUid, Guid.Empty))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 10:
								if (entityMetadata2 == null)
								{
									num3 = 3;
									continue;
								}
								goto case 28;
							case 11:
								text2 = string.Empty;
								num3 = 6;
								continue;
							case 20:
								try
								{
									while (true)
									{
										IL_0e21:
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 2;
											goto IL_0de4;
										}
										goto IL_0dfe;
										IL_0de4:
										while (true)
										{
											switch (num4)
											{
											case 3:
												break;
											default:
												goto IL_0e21;
											case 1:
												text = (string)jjG8uRL7CViqg5tDhjc(fFxNmQLAEJlD88S2B9f(0x571EA399 ^ 0x571EE19B), text, (DatePartType)current);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
												{
													num4 = 0;
												}
												continue;
											case 2:
												goto end_IL_0e21;
											}
											break;
										}
										goto IL_0dfe;
										IL_0dfe:
										current = enumerator2.Current;
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
										{
											num4 = 1;
										}
										goto IL_0de4;
										continue;
										end_IL_0e21:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								goto default;
							case 3:
							case 9:
							case 30:
								break;
							case 17:
								hTNkrKL0lC24SPqI8x5(propertyMetadata, new StringSettings());
								num8 = 26;
								goto IL_0c28;
							default:
								AI0UVyLxlggDZZG3qd2(propertyMetadata, StringDescriptor.UID);
								num3 = 17;
								continue;
							case 24:
								_ = string.Empty;
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num3 = 12;
								}
								continue;
							case 5:
							{
								PropertyMetadata propertyMetadata4 = new PropertyMetadata();
								nTWd7hL6nYRn78RFmD6(propertyMetadata4, propertyMetadata2.Uid);
								propertyMetadata = propertyMetadata4;
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
								{
									num3 = 25;
								}
								continue;
							}
							case 15:
								AI0UVyLxlggDZZG3qd2(propertyMetadata, propertyMetadata2.TypeUid);
								num8 = 13;
								goto IL_0c28;
							case 1:
								if ((entityMetadata2 = classMetadata3 as EntityMetadata) != null)
								{
									num3 = 11;
									continue;
								}
								break;
							case 19:
								try
								{
									while (true)
									{
										IL_1077:
										int num6;
										if (!enumerator3.MoveNext())
										{
											num6 = 9;
											goto IL_0fe6;
										}
										goto IL_108d;
										IL_0fe6:
										while (true)
										{
											switch (num6)
											{
											case 5:
												break;
											case 11:
												propertyMetadata3 = entityMetadata2.GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass9_2._003CGetMetadata_003Eb__0);
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
												{
													num6 = 3;
												}
												continue;
											case 4:
												goto IL_1077;
											case 8:
												goto IL_108d;
											case 7:
												entityMetadata2 = classMetadata2 as EntityMetadata;
												num6 = 12;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
												{
													num6 = 9;
												}
												continue;
											case 12:
												if (entityMetadata2 == null)
												{
													num6 = 2;
													continue;
												}
												goto IL_1077;
											case 1:
												_003C_003Ec__DisplayClass9_2.parentUid = enumerator3.Current;
												num6 = 11;
												continue;
											case 6:
											case 10:
												text2 = (string)rbs4B9L4BYm3530SLd2(text2, zqlmiTLwLLi9Jl0hijy(propertyMetadata3));
												num6 = 7;
												continue;
											case 2:
												break;
											case 3:
												classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(ModelHelper.GetEntityType(mZhagXLtvOSNt22f2d4(propertyMetadata3)));
												num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
												{
													num6 = 0;
												}
												continue;
											default:
												if (classMetadata2 == null)
												{
													break;
												}
												num6 = 6;
												continue;
											case 9:
												break;
											}
											break;
										}
										break;
										IL_108d:
										_003C_003Ec__DisplayClass9_2 = new _003C_003Ec__DisplayClass9_1();
										num6 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
										{
											num6 = 1;
										}
										goto IL_0fe6;
									}
								}
								finally
								{
									((IDisposable)enumerator3).Dispose();
									int num7 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
									{
										num7 = 0;
									}
									switch (num7)
									{
									case 0:
										break;
									}
								}
								goto case 10;
							case 26:
								mN2SV9LmdOHVX2ju2Om(propertyMetadata, GetName((string)fFxNmQLAEJlD88S2B9f(-345420348 ^ -345399456) + text2 + text, (string)zqlmiTLwLLi9Jl0hijy(propertyMetadata2)));
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num3 = 4;
								}
								continue;
							case 25:
								datePartTypes = _003C_003Ec__DisplayClass9_.includedProperty.DatePartTypes;
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num3 = 2;
								}
								continue;
							case 27:
								if (propertyMetadata2 == null)
								{
									num3 = 30;
									continue;
								}
								goto case 5;
							case 7:
								_003C_003Ec__DisplayClass9_.includedProperty = enumerator.Current;
								num3 = 29;
								continue;
							case 22:
								goto IL_125e;
							case 2:
								if (AV031dLHIbW5OWVonix(datePartTypes) >= 3)
								{
									num3 = 16;
									continue;
								}
								goto case 23;
							case 8:
							case 16:
								mN2SV9LmdOHVX2ju2Om(propertyMetadata, GetName((string)rbs4B9L4BYm3530SLd2(fFxNmQLAEJlD88S2B9f(-1426094279 ^ -1426106979), text2), (string)zqlmiTLwLLi9Jl0hijy(propertyMetadata2)));
								num3 = 15;
								continue;
							case 12:
								enumerator2 = datePartTypes.GetEnumerator();
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
								{
									num3 = 20;
								}
								continue;
							case 13:
								vmCAHjLyntHQkpbGCnx(propertyMetadata, propertyMetadata2.SubTypeUid);
								num3 = 14;
								continue;
							case 23:
								text = string.Empty;
								num3 = 24;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num3 = 17;
								}
								continue;
							case 18:
								goto end_IL_0ee9;
								IL_0c28:
								num3 = num8;
								continue;
							}
							break;
						}
						continue;
						end_IL_0ee9:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				goto case 9;
			case 12:
				return classMetadata;
			case 4:
				yH71x9LgMylxw7I3iC0(classMetadata);
				num2 = 12;
				continue;
			case 3:
				enumerator4 = userDefinedListInfo.AggregationProperties.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				enumerable = properties;
				break;
			case 14:
				entityMetadata = classMetadata3 as IEntityMetadata;
				num2 = 2;
				continue;
			case 11:
				classMetadata = new ClassMetadata();
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 5;
				}
				continue;
			case 7:
				enumerator = userDefinedListInfo.IncludedProperties.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				return classMetadata;
			case 10:
				if (!dqqX23LD9MKaMZVABlN(BjNmPJLaN7aqXj2y2am(userDefinedListInfo), Guid.Empty))
				{
					classMetadata3 = (ClassMetadata)MetadataLoader.LoadMetadata(ModelHelper.GetEntityType(BjNmPJLaN7aqXj2y2am(userDefinedListInfo)));
					num2 = 14;
				}
				else
				{
					num2 = 6;
				}
				continue;
			case 2:
				if (entityMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				enumerable = entityMetadata.GetPropertiesAndTableParts();
				break;
			}
			source = enumerable;
			num2 = 7;
		}
	}

	private string GetName(string prefix, string propertyName)
	{
		return (string)pxvgXUL5B3r9gWbx0b1(prefix, fFxNmQLAEJlD88S2B9f(0x2ACE37D ^ 0x2ACF9B9), propertyName);
	}

	private string GetAggregationName(string prefix, string propertyName, AggregationType aggregationType)
	{
		int num = 1;
		int num2 = num;
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				name = GetName(prefix, propertyName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return string.Format((string)fFxNmQLAEJlD88S2B9f(0x3630F361 ^ 0x3630218B), name, aggregationType);
			}
		}
	}

	private IEnumerable<object> GetEntities(UserDefinedListInfo preparationDataInfo)
	{
		if (preparationDataInfo.SubTypeUid == Guid.Empty)
		{
			return Enumerable.Empty<object>();
		}
		Type entityType = ModelHelper.GetEntityType(preparationDataInfo.SubTypeUid);
		IEntityManager entityManager = ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(entityType));
		if (entityManager == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F5B44C), entityType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751177278));
		}
		IEntityFilter entityFilter = (IEntityFilter)InterfaceActivator.Create(ModelHelper.GetEntityFilterType(entityType));
		entityFilter.Query = preparationDataInfo.ComputedEqlQuery;
		string alias = null;
		if (entityManager is IEntityManagerAlias entityManagerAlias)
		{
			alias = entityManagerAlias.GetDefaultCriteriaAlias();
		}
		ICriteria val = CreateCriteria(FetchOptions.All, entityType, alias, entityFilter);
		entityManager.SetupFilter(val, entityFilter);
		ProjectionList val2 = Projections.ProjectionList();
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(entityType);
		IEnumerable<IPropertyMetadata> enumerable;
		if (!(classMetadata is IEntityMetadata entityMetadata))
		{
			IEnumerable<IPropertyMetadata> properties = classMetadata.Properties;
			enumerable = properties;
		}
		else
		{
			enumerable = entityMetadata.GetPropertiesAndTableParts();
		}
		IEnumerable<IPropertyMetadata> source = enumerable;
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		using (List<IncludedProperty>.Enumerator enumerator = preparationDataInfo.IncludedProperties.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
				CS_0024_003C_003E8__locals0.includedProperty = enumerator.Current;
				if (CS_0024_003C_003E8__locals0.includedProperty.OriginalPropertyUid == Guid.Empty || !(classMetadata is EntityMetadata entityMetadata2))
				{
					continue;
				}
				Type type = entityType;
				string text = string.Empty;
				string defaultAlias = null;
				if (entityManager is IEntityManagerAlias entityManagerAlias2)
				{
					defaultAlias = entityManagerAlias2.GetDefaultCriteriaAlias();
				}
				using (List<Guid>.Enumerator enumerator2 = CS_0024_003C_003E8__locals0.includedProperty.PropertyParents.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass13_1();
						CS_0024_003C_003E8__locals1.parentUid = enumerator2.Current;
						ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(type));
						IPropertyMetadata propertyMetadata = entityMetadata2.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata prop) => _003C_003Ec__DisplayClass13_1.nfbDsUfL1eIki3Qw0Q4i(prop) == CS_0024_003C_003E8__locals1.parentUid);
						string text2 = CreateAlias(defaultAlias, propertyMetadata.Name);
						string alias2 = propertyMetadata.Name;
						val.GetOrCreateAlias(text2, text2, (JoinType)1, ref alias2);
						defaultAlias = propertyMetadata.Name;
						Type entityType2 = ModelHelper.GetEntityType(propertyMetadata.SubTypeUid);
						ClassMetadata classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(entityType2);
						if (classMetadata2 == null)
						{
							break;
						}
						text += propertyMetadata.Name;
						type = entityType2;
						entityMetadata2 = classMetadata2 as EntityMetadata;
						if (entityMetadata2 == null)
						{
							break;
						}
					}
				}
				if (entityMetadata2 == null)
				{
					continue;
				}
				IPropertyMetadata propertyMetadata2 = entityMetadata2.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata prop) => _003C_003Ec__DisplayClass13_0.wUaY8cfLnKJuARPhtvY2(prop) == _003C_003Ec__DisplayClass13_0.Pb2OG8fLOkd7q2wnhw30(CS_0024_003C_003E8__locals0.includedProperty));
				string text3 = CreateAlias(defaultAlias, propertyMetadata2.Name);
				List<int> datePartTypes = CS_0024_003C_003E8__locals0.includedProperty.DatePartTypes;
				if (propertyMetadata2.Settings is DateTimeSettings && datePartTypes.Count < 3)
				{
					List<string> list = new List<string>();
					string text4 = string.Empty;
					foreach (int item in datePartTypes)
					{
						string text5 = ((DatePartType)item).ToString();
						string name = GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3279170) + text + text5, propertyMetadata2.Name);
						val2.Add((IProjection)(object)Projections.GroupProperty(Projections.SqlFunction(text5, (IType)(object)NHibernateUtil.Date, (IProjection[])(object)new IProjection[1] { (IProjection)Projections.GroupProperty(text3) })), name);
						text4 = text4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886644405) + text5;
						list.Add(name);
					}
					string name2 = GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380474F) + text + text4, propertyMetadata2.Name);
					dictionary.Add(name2, list);
				}
				else
				{
					val2.Add(((SimpleProjection)Projections.GroupProperty(text3)).As(GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488861329) + text, propertyMetadata2.Name)));
				}
			}
		}
		using (List<GroupingProperty>.Enumerator enumerator4 = preparationDataInfo.GroupingProperties.GetEnumerator())
		{
			while (enumerator4.MoveNext())
			{
				_003C_003Ec__DisplayClass13_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass13_2();
				CS_0024_003C_003E8__locals2.grouping = enumerator4.Current;
				if (CS_0024_003C_003E8__locals2.grouping.OriginalPropertyUid == Guid.Empty)
				{
					continue;
				}
				IPropertyMetadata propertyMetadata3 = source.FirstOrDefault((IPropertyMetadata p) => _003C_003Ec__DisplayClass13_2.Ixl9bnfLwLpQfg3pWc27(_003C_003Ec__DisplayClass13_2.tdZTBsfLDQgiZ8fCELX7(p), _003C_003Ec__DisplayClass13_2.nhjgWtfLtm34ce4hurcg(CS_0024_003C_003E8__locals2.grouping)));
				if (propertyMetadata3 == null)
				{
					continue;
				}
				string defaultAlias2 = null;
				if (entityManager is IEntityManagerAlias entityManagerAlias3)
				{
					defaultAlias2 = entityManagerAlias3.GetDefaultCriteriaAlias();
				}
				string text6 = CreateAlias(defaultAlias2, propertyMetadata3.Name);
				List<int> datePartTypes2 = CS_0024_003C_003E8__locals2.grouping.DatePartTypes;
				if (propertyMetadata3.Settings is DateTimeSettings && datePartTypes2.Count < 3)
				{
					List<string> list2 = new List<string>();
					string text7 = string.Empty;
					foreach (int item2 in datePartTypes2)
					{
						string text8 = ((DatePartType)item2).ToString();
						string name3 = GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x34188C97) + text8, propertyMetadata3.Name);
						val2.Add((IProjection)(object)Projections.GroupProperty(Projections.SqlFunction(text8, (IType)(object)NHibernateUtil.Date, (IProjection[])(object)new IProjection[1] { (IProjection)Projections.GroupProperty(text6) })), name3);
						text7 = text7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426428C7) + text8;
						list2.Add(name3);
					}
					string name4 = GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633526121) + text7, propertyMetadata3.Name);
					dictionary.Add(name4, list2);
				}
				else
				{
					val2.Add(((SimpleProjection)Projections.GroupProperty(text6)).As(GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1B6CD), propertyMetadata3.Name)));
				}
			}
		}
		using (List<AggregationProperty>.Enumerator enumerator5 = preparationDataInfo.AggregationProperties.GetEnumerator())
		{
			while (enumerator5.MoveNext())
			{
				_003C_003Ec__DisplayClass13_3 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass13_3();
				CS_0024_003C_003E8__locals3.aggregation = enumerator5.Current;
				if (CS_0024_003C_003E8__locals3.aggregation.OriginalPropertyUid == Guid.Empty)
				{
					continue;
				}
				string text9 = string.Empty;
				IPropertyMetadata propertyMetadata4 = source.FirstOrDefault((IPropertyMetadata p) => _003C_003Ec__DisplayClass13_3.TKS7SKfL74rNd3XsdwI1(_003C_003Ec__DisplayClass13_3.R0K3xHfLAB0ukhIC6IR5(p), CS_0024_003C_003E8__locals3.aggregation.OriginalPropertyUid));
				string text10 = string.Empty;
				string text11 = string.Empty;
				if (propertyMetadata4 == null)
				{
					_003C_003Ec__DisplayClass13_4 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass13_4();
					CS_0024_003C_003E8__locals4.includedProperty = preparationDataInfo.IncludedProperties.FirstOrDefault((IncludedProperty ip) => _003C_003Ec__DisplayClass13_3.TKS7SKfL74rNd3XsdwI1(_003C_003Ec__DisplayClass13_3.OyVflifLxJDtIC1Fl30L(ip), _003C_003Ec__DisplayClass13_3.OyVflifLxJDtIC1Fl30L(CS_0024_003C_003E8__locals3.aggregation)));
					if (CS_0024_003C_003E8__locals4.includedProperty == null)
					{
						continue;
					}
					if (classMetadata is EntityMetadata entityMetadata3)
					{
						Type type2 = entityType;
						text9 = null;
						if (entityManager is IEntityManagerAlias entityManagerAlias4)
						{
							text9 = entityManagerAlias4.GetDefaultCriteriaAlias();
						}
						using (List<Guid>.Enumerator enumerator2 = CS_0024_003C_003E8__locals4.includedProperty.PropertyParents.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								_003C_003Ec__DisplayClass13_5 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass13_5();
								CS_0024_003C_003E8__locals5.parentUid = enumerator2.Current;
								ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(type2));
								IPropertyMetadata propertyMetadata5 = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata prop) => _003C_003Ec__DisplayClass13_5.Tl2R7QfLYRU8K4embk0O(_003C_003Ec__DisplayClass13_5.jXq6DAfLj6j08VtIFnhW(prop), CS_0024_003C_003E8__locals5.parentUid));
								text9 = propertyMetadata5.Name;
								Type entityType3 = ModelHelper.GetEntityType(propertyMetadata5.SubTypeUid);
								ClassMetadata classMetadata3 = (ClassMetadata)MetadataLoader.LoadMetadata(entityType3);
								if (classMetadata3 == null)
								{
									break;
								}
								text11 += propertyMetadata5.Name;
								type2 = entityType3;
								entityMetadata3 = classMetadata3 as EntityMetadata;
								if (entityMetadata3 == null)
								{
									break;
								}
							}
						}
						if (entityMetadata3 != null)
						{
							text10 = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata prop) => _003C_003Ec__DisplayClass13_4.vvV5UefLdGdMd4KlBy06(_003C_003Ec__DisplayClass13_4.eqaAatfLJQHwQCwKsiQT(prop), _003C_003Ec__DisplayClass13_4.HPE6aHfL9y8YHhIBb0pj(CS_0024_003C_003E8__locals4.includedProperty))).Name;
							text9 = CreateAlias(text9, text10);
						}
					}
				}
				else
				{
					string defaultAlias3 = null;
					if (entityManager is IEntityManagerAlias entityManagerAlias5)
					{
						text9 = entityManagerAlias5.GetDefaultCriteriaAlias();
					}
					text9 = CreateAlias(defaultAlias3, propertyMetadata4.Name);
					text10 = propertyMetadata4.Name;
				}
				if (!string.IsNullOrEmpty(text9))
				{
					string aggregationName = GetAggregationName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521220464) + text11, text10, CS_0024_003C_003E8__locals3.aggregation.AggregationType);
					switch (CS_0024_003C_003E8__locals3.aggregation.AggregationType)
					{
					case AggregationType.Avg:
						val2.Add(((SimpleProjection)Projections.Avg(text9)).As(aggregationName));
						break;
					case AggregationType.Max:
						val2.Add(((SimpleProjection)Projections.Max(text9)).As(aggregationName));
						break;
					case AggregationType.Min:
						val2.Add(((SimpleProjection)Projections.Min(text9)).As(aggregationName));
						break;
					case AggregationType.Sum:
						val2.Add(((SimpleProjection)Projections.Sum(text9)).As(aggregationName));
						break;
					case AggregationType.Count:
						val2.Add(((SimpleProjection)Projections.Count(text9)).As(aggregationName));
						break;
					}
				}
			}
		}
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)val2 });
		val.SetResultTransformer((IResultTransformer)(object)new DictionaryResultTransformer());
		List<object> list3 = val.List().CastToListOrNull<object>().ToList();
		if (dictionary.Any())
		{
			MergeDates(list3, dictionary);
		}
		return list3;
	}

	private void MergeDates(List<object> entities, Dictionary<string, List<string>> dateTimeGroups)
	{
		foreach (object entity in entities)
		{
			foreach (KeyValuePair<string, List<string>> dateTimeGroup in dateTimeGroups)
			{
				UDLDynamicObject uDLDynamicObject = entity as UDLDynamicObject;
				string text = string.Empty;
				foreach (string item in dateTimeGroup.Value)
				{
					object obj = uDLDynamicObject.TryGetValue(item);
					if (obj != null)
					{
						bool flag = item.Contains(DatePartType.Day.ToString()) || item.Contains(DatePartType.Month.ToString());
						string text2 = ((int)obj).ToString(flag ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998560074) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638455915));
						text = (string.IsNullOrEmpty(text) ? text2 : (text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6C8F4) + text2));
						uDLDynamicObject.RemoveValue(item);
					}
				}
				uDLDynamicObject.AddMember(dateTimeGroup.Key, text);
			}
		}
	}

	protected internal ICriteria CreateCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		//Discarded unreachable code: IL_0112, IL_0121, IL_0132, IL_0141, IL_014c, IL_01dc, IL_0214
		int num = 5;
		ICriteria val = default(ICriteria);
		Type type2 = default(Type);
		IEnumerator<IEntityManagerBehavior> enumerator = default(IEnumerator<IEntityManagerBehavior>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (val != null)
					{
						num2 = 10;
						break;
					}
					goto case 6;
				case 5:
					type2 = type;
					num2 = 4;
					break;
				default:
					if (NkSowmLUs3bQXCy2AQg(fetchOptions, null))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 10:
					zXyAYoLLDTV1UC4olDk(val, CriteriaSpecification.DistinctRootEntity);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					enumerator = behaviors.Value.GetEnumerator();
					num2 = 8;
					break;
				case 4:
					if (sessionProvider == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 9;
						}
						break;
					}
					goto case 7;
				case 3:
					UIdL1ZLsSCP9f2gU3m9(this, val, fetchOptions, type2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num3 = 0;
								}
								goto IL_0150;
							}
							goto IL_0166;
							IL_0166:
							hSA28YLcKM0J3SIpC8x(enumerator.Current, val, filter);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 1;
							}
							goto IL_0150;
							IL_0150:
							switch (num3)
							{
							case 2:
								break;
							case 1:
								continue;
							default:
								return val;
							case 0:
								return val;
							}
							goto IL_0166;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									R1ZOGxLzc1yw3j52X0q(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 7:
					val = (ICriteria)U19i0ALYe6RU9kUlf7k(yjsMMuLjVaLURsqmgkg(sessionProvider, ""), type2, alias);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					return val;
				case 9:
					return null;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected virtual void SetupFetchOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		//Discarded unreachable code: IL_0150, IL_01cc, IL_01db, IL_0205
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		int num = 12;
		List<string> list3 = default(List<string>);
		List<string> list2 = default(List<string>);
		EntityMetadata metadata = default(EntityMetadata);
		SelectMode selectMode = default(SelectMode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				List<string> list;
				switch (num2)
				{
				case 13:
					criteria = (ICriteria)x5BNDVUWvPHqFhn1vkZ(criteria, fetchOptions.MaxResults);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 15;
					}
					continue;
				case 15:
					SetupSortOptions(criteria, fetchOptions, entityType);
					num2 = 3;
					continue;
				case 4:
					if (FetchOptionsBuilder.IsCanOptimaze(criteria, list3.Union(list2).ToList(), metadata))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 8:
					FetchOptionsBuilder.ResolveFetchColumns(criteria, list3.ToList(), selectMode, usingAlias: true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (!fetchOptions.UseProjections)
					{
						num2 = 16;
						continue;
					}
					goto case 9;
				case 11:
					if (fsOsgRUBSrXMlxvMn6l(fetchOptions) > 0)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 15;
				case 9:
					if (fetchOptions.UsePartialFetching)
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 6:
				case 16:
					num3 = 1;
					break;
				default:
					FetchOptionsBuilder.ResolveFetchColumns(criteria, list2.ToList(), (SelectMode)1);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 9;
					}
					continue;
				case 3:
					list3 = new List<string>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					criteria = (ICriteria)eLM408UFJ1oxuPIAYuM(criteria, fetchOptions.FirstResult);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 11;
					}
					continue;
				case 14:
					metadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
					num2 = 4;
					continue;
				case 10:
					return;
				case 1:
					list = fetchOptions.FetchRelations;
					if (list == null)
					{
						goto end_IL_0012;
					}
					goto IL_0234;
				case 5:
					list = new List<string>();
					goto IL_0234;
				case 7:
					{
						num3 = 6;
						break;
					}
					IL_0234:
					list2 = list;
					num2 = 14;
					continue;
				}
				selectMode = (SelectMode)num3;
				num2 = 8;
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	protected void SetupSortOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		//Discarded unreachable code: IL_00c1, IL_00d0, IL_0111, IL_0120, IL_012f, IL_01b4, IL_0203, IL_0222, IL_027d
		int num = 10;
		int num2 = num;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return;
			case 14:
				if (J0fgt0UbjV0Nh8KaQmR(_003C_003Ec__DisplayClass17_.metadata) != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 5;
			case 10:
				_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 3;
				}
				continue;
			case 13:
				if (_003C_003Ec__DisplayClass17_.metadata == null)
				{
					num2 = 17;
					continue;
				}
				goto case 6;
			case 6:
				if (!_003C_003Ec__DisplayClass17_.metadata.Hierarchical)
				{
					num2 = 11;
					continue;
				}
				goto case 14;
			case 20:
				return;
			case 8:
				if (!kPNc6CUQCCyTstv1eFf(DWkxc4UfLlLPV5DjDrK(fetchOptions), propertyMetadata.Name))
				{
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 19;
					}
					continue;
				}
				goto case 16;
			case 19:
				if (!d9bZJhUE2g2pNC7Qs5v(fetchOptions, null))
				{
					num2 = 8;
					continue;
				}
				goto case 2;
			case 15:
				_003C_003Ec__DisplayClass17_.metadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 4;
				}
				continue;
			case 7:
				if (propertyMetadata == null)
				{
					num2 = 18;
					continue;
				}
				goto case 19;
			case 0:
				return;
			case 18:
				return;
			case 2:
				HhswRwU8yKxdCeHTkRr(criteria, AVP8fYUvuHrjMPlf1sm(SHWcK7UClGcKgX0QrNS(propertyMetadata)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
			case 3:
			case 11:
			case 17:
				obj = null;
				break;
			case 16:
				if (fetchOptions.DisableDefaultGroupSorting)
				{
					return;
				}
				num2 = 2;
				continue;
			case 5:
				if (VE5sLyUGx5TZeVuhBoD(cX3TeoUh66SB6VSiUNh(_003C_003Ec__DisplayClass17_.metadata), Guid.Empty))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 1;
			case 4:
				MetadataLoader.GetChildProperties(_003C_003Ec__DisplayClass17_.metadata);
				num2 = 13;
				continue;
			case 9:
				uJWcFOUoCEdh4LfeNyt(entityType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889505324));
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 12;
				}
				continue;
			case 12:
				obj = _003C_003Ec__DisplayClass17_.metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CSetupSortOptions_003Eb__0);
				break;
			}
			propertyMetadata = (PropertyMetadata)obj;
			num2 = 7;
		}
	}

	private string CreateAlias(string defaultAlias, string property)
	{
		//Discarded unreachable code: IL_0072, IL_0081
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)jjG8uRL7CViqg5tDhjc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583761162), defaultAlias, property);
			case 1:
				return property;
			case 2:
				if (GlSSBOUZJ4EUa9F3ld6(defaultAlias))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static void POVZIPLNrdF5mD4OGJI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type A1DnkJL31cuZUAeXSts(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object mHqXrBLpHigmZ7RuxCs(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static bool ybtgBSLPhGxlg2x7Jiu()
	{
		return gT23erLe4xq53Drsw4N == null;
	}

	internal static UserDefinedListService cRx3tgL14iWhRvS313b()
	{
		return gT23erLe4xq53Drsw4N;
	}

	internal static Guid BjNmPJLaN7aqXj2y2am(object P_0)
	{
		return ((UserDefinedListInfo)P_0).SubTypeUid;
	}

	internal static bool dqqX23LD9MKaMZVABlN(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid mZhagXLtvOSNt22f2d4(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static object zqlmiTLwLLi9Jl0hijy(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object rbs4B9L4BYm3530SLd2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void nTWd7hL6nYRn78RFmD6(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static int AV031dLHIbW5OWVonix(object P_0)
	{
		return ((List<int>)P_0).Count;
	}

	internal static object fFxNmQLAEJlD88S2B9f(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object jjG8uRL7CViqg5tDhjc(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void AI0UVyLxlggDZZG3qd2(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).TypeUid = value;
	}

	internal static void hTNkrKL0lC24SPqI8x5(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).Settings = (TypeSettings)P_1;
	}

	internal static void mN2SV9LmdOHVX2ju2Om(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void vmCAHjLyntHQkpbGCnx(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}

	internal static object d23bYXLMdPAlme5Viru(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static Guid xNAYNyLJr08A25GN1KT(object P_0)
	{
		return ((UserDefinedListPropertyBase)P_0).OriginalPropertyUid;
	}

	internal static Guid bBxgn6L9i0fQVvww6tM(object P_0)
	{
		return ((UserDefinedListPropertyBase)P_0).Uid;
	}

	internal static Guid oJxDA0LdwuZHQc6Mow3(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static AggregationType KAPY9bLlhSDfdZs87Gt(object P_0)
	{
		return ((AggregationProperty)P_0).AggregationType;
	}

	internal static Guid WG5jVyLri4qaFgx39xi(object P_0)
	{
		return ((IPropertyMetadata)P_0).TypeUid;
	}

	internal static void yH71x9LgMylxw7I3iC0(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static object pxvgXUL5B3r9gWbx0b1(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object yjsMMuLjVaLURsqmgkg(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object U19i0ALYe6RU9kUlf7k(object P_0, Type P_1, object P_2)
	{
		return ((ISession)P_0).CreateCriteria(P_1, (string)P_2);
	}

	internal static object zXyAYoLLDTV1UC4olDk(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static bool NkSowmLUs3bQXCy2AQg(object P_0, object P_1)
	{
		return (FetchOptions)P_0 != (FetchOptions)P_1;
	}

	internal static void UIdL1ZLsSCP9f2gU3m9(object P_0, object P_1, object P_2, Type entityType)
	{
		((UserDefinedListService)P_0).SetupFetchOptions((ICriteria)P_1, (FetchOptions)P_2, entityType);
	}

	internal static void hSA28YLcKM0J3SIpC8x(object P_0, object P_1, object P_2)
	{
		((IEntityManagerBehavior)P_0).OnCreateCriteria((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static void R1ZOGxLzc1yw3j52X0q(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object eLM408UFJ1oxuPIAYuM(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetFirstResult(P_1);
	}

	internal static int fsOsgRUBSrXMlxvMn6l(object P_0)
	{
		return ((FetchOptions)P_0).MaxResults;
	}

	internal static object x5BNDVUWvPHqFhn1vkZ(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static void uJWcFOUoCEdh4LfeNyt(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static HierarchyType J0fgt0UbjV0Nh8KaQmR(object P_0)
	{
		return ((EntityMetadata)P_0).HierarchyType;
	}

	internal static Guid cX3TeoUh66SB6VSiUNh(object P_0)
	{
		return ((EntityMetadata)P_0).IsGroupPropertyUid;
	}

	internal static bool VE5sLyUGx5TZeVuhBoD(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool d9bZJhUE2g2pNC7Qs5v(object P_0, object P_1)
	{
		return (FetchOptions)P_0 == (FetchOptions)P_1;
	}

	internal static object DWkxc4UfLlLPV5DjDrK(object P_0)
	{
		return ((FetchOptions)P_0).SortExpression;
	}

	internal static bool kPNc6CUQCCyTstv1eFf(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object SHWcK7UClGcKgX0QrNS(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object AVP8fYUvuHrjMPlf1sm(object P_0)
	{
		return Order.Desc((string)P_0);
	}

	internal static object HhswRwU8yKxdCeHTkRr(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static bool GlSSBOUZJ4EUa9F3ld6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
