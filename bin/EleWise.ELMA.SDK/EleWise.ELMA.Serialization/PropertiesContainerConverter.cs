using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using EleWise.ELMA.Common;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal sealed class PropertiesContainerConverter : JsonConverter
{
	private static PropertiesContainerConverter instance;

	internal static PropertiesContainerConverter kH8sNaBJ4A1jQJKj35K9;

	internal static PropertiesContainerConverter Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			PropertiesContainerConverter propertiesContainerConverter;
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertiesContainerConverter = instance;
					if (propertiesContainerConverter != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					propertiesContainerConverter = (instance = new PropertiesContainerConverter());
					break;
				}
				break;
			}
			return propertiesContainerConverter;
		}
	}

	public override bool CanConvert(Type objectType)
	{
		return TypeOf<PropertiesContainer>.Raw.IsAssignableFrom(objectType);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//Discarded unreachable code: IL_009f, IL_0266, IL_0275, IL_02c9, IL_0301, IL_0310
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0224: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		int num2 = num;
		PropertiesContainer propertiesContainer = default(PropertiesContainer);
		JsonToken val = default(JsonToken);
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		object value2 = default(object);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		Type type = default(Type);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return propertiesContainer;
			default:
				return null;
			case 3:
				if ((int)val == 1)
				{
					propertiesContainer = new PropertiesContainer();
					num2 = 2;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if ((int)val != 11)
				{
					return new PropertiesContainer();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
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
						if (!VB1AkjBJd7PQJr0iZxip(enumerator))
						{
							num3 = 4;
							goto IL_00ad;
						}
						goto IL_0280;
						IL_00ad:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return propertiesContainer;
							case 10:
								if (X8raRpBJxI2btXlbpx1v(current.Key, Xb1iFEBJ7LElbnWGNWrR(-1426094279 ^ -1426134089)))
								{
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto default;
							case 6:
								throw new InvalidOperationException(SR.T((string)Xb1iFEBJ7LElbnWGNWrR(0x2A7797B7 ^ 0x2A76FB2B), value2));
							case 9:
								if (dictionary.TryGetValue((string)Xb1iFEBJ7LElbnWGNWrR(-1979251663 ^ -1979291457), out value2))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto end_IL_00ad;
							case 7:
								break;
							case 1:
								type = f1bxu3BJmZ0V672aNnRm(UWOBmbBJ0N3TcAr16B3p(), null, (string)value2);
								num3 = 7;
								continue;
							case 2:
							case 8:
								goto end_IL_00ad;
							case 5:
							{
								PropertiesContainer propertiesContainer2 = propertiesContainer;
								string key = current.Key;
								string obj = (string)value;
								Type type2 = type;
								JsonSerializerSettings val2 = new JsonSerializerSettings();
								RxRaf7BJMF8XeCgJbgPD((object)val2, (DateFormatHandling)0);
								lsJdraBJ9QYASW3B2Kff(propertiesContainer2, key, null, DZLEKEBJJm4xaod5eMqF(obj, type2, (object)val2));
								num3 = 2;
								continue;
							}
							default:
								if ((dictionary = current.Value as IDictionary<string, object>) != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
									{
										num3 = 9;
									}
									continue;
								}
								goto end_IL_00ad;
							case 3:
								goto IL_0280;
							}
							if (U50oQEBJyM0YOyk9l8My(type, null))
							{
								int num4 = 6;
								num3 = num4;
								continue;
							}
							if (!dictionary.TryGetValue((string)Xb1iFEBJ7LElbnWGNWrR(-812025778 ^ -812043976), out value))
							{
								break;
							}
							num3 = 5;
							continue;
							end_IL_00ad:
							break;
						}
						continue;
						IL_0280:
						current = enumerator.Current;
						num3 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num3 = 8;
						}
						goto IL_00ad;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								CrrfJPBJllQjlAw8JZLf(enumerator);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				enumerator = ((IDictionary<string, object>)serializer.Deserialize(reader, TypeOf<ExpandoObject>.Raw)).GetEnumerator();
				num2 = 5;
				break;
			case 4:
				val = FuQqZpBJABRCjCSyurLy(reader);
				num2 = 3;
				break;
			}
		}
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//Discarded unreachable code: IL_0107, IL_0259, IL_0291
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		PropertiesContainer propertiesContainer = default(PropertiesContainer);
		JObject val2 = default(JObject);
		JObject val = default(JObject);
		object obj = default(object);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				enumerator = propertiesContainer.GetProperties().GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				if ((propertiesContainer = value as PropertiesContainer) != null)
				{
					val2 = new JObject();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 6:
				E8dmwoBJYLvB3I0AKBYP(val2, writer, Array.Empty<JsonConverter>());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				rFv8gFBJrmQUBS4Y5Ujq(val2, (object)new JProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858941649), (object)TypeOf<PropertiesContainer>.Raw.FullName));
				num2 = 5;
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!VB1AkjBJd7PQJr0iZxip(enumerator))
						{
							num3 = 4;
							goto IL_0115;
						}
						goto IL_01be;
						IL_0115:
						while (true)
						{
							switch (num3)
							{
							default:
								val = new JObject();
								num3 = 6;
								continue;
							case 7:
								break;
							case 5:
								((JContainer)val).AddFirst((object)new JProperty((string)Xb1iFEBJ7LElbnWGNWrR(-643786247 ^ -643697289), (object)obj.GetType().FullName));
								num3 = 2;
								continue;
							case 6:
								obj = SAxtWSBJgDtk99Bod4uK(propertiesContainer, current, null);
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
								goto IL_01be;
							case 1:
							{
								xJtHL8BJjl4g0cF2RU2S(val2, current, val);
								int num4 = 7;
								num3 = num4;
								continue;
							}
							case 2:
								val.Add((string)Xb1iFEBJ7LElbnWGNWrR(-675505729 ^ -675491639), (JToken)tUxtvvBJ53IrVo1pTgfP(obj, serializer));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num3 = 1;
								}
								continue;
							case 4:
								goto end_IL_0150;
							}
							break;
						}
						continue;
						IL_01be:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num3 = 0;
						}
						goto IL_0115;
						continue;
						end_IL_0150:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								CrrfJPBJllQjlAw8JZLf(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto case 6;
			case 2:
				return;
			}
		}
	}

	public PropertiesContainerConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PGxN8NBJLOdLEKLX3avr();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kLwq1lBJ6hpv8XlQLeml()
	{
		return kH8sNaBJ4A1jQJKj35K9 == null;
	}

	internal static PropertiesContainerConverter VXPmJWBJHwkQE9MSIDM4()
	{
		return kH8sNaBJ4A1jQJKj35K9;
	}

	internal static JsonToken FuQqZpBJABRCjCSyurLy(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonReader)P_0).get_TokenType();
	}

	internal static object Xb1iFEBJ7LElbnWGNWrR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool X8raRpBJxI2btXlbpx1v(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object UWOBmbBJ0N3TcAr16B3p()
	{
		return KnownTypesBinder.Instance;
	}

	internal static Type f1bxu3BJmZ0V672aNnRm(object P_0, object P_1, object P_2)
	{
		return ((KnownTypesBinder)P_0).BindToType((string)P_1, (string)P_2);
	}

	internal static bool U50oQEBJyM0YOyk9l8My(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void RxRaf7BJMF8XeCgJbgPD(object P_0, DateFormatHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializerSettings)P_0).set_DateFormatHandling(P_1);
	}

	internal static object DZLEKEBJJm4xaod5eMqF(object P_0, Type P_1, object P_2)
	{
		return JsonConvert.DeserializeObject((string)P_0, P_1, (JsonSerializerSettings)P_2);
	}

	internal static void lsJdraBJ9QYASW3B2Kff(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertiesContainer)P_0).SetPropertyValue((string)P_1, (object[])P_2, P_3);
	}

	internal static bool VB1AkjBJd7PQJr0iZxip(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void CrrfJPBJllQjlAw8JZLf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void rFv8gFBJrmQUBS4Y5Ujq(object P_0, object P_1)
	{
		((JContainer)P_0).AddFirst(P_1);
	}

	internal static object SAxtWSBJgDtk99Bod4uK(object P_0, object P_1, object P_2)
	{
		return ((PropertiesContainer)P_0).GetPropertyValue((string)P_1, (object[])P_2);
	}

	internal static object tUxtvvBJ53IrVo1pTgfP(object P_0, object P_1)
	{
		return JToken.FromObject(P_0, (JsonSerializer)P_1);
	}

	internal static void xJtHL8BJjl4g0cF2RU2S(object P_0, object P_1, object P_2)
	{
		((JObject)P_0).Add((string)P_1, (JToken)P_2);
	}

	internal static void E8dmwoBJYLvB3I0AKBYP(object P_0, object P_1, object P_2)
	{
		((JToken)P_0).WriteTo((JsonWriter)P_1, (JsonConverter[])P_2);
	}

	internal static void PGxN8NBJLOdLEKLX3avr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
