using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemTransformationSerializer : JsonSerializer
{
	private class FormViewItemTransformationConverter : JavaScriptConverter
	{
		internal static object Iu5nHpCCtwpWSHxXMq5X;

		public override IEnumerable<Type> SupportedTypes => new Type[1] { typeof(FormViewItemTransformation) };

		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.serializer = serializer;
			CS_0024_003C_003E8__locals0.transformation = (FormViewItemTransformation)Activator.CreateInstance(type);
			if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12465D)))
			{
				CS_0024_003C_003E8__locals0.transformation.Uid = new Guid(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51156D8F)].ToString());
			}
			if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538754318)))
			{
				CS_0024_003C_003E8__locals0.transformation.NewFormUid = new Guid(dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978709521)].ToString());
			}
			if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112410006)))
			{
				CS_0024_003C_003E8__locals0.transformation.FormName = (string)dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822589724)];
			}
			if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36356871)))
			{
				CS_0024_003C_003E8__locals0.transformation.NewFormDisplayName = (string)dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69837795)];
			}
			if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459261415)))
			{
				CS_0024_003C_003E8__locals0.transformation.NewFormName = (string)dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE17B2F7)];
			}
			if (dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767893991)))
			{
				((IEnumerable)dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA7EDDE)]).Cast<object>().Each(delegate(object i)
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
							CS_0024_003C_003E8__locals0.transformation.Items.Add(CS_0024_003C_003E8__locals0.serializer.ConvertToType<ViewItemTransformation>(i));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				});
			}
			return CS_0024_003C_003E8__locals0.transformation;
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (obj is FormViewItemTransformation formViewItemTransformation)
			{
				if (formViewItemTransformation.Uid != Guid.Empty)
				{
					dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1637ABBB)] = formViewItemTransformation.Uid.ToString();
				}
				if (formViewItemTransformation.NewFormUid != Guid.Empty)
				{
					dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A49E1CD)] = formViewItemTransformation.NewFormUid.ToString();
				}
				if (!string.IsNullOrEmpty(formViewItemTransformation.FormName))
				{
					dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E99644)] = formViewItemTransformation.FormName;
				}
				if (!string.IsNullOrEmpty(formViewItemTransformation.NewFormDisplayName))
				{
					dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x7684F9E)] = formViewItemTransformation.NewFormDisplayName;
				}
				if (!string.IsNullOrEmpty(formViewItemTransformation.NewFormName))
				{
					dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998246910)] = formViewItemTransformation.NewFormName;
				}
				if (formViewItemTransformation.Items.Any())
				{
					dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477249480)] = formViewItemTransformation.Items;
				}
			}
			return dictionary;
		}

		public FormViewItemTransformationConverter()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			vFboewCC6DaVdWtkxxxj();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void vFboewCC6DaVdWtkxxxj()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool W6waurCCwK5EeTXvhHJO()
		{
			return Iu5nHpCCtwpWSHxXMq5X == null;
		}

		internal static FormViewItemTransformationConverter nytYxxCC41GXXnw0lKMQ()
		{
			return (FormViewItemTransformationConverter)Iu5nHpCCtwpWSHxXMq5X;
		}
	}

	private class FormViewItemConverter : JavaScriptConverter
	{
		private static object IFPyF1CCHu5ArX61dWwe;

		public override IEnumerable<Type> SupportedTypes => new Type[1] { typeof(ViewItem) };

		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.serializer = serializer;
			ViewItem viewItem = (ViewItem)Activator.CreateInstance(type);
			foreach (PropertyInfo item in from p in viewItem.GetType().GetProperties()
				where AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null
				select p)
			{
				if (item.CanWrite && dictionary.ContainsKey(item.Name))
				{
					item.SetValue(viewItem, CS_0024_003C_003E8__locals0.serializer.ConvertToType(dictionary[item.Name], item.PropertyType), null);
				}
			}
			CS_0024_003C_003E8__locals0.rootViewItem = viewItem as RootViewItem;
			if (CS_0024_003C_003E8__locals0.rootViewItem != null && dictionary.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x163569CB)))
			{
				((IEnumerable)dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108136964)]).Cast<object>().Each(delegate(object i)
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							((EventedList<ViewItem>)_003C_003Ec__DisplayClass2_0.nX6iN1ZIYuDOTmvYOcWW(CS_0024_003C_003E8__locals0.rootViewItem)).Add(CS_0024_003C_003E8__locals0.serializer.ConvertToType<ViewItem>(i));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num2 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
			}
			return viewItem;
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
			if (!(obj is ViewItem viewItem))
			{
				return dictionary;
			}
			foreach (PropertyInfo item in (from p in viewItem.GetType().GetProperties()
				where AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null
				select p).ToList())
			{
				if (!item.CanRead)
				{
					continue;
				}
				DefaultValueAttribute attribute = AttributeHelper<DefaultValueAttribute>.GetAttribute(item, inherited: true);
				object value = item.GetValue(viewItem, null);
				Func<object, object, bool> func = delegate(object v1, object v2)
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
							if (v1 != null)
							{
								return v1.Equals(v2);
							}
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num2 = 0;
							}
							break;
						default:
							return v2 == null;
						}
					}
				};
				if ((attribute == null || !func(attribute.Value, value)) && (!(value is IEnumerable) || ((IEnumerable)value).Cast<object>().Any()))
				{
					dictionary[item.Name] = value;
				}
				dictionary2[item.Name] = value;
			}
			return dictionary;
		}

		public FormViewItemConverter()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			GPnMavCCxw8xW90LLNyY();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void GPnMavCCxw8xW90LLNyY()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool HcHASECCAvO1Ly4YnUnR()
		{
			return IFPyF1CCHu5ArX61dWwe == null;
		}

		internal static FormViewItemConverter vcEy4ZCC7pen50tfA52N()
		{
			return (FormViewItemConverter)IFPyF1CCHu5ArX61dWwe;
		}
	}

	private class CustomTypeResolver : SimpleTypeResolver
	{
		internal static object pyGeEcCC0KPArJ9pMgvG;

		public override Type ResolveType(string id)
		{
			return base.ResolveType(id);
		}

		public override string ResolveTypeId(Type type)
		{
			return base.ResolveTypeId(type);
		}

		public CustomTypeResolver()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			PdfJLECCMPCuVJvxjM5m();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool SKwaNECCmG4Is23AiHXt()
		{
			return pyGeEcCC0KPArJ9pMgvG == null;
		}

		internal static CustomTypeResolver uNv5GuCCyPwLwyq3mgKh()
		{
			return (CustomTypeResolver)pyGeEcCC0KPArJ9pMgvG;
		}

		internal static void PdfJLECCMPCuVJvxjM5m()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static ViewItemTransformationSerializer vwLx7So1D0IkKWQ4lSks;

	public ViewItemTransformationSerializer()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		lShH75o14LpO7MZJCKZ6();
		base._002Ector(new CustomTypeResolver());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			RegisterConverters(new JavaScriptConverter[2]
			{
				new FormViewItemTransformationConverter(),
				new FormViewItemConverter()
			});
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
			{
				num = 1;
			}
		}
	}

	internal static void lShH75o14LpO7MZJCKZ6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool SCtYCWo1tcj387QBAFPI()
	{
		return vwLx7So1D0IkKWQ4lSks == null;
	}

	internal static ViewItemTransformationSerializer Gk4KSIo1wVWDed5DS1YO()
	{
		return vwLx7So1D0IkKWQ4lSks;
	}
}
