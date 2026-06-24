using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Collections.Generic;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal class EnumProvider : TypeDescriptionProvider
{
	private class TypeDelegator : BaseTypeDelegator
	{
		private class EnumFieldInfo : FieldInfo
		{
			private readonly object value;

			private PublishCacheContext.Local<CustomAttributesData> customAttributesData;

			internal static object cCUCP7ZR7qMFATIkkRTR;

			public override string Name { get; }

			public override Type FieldType => PRhVVPZR96bLdFer5XWd(this);

			public override FieldAttributes Attributes => FieldAttributes.Public | FieldAttributes.Static | FieldAttributes.Literal | FieldAttributes.HasDefault;

			public override Type DeclaringType { get; }

			public override Type ReflectedType { get; }

			public override RuntimeFieldHandle FieldHandle
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public EnumFieldInfo(Type runtimeType, FieldDefinition fieldDefinition)
			{
				//Discarded unreachable code: IL_003e
				r7RbL2ZRmKaKCNKOQwNv();
				customAttributesData = new PublishCacheContext.Local<CustomAttributesData>();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
					{
						value = OrdLWLZRJIl1kQfWSku2(runtimeType, Q3qYLFZRMQIlhPG8ZNCQ(fieldDefinition));
						int num2 = 4;
						num = num2;
						break;
					}
					case 4:
						customAttributesData.Value = new CustomAttributesData((ICollection<CustomAttribute>)fieldDefinition.get_CustomAttributes());
						num = 5;
						break;
					case 1:
						DeclaringType = runtimeType;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num = 0;
						}
						break;
					case 5:
						return;
					case 3:
						Name = (string)otIgORZRypWK3InN77UV(fieldDefinition);
						num = 2;
						break;
					default:
						ReflectedType = runtimeType;
						num = 3;
						break;
					}
				}
			}

			public override object GetValue(object obj)
			{
				return value;
			}

			public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
			{
				throw new FieldAccessException();
			}

			public override IList<CustomAttributeData> GetCustomAttributesData()
			{
				return customAttributesData.Value.GetCustomAttributesData();
			}

			public override bool IsDefined(Type attributeType, bool inherit)
			{
				return customAttributesData.Value.IsDefined(attributeType, inherit);
			}

			public override object[] GetCustomAttributes(bool inherit)
			{
				return customAttributesData.Value.GetCustomAttributes(inherit);
			}

			public override object[] GetCustomAttributes(Type attributeType, bool inherit)
			{
				return customAttributesData.Value.GetCustomAttributes(attributeType, inherit);
			}

			internal static void r7RbL2ZRmKaKCNKOQwNv()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static object otIgORZRypWK3InN77UV(object P_0)
			{
				return ((MemberReference)P_0).get_Name();
			}

			internal static object Q3qYLFZRMQIlhPG8ZNCQ(object P_0)
			{
				return ((FieldDefinition)P_0).get_Constant();
			}

			internal static object OrdLWLZRJIl1kQfWSku2(Type P_0, object P_1)
			{
				return Enum.ToObject(P_0, P_1);
			}

			internal static bool QmPaV7ZRxRppba1PM7my()
			{
				return cCUCP7ZR7qMFATIkkRTR == null;
			}

			internal static EnumFieldInfo NhgXCaZR0uhoKZFNj7tW()
			{
				return (EnumFieldInfo)cCUCP7ZR7qMFATIkkRTR;
			}

			internal static Type PRhVVPZR96bLdFer5XWd(object P_0)
			{
				return ((MemberInfo)P_0).DeclaringType;
			}
		}

		private static readonly object GenericCacheProperty;

		private static readonly Type ValuesAndNamesType;

		private static readonly IDictionary<Type, object> EnumCachedValuesAndNames;

		private static readonly object MetadataTypeAttribute;

		private static readonly object UidAttribute;

		private static readonly object DisplayNameAttribute;

		private PublishCacheContext.Local<FieldInfo[]> allValues;

		private PublishCacheContext.Local<FieldInfo[]> staticValues;

		internal static object AvmijAvWaOgEeCRaJQFt;

		public TypeDelegator(Type runtimeType)
		{
			//Discarded unreachable code: IL_0053, IL_0058
			DvPZqPvWwtnklF5rFcZ9();
			allValues = new PublishCacheContext.Local<FieldInfo[]>();
			staticValues = new PublishCacheContext.Local<FieldInfo[]>();
			base._002Ector(runtimeType);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override void InitType(TypeDefinition typeDefinition)
		{
			//Discarded unreachable code: IL_014c, IL_025c, IL_0294
			int num = 3;
			FieldInfo[] array4 = default(FieldInfo[]);
			FieldInfo[] array2 = default(FieldInfo[]);
			ulong[] array6 = default(ulong[]);
			string[] array7 = default(string[]);
			IEnumerator<FieldDefinition> enumerator = default(IEnumerator<FieldDefinition>);
			FieldDefinition current = default(FieldDefinition);
			int num3 = default(int);
			FieldInfo[] array5 = default(FieldInfo[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						array4[0] = base.RuntimeType.GetField(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A09FE2));
						num2 = 5;
						continue;
					default:
						array2 = (staticValues.Value = new FieldInfo[jC2lOmvW4sCUJ0GeUbRh(typeDefinition.get_Fields()) - 1]);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 4;
						}
						continue;
					case 12:
						array4 = array2;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						array2 = (allValues.Value = new FieldInfo[jC2lOmvW4sCUJ0GeUbRh(typeDefinition.get_Fields())]);
						num2 = 12;
						continue;
					case 6:
						return;
					case 7:
						array6 = new ulong[jC2lOmvW4sCUJ0GeUbRh(typeDefinition.get_Fields()) - 1];
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 8;
						}
						continue;
					case 8:
						array7 = new string[jC2lOmvW4sCUJ0GeUbRh(typeDefinition.get_Fields()) - 1];
						num2 = 9;
						continue;
					case 10:
						try
						{
							while (true)
							{
								int num4;
								if (!aUg9vGvW7pDRNbqjDlgU(enumerator))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num4 = 1;
									}
									goto IL_015a;
								}
								goto IL_01de;
								IL_01de:
								current = enumerator.Current;
								num4 = 3;
								goto IL_015a;
								IL_015a:
								while (true)
								{
									switch (num4)
									{
									case 4:
										array4[num3 + 1] = (array5[num3] = new EnumFieldInfo(base.RuntimeType, current));
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
										{
											num4 = 0;
										}
										continue;
									case 5:
										break;
									case 2:
										goto IL_01de;
									case 6:
										array7[num3] = (string)DELWayvWAXOSGJEsA03c(current);
										num4 = 4;
										continue;
									default:
									{
										num3++;
										int num5 = 5;
										num4 = num5;
										continue;
									}
									case 3:
										array6[num3] = SGxxB0vWHBiWe71LFjkw(MwVmBevW6VZMq9WHAqq8(current));
										num4 = 6;
										continue;
									case 1:
										goto end_IL_01b8;
									}
									break;
								}
								continue;
								end_IL_01b8:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
								{
									num6 = 1;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										enumerator.Dispose();
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
										{
											num6 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 11;
					case 11:
						EnumCachedValuesAndNames[base.RuntimeType] = i3bK9DvWxHibkHODyi6O(ValuesAndNamesType, new object[2] { array6, array7 });
						num2 = 6;
						continue;
					case 4:
						array5 = array2;
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 7;
						}
						continue;
					case 3:
						break;
					case 5:
						num3 = 0;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						enumerator = ((IEnumerable<FieldDefinition>)typeDefinition.get_Fields()).Where((FieldDefinition f) => _003C_003Ec.WYV9cdZR5rcgtgEcLbXR(f) != null).GetEnumerator();
						num2 = 10;
						continue;
					}
					break;
				}
				base.InitType(typeDefinition);
				num = 2;
			}
		}

		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return staticValues.Value;
				default:
					return (FieldInfo[])f0uTxEvW0Is3DvEZ2HfD(this, bindingAttr);
				case 2:
					if (bindingAttr.HasFlag(BindingFlags.Instance))
					{
						return allValues.Value;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					if (bindingAttr.HasFlag(BindingFlags.Static | BindingFlags.Public))
					{
						num2 = 2;
						break;
					}
					goto default;
				}
			}
		}

		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			int num = 4;
			int num2 = num;
			List<FieldInfo> list = default(List<FieldInfo>);
			_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					throw new AmbiguousMatchException();
				default:
					if (rf5RokvWmsII6dp78XXa(list) == 0)
					{
						return null;
					}
					num2 = 5;
					break;
				case 5:
					if (list.Count == 1)
					{
						return list[0];
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					list = GetFields(bindingAttr).Where(_003C_003Ec__DisplayClass11_._003CGetField_003Eb__0).ToList();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 3;
					}
					break;
				case 7:
					if (_003C_003Ec__DisplayClass11_.name == null)
					{
						num2 = 6;
						break;
					}
					_003C_003Ec__DisplayClass11_.ignoreCase = bindingAttr.HasFlag(BindingFlags.IgnoreCase);
					num2 = 2;
					break;
				case 3:
					_003C_003Ec__DisplayClass11_.name = name;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 7;
					}
					break;
				case 6:
					throw new ArgumentNullException();
				}
			}
		}

		static TypeDelegator()
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					UidAttribute = TypeOf<EleWise.ELMA.Model.Attributes.UidAttribute>.Raw.GetConstructor(new Type[1] { TypeOf<string>.Raw });
					num2 = 7;
					break;
				case 1:
					ValuesAndNamesType = bo4GWdvWMOghebOCsJUa(typeof(Enum).TypeHandle).GetNestedType((string)ykEOXlvWylVqBHO3Cnkf(-1426094279 ^ -1426441261), BindingFlags.NonPublic);
					num2 = 4;
					break;
				case 4:
					EnumCachedValuesAndNames = PublishCacheContext.CreateCache((IDictionary<Type, object> _) => new Dictionary<Type, object>(), null, delegate(IDictionary<Type, object> _)
					{
						_.RemoveAll(delegate(KeyValuePair<Type, object> p)
						{
							((PropertyInfo)GenericCacheProperty).SetValue((object)p.Key, p.Value);
							return true;
						});
					}, delegate(IDictionary<Type, object> _)
					{
						_.Clear();
					});
					num2 = 6;
					break;
				case 2:
					GenericCacheProperty = typeof(Type).GetType().GetProperty((string)ykEOXlvWylVqBHO3Cnkf(-1638402543 ^ -1638774049), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					MetadataTypeAttribute = TypeOf<EleWise.ELMA.Model.Attributes.MetadataTypeAttribute>.Raw.GetConstructor(new Type[1] { TypeOf<Type>.Raw });
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					return;
				case 3:
					DvPZqPvWwtnklF5rFcZ9();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 2;
					}
					break;
				case 7:
					DisplayNameAttribute = TypeOf<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.Raw.GetConstructor(new Type[1] { TypeOf<string>.Raw });
					num2 = 5;
					break;
				}
			}
		}

		internal static void DvPZqPvWwtnklF5rFcZ9()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool JNMG3dvWDKMI4kEE6Xyi()
		{
			return AvmijAvWaOgEeCRaJQFt == null;
		}

		internal static TypeDelegator u9Q26pvWtjiTCJALKuMc()
		{
			return (TypeDelegator)AvmijAvWaOgEeCRaJQFt;
		}

		internal static int jC2lOmvW4sCUJ0GeUbRh(object P_0)
		{
			return ((Collection<FieldDefinition>)P_0).get_Count();
		}

		internal static object MwVmBevW6VZMq9WHAqq8(object P_0)
		{
			return ((FieldDefinition)P_0).get_Constant();
		}

		internal static ulong SGxxB0vWHBiWe71LFjkw(object P_0)
		{
			return Convert.ToUInt64(P_0);
		}

		internal static object DELWayvWAXOSGJEsA03c(object P_0)
		{
			return ((MemberReference)P_0).get_Name();
		}

		internal static bool aUg9vGvW7pDRNbqjDlgU(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static object i3bK9DvWxHibkHODyi6O(Type P_0, object P_1)
		{
			return Activator.CreateInstance(P_0, (object[])P_1);
		}

		internal static object f0uTxEvW0Is3DvEZ2HfD(object P_0, BindingFlags P_1)
		{
			return ((System.Reflection.TypeDelegator)P_0).GetFields(P_1);
		}

		internal static int rf5RokvWmsII6dp78XXa(object P_0)
		{
			return ((List<FieldInfo>)P_0).Count;
		}

		internal static object ykEOXlvWylVqBHO3Cnkf(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static Type bo4GWdvWMOghebOCsJUa(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	private class CustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor
	{
		private class EnumTypeConverter : TypeConverter
		{
			private readonly object enumType;

			internal static object JehKaBZRzTtGi2jCTrIE;

			public EnumTypeConverter(Type enumType)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				NEPEhRZqWNKykur72UqI();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						this.enumType = types[enumType];
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			{
				//Discarded unreachable code: IL_0038, IL_0047
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return uIyrEnZqbgS07PBgoqey(this, context, sourceType);
					case 1:
						return true;
					case 2:
						if (sourceType == KplalMZqoJLCf5RL4Oa2(typeof(string).TypeHandle))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					}
				}
			}

			public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
			{
				//Discarded unreachable code: IL_0102, IL_01d3, IL_01fb, IL_020a
				int num = 8;
				int? num6 = default(int?);
				int? num3 = default(int?);
				string name = default(string);
				string[] array = default(string[]);
				int num4 = default(int);
				int num5 = default(int);
				string text = default(string);
				FieldInfo field = default(FieldInfo);
				int? num8 = default(int?);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int? num7;
						object obj;
						switch (num2)
						{
						case 5:
							num6 = num3;
							num2 = 6;
							continue;
						case 1:
							name = array[num4];
							num = 4;
							break;
						case 14:
							if (!num6.HasValue)
							{
								num2 = 15;
								continue;
							}
							num7 = num6.GetValueOrDefault() | num5;
							goto IL_0267;
						case 7:
							if (okk89jZqhiIyOTM7Ae8D(text, ',') != -1)
							{
								num = 19;
								break;
							}
							goto case 11;
						case 16:
							array = text.Split(',');
							num2 = 12;
							continue;
						case 3:
							if (fpQQeoZqGTjyKTgHncmx(field, null))
							{
								num2 = 5;
								continue;
							}
							goto case 9;
						case 2:
							num7 = num8;
							goto IL_0267;
						default:
							return MPjxTuZqfBAKpP95hY83((Type)enumType, num3);
						case 4:
							field = ((Type)enumType).GetField(name);
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num2 = 2;
							}
							continue;
						case 15:
							num8 = null;
							num2 = 2;
							continue;
						case 10:
						case 20:
							if (num4 >= array.Length)
							{
								num2 = 17;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num2 = 12;
								}
								continue;
							}
							goto case 1;
						case 9:
							num4++;
							num2 = 20;
							continue;
						case 19:
							num3 = 0;
							num2 = 16;
							continue;
						case 8:
							if ((text = value as string) != null)
							{
								num2 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num2 = 4;
								}
								continue;
							}
							goto IL_011a;
						case 6:
							num5 = (int)KrZnilZqECpbRZiEYoAx(field, null);
							num2 = 14;
							continue;
						case 12:
							num4 = 0;
							num2 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num2 = 10;
							}
							continue;
						case 17:
						case 18:
							if (num3.HasValue)
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto IL_011a;
						case 11:
						{
							FieldInfo field2 = ((Type)enumType).GetField(text);
							if ((object)field2 == null)
							{
								num2 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
								{
									num2 = 13;
								}
								continue;
							}
							obj = KrZnilZqECpbRZiEYoAx(field2, null);
							goto IL_02b2;
						}
						case 13:
							{
								obj = null;
								goto IL_02b2;
							}
							IL_011a:
							return EB4LWXZqQVxGKFX6Sby1(this, context, culture, value);
							IL_02b2:
							num3 = (int?)obj;
							num2 = 18;
							continue;
							IL_0267:
							num3 = num7;
							num2 = 9;
							continue;
						}
						break;
					}
				}
			}

			internal static void NEPEhRZqWNKykur72UqI()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool HeYk6RZqFW3wUfoa6r4x()
			{
				return JehKaBZRzTtGi2jCTrIE == null;
			}

			internal static EnumTypeConverter EkVmLIZqBE9OfbdCnFgm()
			{
				return (EnumTypeConverter)JehKaBZRzTtGi2jCTrIE;
			}

			internal static Type KplalMZqoJLCf5RL4Oa2(RuntimeTypeHandle P_0)
			{
				return Type.GetTypeFromHandle(P_0);
			}

			internal static bool uIyrEnZqbgS07PBgoqey(object P_0, object P_1, Type P_2)
			{
				return ((TypeConverter)P_0).CanConvertFrom((ITypeDescriptorContext)P_1, P_2);
			}

			internal static int okk89jZqhiIyOTM7Ae8D(object P_0, char P_1)
			{
				return ((string)P_0).IndexOf(P_1);
			}

			internal static bool fpQQeoZqGTjyKTgHncmx(object P_0, object P_1)
			{
				return (FieldInfo)P_0 != (FieldInfo)P_1;
			}

			internal static object KrZnilZqECpbRZiEYoAx(object P_0, object P_1)
			{
				return ((FieldInfo)P_0).GetValue(P_1);
			}

			internal static object MPjxTuZqfBAKpP95hY83(Type P_0, object P_1)
			{
				return Enum.ToObject(P_0, P_1);
			}

			internal static object EB4LWXZqQVxGKFX6Sby1(object P_0, object P_1, object P_2, object P_3)
			{
				return ((TypeConverter)P_0).ConvertFrom((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
			}
		}

		private readonly object typeConverter;

		internal static object eLT4xdvWJtheNmVkHiFo;

		public CustomTypeDescriptor(Type enumType, ICustomTypeDescriptor enumTypeDescriptor)
		{
			//Discarded unreachable code: IL_002b, IL_0030
			PT6CORvWlGElCJHkKGC8();
			base._002Ector(enumTypeDescriptor);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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
				typeConverter = new EnumTypeConverter(enumType);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 1;
				}
			}
		}

		public override TypeConverter GetConverter()
		{
			return (TypeConverter)typeConverter;
		}

		internal static void PT6CORvWlGElCJHkKGC8()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool YfT411vW9n55XHLEuVvk()
		{
			return eLT4xdvWJtheNmVkHiFo == null;
		}

		internal static CustomTypeDescriptor JpXl4mvWdcASF4fCxi6c()
		{
			return (CustomTypeDescriptor)eLT4xdvWJtheNmVkHiFo;
		}
	}

	private static EnumProvider instance;

	private static readonly ISet<Type> providerTypes;

	private static readonly IDictionary<Type, TypeDelegator> types;

	private static readonly IDictionary<Type, ICustomTypeDescriptor> typeDescriptor;

	internal static EnumProvider n8xV4Mhiqx88LHfuy19e;

	internal static EnumProvider Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			EnumProvider enumProvider;
			while (true)
			{
				switch (num2)
				{
				case 1:
					enumProvider = instance;
					if (enumProvider != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					enumProvider = new EnumProvider();
					break;
				}
				break;
			}
			return enumProvider;
		}
	}

	internal static void AddType(Type type, TypeDefinition typeDefinition)
	{
		//Discarded unreachable code: IL_0041, IL_00d2
		int num = 1;
		int num2 = num;
		TypeDelegator value = default(TypeDelegator);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 3:
			case 4:
				oQq8vLhikRhVgTSo1f3v(value, typeDefinition);
				num2 = 6;
				break;
			case 5:
				TypeDescriptor.AddProvider((TypeDescriptionProvider)lQWPdThiTeNIMsuNMQRy(), type);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				value = (types[type] = new TypeDelegator(type));
				num2 = 4;
				break;
			default:
				if (types.TryGetValue(type, out value))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 7;
			case 1:
				if (!providerTypes.Add(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public EnumProvider()
	{
		//Discarded unreachable code: IL_0039, IL_003e
		BrfL0Uhin2HeXNGLeOZR();
		base._002Ector((TypeDescriptionProvider)c7ouYmhi20QeWjUVgMuj(zaCotHhiOUA6EnEG3XHi(typeof(Enum).TypeHandle)));
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				instance = this;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsSupportedType(Type type)
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!type.IsEnum)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return v1K1pOhiei9H7p3LQBQh(type.Assembly);
			case 1:
				return false;
			}
		}
	}

	public override Type GetRuntimeType(Type reflectionType)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 1;
		int num2 = num;
		BaseTypeDelegator baseTypeDelegator = default(BaseTypeDelegator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return QYTeX9hiPBB5J0TFnDa2(this, reflectionType);
			default:
				return H5KSa1hi1HaVrip3cwKd(baseTypeDelegator);
			case 1:
				if ((object)(baseTypeDelegator = reflectionType as BaseTypeDelegator) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override Type GetReflectionType(Type objectType, object instance)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (!types.TryGetValue(objectType, out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
				return value;
			}
			default:
				return objectType;
			}
		}
	}

	private static EnumMetadata GetEnumMetadata(Type type)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				AssemblyModelsMetadata assemblyModelsMetadata = MetadataServiceContext.MetadataRuntimeService.GetAssemblyModelsMetadataList().First((AssemblyModelsMetadata a) => _003C_003Ec.avr5aHvoB5xQP8BsuHev(_003C_003Ec.b8OvwgvoFZtvYUlLlXMR(a), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A0558)));
				_003C_003Ec__DisplayClass11_.fullTypeName = type.FullName;
				return assemblyModelsMetadata.RestoreMetadata().OfType<EnumMetadata>().First(_003C_003Ec__DisplayClass11_._003CGetEnumMetadata_003Eb__1);
			}
			}
		}
	}

	public override ICustomTypeDescriptor GetTypeDescriptor(Type type, object instance)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass12_.instance = instance;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return typeDescriptor.GetOrAdd(type, _003C_003Ec__DisplayClass12_._003CGetTypeDescriptor_003Eb__0);
			default:
				_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static EnumProvider()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				SingletonReader.JJCZtPuTvSt();
				num2 = 3;
				break;
			default:
				typeDescriptor = PublishCacheContext.CreateCache<Type, ICustomTypeDescriptor>();
				num2 = 2;
				break;
			case 2:
				return;
			case 3:
				providerTypes = new HashSet<Type>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				types = PublishCacheContext.CreateCache<Type, TypeDelegator>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool UeG0xPhiKvyfYh5QCPPI()
	{
		return n8xV4Mhiqx88LHfuy19e == null;
	}

	internal static EnumProvider aurP45hiXIZarOWyhger()
	{
		return n8xV4Mhiqx88LHfuy19e;
	}

	internal static object lQWPdThiTeNIMsuNMQRy()
	{
		return Instance;
	}

	internal static void oQq8vLhikRhVgTSo1f3v(object P_0, object P_1)
	{
		((BaseTypeDelegator)P_0).InitType((TypeDefinition)P_1);
	}

	internal static void BrfL0Uhin2HeXNGLeOZR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type zaCotHhiOUA6EnEG3XHi(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object c7ouYmhi20QeWjUVgMuj(Type P_0)
	{
		return TypeDescriptor.GetProvider(P_0);
	}

	internal static bool v1K1pOhiei9H7p3LQBQh(object P_0)
	{
		return ((Assembly)P_0).IsDynamicAssembly();
	}

	internal static Type QYTeX9hiPBB5J0TFnDa2(object P_0, Type P_1)
	{
		return ((TypeDescriptionProvider)P_0).GetRuntimeType(P_1);
	}

	internal static Type H5KSa1hi1HaVrip3cwKd(object P_0)
	{
		return ((BaseTypeDelegator)P_0).RuntimeType;
	}

	internal static object JeyWrBhiNEgK0hIv8sF5(object P_0, Type P_1, object P_2)
	{
		return ((TypeDescriptionProvider)P_0).GetTypeDescriptor(P_1, P_2);
	}
}
