using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class EntityPropertyDescriptor : FullTextPropertyDescriptor
{
	protected const string IndexFieldIdPostfix = "_index";

	private static EntityPropertyDescriptor gvpkU5GvyJPlvp9pFBco;

	public EntityPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (reindex)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return GetIndexField(obj, propMd);
			default:
				return GetReIndexField(obj, propMd);
			}
		}
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0051, IL_007d, IL_0128, IL_0137, IL_01b2, IL_029d, IL_02ac, IL_02cf, IL_02f2, IL_0301, IL_033f, IL_034e, IL_0379, IL_03b1, IL_03c0, IL_03d0, IL_03df, IL_050c, IL_051b
		int num = 7;
		IEntity entity = default(IEntity);
		IEnumerable enumerable = default(IEnumerable);
		FieldIndexList result = default(FieldIndexList);
		IEnumerator enumerator = default(IEnumerator);
		object obj2 = default(object);
		long result2 = default(long);
		IEntity entity2 = default(IEntity);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (propMd == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 8:
					return new FieldIndexList
					{
						new FieldIndexListItem((string)E3AC8fGvUxmX09tJS8Jv(zIWGDHGvYJY5OEb69nhF(UIwJZHGvj6Lhw5mb5cul(propMd).ToString()), L0D824GvLLhC1EYksCmT(0x1637C429 ^ 0x16340F3B)), Convert.ToInt64(D0X3i9GvrLxu7tmfMaUR(entity)), FullTextFieldType.Long)
					};
				case 5:
					return null;
				case 2:
					if (!x8Oel6Gvlq4kMHcCaHsg(entity))
					{
						num2 = 8;
						continue;
					}
					goto case 5;
				case 10:
					if (entity == null)
					{
						num2 = 5;
						continue;
					}
					goto case 2;
				case 1:
					if (obj != null)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 11:
					if (enumerable != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 4:
					entity = obj as IEntity;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 10;
					}
					continue;
				case 3:
				case 6:
					return new FieldIndexList();
				case 9:
					enumerable = obj as IEnumerable;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				try
				{
					List<long> list = new List<long>();
					int num3 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result = new FieldIndexList
							{
								new FieldIndexListItem((string)E3AC8fGvUxmX09tJS8Jv(zIWGDHGvYJY5OEb69nhF(UIwJZHGvj6Lhw5mb5cul(propMd).ToString()), L0D824GvLLhC1EYksCmT(-561074844 ^ -561158538)), list, FullTextFieldType.Long)
							};
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							enumerator = (IEnumerator)spkAtDGv9ZhmK4ikUa00(enumerable);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
							{
								num3 = 2;
							}
							break;
						case 2:
							try
							{
								while (true)
								{
									int num4;
									if (!dhDiHNGv5OFS64bhVJfT(enumerator))
									{
										num4 = 3;
										goto IL_0146;
									}
									goto IL_0241;
									IL_0146:
									while (true)
									{
										switch (num4)
										{
										case 1:
											if (!long.TryParse(obj2.ToString(), out result2))
											{
												num4 = 4;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
												{
													num4 = 9;
												}
												continue;
											}
											goto case 11;
										case 6:
										case 8:
										case 9:
											break;
										case 5:
										{
											list.Add(OnUYqHGvg6ZOoctmKbHm(D0X3i9GvrLxu7tmfMaUR(entity2)));
											int num5 = 6;
											num4 = num5;
											continue;
										}
										case 11:
											list.Add(result2);
											num4 = 8;
											continue;
										case 4:
											if (entity2 == null)
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
												{
													num4 = 2;
												}
												continue;
											}
											goto default;
										default:
											if (!x8Oel6Gvlq4kMHcCaHsg(entity2))
											{
												num4 = 5;
												continue;
											}
											break;
										case 10:
											goto IL_0241;
										case 2:
											if (obj2 != null)
											{
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
												{
													num4 = 1;
												}
												continue;
											}
											break;
										case 7:
											entity2 = obj2 as IEntity;
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
											{
												num4 = 4;
											}
											continue;
										case 3:
											goto end_IL_01c0;
										}
										break;
									}
									continue;
									IL_0241:
									obj2 = mOwB0CGvd6PmqRwWBc85(enumerator);
									num4 = 7;
									goto IL_0146;
									continue;
									end_IL_01c0:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								int num6 = 3;
								while (true)
								{
									switch (num6)
									{
									default:
										goto end_IL_02d3;
									case 0:
										goto end_IL_02d3;
									case 3:
										if (disposable == null)
										{
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
											{
												num6 = 0;
											}
											continue;
										}
										break;
									case 1:
										break;
									case 2:
										goto end_IL_02d3;
									}
									disposable.Dispose();
									num6 = 2;
									continue;
									end_IL_02d3:
									break;
								}
							}
							goto case 1;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				catch (Exception)
				{
					int num7 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							result = null;
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
							{
								num7 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_0071, IL_01c5, IL_01d4, IL_01e3, IL_01f3, IL_0202, IL_0213, IL_0222, IL_0278, IL_0287, IL_0300, IL_030f, IL_031e, IL_03ca, IL_040a, IL_0419, IL_0425, IL_0480
		int num = 1;
		int num2 = num;
		IList<object> list2 = default(IList<object>);
		List<long> list = default(List<long>);
		long result = default(long);
		Type type = default(Type);
		IEnumerator<object> enumerator = default(IEnumerator<object>);
		object current = default(object);
		long? idValueForEntity = default(long?);
		long result2 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 13:
				if (!list2.Any())
				{
					num2 = 3;
					break;
				}
				goto case 10;
			case 2:
				return new FieldIndexList
				{
					new FieldIndexListItem((string)E3AC8fGvUxmX09tJS8Jv(zIWGDHGvYJY5OEb69nhF(propMd.Uid.ToString()), L0D824GvLLhC1EYksCmT(0x8317432 ^ 0x832BF20)), list, FullTextFieldType.Long)
				};
			case 3:
				return new FieldIndexList
				{
					new FieldIndexListItem((string)zIWGDHGvYJY5OEb69nhF(UIwJZHGvj6Lhw5mb5cul(propMd).ToString()) + (string)L0D824GvLLhC1EYksCmT(-541731959 ^ -541714277), null, FullTextFieldType.Long)
				};
			case 11:
				if (long.TryParse(obj.ToString(), out result))
				{
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 9;
			case 8:
			case 14:
				list2 = (obj as IEnumerable).CastToListOrNull<object>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 6;
				}
				break;
			case 12:
				type = obj.GetType();
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 14;
				}
				break;
			case 18:
				enumerator = list2.Distinct().GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!dhDiHNGv5OFS64bhVJfT(enumerator))
						{
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
							{
								num3 = 7;
							}
							goto IL_0231;
						}
						goto IL_0340;
						IL_0340:
						current = enumerator.Current;
						num3 = 5;
						goto IL_0231;
						IL_0231:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 9:
							case 10:
							case 11:
							case 12:
								break;
							case 8:
								if (!idValueForEntity.HasValue)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 4;
							case 6:
								if (!long.TryParse(current.ToString(), out result2))
								{
									num3 = 9;
									continue;
								}
								goto case 3;
							case 4:
								list.Add(idValueForEntity.Value);
								num3 = 11;
								continue;
							default:
								goto IL_0340;
							case 2:
								idValueForEntity = GetIdValueForEntity(current);
								num3 = 8;
								continue;
							case 3:
							{
								list.Add(result2);
								int num4 = 12;
								num3 = num4;
								continue;
							}
							case 5:
								if (current is IEntity)
								{
									num3 = 2;
									continue;
								}
								goto case 7;
							case 7:
								if (current == null)
								{
									num3 = 10;
									continue;
								}
								goto case 6;
							case 13:
								goto end_IL_0292;
							}
							break;
						}
						continue;
						end_IL_0292:
						break;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num5 = 0;
						}
						goto IL_03ce;
					}
					goto IL_03e4;
					IL_03e4:
					enumerator.Dispose();
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num5 = 2;
					}
					goto IL_03ce;
					IL_03ce:
					switch (num5)
					{
					default:
						goto end_IL_03a9;
					case 1:
						break;
					case 0:
						goto end_IL_03a9;
					case 2:
						goto end_IL_03a9;
					}
					goto IL_03e4;
					end_IL_03a9:;
				}
				goto case 16;
			case 10:
				list = new List<long>();
				num2 = 18;
				break;
			case 7:
				if (ikAgumGvcRsW6C6Ufyyb(type.GetGenericTypeDefinition(), kSqPCgGvsjvfQ5kFXyBh(typeof(List<>).TypeHandle)))
				{
					num2 = 14;
					break;
				}
				goto case 11;
			case 19:
				return new FieldIndexList();
			default:
				if (obj != null)
				{
					num2 = 12;
					break;
				}
				return new FieldIndexList
				{
					new FieldIndexListItem((string)E3AC8fGvUxmX09tJS8Jv(zIWGDHGvYJY5OEb69nhF(propMd.Uid.ToString()), L0D824GvLLhC1EYksCmT(-488881205 ^ -488666919)), null, FullTextFieldType.Long)
				};
			case 1:
				if (propMd != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 19;
			case 16:
				if (!list.Any())
				{
					return new FieldIndexList();
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				if (list2 != null)
				{
					num2 = 13;
					break;
				}
				goto case 3;
			case 4:
				if (ikAgumGvcRsW6C6Ufyyb(type.GetGenericTypeDefinition(), kSqPCgGvsjvfQ5kFXyBh(typeof(SerializableList<>).TypeHandle)))
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 17:
				if (!type.IsGenericType)
				{
					num2 = 11;
					break;
				}
				goto case 4;
			case 9:
				return new FieldIndexList();
			case 15:
				return new FieldIndexList
				{
					new FieldIndexListItem((string)E3AC8fGvUxmX09tJS8Jv(zIWGDHGvYJY5OEb69nhF(UIwJZHGvj6Lhw5mb5cul(propMd).ToString()), L0D824GvLLhC1EYksCmT(-1870892489 ^ -1870677723)), result, FullTextFieldType.Long)
				};
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_00b6, IL_00ed, IL_0127, IL_0161, IL_02f0, IL_0320, IL_032f, IL_03a4, IL_03f1, IL_0401, IL_0410, IL_041b, IL_04bc, IL_0504, IL_053e, IL_0551
		int num = 9;
		int num2 = num;
		IEntityFilter entityFilter = default(IEntityFilter);
		Guid guid = default(Guid);
		ListInfo listInfo = default(ListInfo);
		List<object> list = default(List<object>);
		PropertyInfo propertyCached = default(PropertyInfo);
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		EntityWrapper entityWrapper2 = default(EntityWrapper);
		EntityWrapper entityWrapper = default(EntityWrapper);
		while (true)
		{
			switch (num2)
			{
			case 23:
				if (entityFilter == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 16;
			case 19:
				guid = UIwJZHGvj6Lhw5mb5cul(propMd);
				num2 = 25;
				break;
			case 6:
				if (listInfo.Objects == null)
				{
					num2 = 21;
					break;
				}
				goto case 14;
			case 14:
				if (!listInfo.Objects.Any())
				{
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 28;
					}
					break;
				}
				goto case 5;
			case 5:
				list = new List<object>();
				num2 = 3;
				break;
			case 4:
				entityFilter = c2hMEmG8W5BtCrjV9Kxs(propertyCached, filter, null) as IEntityFilter;
				num2 = 23;
				break;
			case 3:
				enumerator = listInfo.Objects.GetEnumerator();
				num2 = 24;
				break;
			case 12:
				return null;
			default:
				throw new FullTextFilterException(SR.T((string)L0D824GvLLhC1EYksCmT(0x3A6135BE ^ 0x3A62FE9C), v6jwVDG8bSnaAAYA1cY6(propMd), oMcwwgG8hKWUNewty3C6(propMd), propMd.Uid, ECq12rG8FQAvXj1KWpFG(propMd), L0D824GvLLhC1EYksCmT(0x3A6135BE ^ 0x3A62F9BE)));
			case 11:
				if (!YyoBkKG8BtitO2QpVfHW(propertyCached, null))
				{
					num2 = 22;
					break;
				}
				goto case 4;
			case 25:
				return new FilterListItem((string)E3AC8fGvUxmX09tJS8Jv(zIWGDHGvYJY5OEb69nhF(guid.ToString()), L0D824GvLLhC1EYksCmT(-1998538950 ^ -1998357464)), list, FilterListItemType.Must, FullTextFieldType.Long);
			case 21:
			case 28:
				if (!(value is SerializableFilter))
				{
					return null;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			case 26:
				return new FilterListItem(guid.ToString().ToLower() + (string)L0D824GvLLhC1EYksCmT(0x7459E02 ^ 0x7465510), new List<object> { Convert.ToInt64(BrvVHuGvzKkIvNaD3gOE(entityWrapper2)) }, FilterListItemType.Must, FullTextFieldType.Long);
			case 2:
			case 18:
				listInfo = value as ListInfo;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				if (listInfo != null)
				{
					num2 = 6;
					break;
				}
				goto case 21;
			case 9:
				if (value == null)
				{
					num2 = 8;
					break;
				}
				entityWrapper2 = value as EntityWrapper;
				num2 = 27;
				break;
			case 27:
				if (entityWrapper2 == null)
				{
					num2 = 18;
					break;
				}
				goto case 13;
			case 1:
				if (filter == null)
				{
					num2 = 17;
					break;
				}
				goto case 20;
			case 16:
				if (!sANelSG8ogvv3ZsHfHVE(entityFilter))
				{
					num2 = 15;
					break;
				}
				goto case 12;
			case 20:
				propertyCached = filter.GetType().GetPropertyCached((string)ECq12rG8FQAvXj1KWpFG(propMd));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 11;
				}
				break;
			case 10:
				guid = UIwJZHGvj6Lhw5mb5cul(propMd);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 26;
				}
				break;
			case 13:
				if (BrvVHuGvzKkIvNaD3gOE(entityWrapper2) == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 10;
			case 8:
				return null;
			case 24:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num3 = 1;
							}
							goto IL_041f;
						}
						goto IL_04c6;
						IL_04c6:
						entityWrapper = enumerator.Current as EntityWrapper;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num3 = 0;
						}
						goto IL_041f;
						IL_041f:
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (BrvVHuGvzKkIvNaD3gOE(entityWrapper) == null)
								{
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto case 5;
							case 5:
								list.Add(OnUYqHGvg6ZOoctmKbHm(BrvVHuGvzKkIvNaD3gOE(entityWrapper)));
								num3 = 6;
								continue;
							case 2:
							case 6:
							case 7:
								break;
							case 4:
								goto IL_04c6;
							default:
								if (entityWrapper == null)
								{
									num3 = 2;
									continue;
								}
								goto case 3;
							case 1:
								goto end_IL_0491;
							}
							break;
						}
						continue;
						end_IL_0491:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 19;
			}
		}
	}

	public override List<string> GetReturnField(IPropertyMetadata propMd)
	{
		return new List<string> { propMd.Uid.ToString().ToLower() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643607829) };
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_00e1, IL_0115, IL_01bd, IL_01cc, IL_01db, IL_0202, IL_024d, IL_025c, IL_02fd, IL_030c, IL_033c, IL_034b, IL_03dd, IL_0409, IL_0465, IL_04b6, IL_059e, IL_05ad, IL_0603, IL_0650, IL_0678, IL_0682, IL_0728, IL_073b, IL_074a, IL_075a, IL_0769, IL_07b9, IL_080a, IL_0819
		int num = 13;
		WebDataItem webDataItem = default(WebDataItem);
		RelationType relationType = default(RelationType);
		EntitySettings entitySettings = default(EntitySettings);
		int num7 = default(int);
		List<long> list = default(List<long>);
		int result3 = default(int);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		int result2 = default(int);
		Type entityType = default(Type);
		WebData[] array = default(WebData[]);
		int result = default(int);
		Type entityType2 = default(Type);
		PropertyInfo propertyCached = default(PropertyInfo);
		IEntity entity = default(IEntity);
		IEntityManager entityManager = default(IEntityManager);
		List<IEntity>.Enumerator enumerator = default(List<IEntity>.Enumerator);
		IEntity current = default(IEntity);
		List<IEntity> list2 = default(List<IEntity>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 27:
					if (webDataItem != null)
					{
						num2 = 15;
						continue;
					}
					return;
				case 9:
					return;
				case 46:
					relationType = hUacvZG8QTqDE43m442H(entitySettings);
					num2 = 23;
					continue;
				case 35:
				case 39:
					num7++;
					num2 = 44;
					continue;
				case 16:
					num7 = 0;
					num2 = 10;
					continue;
				case 38:
					list = new List<long>();
					num2 = 22;
					continue;
				case 8:
					list.Add(result3);
					num2 = 45;
					continue;
				case 19:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 7;
					}
					continue;
				case 11:
					return;
				case 18:
					if (!int.TryParse((string)tqE5T1G8CmnfgrLtZWmI(webDataItem), out result2))
					{
						num2 = 30;
						continue;
					}
					goto case 5;
				case 5:
					entityType = ModelHelper.GetEntityType(oMcwwgG8hKWUNewty3C6(propMd));
					num2 = 14;
					continue;
				case 14:
					if (!DnImPMG8vb4G0A2j6oMZ(entityType, null))
					{
						num2 = 6;
						continue;
					}
					goto case 1;
				case 26:
					return;
				case 37:
					if ((uint)(relationType - 1) > 2u)
					{
						return;
					}
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 17;
					}
					continue;
				case 33:
					return;
				case 30:
					return;
				case 45:
					if (vx4NEGG8Iv3x2yAosC1Q(webDataItem) == null)
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 47;
						}
						continue;
					}
					goto case 43;
				case 15:
					if (!((string)fUbZH4G8Ep00vqyEASc9(webDataItem) != (string)zIWGDHGvYJY5OEb69nhF(UIwJZHGvj6Lhw5mb5cul(propMd).ToString()) + (string)L0D824GvLLhC1EYksCmT(-398663332 ^ -398513586)))
					{
						entitySettings = kNMDx2G8fmZl6R74ryLa(propMd) as EntitySettings;
						num2 = 40;
						continue;
					}
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 33;
					}
					continue;
				case 23:
					if (relationType == RelationType.OneToOne)
					{
						num2 = 18;
						continue;
					}
					goto case 37;
				case 6:
					return;
				case 20:
				case 34:
					if (!int.TryParse(array[num7].Value, out result))
					{
						num2 = 39;
						continue;
					}
					goto case 24;
				case 10:
				case 44:
					if (num7 < array.Length)
					{
						num2 = 34;
						continue;
					}
					goto case 17;
				case 4:
				case 28:
					entityType2 = ModelHelper.GetEntityType(oMcwwgG8hKWUNewty3C6(propMd));
					num2 = 29;
					continue;
				case 22:
					if (int.TryParse((string)tqE5T1G8CmnfgrLtZWmI(webDataItem), out result3))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 45;
				case 31:
					if (YUHLL5G8Gt0nEmpYJxYb(propertyCached, null))
					{
						return;
					}
					num2 = 27;
					continue;
				case 40:
					if (entitySettings == null)
					{
						return;
					}
					num2 = 46;
					continue;
				case 32:
					try
					{
						if (entity == null)
						{
							return;
						}
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num8 = 1;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								return;
							case 1:
								propertyCached.SetValue(obj, entity, null);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num8 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
					catch (Exception ex2)
					{
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								return;
							}
							qZsvDaG8uONufyFa6npi(Jy1cTVG8ZRtTkrTdiGHd(), L0D824GvLLhC1EYksCmT(0x31326106 ^ 0x3131ABEE), ex2);
							num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num9 = 0;
							}
						}
					}
				case 3:
					return;
				case 42:
					propertyCached = obj.GetType().GetPropertyCached((string)ECq12rG8FQAvXj1KWpFG(propMd));
					num = 25;
					break;
				case 7:
					_003C_003Ec__DisplayClass7_.manager = (IEntityManager)neoyblG88YrniR71Z4ey(entityType2);
					num2 = 2;
					continue;
				case 2:
					if (_003C_003Ec__DisplayClass7_.manager != null)
					{
						num2 = 38;
						continue;
					}
					return;
				case 25:
					webDataItem = value as WebDataItem;
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 29;
					}
					continue;
				case 43:
					array = (WebData[])vx4NEGG8Iv3x2yAosC1Q(webDataItem);
					num2 = 16;
					continue;
				case 36:
					if (entityManager != null)
					{
						num2 = 21;
						continue;
					}
					return;
				case 1:
					entityManager = (IEntityManager)neoyblG88YrniR71Z4ey(entityType);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 14;
					}
					continue;
				case 13:
					if (obj == null)
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 12;
					}
					continue;
				case 29:
					if (!DnImPMG8vb4G0A2j6oMZ(entityType2, null))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 19;
				case 21:
					entity = entityManager.LoadOrNull(result2) as IEntity;
					num2 = 32;
					continue;
				case 24:
					list.Add(result);
					num = 35;
					break;
				default:
					try
					{
						IUntypedCollectionProxy untypedCollectionProxy = (IUntypedCollectionProxy)bl3i4wG8VADYZBIOiZow(c2hMEmG8W5BtCrjV9Kxs(propertyCached, obj, null));
						int num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								try
								{
									while (true)
									{
										IL_06e6:
										int num4;
										if (!enumerator.MoveNext())
										{
											num4 = 2;
											goto IL_0686;
										}
										goto IL_06a0;
										IL_0686:
										while (true)
										{
											switch (num4)
											{
											case 3:
												break;
											case 1:
												nYSoZFG8SG1CdlFmqL8W(untypedCollectionProxy, current);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
												{
													num4 = 0;
												}
												continue;
											default:
												goto IL_06e6;
											case 2:
												return;
											}
											break;
										}
										goto IL_06a0;
										IL_06a0:
										current = enumerator.Current;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num4 = 1;
										}
										goto IL_0686;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
							case 4:
								return;
							case 3:
								if (untypedCollectionProxy == null)
								{
									num3 = 4;
									continue;
								}
								break;
							case 1:
								return;
							}
							enumerator = list2.GetEnumerator();
							num3 = 2;
						}
					}
					catch (Exception ex)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								return;
							}
							qZsvDaG8uONufyFa6npi(Jy1cTVG8ZRtTkrTdiGHd(), L0D824GvLLhC1EYksCmT(-606654180 ^ -606798860), ex);
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num6 = 1;
							}
						}
					}
				case 41:
					return;
				case 12:
					if (propMd == null)
					{
						return;
					}
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 42;
					}
					continue;
				case 17:
				case 47:
					list2 = (from i in list.Distinct()
						orderby i
						select i).Select(_003C_003Ec__DisplayClass7_._003CSetIndexField_003Eb__1).OfType<IEntity>().ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static long? GetIdValueForEntity(object obj)
	{
		try
		{
			if (obj is IEntity entity)
			{
				object id = entity.GetId();
				long result;
				if (id != null)
				{
					return long.TryParse(id.ToString(), out result) ? new long?(result) : null;
				}
			}
			else
			{
				PropertyInfo property = obj.GetType().GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740305782));
				if (property != null)
				{
					object value = property.GetValue(obj, null);
					if (value == null)
					{
						return null;
					}
					long result2;
					return long.TryParse(value.ToString(), out result2) ? new long?(result2) : null;
				}
			}
		}
		catch (Exception)
		{
			return null;
		}
		return null;
	}

	internal static bool pTGWgDGvMh3EVBsYUFL9()
	{
		return gvpkU5GvyJPlvp9pFBco == null;
	}

	internal static EntityPropertyDescriptor QY6WJUGvJaAbfmKWdZLJ()
	{
		return gvpkU5GvyJPlvp9pFBco;
	}

	internal static object spkAtDGv9ZhmK4ikUa00(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object mOwB0CGvd6PmqRwWBc85(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool x8Oel6Gvlq4kMHcCaHsg(object P_0)
	{
		return ((IEntity)P_0).IsNew();
	}

	internal static object D0X3i9GvrLxu7tmfMaUR(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static long OnUYqHGvg6ZOoctmKbHm(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool dhDiHNGv5OFS64bhVJfT(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Guid UIwJZHGvj6Lhw5mb5cul(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static object zIWGDHGvYJY5OEb69nhF(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object L0D824GvLLhC1EYksCmT(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object E3AC8fGvUxmX09tJS8Jv(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Type kSqPCgGvsjvfQ5kFXyBh(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool ikAgumGvcRsW6C6Ufyyb(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object BrvVHuGvzKkIvNaD3gOE(object P_0)
	{
		return ((EntityWrapper)P_0).Id;
	}

	internal static object ECq12rG8FQAvXj1KWpFG(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool YyoBkKG8BtitO2QpVfHW(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object c2hMEmG8W5BtCrjV9Kxs(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool sANelSG8ogvv3ZsHfHVE(object P_0)
	{
		return ((IEntityFilter)P_0).IsEmpty();
	}

	internal static Guid v6jwVDG8bSnaAAYA1cY6(object P_0)
	{
		return ((IPropertyMetadata)P_0).TypeUid;
	}

	internal static Guid oMcwwgG8hKWUNewty3C6(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool YUHLL5G8Gt0nEmpYJxYb(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object fUbZH4G8Ep00vqyEASc9(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static object kNMDx2G8fmZl6R74ryLa(object P_0)
	{
		return ((IPropertyMetadata)P_0).Settings;
	}

	internal static RelationType hUacvZG8QTqDE43m442H(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object tqE5T1G8CmnfgrLtZWmI(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static bool DnImPMG8vb4G0A2j6oMZ(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object neoyblG88YrniR71Z4ey(Type entityType)
	{
		return ModelHelper.GetEntityManagerOrNull(entityType);
	}

	internal static object Jy1cTVG8ZRtTkrTdiGHd()
	{
		return Logger.Log;
	}

	internal static void qZsvDaG8uONufyFa6npi(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static object vx4NEGG8Iv3x2yAosC1Q(object P_0)
	{
		return ((WebDataItem)P_0).DataArray;
	}

	internal static object bl3i4wG8VADYZBIOiZow(object P_0)
	{
		return P_0.AsUntypedISet();
	}

	internal static void nYSoZFG8SG1CdlFmqL8W(object P_0, object P_1)
	{
		((IUntypedCollectionProxy)P_0).Add(P_1);
	}
}
