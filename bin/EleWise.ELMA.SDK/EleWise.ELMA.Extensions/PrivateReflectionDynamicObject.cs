using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class PrivateReflectionDynamicObjectExtensions
{
	internal class PrivateReflectionDynamicObject : DynamicObject
	{
		private interface IProperty
		{
			string Name { get; }

			object GetValue(object obj, object[] index);

			void SetValue(object obj, object val, object[] index);
		}

		private class Property : IProperty
		{
			internal static object gpE8WsZnPrFyxuUnnSUM;

			internal PropertyInfo PropertyInfo
			{
				[CompilerGenerated]
				get
				{
					return _003CPropertyInfo_003Ek__BackingField;
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
							_003CPropertyInfo_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			string IProperty.Name => (string)skO2dhZn3ID4QWCw3CJx(PropertyInfo);

			object IProperty.GetValue(object obj, object[] index)
			{
				return bwxU4pZnpJWRw0wjZjFq(PropertyInfo, obj, index);
			}

			void IProperty.SetValue(object obj, object val, object[] index)
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
						PropertyInfo.SetValue(obj, val, index);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public Property()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				wHyqGEZnavDE8rcSSPUy();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool y3NsMfZn1MdQimu4vBKs()
			{
				return gpE8WsZnPrFyxuUnnSUM == null;
			}

			internal static Property aqZFt3ZnNXtPWbnHsUfB()
			{
				return (Property)gpE8WsZnPrFyxuUnnSUM;
			}

			internal static object skO2dhZn3ID4QWCw3CJx(object P_0)
			{
				return ((MemberInfo)P_0).Name;
			}

			internal static object bwxU4pZnpJWRw0wjZjFq(object P_0, object P_1, object P_2)
			{
				return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
			}

			internal static void wHyqGEZnavDE8rcSSPUy()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		private class Field : IProperty
		{
			private static object ISQeLYZnDU2DEhSLqb4r;

			internal FieldInfo FieldInfo
			{
				[CompilerGenerated]
				get
				{
					return _003CFieldInfo_003Ek__BackingField;
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
							_003CFieldInfo_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			string IProperty.Name => (string)TOKy2oZn4iRCoD37ldHY(FieldInfo);

			object IProperty.GetValue(object obj, object[] index)
			{
				return ujjodVZn6mt3dZ9AZ2U1(FieldInfo, obj);
			}

			void IProperty.SetValue(object obj, object val, object[] index)
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
						iw0owKZnHpmqTkygRqo0(FieldInfo, obj, val);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			public Field()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				zdOXaPZnAgojOr7apoA2();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool vlE2bVZntHTl4FHscUtd()
			{
				return ISQeLYZnDU2DEhSLqb4r == null;
			}

			internal static Field m4nIpuZnw6wOXqE91e5q()
			{
				return (Field)ISQeLYZnDU2DEhSLqb4r;
			}

			internal static object TOKy2oZn4iRCoD37ldHY(object P_0)
			{
				return ((MemberInfo)P_0).Name;
			}

			internal static object ujjodVZn6mt3dZ9AZ2U1(object P_0, object P_1)
			{
				return ((FieldInfo)P_0).GetValue(P_1);
			}

			internal static void iw0owKZnHpmqTkygRqo0(object P_0, object P_1, object P_2)
			{
				((FieldInfo)P_0).SetValue(P_1, P_2);
			}

			internal static void zdOXaPZnAgojOr7apoA2()
			{
				SingletonReader.JJCZtPuTvSt();
			}
		}

		private static readonly IDictionary<Type, IDictionary<string, IProperty>> PropertiesOnType;

		private static PrivateReflectionDynamicObject RKcbxC8frXgZ113DVgsF;

		private object RealObject
		{
			[CompilerGenerated]
			get
			{
				return _003CRealObject_003Ek__BackingField;
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
						_003CRealObject_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		internal static object WrapObjectIfNeeded(object o)
		{
			//Discarded unreachable code: IL_00b3, IL_00c2
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!o.GetType().IsPrimitive)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 2;
				case 2:
					return o;
				case 4:
				{
					PrivateReflectionDynamicObject privateReflectionDynamicObject = new PrivateReflectionDynamicObject();
					iSvSWn8fjYSxg679mcMO(privateReflectionDynamicObject, o);
					return privateReflectionDynamicObject;
				}
				case 1:
					if (o != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					if (!(o is string))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			int num = 2;
			int num2 = num;
			IProperty property = default(IProperty);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return true;
				case 1:
					result = iTxc3y8fYYTTq30iDS5W(property, RealObject, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					property = GetProperty(binder.Name);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					result = MqBnP98fLud7rNdbLvdd(result);
					num2 = 3;
					break;
				}
			}
		}

		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return true;
				case 1:
					OaTwIX8fs3GSQ7mibcFg(GetProperty((string)FJEWeT8fU3MK1x1CO60l(binder)), RealObject, value, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
		{
			int num = 2;
			int num2 = num;
			IProperty indexProperty = default(IProperty);
			while (true)
			{
				switch (num2)
				{
				default:
					result = WrapObjectIfNeeded(result);
					num2 = 3;
					break;
				case 3:
					return true;
				case 2:
					indexProperty = GetIndexProperty();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					result = iTxc3y8fYYTTq30iDS5W(indexProperty, RealObject, indexes);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return true;
				case 1:
					GetIndexProperty().SetValue(RealObject, value, indexes);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return true;
				case 2:
					result = KxBg7g8fz5HPiF86oeNd(RealObject.GetType(), RealObject, nblhP08fc6YMdLDFy7lr(binder), args);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					result = MqBnP98fLud7rNdbLvdd(result);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override bool TryConvert(ConvertBinder binder, out object result)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					result = eoqiJE8QBSL3BGEyaNjM(RealObject, jaf9eN8QF5XwQcN93Dur(binder));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return true;
				}
			}
		}

		public override string ToString()
		{
			return RealObject.ToString();
		}

		private IProperty GetIndexProperty()
		{
			return GetProperty((string)WUWAve8QWWBdM6V3yeiU(-138018305 ^ -138016623));
		}

		private IProperty GetProperty(string propertyName)
		{
			//Discarded unreachable code: IL_008a
			int num = 3;
			int num2 = num;
			IDictionary<string, IProperty> typeProperties = default(IDictionary<string, IProperty>);
			IProperty value = default(IProperty);
			IOrderedEnumerable<string> values = default(IOrderedEnumerable<string>);
			while (true)
			{
				switch (num2)
				{
				case 3:
					typeProperties = GetTypeProperties(RealObject.GetType());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					if (!typeProperties.TryGetValue(propertyName, out value))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				default:
					throw new ArgumentException((string)t8tSp28QoavwpRI0NKgN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195890281), propertyName, RealObject.GetType(), string.Join((string)WUWAve8QWWBdM6V3yeiU(-2106517564 ^ -2106516538), values)));
				case 4:
					return value;
				case 1:
					values = from name in typeProperties.Keys
						where _003C_003Ec.NMItdmZnyD4KnOUntW98(name, 0) != '<'
						orderby name
						select name;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private static IDictionary<string, IProperty> GetTypeProperties(Type type)
		{
			_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
			CS_0024_003C_003E8__locals0.type = type;
			if (PropertiesOnType.TryGetValue(CS_0024_003C_003E8__locals0.type, out var value))
			{
				return value;
			}
			value = new ConcurrentDictionary<string, IProperty>();
			foreach (PropertyInfo item in from p in CS_0024_003C_003E8__locals0.type.GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where _003C_003Ec__DisplayClass19_0.np57IWZnlN4InbDxX15X(p.DeclaringType, CS_0024_003C_003E8__locals0.type)
				select p)
			{
				value[item.Name] = new Property
				{
					PropertyInfo = item
				};
			}
			foreach (FieldInfo item2 in from p in CS_0024_003C_003E8__locals0.type.GetReflectionFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where _003C_003Ec__DisplayClass19_0.np57IWZnlN4InbDxX15X(p.DeclaringType, CS_0024_003C_003E8__locals0.type)
				select p)
			{
				value[item2.Name] = new Field
				{
					FieldInfo = item2
				};
			}
			if (CS_0024_003C_003E8__locals0.type.BaseType != null)
			{
				foreach (IProperty value2 in GetTypeProperties(CS_0024_003C_003E8__locals0.type.BaseType).Values)
				{
					value[value2.Name] = value2;
				}
			}
			PropertiesOnType[CS_0024_003C_003E8__locals0.type] = value;
			return value;
		}

		private static object InvokeMemberOnType(Type type, object target, object name, object args)
		{
			//Discarded unreachable code: IL_0053, IL_0085, IL_00c2, IL_00d1, IL_0109, IL_0118
			object obj = default(object);
			switch (1)
			{
			default:
				return obj;
			case 1:
				try
				{
					obj = type.InvokeMember((string)name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, (object[])args);
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num = 0;
					}
					return num switch
					{
						0 => obj, 
						_ => obj, 
					};
				}
				catch (MissingMethodException)
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 2:
							return obj;
						default:
							obj = KxBg7g8fz5HPiF86oeNd(type.BaseType, target, name, args);
							num2 = 2;
							continue;
						case 1:
							if (teuLqY8Qb8hAiHIEhWtM(type.BaseType, null))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						case 3:
							break;
						}
						break;
					}
					throw;
				}
			}
		}

		public PrivateReflectionDynamicObject()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			njOn3c8QhomIWFtVF4Cm();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static PrivateReflectionDynamicObject()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					njOn3c8QhomIWFtVF4Cm();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					PropertiesOnType = new ConcurrentDictionary<Type, IDictionary<string, IProperty>>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool IHUE7f8fgnBFtwaDHxuX()
		{
			return RKcbxC8frXgZ113DVgsF == null;
		}

		internal static PrivateReflectionDynamicObject Esv0Ll8f56OhdhqrCi4m()
		{
			return RKcbxC8frXgZ113DVgsF;
		}

		internal static void iSvSWn8fjYSxg679mcMO(object P_0, object P_1)
		{
			((PrivateReflectionDynamicObject)P_0).RealObject = P_1;
		}

		internal static object iTxc3y8fYYTTq30iDS5W(object P_0, object P_1, object P_2)
		{
			return ((IProperty)P_0).GetValue(P_1, (object[])P_2);
		}

		internal static object MqBnP98fLud7rNdbLvdd(object P_0)
		{
			return WrapObjectIfNeeded(P_0);
		}

		internal static object FJEWeT8fU3MK1x1CO60l(object P_0)
		{
			return ((SetMemberBinder)P_0).Name;
		}

		internal static void OaTwIX8fs3GSQ7mibcFg(object P_0, object P_1, object P_2, object P_3)
		{
			((IProperty)P_0).SetValue(P_1, P_2, (object[])P_3);
		}

		internal static object nblhP08fc6YMdLDFy7lr(object P_0)
		{
			return ((InvokeMemberBinder)P_0).Name;
		}

		internal static object KxBg7g8fz5HPiF86oeNd(Type type, object P_1, object P_2, object P_3)
		{
			return InvokeMemberOnType(type, P_1, P_2, P_3);
		}

		internal static Type jaf9eN8QF5XwQcN93Dur(object P_0)
		{
			return ((ConvertBinder)P_0).Type;
		}

		internal static object eoqiJE8QBSL3BGEyaNjM(object P_0, Type P_1)
		{
			return Convert.ChangeType(P_0, P_1);
		}

		internal static object WUWAve8QWWBdM6V3yeiU(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object t8tSp28QoavwpRI0NKgN(object P_0, object P_1, object P_2, object P_3)
		{
			return string.Format((string)P_0, P_1, P_2, P_3);
		}

		internal static bool teuLqY8Qb8hAiHIEhWtM(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static void njOn3c8QhomIWFtVF4Cm()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public static dynamic AsDynamic(this object o)
	{
		return PnlUA7GA2UHvJxhTh57t(o);
	}

	internal static object PnlUA7GA2UHvJxhTh57t(object P_0)
	{
		return PrivateReflectionDynamicObject.WrapObjectIfNeeded(P_0);
	}
}
