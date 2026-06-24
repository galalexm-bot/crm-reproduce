using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class EntityCompareHelper
{
	private static EntityCompareHelper Tf9CUIhUoyVYXLR1R8Jw;

	public static IDictionary<string, object> GetState([NotNull] IEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852875104));
		}
		return (IDictionary<string, object>)new EntityJsonSerializer().ConvertToSerializable(entity);
	}

	public static string[] Compare([NotNull] IEntity entity, [NotNull] IDictionary<string, object> state)
	{
		if (entity == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281821156));
		}
		if (state == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E058B0));
		}
		List<string> list = new List<string>();
		Compare(entity, state, list, "");
		return list.ToArray();
	}

	private static bool Compare(object entity, IDictionary<string, object> state, List<string> result, object prefix)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.result = result;
		CS_0024_003C_003E8__locals0.hasChanges = false;
		Action<string> action = delegate(string s)
		{
			//Discarded unreachable code: IL_007c, IL_008b
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					CS_0024_003C_003E8__locals0.hasChanges = true;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					CS_0024_003C_003E8__locals0.result.Add(s);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 4:
					if (CS_0024_003C_003E8__locals0.result.Contains(s))
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 1:
					return;
				}
			}
		};
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(((IEntity)entity).CastAsRealType().GetType());
		IMetadataService service = MetadataServiceContext.Service;
		foreach (PropertyMetadata property in entityMetadata.Properties)
		{
			string obj = (string)prefix + property.Name;
			ITypeDescriptor typeDescriptor = service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid);
			if (typeDescriptor == null)
			{
				throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210639533), property.TypeUid));
			}
			IDictionary<string, object> dictionary = (typeDescriptor as ISerializableTypeDescriptor).Serialize(entity, entityMetadata, property);
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, object> item in dictionary)
				{
					object value = item.Value;
					if (!state.TryGetValue(item.Key, out var value2) || !EqualsSerializedValues(value, value2))
					{
						action(obj);
					}
				}
			}
			else if (state.ContainsKey(property.Name))
			{
				action(obj);
			}
		}
		foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
		{
			_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass2_1();
			string obj2 = (string)prefix + tablePart.TablePartPropertyName;
			if (!(((IEntity)entity).GetPropertyValue(tablePart.TablePartPropertyUid) is IEnumerable enumerable))
			{
				if (state.ContainsKey(tablePart.TablePartPropertyName))
				{
					action(obj2);
				}
				continue;
			}
			if (!state.TryGetValue(tablePart.TablePartPropertyName, out var value3))
			{
				action(obj2);
				continue;
			}
			IEnumerable obj3 = (IEnumerable)value3;
			Dictionary<object, IDictionary<string, object>> dictionary2 = new Dictionary<object, IDictionary<string, object>>();
			foreach (IDictionary<string, object> item2 in obj3)
			{
				if (item2.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889492706), out var value4))
				{
					dictionary2[value4] = item2;
				}
			}
			Dictionary<object, IEntity> dictionary4 = new Dictionary<object, IEntity>();
			foreach (IEntity item3 in enumerable)
			{
				dictionary4[item3.GetId()] = item3;
			}
			bool flag = false;
			CS_0024_003C_003E8__locals1.oldIds = dictionary2.Select((KeyValuePair<object, IDictionary<string, object>> v) => v.Key);
			CS_0024_003C_003E8__locals1.newIds = dictionary4.Select((KeyValuePair<object, IEntity> v) => v.Key);
			if (CS_0024_003C_003E8__locals1.oldIds.Any((object i) => !CS_0024_003C_003E8__locals1.newIds.Contains(i)) || CS_0024_003C_003E8__locals1.newIds.Any((object i) => !CS_0024_003C_003E8__locals1.oldIds.Contains(i)))
			{
				flag = true;
			}
			foreach (KeyValuePair<object, IEntity> item4 in dictionary4)
			{
				if (dictionary2.TryGetValue(item4.Key, out var value5) && Compare(item4.Value, value5, CS_0024_003C_003E8__locals0.result, (string)prefix + tablePart.TablePartPropertyName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E8515)))
				{
					flag = true;
				}
			}
			if (flag)
			{
				action(obj2);
			}
		}
		return CS_0024_003C_003E8__locals0.hasChanges;
	}

	private static bool EqualsSerializedValues(object v1, object v2)
	{
		//Discarded unreachable code: IL_00ac, IL_00bb, IL_00fc, IL_010b, IL_011b, IL_01c8, IL_01d7, IL_01e2, IL_0283, IL_0292, IL_02f3, IL_032b, IL_033a, IL_0431, IL_04a6, IL_04b5
		int num = 11;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		List<object> list2 = default(List<object>);
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		object value = default(object);
		bool result = default(bool);
		List<object> list = default(List<object>);
		HashSet<object> hashSet = default(HashSet<object>);
		HashSet<object> equals = default(HashSet<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Func<List<object>, HashSet<object>> func;
				switch (num2)
				{
				case 18:
					if (!_003C_003Ec__DisplayClass3_.v1dict.Any())
					{
						num2 = 6;
						continue;
					}
					goto IL_015e;
				case 25:
					if (v2 != null)
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 17;
				case 26:
					if (dictionary != null)
					{
						num2 = 18;
						continue;
					}
					goto case 21;
				case 9:
					if (list2 == null)
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 5;
				case 22:
					dictionary = v2 as IDictionary<string, object>;
					num = 23;
					break;
				case 1:
					return true;
				case 14:
					list2 = v2 as List<object>;
					num = 27;
					break;
				case 6:
					if (!dictionary.Any())
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_015e;
				case 13:
					try
					{
						while (true)
						{
							IL_0239:
							int num3;
							if (!gOEwFehUEiKwX9rb0nSm(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num3 = 0;
								}
								goto IL_01e6;
							}
							goto IL_02ba;
							IL_02ba:
							current = enumerator.Current;
							num3 = 5;
							goto IL_01e6;
							IL_01e6:
							while (true)
							{
								switch (num3)
								{
								case 3:
									if (!TtJoUshUGmUjaYwXpTtN(current.Value, value))
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
										{
											num3 = 6;
										}
										continue;
									}
									goto IL_0239;
								case 4:
									goto IL_0239;
								case 5:
									if (dictionary.TryGetValue(current.Key, out value))
									{
										num3 = 3;
										continue;
									}
									goto IL_0239;
								case 6:
									result = false;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									goto IL_02ba;
								case 0:
									break;
								case 1:
									return result;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									DK6ecwhUfqKbN0IGXSC3(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto default;
				case 17:
				case 24:
					return false;
				case 19:
				case 20:
					if (!v1.Equals(v2))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 16;
				case 16:
					return true;
				case 12:
					_003C_003Ec__DisplayClass3_.v1dict = v1 as IDictionary<string, object>;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 22;
					}
					continue;
				case 23:
					if (_003C_003Ec__DisplayClass3_.v1dict == null)
					{
						num2 = 21;
						continue;
					}
					goto case 26;
				case 10:
					if (v1 == v2)
					{
						num2 = 8;
						continue;
					}
					if (v1 == null)
					{
						num2 = 7;
						continue;
					}
					goto case 4;
				case 8:
					return true;
				default:
					return dictionary.Keys.All(_003C_003Ec__DisplayClass3_._003CEqualsSerializedValues_003Eb__0);
				case 21:
					list = v1 as List<object>;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					func = _003C_003Ec._003C_003E9__3_1;
					if (func == null)
					{
						num2 = 2;
						continue;
					}
					goto IL_04d5;
				case 7:
					if (v2 != null)
					{
						num2 = 24;
						continue;
					}
					goto case 4;
				case 4:
					if (v1 == null)
					{
						num2 = 19;
						continue;
					}
					goto case 25;
				case 27:
					if (list != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 15;
				case 3:
					return hashSet.SetEquals(equals);
				case 15:
					return false;
				case 2:
					{
						func = (_003C_003Ec._003C_003E9__3_1 = delegate(List<object> e)
						{
							HashSet<object> hashSet2 = new HashSet<object>();
							foreach (IDictionary<string, object> item in e.OfType<IDictionary<string, object>>())
							{
								if (item.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289681612), out var value2))
								{
									hashSet2.Add(value2);
								}
							}
							return hashSet2;
						});
						goto IL_04d5;
					}
					IL_015e:
					enumerator = _003C_003Ec__DisplayClass3_.v1dict.GetEnumerator();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					continue;
					IL_04d5:
					hashSet = func(list);
					equals = func(list2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool TtJoUshUGmUjaYwXpTtN(object P_0, object P_1)
	{
		return EqualsSerializedValues(P_0, P_1);
	}

	internal static bool gOEwFehUEiKwX9rb0nSm(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void DK6ecwhUfqKbN0IGXSC3(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool x0B04VhUb2Ynb7piwLNq()
	{
		return Tf9CUIhUoyVYXLR1R8Jw == null;
	}

	internal static EntityCompareHelper XCgb8ohUhkKGoLPT5BSH()
	{
		return Tf9CUIhUoyVYXLR1R8Jw;
	}
}
