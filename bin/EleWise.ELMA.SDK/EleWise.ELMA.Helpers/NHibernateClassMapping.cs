using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Impl;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

internal class NHibernateClassMapping : IConformistHoldersProvider
{
	private class CandidatePersistentMembersProvider : DefaultCandidatePersistentMembersProvider, ICandidatePersistentMembersProvider
	{
		private class TypeDelegator : System.Reflection.TypeDelegator
		{
			private readonly IDictionary<string, PropertyInfo> properties;

			internal static object T9sgs5ZTKeJru5nvQugs;

			public TypeDelegator(Type runtimeType, IDictionary<string, PropertyInfo> properties)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector(runtimeType);
				this.properties = properties;
			}

			public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
			{
				return new MemberInfo[1] { properties[name] };
			}

			internal static bool bpqbQCZTXsvhLRPxj9hK()
			{
				return T9sgs5ZTKeJru5nvQugs == null;
			}

			internal static TypeDelegator eL4ORVZTT29aWSHhn3Cy()
			{
				return (TypeDelegator)T9sgs5ZTKeJru5nvQugs;
			}
		}

		private readonly IDictionary<Type, IDictionary<string, PropertyInfo>> properties;

		private readonly IDictionary<Type, string> entityNames;

		internal static object RO6XXxvxwNjXcjXu4TLD;

		public CandidatePersistentMembersProvider(IDictionary<Type, string> entityNames)
		{
			SingletonReader.JJCZtPuTvSt();
			properties = new Dictionary<Type, IDictionary<string, PropertyInfo>>();
			this.entityNames = new Dictionary<Type, string>();
			((DefaultCandidatePersistentMembersProvider)this)._002Ector();
			this.entityNames = ((entityNames.Count > 0) ? entityNames : null);
		}

		IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetComponentMembers(Type componentClass)
		{
			return GetProperties(componentClass) ?? ((DefaultCandidatePersistentMembersProvider)this).GetComponentMembers(componentClass);
		}

		IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetEntityMembersForPoid(Type entityClass)
		{
			return GetProperties(entityClass) ?? ((DefaultCandidatePersistentMembersProvider)this).GetEntityMembersForPoid(entityClass);
		}

		IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetRootEntityMembers(Type entityClass)
		{
			return GetProperties(entityClass) ?? ((DefaultCandidatePersistentMembersProvider)this).GetRootEntityMembers(entityClass);
		}

		IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetSubEntityMembers(Type entityClass, Type entitySuperclass)
		{
			return GetProperties(entityClass) ?? ((DefaultCandidatePersistentMembersProvider)this).GetSubEntityMembers(entityClass, entitySuperclass);
		}

		private IEnumerable<MemberInfo> GetProperties(Type type)
		{
			if (!properties.TryGetValue(type, out var value))
			{
				return null;
			}
			return value.Values;
		}

		internal bool TryGetEntityName(PropertyPath propertyPath, out string entityName)
		{
			//Discarded unreachable code: IL_0056, IL_00e3, IL_00f2
			int num = 2;
			Type type = default(Type);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						entityName = null;
						num = 3;
						break;
					case 8:
						if (TypeOf<IEnumerable>.Raw.IsAssignableFrom(type))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					case 2:
						if (entityNames != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 5;
					case 6:
						if (!jmsMaFvx7d70p8n3EMxV(type, TypeOf<string>.Raw))
						{
							num = 4;
							break;
						}
						goto case 8;
					case 4:
					case 7:
						return entityNames.TryGetValue(type, out entityName);
					case 3:
						return false;
					case 1:
						type = ENxwUpvxAYcVsSC2isvR((PropertyInfo)f0BfScvxHxCXUirUWGHL(propertyPath));
						num2 = 6;
						continue;
					default:
						type = type.GetInterface(TypeOf.IEnumerable.FullName).GetGenericArguments()[0];
						num2 = 7;
						continue;
					}
					break;
				}
			}
		}

		internal PropertyInfo GetProperty(Type type, string name)
		{
			//Discarded unreachable code: IL_00b2, IL_00c1
			int num = 4;
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 3;
						}
						continue;
					case 2:
						if (((TypeDescriptionProvider)qbgxxPvxxrN48LfA0K5g()).IsSupportedType(_003C_003Ec__DisplayClass9_.type))
						{
							num2 = 5;
							continue;
						}
						goto case 1;
					default:
						_003C_003Ec__DisplayClass9_.name = name;
						num2 = 2;
						continue;
					case 3:
						_003C_003Ec__DisplayClass9_.type = type;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 0;
						}
						continue;
					case 6:
						return _003C_003Ec__DisplayClass9_.props.GetOrAdd(_003C_003Ec__DisplayClass9_.name, _003C_003Ec__DisplayClass9_._003CGetProperty_003Eb__1);
					case 1:
						return _003C_003Ec__DisplayClass9_.type.GetProperty(_003C_003Ec__DisplayClass9_.name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
					case 5:
						_003C_003Ec__DisplayClass9_.props = properties.GetOrAdd(_003C_003Ec__DisplayClass9_.type, (Type _) => new Dictionary<string, PropertyInfo>());
						num = 6;
						break;
					}
					break;
				}
			}
		}

		private static PropertyInfo DeclaringTo(object propertyInfo, Type declaringType)
		{
			return new PropertyInfoProxy((PropertyInfo)propertyInfo, declaringType);
		}

		internal static object f0BfScvxHxCXUirUWGHL(object P_0)
		{
			return ((PropertyPath)P_0).get_LocalMember();
		}

		internal static Type ENxwUpvxAYcVsSC2isvR(object P_0)
		{
			return ((PropertyInfo)P_0).PropertyType;
		}

		internal static bool jmsMaFvx7d70p8n3EMxV(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static bool Hv6V9rvx4Iq0YC8Y8Jls()
		{
			return RO6XXxvxwNjXcjXu4TLD == null;
		}

		internal static CandidatePersistentMembersProvider p86BpXvx6kBW9w01XL4T()
		{
			return (CandidatePersistentMembersProvider)RO6XXxvxwNjXcjXu4TLD;
		}

		internal static object qbgxxPvxxrN48LfA0K5g()
		{
			return EntityDynamicProvider.Instance;
		}
	}

	private class NHibernatePropertiesMapper : INHibernatePropertiesMapper
	{
		private class NHibernatePropertyTypeBuilder : INHibernatePropertyTypeMapper
		{
			private object m;

			internal static object LsZWQ8ZTDD6bJWrOG01O;

			public Type PersistentType
			{
				[CompilerGenerated]
				get
				{
					return _003CPersistentType_003Ek__BackingField;
				}
				[CompilerGenerated]
				private set
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
							_003CPersistentType_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public NHibernatePropertyTypeBuilder(IPropertyMapper m)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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
						this.m = m;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			public void Type<TPersistentType>()
			{
				PersistentType = typeof(TPersistentType);
				((IPropertyMapper)m).Type<TPersistentType>();
			}

			public void Type(Type persistentType)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					case 1:
						PersistentType = persistentType;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						jagYsSZT4rwn2bEd7P4O(m, persistentType, null);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			public void Type<TPersistentType>(object parameter)
			{
				PersistentType = typeof(TPersistentType);
				((IPropertyMapper)m).Type<TPersistentType>(parameter);
			}

			public void Type(Type persistentType, object parameter)
			{
				int num = 2;
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
						jagYsSZT4rwn2bEd7P4O(m, persistentType, parameter);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						PersistentType = persistentType;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			public void Length(int length)
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
						lJfS03ZT6eVr7KqxXFbJ(m, length);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}

			internal static bool viQJMRZTtc0ZwBZkEGWl()
			{
				return LsZWQ8ZTDD6bJWrOG01O == null;
			}

			internal static NHibernatePropertyTypeBuilder HY3XB4ZTwBfCZtm9Fchx()
			{
				return (NHibernatePropertyTypeBuilder)LsZWQ8ZTDD6bJWrOG01O;
			}

			internal static void jagYsSZT4rwn2bEd7P4O(object P_0, Type P_1, object P_2)
			{
				((IPropertyMapper)P_0).Type(P_1, P_2);
			}

			internal static void lJfS03ZT6eVr7KqxXFbJ(object P_0, int P_1)
			{
				((IPropertyMapper)P_0).Length(P_1);
			}
		}

		private class NHibernateElementTypeBuilder : INHibernatePropertyTypeMapper
		{
			private object m;

			internal static object QuHeA9ZTHuhXKkOmABCA;

			public Type PersistentType
			{
				[CompilerGenerated]
				get
				{
					return _003CPersistentType_003Ek__BackingField;
				}
				[CompilerGenerated]
				private set
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
							_003CPersistentType_003Ek__BackingField = value;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			public NHibernateElementTypeBuilder(IElementMapper m)
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
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
						this.m = m;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			public void Type<TPersistentType>()
			{
				PersistentType = typeof(TPersistentType);
				((IElementMapper)m).Type<TPersistentType>();
			}

			public void Type(Type persistentType)
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
						PersistentType = persistentType;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					case 1:
						TaVDUOZTxgep3iOmrkkZ(m, persistentType, null);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			public void Type<TPersistentType>(object parameter)
			{
				PersistentType = typeof(TPersistentType);
				((IElementMapper)m).Type<TPersistentType>(parameter);
			}

			public void Type(Type persistentType, object parameter)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					case 1:
						PersistentType = persistentType;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						break;
					default:
						((IElementMapper)m).Type(persistentType, parameter);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 2;
						}
						break;
					}
				}
			}

			public void Length(int length)
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
						xwyfPOZT02layE43urhy(m, length);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}

			internal static bool cy44mQZTAbe3jAKQvLNT()
			{
				return QuHeA9ZTHuhXKkOmABCA == null;
			}

			internal static NHibernateElementTypeBuilder S0p0IBZT7QjsxsaGbRpA()
			{
				return (NHibernateElementTypeBuilder)QuHeA9ZTHuhXKkOmABCA;
			}

			internal static void TaVDUOZTxgep3iOmrkkZ(object P_0, Type P_1, object P_2)
			{
				((IElementMapper)P_0).Type(P_1, P_2);
			}

			internal static void xwyfPOZT02layE43urhy(object P_0, int P_1)
			{
				((IElementMapper)P_0).Length(P_1);
			}
		}

		private static readonly IDictionary<Type, string[]> UserTypePropertyNames;

		private readonly object mapper;

		private readonly object membersProvider;

		private readonly object splitGroupId;

		private object dialect;

		internal static object AMIrFVvx07A1ppIQstvv;

		public NHibernatePropertiesMapper(NHibernateClassMapping mapper, CandidatePersistentMembersProvider membersProvider, string splitGroupId)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					this.splitGroupId = splitGroupId;
					num = 3;
					continue;
				case 3:
					return;
				case 1:
					this.membersProvider = membersProvider;
					num = 2;
					continue;
				}
				this.mapper = mapper;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 1;
				}
			}
		}

		public void Property(string name, string columnName, Action<INHibernatePropertyTypeMapper> propertyTypeBuilder, bool notNull, string formula, string sqlType)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.propertyTypeBuilder = propertyTypeBuilder;
			CS_0024_003C_003E8__locals0.formula = formula;
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.name = name;
			CS_0024_003C_003E8__locals0.columnName = columnName;
			CS_0024_003C_003E8__locals0.notNull = notNull;
			CS_0024_003C_003E8__locals0.sqlType = sqlType;
			PropertyPath propertyPath = GetPropertyPath(CS_0024_003C_003E8__locals0.name);
			ExplicitDeclaration(propertyPath.get_LocalMember(), (Action<MemberInfo>)((NHibernateClassMapping)mapper).explicitDeclarationsHolder.AddAsProperty);
			((NHibernateClassMapping)mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IPropertyMapper>)delegate(IPropertyMapper m)
			{
				//Discarded unreachable code: IL_00ed
				int num = 4;
				int num2 = num;
				Type persistentType = default(Type);
				NHibernatePropertyTypeBuilder nHibernatePropertyTypeBuilder = default(NHibernatePropertyTypeBuilder);
				while (true)
				{
					switch (num2)
					{
					default:
						CS_0024_003C_003E8__locals0._003C_003E4__this.PropertyColumnMap(m, persistentType, CS_0024_003C_003E8__locals0.name, CS_0024_003C_003E8__locals0.columnName, CS_0024_003C_003E8__locals0.notNull, CS_0024_003C_003E8__locals0.sqlType);
						num2 = 8;
						break;
					case 4:
						persistentType = null;
						num2 = 3;
						break;
					case 5:
						_003C_003Ec__DisplayClass6_0.aeVRxTZTljOnhcbiJ1GH(m, CS_0024_003C_003E8__locals0.formula);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
					case 2:
						if (!_003C_003Ec__DisplayClass6_0.QQOQF7ZTdlIZwrkZm6du(CS_0024_003C_003E8__locals0.formula))
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto default;
					case 6:
						CS_0024_003C_003E8__locals0.propertyTypeBuilder(nHibernatePropertyTypeBuilder);
						num2 = 7;
						break;
					case 9:
						nHibernatePropertyTypeBuilder = new NHibernatePropertyTypeBuilder(m);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 4;
						}
						break;
					case 3:
						if (CS_0024_003C_003E8__locals0.propertyTypeBuilder == null)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 9;
					case 7:
						persistentType = _003C_003Ec__DisplayClass6_0.pDEM5LZT9DIY94l1JbSB(nHibernatePropertyTypeBuilder);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						break;
					case 8:
						return;
					}
				}
			});
		}

		public void ManyToOne(string name, string columnName, CascadeMode cascadeMode)
		{
			int num = 8;
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						_003C_003Ec__DisplayClass7_.propertyPath = GetPropertyPath(_003C_003Ec__DisplayClass7_.name);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 2;
						}
						continue;
					case 3:
						return;
					case 6:
						_003C_003Ec__DisplayClass7_.cascadeMode = cascadeMode;
						num2 = 4;
						continue;
					case 5:
						((NHibernateClassMapping)mapper).customizersHolder.AddCustomizer(_003C_003Ec__DisplayClass7_.propertyPath, (Action<IManyToOneMapper>)_003C_003Ec__DisplayClass7_._003CManyToOne_003Eb__0);
						num2 = 3;
						continue;
					case 2:
						ExplicitDeclaration((MemberInfo)OTgL83vxMJvsa9uR8itn(_003C_003Ec__DisplayClass7_.propertyPath), (Action<MemberInfo>)((NHibernateClassMapping)mapper).explicitDeclarationsHolder.AddAsManyToOneRelation);
						num2 = 5;
						continue;
					case 1:
						_003C_003Ec__DisplayClass7_.name = name;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num2 = 0;
						}
						continue;
					case 7:
						_003C_003Ec__DisplayClass7_.columnName = columnName;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						continue;
					case 8:
						_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				}
				_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
				num = 6;
			}
		}

		public void OneToManyCollection(string name, string tableName, string keyColumn, CascadeMode cascadeMode, int batchSize, Type comparerType)
		{
			//Discarded unreachable code: IL_012f, IL_013e
			int num = 7;
			PropertyPath propertyPath = default(PropertyPath);
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 5:
						CollectionMapping(propertyPath, tableName, keyColumn, cascadeMode, batchSize, comparerType);
						num2 = 4;
						continue;
					case 7:
						_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 6;
						}
						continue;
					case 3:
						ExplicitDeclaration((MemberInfo)OTgL83vxMJvsa9uR8itn(propertyPath), (Action<MemberInfo>)((NHibernateClassMapping)mapper).explicitDeclarationsHolder.AddAsOneToManyRelation);
						num2 = 5;
						continue;
					case 1:
						((NHibernateClassMapping)mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IOneToManyMapper>)_003C_003Ec__DisplayClass8_._003COneToManyCollection_003Eb__0);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					case 2:
						return;
					case 4:
						if (!((CandidatePersistentMembersProvider)membersProvider).TryGetEntityName(propertyPath, out _003C_003Ec__DisplayClass8_.entityName))
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 1;
					case 6:
						break;
					}
					break;
				}
				propertyPath = GetPropertyPath(name);
				num = 3;
			}
		}

		public void ManyToManyCollection(string name, string tableName, string parentKeyColumn, string childKeyColumn, CascadeMode cascadeMode, int batchSize, Type comparerType, bool inverse)
		{
			int num = 4;
			_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						_003C_003Ec__DisplayClass9_.parentKeyColumn = parentKeyColumn;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						_003C_003Ec__DisplayClass9_.childKeyColumn = childKeyColumn;
						num2 = 8;
						continue;
					case 7:
						break;
					case 1:
						((NHibernateClassMapping)mapper).customizersHolder.AddCustomizer(_003C_003Ec__DisplayClass9_.propertyPath, (Action<IManyToManyMapper>)_003C_003Ec__DisplayClass9_._003CManyToManyCollection_003Eb__0);
						num2 = 2;
						continue;
					case 4:
						_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
						num2 = 3;
						continue;
					case 5:
						ExplicitDeclaration((MemberInfo)OTgL83vxMJvsa9uR8itn(_003C_003Ec__DisplayClass9_.propertyPath), (Action<MemberInfo>)((NHibernateClassMapping)mapper).explicitDeclarationsHolder.AddAsManyToManyItemRelation);
						num2 = 6;
						continue;
					case 8:
						_003C_003Ec__DisplayClass9_.propertyPath = GetPropertyPath(name);
						num2 = 5;
						continue;
					case 2:
						return;
					case 3:
						_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
						num2 = 7;
						continue;
					case 6:
						CollectionMapping(_003C_003Ec__DisplayClass9_.propertyPath, tableName, QuoteIfNeeded(_003C_003Ec__DisplayClass9_.inverse ? _003C_003Ec__DisplayClass9_.childKeyColumn : _003C_003Ec__DisplayClass9_.parentKeyColumn), cascadeMode, batchSize, comparerType, _003C_003Ec__DisplayClass9_.inverse);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				_003C_003Ec__DisplayClass9_.inverse = inverse;
				num = 9;
			}
		}

		public void Set(string name, string tableName, string parentKeyColumn, string childKeyColumn, CascadeMode cascadeMode, int batchSize, Type comparerType, Action<INHibernatePropertyTypeMapper> propertyTypeBuilder)
		{
			_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
			CS_0024_003C_003E8__locals0.propertyTypeBuilder = propertyTypeBuilder;
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.childKeyColumn = childKeyColumn;
			PropertyPath propertyPath = GetPropertyPath(name);
			ExplicitDeclaration(propertyPath.get_LocalMember(), (Action<MemberInfo>)((NHibernateClassMapping)mapper).explicitDeclarationsHolder.AddAsSet);
			CollectionMapping(propertyPath, tableName, QuoteIfNeeded(parentKeyColumn), cascadeMode, batchSize, comparerType);
			((NHibernateClassMapping)mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IElementMapper>)delegate(IElementMapper mappingElement)
			{
				//Discarded unreachable code: IL_00bb, IL_00ca
				int num = 7;
				int num2 = num;
				NHibernateElementTypeBuilder nHibernateElementTypeBuilder = default(NHibernateElementTypeBuilder);
				Type type = default(Type);
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 6:
						((IColumnsMapper)mappingElement).Column(CS_0024_003C_003E8__locals0._003C_003E4__this.QuoteIfNeeded(CS_0024_003C_003E8__locals0.childKeyColumn));
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						CS_0024_003C_003E8__locals0.propertyTypeBuilder(nHibernateElementTypeBuilder);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						nHibernateElementTypeBuilder = new NHibernateElementTypeBuilder(mappingElement);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						return;
					case 3:
						type = _003C_003Ec__DisplayClass10_0.EnXUeBZkZ4rYEA8u5r89(nHibernateElementTypeBuilder);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 3;
						}
						break;
					case 7:
						if (CS_0024_003C_003E8__locals0.propertyTypeBuilder == null)
						{
							num2 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num2 = 6;
							}
							break;
						}
						goto default;
					case 5:
						_003C_003Ec__DisplayClass10_0.wZ1ZXfZkuoS4XIcprMns(mappingElement, type, null);
						num2 = 2;
						break;
					}
				}
			});
		}

		private PropertyPath GetPropertyPath(string name)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			return new PropertyPath((PropertyPath)null, (MemberInfo)((CandidatePersistentMembersProvider)membersProvider).GetProperty(((NHibernateClassMapping)mapper).type, name));
		}

		private void ExplicitDeclaration(MemberInfo member, Action<MemberInfo> explicitDeclaration)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			if (splitGroupId != null)
			{
				((NHibernateClassMapping)mapper).explicitDeclarationsHolder.AddAsPropertySplit(new SplitDefinition(((NHibernateClassMapping)mapper).type, (string)splitGroupId, member));
			}
			explicitDeclaration(member);
		}

		private string QuoteIfNeeded(string name)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return name;
				case 1:
					if (dialect == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					if (((Dialect)dialect).IsReservedWord(name))
					{
						return (string)Vsh3eavx9IaHOGNMcPS7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103A3F11), name, kOatePvxJSJd4IGwbBCg(0x26FFCB59 ^ 0x26FA1D3D));
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 2;
					}
					break;
				default:
					dialect = ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE4AE87), () => ((ITransformationProvider)_003C_003Ec.JryCKfZkRwI4Oio5yk0D(Locator.GetServiceNotNull<IRuntimeApplication>())).Dialect);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		private void PropertyColumnMap(IPropertyMapper m, Type persistentType, string name, string columnName, bool notNull, string sqlType)
		{
			//Discarded unreachable code: IL_0073, IL_0082, IL_019c
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			int num = 2;
			string[] value = default(string[]);
			_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						value = (UserTypePropertyNames[persistentType] = (string[])JYGfAnvxdqi1UqrcvQLb((object)(ICompositeUserType)Activator.CreateInstance(persistentType)));
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 2;
						}
						continue;
					case 3:
						return;
					case 7:
					case 8:
						if (value.Length > 1)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 12;
					case 10:
						if (!TypeOf<ICompositeUserType>.Raw.IsAssignableFrom(persistentType))
						{
							num2 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 5;
					case 5:
						if (UserTypePropertyNames.TryGetValue(persistentType, out value))
						{
							num2 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num2 = 8;
							}
							continue;
						}
						goto case 9;
					case 14:
						return;
					case 12:
						((IColumnsMapper)m).Column((Action<IColumnMapper>)_003C_003Ec__DisplayClass14_._003CPropertyColumnMap_003Eb__0);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						lb2iEVvxlkKfbYpJdjdZ(m, value.Select(_003C_003Ec__DisplayClass14_._003CPropertyColumnMap_003Eb__1).ToArray());
						num2 = 14;
						continue;
					case 13:
						_003C_003Ec__DisplayClass14_.notNull = notNull;
						num2 = 11;
						continue;
					case 11:
						_003C_003Ec__DisplayClass14_.sqlType = sqlType;
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						_003C_003Ec__DisplayClass14_.columnName = columnName;
						num2 = 13;
						continue;
					case 1:
						_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				_003C_003Ec__DisplayClass14_.name = name;
				num = 4;
			}
		}

		private void PropertyColumnMap(IColumnMapper c, string name, string columnName, bool notNull, string sqlType)
		{
			//Discarded unreachable code: IL_00b2, IL_00c5, IL_00e5
			int num = 2;
			string text = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 4:
						AJmbHUvxgWI4gWirdxEq(c, text);
						num2 = 13;
						continue;
					case 2:
						if (!PSEpUOvxrGa6RGkp3wvd(columnName))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 11;
					case 10:
						ooOxW8vxj4SU6MJndho8(c, sqlType);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
					case 12:
					case 13:
						if (notNull)
						{
							num2 = 5;
							continue;
						}
						goto case 9;
					case 0:
						return;
					case 1:
						if (columnName != name)
						{
							num2 = 6;
							continue;
						}
						goto case 11;
					case 8:
						if (!(text != name))
						{
							num2 = 12;
							continue;
						}
						goto case 4;
					case 6:
						c.Name(QuoteIfNeeded(columnName));
						num2 = 3;
						continue;
					case 11:
						text = QuoteIfNeeded(name);
						num2 = 8;
						continue;
					case 9:
						CoUiyBvx5kjG3nStIm2x(c, false);
						num2 = 7;
						continue;
					case 5:
					case 7:
						if (string.IsNullOrWhiteSpace(sqlType))
						{
							return;
						}
						num = 10;
						break;
					}
					break;
				}
			}
		}

		private void CollectionMapping(PropertyPath propertyPath, string tableName, string keyColumn, CascadeMode cascadeMode, int batchSize, Type comparerType, bool inverse = false)
		{
			int num = 8;
			int num2 = num;
			_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
			while (true)
			{
				switch (num2)
				{
				case 10:
					_003C_003Ec__DisplayClass16_.comparerType = comparerType;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 7;
					break;
				case 7:
					_003C_003Ec__DisplayClass16_._003C_003E4__this = this;
					num2 = 6;
					break;
				case 5:
					((NHibernateClassMapping)mapper).customizersHolder.AddCustomizer(propertyPath, (Action<ICollectionPropertiesMapper>)_003C_003Ec__DisplayClass16_._003CCollectionMapping_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					break;
				default:
					_003C_003Ec__DisplayClass16_.inverse = inverse;
					num2 = 3;
					break;
				case 9:
					_003C_003Ec__DisplayClass16_.batchSize = batchSize;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					_003C_003Ec__DisplayClass16_.keyColumn = keyColumn;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 4:
					_003C_003Ec__DisplayClass16_.tableName = tableName;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 7;
					}
					break;
				case 3:
					((NHibernateClassMapping)mapper).explicitDeclarationsHolder.AddAsSet(propertyPath.get_LocalMember());
					num2 = 5;
					break;
				case 1:
					_003C_003Ec__DisplayClass16_.cascadeMode = cascadeMode;
					num2 = 10;
					break;
				}
			}
		}

		private static Cascade ToCascade(CascadeMode cascadeMode)
		{
			//Discarded unreachable code: IL_006b, IL_007a
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (Cascade)256;
				case 1:
					return (Cascade)0;
				case 2:
					{
						switch (cascadeMode)
						{
						case CascadeMode.All:
							break;
						case CascadeMode.SaveUpdate:
							return (Cascade)2;
						case CascadeMode.AllDeleteOrphan:
							return (Cascade)384;
						default:
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
							{
								num2 = 1;
							}
							goto end_IL_0012;
						}
						goto default;
					}
					end_IL_0012:
					break;
				}
			}
		}

		static NHibernatePropertiesMapper()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					UserTypePropertyNames = new Dictionary<Type, string[]>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					lK5SOovxYA5ntpvgcNq0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static bool qSPC8YvxmJWerajScwRy()
		{
			return AMIrFVvx07A1ppIQstvv == null;
		}

		internal static NHibernatePropertiesMapper k7mRLDvxynIpvq7LsxqL()
		{
			return (NHibernatePropertiesMapper)AMIrFVvx07A1ppIQstvv;
		}

		internal static object OTgL83vxMJvsa9uR8itn(object P_0)
		{
			return ((PropertyPath)P_0).get_LocalMember();
		}

		internal static object kOatePvxJSJd4IGwbBCg(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Vsh3eavx9IaHOGNMcPS7(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static object JYGfAnvxdqi1UqrcvQLb(object P_0)
		{
			return ((ICompositeUserType)P_0).get_PropertyNames();
		}

		internal static void lb2iEVvxlkKfbYpJdjdZ(object P_0, object P_1)
		{
			((IColumnsMapper)P_0).Columns((Action<IColumnMapper>[])P_1);
		}

		internal static bool PSEpUOvxrGa6RGkp3wvd(object P_0)
		{
			return string.IsNullOrWhiteSpace((string)P_0);
		}

		internal static void AJmbHUvxgWI4gWirdxEq(object P_0, object P_1)
		{
			((IColumnMapper)P_0).Name((string)P_1);
		}

		internal static void CoUiyBvx5kjG3nStIm2x(object P_0, bool P_1)
		{
			((IColumnMapper)P_0).NotNullable(P_1);
		}

		internal static void ooOxW8vxj4SU6MJndho8(object P_0, object P_1)
		{
			((IColumnMapper)P_0).SqlType((string)P_1);
		}

		internal static void lK5SOovxYA5ntpvgcNq0()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private readonly CandidatePersistentMembersProvider membersProvider;

	private readonly IModelExplicitDeclarationsHolder explicitDeclarationsHolder;

	private readonly ICustomizersHolder customizersHolder;

	private readonly Type type;

	private readonly EntityMetadata metadata;

	private static NHibernateClassMapping NtDM6Ph5mesUU50jOJRq;

	IModelExplicitDeclarationsHolder ExplicitDeclarationsHolder => explicitDeclarationsHolder;

	ICustomizersHolder CustomizersHolder => customizersHolder;

	internal static ModelMapper CreateModelMapper(IDictionary<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> mappings)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.membersProvider = new CandidatePersistentMembersProvider(mappings.Where((KeyValuePair<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> p) => p.Value.entityName != null).ToDictionary((KeyValuePair<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> p) => p.Key, (KeyValuePair<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> p) => p.Value.entityName));
		CS_0024_003C_003E8__locals0.mapper = new ModelMapper((IModelInspector)new ExplicitlyDeclaredModel(), (ICandidatePersistentMembersProvider)(object)CS_0024_003C_003E8__locals0.membersProvider);
		mappings.ForEach(delegate(KeyValuePair<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> p)
		{
			CS_0024_003C_003E8__locals0.mapper.AddMapping((IConformistHoldersProvider)(object)new NHibernateClassMapping(p.Key, p.Value.entityName, p.Value.tableNumber, p.Value.dynamicInsert, p.Value.dynamicUpdate, CS_0024_003C_003E8__locals0.membersProvider));
		});
		return CS_0024_003C_003E8__locals0.mapper;
	}

	private NHibernateClassMapping(Type type, string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate, CandidatePersistentMembersProvider membersProvider)
	{
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.entityName = entityName;
		_003C_003Ec__DisplayClass12_.dynamicInsert = dynamicInsert;
		_003C_003Ec__DisplayClass12_.dynamicUpdate = dynamicUpdate;
		_003C_003Ec__DisplayClass12_.type = type;
		_003C_003Ec__DisplayClass12_.tableNumber = tableNumber;
		base._002Ector();
		_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
		CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass12_;
		this.membersProvider = membersProvider;
		Contract.CheckArgument(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type.IsClass, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123739278), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type));
		this.type = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type;
		metadata = MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type, inherit: false) as EntityMetadata;
		Contract.CheckArgument(metadata != null, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978568244), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type));
		CS_0024_003C_003E8__locals0.tableName = GetTableName(metadata, null);
		explicitDeclarationsHolder = (IModelExplicitDeclarationsHolder)new ExplicitDeclarationsHolder();
		customizersHolder = (ICustomizersHolder)new CustomizersHolder();
		if (metadata.BaseClassUid == Guid.Empty)
		{
			explicitDeclarationsHolder.AddAsRootEntity(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type);
			customizersHolder.AddCustomizer(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type, (Action<IClassMapper>)delegate(IClassMapper m)
			{
				//Discarded unreachable code: IL_0218
				int num7 = 8;
				_003C_003Ec__DisplayClass12_2 _003C_003Ec__DisplayClass12_2 = default(_003C_003Ec__DisplayClass12_2);
				PropertyInfo propertyInfo = default(PropertyInfo);
				while (true)
				{
					int num8 = num7;
					while (true)
					{
						switch (num8)
						{
						case 9:
							((IEntityAttributesMapper)_003C_003Ec__DisplayClass12_2.m).EntityName(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.entityName);
							num8 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
							{
								num8 = 6;
							}
							continue;
						case 13:
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.explicitDeclarationsHolder.AddAsPoid((MemberInfo)propertyInfo);
							num8 = 14;
							continue;
						case 10:
							return;
						case 1:
							_003C_003Ec__DisplayClass12_1.JW8kOBv0S6ZkGiBnhjir(_003C_003Ec__DisplayClass12_2.m, CS_0024_003C_003E8__locals0.tableName);
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num8 = 0;
							}
							continue;
						case 11:
							_003C_003Ec__DisplayClass12_1.wjjDklv0KWxMrsga7xC9(_003C_003Ec__DisplayClass12_2.m, _003C_003Ec__DisplayClass12_1.QdrgrJv0qcikAD2TvruX(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.metadata));
							num8 = 10;
							continue;
						case 15:
							propertyInfo = (PropertyInfo)_003C_003Ec__DisplayClass12_1.xsvlIbv0ikLXO8UgQWvE(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335026351));
							num8 = 13;
							continue;
						case 8:
							_003C_003Ec__DisplayClass12_2 = new _003C_003Ec__DisplayClass12_2();
							num8 = 7;
							continue;
						case 17:
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.WriteClassMapCache(_003C_003Ec__DisplayClass12_2.m);
							num8 = 15;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num8 = 13;
							}
							continue;
						case 4:
							_003C_003Ec__DisplayClass12_2.m = m;
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num8 = 0;
							}
							continue;
						case 2:
							if (!_003C_003Ec__DisplayClass12_1.hccV1kv0RNEGjaB9abDq(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.metadata))
							{
								if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.tableNumber.HasValue)
								{
									return;
								}
								num8 = 5;
							}
							else
							{
								num8 = 3;
							}
							continue;
						case 7:
							_003C_003Ec__DisplayClass12_2.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
							num8 = 4;
							continue;
						case 12:
							return;
						default:
							if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.entityName == null)
							{
								num8 = 16;
								continue;
							}
							goto case 9;
						case 6:
						case 16:
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.CreateClassMapAdditional((IEntityAttributesMapper)(object)_003C_003Ec__DisplayClass12_2.m, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dynamicInsert, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dynamicUpdate);
							num8 = 17;
							continue;
						case 14:
							((IClassAttributesMapper)_003C_003Ec__DisplayClass12_2.m).Id((MemberInfo)propertyInfo, (Action<IIdMapper>)delegate(IIdMapper i)
							{
								//Discarded unreachable code: IL_013a, IL_0149, IL_0158
								int num9 = 4;
								int num10 = num9;
								int num11 = default(int);
								int? tableNumber2 = default(int?);
								while (true)
								{
									switch (num10)
									{
									case 2:
										_003C_003Ec__DisplayClass12_1.REBaqbv0TG6j9oVe3oB7(i, _003C_003Ec__DisplayClass12_1.dqekykv0X5MfIkUIXRZ7());
										num10 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
										{
											num10 = 1;
										}
										break;
									case 3:
										num11 = 0;
										num10 = 9;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
										{
											num10 = 8;
										}
										break;
									case 4:
										tableNumber2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.tableNumber;
										num10 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
										{
											num10 = 1;
										}
										break;
									case 6:
										if (!(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.metadata is TablePartMetadata))
										{
											num10 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
											{
												num10 = 5;
											}
											break;
										}
										goto default;
									case 1:
										return;
									case 7:
										i.SetGenerator(CS_0024_003C_003E8__locals0.tableName, (string)_003C_003Ec__DisplayClass12_1.M8Ye5av0kxekrBiv4QcA(0x76DD48E ^ 0x76D55D0));
										num10 = 6;
										break;
									default:
										_003C_003Ec__DisplayClass12_1.m7EN1Fv0ncvQrEAjbWSu(i, _003C_003Ec__DisplayClass12_1.M8Ye5av0kxekrBiv4QcA(0x92F12D5 ^ 0x92AC4BF));
										num10 = 8;
										break;
									case 5:
										return;
									case 8:
										return;
									case 9:
										if (!(tableNumber2 > num11))
										{
											num10 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
											{
												num10 = 7;
											}
											break;
										}
										goto case 2;
									}
								}
							});
							num8 = 2;
							continue;
						case 3:
							((IClassAttributesMapper)_003C_003Ec__DisplayClass12_2.m).Discriminator((Action<IDiscriminatorMapper>)delegate(IDiscriminatorMapper d)
							{
								int num12 = 1;
								int num13 = num12;
								while (true)
								{
									switch (num13)
									{
									default:
										return;
									case 1:
										_003C_003Ec.ACQR8Zv0boX3q5UPBkZG(d, _003C_003Ec.emu5mgv0oCVRcoFLeLX4(-521266112 ^ -521249246));
										num13 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
										{
											num13 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
							num8 = 11;
							continue;
						case 5:
							(from p in CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.metadata.Properties.OfType<EntityPropertyMetadata>()
								where p.TableNumber != 0
								group p by _003C_003Ec.ylqu8jv0hyikBOrbiAUA(p)).ForEach(_003C_003Ec__DisplayClass12_2._003C_002Ector_003Eb__9);
							num7 = 12;
							break;
						}
						break;
					}
				}
			});
			if (metadata.AllowCreateHeirs)
			{
				CreateClassMapProperties();
			}
			else
			{
				(from p in metadata.Properties.OfType<EntityPropertyMetadata>()
					group p by p.TableNumber).ForEach(delegate(IGrouping<int, EntityPropertyMetadata> grouping)
				{
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.CreateClassMapProperties(grouping, (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.tableNumber.HasValue || grouping.Key == 0) ? null : GetTableName(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.metadata, grouping.Key));
				});
			}
			if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.tableNumber == 0 || (!CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.tableNumber.HasValue && metadata.Properties.OfType<EntityPropertyMetadata>().All((EntityPropertyMetadata p) => p.TableNumber == 0)))
			{
				CreateClassMapTableParts();
			}
			return;
		}
		explicitDeclarationsHolder.AddAsTablePerClassHierarchyEntity(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type);
		customizersHolder.AddCustomizer(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type, (Action<ISubclassMapper>)delegate(ISubclassMapper m)
		{
			//Discarded unreachable code: IL_0082
			int num = 7;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 6:
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.CreateClassMapAdditional((IEntityAttributesMapper)(object)m, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dynamicInsert, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dynamicUpdate);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					return;
				case 7:
					if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.entityName == null)
					{
						num2 = 6;
						break;
					}
					goto case 2;
				case 5:
					_003C_003Ec__DisplayClass12_1.QqVSlJv02k5qGbQ0ioWH(m, _003C_003Ec__DisplayClass12_1.QdrgrJv0qcikAD2TvruX(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.metadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					((IEntityAttributesMapper)m).EntityName(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.entityName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass12_1.dLt4pOv0Ou7oh6DuJUOF(m, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.type.BaseType);
					num2 = 5;
					break;
				default:
					m.Join(CS_0024_003C_003E8__locals0.tableName, (Action<IJoinMapper>)delegate(IJoinMapper j)
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								((IJoinAttributesMapper)j).Key((Action<IKeyMapper>)delegate(IKeyMapper x)
								{
									int num5 = 1;
									int num6 = num5;
									while (true)
									{
										switch (num6)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											_003C_003Ec.ct8sUCv0EyMl31y4H1rj(x, _003C_003Ec.emu5mgv0oCVRcoFLeLX4(0x7E6E5A0B ^ 0x7E6EDB55));
											num6 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
											{
												num6 = 0;
											}
											break;
										}
									}
								});
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 3;
					break;
				}
			}
		});
		CreateClassMapProperties(CS_0024_003C_003E8__locals0.tableName);
		CreateClassMapTableParts(CS_0024_003C_003E8__locals0.tableName);
	}

	internal static string GetTableName(EntityMetadata metadata, int? tableNumber)
	{
		return metadata.TableName + ((tableNumber > 0) ? (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638401429) + tableNumber) : "");
	}

	private void WriteClassMapCache(IClassMapper mapper)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 3:
				if (!XQAgqGh5JPaMkEJvZTtP(metadata))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 1:
				break;
			}
			((IClassAttributesMapper)mapper).Cache((Action<ICacheMapper>)delegate(ICacheMapper c)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 1:
						_003C_003Ec.fLgH6nv0fJq9sR4AX4ep(c, CacheUsage.ReadWrite);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
			{
				num2 = 0;
			}
		}
	}

	private void CreateClassMapAdditional(IEntityAttributesMapper mapper, bool? dynamicInsert, bool? dynamicUpdate)
	{
		if (dynamicInsert == true)
		{
			mapper.DynamicInsert(true);
		}
		if (dynamicUpdate == true)
		{
			mapper.DynamicUpdate(true);
		}
	}

	private void CreateClassMapTableParts(string splitGroupId = null)
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
				CreateClassMapProperties(metadata.TableParts.Select((TablePartMetadata tablePartMetadata) => new EntityPropertyTablePartMetadata(metadata, tablePartMetadata)), splitGroupId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void CreateClassMapProperties(string splitGroupId = null)
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
				CreateClassMapProperties(null, splitGroupId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void CreateClassMapProperties(IEnumerable<EntityPropertyMetadata> properties, string splitGroupId = null)
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.splitGroupId = splitGroupId;
		(properties ?? metadata.Properties.OfType<EntityPropertyMetadata>()).ForEach(delegate(EntityPropertyMetadata property)
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
					CS_0024_003C_003E8__locals0._003C_003E4__this.CreateClassMapProperty(property, CS_0024_003C_003E8__locals0.splitGroupId);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	private void CreateClassMapProperty(EntityPropertyMetadata entityProperty, string splitGroupId)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				IMappingTypeDescriptor obj = e5rRWMh5l3BDxIlXlV7Q(MetadataServiceContext.Service, q2LSBmh59qX0CKFBbX22(entityProperty), BdblvRh5dlUfd6scZCL4(entityProperty)) as IMappingTypeDescriptor;
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					break;
				}
				yvijg3h5rFSjppodeTJp(obj, new NHibernatePropertiesMapper(this, membersProvider, splitGroupId), metadata, entityProperty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	internal static bool XQAgqGh5JPaMkEJvZTtP(object P_0)
	{
		return ((EntityMetadata)P_0).CacheEntity;
	}

	internal static bool WAhdBbh5yapqCAMRE91l()
	{
		return NtDM6Ph5mesUU50jOJRq == null;
	}

	internal static NHibernateClassMapping kjPBfGh5Mob3tFDfYjR6()
	{
		return NtDM6Ph5mesUU50jOJRq;
	}

	internal static Guid q2LSBmh59qX0CKFBbX22(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static Guid BdblvRh5dlUfd6scZCL4(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object e5rRWMh5l3BDxIlXlV7Q(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static void yvijg3h5rFSjppodeTJp(object P_0, object P_1, object P_2, object P_3)
	{
		((IMappingTypeDescriptor)P_0).CreatePropertyMapping((INHibernatePropertiesMapper)P_1, (ClassMetadata)P_2, (EntityPropertyMetadata)P_3);
	}
}
