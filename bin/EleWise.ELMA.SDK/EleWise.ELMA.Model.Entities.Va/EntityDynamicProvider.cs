using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Accessors;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.SDK;
using j3AmrhgkCleVTGdEwA;
using Mono.Cecil;
using Mono.Collections.Generic;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal class EntityDynamicProvider : TypeDescriptionProvider
{
	private class CustomTypeDescriptor : System.ComponentModel.CustomTypeDescriptor, ICustomTypeDescriptor
	{
		private class EntityPropertyDescriptor : PropertyDescriptor
		{
			private readonly object propertyInfo;

			internal static object W01soZZigtpkHmBkJgTu;

			public override Type ComponentType => TmG2ThZiLdWIRDyrTJmA(propertyInfo);

			public override bool IsReadOnly => !((PropertyInfo)propertyInfo).CanWrite;

			public override Type PropertyType => CCen7aZiUvv4kdpSeHvL(propertyInfo);

			public EntityPropertyDescriptor(EntityPropertyInfo propertyInfo)
			{
				//Discarded unreachable code: IL_0031, IL_0036
				zbvjThZiYuBLFImGTaxm();
				base._002Ector(propertyInfo.Name, null);
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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
						this.propertyInfo = propertyInfo;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			protected override void FillAttributes(IList attributeList)
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
						((MemberInfo)propertyInfo).GetCustomAttributes().Max((Func<Attribute, int>)attributeList.Add);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public override object GetValue(object component)
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				return ((IGetter)((EntityPropertyInfo)propertyInfo).Accessor).Get(component);
			}

			public override void SetValue(object component, object value)
			{
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Expected O, but got Unknown
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
						GV5wqcZiseTymibMJTX8((object)(ISetter)((EntityPropertyInfo)propertyInfo).Accessor, component, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public override bool ShouldSerializeValue(object component)
			{
				return true;
			}

			public override bool CanResetValue(object component)
			{
				return false;
			}

			public override void ResetValue(object component)
			{
			}

			internal static void zbvjThZiYuBLFImGTaxm()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static bool Op6eaYZi51SpgN7Sxfqb()
			{
				return W01soZZigtpkHmBkJgTu == null;
			}

			internal static EntityPropertyDescriptor RP5pGYZijoQdySxZjRfc()
			{
				return (EntityPropertyDescriptor)W01soZZigtpkHmBkJgTu;
			}

			internal static Type TmG2ThZiLdWIRDyrTJmA(object P_0)
			{
				return ((MemberInfo)P_0).DeclaringType;
			}

			internal static Type CCen7aZiUvv4kdpSeHvL(object P_0)
			{
				return ((PropertyInfo)P_0).PropertyType;
			}

			internal static void GV5wqcZiseTymibMJTX8(object P_0, object P_1, object P_2)
			{
				((ISetter)P_0).Set(P_1, P_2);
			}
		}

		private class PropertyDescriptorComparer : IEqualityComparer<PropertyDescriptor>
		{
			public static IEqualityComparer<PropertyDescriptor> Instance;

			internal static object e6pxS6ZicINW2PubO3DU;

			public bool Equals(PropertyDescriptor x, PropertyDescriptor y)
			{
				return bRjYICZRW0ho6hWY0VNR(M52oC3ZRBOoyoCNI48ro(x), y.Name);
			}

			public int GetHashCode(PropertyDescriptor obj)
			{
				return M52oC3ZRBOoyoCNI48ro(obj).GetHashCode();
			}

			public PropertyDescriptorComparer()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			static PropertyDescriptorComparer()
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						Instance = new PropertyDescriptorComparer();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					case 2:
						DyGVqKZRoXJEYWU6cfib();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static object M52oC3ZRBOoyoCNI48ro(object P_0)
			{
				return ((MemberDescriptor)P_0).Name;
			}

			internal static bool bRjYICZRW0ho6hWY0VNR(object P_0, object P_1)
			{
				return (string)P_0 == (string)P_1;
			}

			internal static bool LS6pUnZizssnJk9W9Kmy()
			{
				return e6pxS6ZicINW2PubO3DU == null;
			}

			internal static PropertyDescriptorComparer vLwKqTZRFyg8jTMxocyE()
			{
				return (PropertyDescriptorComparer)e6pxS6ZicINW2PubO3DU;
			}

			internal static void DyGVqKZRoXJEYWU6cfib()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		private readonly object entityType;

		private readonly ConcurrentDictionary<PropertyInfo, PropertyDescriptor> propertyDescriptors;

		private object concatProperties;

		private static object hHPdM8vF7nsiOwvJx2Xo;

		private IEnumerable<PropertyDescriptor> MetadataProperties => ((TypeDelegator)entityType).metadataProperties.Values.Select((PropertyInfo p) => propertyDescriptors.GetOrAdd(p, (PropertyInfo pp) => new EntityPropertyDescriptor((EntityPropertyInfo)pp)));

		private IEnumerable<PropertyDescriptor> ConcatProperties => (IEnumerable<PropertyDescriptor>)(concatProperties ?? (concatProperties = base.GetProperties().Cast<PropertyDescriptor>().Where(delegate(PropertyDescriptor pd)
		{
			//Discarded unreachable code: IL_005d, IL_006c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (jj68YbvFJBPuWVpM5DWT(pd.ComponentType, (Type)entityType))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return jj68YbvFJBPuWVpM5DWT(pd.ComponentType, Ax0AJpvF9ySEfm7XtoJs(entityType));
				default:
					return true;
				}
			}
		})
			.Except(MetadataProperties, PropertyDescriptorComparer.Instance)
			.ToArray()));

		internal CustomTypeDescriptor(Type entityType, ICustomTypeDescriptor entityTypeDescriptor)
		{
			//Discarded unreachable code: IL_003b, IL_0040
			Lodl9qvFm3wkGgTPdAYK();
			propertyDescriptors = new ConcurrentDictionary<PropertyInfo, PropertyDescriptor>();
			base._002Ector(entityTypeDescriptor);
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
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
					this.entityType = (entityType as TypeDelegator) ?? types[entityType];
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public override PropertyDescriptorCollection GetProperties()
		{
			int num = 3;
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 1;
						}
						continue;
					default:
						return new PropertyDescriptorCollection(MetadataProperties.Concat(ConcatProperties).If(_003C_003Ec__DisplayClass8_.baseTypeDescriptor != null, _003C_003Ec__DisplayClass8_._003CGetProperties_003Eb__0).ToArray());
					case 3:
						break;
					case 1:
						_003C_003Ec__DisplayClass8_.baseTypeDescriptor = (ICustomTypeDescriptor)((((Type)entityType)?.BaseType != null) ? n8K2qevFMISgOVxdndvb(NUojpfvFybTxgiFdIiQG(), ((Type)entityType).BaseType) : null);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num = 2;
			}
		}

		public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return GetProperties();
		}

		internal static void Lodl9qvFm3wkGgTPdAYK()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool sYW7a6vFxXu0I7U4ELDk()
		{
			return hHPdM8vF7nsiOwvJx2Xo == null;
		}

		internal static CustomTypeDescriptor Jf1IyWvF0tQ7lfUK6AZH()
		{
			return (CustomTypeDescriptor)hHPdM8vF7nsiOwvJx2Xo;
		}

		internal static object NUojpfvFybTxgiFdIiQG()
		{
			return Instance;
		}

		internal static object n8K2qevFMISgOVxdndvb(object P_0, Type P_1)
		{
			return ((TypeDescriptionProvider)P_0).GetTypeDescriptor(P_1);
		}

		internal static bool jj68YbvFJBPuWVpM5DWT(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static Type Ax0AJpvF9ySEfm7XtoJs(object P_0)
		{
			return ((BaseTypeDelegator)P_0).RuntimeType;
		}
	}

	private class TypeDelegator : BaseTypeDelegator
	{
		private class PropertyInfoComparer : IEqualityComparer<PropertyInfo>
		{
			public static IEqualityComparer<PropertyInfo> Instance;

			internal static object p7MwjmZR8hprF4e3Ay3k;

			public bool Equals(PropertyInfo x, PropertyInfo y)
			{
				return (string)EIPoPGZRIaUy9fvak6Rp(x) == (string)EIPoPGZRIaUy9fvak6Rp(y);
			}

			public int GetHashCode(PropertyInfo obj)
			{
				return EIPoPGZRIaUy9fvak6Rp(obj).GetHashCode();
			}

			public PropertyInfoComparer()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				JMj9slZRVBomtJS0F0fS();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			static PropertyInfoComparer()
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						JMj9slZRVBomtJS0F0fS();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					default:
						Instance = new PropertyInfoComparer();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static object EIPoPGZRIaUy9fvak6Rp(object P_0)
			{
				return ((MemberInfo)P_0).Name;
			}

			internal static bool hdHf0lZRZ8myXK9KnwDT()
			{
				return p7MwjmZR8hprF4e3Ay3k == null;
			}

			internal static PropertyInfoComparer VDxlHfZRu9fYJHcFvkfp()
			{
				return (PropertyInfoComparer)p7MwjmZR8hprF4e3Ay3k;
			}

			internal static void JMj9slZRVBomtJS0F0fS()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		private readonly bool hasBase;

		internal IDictionary<string, PropertyInfo> metadataProperties;

		private readonly ConcurrentDictionary<IAccessor, PropertyInfo> propertyInfos;

		private readonly ConcurrentDictionary<PropertyInfo, PropertyInfo> reflectedBaseProperties;

		private object baseExceptProperties;

		private object exceptMethods;

		private static object j41j02vFdvRev0bxOq7C;

		public override Type BaseType
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return base.RuntimeType.BaseType;
					case 1:
						if (hasBase)
						{
							return qgEu4DvFzGr6ZIIfQnPT(D6IMipvFchZTSpGYmD21(base.RuntimeType.BaseType), base.RuntimeType.BaseType);
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		private PropertyInfo[] BaseExceptProperties
		{
			get
			{
				int num = 1;
				int num2 = num;
				PropertyInfo[] array = default(PropertyInfo[]);
				object obj;
				while (true)
				{
					switch (num2)
					{
					default:
						array = (PropertyInfo[])(baseExceptProperties = BaseType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Intersect((IEnumerable<PropertyInfo>)rkMBcivBFkwt4fTFdYua(this, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public), PropertyInfoComparer.Instance).ToArray());
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 2;
						}
						continue;
					case 1:
						obj = baseExceptProperties;
						if (obj != null)
						{
							break;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						obj = array;
						break;
					}
					break;
				}
				return (PropertyInfo[])obj;
			}
		}

		private MethodInfo[] ExceptMethods
		{
			get
			{
				int num = 1;
				int num2 = num;
				object obj;
				MethodInfo[] array = default(MethodInfo[]);
				while (true)
				{
					switch (num2)
					{
					case 1:
						obj = exceptMethods;
						if (obj == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					default:
						array = (MethodInfo[])(exceptMethods = ((IEnumerable<PropertyInfo>)rkMBcivBFkwt4fTFdYua(this, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)).SelectMany((PropertyInfo p) => p.GetAccessors()).ToArray());
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						obj = array;
						break;
					}
					break;
				}
				return (MethodInfo[])obj;
			}
		}

		public TypeDelegator(Type runtimeType)
		{
			//Discarded unreachable code: IL_005c, IL_00b6
			LdOoqjvFg1T6hbHnlEXN();
			metadataProperties = PublishCacheContext.CreateCache<string, PropertyInfo>();
			propertyInfos = new ConcurrentDictionary<IAccessor, PropertyInfo>();
			reflectedBaseProperties = new ConcurrentDictionary<PropertyInfo, PropertyInfo>();
			base._002Ector(runtimeType);
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
			{
				num = 0;
			}
			Type type = default(Type);
			while (true)
			{
				object obj;
				int num2;
				switch (num)
				{
				case 3:
					return;
				case 5:
					return;
				default:
					hasBase = base.RuntimeType.BaseType != null;
					num = 2;
					continue;
				case 7:
				{
					FilterForAttribute customAttribute = runtimeType.GetCustomAttribute<FilterForAttribute>();
					if (customAttribute == null)
					{
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num = 4;
						}
						continue;
					}
					obj = customAttribute.EntityType;
					goto IL_0107;
				}
				case 2:
					if (!hasBase)
					{
						num = 3;
						continue;
					}
					goto case 7;
				case 4:
					obj = null;
					goto IL_0107;
				case 6:
					obj = runtimeType;
					break;
				case 1:
					{
						hasBase = !type.BaseType.IsGenericType || (u9gDuJvFjGVYaJcXI27b(type.BaseType.GetGenericTypeDefinition(), vekDskvF5hygG5GnmJfo(EleWise.ELMA.SDK.TypeOf.EntityDynamic1)) && u9gDuJvFjGVYaJcXI27b(type.BaseType.GetGenericTypeDefinition(), vekDskvF5hygG5GnmJfo(EleWise.ELMA.SDK.TypeOf.Entity1)));
						num2 = 5;
						goto IL_0061;
					}
					IL_0107:
					if (obj != null)
					{
						break;
					}
					num2 = 6;
					goto IL_0061;
					IL_0061:
					num = num2;
					continue;
				}
				type = (Type)obj;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 0;
				}
			}
		}

		public override void InitType(TypeDefinition typeDefinition)
		{
			//Discarded unreachable code: IL_00c0, IL_00cf, IL_0148, IL_01c2, IL_01d1, IL_01f7, IL_0257, IL_0266, IL_02f9, IL_030c
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			int num = 5;
			int num2 = num;
			Lazy<ISet<string>> lazy = default(Lazy<ISet<string>>);
			Enumerator<PropertyDefinition> enumerator = default(Enumerator<PropertyDefinition>);
			PropertyDefinition current = default(PropertyDefinition);
			PropertyInfo value = default(PropertyInfo);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 4:
					if (typeDefinition == null)
					{
						return;
					}
					num2 = 3;
					continue;
				case 3:
					lazy = new Lazy<ISet<string>>(() => (from p in base.RuntimeType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
						select (string)_003C_003Ec.UNloXEZRKOhLI8nqfHLw(p)).ToHashSet());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					base.InitType(typeDefinition);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					enumerator = typeDefinition.get_Properties().GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					while (true)
					{
						IL_0271:
						int num4;
						if (!enumerator.MoveNext())
						{
							int num3 = 13;
							num4 = num3;
							goto IL_00de;
						}
						goto IL_0178;
						IL_00de:
						while (true)
						{
							switch (num4)
							{
							case 13:
								return;
							case 1:
								if (!metadataProperties.TryGetValue((string)PvyAghvFY4pDNnGa5cxR(current), out value))
								{
									num4 = 8;
									continue;
								}
								goto case 7;
							case 6:
								if (AgTM77vFspaUry7MeBqt(current))
								{
									num4 = 11;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto IL_0271;
							case 3:
							case 8:
								if (lazy.Value.Contains((string)PvyAghvFY4pDNnGa5cxR(current)))
								{
									num4 = 12;
									continue;
								}
								goto case 4;
							case 12:
								if (!i90OcuvFUNEnnty0wd5h(current))
								{
									num4 = 10;
									continue;
								}
								goto case 6;
							case 7:
								Iax2fPvFL4GcGj7DdAVD((EntityPropertyInfo)value, current);
								num4 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
								{
									num4 = 9;
								}
								continue;
							case 4:
								metadataProperties[((MemberReference)current).get_Name()] = new EntityPropertyInfo(base.RuntimeType, current);
								num4 = 5;
								continue;
							case 2:
							case 5:
							case 9:
							case 10:
								goto IL_0271;
							case 11:
								if (!((IEnumerable<CustomAttribute>)current.get_CustomAttributes()).Any((CustomAttribute ca) => _003C_003Ec.GFSJIiZRnPEJfk7dL27o(_003C_003Ec.VuVY1OZRT4sf9mGBhFQQ(_003C_003Ec.M57RUxZRXQhAyJDBfQJ2(ca)), _003C_003Ec.YakbdaZRkkajE9LfHk06())))
								{
									num4 = 2;
									continue;
								}
								goto case 4;
							}
							break;
						}
						goto IL_0178;
						IL_0178:
						current = enumerator.get_Current();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num4 = 1;
						}
						goto IL_00de;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			}
		}

		private PropertyInfo GetReflectedBaseProperty(PropertyInfo propertyInfo)
		{
			return reflectedBaseProperties.GetOrAdd(propertyInfo, (PropertyInfo p) => new PropertyInfoProxy(p, null, base.RuntimeType));
		}

		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			//Discarded unreachable code: IL_00b5
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					if (_003C_003Ec__DisplayClass12_.bindingAttr.HasFlag(BindingFlags.Instance | BindingFlags.Public))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 4;
				case 3:
					_003C_003Ec__DisplayClass12_.bindingAttr = bindingAttr;
					num2 = 5;
					break;
				default:
					_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
					num2 = 3;
					break;
				case 4:
					return base.GetProperties(_003C_003Ec__DisplayClass12_.bindingAttr);
				case 2:
				{
					ICollection<PropertyInfo> values = metadataProperties.Values;
					IEnumerable<PropertyInfo> second;
					if (!hasBase)
					{
						IEnumerable<PropertyInfo> properties = base.GetProperties(_003C_003Ec__DisplayClass12_.bindingAttr);
						second = properties;
					}
					else
					{
						second = ((IEnumerable<PropertyInfo>)rkMBcivBFkwt4fTFdYua(this, _003C_003Ec__DisplayClass12_.bindingAttr | BindingFlags.DeclaredOnly)).If(!_003C_003Ec__DisplayClass12_.bindingAttr.HasFlag(BindingFlags.DeclaredOnly), _003C_003Ec__DisplayClass12_._003CGetProperties_003Eb__0);
					}
					return values.Union(second, PropertyInfoComparer.Instance).ToArray();
				}
				}
			}
		}

		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			//Discarded unreachable code: IL_00d1, IL_00e0, IL_013f, IL_0152, IL_017e, IL_023e, IL_02cd, IL_02dc, IL_02eb, IL_02fa, IL_037e, IL_040f, IL_041e, IL_04d6, IL_04e5
			int num = 36;
			_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
			int num5 = default(int);
			int num6 = default(int);
			PropertyInfo propertyInfo2 = default(PropertyInfo);
			PropertyInfo[] array = default(PropertyInfo[]);
			int num4 = default(int);
			PropertyInfo propertyInfo = default(PropertyInfo);
			ParameterInfo[] indexParameters = default(ParameterInfo[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					object obj;
					switch (num2)
					{
					case 11:
						if (_003C_003Ec__DisplayClass13_.types != null)
						{
							num2 = 41;
							continue;
						}
						goto case 2;
					case 34:
						if (!(returnType != null))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 17;
					case 8:
					case 38:
						if (num5 >= num6)
						{
							num2 = 13;
							continue;
						}
						goto case 15;
					case 40:
						return propertyInfo2;
					case 2:
						num3 = 0;
						goto IL_0536;
					case 35:
						_003C_003Ec__DisplayClass13_.name = name;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 16;
						}
						continue;
					case 19:
						throw new AmbiguousMatchException();
					case 21:
						propertyInfo2 = array[num4];
						num2 = 28;
						continue;
					case 36:
						_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 16;
						}
						continue;
					case 18:
						return null;
					case 20:
					case 33:
						return propertyInfo;
					case 13:
					case 26:
						if (num5 < num6)
						{
							num2 = 3;
							continue;
						}
						goto case 34;
					case 5:
						if (_003C_003Ec__DisplayClass13_.types.Length == 0)
						{
							num2 = 37;
							continue;
						}
						goto IL_0480;
					case 7:
						if (array.Length != 0)
						{
							num2 = 31;
							continue;
						}
						goto case 43;
					case 25:
						num5 = 0;
						num2 = 8;
						continue;
					case 37:
						if (array.Length != 1)
						{
							if (returnType == null)
							{
								num2 = 12;
								continue;
							}
							goto IL_0480;
						}
						num2 = 22;
						continue;
					case 3:
					case 28:
						num4++;
						num2 = 4;
						continue;
					case 10:
						if (returnType.IsEquivalentTo(pKa7wGvBoFbKhTcIjvSQ(propertyInfo)))
						{
							num = 33;
							break;
						}
						goto case 18;
					case 15:
						if (u9gDuJvFjGVYaJcXI27b(v9lELEvBGLJKbBCO6OEy(indexParameters[num5]), _003C_003Ec__DisplayClass13_.types[num5]))
						{
							num2 = 15;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num2 = 26;
							}
							continue;
						}
						goto case 24;
					case 16:
						_003C_003Ec__DisplayClass13_.types = types;
						num = 14;
						break;
					case 6:
					case 23:
						if (!(propertyInfo2 != null))
						{
							num2 = 21;
							continue;
						}
						goto case 19;
					case 24:
						num5++;
						num2 = 38;
						continue;
					default:
						indexParameters = array[num4].GetIndexParameters();
						num2 = 25;
						continue;
					case 1:
					case 4:
						if (num4 < array.Length)
						{
							num2 = 30;
							continue;
						}
						goto case 40;
					case 39:
						_003C_003Ec__DisplayClass13_.ignoreCase = bindingAttr.HasFlag(BindingFlags.IgnoreCase);
						num2 = 29;
						continue;
					case 17:
						if (!u9gDuJvFjGVYaJcXI27b(returnType, pKa7wGvBoFbKhTcIjvSQ(array[num4])))
						{
							num2 = 23;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 3;
					case 43:
						return null;
					case 31:
						if (_003C_003Ec__DisplayClass13_.types != null)
						{
							num2 = 5;
							continue;
						}
						goto case 37;
					case 14:
						hSKmUAvBW1ZhVLA6MWdh(_003C_003Ec__DisplayClass13_.name, pJdceWvBBjAs1TmbxpNP(-882126494 ^ -882123404));
						num2 = 39;
						continue;
					case 22:
						propertyInfo = array[0];
						num2 = 42;
						continue;
					case 29:
						array = GetProperties(bindingAttr).Where(_003C_003Ec__DisplayClass13_._003CGetPropertyImpl_003Eb__0).ToArray();
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 6;
						}
						continue;
					case 42:
						if (!(returnType != null))
						{
							num2 = 20;
							continue;
						}
						goto case 10;
					case 12:
						throw new AmbiguousMatchException();
					case 9:
						num4 = 0;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 1;
						}
						continue;
					case 27:
						obj = binder;
						if (obj != null)
						{
							goto IL_050c;
						}
						num2 = 32;
						continue;
					case 32:
						obj = ob6lLIvBb7XI3N2Kw73P();
						goto IL_050c;
					case 41:
						{
							num3 = _003C_003Ec__DisplayClass13_.types.Length;
							goto IL_0536;
						}
						IL_050c:
						return (PropertyInfo)yFuIvkvBhGvB3a2lXyop(obj, bindingAttr, array, returnType, _003C_003Ec__DisplayClass13_.types, modifiers);
						IL_0480:
						if (!bindingAttr.HasFlag(BindingFlags.ExactBinding))
						{
							num2 = 27;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num2 = 26;
							}
						}
						else
						{
							propertyInfo2 = null;
							num2 = 11;
						}
						continue;
						IL_0536:
						num6 = num3;
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					break;
				}
			}
		}

		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (bindingAttr.HasFlag(BindingFlags.Instance | BindingFlags.Public))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return (MethodInfo[])d8hYn3vBEh68i59jNL9a(this, bindingAttr);
				case 1:
					return GetProperties(bindingAttr).SelectMany((PropertyInfo p) => p.GetAccessors()).Concat(((IEnumerable<MethodInfo>)d8hYn3vBEh68i59jNL9a(this, bindingAttr)).Except(ExceptMethods)).ToArray();
				}
			}
		}

		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			//Discarded unreachable code: IL_00a6, IL_00b5, IL_00c5, IL_017a, IL_0189, IL_0341, IL_0350, IL_0360
			int num = 10;
			MethodInfo methodInfo = default(MethodInfo);
			MethodInfo[] array = default(MethodInfo[]);
			_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
			MethodBase[] array2 = default(MethodBase[]);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 11:
						return methodInfo;
					case 16:
						return FindMostDerivedNewSlotMeth(array2) as MethodInfo;
					case 24:
					case 25:
						if (binder != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 19;
					case 2:
						throw new AmbiguousMatchException();
					case 23:
						array2 = array;
						num = 16;
						break;
					case 15:
						_003C_003Ec__DisplayClass19_.bindingAttr = bindingAttr;
						num2 = 14;
						continue;
					case 12:
						_003C_003Ec__DisplayClass19_.ignoreCase = _003C_003Ec__DisplayClass19_.bindingAttr.HasFlag(BindingFlags.IgnoreCase);
						num2 = 7;
						continue;
					case 21:
						if (_003C_003Ec__DisplayClass19_.types.Length != 0)
						{
							num2 = 24;
							continue;
						}
						goto case 20;
					case 3:
					case 18:
					{
						Binder binder2 = binder;
						BindingFlags bindingAttr2 = _003C_003Ec__DisplayClass19_.bindingAttr;
						array2 = array;
						return FEPuPpvBfBvlAccbKoDd(binder2, bindingAttr2, array2, _003C_003Ec__DisplayClass19_.types, modifiers) as MethodInfo;
					}
					case 13:
						hSKmUAvBW1ZhVLA6MWdh(_003C_003Ec__DisplayClass19_.name, pJdceWvBBjAs1TmbxpNP(-35995181 ^ -35992123));
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 12;
						}
						continue;
					case 20:
						methodInfo = array[0];
						num2 = 5;
						continue;
					case 22:
						return null;
					case 9:
						_003C_003Ec__DisplayClass19_.name = name;
						num2 = 15;
						continue;
					case 4:
					case 8:
						if (num3 < array.Length)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 23;
					default:
						num3 = 1;
						num2 = 4;
						continue;
					case 17:
						_003C_003Ec__DisplayClass19_.types = types;
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 8;
						}
						continue;
					case 19:
						binder = (Binder)ob6lLIvBb7XI3N2Kw73P();
						num = 18;
						break;
					case 26:
						if (array.Length != 0)
						{
							if (_003C_003Ec__DisplayClass19_.types != null)
							{
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num2 = 21;
								}
								continue;
							}
							goto case 20;
						}
						num2 = 22;
						continue;
					case 10:
						_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
						num2 = 9;
						continue;
					case 1:
					case 6:
						if (array[num3].GetParameters().SequenceEqual(methodInfo.GetParameters()))
						{
							num3++;
							num2 = 8;
						}
						else
						{
							num2 = 2;
						}
						continue;
					case 5:
						if (array.Length != 1)
						{
							if (_003C_003Ec__DisplayClass19_.types != null)
							{
								num2 = 25;
								continue;
							}
							goto default;
						}
						num2 = 11;
						continue;
					case 7:
						array = GetMethods(_003C_003Ec__DisplayClass19_.bindingAttr).Where(_003C_003Ec__DisplayClass19_._003CGetMethodImpl_003Eb__0).ToArray();
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 26;
						}
						continue;
					case 14:
						_003C_003Ec__DisplayClass19_.callConvention = callConvention;
						num2 = 17;
						continue;
					}
					break;
				}
			}
		}

		private static bool FilterApplyMethodBase(object methodBase, BindingFlags bindingFlags, CallingConventions callConv, object argumentTypes)
		{
			//Discarded unreachable code: IL_00f2, IL_01d8, IL_020f, IL_021e, IL_0280, IL_02d2, IL_02e1, IL_02f1, IL_0325, IL_0358
			int num = 12;
			int num2 = num;
			ParameterInfo parameterInfo = default(ParameterInfo);
			bool flag = default(bool);
			ParameterInfo[] array = default(ParameterInfo[]);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 34:
					if (parameterInfo.IsDefined(DKeLeQvB8H0v1tHVEE47(typeof(ParamArrayAttribute).TypeHandle), inherit: false))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 24;
				case 21:
				case 23:
				case 36:
					if (flag)
					{
						num2 = 27;
						break;
					}
					goto default;
				case 8:
				case 9:
					return false;
				case 31:
					return false;
				case 1:
					flag = true;
					num2 = 36;
					break;
				case 4:
					if (v9lELEvBGLJKbBCO6OEy(array[num3]) != ((object[])argumentTypes)[num3])
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 13;
						}
						break;
					}
					goto IL_01e4;
				case 10:
					if (!pkmfd6vBQwQojcHpeMtJ(methodBase).HasFlag(CallingConventions.Standard))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 9;
						}
						break;
					}
					goto IL_010f;
				case 29:
					if (((Array)argumentTypes).Length != array.Length)
					{
						num2 = 22;
						break;
					}
					if (!bindingFlags.HasFlag(BindingFlags.ExactBinding))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 30;
				case 13:
					return false;
				case 17:
					if (((Array)argumentTypes).Length <= array.Length)
					{
						num2 = 33;
						break;
					}
					goto case 15;
				case 37:
					return false;
				case 7:
					if (v9lELEvBGLJKbBCO6OEy(parameterInfo).IsArray)
					{
						num2 = 34;
						break;
					}
					goto case 24;
				case 35:
					num3 = 0;
					num2 = 18;
					break;
				case 24:
					return false;
				case 2:
				case 38:
					flag = true;
					num2 = 23;
					break;
				case 16:
					if (!pkmfd6vBQwQojcHpeMtJ(methodBase).HasFlag(CallingConventions.VarArgs))
					{
						num2 = 8;
						break;
					}
					goto case 19;
				case 32:
				case 33:
					if (!bindingFlags.HasFlag(BindingFlags.OptionalParamBinding))
					{
						num2 = 2;
						break;
					}
					goto case 25;
				case 11:
					if (!callConv.HasFlag(CallingConventions.Any))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 39;
						}
						break;
					}
					goto IL_010f;
				case 22:
					if (bindingFlags.HasFlag(BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetProperty | BindingFlags.SetProperty))
					{
						flag = false;
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 17;
						}
					}
					else
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 21;
						}
					}
					break;
				case 26:
					if (u9gDuJvFjGVYaJcXI27b((Type)((object[])argumentTypes)[num3], null))
					{
						num2 = 4;
						break;
					}
					goto IL_01e4;
				case 18:
				case 28:
					if (num3 >= array.Length)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 26;
				case 27:
					if (array.Length == 0)
					{
						num2 = 20;
					}
					else if (((Array)argumentTypes).Length >= array.Length - 1)
					{
						parameterInfo = array[array.Length - 1];
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 7;
						}
					}
					else
					{
						num2 = 37;
					}
					break;
				default:
					return true;
				case 19:
					if (callConv.HasFlag(CallingConventions.Standard))
					{
						num2 = 10;
						break;
					}
					goto IL_010f;
				case 25:
					if (BaXUZavBvRA99PtiTmlj(array[((Array)argumentTypes).Length]))
					{
						num2 = 21;
						break;
					}
					goto case 2;
				case 39:
					if (callConv.HasFlag(CallingConventions.VarArgs))
					{
						num2 = 16;
						break;
					}
					goto case 19;
				case 12:
					bindingFlags ^= BindingFlags.DeclaredOnly;
					num2 = 11;
					break;
				case 6:
					array = (ParameterInfo[])LV5mIBvBCA8e5YJnpXMP(methodBase);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 29;
					}
					break;
				case 15:
					if (!pkmfd6vBQwQojcHpeMtJ(methodBase).HasFlag(CallingConventions.VarArgs))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 21;
				case 20:
					return false;
				case 30:
					{
						if (!bindingFlags.HasFlag(BindingFlags.InvokeMethod))
						{
							num2 = 35;
							break;
						}
						goto default;
					}
					IL_010f:
					if (argumentTypes == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 14;
						}
						break;
					}
					goto case 6;
					IL_01e4:
					num3++;
					num2 = 28;
					break;
				}
			}
		}

		private static MethodBase FindMostDerivedNewSlotMeth(object match)
		{
			//Discarded unreachable code: IL_00d2, IL_00e1, IL_00f1, IL_0100
			int num = 3;
			int num5 = default(int);
			int num4 = default(int);
			MethodBase result = default(MethodBase);
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
					case 10:
						if (num5 >= ((Array)match).Length)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 12;
					case 3:
						num4 = 0;
						num2 = 2;
						continue;
					case 7:
						throw new AmbiguousMatchException();
					case 1:
						return result;
					case 11:
						result = (MethodBase)((object[])match)[num5];
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						continue;
					case 8:
						num5 = 0;
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 2;
						}
						continue;
					default:
						num5++;
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 3;
						}
						continue;
					case 12:
						num3 = RhwExBvBZ02v6gIOD1TI(((MemberInfo)((object[])match)[num5]).DeclaringType);
						num2 = 6;
						continue;
					case 9:
						num4 = num3;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 11;
						}
						continue;
					case 2:
						result = null;
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						if (num3 == num4)
						{
							break;
						}
						if (num3 <= num4)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 9;
					}
					break;
				}
				num = 7;
			}
		}

		private static int GetHierarchyDepth(Type t)
		{
			int num = 2;
			int num2 = num;
			Type type = default(Type);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 4:
					type = type.BaseType;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					type = t;
					num2 = 3;
					continue;
				case 2:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (!u9gDuJvFjGVYaJcXI27b(type, null))
					{
						num2 = 5;
						continue;
					}
					break;
				case 5:
					return num3;
				case 3:
					break;
				}
				num3++;
				num2 = 4;
			}
		}

		internal static void LdOoqjvFg1T6hbHnlEXN()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static Type vekDskvF5hygG5GnmJfo(object P_0)
		{
			return ((RipeType)P_0).Raw;
		}

		internal static bool u9gDuJvFjGVYaJcXI27b(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static bool kPGA7HvFlG4nbgi4skRA()
		{
			return j41j02vFdvRev0bxOq7C == null;
		}

		internal static TypeDelegator b20QWPvFrHXoPLUdZ0Bb()
		{
			return (TypeDelegator)j41j02vFdvRev0bxOq7C;
		}

		internal static object PvyAghvFY4pDNnGa5cxR(object P_0)
		{
			return ((MemberReference)P_0).get_Name();
		}

		internal static void Iax2fPvFL4GcGj7DdAVD(object P_0, object P_1)
		{
			((EntityPropertyInfo)P_0).UpdateCustomAttributes((PropertyDefinition)P_1);
		}

		internal static bool i90OcuvFUNEnnty0wd5h(object P_0)
		{
			return ((PropertyDefinition)P_0).get_HasThis();
		}

		internal static bool AgTM77vFspaUry7MeBqt(object P_0)
		{
			return ((PropertyDefinition)P_0).get_HasCustomAttributes();
		}

		internal static object D6IMipvFchZTSpGYmD21(Type P_0)
		{
			return TypeDescriptor.GetProvider(P_0);
		}

		internal static Type qgEu4DvFzGr6ZIIfQnPT(object P_0, Type P_1)
		{
			return ((TypeDescriptionProvider)P_0).GetReflectionType(P_1);
		}

		internal static object rkMBcivBFkwt4fTFdYua(object P_0, BindingFlags P_1)
		{
			return ((System.Reflection.TypeDelegator)P_0).GetProperties(P_1);
		}

		internal static object pJdceWvBBjAs1TmbxpNP(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void hSKmUAvBW1ZhVLA6MWdh(object P_0, object P_1)
		{
			Contract.NotNull(P_0, (string)P_1);
		}

		internal static Type pKa7wGvBoFbKhTcIjvSQ(object P_0)
		{
			return ((PropertyInfo)P_0).PropertyType;
		}

		internal static object ob6lLIvBb7XI3N2Kw73P()
		{
			return Type.DefaultBinder;
		}

		internal static object yFuIvkvBhGvB3a2lXyop(object P_0, BindingFlags P_1, object P_2, Type P_3, object P_4, object P_5)
		{
			return ((Binder)P_0).SelectProperty(P_1, (PropertyInfo[])P_2, P_3, (Type[])P_4, (ParameterModifier[])P_5);
		}

		internal static Type v9lELEvBGLJKbBCO6OEy(object P_0)
		{
			return ((ParameterInfo)P_0).ParameterType;
		}

		internal static object d8hYn3vBEh68i59jNL9a(object P_0, BindingFlags P_1)
		{
			return ((System.Reflection.TypeDelegator)P_0).GetMethods(P_1);
		}

		internal static object FEPuPpvBfBvlAccbKoDd(object P_0, BindingFlags P_1, object P_2, object P_3, object P_4)
		{
			return ((Binder)P_0).SelectMethod(P_1, (MethodBase[])P_2, (Type[])P_3, (ParameterModifier[])P_4);
		}

		internal static CallingConventions pkmfd6vBQwQojcHpeMtJ(object P_0)
		{
			return ((MethodBase)P_0).CallingConvention;
		}

		internal static object LV5mIBvBCA8e5YJnpXMP(object P_0)
		{
			return ((MethodBase)P_0).GetParameters();
		}

		internal static bool BaXUZavBvRA99PtiTmlj(object P_0)
		{
			return ((ParameterInfo)P_0).IsOptional;
		}

		internal static Type DKeLeQvB8H0v1tHVEE47(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static int RhwExBvBZ02v6gIOD1TI(Type t)
		{
			return GetHierarchyDepth(t);
		}
	}

	internal class EntityPropertyInfo : PropertyInfo
	{
		private readonly ParameterInfo[] indexParameters;

		private readonly TypeReference propertyTypeReference;

		private Type propertyType;

		private MethodInfo getMethod;

		private MethodInfo setMethod;

		private MethodInfo[] accessors;

		private IAccessor accessor;

		private PublishCacheContext.Local<CustomAttributesData> customAttributesData;

		private static EntityPropertyInfo oY1qMpvBuYsQ8qKH1v2o;

		public override Type DeclaringType { get; }

		public override Type ReflectedType { get; }

		public override string Name { get; }

		public override Type PropertyType
		{
			get
			{
				int num = 2;
				int num2 = num;
				Type type = default(Type);
				Type type2;
				while (true)
				{
					switch (num2)
					{
					case 1:
						type = (propertyType = EntityDynamicGenerator.Resolve(propertyTypeReference));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						type2 = propertyType;
						if ((object)type2 == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					default:
						type2 = type;
						break;
					}
					break;
				}
				return type2;
			}
		}

		public override bool CanRead { get; }

		public override bool CanWrite { get; }

		public override PropertyAttributes Attributes => PropertyAttributes.None;

		public override Module Module => dwnZluvBqcyKZbLWe5SB(this).Module;

		internal IAccessor Accessor
		{
			get
			{
				int num = 1;
				int num2 = num;
				IAccessor accessor = default(IAccessor);
				IAccessor obj;
				while (true)
				{
					switch (num2)
					{
					default:
						accessor = (this.accessor = (IAccessor)GcA65evBNUdLoUjNoUSI(DeclaringType, Name, true));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 2;
						}
						continue;
					case 1:
						obj = this.accessor;
						if (obj != null)
						{
							break;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						obj = accessor;
						break;
					}
					break;
				}
				return obj;
			}
		}

		internal EntityPropertyInfo(Type runtimeType, PropertyDefinition propertyDefinition)
		{
			//Discarded unreachable code: IL_004f
			SingletonReader.JJCZtPuTvSt();
			indexParameters = new ParameterInfo[0];
			customAttributesData = new PublishCacheContext.Local<CustomAttributesData>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 7:
					ReflectedType = runtimeType;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num = 1;
					}
					break;
				case 3:
					return;
				case 6:
					CanRead = propertyDefinition.get_GetMethod() != null;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					DeclaringType = runtimeType;
					num = 7;
					break;
				default:
					CanWrite = oI5MiFvBRUT64lURmohB(propertyDefinition) != null;
					num = 5;
					break;
				case 1:
					Name = (string)cSH7dsvBSfgq8nU4mIEo(propertyDefinition);
					num = 4;
					break;
				case 4:
					propertyTypeReference = (TypeReference)OgyxEkvBiSu464kgttYn(((PropertyReference)propertyDefinition).get_PropertyType());
					num = 6;
					break;
				case 5:
				{
					UpdateCustomAttributes(propertyDefinition);
					int num2 = 3;
					num = num2;
					break;
				}
				}
			}
		}

		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			return TRLZ60vBX1w1K4hNYI8H(I4fUF5vBKrbH08ELFcJe(this), obj, null);
		}

		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
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
					TRLZ60vBX1w1K4hNYI8H(SetMethod, obj, new object[1] { value });
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override ParameterInfo[] GetIndexParameters()
		{
			return indexParameters;
		}

		public override string ToString()
		{
			return (string)W13xf4vBnP69rWrqrboM(NKnA2svBTET25WXFcKRi(-1710575414 ^ -1710535014), kaIWg1vBkW0sYynacL2b(this), Name);
		}

		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			//Discarded unreachable code: IL_00bc
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			int num = 1;
			int num2 = num;
			MethodInfo result = default(MethodInfo);
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 3:
					result = (getMethod = new EntityGetPropertyMethodInfo(dwnZluvBqcyKZbLWe5SB(this), ReflectedType, (string)eppuLHvB2RcWtGkdNAI2(this), kaIWg1vBkW0sYynacL2b(this), (IGetter)Accessor));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					obj = getMethod;
					if (obj == null)
					{
						num2 = 3;
						continue;
					}
					break;
				case 1:
					if (!m9rVp7vBOu35AMBKAyWg(this))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 2:
					return result;
				default:
					obj = null;
					break;
				}
				break;
			}
			return (MethodInfo)obj;
		}

		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			//Discarded unreachable code: IL_0035, IL_0044
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			int num = 4;
			int num2 = num;
			object obj;
			MethodInfo result = default(MethodInfo);
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = setMethod;
					if (obj == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 4:
					if (!TgXmF2vBePX6ORcxVi0l(this))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 2:
					result = (setMethod = new EntitySetPropertyMethodInfo(DeclaringType, z8UnhJvBPvKDikq98HEE(this), (string)eppuLHvB2RcWtGkdNAI2(this), PropertyType, (ISetter)Accessor));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return result;
				case 3:
					obj = null;
					break;
				}
				break;
			}
			return (MethodInfo)obj;
		}

		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			int num = 1;
			int num2 = num;
			MethodInfo[] array2;
			MethodInfo[] array = default(MethodInfo[]);
			while (true)
			{
				switch (num2)
				{
				case 1:
					array2 = accessors;
					if (array2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					array = (accessors = ((!TgXmF2vBePX6ORcxVi0l(this)) ? new MethodInfo[1] { (MethodInfo)I4fUF5vBKrbH08ELFcJe(this) } : (m9rVp7vBOu35AMBKAyWg(this) ? new MethodInfo[2]
					{
						GetMethod,
						(MethodInfo)bU6HTPvB1xQv7j7U5jpj(this)
					} : new MethodInfo[1] { (MethodInfo)bU6HTPvB1xQv7j7U5jpj(this) })));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					array2 = array;
					break;
				}
				break;
			}
			return array2;
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

		internal void UpdateCustomAttributes(PropertyDefinition propertyDefinition)
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
					customAttributesData.Value = new CustomAttributesData((ICollection<CustomAttribute>)propertyDefinition.get_CustomAttributes());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static object cSH7dsvBSfgq8nU4mIEo(object P_0)
		{
			return ((MemberReference)P_0).get_Name();
		}

		internal static object OgyxEkvBiSu464kgttYn(object P_0)
		{
			return EntityDynamicGenerator.CreateReference((TypeReference)P_0);
		}

		internal static object oI5MiFvBRUT64lURmohB(object P_0)
		{
			return ((PropertyDefinition)P_0).get_SetMethod();
		}

		internal static bool faQqdFvBINe81UuEMvBq()
		{
			return (object)oY1qMpvBuYsQ8qKH1v2o == null;
		}

		internal static EntityPropertyInfo bEnSo9vBVfoB3RSM6pWn()
		{
			return oY1qMpvBuYsQ8qKH1v2o;
		}

		internal static Type dwnZluvBqcyKZbLWe5SB(object P_0)
		{
			return ((MemberInfo)P_0).DeclaringType;
		}

		internal static object I4fUF5vBKrbH08ELFcJe(object P_0)
		{
			return ((PropertyInfo)P_0).GetMethod;
		}

		internal static object TRLZ60vBX1w1K4hNYI8H(object P_0, object P_1, object P_2)
		{
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}

		internal static object NKnA2svBTET25WXFcKRi(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static Type kaIWg1vBkW0sYynacL2b(object P_0)
		{
			return ((PropertyInfo)P_0).PropertyType;
		}

		internal static object W13xf4vBnP69rWrqrboM(object P_0, object P_1, object P_2)
		{
			return string.Format((string)P_0, P_1, P_2);
		}

		internal static bool m9rVp7vBOu35AMBKAyWg(object P_0)
		{
			return ((PropertyInfo)P_0).CanRead;
		}

		internal static object eppuLHvB2RcWtGkdNAI2(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static bool TgXmF2vBePX6ORcxVi0l(object P_0)
		{
			return ((PropertyInfo)P_0).CanWrite;
		}

		internal static Type z8UnhJvBPvKDikq98HEE(object P_0)
		{
			return ((MemberInfo)P_0).ReflectedType;
		}

		internal static object bU6HTPvB1xQv7j7U5jpj(object P_0)
		{
			return ((PropertyInfo)P_0).SetMethod;
		}

		internal static object GcA65evBNUdLoUjNoUSI(Type type, object P_1, bool declaredOnly)
		{
			return type.GetAccessor((string)P_1, declaredOnly);
		}
	}

	private static EntityDynamicProvider instance;

	private static readonly ISet<Type> providerTypes;

	private static readonly IDictionary<Type, TypeDelegator> types;

	private static readonly IDictionary<Type, ICustomTypeDescriptor> typeDelegators;

	private static ILogger entityDynamicProviderLogger;

	internal static EntityDynamicProvider Tu1cFuhVgZIiBXftthqM;

	internal static EntityDynamicProvider Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			EntityDynamicProvider entityDynamicProvider;
			while (true)
			{
				switch (num2)
				{
				case 1:
					entityDynamicProvider = instance;
					if (entityDynamicProvider == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					entityDynamicProvider = new EntityDynamicProvider();
					break;
				}
				break;
			}
			return entityDynamicProvider;
		}
	}

	internal static void AddType(Type type, TypeDefinition typeDefinition = null)
	{
		//Discarded unreachable code: IL_005e, IL_006d, IL_007d, IL_00ae
		int num = 7;
		int num2 = num;
		TypeDelegator value = default(TypeDelegator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				ehSbyLhVYB21B8GthfV5(Instance, type);
				num2 = 9;
				break;
			case 1:
				value = (types[type] = new TypeDelegator(type));
				num2 = 4;
				break;
			case 0:
				return;
			case 7:
				if (!providerTypes.Add(type))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 4:
				RcqbOShVLAsbs9KSBdIs(value, typeDefinition);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			case 8:
				if (typeDefinition != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 5:
				return;
			case 3:
			case 9:
				if (!types.TryGetValue(type, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public EntityDynamicProvider()
	{
		//Discarded unreachable code: IL_0039, IL_003e
		pg8dWShVUiTQCQKHamqB();
		base._002Ector((TypeDescriptionProvider)oMQCvThVctZDE8ThSna8(z6EXhehVsyoEBcWjnlvG(typeof(object).TypeHandle)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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
			instance = this;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
			{
				num = 1;
			}
		}
	}

	public override bool IsSupportedType(Type type)
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Ta5V97hVzYoQ18r8LGha(type.Assembly);
			default:
				return false;
			case 1:
				if (type.IsEnum)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override Type GetRuntimeType(Type reflectionType)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 1;
		int num2 = num;
		BaseTypeDelegator baseTypeDelegator = default(BaseTypeDelegator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ITnDXJhSFC6PpHT7jUnv(this, reflectionType);
			default:
				return Tg5YbuhSBIiw9GPixrua(baseTypeDelegator);
			case 1:
				if ((object)(baseTypeDelegator = reflectionType as BaseTypeDelegator) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
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
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		TypeDelegator value = default(TypeDelegator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (types.TryGetValue(objectType, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return objectType;
			default:
				return value;
			}
		}
	}

	public override ICustomTypeDescriptor GetTypeDescriptor(Type type, object instance)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass15_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass15_.instance = instance;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return typeDelegators.GetOrAdd((type is TypeDelegator typeDelegator) ? Tg5YbuhSBIiw9GPixrua(typeDelegator) : type, _003C_003Ec__DisplayClass15_._003CGetTypeDescriptor_003Eb__0);
			}
		}
	}

	static EntityDynamicProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				providerTypes = new HashSet<Type>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				pg8dWShVUiTQCQKHamqB();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 3:
				entityDynamicProviderLogger = (ILogger)ArWCe3hSWlBmlM8Wb5ku(typeof(EntityDynamicProvider));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				typeDelegators = PublishCacheContext.CreateCache(delegate(IDictionary<Type, ICustomTypeDescriptor> c, Type type, Guid _)
				{
					c.Remove(type);
				});
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				types = PublishCacheContext.CreateCache<Type, TypeDelegator>();
				num2 = 5;
				break;
			}
		}
	}

	internal static bool akLfDAhV5nh06Mcs0b7D()
	{
		return Tu1cFuhVgZIiBXftthqM == null;
	}

	internal static EntityDynamicProvider BcMC2uhVjRThBtTyG8RO()
	{
		return Tu1cFuhVgZIiBXftthqM;
	}

	internal static void ehSbyLhVYB21B8GthfV5(object P_0, Type P_1)
	{
		TypeDescriptor.AddProvider((TypeDescriptionProvider)P_0, P_1);
	}

	internal static void RcqbOShVLAsbs9KSBdIs(object P_0, object P_1)
	{
		((BaseTypeDelegator)P_0).InitType((TypeDefinition)P_1);
	}

	internal static void pg8dWShVUiTQCQKHamqB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type z6EXhehVsyoEBcWjnlvG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object oMQCvThVctZDE8ThSna8(Type P_0)
	{
		return TypeDescriptor.GetProvider(P_0);
	}

	internal static bool Ta5V97hVzYoQ18r8LGha(object P_0)
	{
		return ((Assembly)P_0).IsDynamicAssembly();
	}

	internal static Type ITnDXJhSFC6PpHT7jUnv(object P_0, Type P_1)
	{
		return ((TypeDescriptionProvider)P_0).GetRuntimeType(P_1);
	}

	internal static Type Tg5YbuhSBIiw9GPixrua(object P_0)
	{
		return ((BaseTypeDelegator)P_0).RuntimeType;
	}

	internal static object ArWCe3hSWlBmlM8Wb5ku(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static object seaykUhSoiNtHn0h2YUS(object P_0, Type P_1, object P_2)
	{
		return ((TypeDescriptionProvider)P_0).GetTypeDescriptor(P_1, P_2);
	}
}
