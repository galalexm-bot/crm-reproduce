// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.RefTypeDescriptor`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание ссылочного типа данных</summary>
  /// <typeparam name="T"></typeparam>
  /// <typeparam name="SettingsT"></typeparam>
  public abstract class RefTypeDescriptor<T, SettingsT> : 
    SimpleTypeDescriptor<T, SettingsT>,
    IMappingTypeDescriptor,
    IValidatableTypeDescriptor
  {
    private static object lJYITxo0FtQoJ083xNLT;

    private Type GetComparerType(
      ClassMetadata classMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntitySettings settings)
    {
      int num1 = 6;
      EntityMetadata metadata;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata property;
        ISortedProperty typeDescriptor;
        while (true)
        {
          switch (num2)
          {
            case 2:
              goto label_5;
            case 3:
              if (metadata != null)
              {
                num2 = 4;
                continue;
              }
              goto label_6;
            case 4:
              property = RefTypeDescriptor<IEntity, EntitySettings>.FindProperty(metadata, settings.SortPropertyUid, out EntityMetadata _);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 10 : 1;
              continue;
            case 5:
              if (!(settings.SortPropertyUid != Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 6:
              if (settings.CanSortProperty)
              {
                num2 = 5;
                continue;
              }
              goto label_6;
            case 7:
              if (typeDescriptor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
                continue;
              }
              goto label_12;
            case 8:
              metadata = this.GetMetadata(propertyMetadata.SubTypeUid) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 1;
              continue;
            case 10:
              typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) as ISortedProperty;
              num2 = 7;
              continue;
            case 11:
              goto label_12;
            default:
              goto label_6;
          }
        }
label_12:
        if (!typeDescriptor.IsSupportSort())
          num1 = 9;
        else
          break;
      }
label_5:
      return typeof (NHComparer<,>).MakeGenericType(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(classMetadata.Uid), MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(metadata.Uid));
label_6:
      return (Type) null;
    }

    /// <summary>Создать мэппинг свойства</summary>
    /// <param name="mappingBuilder">Мэппинг</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected override void CreatePropertyMapping(
      INHibernatePropertiesMapper mappingBuilder,
      ClassMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 14;
      EntityMetadata baseRefMetadata;
      EntitySettings settings1;
      PropertyMetadata property;
      RelationType relationType;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_24;
          case 2:
            goto label_22;
          case 3:
            goto label_14;
          case 4:
            if (!(MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid, false) is EntityMetadata metadata1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            }
            switch (relationType)
            {
              case RelationType.OneToOne:
                mappingBuilder.ManyToOne(propertyMetadata.Name, settings1.FieldName, settings1.CascadeMode);
                num = 11;
                continue;
              case RelationType.OneToMany:
              case RelationType.ManyToManyInverse:
                goto label_5;
              case RelationType.ManyToMany:
                mappingBuilder.ManyToManyCollection(propertyMetadata.Name, settings1.RelationTableName, settings1.ParentColumnName, settings1.ChildColumnName, settings1.CascadeMode, 15, this.GetComparerType(metadata, propertyMetadata, settings1));
                num = 3;
                continue;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 6 : 9;
                continue;
            }
          case 5:
            goto label_21;
          case 6:
            mappingBuilder.OneToManyCollection(propertyMetadata.Name, baseRefMetadata.TableName, settings2.FieldName, settings1.CascadeMode, 15, this.GetComparerType(metadata, propertyMetadata, settings1));
            num = 2;
            continue;
          case 7:
            if (!(property.Settings is EntitySettings settings2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            }
            if (relationType == RelationType.OneToMany)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 6 : 0;
              continue;
            }
            mappingBuilder.ManyToManyCollection(propertyMetadata.Name, settings2.RelationTableName, settings2.ParentColumnName, settings2.ChildColumnName, settings1.CascadeMode, 15, this.GetComparerType(metadata, propertyMetadata, settings1), true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 1;
            continue;
          case 8:
            goto label_3;
          case 9:
            goto label_15;
          case 10:
label_5:
            if (!(settings1.KeyColumnUid == Guid.Empty))
            {
              property = RefTypeDescriptor<IEntity, EntitySettings>.FindProperty(metadata1, settings1.KeyColumnUid, out baseRefMetadata);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 15 : 7;
              continue;
            }
            num = 8;
            continue;
          case 11:
            goto label_7;
          case 12:
            goto label_9;
          case 13:
            relationType = settings1.RelationType;
            num = 4;
            continue;
          case 14:
            settings1 = (EntitySettings) propertyMetadata.Settings;
            num = 13;
            continue;
          case 15:
            if (property != null)
            {
              num = 7;
              continue;
            }
            goto label_9;
          default:
            goto label_16;
        }
      }
label_22:
      return;
label_14:
      return;
label_21:
      return;
label_7:
      return;
label_3:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97820642), (object) propertyMetadata.Name));
label_9:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304478181)), (object) metadata1.Name, (object) settings1.KeyColumnUid));
label_15:
      throw new NotImplementedException();
label_16:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97812570), (object) propertyMetadata.SubTypeUid));
label_24:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597114772)), (object) metadata1.Name, (object) property.Name));
    }

    /// <summary>Получить отображаемое имя типа у свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Отображаемое имя типа у свойства</returns>
    public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
    {
      int num = 1;
      string typeDisplayName;
      RelationType relationType;
      while (true)
      {
        switch (num)
        {
          case 1:
            relationType = this.GetRelationType(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            switch (relationType)
            {
              case RelationType.OneToMany:
                goto label_4;
              case RelationType.ManyToMany:
                goto label_5;
              case RelationType.ManyToManyInverse:
                goto label_6;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 0;
                continue;
            }
          case 4:
            goto label_4;
          default:
            typeDisplayName = this.GetTypeDisplayName(propertyMetadata.SubTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 3 : 3;
            continue;
        }
      }
label_4:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487261070), (object) typeDisplayName);
label_5:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011960517), (object) typeDisplayName);
label_6:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647769514), (object) typeDisplayName);
label_7:
      return typeDisplayName;
    }

    /// <summary>
    /// Получить тип колонки в БД - нет реализации, т.к. перекрыт метод GetDbStructures
    /// </summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 3;
      EntityMetadata relatedEntityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (((EntitySettings) propertyMetadata.Settings).RelationType != RelationType.OneToOne)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 6;
              continue;
            }
            relatedEntityMetadata = (EntityMetadata) this.GetRelatedEntityMetadata((ClassMetadata) entityMetadata, (PropertyMetadata) propertyMetadata, false);
            num = 4;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29101899));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 7 : 5;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712498917));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 2;
            continue;
          case 4:
            if (relatedEntityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 5;
              continue;
            }
            goto label_9;
          case 5:
            goto label_10;
          case 6:
            goto label_7;
          case 7:
            Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638561411));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_7:
      throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108753188));
label_9:
      return DbModelHelper.GetDefaultColumnForIdentifier().ColumnType;
label_10:
      return DbModelHelper.GetColumnForIdentifier(relatedEntityMetadata).ColumnType;
    }

    /// <summary>Получить информацию о требуемых структурах БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Структуры БД</returns>
    public override TypeDbStructures GetDbStructures(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 23;
      TypeDbStructures dbStructures;
      while (true)
      {
        int num2 = num1;
        Column columnForIdentifier1;
        while (true)
        {
          EntitySettings settings;
          ForeignKey foreignKeyForChild;
          EntityMetadata relatedEntityMetadata;
          RelationType relationType;
          ForeignKey foreignKeyForOneToOne;
          Column column;
          EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table;
          Column columnForIdentifier2;
          Column columnForIdentifier3;
          switch (num2)
          {
            case 1:
              goto label_41;
            case 2:
              dbStructures.Tables.Add(table);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 8 : 13;
              continue;
            case 3:
            case 4:
              if (relatedEntityMetadata == null)
                goto case 10;
              else
                goto label_8;
            case 5:
              switch (relationType)
              {
                case RelationType.OneToMany:
                case RelationType.ManyToManyInverse:
                  goto label_32;
                case RelationType.ManyToMany:
                  goto label_30;
                default:
                  num2 = 4;
                  continue;
              }
            case 6:
              if (foreignKeyForChild != null)
              {
                num2 = 28;
                continue;
              }
              goto label_32;
            case 7:
              dbStructures.Columns.Add(column);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 6 : 11;
              continue;
            case 8:
              if (foreignKeyForOneToOne == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 6 : 30;
                continue;
              }
              goto case 17;
            case 9:
              columnForIdentifier2 = DbModelHelper.GetColumnForIdentifier(relatedEntityMetadata);
              goto label_47;
            case 10:
              columnForIdentifier2 = DbModelHelper.GetDefaultColumnForIdentifier();
              goto label_47;
            case 11:
              foreignKeyForOneToOne = this.GetForeignKeyForOneToOne((IDbModelUpdater) null, entityMetadata, propertyMetadata);
              num2 = 8;
              continue;
            case 12:
              relationType = settings.RelationType;
              num2 = 5;
              continue;
            case 13:
              dbStructures.ForeignKeys.Add(this.GetForeignKeyForParent((IDbModelUpdater) null, entityMetadata, propertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 19 : 14;
              continue;
            case 14:
              settings = (EntitySettings) propertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 27 : 6;
              continue;
            case 15:
              columnForIdentifier3 = DbModelHelper.GetColumnForIdentifier(relatedEntityMetadata);
              break;
            case 16:
              column.Name = settings.FieldName;
              num2 = 7;
              continue;
            case 17:
              dbStructures.ForeignKeys.Add(foreignKeyForOneToOne);
              num2 = 34;
              continue;
            case 18:
              column.Name = settings.ChildColumnName;
              num2 = 25;
              continue;
            case 19:
              foreignKeyForChild = this.GetForeignKeyForChild((IDbModelUpdater) null, entityMetadata, propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 6 : 6;
              continue;
            case 20:
              goto label_38;
            case 21:
              if (relatedEntityMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 8 : 15;
                continue;
              }
              goto case 31;
            case 22:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239422556));
              num2 = 26;
              continue;
            case 23:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883333986));
              num2 = 22;
              continue;
            case 24:
              goto label_35;
            case 25:
              table = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table()
              {
                Name = settings.RelationTableName,
                Columns = new List<Column>()
                {
                  columnForIdentifier1,
                  column
                }
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 1;
              continue;
            case 26:
              Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239418086));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 6 : 14;
              continue;
            case 27:
              dbStructures = new TypeDbStructures();
              num2 = 29;
              continue;
            case 28:
              dbStructures.ForeignKeys.Add(foreignKeyForChild);
              num2 = 33;
              continue;
            case 29:
              relatedEntityMetadata = (EntityMetadata) this.GetRelatedEntityMetadata((ClassMetadata) entityMetadata, (PropertyMetadata) propertyMetadata, false);
              num2 = 12;
              continue;
            case 30:
            case 33:
            case 34:
              goto label_32;
            case 31:
              columnForIdentifier3 = DbModelHelper.GetDefaultColumnForIdentifier();
              break;
            case 32:
              columnForIdentifier1.Name = settings.ParentColumnName;
              num2 = 21;
              continue;
            default:
label_30:
              if (string.IsNullOrEmpty(settings.RelationTableName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 8 : 24;
                continue;
              }
              if (string.IsNullOrEmpty(settings.ParentColumnName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
                continue;
              }
              if (string.IsNullOrEmpty(settings.ChildColumnName))
              {
                num2 = 20;
                continue;
              }
              goto label_39;
          }
          column = columnForIdentifier3;
          num2 = 18;
          continue;
label_47:
          column = columnForIdentifier2;
          num2 = 16;
        }
label_8:
        num1 = 9;
        continue;
label_39:
        columnForIdentifier1 = DbModelHelper.GetColumnForIdentifier(entityMetadata);
        num1 = 32;
      }
label_32:
      return dbStructures;
label_35:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811921528)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
label_38:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123761830)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
label_41:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108115850)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
    }

    /// <summary>Применить изменения в структуре БД в updater</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="entityMetadata">Метаданные сущности (не может быть NULL)</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <param name="oldPropertyMetadata">Предыдущие метаданные свойства (не может быть NULL)</param>
    /// <returns>True, если есть изменения</returns>
    public override bool ApplyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        RelationType relationType;
        EntitySettings settings1;
        while (true)
        {
          ForeignKey foreignKeyForChild;
          EntitySettings settings2;
          switch (num2)
          {
            case 1:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameRelationTableAction(updater, (ClassMetadata) entityMetadata, this.GetRelatedEntityMetadata((ClassMetadata) entityMetadata, (PropertyMetadata) propertyMetadata, false) as ClassMetadata, settings2, settings1));
              num2 = 23;
              continue;
            case 2:
              if (settings1.RelationType != RelationType.OneToMany)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 3 : 12;
                continue;
              }
              break;
            case 3:
              updater.ForeignKeysCreatedActions.Add((IDbAction) new DbCreateForeignKeyAction(updater.Transform, this.GetForeignKeyForParent(updater, entityMetadata, propertyMetadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 4 : 9;
              continue;
            case 4:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(updater.Transform, settings1.RelationTableName, settings2.ChildColumnName, settings1.ChildColumnName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 6;
              continue;
            case 5:
              if (settings1.ParentColumnName != settings2.ParentColumnName)
              {
                num2 = 15;
                continue;
              }
              goto case 9;
            case 6:
              foreignKeyForChild = this.GetForeignKeyForChild(updater, entityMetadata, propertyMetadata);
              num2 = 11;
              continue;
            case 7:
            case 10:
            case 23:
              goto label_13;
            case 8:
              updater.ForeignKeysCreatedActions.Add((IDbAction) new DbCreateForeignKeyAction(updater.Transform, foreignKeyForChild));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 7;
              continue;
            case 9:
              if (settings1.ChildColumnName != settings2.ChildColumnName)
              {
                num2 = 4;
                continue;
              }
              goto label_13;
            case 11:
              if (foreignKeyForChild != null)
                goto case 8;
              else
                goto label_11;
            case 12:
              if (settings1.RelationType != RelationType.ManyToManyInverse)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 18 : 20;
                continue;
              }
              break;
            case 13:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787471305));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 6 : 24;
              continue;
            case 14:
              Contract.ArgumentNotNull((object) updater, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921085437));
              num2 = 13;
              continue;
            case 15:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(updater.Transform, settings1.RelationTableName, settings2.ParentColumnName, settings1.ParentColumnName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 3;
              continue;
            case 16:
              goto label_44;
            case 17:
              Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122151278));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            case 18:
              Contract.ArgumentNotNull((object) oldPropertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477297842));
              num2 = 21;
              continue;
            case 19:
              settings2 = (EntitySettings) oldPropertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 24 : 28;
              continue;
            case 20:
              goto label_14;
            case 21:
              goto label_43;
            case 22:
              if (!string.IsNullOrEmpty(settings1.RelationTableName))
              {
                num2 = 26;
                continue;
              }
              goto case 5;
            case 24:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44994219));
              num2 = 17;
              continue;
            case 25:
              if (!settings1.RelationTableName.Equals(settings2.RelationTableName, StringComparison.CurrentCultureIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                continue;
              }
              goto case 5;
            case 26:
              if (!string.IsNullOrEmpty(settings2.RelationTableName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 25 : 15;
                continue;
              }
              goto case 5;
            case 27:
              settings1 = (EntitySettings) propertyMetadata.Settings;
              num2 = 19;
              continue;
            case 28:
              if (settings1.RelationType == settings2.RelationType)
                break;
              goto label_25;
            case 29:
              if (relationType == RelationType.ManyToMany)
              {
                num2 = 22;
                continue;
              }
              goto label_13;
            default:
              Contract.ArgumentNotNull((object) oldPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397386418));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 18 : 16;
              continue;
          }
          if (settings1.RelationType == RelationType.OneToOne)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 16 : 0;
          else
            goto label_47;
        }
label_11:
        num1 = 10;
        continue;
label_25:
        num1 = 2;
        continue;
label_43:
        Contract.CheckArgument(oldPropertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011987781));
        num1 = 27;
        continue;
label_47:
        relationType = settings1.RelationType;
        num1 = 29;
      }
label_13:
      return false;
label_14:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459447627)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
label_44:
      int num3 = base.ApplyDbChanges(updater, entityMetadata, propertyMetadata, oldPropertyMetadata) ? 1 : 0;
      if (num3 == 0)
        return num3 != 0;
      ForeignKey foreignKeyForOneToOne = this.GetForeignKeyForOneToOne(updater, entityMetadata, propertyMetadata);
      if (foreignKeyForOneToOne == null)
        return num3 != 0;
      updater.ForeignKeysCreatedActions.Add((IDbAction) new DbCreateForeignKeyAction(updater.Transform, foreignKeyForOneToOne));
      return num3 != 0;
    }

    /// <summary>Получить ссылку на тип данных для свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Ссылка на тип данных</returns>
    public override ISyntaxNode GetPropertyTypeReference(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      return this.GetPropertyTypeReferenceInnerLogic(classMetadata, propertyMetadata, forFilter);
    }

    /// <summary>Получить выражение инициализации свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return this.GetPropertyInitExpressionInnerLogic(classMetadata, propertyMetadata, forFilter);
    }

    /// <summary>
    /// Получить контейнер свойства сущности с данными по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Контейнер</returns>
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num = 8;
      IPropertyDefaultValueContainer defaultContainer;
      Type typeByUid;
      while (true)
      {
        IMetadataRuntimeService serviceNotNull;
        switch (num)
        {
          case 1:
            defaultContainer = (IPropertyDefaultValueContainer) new PropertyEntityValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, false), forFilter);
            num = 6;
            continue;
          case 2:
            if (entitySettings.RelationType != RelationType.OneToOne)
            {
              num = 10;
              continue;
            }
            goto label_9;
          case 3:
            typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid, !dataClassMetadata.IsInterfaceType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 0;
            continue;
          case 4:
            if (classMetadata is DataClassMetadata dataClassMetadata)
            {
              num = 3;
              continue;
            }
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 11 : 7;
            continue;
          case 5:
            entitySettings = (EntitySettings) this.CreateSettingsForFilterProperty(propertyMetadata);
            num = 4;
            continue;
          case 6:
            goto label_18;
          case 7:
            if (forFilter)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 8:
            if (propertyMetadata.Settings is EntitySettings entitySettings)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 7;
              continue;
            }
            goto label_19;
          case 9:
            goto label_15;
          case 10:
            goto label_10;
          case 11:
            if (entitySettings.RelationType == RelationType.OneToOne)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 12:
            goto label_9;
        }
        defaultContainer = (IPropertyDefaultValueContainer) new PropertySetValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, false), forFilter);
        num = 9;
      }
label_9:
      return (IPropertyDefaultValueContainer) Activator.CreateInstance(typeof (PropertyValueContainer<>).MakeGenericType(typeByUid));
label_10:
      return (IPropertyDefaultValueContainer) new PropertyCollectionValueContainer(typeByUid);
label_15:
      return defaultContainer;
label_18:
      return defaultContainer;
label_19:
      return (IPropertyDefaultValueContainer) new PropertyAnyTypeValueContainer((IPropertyMetadata) propertyMetadata);
    }

    /// <inheritdoc />
    public virtual MetadataItemValidationError[] Validate(IPropertyMetadata propertyMetadata)
    {
      int num = 3;
      EntitySettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (settings != null)
            {
              num = 4;
              continue;
            }
            goto label_10;
          case 3:
            settings = propertyMetadata.Settings as EntitySettings;
            num = 2;
            continue;
          case 4:
            if (settings.RelationType != RelationType.ManyToManyInverse)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 5:
            goto label_11;
          case 6:
            if (!string.IsNullOrEmpty(settings.KeyColumnUidStr))
            {
              if (propertyMetadata.PropertyUid == settings.KeyColumnUid)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
                continue;
              }
              goto label_10;
            }
            else
            {
              num = 5;
              continue;
            }
          default:
            if (settings.RelationType == RelationType.OneToMany)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 6 : 1;
              continue;
            }
            goto label_10;
        }
      }
label_9:
      return new MetadataItemValidationError[1]
      {
        new MetadataItemValidationError()
        {
          MetadataUid = this.Uid,
          Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195713103), (object) propertyMetadata.DisplayName)
        }
      };
label_10:
      return (MetadataItemValidationError[]) null;
label_11:
      return new MetadataItemValidationError[1]
      {
        new MetadataItemValidationError()
        {
          MetadataUid = this.Uid,
          Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501306259), (object) propertyMetadata.DisplayName)
        }
      };
    }

    /// <summary>
    /// Получить метаданные сущности по уникальному идентификатору (из сервиса IMetadataService или IMetadataRuntimeService)
    /// </summary>
    /// <param name="subTypeUid">Uid сущности (подтипа)</param>
    /// <returns>Метаданные сущности</returns>
    protected ClassMetadata GetMetadata(Guid subTypeUid) => (ClassMetadata) MetadataServiceContext.Service.GetMetadata(subTypeUid, false) ?? throw new TypeNotFoundException(subTypeUid);

    /// <summary>Поиск свойства</summary>
    /// <param name="metadata"></param>
    /// <param name="propertyUid"></param>
    /// <returns></returns>
    public static PropertyMetadata FindProperty(
      EntityMetadata metadata,
      Guid propertyUid,
      out EntityMetadata baseRefMetadata)
    {
      int num1 = 2;
      PropertyMetadata property;
      IEnumerator<EntityMetadata> enumerator;
      Guid propertyUid1;
      EntityMetadata brfMetadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            propertyUid1 = propertyUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 7;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 16 : 18;
            continue;
          case 4:
label_8:
            if (property != null)
            {
              num1 = 9;
              continue;
            }
            goto case 12;
          case 5:
            try
            {
label_18:
              if (enumerator.MoveNext())
                goto label_22;
              else
                goto label_19;
label_17:
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (property != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_18;
                  case 3:
                    goto label_22;
                  case 4:
                    goto label_18;
                  default:
                    goto label_8;
                }
              }
label_19:
              num2 = 2;
              goto label_17;
label_22:
              List<PropertyMetadata> properties = enumerator.Current.Properties;
              Func<PropertyMetadata, bool> func;
              Func<PropertyMetadata, bool> func1 = func;
              Func<PropertyMetadata, bool> predicate = func1 == null ? (func = (Func<PropertyMetadata, bool>) (p => p.Uid == propertyUid1)) : func1;
              property = properties.FirstOrDefault<PropertyMetadata>(predicate);
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
              {
                num2 = 1;
                goto label_17;
              }
              else
                goto label_17;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              else
                goto label_27;
label_26:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_27:
              enumerator.Dispose();
              num3 = 2;
              goto label_26;
            }
          case 7:
            baseRefMetadata = metadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 13 : 20;
            continue;
          case 8:
            if (property != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 10;
              continue;
            }
            goto case 13;
          case 11:
            if (baseRefMetadata == null)
            {
              num1 = 6;
              continue;
            }
            goto case 14;
          case 12:
            baseRefMetadata = baseRefMetadata.BaseClassUid != Guid.Empty ? MetadataServiceContext.Service.GetMetadata(baseRefMetadata.BaseClassUid, false) as EntityMetadata : (EntityMetadata) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 19 : 0;
            continue;
          case 13:
            if (property == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 5 : 17;
              continue;
            }
            goto case 4;
          case 14:
            property = baseRefMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == propertyUid1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 8 : 0;
            continue;
          case 15:
            enumerator = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (e =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    if (e.Type == EntityMetadataType.InterfaceExtension)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              return e.BaseClassUid == brfMetadata.Uid;
label_5:
              return false;
            })).GetEnumerator();
            num1 = 5;
            continue;
          case 16:
          case 19:
            if (property != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            }
            goto case 11;
          case 17:
            if (baseRefMetadata.Type == EntityMetadataType.Interface)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 3 : 2;
              continue;
            }
            goto case 4;
          case 18:
            brfMetadata = baseRefMetadata;
            num1 = 15;
            continue;
          case 20:
            property = (PropertyMetadata) null;
            num1 = 16;
            continue;
          default:
            goto label_31;
        }
      }
label_31:
      return property;
    }

    /// <summary>Получить тип связи</summary>
    /// <param name="propertyMetadata"></param>
    /// <returns></returns>
    protected RelationType GetRelationType(PropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757150316));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372620101));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 3 : 2;
            continue;
          case 3:
            goto label_4;
          default:
            Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825232592));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      return ((EntitySettings) propertyMetadata.Settings).RelationType;
    }

    /// <summary>Получить имя типа данных CLR</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Имя типа</returns>
    protected abstract string GetTypeName(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter);

    private IEntityMetadata GetRelatedEntityMetadata(
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      bool throwOnError)
    {
      int num1 = 1;
      IMetadata metadata1;
      IEntityMetadata relatedEntityMetadata;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852851370));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 2:
              relatedEntityMetadata = metadata1 as IEntityMetadata;
              num2 = 6;
              continue;
            case 3:
              if (throwOnError)
              {
                num2 = 7;
                continue;
              }
              goto label_23;
            case 4:
              if (throwOnError)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 13 : 7;
                continue;
              }
              goto label_5;
            case 5:
              goto label_22;
            case 6:
              if (relatedEntityMetadata == null)
              {
                num2 = 4;
                continue;
              }
              goto label_7;
            case 7:
              goto label_24;
            case 8:
              goto label_5;
            case 9:
              metadata1 = (IMetadata) null;
              num2 = 12;
              continue;
            case 10:
              goto label_23;
            case 11:
label_17:
              if (metadata1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 0;
                continue;
              }
              goto case 3;
            case 12:
              try
              {
                metadata1 = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_17;
                }
              }
              catch (Exception ex)
              {
                int num4 = 2;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_17;
                    case 2:
                      this.Logger.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757004146) + (object) propertyMetadata.SubTypeUid), ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                      continue;
                    default:
                      metadata1 = (IMetadata) null;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
                      continue;
                  }
                }
              }
            case 13:
              goto label_6;
            default:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574387078));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 5;
              continue;
          }
        }
label_22:
        Contract.CheckArgument(propertyMetadata.Settings is EntitySettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16637557));
        num1 = 9;
      }
label_5:
      return (IEntityMetadata) null;
label_6:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108787960)), (object) metadata.FullTypeName, (object) propertyMetadata.Name, (object) metadata1.GetType().FullName));
label_7:
      return relatedEntityMetadata;
label_23:
      return (IEntityMetadata) null;
label_24:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647769014)), (object) metadata.FullTypeName, (object) propertyMetadata.Name, (object) propertyMetadata.SubTypeUid));
    }

    private ForeignKey GetForeignKeyForOneToOne(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 2;
      EntityMetadata relatedEntityMetadata;
      EntitySettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (relatedEntityMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            }
            settings = (EntitySettings) propertyMetadata.Settings;
            num = 3;
            continue;
          case 2:
            relatedEntityMetadata = (EntityMetadata) this.GetRelatedEntityMetadata((ClassMetadata) entityMetadata, (PropertyMetadata) propertyMetadata, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_7;
          default:
            goto label_4;
        }
      }
label_4:
      return (ForeignKey) null;
label_7:
      return new ForeignKey()
      {
        Name = updater == null ? (string) null : updater.GenerateForeignKeyName(entityMetadata.TableName, settings.FieldName),
        TableName = entityMetadata.TableName,
        Columns = new List<string>() { settings.FieldName },
        RefTableName = relatedEntityMetadata.TableName,
        RefColumns = new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541764905)
        }
      };
    }

    private ForeignKey GetForeignKeyForParent(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      EntitySettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            settings = (EntitySettings) propertyMetadata.Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new ForeignKey()
      {
        Name = updater == null ? (string) null : updater.GenerateForeignKeyName(settings.RelationTableName, settings.ParentColumnName),
        TableName = settings.RelationTableName,
        Columns = new List<string>()
        {
          settings.ParentColumnName
        },
        RefTableName = entityMetadata.TableName,
        RefColumns = new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867346093)
        }
      };
    }

    private ForeignKey GetForeignKeyForChild(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      EntityMetadata relatedEntityMetadata;
      EntitySettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            relatedEntityMetadata = (EntityMetadata) this.GetRelatedEntityMetadata((ClassMetadata) entityMetadata, (PropertyMetadata) propertyMetadata, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_5;
          case 4:
            settings = (EntitySettings) propertyMetadata.Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
            continue;
          default:
            if (relatedEntityMetadata != null)
            {
              num = 4;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return (ForeignKey) null;
label_7:
      return new ForeignKey()
      {
        Name = updater?.GenerateForeignKeyName(settings.RelationTableName, settings.ChildColumnName),
        TableName = settings.RelationTableName,
        Columns = new List<string>()
        {
          settings.ChildColumnName
        },
        RefTableName = relatedEntityMetadata.TableName,
        RefColumns = new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87304919)
        }
      };
    }

    private ISyntaxNode GetPropertyTypeReferenceInnerLogic(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num = 1;
      ISyntaxNode typeSyntax;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137444704));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_4;
          default:
            int relationType = (int) this.GetRelationType(propertyMetadata);
            typeSyntax = this.GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
            if (relationType == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 2;
              continue;
            }
            if (classMetadata is DataClassMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 3;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return TypeOf.ICollection.Raw.CreateTypeSyntax(typeSyntax);
label_5:
      return typeof (Iesi.Collections.Generic.ISet<>).CreateTypeSyntax(typeSyntax);
label_6:
      return typeSyntax;
    }

    private ISyntaxNode GetPropertyInitExpressionInnerLogic(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num1 = 2;
      EntitySettings settings;
      PropertyMetadata property;
      ISyntaxNode typeSyntax;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              settings = (EntitySettings) propertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 1;
              continue;
            case 2:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372739451));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
              continue;
            case 3:
            case 13:
              goto label_19;
            case 4:
              if (this.GetRelationType(propertyMetadata) != RelationType.OneToOne)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 6 : 6;
                continue;
              }
              goto label_11;
            case 5:
              if (!(MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) is ITypeGenerationInfo))
              {
                num2 = 7;
                continue;
              }
              goto label_18;
            case 6:
              typeSyntax = this.GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 7 : 8;
              continue;
            case 7:
              goto label_17;
            case 8:
              if (!settings.CanSortProperty)
              {
                num2 = 13;
                continue;
              }
              goto case 10;
            case 9:
              goto label_3;
            case 10:
              if (!(settings.SortPropertyUid != Guid.Empty))
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            case 11:
              goto label_8;
            case 12:
              goto label_15;
            default:
              goto label_11;
          }
        }
label_3:
        property = RefTypeDescriptor<T, SettingsT>.FindProperty(this.GetMetadata(propertyMetadata.SubTypeUid) as EntityMetadata, settings.SortPropertyUid, out EntityMetadata _);
        num1 = 12;
        continue;
label_15:
        if (property != null)
          num1 = 5;
        else
          break;
      }
label_8:
      throw new ArgumentNullException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293838140), (object) settings.SortPropertyUid, (object) propertyMetadata.SubTypeUid));
label_11:
      return (ISyntaxNode) null;
label_17:
      throw new ArgumentNullException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420901532), (object) property.DisplayName, (object) property.Uid, (object) property.TypeUid, (object) property.SubTypeUid));
label_18:
      return typeof (IesiSortedSet<>).CreateTypeSyntax(typeSyntax).MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479516608)).InvocationExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398550030).ValueReturningLambdaExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921073811).IdentifierName().MemberAccessExpression(property.Name)), settings.SortPropertyOrder.CreateSyntaxNode());
label_19:
      return typeof (HashedSet<>).CreateTypeSyntax(typeSyntax).ObjectCreationExpression();
    }

    protected RefTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ohb26fo0BwT0O19b2ecT() => RefTypeDescriptor<T, SettingsT>.lJYITxo0FtQoJ083xNLT == null;

    internal static object yKwdnyo0WYTFWHkmhBGc() => RefTypeDescriptor<T, SettingsT>.lJYITxo0FtQoJ083xNLT;
  }
}
