using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;

namespace EleWise.ELMA.Serialization;

internal sealed class SimpleTypesConverter : JsonConverter
{
	private static SimpleTypesConverter instance;

	private readonly ConcurrentDictionary<Type, bool> canConvert;

	internal static SimpleTypesConverter IwsuFKB9Ach9pUMrwhSF;

	internal static SimpleTypesConverter Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			SimpleTypesConverter simpleTypesConverter;
			while (true)
			{
				switch (num2)
				{
				case 1:
					simpleTypesConverter = instance;
					if (simpleTypesConverter != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					simpleTypesConverter = (instance = new SimpleTypesConverter());
					break;
				}
				break;
			}
			return simpleTypesConverter;
		}
	}

	public override bool CanRead => false;

	public override bool CanConvert(Type objectType)
	{
		return canConvert.GetOrAdd(objectType, delegate(Type t)
		{
			//Discarded unreachable code: IL_006b, IL_007a
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!_003C_003Ec.qZWFrkQ2obSy1jLFfB94(t))
					{
						return false;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					if (_003C_003Ec.cgyS7DQ2WPAFaffMEqrh(t))
					{
						num2 = 2;
						break;
					}
					goto default;
				case 1:
					return t.GetGenericArguments()[0].IsSimpleType();
				case 2:
					return true;
				}
			}
		});
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return null;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		int num = 1;
		int num2 = num;
		TypeConverter typeConverter = default(TypeConverter);
		while (true)
		{
			switch (num2)
			{
			default:
				BLGJ6nB9yg8tCMSbRYPR(writer, rJvyULB9mNdEEiGLoEOi(typeConverter, value));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				typeConverter = (TypeConverter)W325K3B90CVDgrcFOYFq(value.GetType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public SimpleTypesConverter()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SgAr8hB9MWWOtFlk3pX3();
		canConvert = new ConcurrentDictionary<Type, bool>();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool GVYeJQB97gcPSWWSVetZ()
	{
		return IwsuFKB9Ach9pUMrwhSF == null;
	}

	internal static SimpleTypesConverter MbWHjkB9xRr9E0LCSlLG()
	{
		return IwsuFKB9Ach9pUMrwhSF;
	}

	internal static object W325K3B90CVDgrcFOYFq(Type P_0)
	{
		return TypeDescriptor.GetConverter(P_0);
	}

	internal static object rJvyULB9mNdEEiGLoEOi(object P_0, object P_1)
	{
		return ((TypeConverter)P_0).ConvertToInvariantString(P_1);
	}

	internal static void BLGJ6nB9yg8tCMSbRYPR(object P_0, object P_1)
	{
		((JsonWriter)P_0).WriteValue((string)P_1);
	}

	internal static void SgAr8hB9MWWOtFlk3pX3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
