using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Db.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

public abstract class RefTypeDescriptor<T, SettingsT> : SimpleTypeDescriptor<T, SettingsT>, IMappingTypeDescriptor, IValidatableTypeDescriptor
{
	private static object lJYITxo0FtQoJ083xNLT;

	private Type GetComparerType(ClassMetadata classMetadata, EntityPropertyMetadata propertyMetadata, EntitySettings settings)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_0070, IL_012f
		int num = 6;
		EntityMetadata entityMetadata = default(EntityMetadata);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		ISortedProperty sortedProperty = default(ISortedProperty);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (settings.CanSortProperty)
					{
						num2 = 5;
						break;
					}
					goto default;
				case 2:
					return typeof(NHComparer<, >).MakeGenericType(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(classMetadata.Uid), MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(entityMetadata.Uid));
				default:
					return null;
				case 4:
				{
					propertyMetadata2 = RefTypeDescriptor<IEntity, EntitySettings>.FindProperty(entityMetadata, settings.SortPropertyUid, out EntityMetadata _);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					break;
				}
				case 5:
					if (!(settings.SortPropertyUid != Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 8;
				case 3:
					if (entityMetadata != null)
					{
						num2 = 4;
						break;
					}
					goto default;
				case 11:
					if (!sortedProperty.IsSupportSort())
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 8:
					entityMetadata = GetMetadata(propertyMetadata.SubTypeUid) as EntityMetadata;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 1;
					}
					break;
				case 10:
					sortedProperty = MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid) as ISortedProperty;
					num2 = 7;
					break;
				case 7:
					if (sortedProperty == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 11;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	protected override void CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata metadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_014e, IL_015d, IL_0297
		int num = 14;
		int num2 = num;
		EntityMetadata baseRefMetadata = default(EntityMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		EntitySettings entitySettings2 = default(EntitySettings);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		RelationType relationType = default(RelationType);
		while (true)
		{
			switch (num2)
			{
			case 6:
				mappingBuilder.OneToManyCollection(propertyMetadata.Name, baseRefMetadata.TableName, entitySettings.FieldName, entitySettings2.CascadeMode, 15, GetComparerType(metadata, propertyMetadata, entitySettings2));
				num2 = 2;
				break;
			case 8:
				throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97820642), propertyMetadata.Name));
			case 10:
				if (!(entitySettings2.KeyColumnUid == Guid.Empty))
				{
					propertyMetadata2 = RefTypeDescriptor<IEntity, EntitySettings>.FindProperty(entityMetadata, entitySettings2.KeyColumnUid, out baseRefMetadata);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 8;
				}
				break;
			case 5:
				return;
			case 12:
				throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC0C1E5)), entityMetadata.Name, entitySettings2.KeyColumnUid));
			case 7:
				if ((entitySettings = propertyMetadata2.Settings as EntitySettings) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					break;
				}
				if (relationType == RelationType.OneToMany)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
				mappingBuilder.ManyToManyCollection(propertyMetadata.Name, entitySettings.RelationTableName, entitySettings.ParentColumnName, entitySettings.ChildColumnName, entitySettings2.CascadeMode, 15, GetComparerType(metadata, propertyMetadata, entitySettings2), inverse: true);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if ((entityMetadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid, loadImplementation: false) as EntityMetadata) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				switch (relationType)
				{
				case RelationType.OneToMany:
				case RelationType.ManyToManyInverse:
					break;
				case RelationType.ManyToMany:
					mappingBuilder.ManyToManyCollection(propertyMetadata.Name, entitySettings2.RelationTableName, entitySettings2.ParentColumnName, entitySettings2.ChildColumnName, entitySettings2.CascadeMode, 15, GetComparerType(metadata, propertyMetadata, entitySettings2));
					num2 = 3;
					goto end_IL_0012;
				default:
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 9;
					}
					goto end_IL_0012;
				case RelationType.OneToOne:
					mappingBuilder.ManyToOne(propertyMetadata.Name, entitySettings2.FieldName, entitySettings2.CascadeMode);
					num2 = 11;
					goto end_IL_0012;
				}
				goto case 10;
			case 11:
				return;
			case 9:
				throw new NotImplementedException();
			default:
				throw new MetadataException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97812570), propertyMetadata.SubTypeUid));
			case 13:
				relationType = entitySettings2.RelationType;
				num2 = 4;
				break;
			case 14:
				entitySettings2 = (EntitySettings)propertyMetadata.Settings;
				num2 = 13;
				break;
			case 3:
				return;
			case 1:
				throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F320994)), entityMetadata.Name, propertyMetadata2.Name));
			case 15:
				if (propertyMetadata2 != null)
				{
					num2 = 7;
					break;
				}
				goto case 12;
			case 2:
				return;
				end_IL_0012:
				break;
			}
		}
	}

	public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_00e6, IL_00f5
		int num = 1;
		int num2 = num;
		string typeDisplayName = default(string);
		RelationType relationType = default(RelationType);
		while (true)
		{
			switch (num2)
			{
			default:
				typeDisplayName = GetTypeDisplayName(propertyMetadata.SubTypeUid);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				relationType = GetRelationType(propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487261070), typeDisplayName);
			case 2:
				return typeDisplayName;
			case 3:
				{
					switch (relationType)
					{
					case RelationType.OneToMany:
						break;
					case RelationType.ManyToMany:
						return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C514AC5), typeDisplayName);
					case RelationType.ManyToManyInverse:
						return SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269C2DAA), typeDisplayName);
					default:
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 4;
				}
				end_IL_0012:
				break;
			}
		}
	}

	protected override ColumnType GetDbColumnType(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		int num = 3;
		int num2 = num;
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (entityMetadata2 != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 1:
				if (((EntitySettings)propertyMetadata.Settings).RelationType != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 6;
					}
				}
				else
				{
					entityMetadata2 = (EntityMetadata)GetRelatedEntityMetadata(entityMetadata, propertyMetadata, throwOnError: false);
					num2 = 4;
				}
				break;
			case 3:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77DEE5));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108753188));
			default:
				return DbModelHelper.GetDefaultColumnForIdentifier().ColumnType;
			case 5:
				return DbModelHelper.GetColumnForIdentifier(entityMetadata2).ColumnType;
			case 7:
				Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638561411));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29101899));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	public override TypeDbStructures GetDbStructures(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0121, IL_0135, IL_0288, IL_02e3, IL_03d6, IL_0408, IL_0417, IL_0526, IL_0535
		int num = 23;
		Column columnForIdentifier = default(Column);
		EntitySettings entitySettings = default(EntitySettings);
		ForeignKey foreignKeyForChild = default(ForeignKey);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		RelationType relationType = default(RelationType);
		ForeignKey foreignKeyForOneToOne = default(ForeignKey);
		Column column3 = default(Column);
		Table item = default(Table);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Column column2;
				Column column;
				switch (num2)
				{
				case 32:
					columnForIdentifier.Name = entitySettings.ParentColumnName;
					num2 = 21;
					continue;
				case 6:
					if (foreignKeyForChild != null)
					{
						num2 = 28;
						continue;
					}
					goto IL_03c9;
				case 19:
					foreignKeyForChild = GetForeignKeyForChild(null, entityMetadata, propertyMetadata);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
				case 4:
					if (entityMetadata2 != null)
					{
						num = 9;
						break;
					}
					goto case 10;
				case 27:
					typeDbStructures = new TypeDbStructures();
					num2 = 29;
					continue;
				case 31:
					column2 = DbModelHelper.GetDefaultColumnForIdentifier();
					goto IL_0547;
				case 14:
					entitySettings = (EntitySettings)propertyMetadata.Settings;
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 6;
					}
					continue;
				case 12:
					relationType = entitySettings.RelationType;
					num2 = 5;
					continue;
				case 29:
					entityMetadata2 = (EntityMetadata)GetRelatedEntityMetadata(entityMetadata, propertyMetadata, throwOnError: false);
					num2 = 12;
					continue;
				case 17:
					typeDbStructures.ForeignKeys.Add(foreignKeyForOneToOne);
					num2 = 34;
					continue;
				case 23:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A69B62));
					num2 = 22;
					continue;
				case 11:
					foreignKeyForOneToOne = GetForeignKeyForOneToOne(null, entityMetadata, propertyMetadata);
					num2 = 8;
					continue;
				case 13:
					typeDbStructures.ForeignKeys.Add(GetForeignKeyForParent(null, entityMetadata, propertyMetadata));
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 14;
					}
					continue;
				case 26:
					Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E004E6));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 14;
					}
					continue;
				case 18:
					column3.Name = entitySettings.ChildColumnName;
					num2 = 25;
					continue;
				case 28:
					typeDbStructures.ForeignKeys.Add(foreignKeyForChild);
					num2 = 33;
					continue;
				case 8:
					if (foreignKeyForOneToOne == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 17;
				case 22:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E0165C));
					num2 = 26;
					continue;
				case 7:
					typeDbStructures.Columns.Add(column3);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 11;
					}
					continue;
				case 21:
					if (entityMetadata2 != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 31;
				case 25:
					item = new Table
					{
						Name = entitySettings.RelationTableName,
						Columns = new List<Column> { columnForIdentifier, column3 }
					};
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					switch (relationType)
					{
					case RelationType.ManyToMany:
						goto IL_039e;
					case RelationType.OneToMany:
					case RelationType.ManyToManyInverse:
						goto IL_03c9;
					}
					num2 = 4;
					continue;
				default:
					goto IL_039e;
				case 30:
				case 33:
				case 34:
					goto IL_03c9;
				case 10:
					column = DbModelHelper.GetDefaultColumnForIdentifier();
					goto IL_055a;
				case 2:
					typeDbStructures.Tables.Add(item);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 13;
					}
					continue;
				case 24:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811921528)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 20:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123761830)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 16:
					column3.Name = entitySettings.FieldName;
					num2 = 7;
					continue;
				case 1:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108115850)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 15:
					column2 = DbModelHelper.GetColumnForIdentifier(entityMetadata2);
					goto IL_0547;
				case 9:
					{
						column = DbModelHelper.GetColumnForIdentifier(entityMetadata2);
						goto IL_055a;
					}
					IL_039e:
					if (string.IsNullOrEmpty(entitySettings.RelationTableName))
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 24;
						}
						continue;
					}
					if (string.IsNullOrEmpty(entitySettings.ParentColumnName))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (!string.IsNullOrEmpty(entitySettings.ChildColumnName))
					{
						columnForIdentifier = DbModelHelper.GetColumnForIdentifier(entityMetadata);
						num = 32;
						break;
					}
					num2 = 20;
					continue;
					IL_03c9:
					return typeDbStructures;
					IL_0547:
					column3 = column2;
					num2 = 18;
					continue;
					IL_055a:
					column3 = column;
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	public override bool ApplyDbChanges(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata, EntityPropertyMetadata oldPropertyMetadata)
	{
		//Discarded unreachable code: IL_00cb, IL_013d, IL_014c
		int num = 14;
		RelationType relationType = default(RelationType);
		ForeignKey foreignKeyForChild = default(ForeignKey);
		EntitySettings entitySettings = default(EntitySettings);
		EntitySettings entitySettings2 = default(EntitySettings);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					Contract.ArgumentNotNull(updater, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921085437));
					num2 = 13;
					continue;
				case 29:
					if (relationType == RelationType.ManyToMany)
					{
						num2 = 22;
						continue;
					}
					goto case 7;
				case 24:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AE8EAB));
					num2 = 17;
					continue;
				case 17:
					Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x747E16E));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (foreignKeyForChild == null)
					{
						num = 10;
						break;
					}
					goto case 8;
				case 15:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction(updater.Transform, entitySettings.RelationTableName, entitySettings2.ParentColumnName, entitySettings.ParentColumnName));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
				case 10:
				case 23:
					return false;
				case 20:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459447627)), entityMetadata.FullTypeName, propertyMetadata.Name));
				case 8:
					updater.ForeignKeysCreatedActions.Add(new DbCreateForeignKeyAction(updater.Transform, foreignKeyForChild));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					if (!string.IsNullOrEmpty(entitySettings.RelationTableName))
					{
						num2 = 26;
						continue;
					}
					goto case 5;
				case 9:
					if (entitySettings.ChildColumnName != entitySettings2.ChildColumnName)
					{
						num2 = 4;
						continue;
					}
					goto case 7;
				case 19:
					entitySettings2 = (EntitySettings)oldPropertyMetadata.Settings;
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 28;
					}
					continue;
				case 27:
					entitySettings = (EntitySettings)propertyMetadata.Settings;
					num2 = 19;
					continue;
				case 28:
					if (entitySettings.RelationType != entitySettings2.RelationType)
					{
						num = 2;
						break;
					}
					goto IL_01e5;
				case 4:
					updater.TablesCreatedActions.Add(new DbRenameColumnAction(updater.Transform, entitySettings.RelationTableName, entitySettings2.ChildColumnName, entitySettings.ChildColumnName));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					if (entitySettings.ParentColumnName != entitySettings2.ParentColumnName)
					{
						num2 = 15;
						continue;
					}
					goto case 9;
				case 18:
					Contract.ArgumentNotNull(oldPropertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477297842));
					num2 = 21;
					continue;
				case 2:
					if (entitySettings.RelationType != RelationType.OneToMany)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto IL_01e5;
				case 25:
					if (!entitySettings.RelationTableName.Equals(entitySettings2.RelationTableName, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 6:
					foreignKeyForChild = GetForeignKeyForChild(updater, entityMetadata, propertyMetadata);
					num2 = 11;
					continue;
				case 3:
					updater.ForeignKeysCreatedActions.Add(new DbCreateForeignKeyAction(updater.Transform, GetForeignKeyForParent(updater, entityMetadata, propertyMetadata)));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 9;
					}
					continue;
				default:
					Contract.ArgumentNotNull(oldPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AFA2B2));
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 16;
					}
					continue;
				case 13:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787471305));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 24;
					}
					continue;
				case 1:
					updater.TablesCreatedActions.Add(new DbRenameRelationTableAction(updater, entityMetadata, GetRelatedEntityMetadata(entityMetadata, propertyMetadata, throwOnError: false) as ClassMetadata, entitySettings2, entitySettings));
					num2 = 23;
					continue;
				case 12:
					if (entitySettings.RelationType != RelationType.ManyToManyInverse)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto IL_01e5;
				case 26:
					if (!string.IsNullOrEmpty(entitySettings2.RelationTableName))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 5;
				case 21:
					Contract.CheckArgument(oldPropertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C51B545));
					num = 27;
					break;
				case 16:
					{
						bool num3 = base.ApplyDbChanges(updater, entityMetadata, propertyMetadata, oldPropertyMetadata);
						if (num3)
						{
							ForeignKey foreignKeyForOneToOne = GetForeignKeyForOneToOne(updater, entityMetadata, propertyMetadata);
							if (foreignKeyForOneToOne != null)
							{
								updater.ForeignKeysCreatedActions.Add(new DbCreateForeignKeyAction(updater.Transform, foreignKeyForOneToOne));
							}
						}
						return num3;
					}
					IL_01e5:
					if (entitySettings.RelationType == RelationType.OneToOne)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						continue;
					}
					relationType = entitySettings.RelationType;
					num = 29;
					break;
				}
				break;
			}
		}
	}

	public override ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		return GetPropertyTypeReferenceInnerLogic(classMetadata, propertyMetadata, forFilter);
	}

	public override ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return GetPropertyInitExpressionInnerLogic(classMetadata, propertyMetadata, forFilter);
	}

	public override IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		//Discarded unreachable code: IL_00bb, IL_01bb, IL_01ca
		int num = 8;
		int num2 = num;
		IPropertyDefaultValueContainer result = default(IPropertyDefaultValueContainer);
		IMetadataRuntimeService serviceNotNull = default(IMetadataRuntimeService);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		Type typeByUid = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				result = new PropertySetValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, loadImplementation: false), forFilter);
				num2 = 9;
				break;
			case 4:
				if ((dataClassMetadata = classMetadata as DataClassMetadata) != null)
				{
					num2 = 3;
					break;
				}
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				if ((entitySettings = propertyMetadata.Settings as EntitySettings) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 7;
					}
					break;
				}
				return new PropertyAnyTypeValueContainer(propertyMetadata);
			case 2:
				if (entitySettings.RelationType != 0)
				{
					num2 = 10;
					break;
				}
				goto case 12;
			case 12:
				return (IPropertyDefaultValueContainer)Activator.CreateInstance(typeof(PropertyValueContainer<>).MakeGenericType(typeByUid));
			case 10:
				return new PropertyCollectionValueContainer(typeByUid);
			case 7:
				if (forFilter)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 5:
				entitySettings = (EntitySettings)CreateSettingsForFilterProperty(propertyMetadata);
				num2 = 4;
				break;
			case 9:
				return result;
			case 1:
				result = new PropertyEntityValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, loadImplementation: false), forFilter);
				num2 = 6;
				break;
			case 3:
				typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid, !dataClassMetadata.IsInterfaceType);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return result;
			case 11:
				if (entitySettings.RelationType == RelationType.OneToOne)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public virtual MetadataItemValidationError[] Validate(IPropertyMetadata propertyMetadata)
	{
		int num = 3;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (entitySettings.RelationType != RelationType.ManyToManyInverse)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 3:
				entitySettings = propertyMetadata.Settings as EntitySettings;
				num2 = 2;
				break;
			default:
				if (entitySettings.RelationType == RelationType.OneToMany)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_00ff;
			case 2:
				if (entitySettings != null)
				{
					num2 = 4;
					break;
				}
				goto IL_00ff;
			case 1:
				return new MetadataItemValidationError[1]
				{
					new MetadataItemValidationError
					{
						MetadataUid = Uid,
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195713103), propertyMetadata.DisplayName)
					}
				};
			case 5:
				return new MetadataItemValidationError[1]
				{
					new MetadataItemValidationError
					{
						MetadataUid = Uid,
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE15393), propertyMetadata.DisplayName)
					}
				};
			case 6:
				{
					if (!string.IsNullOrEmpty(entitySettings.KeyColumnUidStr))
					{
						if (propertyMetadata.PropertyUid == entitySettings.KeyColumnUid)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto IL_00ff;
					}
					num2 = 5;
					break;
				}
				IL_00ff:
				return null;
			}
		}
	}

	protected ClassMetadata GetMetadata(Guid subTypeUid)
	{
		return ((ClassMetadata)MetadataServiceContext.Service.GetMetadata(subTypeUid, loadImplementation: false)) ?? throw new TypeNotFoundException(subTypeUid);
	}

	public static PropertyMetadata FindProperty(EntityMetadata metadata, Guid propertyUid, out EntityMetadata baseRefMetadata)
	{
		//Discarded unreachable code: IL_01a8, IL_01b2, IL_01d9, IL_01e8, IL_02a9, IL_02d9, IL_02e8, IL_02f4, IL_0303, IL_0356, IL_0375, IL_0384, IL_03c6, IL_03d5
		int num = 2;
		int num2 = num;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_2 = default(_003C_003Ec__DisplayClass11_0);
		IEnumerator<EntityMetadata> enumerator = default(IEnumerator<EntityMetadata>);
		_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_1);
		while (true)
		{
			switch (num2)
			{
			case 14:
				propertyMetadata = baseRefMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass11_2._003CFindProperty_003Eb__0);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				baseRefMetadata = metadata;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 20;
				}
				continue;
			case 15:
				enumerator = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where(_003C_003Ec__DisplayClass11_._003CFindProperty_003Eb__1)
					.GetEnumerator();
				num2 = 5;
				continue;
			case 18:
				_003C_003Ec__DisplayClass11_.brfMetadata = baseRefMetadata;
				num2 = 15;
				continue;
			case 16:
			case 19:
				if (propertyMetadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 11;
			case 4:
				if (propertyMetadata != null)
				{
					num2 = 9;
					continue;
				}
				break;
			case 8:
				if (propertyMetadata != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 13;
			case 13:
				if (propertyMetadata == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 17;
					}
					continue;
				}
				goto case 4;
			case 17:
				if (baseRefMetadata.Type == EntityMetadataType.Interface)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 4;
			case 5:
				try
				{
					while (true)
					{
						IL_01f3:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_01b6;
						}
						goto IL_022a;
						IL_01b6:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 4:
								goto IL_01f3;
							case 1:
								if (propertyMetadata != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto IL_01f3;
							case 3:
								goto IL_022a;
							case 2:
								break;
							}
							break;
						}
						break;
						IL_022a:
						propertyMetadata = enumerator.Current.Properties.FirstOrDefault(_003C_003Ec__DisplayClass11_2._003CFindProperty_003Eb__2);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num3 = 1;
						}
						goto IL_01b6;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num4 = 0;
						}
						goto IL_02ad;
					}
					goto IL_02c3;
					IL_02c3:
					enumerator.Dispose();
					num4 = 2;
					goto IL_02ad;
					IL_02ad:
					switch (num4)
					{
					default:
						goto end_IL_0288;
					case 1:
						break;
					case 0:
						goto end_IL_0288;
					case 2:
						goto end_IL_0288;
					}
					goto IL_02c3;
					end_IL_0288:;
				}
				goto case 4;
			case 2:
				_003C_003Ec__DisplayClass11_2 = new _003C_003Ec__DisplayClass11_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass11_2.propertyUid = propertyUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 7;
				}
				continue;
			default:
				return propertyMetadata;
			case 20:
				propertyMetadata = null;
				num2 = 16;
				continue;
			case 3:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_1();
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 18;
				}
				continue;
			case 11:
				if (baseRefMetadata == null)
				{
					num2 = 6;
					continue;
				}
				goto case 14;
			case 12:
				break;
			}
			baseRefMetadata = ((baseRefMetadata.BaseClassUid != Guid.Empty) ? (MetadataServiceContext.Service.GetMetadata(baseRefMetadata.BaseClassUid, loadImplementation: false) as EntityMetadata) : null);
			num2 = 19;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
			{
				num2 = 0;
			}
		}
	}

	protected RelationType GetRelationType(PropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31300CD0));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1635BB45));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return ((EntitySettings)propertyMetadata.Settings).RelationType;
			case 1:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBFC6C));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected abstract string GetTypeName(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter);

	private IEntityMetadata GetRelatedEntityMetadata(ClassMetadata metadata, PropertyMetadata propertyMetadata, bool throwOnError)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_00ff, IL_0138, IL_01e8, IL_0275
		int num = 1;
		IMetadata metadata2 = default(IMetadata);
		IEntityMetadata entityMetadata = default(IEntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (throwOnError)
					{
						num2 = 7;
						continue;
					}
					goto case 10;
				case 8:
					return null;
				case 13:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108787960)), metadata.FullTypeName, propertyMetadata.Name, metadata2.GetType().FullName));
				default:
					Contract.ArgumentNotNull(propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD73D86));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
					try
					{
						metadata2 = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
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
						int num4 = 2;
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							default:
								metadata2 = null;
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
								{
									num5 = 1;
								}
								continue;
							case 2:
								base.Logger.Debug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68B9C172) + propertyMetadata.SubTypeUid, exception);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
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
					goto case 11;
				case 9:
					metadata2 = null;
					num2 = 12;
					continue;
				case 11:
					if (metadata2 != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 4:
					if (throwOnError)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 8;
				case 1:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852851370));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				case 10:
					return null;
				case 7:
					throw new MetadataException(string.Format(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269C2BB6)), metadata.FullTypeName, propertyMetadata.Name, propertyMetadata.SubTypeUid));
				case 2:
					entityMetadata = metadata2 as IEntityMetadata;
					num2 = 6;
					continue;
				case 6:
					if (entityMetadata != null)
					{
						return entityMetadata;
					}
					num2 = 4;
					continue;
				}
				break;
			}
			Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16637557));
			num = 9;
		}
	}

	private ForeignKey GetForeignKeyForOneToOne(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		int num = 2;
		int num2 = num;
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (entityMetadata2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					entitySettings = (EntitySettings)propertyMetadata.Settings;
					num2 = 3;
				}
				break;
			default:
				return null;
			case 2:
				entityMetadata2 = (EntityMetadata)GetRelatedEntityMetadata(entityMetadata, propertyMetadata, throwOnError: false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return new ForeignKey
				{
					Name = updater?.GenerateForeignKeyName(entityMetadata.TableName, entitySettings.FieldName),
					TableName = entityMetadata.TableName,
					Columns = new List<string> { entitySettings.FieldName },
					RefTableName = entityMetadata2.TableName,
					RefColumns = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541764905) }
				};
			}
		}
	}

	private ForeignKey GetForeignKeyForParent(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				entitySettings = (EntitySettings)propertyMetadata.Settings;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new ForeignKey
				{
					Name = updater?.GenerateForeignKeyName(entitySettings.RelationTableName, entitySettings.ParentColumnName),
					TableName = entitySettings.RelationTableName,
					Columns = new List<string> { entitySettings.ParentColumnName },
					RefTableName = entityMetadata.TableName,
					RefColumns = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D70AD) }
				};
			}
		}
	}

	private ForeignKey GetForeignKeyForChild(IDbModelUpdater updater, EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0035
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				entityMetadata2 = (EntityMetadata)GetRelatedEntityMetadata(entityMetadata, propertyMetadata, throwOnError: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (entityMetadata2 != null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 3:
				return null;
			case 4:
				entitySettings = (EntitySettings)propertyMetadata.Settings;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return new ForeignKey
				{
					Name = updater?.GenerateForeignKeyName(entitySettings.RelationTableName, entitySettings.ChildColumnName),
					TableName = entitySettings.RelationTableName,
					Columns = new List<string> { entitySettings.ChildColumnName },
					RefTableName = entityMetadata2.TableName,
					RefColumns = new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87304919) }
				};
			}
		}
	}

	private ISyntaxNode GetPropertyTypeReferenceInnerLogic(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return TypeOf.ICollection.Raw.CreateTypeSyntax(syntaxNode);
			case 2:
				return syntaxNode;
			case 1:
				Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8313D60));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			RelationType relationType = GetRelationType(propertyMetadata);
			syntaxNode = GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
			if (relationType == RelationType.OneToOne)
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			if (!(classMetadata is DataClassMetadata))
			{
				return typeof(ISet<>).CreateTypeSyntax(syntaxNode);
			}
			num2 = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
			{
				num2 = 3;
			}
		}
	}

	private ISyntaxNode GetPropertyInitExpressionInnerLogic(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		//Discarded unreachable code: IL_00df, IL_01b0, IL_01bf, IL_01e5, IL_01f4, IL_0219
		int num = 2;
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		EntitySettings entitySettings = default(EntitySettings);
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
				{
					propertyMetadata2 = FindProperty(GetMetadata(propertyMetadata.SubTypeUid) as EntityMetadata, entitySettings.SortPropertyUid, out var _);
					num = 12;
					break;
				}
				case 1:
					entitySettings = (EntitySettings)propertyMetadata.Settings;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16378D7B));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (GetRelationType(propertyMetadata) != 0)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				case 11:
					throw new ArgumentNullException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1E673C), entitySettings.SortPropertyUid, propertyMetadata.SubTypeUid));
				case 5:
					if (!(MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid) is ITypeGenerationInfo))
					{
						num2 = 7;
						continue;
					}
					return typeof(IesiSortedSet<>).CreateTypeSyntax(syntaxNode).MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C94D7C0)).InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398550030).ValueReturningLambdaExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921073811).IdentifierName().MemberAccessExpression(propertyMetadata2.Name)), entitySettings.SortPropertyOrder.CreateSyntaxNode());
				default:
					return null;
				case 6:
					syntaxNode = GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					if (!entitySettings.CanSortProperty)
					{
						num2 = 13;
						continue;
					}
					goto case 10;
				case 12:
					if (propertyMetadata2 != null)
					{
						num = 5;
						break;
					}
					goto case 11;
				case 7:
					throw new ArgumentNullException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420901532), propertyMetadata2.DisplayName, propertyMetadata2.Uid, propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid));
				case 3:
				case 13:
					return typeof(HashedSet<>).CreateTypeSyntax(syntaxNode).ObjectCreationExpression();
				case 10:
					if (!(entitySettings.SortPropertyUid != Guid.Empty))
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	protected RefTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
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

	internal static bool ohb26fo0BwT0O19b2ecT()
	{
		return lJYITxo0FtQoJ083xNLT == null;
	}

	internal static object yKwdnyo0WYTFWHkmhBGc()
	{
		return lJYITxo0FtQoJ083xNLT;
	}
}
