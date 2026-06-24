using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Db.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public abstract class RefCLRTypeDescriptorBase<T, TSettings> : CLRTypeDescriptor<T, TSettings>, IMappingTypeDescriptor where T : ClassMetadata where TSettings : EntitySettings
{
	private static ConcurrentDictionary<Guid, Guid> entityUidProperties;

	internal static object z25R8do4H2dNgYl1XWsv;

	private Type GetComparerType(ClassMetadata classMetadata, EntityPropertyMetadata propertyMetadata, TSettings settings)
	{
		if (settings.CanSortProperty && settings.SortPropertyUid != Guid.Empty && GetMetadata(propertyMetadata.SubTypeUid) is T val)
		{
			T baseRefMetadata;
			PropertyMetadata propertyMetadata2 = FindProperty(val, settings.SortPropertyUid, out baseRefMetadata);
			if (MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid) is ISortedProperty sortedProperty && sortedProperty.IsSupportSort())
			{
				return typeof(NHComparer<, >).MakeGenericType(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(classMetadata.Uid), MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(val.Uid));
			}
		}
		return null;
	}

	protected override void CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0169, IL_0178, IL_02c9, IL_02d8
		int num = 10;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		T baseRefMetadata = default(T);
		EntitySettings entitySettings = default(EntitySettings);
		TSettings val2 = default(TSettings);
		RelationType relationType = default(RelationType);
		T val = default(T);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 6:
					mappingBuilder.OneToManyCollection(_003C_003Ec__DisplayClass1_.propertyMetadata.Name, GetTableName(baseRefMetadata), entitySettings.FieldName, val2.CascadeMode, 15, GetComparerType(metadata, _003C_003Ec__DisplayClass1_.propertyMetadata, val2));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 3;
					}
					break;
				default:
					relationType = val2.RelationType;
					num2 = 11;
					break;
				case 10:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 5;
					}
					break;
				case 17:
					val2 = (TSettings)_003C_003Ec__DisplayClass1_.propertyMetadata.Settings;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108789096)), val.Name, val2.KeyColumnUid));
				case 9:
					_003C_003Ec__DisplayClass1_._003C_003E4__this = this;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 3;
					}
					break;
				case 14:
					return;
				case 2:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36130575)), val.Name, propertyMetadata2.Name));
				case 15:
					_003C_003Ec__DisplayClass1_.propertyMetadata = propertyMetadata;
					num2 = 17;
					break;
				case 13:
					return;
				case 18:
					throw new NotImplementedException();
				case 11:
					if ((val = MetadataServiceContext.Service.GetMetadata(_003C_003Ec__DisplayClass1_.propertyMetadata.SubTypeUid, loadImplementation: false) as T) != null)
					{
						num2 = 12;
						break;
					}
					goto case 3;
				case 3:
					throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978614014), _003C_003Ec__DisplayClass1_.propertyMetadata.SubTypeUid));
				case 12:
					switch (relationType)
					{
					case RelationType.OneToOne:
						mappingBuilder.Property(_003C_003Ec__DisplayClass1_.propertyMetadata.Name, val2.FieldName, _003C_003Ec__DisplayClass1_._003CCreatePropertyMapping_003Eb__1);
						num2 = 13;
						goto end_IL_0012;
					default:
						goto end_IL_0012_2;
					case RelationType.ManyToMany:
						mappingBuilder.Set(_003C_003Ec__DisplayClass1_.propertyMetadata.Name, val2.RelationTableName, val2.ParentColumnName, val2.ChildColumnName, val2.CascadeMode, 15, GetComparerType(metadata, _003C_003Ec__DisplayClass1_.propertyMetadata, val2), _003C_003Ec__DisplayClass1_._003CCreatePropertyMapping_003Eb__0);
						num2 = 4;
						goto end_IL_0012;
					case RelationType.OneToMany:
						break;
					}
					goto case 16;
				case 1:
					return;
				case 8:
					if (propertyMetadata2 != null)
					{
						if ((entitySettings = propertyMetadata2.Settings as EntitySettings) == null)
						{
							num2 = 2;
						}
						else if (relationType != RelationType.OneToMany)
						{
							mappingBuilder.ManyToManyCollection(_003C_003Ec__DisplayClass1_.propertyMetadata.Name, entitySettings.RelationTableName, entitySettings.ParentColumnName, entitySettings.ChildColumnName, val2.CascadeMode, 15, GetComparerType(metadata, _003C_003Ec__DisplayClass1_.propertyMetadata, val2), inverse: true);
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
							{
								num2 = 1;
							}
						}
						else
						{
							num2 = 6;
						}
					}
					else
					{
						num2 = 5;
					}
					break;
				case 7:
					throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459446935), _003C_003Ec__DisplayClass1_.propertyMetadata.Name));
				case 19:
					propertyMetadata2 = FindProperty(val, val2.KeyColumnUid, out baseRefMetadata);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 1;
					}
					break;
				case 16:
					{
						if (!(val2.KeyColumnUid == Guid.Empty))
						{
							num2 = 19;
							break;
						}
						goto case 7;
					}
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
			num = 18;
		}
	}

	protected virtual void ExtendSetPropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata propertyMetadata)
	{
	}

	protected abstract Type CodeTypeReferenceType(EntityPropertyMetadata propertyMetadata);

	protected abstract string GetTableName(T metadata);

	protected abstract EntityMetadataType GetEntityMetadataType(T metadata);

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		return GetPropertyTypeReferenceInnerLogic(classMetadata, propertyMetadata, forFilter);
	}

	protected override void ExtendSimplePropertyMapping(INHibernatePropertyTypeMapper mapper, EntityPropertyMetadata entityPropertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.ExtendSimplePropertyMapping(mapper, entityPropertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				mapper.Type(CodeTypeReferenceType(entityPropertyMetadata));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual RelationType GetRelationType(PropertyMetadata propertyMetadata)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EE78E9));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4787CDDD), typeof(TSettings).Name));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA5096E));
				num2 = 2;
				break;
			case 1:
				return GetRelationType((TSettings)propertyMetadata.Settings);
			}
		}
	}

	public virtual string GetTypeName(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_007d, IL_008c, IL_009c, IL_00ab, IL_0173, IL_0182, IL_01e3, IL_01f2, IL_024c
		int num = 13;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		ClassMetadata metadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				if (forFilter)
				{
					num2 = 4;
					break;
				}
				goto case 14;
			case 2:
				if (entityMetadata.Type == EntityMetadataType.Interface)
				{
					num2 = 10;
					break;
				}
				goto case 9;
			case 15:
				if (!entityMetadata3.IsInterfaceType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 3:
				entityMetadata3 = classMetadata as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 17:
				entityMetadata2 = GetMetadata(metadata.BaseClassUid) as EntityMetadata;
				num2 = 5;
				break;
			case 12:
				entityMetadata = metadata as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 3;
				}
				break;
			case 13:
				metadata = GetMetadata(propertyMetadata.SubTypeUid);
				num2 = 12;
				break;
			case 1:
			case 4:
			case 6:
			case 8:
			case 16:
			case 18:
				return metadata.FullTypeName;
			case 9:
				if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
				{
					num2 = 17;
					break;
				}
				goto case 1;
			case 11:
				if (entityMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 15;
			case 5:
				if (entityMetadata2 == null)
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 7:
				metadata = GetMetadata(entityMetadata2.ImplementationUid);
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 18;
				}
				break;
			case 14:
				if (entityMetadata3 == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 10:
				metadata = GetMetadata(entityMetadata.ImplementationUid);
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected ClassMetadata GetMetadata(Guid subTypeUid)
	{
		return ((ClassMetadata)MetadataServiceContext.Service.GetMetadata(subTypeUid, loadImplementation: false)) ?? throw new TypeNotFoundException(subTypeUid);
	}

	public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00f9, IL_0108
		int num = 4;
		string typeDisplayName = default(string);
		RelationType relationType = default(RelationType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4787CE19), typeDisplayName);
				case 2:
					return typeDisplayName;
				case 3:
					typeDisplayName = GetTypeDisplayName(propertyMetadata.SubTypeUid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					switch (relationType)
					{
					case RelationType.OneToMany:
						break;
					case RelationType.ManyToMany:
						return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A75E58D), typeDisplayName);
					case RelationType.ManyToManyInverse:
						return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638562703), typeDisplayName);
					default:
						goto end_IL_0012;
					}
					goto default;
				case 4:
					relationType = GetRelationType(propertyMetadata);
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public virtual PropertyMetadata FindProperty(T metadata, Guid propertyUid, out T baseRefMetadata)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		baseRefMetadata = metadata;
		PropertyMetadata propertyMetadata = null;
		while (propertyMetadata == null && baseRefMetadata != null)
		{
			propertyMetadata = baseRefMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals0.propertyUid);
			if (propertyMetadata != null)
			{
				break;
			}
			if (propertyMetadata == null && GetEntityMetadataType(baseRefMetadata) == EntityMetadataType.Interface)
			{
				_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass14_1();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.brfMetadata = baseRefMetadata;
				foreach (T item in from e in MetadataServiceContext.Service.GetMetadataList().OfType<T>()
					where CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.GetEntityMetadataType(e) == EntityMetadataType.InterfaceExtension && e.BaseClassUid == CS_0024_003C_003E8__locals1.brfMetadata.Uid
					select e)
				{
					propertyMetadata = item.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.propertyUid);
					if (propertyMetadata != null)
					{
						break;
					}
				}
			}
			if (propertyMetadata != null)
			{
				break;
			}
			baseRefMetadata = ((baseRefMetadata.BaseClassUid != Guid.Empty) ? (MetadataServiceContext.Service.GetMetadata(baseRefMetadata.BaseClassUid) as T) : null);
		}
		return propertyMetadata;
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return GetPropertyInitExpressionInnerLogic(classMetadata, propertyMetadata, forFilter);
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_00ca, IL_00d9, IL_0111, IL_013f, IL_020f
		int num = 10;
		IPropertyDefaultValueContainer result = default(IPropertyDefaultValueContainer);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		TSettings val = default(TSettings);
		Type typeByUid = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
				case 12:
					if (!(classMetadata is DataClassMetadata))
					{
						num2 = 13;
						continue;
					}
					goto case 6;
				case 4:
					result = new PropertySetValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, loadImplementation: false), forFilter);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					if ((val = propertyMetadata.Settings as TSettings) != null)
					{
						num2 = 9;
						continue;
					}
					return new PropertyAnyTypeValueContainer(propertyMetadata);
				case 1:
					return result;
				case 7:
					result = new PropertyEntityValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, loadImplementation: false), forFilter);
					num = 2;
					break;
				case 3:
					if (val.RelationType != 0)
					{
						num = 5;
						break;
					}
					goto default;
				case 14:
					if (val.RelationType == RelationType.OneToOne)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 4;
				case 6:
					typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					if (!forFilter)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 11;
				case 2:
					return result;
				default:
					return (IPropertyDefaultValueContainer)Activator.CreateInstance(typeof(PropertyValueContainer<>).MakeGenericType(typeByUid));
				case 5:
					return new PropertyCollectionValueContainer(typeByUid);
				case 13:
					serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
					num2 = 14;
					continue;
				case 11:
					val = (TSettings)CreateSettingsForFilterProperty(propertyMetadata);
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	public override void Deserialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, IDictionary<string, object> values)
	{
		if (obj == null || values == null)
		{
			return;
		}
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92F5BEB));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A33B764));
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanWrite)
		{
			return;
		}
		if (values.Count == 0)
		{
			property.SetValue(obj, null, null);
		}
		else
		{
			if (!values.TryGetValue(propertyMetadata.Name, out var value))
			{
				return;
			}
			TSettings typeSettings = (TSettings)propertyMetadata.Settings;
			IDictionary<string, object> dictionary = value as IDictionary<string, object>;
			switch (GetRelationType(typeSettings))
			{
			case RelationType.OneToOne:
			{
				Type typeByUid2 = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
				object obj2 = TryDeserializeEntityId(dictionary, typeByUid2);
				IEntity value2 = ((obj2 != null) ? ((IEntity)ModelHelper.GetEntityManager(typeByUid2).LoadOrNull(obj2)) : null);
				property.SetValue(obj, value2, null);
				break;
			}
			case RelationType.OneToMany:
			case RelationType.ManyToMany:
			case RelationType.ManyToManyInverse:
			{
				IEnumerable enumerable = (IEnumerable)property.GetValue(obj, null);
				IUntypedCollectionProxy untypedCollectionProxy = null;
				if (enumerable == null)
				{
					Type propertyType = property.PropertyType;
					Type type = null;
					if (propertyType.IsGenericType)
					{
						Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
						if (genericTypeDefinition == typeof(IDictionary<, >))
						{
							type = typeof(Dictionary<, >).MakeGenericType(propertyType.GetGenericArguments());
							enumerable = (IEnumerable)Activator.CreateInstance(type);
							untypedCollectionProxy = enumerable.AsUntypedIDictionary();
						}
						else if (genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IList<>))
						{
							type = typeof(List<>).MakeGenericType(propertyType.GetGenericArguments());
							enumerable = (IEnumerable)Activator.CreateInstance(type);
							untypedCollectionProxy = enumerable.AsUntypedICollection();
						}
					}
					else if (propertyType.IsArray && value is ArrayList arrayList)
					{
						type = propertyType.GetElementType();
						Array array = Array.CreateInstance(type, arrayList.Count);
						for (int i = 0; i < arrayList.Count; i++)
						{
							array.SetValue(DeserializeSimple(arrayList.ElementAt(i), type), i);
						}
						enumerable = array;
					}
					if (type == null)
					{
						break;
					}
					if (enumerable != null)
					{
						property.SetValue(obj, enumerable, null);
					}
				}
				if (untypedCollectionProxy == null)
				{
					untypedCollectionProxy = enumerable.AsUntypedISet();
				}
				if (untypedCollectionProxy == null)
				{
					break;
				}
				Dictionary<string, IEntity> dictionary2 = new Dictionary<string, IEntity>();
				foreach (IEntity item in enumerable)
				{
					dictionary2[GetEntityId(item)] = item;
				}
				List<string> list = new List<string>();
				if (value is IEnumerable enumerable2)
				{
					foreach (object item2 in enumerable2)
					{
						dictionary = item2 as IDictionary<string, object>;
						Type typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
						IEntity entity2 = (IEntity)DeserializeSimple(dictionary, typeByUid);
						if (entity2 != null)
						{
							string entityId = GetEntityId(entity2, typeByUid);
							if (!dictionary2.ContainsKey(entityId))
							{
								untypedCollectionProxy.Add(entity2);
							}
							list.Add(entityId);
						}
					}
				}
				{
					foreach (KeyValuePair<string, IEntity> item3 in dictionary2)
					{
						if (!list.Contains(item3.Key))
						{
							untypedCollectionProxy.Remove(item3.Value);
						}
					}
					break;
				}
			}
			}
		}
	}

	protected virtual object TryDeserializeEntityId(IDictionary<string, object> dictionary, Type entityType)
	{
		if (dictionary != null && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951482184), out var value))
		{
			return ModelHelper.TryConvertEntityId(entityType, value);
		}
		return null;
	}

	public override IDictionary<string, object> Serialize(object obj, [NotNull] ClassMetadata metadata, [NotNull] PropertyMetadata propertyMetadata, EntitySerializationSettings serializationSettings)
	{
		if (obj == null)
		{
			return null;
		}
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138940730));
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048387));
		obj = obj.CastAsRealType();
		PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
		if (property == null || !property.CanRead)
		{
			return null;
		}
		object value = property.GetValue(obj, null);
		SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
		if (value != null)
		{
			switch (((EntitySettings)propertyMetadata.Settings).RelationType)
			{
			case RelationType.OneToOne:
				if (value is IEntity entity)
				{
					SerializableDictionary<string, object> serializableDictionary2 = new SerializableDictionary<string, object>
					{
						{
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876095503),
							entity.GetId()
						},
						{
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC3C431),
							entity.ToString()
						},
						{
							z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487404540),
							InterfaceActivator.UID(value.GetType()).ToString()
						}
					};
					if (serializationSettings == null || serializationSettings.Mode == EntitySerializationMode.Default)
					{
						serializableDictionary2[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889480832)] = entity.ToString();
					}
					serializableDictionary[propertyMetadata.Name] = serializableDictionary2;
				}
				break;
			case RelationType.OneToMany:
			case RelationType.ManyToMany:
			case RelationType.ManyToManyInverse:
			{
				if (!(value is IEnumerable enumerable))
				{
					break;
				}
				SerializableList<object> serializableList = new SerializableList<object>();
				try
				{
					foreach (object item in enumerable)
					{
						serializableList.Add(SerializeSimple(item, item.GetType(), serializationSettings));
					}
					serializableDictionary[propertyMetadata.Name] = serializableList;
					return serializableDictionary;
				}
				catch (Exception ex)
				{
					base.Logger.Log(LogLevel.Error, ex, ex.Message);
					return serializableDictionary;
				}
			}
			}
		}
		else
		{
			serializableDictionary[propertyMetadata.Name] = null;
		}
		return serializableDictionary;
	}

	public override string GetTypeDisplayName(Guid subTypeUid)
	{
		//Discarded unreachable code: IL_006c, IL_00fa, IL_0142, IL_01d3, IL_01e2, IL_0235, IL_0244
		int num = 3;
		int num2 = num;
		string text = default(string);
		T val = default(T);
		T val2 = default(T);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (text != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				try
				{
					int num3;
					if (!(subTypeUid != Guid.Empty))
					{
						num3 = 3;
						goto IL_0070;
					}
					object obj = MetadataServiceContext.Service.GetMetadata(subTypeUid) as T;
					goto IL_0115;
					IL_0115:
					val = (T)obj;
					num3 = 4;
					goto IL_0070;
					IL_0070:
					while (true)
					{
						switch (num3)
						{
						case 4:
							if (val != null)
							{
								num3 = 2;
								continue;
							}
							goto end_IL_0070;
						case 3:
							val2 = null;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							text = SR.T(val.DisplayName);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num3 = 1;
							}
							continue;
						default:
							obj = val2;
							break;
						case 1:
							goto end_IL_0070;
						}
						goto IL_0115;
						continue;
						end_IL_0070:
						break;
					}
				}
				catch (Exception exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							text = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765978578));
							num4 = 2;
							continue;
						default:
							base.Logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A75E52D), subTypeUid), exception);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num4 = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				goto case 1;
			case 4:
				return Name;
			default:
				return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D4126), text, Name);
			case 3:
				text = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual RelationType GetRelationType(TSettings typeSettings)
	{
		return typeSettings.RelationType;
	}

	protected abstract Guid GetIdentifierTypeUid(T metadata);

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00be, IL_00cd, IL_00dd, IL_00ec, IL_0129, IL_0138, IL_0147, IL_01fa
		int num = 10;
		Guid identifierTypeUid = default(Guid);
		T relatedEntityMetadata = default(T);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return new ColumnType(DbType.DateTime);
				case 12:
					if (!(identifierTypeUid == DoubleDescriptor.UID))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 7:
					return new ColumnType(DbType.Int64);
				case 4:
					if (!(identifierTypeUid == Int32Descriptor.UID))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 9:
					break;
				case 6:
					return new ColumnType(DbType.Int32);
				case 1:
					return new ColumnType(DbType.String, int.MaxValue);
				case 11:
					return new ColumnType(DbType.Guid);
				case 13:
					if (!(identifierTypeUid == GuidDescriptor.UID))
					{
						if (!(identifierTypeUid == DateTimeDescriptor.UID))
						{
							num2 = 12;
							continue;
						}
						goto case 5;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 11;
					}
					continue;
				case 8:
					return new ColumnType(DbType.Int16);
				case 3:
					if (!(identifierTypeUid == Int64Descriptor.UID))
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				default:
					return new ColumnType(DbType.Double);
				case 2:
					if (!(identifierTypeUid == Int16Descriptor.UID))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 10:
					relatedEntityMetadata = GetRelatedEntityMetadata(propertyMetadata);
					num2 = 9;
					continue;
				}
				break;
			}
			identifierTypeUid = GetIdentifierTypeUid(relatedEntityMetadata);
			num = 13;
		}
	}

	public override bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		//Discarded unreachable code: IL_01c4, IL_01d3, IL_0442, IL_04cb, IL_0542, IL_0551, IL_0561, IL_0570
		int num = 21;
		TSettings val2 = default(TSettings);
		RelationType relationType2 = default(RelationType);
		TSettings val = default(TSettings);
		RelationType relationType = default(RelationType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (string.IsNullOrEmpty(val2.RelationTableName))
					{
						num2 = 26;
						continue;
					}
					goto case 2;
				case 25:
					relationType2 = GetRelationType(val2);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 29:
					val = (TSettings)propertyMetadata.Settings;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 14;
					}
					continue;
				case 20:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDCF360));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					continue;
				case 27:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction(updater.Transform, val.RelationTableName, val2.ParentColumnName, val.ParentColumnName));
					num2 = 9;
					continue;
				case 6:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51177189)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 14:
					val2 = (TSettings)oldPropertyMetadata.Settings;
					num = 15;
					break;
				case 17:
					Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFC89BA), typeof(TSettings).FullName));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (relationType != relationType2)
					{
						num2 = 24;
						continue;
					}
					goto IL_01ae;
				case 5:
					Contract.CheckArgument(oldPropertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E008C0), typeof(TSettings).FullName));
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 12;
					}
					continue;
				case 15:
					relationType = GetRelationType(val);
					num2 = 25;
					continue;
				case 24:
					if (relationType != RelationType.OneToMany)
					{
						num2 = 16;
						continue;
					}
					goto IL_01ae;
				case 16:
					if (relationType != RelationType.ManyToManyInverse)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto IL_01ae;
				case 1:
					Contract.ArgumentNotNull(oldPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72456CE0));
					num = 12;
					break;
				case 2:
					if (val.RelationTableName.Equals(val2.RelationTableName, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 13;
				default:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541606305));
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 15;
					}
					continue;
				case 13:
					updater.TablesCreatedActions.Add(new DbRenameRelationTableAction(updater, entityMetadata, GetRelatedEntityMetadata(entityMetadata, propertyMetadata, throwOnError: false) as ClassMetadata, val2, val));
					num2 = 7;
					continue;
				case 8:
				case 19:
				case 26:
					if (val.ParentColumnName != val2.ParentColumnName)
					{
						num2 = 27;
						continue;
					}
					goto case 10;
				case 30:
					if (relationType != RelationType.ManyToMany)
					{
						num2 = 18;
						continue;
					}
					if (!string.IsNullOrEmpty(val.RelationTableName))
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 9:
					updater.ForeignKeysCreatedActions.Add(new DbCreateForeignKeyAction(updater.Transform, GetForeignKeyForParent(updater, entityMetadata, propertyMetadata)));
					num2 = 10;
					continue;
				case 7:
				case 18:
				case 22:
				case 23:
					return false;
				case 28:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction(updater.Transform, val.RelationTableName, val2.ChildColumnName, val.ChildColumnName));
					num2 = 23;
					continue;
				case 21:
					Contract.ArgumentNotNull(updater, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411346835));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 12;
					}
					continue;
				case 11:
				case 31:
					return base.ApplyDbChanges(updater, entityMetadata, propertyMetadata, oldPropertyMetadata);
				case 10:
					if (!(val.ChildColumnName != val2.ChildColumnName))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 28;
				case 12:
					{
						Contract.ArgumentNotNull(oldPropertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63A9CA7C));
						num2 = 5;
						continue;
					}
					IL_01ae:
					if (relationType == RelationType.OneToOne)
					{
						num2 = 31;
						continue;
					}
					goto case 30;
				}
				break;
			}
		}
	}

	private ForeignKey GetForeignKeyForParent(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		TSettings val = default(TSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				val = (TSettings)propertyMetadata.Settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new ForeignKey
				{
					Name = updater?.GenerateForeignKeyName(val.RelationTableName, val.ParentColumnName),
					TableName = val.RelationTableName,
					Columns = new List<string> { val.ParentColumnName },
					RefTableName = entityMetadata.TableName,
					RefColumns = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824355645) }
				};
			}
		}
	}

	protected virtual IEntityMetadata GetRelatedEntityMetadata(ClassMetadata metadata, PropertyMetadata propertyMetadata, bool throwOnError)
	{
		//Discarded unreachable code: IL_0055, IL_00b7, IL_00c6, IL_0114, IL_0147, IL_01c0, IL_01cf
		int num = 10;
		IEntityMetadata entityMetadata = default(IEntityMetadata);
		IMetadata metadata2 = default(IMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if (entityMetadata == null)
					{
						num2 = 8;
						break;
					}
					return entityMetadata;
				case 5:
					return null;
				case 4:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x747EB3A)), metadata.FullTypeName, propertyMetadata.Name, metadata2.GetType().FullName));
				case 3:
					if (metadata2 != null)
					{
						goto end_IL_0012;
					}
					goto case 12;
				case 1:
					try
					{
						metadata2 = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								base.Logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92D6699) + propertyMetadata.SubTypeUid, exception);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num4 = 0;
								}
								continue;
							default:
								metadata2 = null;
								num4 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					goto case 3;
				case 10:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488895847));
					num2 = 9;
					break;
				case 8:
					if (throwOnError)
					{
						num2 = 4;
						break;
					}
					goto case 5;
				case 9:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE104419));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					return null;
				case 2:
					entityMetadata = metadata2 as IEntityMetadata;
					num2 = 11;
					break;
				case 7:
					metadata2 = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				case 12:
					if (throwOnError)
					{
						throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978453129)), metadata.FullTypeName, propertyMetadata.Name, propertyMetadata.SubTypeUid));
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 6;
					}
					break;
				default:
					Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309774740), typeof(TSettings).FullName));
					num2 = 7;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	protected virtual T GetRelatedEntityMetadata(PropertyMetadata propertyMetadata)
	{
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289732808));
		Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411337093));
		Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1E6F34), typeof(TSettings).FullName));
		IMetadata metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
		if (metadata == null)
		{
			throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97819046)), propertyMetadata.Name, propertyMetadata.SubTypeUid));
		}
		return (metadata as T) ?? throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859004575)), propertyMetadata.Name, metadata.GetType().FullName));
	}

	public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals0.classMetadata = classMetadata;
		List<NamedMetadata> metadataList = ((IEnumerable<NamedMetadata>)(from m in MetadataServiceContext.Service.GetMetadataList().OfType<T>()
			orderby m.DisplayName
			select m into k
			where k.ShowInTypeTree
			select k)).ToList();
		return CompositeTypeDescriptorHelper.GetDescriptorsByGroups(this, metadataList).SelectMany((ITypeDescriptor d) => d.GetSubTypes(CS_0024_003C_003E8__locals0.classMetadata));
	}

	public override TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00cf, IL_00de, IL_010f, IL_011e, IL_015c, IL_016b, IL_02e0, IL_03a0
		int num = 12;
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		Column columnForIdentifier = default(Column);
		TSettings val = default(TSettings);
		T val2 = default(T);
		RelationType relationType = default(RelationType);
		Column column = default(Column);
		Table item = default(Table);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638556729));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					typeDbStructures = new TypeDbStructures();
					num2 = 20;
					continue;
				case 15:
					columnForIdentifier.Name = val.ParentColumnName;
					num = 6;
					break;
				case 6:
					if (val2 == null)
					{
						num2 = 24;
						continue;
					}
					goto case 10;
				case 22:
					relationType = val.RelationType;
					num2 = 21;
					continue;
				case 10:
				{
					SimpleTypeSettings obj = (SimpleTypeSettings)propertyMetadata.Settings;
					column = new Column(type: GetDbColumnType(entityMetadata, propertyMetadata), name: obj.FieldName);
					num2 = 25;
					continue;
				}
				case 14:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A40E77)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 17:
					typeDbStructures.Tables.Add(item);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
				case 25:
					column.Name = val.ChildColumnName;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 2;
					}
					continue;
				case 18:
				case 24:
					column = DbModelHelper.GetDefaultColumnForIdentifier();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					val2 = (T)GetRelatedEntityMetadata(entityMetadata, propertyMetadata, throwOnError: false);
					num2 = 22;
					continue;
				case 12:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643772245));
					num2 = 11;
					continue;
				case 16:
					val = (TSettings)propertyMetadata.Settings;
					num2 = 8;
					continue;
				case 7:
					typeDbStructures.ForeignKeys.Add(GetForeignKeyForParent(null, entityMetadata, propertyMetadata));
					num2 = 13;
					continue;
				case 23:
					if (!string.IsNullOrEmpty(val.RelationTableName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 5;
				case 4:
					Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765978886), typeof(TSettings)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 16;
					}
					continue;
				case 21:
					switch (relationType)
					{
					case RelationType.ManyToMany:
						break;
					default:
						goto IL_0381;
					case RelationType.OneToMany:
					case RelationType.ManyToManyInverse:
						goto IL_03b3;
					}
					goto case 23;
				default:
					return base.GetDbStructures(entityMetadata, propertyMetadata);
				case 13:
					goto IL_03b3;
				case 3:
					item = new Table
					{
						Name = val.RelationTableName,
						Columns = new List<Column> { columnForIdentifier, column }
					};
					num2 = 17;
					continue;
				case 19:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637C50BF)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 5:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138119623)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 2:
					{
						if (!string.IsNullOrEmpty(val.ParentColumnName))
						{
							if (string.IsNullOrEmpty(val.ChildColumnName))
							{
								num2 = 19;
								continue;
							}
							columnForIdentifier = DbModelHelper.GetColumnForIdentifier(entityMetadata);
							num = 15;
							break;
						}
						num2 = 14;
						continue;
					}
					IL_03b3:
					return typeDbStructures;
					IL_0381:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	private ISyntaxNode GetPropertyTypeReferenceInnerLogic(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_00a1, IL_00b0
		int num = 1;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F52FE4));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return TypeOf.ICollection.Raw.CreateTypeSyntax(syntaxNode);
			case 3:
				return typeof(ISet<>).CreateTypeSyntax(syntaxNode);
			default:
			{
				RelationType relationType = GetRelationType(propertyMetadata);
				syntaxNode = GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
				if (relationType == RelationType.OneToOne)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 4;
					}
					break;
				}
				if (!(classMetadata is DataClassMetadata))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
			case 4:
				return syntaxNode;
			}
		}
	}

	private ISyntaxNode GetPropertyInitExpressionInnerLogic(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_0271, IL_0280, IL_0339, IL_0348
		int num = 7;
		EntitySettings entitySettings = default(EntitySettings);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		T metadata = default(T);
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					entitySettings = (EntitySettings)propertyMetadata.Settings;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
				{
					propertyMetadata2 = FindProperty(metadata, entitySettings.SortPropertyUid, out var _);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 5:
					throw new ArgumentNullException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2024600D), propertyMetadata2.DisplayName, propertyMetadata2.Uid, propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid));
				case 3:
					return typeof(HashedSet<>).CreateTypeSyntax(syntaxNode).ObjectCreationExpression();
				case 12:
					throw new ArgumentNullException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36128757), entitySettings.SortPropertyUid, propertyMetadata.SubTypeUid));
				case 7:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105214288));
					num2 = 6;
					continue;
				case 11:
					if (propertyMetadata2 != null)
					{
						if (MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid) is ITypeGenerationInfo)
						{
							return typeof(IesiSortedSet<>).CreateTypeSyntax(syntaxNode).MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583761280)).InvocationExpression(propertyMetadata2.TypeUid.ToString().CreateSyntaxNode(), propertyMetadata2.SubTypeUid.ToString().CreateSyntaxNode(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088179850).ValueReturningLambdaExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488752795).IdentifierName().MemberAccessExpression(propertyMetadata2.Name)), entitySettings.SortPropertyOrder.CreateSyntaxNode());
						}
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 12;
					}
					continue;
				case 4:
					if (GetRelationType(propertyMetadata) != 0)
					{
						num2 = 8;
						continue;
					}
					goto default;
				case 1:
					if (entitySettings.SortPropertyUid != Guid.Empty)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 2:
					break;
				default:
					return null;
				case 8:
					syntaxNode = GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
					num2 = 9;
					continue;
				case 9:
					if (!entitySettings.CanSortProperty)
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				}
				break;
			}
			metadata = GetMetadata(propertyMetadata.SubTypeUid) as T;
			num = 10;
		}
	}

	private string GetEntityId(IEntity entity, Type entityType = null)
	{
		return entity.GetId().ToString();
	}

	protected RefCLRTypeDescriptorBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RefCLRTypeDescriptorBase()
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
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				entityUidProperties = new ConcurrentDictionary<Guid, Guid>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool h0aZ57o4At6H9x23Oh6J()
	{
		return z25R8do4H2dNgYl1XWsv == null;
	}

	internal static object K1uV1do47CHjOvQJqVyD()
	{
		return z25R8do4H2dNgYl1XWsv;
	}
}
