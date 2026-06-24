using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web.Script.Serialization;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Serialization;

public class JsonSerializer : JavaScriptSerializer
{
	private class ExpandoObjectConverter : JavaScriptConverter
	{
		internal static object yWmqVtQe1iWlFFOom48h;

		public override IEnumerable<Type> SupportedTypes => new Type[1] { typeof(ExpandoObject) };

		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			ExpandoObject expandoObject = new ExpandoObject();
			IDictionary<string, object> dictionary2 = expandoObject;
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, object> item in dictionary)
				{
					dictionary2[item.Key] = item.Value;
				}
				return expandoObject;
			}
			return expandoObject;
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (obj is ExpandoObject expandoObject)
			{
				{
					foreach (KeyValuePair<string, object> item in (IEnumerable<KeyValuePair<string, object>>)expandoObject)
					{
						dictionary[item.Key] = item.Value;
					}
					return dictionary;
				}
			}
			return dictionary;
		}

		public ExpandoObjectConverter()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			yTLJYkQepkEmpYG4Arqd();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void yTLJYkQepkEmpYG4Arqd()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool JpGN2pQeNJ0h0hRS2SSB()
		{
			return yWmqVtQe1iWlFFOom48h == null;
		}

		internal static ExpandoObjectConverter XNhrdVQe3uB5NBKUDXYa()
		{
			return (ExpandoObjectConverter)yWmqVtQe1iWlFFOom48h;
		}
	}

	private class EntityConverter : JavaScriptConverter
	{
		internal static object TSOEtOQeaaHx1jeGDXfC;

		public override IEnumerable<Type> SupportedTypes => new Type[4]
		{
			typeof(IEntity),
			typeof(Entity<short>),
			typeof(Entity<int>),
			typeof(Entity<long>)
		};

		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			return InterfaceActivator.Create(type);
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			if (obj is IEntity obj2)
			{
				return (IDictionary<string, object>)new EntityJsonSerializer().ConvertToSerializable(obj2);
			}
			return new Dictionary<string, object>();
		}

		public EntityConverter()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			MkfOVxQewiMpGcypKK8r();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void MkfOVxQewiMpGcypKK8r()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool WZqDW2QeDiDt8SMISRmO()
		{
			return TSOEtOQeaaHx1jeGDXfC == null;
		}

		internal static EntityConverter aAmelWQet5rdRdD7M7u5()
		{
			return (EntityConverter)TSOEtOQeaaHx1jeGDXfC;
		}
	}

	internal static JsonSerializer xcu5XSBgCZsVtkUb7soa;

	public JsonSerializer()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected JsonSerializer(JavaScriptTypeResolver resolver)
	{
		//Discarded unreachable code: IL_001f
		qc0WcbBgZr3cgcpJiQWk();
		base._002Ector(resolver);
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				RegisterConverters(new EntityConverter[1]
				{
					new EntityConverter()
				});
				num2 = 4;
				break;
			case 1:
				dTJgZHBgIsoDYeLe1M4U(this, int.MaxValue);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				F7qJLFBguASSW6XRPMJm(this, int.MaxValue);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				RegisterConverters(new ExpandoObjectConverter[1]
				{
					new ExpandoObjectConverter()
				});
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool AjiDqIBgvNbparPwnXFV()
	{
		return xcu5XSBgCZsVtkUb7soa == null;
	}

	internal static JsonSerializer w43SVsBg84nNQnitwUUV()
	{
		return xcu5XSBgCZsVtkUb7soa;
	}

	internal static void qc0WcbBgZr3cgcpJiQWk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void F7qJLFBguASSW6XRPMJm(object P_0, int P_1)
	{
		((JavaScriptSerializer)P_0).MaxJsonLength = P_1;
	}

	internal static void dTJgZHBgIsoDYeLe1M4U(object P_0, int P_1)
	{
		((JavaScriptSerializer)P_0).RecursionLimit = P_1;
	}
}
