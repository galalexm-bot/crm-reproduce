using System;
using System.Web.Mvc;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;

namespace EleWise.ELMA.Diagnostics.Serialization;

public class MvcHtmlStringJsonConverter : JsonConverter
{
	public static MvcHtmlStringJsonConverter Instance;

	private static MvcHtmlStringJsonConverter zfH0KDEhhdaeQ0mTsnPI;

	public override bool CanConvert(Type objectType)
	{
		return FmOWaREhf50njrMeNZft(typeof(MvcHtmlString).TypeHandle).IsAssignableFrom(objectType);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return MvcHtmlString.Create(text);
			case 1:
				if (!QXcjLHEhCVIcGr9Jx2aM(typeof(MvcHtmlString), objectType))
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				text = hoIHVlEhQXR7iaw00PjJ(reader) as string;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		int num = 2;
		int num2 = num;
		MvcHtmlString val = default(MvcHtmlString);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				O6dXmhEhvvH3IrqFoMh8(writer, ((object)val).ToString());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				val = (MvcHtmlString)((value is MvcHtmlString) ? value : null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (value == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public MvcHtmlStringJsonConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		V8ZRUvEh8UghsA4EQtlv();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MvcHtmlStringJsonConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				Instance = new MvcHtmlStringJsonConverter();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				V8ZRUvEh8UghsA4EQtlv();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type FmOWaREhf50njrMeNZft(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool DPXIZiEhGqGTAM3pY0fU()
	{
		return zfH0KDEhhdaeQ0mTsnPI == null;
	}

	internal static MvcHtmlStringJsonConverter cE87jEEhEM48eEy6iwhW()
	{
		return zfH0KDEhhdaeQ0mTsnPI;
	}

	internal static object hoIHVlEhQXR7iaw00PjJ(object P_0)
	{
		return ((JsonReader)P_0).get_Value();
	}

	internal static bool QXcjLHEhCVIcGr9Jx2aM(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void O6dXmhEhvvH3IrqFoMh8(object P_0, object P_1)
	{
		((JsonWriter)P_0).WriteValue((string)P_1);
	}

	internal static void V8ZRUvEh8UghsA4EQtlv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
