using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public abstract class SimpleTypeDescriptor<T> : TypeDescriptor<T>, IMappingTypeDescriptor
{
	private Dictionary<Type, Type> conventionTypesMap;

	private static object yh4oCboxsafypbj7Z47y;

	public override Guid ParentUid => SimpleTypesDescriptor.UID;

	public override bool UseForEntity => true;

	public override bool CanBeNullable => typeof(T).CanBeNullableType();

	public override bool? DefaultNullableValue => null;

	private Type CreateUserTypeInstance(Type genericArgument)
	{
		//Discarded unreachable code: IL_0052, IL_00b3
		int num = 5;
		int num2 = num;
		IUserType val = default(IUserType);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!genericArgument.IsClass)
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 2:
			{
				object obj = Activator.CreateInstance(genericArgument);
				if ((val = (IUserType)((obj is IUserType) ? obj : null)) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			}
			case 4:
				if (!genericArgument.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 5:
				if (genericArgument.GetInterface(typeof(IUserType).FullName, ignoreCase: true) != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 6:
				return val.get_ReturnedType();
			}
			break;
		}
		return genericArgument;
	}

	private void ProcessConventionType(Type conventionType)
	{
		//Discarded unreachable code: IL_00e7, IL_00f6, IL_0187, IL_0196, IL_0258, IL_02a8, IL_0327, IL_0336, IL_0345
		int num = 4;
		int num2 = num;
		Type genericTypeDefinition = default(Type);
		Type baseType = default(Type);
		Type type2 = default(Type);
		Type type3 = default(Type);
		Type type4 = default(Type);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 15:
				genericTypeDefinition = baseType.GetGenericTypeDefinition();
				num2 = 8;
				break;
			case 19:
				conventionTypesMap[type2] = null;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 13;
				}
				break;
			case 9:
				if (!(type3 != null))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 22;
					}
					break;
				}
				goto case 17;
			case 14:
				return;
			case 17:
				if (!conventionTypesMap.ContainsKey(type3))
				{
					num2 = 12;
					break;
				}
				goto case 7;
			case 2:
				type3 = CreateUserTypeInstance(type4);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 9;
				}
				break;
			case 5:
			case 21:
				conventionTypesMap.Add(type2, typeof(XmlSerializableType<>).MakeGenericType(type));
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 16;
				}
				break;
			case 22:
				return;
			case 11:
				if (!conventionTypesMap.ContainsKey(type2))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 19;
			case 1:
				if (type2 != null)
				{
					num2 = 11;
					break;
				}
				goto case 13;
			case 13:
			case 16:
				if (!(genericTypeDefinition == typeof(AutoRegisterUserTypeConvention<>)))
				{
					num2 = 14;
					break;
				}
				goto default;
			case 4:
				baseType = conventionType.BaseType;
				num2 = 3;
				break;
			case 24:
				type = baseType.GetGenericArguments()[0];
				num2 = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				conventionTypesMap[type3] = null;
				num2 = 23;
				break;
			case 10:
				if (!baseType.IsGenericType)
				{
					num2 = 6;
					break;
				}
				goto case 15;
			case 6:
				return;
			case 18:
				return;
			case 23:
				return;
			case 12:
				conventionTypesMap.Add(type3, type4);
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 8;
				}
				break;
			default:
				type4 = baseType.GetGenericArguments()[0];
				num2 = 2;
				break;
			case 3:
				if (!(baseType != null))
				{
					return;
				}
				num2 = 10;
				break;
			case 8:
				if (genericTypeDefinition == typeof(XmlSerializableTypeConvention<>))
				{
					num2 = 24;
					break;
				}
				goto case 13;
			case 20:
				type2 = CreateUserTypeInstance(type);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private Type GetAutoRegisterType(Type propertyType)
	{
		//Discarded unreachable code: IL_0077, IL_0086, IL_00a6, IL_00b5, IL_00c0, IL_015f, IL_019f, IL_01ae, IL_01ba, IL_01c9
		int num = 1;
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		Type current = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					conventionTypesMap = new Dictionary<Type, Type>();
					num2 = 5;
					continue;
				case 1:
					if (conventionTypesMap == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 3:
					return null;
				case 6:
					return conventionTypesMap[propertyType];
				case 4:
					try
					{
						while (true)
						{
							IL_0113:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num3 = 0;
								}
								goto IL_00c4;
							}
							goto IL_00f0;
							IL_00f0:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num3 = 0;
							}
							goto IL_00c4;
							IL_00c4:
							while (true)
							{
								switch (num3)
								{
								case 1:
									ProcessConventionType(current);
									num3 = 2;
									continue;
								case 2:
									goto IL_0113;
								case 3:
									goto end_IL_0113;
								}
								break;
							}
							goto IL_00f0;
							continue;
							end_IL_0113:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
							{
								num4 = 0;
							}
							goto IL_0163;
						}
						goto IL_0179;
						IL_0179:
						enumerator.Dispose();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num4 = 1;
						}
						goto IL_0163;
						IL_0163:
						switch (num4)
						{
						default:
							goto end_IL_013e;
						case 2:
							break;
						case 0:
							goto end_IL_013e;
						case 1:
							goto end_IL_013e;
						}
						goto IL_0179;
						end_IL_013e:;
					}
					goto case 2;
				case 2:
					if (conventionTypesMap.ContainsKey(propertyType))
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				case 5:
					enumerator = ComponentManager.Current.GetExtensionPointTypes<IAutoRegisterConvention>().Where(delegate(Type t)
					{
						//Discarded unreachable code: IL_005e, IL_006d
						int num5 = 1;
						int num6 = num5;
						while (true)
						{
							switch (num6)
							{
							case 1:
								if (!t.IsClass)
								{
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
									{
										num6 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return !t.IsAbstract;
							default:
								return false;
							}
						}
					}).GetEnumerator();
					num = 4;
					break;
				}
				break;
			}
		}
	}

	protected override void CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00f0, IL_00fa, IL_0109, IL_0119, IL_0128, IL_014d, IL_015c, IL_01a9, IL_01e0
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		bool notNull = default(bool);
		string formula = default(string);
		while (true)
		{
			int num3;
			string text;
			switch (num2)
			{
			case 14:
				return;
			case 1:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				mappingBuilder.Property(_003C_003Ec__DisplayClass4_.propertyMetadata.Name, _003C_003Ec__DisplayClass4_.propertyMetadata.SimpleTypeSettings.FieldName, _003C_003Ec__DisplayClass4_._003CCreatePropertyMapping_003Eb__0, notNull, formula);
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 2;
				}
				continue;
			case 13:
				_003C_003Ec__DisplayClass4_.propertyMetadata = propertyMetadata;
				num2 = 10;
				continue;
			case 4:
				if (_003C_003Ec__DisplayClass4_.propertyMetadata.Nullable)
				{
					goto case 9;
				}
				goto case 5;
			case 12:
				if (!CanBeNullable)
				{
					num2 = 5;
					continue;
				}
				goto case 2;
			case 10:
				if (_003C_003Ec__DisplayClass4_.propertyMetadata.SimpleTypeSettings == null)
				{
					return;
				}
				num2 = 3;
				continue;
			case 3:
				Locator.GetService<IRuntimeApplication>();
				num2 = 11;
				continue;
			case 9:
				num3 = ((!typeof(T).IsEnum) ? 1 : 0);
				break;
			default:
				_003C_003Ec__DisplayClass4_._003C_003E4__this = this;
				num2 = 13;
				continue;
			case 2:
				if (_003C_003Ec__DisplayClass4_.propertyMetadata == null)
				{
					num2 = 6;
					continue;
				}
				goto case 4;
			case 7:
				text = string.Empty;
				goto IL_020e;
			case 11:
				if (_003C_003Ec__DisplayClass4_.propertyMetadata.CalculateType != PropertyCalculateType.SQLFormula)
				{
					num2 = 7;
					continue;
				}
				text = _003C_003Ec__DisplayClass4_.propertyMetadata.SQLFormula;
				goto IL_020e;
			case 5:
			case 6:
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 15;
				}
				continue;
			case 15:
				{
					num3 = 1;
					break;
				}
				IL_020e:
				formula = text;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 12;
				}
				continue;
			}
			notNull = (byte)num3 != 0;
			num2 = 8;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
			{
				num2 = 2;
			}
		}
	}

	protected virtual void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		NHProvider nHProvider = default(NHProvider);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				nHProvider.CustomMapping(mapper, propertyMetadata);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				return;
			case 1:
			{
				IRuntimeApplication runtimeApplication = base.RuntimeApplication;
				if (runtimeApplication == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = runtimeApplication.MainProvider;
				break;
			}
			default:
				obj = null;
				break;
			}
			if ((nHProvider = obj as NHProvider) == null)
			{
				break;
			}
			num2 = 3;
		}
	}

	public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		return null;
	}

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (propertyMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				if (!propertyMetadata.Nullable)
				{
					num2 = 4;
					continue;
				}
				goto default;
			case 3:
				if (CanBeNullable)
				{
					num2 = 2;
					continue;
				}
				break;
			default:
				return typeof(T).NullableType().CreateTypeSyntax();
			case 4:
				break;
			}
			break;
		}
		return typeof(T).CreateTypeSyntax();
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return null;
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return new PropertyAnyTypeValueContainer(propertyMetadata);
	}

	public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
	{
		return Name;
	}

	public override TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00c9, IL_0121
		int num = 3;
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		SimpleTypeSettings simpleTypeSettings = default(SimpleTypeSettings);
		ColumnType dbColumnType = default(ColumnType);
		object dbDefaultValue = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					typeDbStructures.Columns.Add(new Column(simpleTypeSettings.FieldName, dbColumnType));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					dbDefaultValue = GetDbDefaultValue(propertyMetadata);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					typeDbStructures = new TypeDbStructures();
					num2 = 15;
					continue;
				case 2:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112825024));
					num2 = 13;
					continue;
				case 3:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218478340));
					num = 2;
					break;
				case 9:
					if (dbDefaultValue == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 10:
					typeDbStructures.Updates.Add(Tuple.Create(simpleTypeSettings.FieldName, dbDefaultValue));
					num2 = 7;
					continue;
				case 1:
					if (CanBeNullable)
					{
						num2 = 5;
						continue;
					}
					goto default;
				case 15:
					if (propertyMetadata.CalculateType != PropertyCalculateType.SQLFormula)
					{
						num = 6;
						break;
					}
					goto default;
				case 13:
					Contract.CheckArgument(propertyMetadata.Settings is SimpleTypeSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671958759));
					num2 = 8;
					continue;
				default:
					return typeDbStructures;
				case 6:
					dbColumnType = GetDbColumnType(entityMetadata, propertyMetadata);
					num2 = 4;
					continue;
				case 8:
					simpleTypeSettings = (SimpleTypeSettings)propertyMetadata.Settings;
					num2 = 12;
					continue;
				case 5:
					if (propertyMetadata.Nullable)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 11;
				}
				break;
			}
		}
	}

	public override bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		//Discarded unreachable code: IL_0071, IL_0121, IL_0130, IL_0255, IL_0264
		int num = 11;
		SimpleTypeSettings simpleTypeSettings2 = default(SimpleTypeSettings);
		SimpleTypeSettings simpleTypeSettings = default(SimpleTypeSettings);
		Column column = default(Column);
		ColumnType dbColumnType = default(ColumnType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					Contract.CheckArgument(propertyMetadata.Settings is SimpleTypeSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978639152));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					simpleTypeSettings2 = (SimpleTypeSettings)oldPropertyMetadata.Settings;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					return true;
				case 12:
					return false;
				default:
					Contract.CheckArgument(oldPropertyMetadata.Settings is SimpleTypeSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A3172B2));
					num = 5;
					break;
				case 11:
					Contract.ArgumentNotNull(updater, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575999900));
					num2 = 10;
					continue;
				case 13:
					return true;
				case 18:
					if (!(simpleTypeSettings2.FieldName != simpleTypeSettings.FieldName))
					{
						num = 12;
						break;
					}
					goto case 17;
				case 4:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867931272)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 14:
					if (!string.IsNullOrEmpty(simpleTypeSettings2.FieldName))
					{
						num2 = 18;
						continue;
					}
					goto case 8;
				case 15:
					Contract.ArgumentNotNull(oldPropertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F321622));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A75FA61));
					num2 = 9;
					continue;
				case 10:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541746469));
					num = 7;
					break;
				case 19:
					column = new Column(simpleTypeSettings.FieldName, dbColumnType);
					num2 = 3;
					continue;
				case 8:
					dbColumnType = GetDbColumnType(entityMetadata, propertyMetadata);
					num2 = 19;
					continue;
				case 3:
					updater.TablesCreatedActions.Add(new DbCreateColumnAction(updater.Transform, propertyMetadata.GetTableName(entityMetadata), column));
					num2 = 13;
					continue;
				case 17:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction(updater.Transform, propertyMetadata.GetTableName(entityMetadata), simpleTypeSettings2.FieldName, simpleTypeSettings.FieldName));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					continue;
				case 16:
					Contract.ArgumentNotNull(oldPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882262264));
					num2 = 15;
					continue;
				case 5:
					simpleTypeSettings = (SimpleTypeSettings)propertyMetadata.Settings;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					if (!string.IsNullOrEmpty(simpleTypeSettings.FieldName))
					{
						num2 = 14;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(SimpleTypeDescriptor<>._003CGetAdditionalTypeMembers_003Ed__21))]
	public override IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetAdditionalTypeMembers_003Ed__21(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__classMetadata = classMetadata,
			_003C_003E3__propertyMetadata = propertyMetadata
		};
	}

	protected abstract ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata);

	protected virtual object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
	{
		return null;
	}

	public override bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_004c, IL_007e, IL_00b6, IL_00c5
		bool flag = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				flag = GetDbColumnType(entityMetadata, propertyMetadata) != null;
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => flag, 
					_ => flag, 
				};
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return flag;
					}
					flag = false;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
				}
			}
		default:
			return flag;
		}
	}

	[IteratorStateMachine(typeof(SimpleTypeDescriptor<>._003CWriteImplementedInterfaceMembers_003Ed__25))]
	protected virtual IEnumerable<ISyntaxNode> WriteImplementedInterfaceMembers(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, Type interfaceType, PropertyInfo interfacePropInfo, ISyntaxNode castPropertyTypeRef)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CWriteImplementedInterfaceMembers_003Ed__25(-2)
		{
			_003C_003E3__propertyMetadata = propertyMetadata,
			_003C_003E3__interfaceType = interfaceType,
			_003C_003E3__interfacePropInfo = interfacePropInfo,
			_003C_003E3__castPropertyTypeRef = castPropertyTypeRef
		};
	}

	protected SimpleTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fa7ZCsoxctJb5GApyOsK()
	{
		return yh4oCboxsafypbj7Z47y == null;
	}

	internal static object u13dZ1oxzHZyH44W8Nhj()
	{
		return yh4oCboxsafypbj7Z47y;
	}
}
public abstract class SimpleTypeDescriptor<T, SettingsT> : SimpleTypeDescriptor<T>
{
	private static object FUu5maol828stG7sZCuR;

	public override Type SettingsType => typeof(SettingsT);

	protected SimpleTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pH8dpvolZEABPhsexnHA()
	{
		return FUu5maol828stG7sZCuR == null;
	}

	internal static object mrTdHioluaWBCryuGifJ()
	{
		return FUu5maol828stG7sZCuR;
	}
}
