using System;
using System.Linq;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Serialization;

public class DiagnosticsMethodInfoConverter : JsonConverter
{
	public static DiagnosticsMethodInfoConverter Instance;

	private static DiagnosticsMethodInfoConverter LBOdo9Ebd3dGe1pOR0Bw;

	public override bool CanRead => false;

	public override bool CanConvert(Type objectType)
	{
		return TypeOf<MethodInfo>.Raw.IsAssignableFrom(objectType);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//Discarded unreachable code: IL_00bc, IL_00f2, IL_0155
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_023b: Expected O, but got Unknown
		int num = 2;
		ParameterInfo[] parameters = default(ParameterInfo[]);
		MethodInfo methodInfo = default(MethodInfo);
		JObject val2 = default(JObject);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					if (parameters.Length == 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 11;
				case 9:
					parameters = methodInfo.GetParameters();
					num2 = 7;
					continue;
				case 4:
				case 6:
					if (!ToAu8yEhB2WkHgUe15M2(methodInfo))
					{
						num = 5;
						break;
					}
					goto case 12;
				case 8:
					return;
				case 5:
				case 10:
					eSjoMmEhoXxc7YRKoY7y(val2, writer, Array.Empty<JsonConverter>());
					num2 = 8;
					continue;
				case 1:
					if (!gvsf76Ebg6K56Hd1hlH9(methodInfo, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					methodInfo = value as MethodInfo;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					y4PX0OEbcb9UFEyre6uD(val2, ou9wjhEbYmAwv4OwEbDs(-210725949 ^ -210453489), zSrOHVEhFBTluFvo0N2W(eU4yQwEhWhVvG3MEFyHI(methodInfo)));
					num = 10;
					break;
				case 3:
					return;
				default:
				{
					JObject val = new JObject();
					val.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103F9AB5), (JToken)rHxMaJEbjOI5lNuLmfuO(exskctEb5NQrSqbpUhfd(methodInfo)));
					val.Add((string)ou9wjhEbYmAwv4OwEbDs(0x35C0467B ^ 0x35C1F62B), JToken.FromObject((OlLYgfEbLeWeYmVAXwcy(methodInfo) != null) ? OXaZ2xEbUO2RS5cx2kjK(OlLYgfEbLeWeYmVAXwcy(methodInfo).Assembly) : ""));
					y4PX0OEbcb9UFEyre6uD((object)val, ou9wjhEbYmAwv4OwEbDs(0xD3DEF7E ^ 0xD3C577C), JToken.FromObject((object)(LHR4hwEbsfb9C6Oe52UH(methodInfo.DeclaringType, null) ? OlLYgfEbLeWeYmVAXwcy(methodInfo).FullName : "")));
					y4PX0OEbcb9UFEyre6uD((object)val, ou9wjhEbYmAwv4OwEbDs(0x463A0F3C ^ 0x463E2088), rHxMaJEbjOI5lNuLmfuO(HaxgXqEbzNCTP8Brsfa5(methodInfo).FullName));
					val2 = val;
					num = 9;
					break;
				}
				case 11:
					y4PX0OEbcb9UFEyre6uD(val2, ou9wjhEbYmAwv4OwEbDs(-889460160 ^ -889208548), zSrOHVEhFBTluFvo0N2W(parameters.Select((ParameterInfo p) => new
					{
						Name = p.Name,
						Type = p.ParameterType
					})));
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public DiagnosticsMethodInfoConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sSsLcZEhbI4s7Z0HN8UA();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DiagnosticsMethodInfoConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Instance = new DiagnosticsMethodInfoConverter();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				sSsLcZEhbI4s7Z0HN8UA();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool iC2SSEEbl1JeenM1HoTD()
	{
		return LBOdo9Ebd3dGe1pOR0Bw == null;
	}

	internal static DiagnosticsMethodInfoConverter IhCOQ0EbrylycCIuPBrn()
	{
		return LBOdo9Ebd3dGe1pOR0Bw;
	}

	internal static bool gvsf76Ebg6K56Hd1hlH9(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object exskctEb5NQrSqbpUhfd(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object rHxMaJEbjOI5lNuLmfuO(object P_0)
	{
		return JToken.FromObject(P_0);
	}

	internal static object ou9wjhEbYmAwv4OwEbDs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type OlLYgfEbLeWeYmVAXwcy(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object OXaZ2xEbUO2RS5cx2kjK(object P_0)
	{
		return ((Assembly)P_0).FullName;
	}

	internal static bool LHR4hwEbsfb9C6Oe52UH(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static void y4PX0OEbcb9UFEyre6uD(object P_0, object P_1, object P_2)
	{
		((JObject)P_0).Add((string)P_1, (JToken)P_2);
	}

	internal static Type HaxgXqEbzNCTP8Brsfa5(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static object zSrOHVEhFBTluFvo0N2W(object P_0)
	{
		return JArray.FromObject(P_0);
	}

	internal static bool ToAu8yEhB2WkHgUe15M2(object P_0)
	{
		return ((MethodBase)P_0).IsGenericMethod;
	}

	internal static object eU4yQwEhWhVvG3MEFyHI(object P_0)
	{
		return ((MethodBase)P_0).GetGenericArguments();
	}

	internal static void eSjoMmEhoXxc7YRKoY7y(object P_0, object P_1, object P_2)
	{
		((JToken)P_0).WriteTo((JsonWriter)P_1, (JsonConverter[])P_2);
	}

	internal static void sSsLcZEhbI4s7Z0HN8UA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
