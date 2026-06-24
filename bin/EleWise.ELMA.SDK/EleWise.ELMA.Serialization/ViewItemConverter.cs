using System;
using System.Collections.ObjectModel;
using System.Reflection;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EleWise.ELMA.Serialization;

internal sealed class ViewItemConverter : JsonConverter
{
	private static ViewItemConverter instance;

	private static ViewItemConverter B3Oiu0BdVd9QcMUnQ69o;

	internal static ViewItemConverter Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			ViewItemConverter viewItemConverter;
			while (true)
			{
				switch (num2)
				{
				case 1:
					viewItemConverter = instance;
					if (viewItemConverter != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					viewItemConverter = (instance = new ViewItemConverter());
					break;
				}
				break;
			}
			return viewItemConverter;
		}
	}

	public override bool CanRead => false;

	public override bool CanConvert(Type objectType)
	{
		return TypeOf<ViewItem>.Raw.IsAssignableFrom(objectType);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return null;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				JsonSerializer val = new JsonSerializer();
				X4HBepBdqc9Mndp5cnOc((object)val, eJSJuABdRqfwvDfwElUP());
				vi8amJBdKWWWlCTfScRI((object)val, new XmlContractResolver());
				NUOQFhBdXANUdXhtZVLh((object)val, (TypeNameHandling)1);
				xirclMBdTT81Hfs2db4X((object)val, (DateFormatHandling)0);
				HsQMnRBdkQyfUqQ0mE8Z((object)val, (ReferenceLoopHandling)1);
				((Collection<JsonConverter>)vFLhJuBdnxYkWHt5stCj((object)val)).Add((JsonConverter)(object)SimpleTypesConverter.Instance);
				((Collection<JsonConverter>)vFLhJuBdnxYkWHt5stCj((object)val)).Add((JsonConverter)QNtvdCBdO51RGSnERdFx());
				((Collection<JsonConverter>)(object)val.get_Converters()).Add((JsonConverter)k2lALDBd2hSlslh2HMqK());
				((Collection<JsonConverter>)(object)val.get_Converters()).Add((JsonConverter)W4yBqFBdeOn2lotlgUdf());
				YBxg9rBdPdyuNIkmTefC((object)val, writer, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	public ViewItemConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WdSpVcBd1OMWBATsqsMe();
		((JsonConverter)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool bF81lLBdSfMVGpBqUc5I()
	{
		return B3Oiu0BdVd9QcMUnQ69o == null;
	}

	internal static ViewItemConverter BlxWOPBdikxOtABwRBMc()
	{
		return B3Oiu0BdVd9QcMUnQ69o;
	}

	internal static object eJSJuABdRqfwvDfwElUP()
	{
		return KnownTypesBinder.Instance;
	}

	internal static void X4HBepBdqc9Mndp5cnOc(object P_0, object P_1)
	{
		((JsonSerializer)P_0).set_SerializationBinder((ISerializationBinder)P_1);
	}

	internal static void vi8amJBdKWWWlCTfScRI(object P_0, object P_1)
	{
		((JsonSerializer)P_0).set_ContractResolver((IContractResolver)P_1);
	}

	internal static void NUOQFhBdXANUdXhtZVLh(object P_0, TypeNameHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializer)P_0).set_TypeNameHandling(P_1);
	}

	internal static void xirclMBdTT81Hfs2db4X(object P_0, DateFormatHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializer)P_0).set_DateFormatHandling(P_1);
	}

	internal static void HsQMnRBdkQyfUqQ0mE8Z(object P_0, ReferenceLoopHandling P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((JsonSerializer)P_0).set_ReferenceLoopHandling(P_1);
	}

	internal static object vFLhJuBdnxYkWHt5stCj(object P_0)
	{
		return ((JsonSerializer)P_0).get_Converters();
	}

	internal static object QNtvdCBdO51RGSnERdFx()
	{
		return AbstractJsonConverter.Instance;
	}

	internal static object k2lALDBd2hSlslh2HMqK()
	{
		return ComputedValueConverter.Instance;
	}

	internal static object W4yBqFBdeOn2lotlgUdf()
	{
		return PropertiesContainerConverter.Instance;
	}

	internal static void YBxg9rBdPdyuNIkmTefC(object P_0, object P_1, object P_2)
	{
		((JsonSerializer)P_0).Serialize((JsonWriter)P_1, P_2);
	}

	internal static void WdSpVcBd1OMWBATsqsMe()
	{
		SingletonReader.PushGlobal();
	}
}
