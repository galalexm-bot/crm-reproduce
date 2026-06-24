using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Settings;

public static class TypeSettingsSerializer
{
	private class DictionarySerializer
	{
		public class PropertyDescriptor
		{
			internal static PropertyDescriptor pllRRbZVCR6yFaCbsSf1;

			public PropertyInfo Property
			{
				[CompilerGenerated]
				get
				{
					return _003CProperty_003Ek__BackingField;
				}
				[CompilerGenerated]
				set
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
							_003CProperty_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num2 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			}

			public string Name
			{
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
				}
				[CompilerGenerated]
				set
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
							_003CName_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num2 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			}

			public Type Type
			{
				[CompilerGenerated]
				get
				{
					return _003CType_003Ek__BackingField;
				}
				[CompilerGenerated]
				set
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
							_003CType_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public DefaultValueAttribute DefaultValueAttribute
			{
				[CompilerGenerated]
				get
				{
					return _003CDefaultValueAttribute_003Ek__BackingField;
				}
				[CompilerGenerated]
				set
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
							_003CDefaultValueAttribute_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public bool JsonIgnore
			{
				[CompilerGenerated]
				get
				{
					return _003CJsonIgnore_003Ek__BackingField;
				}
				[CompilerGenerated]
				set
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
							_003CJsonIgnore_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public Func<string> DisplayNameAccessor { get; set; }

			public Func<string> DescriptionAccessor { get; set; }

			public PropertyDescriptor()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool i7B9VBZVvW5NepoVhT5D()
			{
				return pllRRbZVCR6yFaCbsSf1 == null;
			}

			internal static PropertyDescriptor TVIi49ZV8Rj7CgmxiK6i()
			{
				return pllRRbZVCR6yFaCbsSf1;
			}
		}

		private Type _type;

		private List<PropertyDescriptor> _propertyInfos;

		private static object ppMZ6JCqwLYHWFQds81s;

		public DictionarySerializer(Type type)
		{
			//Discarded unreachable code: IL_003a, IL_02ba, IL_02c9, IL_0333, IL_0342, IL_0363, IL_0372, IL_0382, IL_0395, IL_03a4, IL_03b3, IL_04a9, IL_04b8, IL_054f, IL_055e, IL_0635, IL_0644, IL_06aa, IL_06b9
			SingletonReader.JJCZtPuTvSt();
			_propertyInfos = new List<PropertyDescriptor>();
			base._002Ector();
			int num = 43;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
			{
				num = 17;
			}
			XmlAttributeAttribute attribute2 = default(XmlAttributeAttribute);
			PropertyDescriptor propertyDescriptor = default(PropertyDescriptor);
			PropertyInfo propertyInfo = default(PropertyInfo);
			PropertyInfo[] array = default(PropertyInfo[]);
			int num3 = default(int);
			string text = default(string);
			DefaultValueAttribute defaultValueAttribute = default(DefaultValueAttribute);
			_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
			XmlElementAttribute attribute = default(XmlElementAttribute);
			_003C_003Ec__DisplayClass0_2 _003C_003Ec__DisplayClass0_3 = default(_003C_003Ec__DisplayClass0_2);
			_003C_003Ec__DisplayClass0_1 _003C_003Ec__DisplayClass0_2 = default(_003C_003Ec__DisplayClass0_1);
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					if (pyHu61CqyCiXjHGGuW9n(B2agQaCqMuchhti6GlqX(attribute2)))
					{
						num = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num = 24;
						}
						break;
					}
					goto case 37;
				case 10:
				case 32:
				case 33:
					_propertyInfos.Add(propertyDescriptor);
					num = 2;
					break;
				case 15:
				case 39:
					propertyInfo = array[num3];
					num2 = 45;
					goto IL_003f;
				case 29:
				{
					PropertyDescriptor propertyDescriptor2 = new PropertyDescriptor();
					d67lSOCq9hrp17pabFgx(propertyDescriptor2, propertyInfo);
					NYxFlkCqd0y3W80osm1R(propertyDescriptor2, text);
					fXkZIgCql1lubCuFxaK8(propertyDescriptor2, propertyInfo.PropertyType);
					propertyDescriptor2.DefaultValueAttribute = defaultValueAttribute;
					O4qeAbCqrZhNUn1Fw2sr(propertyDescriptor2, gg2EEcCqApfcsyAQHJxw(propertyInfo, fZWLo5CqxcGTEIKNNY06(typeof(JsonSerializationIgnoreAttribute).TypeHandle), true));
					propertyDescriptor = propertyDescriptor2;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num = 30;
					}
					break;
				}
				case 42:
					propertyDescriptor.DisplayNameAccessor = _003C_003Ec__DisplayClass0_._003C_002Ector_003Eb__0;
					num = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num = 14;
					}
					break;
				case 41:
					if (pyHu61CqyCiXjHGGuW9n(attribute.ElementName))
					{
						num = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num = 46;
						}
						break;
					}
					goto case 12;
				case 30:
					_003C_003Ec__DisplayClass0_.displayNameAttr = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(propertyInfo, inherited: true);
					num = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num = 40;
					}
					break;
				case 35:
					if (_003C_003Ec__DisplayClass0_3.sysDescriptionAttr == null)
					{
						num = 33;
						break;
					}
					goto case 7;
				case 18:
					attribute = AttributeHelper<XmlElementAttribute>.GetAttribute(propertyInfo, inherited: true);
					num = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num = 11;
					}
					break;
				case 38:
					_003C_003Ec__DisplayClass0_3.sysDescriptionAttr = AttributeHelper<System.ComponentModel.DescriptionAttribute>.GetAttribute(propertyInfo, inherited: true);
					num = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num = 35;
					}
					break;
				case 8:
					return;
				case 43:
					_type = type;
					num = 11;
					break;
				case 27:
					text = (string)uhsuDLCqmwaBR8A34KUK(propertyInfo);
					num = 18;
					break;
				case 5:
					if (_003C_003Ec__DisplayClass0_2.sysDisplayNameAttr != null)
					{
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num = 44;
						}
						break;
					}
					goto case 14;
				case 45:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num = 19;
					}
					break;
				case 9:
					_003C_003Ec__DisplayClass0_2 = new _003C_003Ec__DisplayClass0_1();
					num = 6;
					break;
				case 44:
					propertyDescriptor.DisplayNameAccessor = _003C_003Ec__DisplayClass0_2._003C_002Ector_003Eb__2;
					num = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num = 3;
					}
					break;
				case 4:
					propertyDescriptor.DisplayNameAccessor = _003C_003Ec__DisplayClass0_._003C_002Ector_003Eb__1;
					num = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num = 5;
					}
					break;
				case 19:
					if (!gg2EEcCqApfcsyAQHJxw(propertyInfo, typeof(XmlIgnoreAttribute), false))
					{
						num = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num = 28;
						}
						break;
					}
					goto case 2;
				case 21:
				case 23:
				case 46:
					attribute2 = AttributeHelper<XmlAttributeAttribute>.GetAttribute(propertyInfo, inherited: true);
					num = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num = 34;
					}
					break;
				case 11:
					array = (PropertyInfo[])kowmiaCqHLclv23h9VUY(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
					num = 25;
					break;
				case 34:
					if (attribute2 == null)
					{
						num = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num = 22;
						}
						break;
					}
					goto default;
				case 40:
					if (_003C_003Ec__DisplayClass0_.displayNameAttr != null)
					{
						num = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num = 42;
						}
						break;
					}
					goto case 9;
				case 2:
					num3++;
					num = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num = 11;
					}
					break;
				case 3:
				case 20:
					if (num3 >= array.Length)
					{
						return;
					}
					num = 39;
					break;
				case 17:
				case 24:
				case 31:
				case 36:
					defaultValueAttribute = ((IEnumerable)SD6XwACqJc75v0Ev379I(propertyInfo, fZWLo5CqxcGTEIKNNY06(typeof(DefaultValueAttribute).TypeHandle), true)).Cast<DefaultValueAttribute>().FirstOrDefault();
					num2 = 29;
					goto IL_003f;
				case 14:
				case 16:
					_003C_003Ec__DisplayClass0_.descriptionAttr = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(propertyInfo, inherited: true);
					num = 26;
					break;
				case 12:
					text = attribute.ElementName;
					num = 17;
					break;
				case 7:
					propertyDescriptor.DisplayNameAccessor = _003C_003Ec__DisplayClass0_3._003C_002Ector_003Eb__3;
					num = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num = 10;
					}
					break;
				case 1:
				case 22:
					_003C_003Ec__DisplayClass0_3 = new _003C_003Ec__DisplayClass0_2();
					num = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num = 0;
					}
					break;
				case 25:
					num3 = 0;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num = 3;
					}
					break;
				case 37:
					text = (string)B2agQaCqMuchhti6GlqX(attribute2);
					num = 36;
					break;
				case 6:
					_003C_003Ec__DisplayClass0_2.sysDisplayNameAttr = AttributeHelper<System.ComponentModel.DisplayNameAttribute>.GetAttribute(propertyInfo, inherited: true);
					num = 5;
					break;
				case 28:
					if (!gl9HIUCq0KGfC3gKoJIU(j1qraKCq7jotKW4KKEsx(propertyInfo), fZWLo5CqxcGTEIKNNY06(typeof(Attribute).TypeHandle)))
					{
						num = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num = 0;
						}
						break;
					}
					goto case 2;
				case 13:
					if (attribute == null)
					{
						num = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num = 3;
						}
						break;
					}
					goto case 41;
				case 26:
					{
						if (_003C_003Ec__DisplayClass0_.descriptionAttr == null)
						{
							num = 22;
							break;
						}
						goto case 4;
					}
					IL_003f:
					num = num2;
					break;
				}
			}
		}

		public Dictionary<string, object> Serialize(TypeSettings settings)
		{
			return SerializeWithType(settings).ToDictionary((KeyValuePair<PropertyDescriptor, object> k) => k.Key.Property.Name, (KeyValuePair<PropertyDescriptor, object> v) => v.Value);
		}

		public Dictionary<PropertyDescriptor, object> SerializeWithType(TypeSettings settings)
		{
			if (settings == null)
			{
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97912104));
			}
			Dictionary<PropertyDescriptor, object> dictionary = new Dictionary<PropertyDescriptor, object>();
			foreach (PropertyDescriptor propertyInfo in _propertyInfos)
			{
				PropertyInfo property = propertyInfo.Property;
				DefaultValueAttribute defaultValueAttribute = propertyInfo.DefaultValueAttribute;
				object value = property.GetValue(settings, null);
				if (defaultValueAttribute == null || (((value != null && (!(value is string) || !((string)value == string.Empty))) || (defaultValueAttribute.Value != null && (!(defaultValueAttribute.Value is string) || !((string)defaultValueAttribute.Value == string.Empty)))) && (value == null || defaultValueAttribute.Value == null || !value.Equals(defaultValueAttribute.Value))))
				{
					dictionary[propertyInfo] = value;
				}
			}
			return dictionary;
		}

		public IEnumerable<PropertyDescriptor> GetSerializedPropertyInfos()
		{
			return _propertyInfos;
		}

		public void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
		{
			//Discarded unreachable code: IL_0032, IL_012f, IL_0167, IL_0176
			int num = 2;
			int num2 = num;
			IEnumerator<PropertyDescriptor> enumerator = default(IEnumerator<PropertyDescriptor>);
			_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
			PropertyDescriptor current = default(PropertyDescriptor);
			TypeSerializationDescriptorBuilder typeSerializationDescriptorBuilder = default(TypeSerializationDescriptorBuilder);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					try
					{
						while (true)
						{
							IL_0085:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 5;
								goto IL_0040;
							}
							goto IL_0062;
							IL_0040:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								default:
									goto IL_0085;
								case 1:
								{
									_003C_003Ec__DisplayClass4_.p1 = current;
									int num4 = 2;
									num3 = num4;
									continue;
								}
								case 3:
									_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									typeSerializationDescriptorBuilder.ItemWithDescriptor((string)nvNFJNCqgEgrBUrReZm2(current), _003C_003Ec__DisplayClass4_._003CGetSerializationDescriptor_003Eb__1);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									return;
								}
								break;
							}
							goto IL_0062;
							IL_0062:
							current = enumerator.Current;
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
							{
								num3 = 3;
							}
							goto IL_0040;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									PlIxyHCq50kHQGkEceOA(enumerator);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 0:
					return;
				case 2:
					typeSerializationDescriptorBuilder = new TypeSerializationDescriptorBuilder(descriptor);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					enumerator = _propertyInfos.Where((PropertyDescriptor p1) => !_003C_003Ec.TXIpSCZVeIVTEQqWtY0L(p1)).GetEnumerator();
					num2 = 3;
					break;
				}
			}
		}

		internal static object kowmiaCqHLclv23h9VUY(Type type, BindingFlags bindingAttr)
		{
			return type.GetReflectionProperties(bindingAttr);
		}

		internal static bool gg2EEcCqApfcsyAQHJxw(object P_0, Type P_1, bool P_2)
		{
			return ((MemberInfo)P_0).IsDefined(P_1, P_2);
		}

		internal static Type j1qraKCq7jotKW4KKEsx(object P_0)
		{
			return ((MemberInfo)P_0).DeclaringType;
		}

		internal static Type fZWLo5CqxcGTEIKNNY06(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool gl9HIUCq0KGfC3gKoJIU(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static object uhsuDLCqmwaBR8A34KUK(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static bool pyHu61CqyCiXjHGGuW9n(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object B2agQaCqMuchhti6GlqX(object P_0)
		{
			return ((XmlAttributeAttribute)P_0).AttributeName;
		}

		internal static object SD6XwACqJc75v0Ev379I(object P_0, Type P_1, bool P_2)
		{
			return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
		}

		internal static void d67lSOCq9hrp17pabFgx(object P_0, object P_1)
		{
			((PropertyDescriptor)P_0).Property = (PropertyInfo)P_1;
		}

		internal static void NYxFlkCqd0y3W80osm1R(object P_0, object P_1)
		{
			((PropertyDescriptor)P_0).Name = (string)P_1;
		}

		internal static void fXkZIgCql1lubCuFxaK8(object P_0, Type value)
		{
			((PropertyDescriptor)P_0).Type = value;
		}

		internal static void O4qeAbCqrZhNUn1Fw2sr(object P_0, bool value)
		{
			((PropertyDescriptor)P_0).JsonIgnore = value;
		}

		internal static bool IM00W3Cq4GDMWVtrwIOR()
		{
			return ppMZ6JCqwLYHWFQds81s == null;
		}

		internal static DictionarySerializer CBMyhhCq63AUHZ1vImHG()
		{
			return (DictionarySerializer)ppMZ6JCqwLYHWFQds81s;
		}

		internal static object nvNFJNCqgEgrBUrReZm2(object P_0)
		{
			return ((PropertyDescriptor)P_0).Name;
		}

		internal static void PlIxyHCq50kHQGkEceOA(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	private static ConcurrentDictionary<Type, DictionarySerializer> _dictSerializers;

	private static ConcurrentDictionary<string, Type> _typesByName;

	internal static TypeSettingsSerializer hyL2eMocNGh6vJvGqy7m;

	public static Dictionary<string, object> SerializeToDictionary(TypeSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC1AD3E));
		}
		return GetSerializer(settings.GetType()).Serialize(settings);
	}

	public static SerializableDictionary<string, object> SerializeToJsonObject(TypeSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70046333));
		}
		Type type = settings.GetType();
		string name = type.Name;
		if (!_typesByName.ContainsKey(name))
		{
			_typesByName[name] = type;
		}
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D9E68)] = name;
		settings.SerializeToJsonObject(serializableDictionary);
		return serializableDictionary;
	}

	public static TypeSettings DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		if (jsonObject == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088198838));
		}
		CS_0024_003C_003E8__locals0.typeName = (string)jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC01D37)];
		if (!_typesByName.TryGetValue(CS_0024_003C_003E8__locals0.typeName, out var value))
		{
			value = ComponentManager.Current.GetXsiTypes().FirstOrDefault(delegate(Type t)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (!typeof(TypeSettings).IsAssignableFrom(t))
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						return _003C_003Ec__DisplayClass2_0.hJZycbCqcqMUBjmTReVY(_003C_003Ec__DisplayClass2_0.gQUtC3CqsBu1yYNEBtvH(t), CS_0024_003C_003E8__locals0.typeName);
					}
				}
			});
			if (value == null)
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289807680), CS_0024_003C_003E8__locals0.typeName));
			}
			_typesByName[CS_0024_003C_003E8__locals0.typeName] = value;
		}
		TypeSettings obj = (TypeSettings)Activator.CreateInstance(value);
		obj.DeserializeFromJsonObject(jsonObject);
		return obj;
	}

	internal static void SerializeBasicToJsonObject(TypeSettings settings, SerializableDictionary<string, object> jsonObject)
	{
		if (settings == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E4917));
		}
		if (jsonObject == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1EB276));
		}
		foreach (KeyValuePair<DictionarySerializer.PropertyDescriptor, object> item in from p in GetSerializer(settings.GetType()).SerializeWithType(settings)
			where !p.Key.JsonIgnore
			select p)
		{
			TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(item.Key.Type);
			if (converter != null)
			{
				string value = converter.ConvertToInvariantString(item.Value);
				jsonObject[item.Key.Name] = value;
			}
		}
	}

	internal static void DeserializeBasicFromJsonObject(TypeSettings settings, IDictionary<string, object> jsonObject)
	{
		if (settings == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36033699));
		}
		if (jsonObject == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36325FF3));
		}
		foreach (DictionarySerializer.PropertyDescriptor item in from p in GetSerializer(settings.GetType()).GetSerializedPropertyInfos()
			where !_003C_003Ec.ygclgyCKoTMu3Em9iIPV(p)
			select p)
		{
			PropertyInfo property = item.Property;
			if (!jsonObject.TryGetValue(item.Name, out var value))
			{
				continue;
			}
			string text = (string)value;
			if (property.CanWrite)
			{
				TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(property.PropertyType);
				if (converter != null)
				{
					object value2 = converter.ConvertFromInvariantString(text);
					property.SetValue(settings, value2, null);
				}
			}
		}
	}

	internal static void GetSerializationDescriptor(Type typeSettingsType, TypeSerializationDescriptor descriptor)
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
				ESvaZwocD9qBZybCpr1b(IisEM0ocaQuitkNJVDbk(typeSettingsType), descriptor);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static DictionarySerializer GetSerializer(Type typeSettingsType)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 4;
		int num2 = num;
		DictionarySerializer value = default(DictionarySerializer);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_dictSerializers[typeSettingsType] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				return value;
			case 4:
				if (_dictSerializers.TryGetValue(typeSettingsType, out value))
				{
					num2 = 3;
					continue;
				}
				break;
			case 1:
				break;
			}
			value = new DictionarySerializer(typeSettingsType);
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
			{
				num2 = 2;
			}
		}
	}

	static TypeSettingsSerializer()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_dictSerializers = new ConcurrentDictionary<Type, DictionarySerializer>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 1:
				Rh10PFoct3KI38iLT622();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_typesByName = new ConcurrentDictionary<string, Type>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object IisEM0ocaQuitkNJVDbk(Type typeSettingsType)
	{
		return GetSerializer(typeSettingsType);
	}

	internal static void ESvaZwocD9qBZybCpr1b(object P_0, object P_1)
	{
		((DictionarySerializer)P_0).GetSerializationDescriptor((TypeSerializationDescriptor)P_1);
	}

	internal static bool B7NfERoc3JjBXCoS7wGN()
	{
		return hyL2eMocNGh6vJvGqy7m == null;
	}

	internal static TypeSettingsSerializer OyxFQRocpAPaQmr2I31F()
	{
		return hyL2eMocNGh6vJvGqy7m;
	}

	internal static void Rh10PFoct3KI38iLT622()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
