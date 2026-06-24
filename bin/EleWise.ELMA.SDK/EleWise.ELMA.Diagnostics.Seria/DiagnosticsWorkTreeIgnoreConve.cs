using System;
using System.Collections.Generic;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EleWise.ELMA.Diagnostics.Serialization;

public class DiagnosticsWorkTreeIgnoreConverter : JsonConverter
{
	public static DiagnosticsWorkTreeIgnoreConverter Instance;

	private static DiagnosticsWorkTreeIgnoreConverter cnTqihEb0Okn5VRTBL40;

	public override bool CanRead => false;

	public override bool CanConvert(Type objectType)
	{
		return TypeOf<IEnumerable<IWorkTreeElement>>.Raw.IsAssignableFrom(objectType);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
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
				iOWb37EbJtyNRCXlj3UQ(yfvK2VEbMSUm5vwqaxNu(new object[0]), writer, Array.Empty<JsonConverter>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DiagnosticsWorkTreeIgnoreConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pfXkYhEb9ypOD8gAJOEI();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DiagnosticsWorkTreeIgnoreConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Instance = new DiagnosticsWorkTreeIgnoreConverter();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool doshMpEbm2y8X4ywls0K()
	{
		return cnTqihEb0Okn5VRTBL40 == null;
	}

	internal static DiagnosticsWorkTreeIgnoreConverter oFN0ZwEbyqJyaNBPthJN()
	{
		return cnTqihEb0Okn5VRTBL40;
	}

	internal static object yfvK2VEbMSUm5vwqaxNu(object P_0)
	{
		return JArray.FromObject(P_0);
	}

	internal static void iOWb37EbJtyNRCXlj3UQ(object P_0, object P_1, object P_2)
	{
		((JToken)P_0).WriteTo((JsonWriter)P_1, (JsonConverter[])P_2);
	}

	internal static void pfXkYhEb9ypOD8gAJOEI()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
