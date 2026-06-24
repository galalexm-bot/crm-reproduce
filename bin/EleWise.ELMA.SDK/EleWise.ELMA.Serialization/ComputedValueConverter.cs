using System;
using System.Reflection;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal sealed class ComputedValueConverter : JsonConverter
{
	private static ComputedValueConverter instance;

	internal static ComputedValueConverter RBjmtJBJkVtK7UFUB84r;

	internal static ComputedValueConverter Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			ComputedValueConverter computedValueConverter;
			while (true)
			{
				switch (num2)
				{
				case 1:
					computedValueConverter = instance;
					if (computedValueConverter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					computedValueConverter = (instance = new ComputedValueConverter());
					break;
				}
				break;
			}
			return computedValueConverter;
		}
	}

	public override bool CanConvert(Type objectType)
	{
		return TypeOf<ComputedValue>.Raw.IsAssignableFrom(objectType);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c9: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		ComputedValue computedValue = default(ComputedValue);
		JsonToken val = default(JsonToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return null;
				case 6:
					return computedValue;
				case 1:
					break;
				case 2:
				{
					if ((int)val != 1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 0;
						}
						continue;
					}
					JsonSerializer val2 = new JsonSerializer();
					y50oyTBJPsdJSSx8JjHv((object)val2, HMDv6EBJeEUu8QG2iMEc());
					Rek7TfBJ1GaVd40fWlLL((object)val2, (TypeNameHandling)1);
					computedValue = (ComputedValue)l4InQiBJN4B5uCcXxPoX((object)val2, reader, objectType);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				default:
					if ((int)val != 11)
					{
						return new ComputedValue();
					}
					num2 = 5;
					continue;
				case 5:
					return null;
				case 3:
					val = YjAaKIBJ25CC7nTZmZt6(reader);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			if (computedValue != null)
			{
				computedValue.Value = MapValue(computedValue);
				num = 6;
			}
			else
			{
				num = 4;
			}
		}
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		int num = 3;
		ComputedValue computedValue = default(ComputedValue);
		ActionValue actionValue = default(ActionValue);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 5:
				{
					JsonSerializer val = new JsonSerializer();
					y50oyTBJPsdJSSx8JjHv((object)val, HMDv6EBJeEUu8QG2iMEc());
					Rek7TfBJ1GaVd40fWlLL((object)val, (TypeNameHandling)1);
					val.Serialize(writer, (object)computedValue);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 3:
					if (value != null)
					{
						goto end_IL_0012;
					}
					num2 = 2;
					break;
				case 1:
					AY4FyKBJaReshrceAKVW(computedValue, mwolXjBJpIhMfNic5wc0(actionValue));
					num2 = 5;
					break;
				case 0:
					return;
				case 4:
					if ((actionValue = XgEDrvBJ3bmlfth62GV3(computedValue) as ActionValue) != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			computedValue = (ComputedValue)value;
			num = 4;
		}
	}

	private static object MapValue(object source)
	{
		//Discarded unreachable code: IL_0050, IL_0074, IL_0083, IL_0117
		int num = 8;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return JsonConvert.DeserializeObject<ActionValue>(text);
			case 1:
				return text;
			case 7:
				if (text == null)
				{
					num2 = 2;
					break;
				}
				if (!Ts9ObPBJDC9RTt26srZK(text))
				{
					num2 = 4;
					break;
				}
				goto default;
			default:
				return null;
			case 4:
				if (!(source is ActionInputComputedValue))
				{
					num2 = 5;
					break;
				}
				goto case 6;
			case 2:
				return null;
			case 6:
				return JsonConvert.DeserializeObject<ActionValue>(text);
			case 5:
				if (!text.Contains((string)KZN9J5BJtkpF8W71r0WF(-787452571 ^ -787414773)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 8:
				text = XgEDrvBJ3bmlfth62GV3(source) as string;
				num2 = 7;
				break;
			}
		}
	}

	public ComputedValueConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		o1fB1MBJw1xabtdvc5aj();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool gQfT32BJn8p82MKxq7UO()
	{
		return RBjmtJBJkVtK7UFUB84r == null;
	}

	internal static ComputedValueConverter XtVxwuBJOXdajSpAfvRK()
	{
		return RBjmtJBJkVtK7UFUB84r;
	}

	internal static JsonToken YjAaKIBJ25CC7nTZmZt6(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonReader)P_0).get_TokenType();
	}

	internal static object HMDv6EBJeEUu8QG2iMEc()
	{
		return KnownTypesBinder.Instance;
	}

	internal static void y50oyTBJPsdJSSx8JjHv(object P_0, object P_1)
	{
		((JsonSerializer)P_0).set_SerializationBinder((ISerializationBinder)P_1);
	}

	internal static void Rek7TfBJ1GaVd40fWlLL(object P_0, TypeNameHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializer)P_0).set_TypeNameHandling(P_1);
	}

	internal static object l4InQiBJN4B5uCcXxPoX(object P_0, object P_1, Type P_2)
	{
		return ((JsonSerializer)P_0).Deserialize((JsonReader)P_1, P_2);
	}

	internal static object XgEDrvBJ3bmlfth62GV3(object P_0)
	{
		return ((ComputedValue)P_0).Value;
	}

	internal static object mwolXjBJpIhMfNic5wc0(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static void AY4FyKBJaReshrceAKVW(object P_0, object P_1)
	{
		((ComputedValue)P_0).Value = P_1;
	}

	internal static bool Ts9ObPBJDC9RTt26srZK(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object KZN9J5BJtkpF8W71r0WF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void o1fB1MBJw1xabtdvc5aj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
