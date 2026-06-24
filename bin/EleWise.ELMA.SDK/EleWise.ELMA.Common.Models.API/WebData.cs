using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Common.Models.API;

[Serializable]
[KnownType(typeof(WebData[]))]
public class WebData : EleWise.ELMA.Common.Models.WebData, ISerializable
{
	private WebDataItem[] items;

	private static readonly Type TypeOfWebData;

	private static readonly Type TypeOfWebDataArray;

	private static readonly Type TypeOfObject;

	private static readonly Type TypeOfObjectArray;

	private static readonly Type TypeofValue;

	internal static WebData ryaVMXfiL15UA8IfH3wJ;

	public override EleWise.ELMA.Common.Models.WebDataItem[] Items
	{
		get
		{
			return items.Cast<EleWise.ELMA.Common.Models.WebDataItem>().ToArray();
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
					items = value.Cast<WebDataItem>().ToArray();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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
		ejmZh7ficYgGVaH6HOxB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
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
					Data = Create((EleWise.ELMA.Common.Models.WebData)item.Value)
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
				int num2 = num;
				WebDataItem obj2 = new WebDataItem
				{
					Name = item.Key
				};
				EleWise.ELMA.Common.Models.WebData[] array4 = (obj2.DataArray = array2);
				array[num2] = obj2;
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

	public WebData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_001a, IL_008e, IL_01a2, IL_01b1, IL_0240, IL_027a, IL_0289, IL_0298, IL_02a8, IL_02b7, IL_02c8, IL_02d7
		ejmZh7ficYgGVaH6HOxB();
		base._002Ector();
		int num = 16;
		List<WebDataItem> list = default(List<WebDataItem>);
		WebDataItem webDataItem = default(WebDataItem);
		SerializationInfoEnumerator serializationInfoEnumerator = default(SerializationInfoEnumerator);
		while (true)
		{
			switch (num)
			{
			default:
				items = (WebDataItem[])wiJtF6fRQx3CWIOXhcLG(list);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 1;
				}
				break;
			case 8:
				heJKR5fRheD0U3J3nqsR(webDataItem, (WebData)ADUhOMfRboJ3KRaruVk7(info, CyH2LKfRF1saYg7WyMZe(serializationInfoEnumerator), TypeOfWebData));
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num = 5;
				}
				break;
			case 12:
			case 15:
				if (!(C3js5RfRW6jvx1958Vji(serializationInfoEnumerator) == TypeofValue))
				{
					num = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num = 13;
					}
					break;
				}
				goto case 3;
			case 4:
			case 5:
			case 6:
			case 13:
			case 17:
				if (HnXCUrfRfsNS6An8RGQh(serializationInfoEnumerator))
				{
					num = 21;
					break;
				}
				goto default;
			case 2:
				sLpwAifRGOb6kpXZyIS6(webDataItem, ((WebData[])info.GetValue((string)CyH2LKfRF1saYg7WyMZe(serializationInfoEnumerator), TypeOfWebDataArray)).Cast<EleWise.ELMA.Common.Models.WebData>().ToArray());
				num = 13;
				break;
			case 21:
			case 22:
			{
				WebDataItem webDataItem2 = new WebDataItem();
				TxnEgEfRBBcnc3kor8Nm(webDataItem2, CyH2LKfRF1saYg7WyMZe(serializationInfoEnumerator));
				webDataItem = webDataItem2;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num = 19;
				}
				break;
			}
			case 16:
				list = new List<WebDataItem>();
				num = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num = 18;
				}
				break;
			case 7:
				if (!xCkppwfRoFDmGMcfCrRp(C3js5RfRW6jvx1958Vji(serializationInfoEnumerator), TypeOfObject))
				{
					num = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num = 15;
					}
					break;
				}
				goto case 8;
			case 10:
			case 14:
				X9wjkWfREIfAVkBigbx3(webDataItem, info.GetString(serializationInfoEnumerator.Name));
				num = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num = 8;
				}
				break;
			case 3:
			{
				_value = ADUhOMfRboJ3KRaruVk7(info, CyH2LKfRF1saYg7WyMZe(serializationInfoEnumerator), TypeofValue).ToString();
				int num2 = 4;
				num = num2;
				break;
			}
			case 1:
				return;
			case 18:
				serializationInfoEnumerator = (SerializationInfoEnumerator)WXr2v3fizkUSqpITB0eh(info);
				num = 6;
				break;
			case 11:
				if (!xCkppwfRoFDmGMcfCrRp(serializationInfoEnumerator.ObjectType, TypeOfObjectArray))
				{
					num = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num = 4;
					}
					break;
				}
				goto case 2;
			case 20:
				if (xCkppwfRoFDmGMcfCrRp(C3js5RfRW6jvx1958Vji(serializationInfoEnumerator), TypeOfWebData))
				{
					num = 8;
					break;
				}
				goto case 11;
			case 9:
				if (!(serializationInfoEnumerator.ObjectType == TypeOfWebDataArray))
				{
					num = 12;
					break;
				}
				goto case 2;
			case 19:
				list.Add(webDataItem);
				num = 7;
				break;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_00d7, IL_00e6, IL_00f6, IL_0105, IL_0161, IL_01ab, IL_01ba, IL_0200, IL_029e, IL_02ad, IL_02bc, IL_02cc, IL_02db
		int num = 5;
		WebDataItem webDataItem = default(WebDataItem);
		WebData value = default(WebData);
		WebData[] array = default(WebData[]);
		int num3 = default(int);
		WebDataItem[] array2 = default(WebDataItem[]);
		string[] array3 = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					return;
				case 9:
					info.AddValue((string)NsuAqHfRvJdVCIOdHIVx(webDataItem), value, TypeOfWebData);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 15;
					}
					continue;
				case 17:
					if (((Array)eAIHySfR8BpvBLjMYMH4(webDataItem)).Length == 0)
					{
						goto end_IL_0012;
					}
					goto case 24;
				case 22:
					value = (WebData)OnsNkDfRCffFClaGCaJT(webDataItem);
					num2 = 9;
					continue;
				case 8:
					if (webDataItem.Data != null)
					{
						num2 = 22;
						continue;
					}
					goto case 3;
				case 12:
					mQn2udfRZHAPnVn89fuZ(info, NsuAqHfRvJdVCIOdHIVx(webDataItem), array, TypeOfWebDataArray);
					num2 = 19;
					continue;
				case 10:
					num3 = 0;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 16;
					}
					continue;
				default:
					JbFNhDfRIPD6QYTqrlEC(info, NsuAqHfRvJdVCIOdHIVx(webDataItem), lXYJDUfRuLLKbjX7lHGR(webDataItem));
					num2 = 21;
					continue;
				case 11:
				case 16:
					webDataItem = array2[num3];
					num2 = 8;
					continue;
				case 14:
				case 20:
					if (num3 < array2.Length)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					return;
				case 13:
				case 15:
				case 19:
				case 21:
					num3++;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 14;
					}
					continue;
				case 5:
					if (items != null)
					{
						num2 = 4;
						continue;
					}
					mQn2udfRZHAPnVn89fuZ(info, WesVgdfRVRB3pfosq1yF(0xE1229CF ^ 0xE128F9B), sQjuorfRS6pDl1raKlbt(this), TypeofValue);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 18;
					}
					continue;
				case 1:
					return;
				case 2:
					mQn2udfRZHAPnVn89fuZ(info, NsuAqHfRvJdVCIOdHIVx(webDataItem), array3, TypeOfWebDataArray);
					num2 = 13;
					continue;
				case 3:
					if (eAIHySfR8BpvBLjMYMH4(webDataItem) == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 17;
				case 4:
					array2 = items;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
				case 23:
					array = ((IEnumerable)eAIHySfR8BpvBLjMYMH4(webDataItem)).Cast<WebData>().ToArray();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 6;
					}
					continue;
				case 24:
					if (!((IEnumerable<EleWise.ELMA.Common.Models.WebData>)eAIHySfR8BpvBLjMYMH4(webDataItem)).All((EleWise.ELMA.Common.Models.WebData d) => d.HasValue))
					{
						num2 = 7;
						continue;
					}
					break;
				case 26:
					break;
				}
				array3 = ((IEnumerable<EleWise.ELMA.Common.Models.WebData>)eAIHySfR8BpvBLjMYMH4(webDataItem)).Select((EleWise.ELMA.Common.Models.WebData d) => (string)_003C_003Ec.xsUsaC8jdNrd4nfOArVw(d)).ToArray();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 25;
		}
	}

	public static WebData Create(EleWise.ELMA.Common.Models.WebData baseData)
	{
		//Discarded unreachable code: IL_006c, IL_007b, IL_008a, IL_0127, IL_0136
		int num = 1;
		int num2 = num;
		WebData webData = default(WebData);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 8:
				e55f6RfRR8FOve4f7g5p(webData, sQjuorfRS6pDl1raKlbt(baseData));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				if (UFr8jlfRiOY7a9x6NAHF(baseData) == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 2;
			case 5:
				return null;
			default:
				webData = new WebData();
				num2 = 6;
				break;
			case 2:
				webData.Items = ((IEnumerable<EleWise.ELMA.Common.Models.WebDataItem>)UFr8jlfRiOY7a9x6NAHF(baseData)).Select(WebDataItem.Create).Cast<EleWise.ELMA.Common.Models.WebDataItem>().ToArray();
				num2 = 7;
				break;
			case 1:
				if (baseData != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 4:
			case 7:
				return webData;
			}
		}
	}

	static WebData()
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					TypeOfObject = yK0u3xfRqWjNbJ7uVtL6(typeof(object).TypeHandle);
					num2 = 2;
					continue;
				case 1:
					return;
				case 6:
					break;
				case 5:
					TypeOfWebData = typeof(WebData);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					TypeOfWebDataArray = yK0u3xfRqWjNbJ7uVtL6(typeof(WebData[]).TypeHandle);
					num2 = 3;
					continue;
				case 2:
					TypeOfObjectArray = typeof(object[]);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					TypeofValue = yK0u3xfRqWjNbJ7uVtL6(typeof(string).TypeHandle);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			ejmZh7ficYgGVaH6HOxB();
			num = 5;
		}
	}

	internal static void ejmZh7ficYgGVaH6HOxB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool bUI2bYfiUvpyApCwJycO()
	{
		return ryaVMXfiL15UA8IfH3wJ == null;
	}

	internal static WebData hK2WsVfisroT2xYyJ3lq()
	{
		return ryaVMXfiL15UA8IfH3wJ;
	}

	internal static object WXr2v3fizkUSqpITB0eh(object P_0)
	{
		return ((SerializationInfo)P_0).GetEnumerator();
	}

	internal static object CyH2LKfRF1saYg7WyMZe(object P_0)
	{
		return ((SerializationInfoEnumerator)P_0).Name;
	}

	internal static void TxnEgEfRBBcnc3kor8Nm(object P_0, object P_1)
	{
		((EleWise.ELMA.Common.Models.WebDataItem)P_0).Name = (string)P_1;
	}

	internal static Type C3js5RfRW6jvx1958Vji(object P_0)
	{
		return ((SerializationInfoEnumerator)P_0).ObjectType;
	}

	internal static bool xCkppwfRoFDmGMcfCrRp(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object ADUhOMfRboJ3KRaruVk7(object P_0, object P_1, Type P_2)
	{
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	internal static void heJKR5fRheD0U3J3nqsR(object P_0, object P_1)
	{
		((EleWise.ELMA.Common.Models.WebDataItem)P_0).Data = (EleWise.ELMA.Common.Models.WebData)P_1;
	}

	internal static void sLpwAifRGOb6kpXZyIS6(object P_0, object P_1)
	{
		((EleWise.ELMA.Common.Models.WebDataItem)P_0).DataArray = (EleWise.ELMA.Common.Models.WebData[])P_1;
	}

	internal static void X9wjkWfREIfAVkBigbx3(object P_0, object P_1)
	{
		((EleWise.ELMA.Common.Models.WebDataItem)P_0).Value = (string)P_1;
	}

	internal static bool HnXCUrfRfsNS6An8RGQh(object P_0)
	{
		return ((SerializationInfoEnumerator)P_0).MoveNext();
	}

	internal static object wiJtF6fRQx3CWIOXhcLG(object P_0)
	{
		return ((List<WebDataItem>)P_0).ToArray();
	}

	internal static object OnsNkDfRCffFClaGCaJT(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebDataItem)P_0).Data;
	}

	internal static object NsuAqHfRvJdVCIOdHIVx(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebDataItem)P_0).Name;
	}

	internal static object eAIHySfR8BpvBLjMYMH4(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebDataItem)P_0).DataArray;
	}

	internal static void mQn2udfRZHAPnVn89fuZ(object P_0, object P_1, object P_2, Type P_3)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2, P_3);
	}

	internal static object lXYJDUfRuLLKbjX7lHGR(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebDataItem)P_0).Value;
	}

	internal static void JbFNhDfRIPD6QYTqrlEC(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static object WesVgdfRVRB3pfosq1yF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sQjuorfRS6pDl1raKlbt(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebData)P_0).Value;
	}

	internal static object UFr8jlfRiOY7a9x6NAHF(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebData)P_0).Items;
	}

	internal static void e55f6RfRR8FOve4f7g5p(object P_0, object P_1)
	{
		((EleWise.ELMA.Common.Models.WebData)P_0).Value = (string)P_1;
	}

	internal static Type yK0u3xfRqWjNbJ7uVtL6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
