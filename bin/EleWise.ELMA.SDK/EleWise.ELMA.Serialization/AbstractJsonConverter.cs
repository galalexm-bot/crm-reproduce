using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal sealed class AbstractJsonConverter : JsonConverter
{
	private static AbstractJsonConverter instance;

	internal static AbstractJsonConverter llc2VCB9RrrTwseXLxsR;

	internal static AbstractJsonConverter Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			AbstractJsonConverter abstractJsonConverter;
			while (true)
			{
				switch (num2)
				{
				case 1:
					abstractJsonConverter = instance;
					if (abstractJsonConverter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					abstractJsonConverter = (instance = new AbstractJsonConverter());
					break;
				}
				break;
			}
			return abstractJsonConverter;
		}
	}

	public override bool CanWrite => false;

	public override bool CanConvert(Type objectType)
	{
		return objectType.IsAbstract;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		JObject val = default(JObject);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return obj;
			case 1:
				val = (JObject)uKohR3B9XtQqIhfu0e5Y(reader);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				obj = yl0uIDB9TCVUQLkMSQNp(val);
				num2 = 3;
				break;
			case 3:
				serializer.Populate((JsonReader)devlb3B9kah7ST3pfeeN(val), obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	private static object Create(object jObject)
	{
		int num = 3;
		int num2 = num;
		string item = default(string);
		Type type = default(Type);
		string item2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				throw new InvalidOperationException(SR.T((string)D0riiAB9ParvxYLlhtOE(-672123589 ^ -672048271), item));
			case 2:
				if (lp9InmB9n1hxaxYfXNMO(item))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				}
				type = HrDZTBB92WtnVyLrSgHL(wQr2gtB9OkTqSZK7JX62(), item2, item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!iCjHUXB9ehm30lPjqDPq(type, null))
				{
					return InterfaceActivator.Create(type);
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
			{
				(string, string) itemTypeString = GetItemTypeString(jObject);
				item = itemTypeString.Item1;
				item2 = itemTypeString.Item2;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
				return null;
			}
		}
	}

	private static (string, string) GetItemTypeString(object jObject)
	{
		JToken val = default(JToken);
		if (((JObject)jObject).TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195672677), ref val))
		{
			string text = Extensions.Value<string>((IEnumerable<JToken>)val);
			if (!string.IsNullOrWhiteSpace(text))
			{
				string[] array = text.Split(',');
				if (array.Length > 1)
				{
					return (array[0], array[1]);
				}
				return (text, string.Empty);
			}
		}
		return (string.Empty, string.Empty);
	}

	public AbstractJsonConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WkVOdoB9qq66M28Od5l6()
	{
		return llc2VCB9RrrTwseXLxsR == null;
	}

	internal static AbstractJsonConverter bpLcodB9KZQBSgmRH2Mo()
	{
		return llc2VCB9RrrTwseXLxsR;
	}

	internal static object uKohR3B9XtQqIhfu0e5Y(object P_0)
	{
		return JObject.Load((JsonReader)P_0);
	}

	internal static object yl0uIDB9TCVUQLkMSQNp(object P_0)
	{
		return Create(P_0);
	}

	internal static object devlb3B9kah7ST3pfeeN(object P_0)
	{
		return ((JToken)P_0).CreateReader();
	}

	internal static bool lp9InmB9n1hxaxYfXNMO(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object wQr2gtB9OkTqSZK7JX62()
	{
		return KnownTypesBinder.Instance;
	}

	internal static Type HrDZTBB92WtnVyLrSgHL(object P_0, object P_1, object P_2)
	{
		return ((KnownTypesBinder)P_0).BindToType((string)P_1, (string)P_2);
	}

	internal static bool iCjHUXB9ehm30lPjqDPq(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object D0riiAB9ParvxYLlhtOE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
