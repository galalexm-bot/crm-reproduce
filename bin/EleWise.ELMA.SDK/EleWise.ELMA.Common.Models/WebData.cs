using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Common.Models.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models;

[Serializable]
[KnownType(typeof(WebDataItem))]
[KnownType(typeof(EleWise.ELMA.Common.Models.API.WebData))]
[KnownType(typeof(EleWise.ELMA.Common.Models.API.WebData[]))]
[DataContract]
public class WebData
{
	private WebDataItem[] items;

	protected string _value;

	private static readonly string IdPropertyName;

	private static readonly string TypeUidPropertyName;

	private static readonly string IsDeletedPropertyName;

	internal static WebData No7KBtfihovppoO8ZLS1;

	[DataMember]
	public virtual WebDataItem[] Items
	{
		get
		{
			return items;
		}
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
				case 0:
					return;
				case 1:
					items = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool HasValue => !wtaKpGfiVaVq9I1J0jYr(_value);

	[DataMember]
	public virtual string Value
	{
		get
		{
			return _value;
		}
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
				case 0:
					return;
				case 1:
					_value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WebData()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BxAqgMfif0FqbsKHpf4c();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public WebData(IEnumerable<KeyValuePair<string, object>> dicObj)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(dicObj.ToArray());
	}

	public WebData(IDictionary<string, object> dicObj)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector((ICollection<KeyValuePair<string, object>>)dicObj);
	}

	public WebData(ICollection<KeyValuePair<string, object>> dicObj)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		WebDataItem[] array = new WebDataItem[dicObj.Count];
		int num = 0;
		foreach (KeyValuePair<string, object> item in dicObj)
		{
			if (item.Value is WebData)
			{
				array[num] = new WebDataItem
				{
					Name = item.Key,
					Data = (WebData)item.Value
				};
			}
			else if (item.Value is SerializableDictionary<string, object>)
			{
				array[num] = new WebDataItem
				{
					Name = item.Key,
					Data = new WebData((ICollection<KeyValuePair<string, object>>)item.Value)
				};
			}
			else if (item.Value is SerializableList<object> serializableList)
			{
				WebData[] array2 = new WebData[serializableList.Count];
				for (int i = 0; i < serializableList.Count; i++)
				{
					object obj = serializableList[i];
					if (obj == null)
					{
						array2[i] = null;
						continue;
					}
					if (obj is ICollection<KeyValuePair<string, object>> dicObj2)
					{
						array2[i] = new WebData(dicObj2);
						continue;
					}
					if (obj is WebData webData)
					{
						array2[i] = webData;
						continue;
					}
					Type type = obj.GetType();
					if (type == typeof(string) || type.IsPrimitive || type.IsValueType)
					{
						WebData webData2 = (array2[i] = new WebData
						{
							Value = obj.ToString()
						});
					}
				}
				array[num] = new WebDataItem
				{
					Name = item.Key,
					DataArray = array2
				};
			}
			else if (item.Value == null)
			{
				array[num] = new WebDataItem
				{
					Name = item.Key,
					Value = null
				};
			}
			else
			{
				TypeConverter converter = ElmaTypeDescriptorHelper.GetConverter(item.Value.GetType());
				if (converter != null && converter.CanConvertTo(typeof(string)))
				{
					array[num] = new WebDataItem
					{
						Name = item.Key,
						Value = converter.ConvertToInvariantString(item.Value)
					};
				}
				else
				{
					array[num] = new WebDataItem
					{
						Name = item.Key,
						Value = item.Value.ToString()
					};
				}
			}
			num++;
		}
		items = array;
	}

	[Obsolete("Метод устарел", true)]
	public static WebData CreateFromEntity(IEntity entity, Func<PropertyMetadata, bool> propertyFilter, Func<TablePartMetadata, bool> tablePartFilter)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.tablePartFilter = tablePartFilter;
		return CreateFromEntity(entity, propertyFilter, (ITablePartMetadata m) => CS_0024_003C_003E8__locals0.tablePartFilter((TablePartMetadata)m));
	}

	[Obsolete("Метод устарел", true)]
	public static WebData CreateFromEntity(IEntity entity, EntitySerializationSettings settings, Func<PropertyMetadata, bool> propertyFilter, Func<TablePartMetadata, bool> tablePartFilter)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.tablePartFilter = tablePartFilter;
		return CreateFromEntity(entity, settings, propertyFilter, (ITablePartMetadata m) => CS_0024_003C_003E8__locals0.tablePartFilter((TablePartMetadata)m));
	}

	public static WebData CreateFromEntity(IEntity entity, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		IDictionary<string, object> dictionary = DictionaryFromEntity(entity, propertyFilter, tablePartFilter);
		if (dictionary == null)
		{
			return null;
		}
		return new WebData(dictionary);
	}

	public static WebData CreateFromEntity(IEntity entity, EntitySerializationSettings settings, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		IDictionary<string, object> dictionary = DictionaryFromEntity(entity, settings, propertyFilter, tablePartFilter);
		if (dictionary == null)
		{
			return null;
		}
		return new WebData(dictionary);
	}

	public static WebData CreateFromEntity(IEntity entity, bool loadDisplayName)
	{
		return (WebData)z3vDUafiQhPixNWNIqbE(entity, null, loadDisplayName);
	}

	internal static WebData CreateFromEntity(IEntity entity, EntitySerializationSettings settings, bool loadDisplayName)
	{
		//Discarded unreachable code: IL_0041
		int num = 2;
		WebData webData = default(WebData);
		WebDataItem item = default(WebDataItem);
		List<WebDataItem> list = default(List<WebDataItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 4:
				case 6:
					return webData;
				case 7:
				{
					WebDataItem webDataItem = new WebDataItem();
					GPc4oJfi8SyZJ0HoPtsC(webDataItem, GQGDLIfiveaM7tkxB92K(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675685509), tSQ3YEfiCOvQ1MxCSpJI(entity.GetType())));
					webDataItem.Value = entity.GetTitleOrDefault();
					item = webDataItem;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 2:
					webData = CreateFromEntity(entity, settings);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					list.AddIfNotContains(item);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					if (!loadDisplayName)
					{
						num2 = 6;
						continue;
					}
					break;
				case 5:
					webData.Items = (WebDataItem[])q7rp1bfiZd2pSP7yTc9S(list);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			list = webData.Items.ToList();
			num = 7;
		}
	}

	public static WebData CreateFromObject(object data)
	{
		//Discarded unreachable code: IL_00ae, IL_00be, IL_00cd, IL_00d8, IL_0194, IL_01c4, IL_01d3, IL_01df
		int num = 5;
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		IEnumerable<KeyValuePair<string, object>> enumerable = default(IEnumerable<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return null;
				case 7:
					enumerator = enumerable.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					if (data != null)
					{
						goto end_IL_0012;
					}
					num2 = 4;
					break;
				case 4:
					return null;
				default:
					if (enumerable != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 6;
				case 1:
					try
					{
						while (true)
						{
							IL_0125:
							int num3;
							if (!qUNeWKfiuDJ52wa2nhAC(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num3 = 0;
								}
								goto IL_00dc;
							}
							goto IL_014b;
							IL_014b:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num3 = 2;
							}
							goto IL_00dc;
							IL_00dc:
							while (true)
							{
								switch (num3)
								{
								case 2:
									dictionary.Add(current.Key, current.Value);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									goto IL_0125;
								case 3:
									goto IL_014b;
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
						int num4;
						if (enumerator == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num4 = 1;
							}
							goto IL_0198;
						}
						goto IL_01ae;
						IL_01ae:
						JyG2ZNfiIDt0NL2kvA7e(enumerator);
						num4 = 2;
						goto IL_0198;
						IL_0198:
						switch (num4)
						{
						case 1:
							goto end_IL_0173;
						case 2:
							goto end_IL_0173;
						}
						goto IL_01ae;
						end_IL_0173:;
					}
					goto case 2;
				case 2:
					return new WebData(dictionary);
				case 3:
					enumerable = new EntityJsonSerializer().ConvertToSerializable(data) as IEnumerable<KeyValuePair<string, object>>;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			dictionary = new Dictionary<string, object>();
			num = 3;
		}
	}

	public static WebData CreateFromObject(object data, EntitySerializationSettings settings)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_00ea, IL_0176, IL_01b6, IL_01c5, IL_01d1, IL_01e4, IL_01f3, IL_0203, IL_0212
		int num = 7;
		IEnumerable<KeyValuePair<string, object>> enumerable = default(IEnumerable<KeyValuePair<string, object>>);
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (enumerable != null)
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 7:
					if (data != null)
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 5:
					return null;
				case 2:
					enumerator = enumerable.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					goto end_IL_0012;
				case 4:
					return null;
				case 6:
					dictionary = new Dictionary<string, object>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							IL_014a:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_00ee;
							}
							goto IL_0127;
							IL_00ee:
							while (true)
							{
								switch (num3)
								{
								case 1:
									dictionary.Add(current.Key, current.Value);
									num3 = 2;
									continue;
								case 2:
									goto IL_014a;
								case 3:
									goto end_IL_014a;
								}
								break;
							}
							goto IL_0127;
							IL_0127:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num3 = 1;
							}
							goto IL_00ee;
							continue;
							end_IL_014a:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 2;
							goto IL_017a;
						}
						goto IL_0190;
						IL_017a:
						switch (num4)
						{
						default:
							goto end_IL_0165;
						case 1:
							break;
						case 2:
							goto end_IL_0165;
						case 0:
							goto end_IL_0165;
						}
						goto IL_0190;
						IL_0190:
						JyG2ZNfiIDt0NL2kvA7e(enumerator);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num4 = 0;
						}
						goto IL_017a;
						end_IL_0165:;
					}
					break;
				case 8:
					break;
				}
				return new WebData(dictionary);
				continue;
				end_IL_0012:
				break;
			}
			enumerable = new EntityJsonSerializer().ConvertToSerializable(data, settings) as IEnumerable<KeyValuePair<string, object>>;
			num = 3;
		}
	}

	public static WebData CreateForDeleted(Guid typeUid, Guid objectUid, object objectId = null)
	{
		int num = 6;
		int num2 = num;
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		while (true)
		{
			switch (num2)
			{
			default:
				dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77F825), objectUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				dictionary.Add(IdPropertyName, objectId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (objectId != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				return new WebData(dictionary);
			case 3:
				dictionary.Add(TypeUidPropertyName, typeUid);
				num2 = 4;
				break;
			case 6:
				dictionary = new Dictionary<string, object>();
				num2 = 5;
				break;
			case 4:
				dictionary.Add(IsDeletedPropertyName, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual WebDataItem FindItem(string name)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass21_.name = name;
				num2 = 3;
				break;
			case 3:
				if (items == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 2;
					}
					break;
				}
				return items.FirstOrDefault(_003C_003Ec__DisplayClass21_._003CFindItem_003Eb__0);
			case 2:
				return null;
			}
		}
	}

	public virtual WebData FindByPath([NotNull] string path)
	{
		//Discarded unreachable code: IL_00a0, IL_01fe, IL_020d, IL_02dd, IL_02ec
		int num = 19;
		string text = default(string);
		string text2 = default(string);
		int num3 = default(int);
		int num4 = default(int);
		List<string> list = default(List<string>);
		long result = default(long);
		WebData webData = default(WebData);
		WebDataItem webDataItem = default(WebDataItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					text = text2.Substring(num3 + 1, num4 - 1);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					continue;
				case 19:
					if (wtaKpGfiVaVq9I1J0jYr(path))
					{
						num2 = 18;
						continue;
					}
					list = ((IEnumerable<string>)UC7Z9BfiS70ACbQgOYW2(path, new char[1] { '.' }, StringSplitOptions.RemoveEmptyEntries)).ToList();
					num = 2;
					break;
				case 11:
					if (long.TryParse(text, out result))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 10;
				case 12:
					webData = webData.FindByPath(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867197103), list));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					text = "";
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 10;
					}
					continue;
				case 2:
					text2 = list[0];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 13;
					}
					continue;
				case 5:
				case 7:
					webDataItem = FindItem(text2);
					num2 = 6;
					continue;
				case 8:
					num4 = owMstTfiqFBVPsG4YKqQ(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195567619), StringComparison.InvariantCultureIgnoreCase);
					num2 = 9;
					continue;
				case 3:
					webData = webDataItem.DataArray[result];
					num2 = 4;
					continue;
				case 15:
					num3 = mKUDYgfiRcn9nhA9iyO5(text2, qxlG8mfiiCJTBAP0lRSQ(-576149596 ^ -576171706), StringComparison.InvariantCultureIgnoreCase);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 8;
					}
					continue;
				case 18:
					return this;
				case 6:
					if (!wtaKpGfiVaVq9I1J0jYr(text))
					{
						num = 11;
						break;
					}
					goto case 10;
				default:
					return webData;
				case 1:
					text2 = (string)EZ84qdfiKdURYq8WMfj3(text2, num3);
					num2 = 5;
					continue;
				case 13:
					list.Remove(text2);
					num2 = 16;
					continue;
				case 17:
					if (text2.IndexOf((string)qxlG8mfiiCJTBAP0lRSQ(-1979251663 ^ -1979190573), StringComparison.InvariantCultureIgnoreCase) <= 0)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 15;
				case 10:
					webData = (WebData)DeAnBjfiXKuNRN6AdYD8(webDataItem);
					num2 = 20;
					continue;
				case 4:
				case 20:
					if (tSaGBofiTXySGICC1dbE(list) <= 0)
					{
						num = 14;
						break;
					}
					goto case 12;
				}
				break;
			}
		}
	}

	public virtual IDictionary<string, object> ToDictionary()
	{
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		if (HasValue)
		{
			serializableDictionary.Add("", Value);
		}
		else if (Items != null)
		{
			WebDataItem[] array = Items;
			foreach (WebDataItem webDataItem in array)
			{
				object obj = null;
				if (webDataItem.Data != null)
				{
					obj = webDataItem.Data.ToDictionary();
				}
				else if (webDataItem.DataArray != null && webDataItem.DataArray.Length != 0)
				{
					obj = new SerializableList<object>();
					if (webDataItem.DataArray.All((WebData d) => d.HasValue))
					{
						((SerializableList<object>)obj).AddRange(webDataItem.DataArray.Select((WebData d) => (string)_003C_003Ec.XsBqJW8jkBnKgJ7uHi2S(d)));
					}
					else
					{
						((SerializableList<object>)obj).AddRange(webDataItem.DataArray.Select((WebData y) => y.ToDictionary()));
					}
				}
				else if (webDataItem.Value != null)
				{
					obj = webDataItem.Value;
				}
				serializableDictionary.Add(webDataItem.Name, obj);
			}
		}
		return serializableDictionary;
	}

	[IteratorStateMachine(typeof(_003CToKeyValueList_003Ed__24))]
	public virtual IEnumerable<KeyValuePair<string, object>> ToKeyValueList()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CToKeyValueList_003Ed__24(-2)
		{
			_003C_003E4__this = this
		};
	}

	public virtual void SaveToEntity(object target)
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
				jpkNsGfike7xiWkObb3r(this, target, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void SaveToEntity(object target, bool ignoreNullDescriptor)
	{
		//Discarded unreachable code: IL_00c4, IL_01f7, IL_0206, IL_0215, IL_027d, IL_0290, IL_0301
		int num = 8;
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		IEntity entity = default(IEntity);
		ClassMetadata classMetadata = default(ClassMetadata);
		IMetadataService metadataService = default(IMetadataService);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		ISerializableTypeDescriptor serializableTypeDescriptor = default(ISerializableTypeDescriptor);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 6:
					return;
				case 2:
					dictionary = ToDictionary();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					return;
				case 1:
					new EntityJsonSerializer().ConvertFromSerializable(entity, dictionary);
					num2 = 4;
					continue;
				case 5:
					entity = target as IEntity;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					return;
				case 3:
					if (entity == null)
					{
						List<PropertyMetadata> properties = classMetadata.Properties;
						metadataService = (IMetadataService)Erv6fjfinC6BKJ6gBEmP();
						enumerator = properties.GetEnumerator();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 1;
						}
					}
					continue;
				case 10:
					if (classMetadata == null)
					{
						return;
					}
					num2 = 2;
					continue;
				case 8:
					if (target != null)
					{
						classMetadata = MetadataLoader.LoadMetadata(target.GetType()) as ClassMetadata;
						num = 10;
						goto end_IL_0012;
					}
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				try
				{
					while (true)
					{
						IL_01bb:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 10;
							goto IL_00d2;
						}
						goto IL_014f;
						IL_00d2:
						while (true)
						{
							switch (num3)
							{
							case 9:
								throw new MetadataException(SR.T((string)qxlG8mfiiCJTBAP0lRSQ(-1317790512 ^ -1317705152), WGKCY0fiOFcEEyvEWDXd(current)));
							case 8:
							{
								serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
								int num4 = 6;
								num3 = num4;
								continue;
							}
							case 5:
								break;
							case 4:
								if (ignoreNullDescriptor)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 2:
								serializableTypeDescriptor.Deserialize(target, classMetadata, current, dictionary);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
								{
									num3 = 1;
								}
								continue;
							case 7:
								if (typeDescriptor != null)
								{
									num3 = 8;
									continue;
								}
								goto case 4;
							case 1:
							case 3:
								goto IL_01bb;
							case 6:
								if (serializableTypeDescriptor != null)
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_01bb;
							default:
								typeDescriptor = (ITypeDescriptor)HYMId0fi2o3n731C8WXk(metadataService, WGKCY0fiOFcEEyvEWDXd(current), current.SubTypeUid);
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num3 = 7;
								}
								continue;
							case 10:
								return;
							}
							break;
						}
						goto IL_014f;
						IL_014f:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num3 = 0;
						}
						goto IL_00d2;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (string)t1TJkqfi1LyEsvLdwUok(qxlG8mfiiCJTBAP0lRSQ(-309639236 ^ -309638080), (items != null) ? ((string)pQV6p9fiefsba88c6Skn() + string.Join((string)r3vUlGfiP0PJIODUvJJI(qxlG8mfiiCJTBAP0lRSQ(0x53CB464B ^ 0x53CB14BB), pQV6p9fiefsba88c6Skn()), items.Select((WebDataItem i) => i.ToString())) + (string)pQV6p9fiefsba88c6Skn()) : null, qxlG8mfiiCJTBAP0lRSQ(--1418440330 ^ 0x548BA29A));
			default:
				return (string)qxlG8mfiiCJTBAP0lRSQ(0x12441CA4 ^ 0x12415E52) + _value + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309759962);
			}
		}
	}

	internal static IDictionary<string, object> DictionaryFromEntity(IEntity entity, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		if (entity == null)
		{
			return null;
		}
		ClassMetadata obj = MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) as ClassMetadata;
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (obj != null)
		{
			if (!(new EntityJsonSerializer
			{
				PropertyFilter = propertyFilter,
				NeedBindTablePart = tablePartFilter
			}.ConvertToSerializable(entity) is IEnumerable<KeyValuePair<string, object>> enumerable))
			{
				return null;
			}
			{
				foreach (KeyValuePair<string, object> item in enumerable)
				{
					dictionary.Add(item.Key, item.Value);
				}
				return dictionary;
			}
		}
		return dictionary;
	}

	internal static IDictionary<string, object> DictionaryFromEntity(IEntity entity, EntitySerializationSettings settings, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		if (entity == null)
		{
			return null;
		}
		ClassMetadata obj = MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) as ClassMetadata;
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (obj != null)
		{
			if (!(new EntityJsonSerializer
			{
				PropertyFilter = propertyFilter,
				NeedBindTablePart = tablePartFilter
			}.ConvertToSerializable(entity, settings) is IEnumerable<KeyValuePair<string, object>> enumerable))
			{
				return null;
			}
			{
				foreach (KeyValuePair<string, object> item in enumerable)
				{
					dictionary.Add(item.Key, item.Value);
				}
				return dictionary;
			}
		}
		return dictionary;
	}

	static WebData()
	{
		int num = 1;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				IsDeletedPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<ISoftDeletable, object>>((Expression)I8mFVZfiD9rofU2AwHWe(Expression.Property(parameterExpression, (MethodInfo)sMDwOLfia7JafpMElwxy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
				num2 = 7;
				break;
			default:
				parameterExpression = (ParameterExpression)Bj5eAwfi3tl9owYdJCMv(jf8a1AfiNSQjcMRLpd5j(typeof(IEntity<object>).TypeHandle), qxlG8mfiiCJTBAP0lRSQ(0x2A7797B7 ^ 0x2A771F9F));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				TypeUidPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IInheritable, object>>(Expression.Convert((Expression)j6kIVjfippkQaLqluV2y(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), jf8a1AfiNSQjcMRLpd5j(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 5;
				break;
			case 5:
				parameterExpression = (ParameterExpression)Bj5eAwfi3tl9owYdJCMv(jf8a1AfiNSQjcMRLpd5j(typeof(ISoftDeletable).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210529503));
				num2 = 3;
				break;
			case 2:
				IdPropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IEntity<object>, object>>((Expression)j6kIVjfippkQaLqluV2y(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<object>).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 6;
				break;
			case 6:
				parameterExpression = Expression.Parameter(jf8a1AfiNSQjcMRLpd5j(typeof(IInheritable).TypeHandle), (string)qxlG8mfiiCJTBAP0lRSQ(0x8317432 ^ 0x83181A2));
				num2 = 4;
				break;
			}
		}
	}

	internal static void BxAqgMfif0FqbsKHpf4c()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fZa0MOfiGGKYywlHY8dt()
	{
		return No7KBtfihovppoO8ZLS1 == null;
	}

	internal static WebData MFEhikfiENGUjkSwxe2L()
	{
		return No7KBtfihovppoO8ZLS1;
	}

	internal static object z3vDUafiQhPixNWNIqbE(object P_0, object P_1, bool loadDisplayName)
	{
		return CreateFromEntity((IEntity)P_0, (EntitySerializationSettings)P_1, loadDisplayName);
	}

	internal static object tSQ3YEfiCOvQ1MxCSpJI(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object GQGDLIfiveaM7tkxB92K(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void GPc4oJfi8SyZJ0HoPtsC(object P_0, object P_1)
	{
		((WebDataItem)P_0).Name = (string)P_1;
	}

	internal static object q7rp1bfiZd2pSP7yTc9S(object P_0)
	{
		return ((List<WebDataItem>)P_0).ToArray();
	}

	internal static bool qUNeWKfiuDJ52wa2nhAC(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void JyG2ZNfiIDt0NL2kvA7e(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool wtaKpGfiVaVq9I1J0jYr(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object UC7Z9BfiS70ACbQgOYW2(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	internal static object qxlG8mfiiCJTBAP0lRSQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int mKUDYgfiRcn9nhA9iyO5(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static int owMstTfiqFBVPsG4YKqQ(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).LastIndexOf((string)P_1, P_2);
	}

	internal static object EZ84qdfiKdURYq8WMfj3(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object DeAnBjfiXKuNRN6AdYD8(object P_0)
	{
		return ((WebDataItem)P_0).Data;
	}

	internal static int tSaGBofiTXySGICC1dbE(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static void jpkNsGfike7xiWkObb3r(object P_0, object P_1, bool ignoreNullDescriptor)
	{
		((WebData)P_0).SaveToEntity(P_1, ignoreNullDescriptor);
	}

	internal static object Erv6fjfinC6BKJ6gBEmP()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid WGKCY0fiOFcEEyvEWDXd(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object HYMId0fi2o3n731C8WXk(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object pQV6p9fiefsba88c6Skn()
	{
		return Environment.NewLine;
	}

	internal static object r3vUlGfiP0PJIODUvJJI(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object t1TJkqfi1LyEsvLdwUok(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Type jf8a1AfiNSQjcMRLpd5j(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Bj5eAwfi3tl9owYdJCMv(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object j6kIVjfippkQaLqluV2y(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object sMDwOLfia7JafpMElwxy(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object I8mFVZfiD9rofU2AwHWe(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}
