// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.RefCLRTypeDescriptorBase`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Базовый тип дескриптора для объектов, не являющихся сущностями
  /// </summary>
  public abstract class RefCLRTypeDescriptorBase<T, TSettings> : 
    CLRTypeDescriptor<T, TSettings>,
    IMappingTypeDescriptor
    where T : ClassMetadata
    where TSettings : EntitySettings
  {
    private static ConcurrentDictionary<Guid, Guid> entityUidProperties;
    internal static object z25R8do4H2dNgYl1XWsv;

    private Type GetComparerType(
      ClassMetadata classMetadata,
      EntityPropertyMetadata propertyMetadata,
      TSettings settings)
    {
      if (settings.CanSortProperty && settings.SortPropertyUid != Guid.Empty && this.GetMetadata(propertyMetadata.SubTypeUid) is T metadata)
      {
        PropertyMetadata property = this.FindProperty(metadata, settings.SortPropertyUid, out T _);
        if (MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) is ISortedProperty typeDescriptor && typeDescriptor.IsSupportSort())
          return typeof (NHComparer<,>).MakeGenericType(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(classMetadata.Uid), MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(metadata.Uid));
      }
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
      int num1 = 10;
      TSettings settings1;
      PropertyMetadata property;
      EntityPropertyMetadata propertyMetadata1;
      while (true)
      {
        int num2 = num1;
        T baseRefMetadata;
        RelationType relationType;
        RefCLRTypeDescriptorBase<T, TSettings> typeDescriptorBase;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_19;
            case 2:
              goto label_15;
            case 3:
              goto label_24;
            case 4:
              goto label_21;
            case 5:
              goto label_9;
            case 6:
              mappingBuilder.OneToManyCollection(propertyMetadata1.Name, this.GetTableName(baseRefMetadata), settings2.FieldName, settings1.CascadeMode, 15, this.GetComparerType(metadata, propertyMetadata1, settings1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 14 : 3;
              continue;
            case 7:
              goto label_30;
            case 8:
              if (property != null)
              {
                if (!(property.Settings is EntitySettings settings2))
                {
                  num2 = 2;
                  continue;
                }
                if (relationType != RelationType.OneToMany)
                {
                  mappingBuilder.ManyToManyCollection(propertyMetadata1.Name, settings2.RelationTableName, settings2.ParentColumnName, settings2.ChildColumnName, settings1.CascadeMode, 15, this.GetComparerType(metadata, propertyMetadata1, settings1), true);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                  continue;
                }
                num2 = 6;
                continue;
              }
              num2 = 5;
              continue;
            case 9:
              typeDescriptorBase = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 15 : 3;
              continue;
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 9 : 5;
              continue;
            case 11:
              if (MetadataServiceContext.Service.GetMetadata(propertyMetadata1.SubTypeUid, false) is T metadata1)
              {
                num2 = 12;
                continue;
              }
              goto label_24;
            case 12:
              switch (relationType)
              {
                case RelationType.OneToOne:
                  mappingBuilder.Property(propertyMetadata1.Name, settings1.FieldName, (Action<INHibernatePropertyTypeMapper>) (mapper =>
                  {
                    int num3 = 1;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          typeDescriptorBase.ExtendSetPropertyMapping(mapper, propertyMetadata1);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  }));
                  num2 = 13;
                  continue;
                case RelationType.OneToMany:
                  goto label_32;
                case RelationType.ManyToMany:
                  mappingBuilder.Set(propertyMetadata1.Name, settings1.RelationTableName, settings1.ParentColumnName, settings1.ChildColumnName, settings1.CascadeMode, 15, this.GetComparerType(metadata, propertyMetadata1, settings1), (Action<INHibernatePropertyTypeMapper>) (mapper =>
                  {
                    int num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          typeDescriptorBase.ExtendSetPropertyMapping(mapper, propertyMetadata1);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  }));
                  num2 = 4;
                  continue;
                default:
                  goto label_26;
              }
            case 13:
              goto label_13;
            case 14:
              goto label_3;
            case 15:
              propertyMetadata1 = propertyMetadata;
              num2 = 17;
              continue;
            case 16:
label_32:
              if (!(settings1.KeyColumnUid == Guid.Empty))
              {
                num2 = 19;
                continue;
              }
              goto label_30;
            case 17:
              settings1 = (TSettings) propertyMetadata1.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            case 18:
              goto label_20;
            case 19:
              property = this.FindProperty(metadata1, settings1.KeyColumnUid, out baseRefMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 8 : 1;
              continue;
            default:
              relationType = settings1.RelationType;
              num2 = 11;
              continue;
          }
        }
label_26:
        num1 = 18;
      }
label_19:
      return;
label_21:
      return;
label_13:
      return;
label_3:
      return;
label_9:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108789096)), (object) metadata1.Name, (object) settings1.KeyColumnUid));
label_15:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36130575)), (object) metadata1.Name, (object) property.Name));
label_20:
      throw new NotImplementedException();
label_24:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978614014), (object) propertyMetadata1.SubTypeUid));
label_30:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459446935), (object) propertyMetadata1.Name));
    }

    /// <summary>Расширить мэппинг Set-свойства</summary>
    /// <param name="mapper">Мэппинг</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected virtual void ExtendSetPropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
    }

    /// <summary>Получить тип</summary>
    protected abstract Type CodeTypeReferenceType(EntityPropertyMetadata propertyMetadata);

    /// <summary>Получить имя таблицы объекта из метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    protected abstract string GetTableName(T metadata);

    /// <summary>Получить тип метаданных сущности</summary>
    /// <param name="metadata">Метаданные</param>
    protected abstract EntityMetadataType GetEntityMetadataType(T metadata);

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

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata entityPropertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.ExtendSimplePropertyMapping(mapper, entityPropertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            mapper.Type(this.CodeTypeReferenceType(entityPropertyMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить тип связи</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    public virtual RelationType GetRelationType(PropertyMetadata propertyMetadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133069033));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319438702));
            num = 2;
            continue;
          default:
            Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200082397), (object) typeof (TSettings).Name));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
            continue;
        }
      }
label_5:
      return this.GetRelationType((TSettings) propertyMetadata.Settings);
    }

    /// <summary>Получить имя типа данных CLR</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Имя типа</returns>
    public virtual string GetTypeName(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num = 13;
      EntityMetadata entityMetadata1;
      EntityMetadata entityMetadata2;
      ClassMetadata metadata1;
      EntityMetadata metadata2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
          case 6:
          case 8:
          case 16:
          case 18:
            goto label_12;
          case 2:
            if (entityMetadata1.Type == EntityMetadataType.Interface)
            {
              num = 10;
              continue;
            }
            goto case 9;
          case 3:
            entityMetadata2 = classMetadata as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 5:
            if (metadata2 == null)
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 7:
            metadata1 = this.GetMetadata(metadata2.ImplementationUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 17 : 18;
            continue;
          case 9:
            if (entityMetadata1.Type == EntityMetadataType.InterfaceExtension)
            {
              num = 17;
              continue;
            }
            goto label_12;
          case 10:
            metadata1 = this.GetMetadata(entityMetadata1.ImplementationUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 16 : 0;
            continue;
          case 11:
            if (entityMetadata1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            }
            goto case 15;
          case 12:
            entityMetadata1 = metadata1 as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 3;
            continue;
          case 13:
            metadata1 = this.GetMetadata(propertyMetadata.SubTypeUid);
            num = 12;
            continue;
          case 14:
            if (entityMetadata2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 0;
              continue;
            }
            goto case 11;
          case 15:
            if (!entityMetadata2.IsInterfaceType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 2;
              continue;
            }
            goto label_12;
          case 17:
            metadata2 = this.GetMetadata(metadata1.BaseClassUid) as EntityMetadata;
            num = 5;
            continue;
          default:
            if (forFilter)
            {
              num = 4;
              continue;
            }
            goto case 14;
        }
      }
label_12:
      return metadata1.FullTypeName;
    }

    /// <summary>
    /// Получить метаданные сущности по уникальному идентификатору (из сервиса IMetadataService или IMetadataRuntimeService)
    /// </summary>
    /// <param name="subTypeUid">Uid сущности (подтипа)</param>
    /// <returns>Метаданные сущности</returns>
    protected ClassMetadata GetMetadata(Guid subTypeUid) => (ClassMetadata) MetadataServiceContext.Service.GetMetadata(subTypeUid, false) ?? throw new TypeNotFoundException(subTypeUid);

    /// <summary>Получить отображаемое имя типа у свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Отображаемое имя типа у свойства</returns>
    public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata)
    {
      int num1 = 4;
      string typeDisplayName;
      while (true)
      {
        int num2 = num1;
        RelationType relationType;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_6;
            case 3:
              typeDisplayName = this.GetTypeDisplayName(propertyMetadata.SubTypeUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
              continue;
            case 4:
              relationType = this.GetRelationType(propertyMetadata);
              num2 = 3;
              continue;
            default:
              goto label_3;
          }
        }
label_8:
        switch (relationType)
        {
          case RelationType.OneToMany:
            goto label_3;
          case RelationType.ManyToMany:
            goto label_4;
          case RelationType.ManyToManyInverse:
            goto label_5;
          default:
            num1 = 2;
            continue;
        }
      }
label_3:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200082457), (object) typeDisplayName);
label_4:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712369549), (object) typeDisplayName);
label_5:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638562703), (object) typeDisplayName);
label_6:
      return typeDisplayName;
    }

    /// <summary>Поиск свойства</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <param name="baseRefMetadata">Метаданные базового типа</param>
    public virtual PropertyMetadata FindProperty(
      T metadata,
      Guid propertyUid,
      out T baseRefMetadata)
    {
      baseRefMetadata = metadata;
      PropertyMetadata property = (PropertyMetadata) null;
      while (property == null && (object) baseRefMetadata != null)
      {
        property = baseRefMetadata.Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => p.Uid == propertyUid));
        if (property == null)
        {
          if (property == null && this.GetEntityMetadataType(baseRefMetadata) == EntityMetadataType.Interface)
          {
            T brfMetadata = baseRefMetadata;
            foreach (T obj in MetadataServiceContext.Service.GetMetadataList().OfType<T>().Where<T>((System.Func<T, bool>) (e => this.GetEntityMetadataType(e) == EntityMetadataType.InterfaceExtension && e.BaseClassUid == brfMetadata.Uid)))
            {
              property = obj.Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => p.Uid == propertyUid));
              if (property != null)
                break;
            }
          }
          if (property == null)
            baseRefMetadata = baseRefMetadata.BaseClassUid != Guid.Empty ? MetadataServiceContext.Service.GetMetadata(baseRefMetadata.BaseClassUid) as T : default (T);
          else
            break;
        }
        else
          break;
      }
      return property;
    }

    /// <inheritdoc />
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
      int num1 = 10;
      IPropertyDefaultValueContainer defaultContainer;
      Type typeByUid;
      while (true)
      {
        int num2 = num1;
        IMetadataRuntimeService serviceNotNull;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_17;
            case 3:
              goto label_10;
            case 4:
              defaultContainer = (IPropertyDefaultValueContainer) new PropertySetValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, false), forFilter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_20;
            case 6:
              typeByUid = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 3;
              continue;
            case 7:
              goto label_9;
            case 8:
            case 12:
              if (!(classMetadata is DataClassMetadata))
              {
                num2 = 13;
                continue;
              }
              goto case 6;
            case 9:
              if (!forFilter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 8 : 8;
                continue;
              }
              goto case 11;
            case 10:
              if (propertyMetadata.Settings is TSettings settings)
              {
                num2 = 9;
                continue;
              }
              goto label_18;
            case 11:
              settings = (TSettings) this.CreateSettingsForFilterProperty(propertyMetadata);
              num2 = 12;
              continue;
            case 13:
              serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
              num2 = 14;
              continue;
            case 14:
              if (settings.RelationType == RelationType.OneToOne)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 7;
                continue;
              }
              goto case 4;
            default:
              goto label_19;
          }
        }
label_9:
        defaultContainer = (IPropertyDefaultValueContainer) new PropertyEntityValueContainer(propertyMetadata, serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid, false), forFilter);
        num1 = 2;
        continue;
label_10:
        if (settings.RelationType != RelationType.OneToOne)
          num1 = 5;
        else
          goto label_19;
      }
label_8:
      return defaultContainer;
label_17:
      return defaultContainer;
label_18:
      return (IPropertyDefaultValueContainer) new PropertyAnyTypeValueContainer((IPropertyMetadata) propertyMetadata);
label_19:
      return (IPropertyDefaultValueContainer) Activator.CreateInstance(typeof (PropertyValueContainer<>).MakeGenericType(typeByUid));
label_20:
      return (IPropertyDefaultValueContainer) new PropertyCollectionValueContainer(typeByUid);
    }

    /// <inheritdoc />
    public override void Deserialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154098667));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439596900));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanWrite)
        return;
      if (values.Count == 0)
      {
        property.SetValue(obj, (object) null, (object[]) null);
      }
      else
      {
        object obj1;
        if (!values.TryGetValue(propertyMetadata.Name, out obj1))
          return;
        TSettings settings = (TSettings) propertyMetadata.Settings;
        IDictionary<string, object> dictionary1 = obj1 as IDictionary<string, object>;
        switch (this.GetRelationType(settings))
        {
          case RelationType.OneToOne:
            Type typeByUid1 = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
            object id = this.TryDeserializeEntityId(dictionary1, typeByUid1);
            IEntity entity1 = id != null ? (IEntity) ModelHelper.GetEntityManager(typeByUid1).LoadOrNull(id) : (IEntity) null;
            property.SetValue(obj, (object) entity1, (object[]) null);
            break;
          case RelationType.OneToMany:
          case RelationType.ManyToMany:
          case RelationType.ManyToManyInverse:
            IEnumerable enumerable1 = (IEnumerable) property.GetValue(obj, (object[]) null);
            IUntypedCollectionProxy untypedCollectionProxy = (IUntypedCollectionProxy) null;
            if (enumerable1 == null)
            {
              Type propertyType = property.PropertyType;
              Type type = (Type) null;
              if (propertyType.IsGenericType)
              {
                Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
                if (genericTypeDefinition == typeof (IDictionary<,>))
                {
                  type = typeof (Dictionary<,>).MakeGenericType(propertyType.GetGenericArguments());
                  enumerable1 = (IEnumerable) Activator.CreateInstance(type);
                  untypedCollectionProxy = (IUntypedCollectionProxy) enumerable1.AsUntypedIDictionary();
                }
                else if (genericTypeDefinition == typeof (ICollection<>) || genericTypeDefinition == typeof (IList<>))
                {
                  type = typeof (List<>).MakeGenericType(propertyType.GetGenericArguments());
                  enumerable1 = (IEnumerable) Activator.CreateInstance(type);
                  untypedCollectionProxy = (IUntypedCollectionProxy) enumerable1.AsUntypedICollection();
                }
              }
              else if (propertyType.IsArray && obj1 is ArrayList source)
              {
                type = propertyType.GetElementType();
                Array instance = Array.CreateInstance(type, source.Count);
                for (int index = 0; index < source.Count; ++index)
                  instance.SetValue(this.DeserializeSimple(source.ElementAt(index), type), index);
                enumerable1 = (IEnumerable) instance;
              }
              if (type == (Type) null)
                break;
              if (enumerable1 != null)
                property.SetValue(obj, (object) enumerable1, (object[]) null);
            }
            if (untypedCollectionProxy == null)
              untypedCollectionProxy = (IUntypedCollectionProxy) enumerable1.AsUntypedISet();
            if (untypedCollectionProxy == null)
              break;
            Dictionary<string, IEntity> dictionary2 = new Dictionary<string, IEntity>();
            foreach (IEntity entity2 in enumerable1)
              dictionary2[this.GetEntityId(entity2)] = entity2;
            List<string> stringList = new List<string>();
            if (obj1 is IEnumerable enumerable2)
            {
              foreach (object obj2 in enumerable2)
              {
                IDictionary<string, object> dictionary3 = obj2 as IDictionary<string, object>;
                Type typeByUid2 = MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
                IEntity entity3 = (IEntity) this.DeserializeSimple((object) dictionary3, typeByUid2);
                if (entity3 != null)
                {
                  string entityId = this.GetEntityId(entity3, typeByUid2);
                  if (!dictionary2.ContainsKey(entityId))
                    untypedCollectionProxy.Add((object) entity3);
                  stringList.Add(entityId);
                }
              }
            }
            using (Dictionary<string, IEntity>.Enumerator enumerator = dictionary2.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                KeyValuePair<string, IEntity> current = enumerator.Current;
                if (!stringList.Contains(current.Key))
                  untypedCollectionProxy.Remove((object) current.Value);
              }
              break;
            }
        }
      }
    }

    /// <summary>Попытаться десериализовать идентификатор сущности</summary>
    /// <param name="dictionary">Словарь, который может содержать идентификатор (в ключе Id)</param>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Идентификатор сущности нужного типа</returns>
    protected virtual object TryDeserializeEntityId(
      IDictionary<string, object> dictionary,
      Type entityType)
    {
      object idValue;
      return dictionary != null && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951482184), out idValue) ? ModelHelper.TryConvertEntityId(entityType, idValue) : (object) null;
    }

    /// <inheritdoc />
    public override IDictionary<string, object> Serialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      EntitySerializationSettings serializationSettings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138940730));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876048387));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary1 = new SerializableDictionary<string, object>();
      if (obj1 != null)
      {
        switch (((EntitySettings) propertyMetadata.Settings).RelationType)
        {
          case RelationType.OneToOne:
            if (obj1 is IEntity entity)
            {
              SerializableDictionary<string, object> serializableDictionary2 = new SerializableDictionary<string, object>();
              serializableDictionary2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876095503), entity.GetId());
              serializableDictionary2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304675377), (object) entity.ToString());
              serializableDictionary2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487404540), (object) InterfaceActivator.UID(obj1.GetType()).ToString());
              SerializableDictionary<string, object> serializableDictionary3 = serializableDictionary2;
              if (serializationSettings == null || serializationSettings.Mode == EntitySerializationMode.Default)
                serializableDictionary3[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889480832)] = (object) entity.ToString();
              serializableDictionary1[propertyMetadata.Name] = (object) serializableDictionary3;
              break;
            }
            break;
          case RelationType.OneToMany:
          case RelationType.ManyToMany:
          case RelationType.ManyToManyInverse:
            if (obj1 is IEnumerable enumerable)
            {
              SerializableList<object> serializableList = new SerializableList<object>();
              try
              {
                foreach (object obj2 in enumerable)
                  serializableList.Add(this.SerializeSimple(obj2, obj2.GetType(), serializationSettings));
                serializableDictionary1[propertyMetadata.Name] = (object) serializableList;
                break;
              }
              catch (Exception ex)
              {
                this.Logger.Log(EleWise.ELMA.Logging.LogLevel.Error, ex, ex.Message);
                break;
              }
            }
            else
              break;
        }
      }
      else
        serializableDictionary1[propertyMetadata.Name] = (object) null;
      return (IDictionary<string, object>) serializableDictionary1;
    }

    /// <inheritdoc />
    public override string GetTypeDisplayName(Guid subTypeUid)
    {
      int num1 = 3;
      string str;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_2:
            if (str != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            }
            goto label_19;
          case 2:
            try
            {
              int num2;
              if (!(subTypeUid != Guid.Empty))
                num2 = 3;
              else
                goto label_12;
label_6:
              T obj1;
              T obj2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_2;
                  case 2:
                    str = EleWise.ELMA.SR.T(obj1.DisplayName);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
                    continue;
                  case 3:
                    obj2 = default (T);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                    continue;
                  case 4:
                    if ((object) obj1 != null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_2;
                  default:
                    goto label_11;
                }
              }
label_11:
              T obj3 = obj2;
              goto label_13;
label_12:
              obj3 = MetadataServiceContext.Service.GetMetadata(subTypeUid) as T;
label_13:
              obj1 = obj3;
              num2 = 4;
              goto label_6;
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    str = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765978578));
                    num3 = 2;
                    continue;
                  case 2:
                    goto label_2;
                  default:
                    this.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712369453), (object) subTypeUid), ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
                    continue;
                }
              }
            }
          case 3:
            str = (string) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
            continue;
          case 4:
            goto label_19;
          default:
            goto label_20;
        }
      }
label_19:
      return this.Name;
label_20:
      return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333608742), (object) str, (object) this.Name);
    }

    /// <summary>Получить тип связи из настроек типа</summary>
    /// <param name="typeSettings">настройки типа</param>
    protected virtual RelationType GetRelationType(TSettings typeSettings) => typeSettings.RelationType;

    /// <summary>
    /// Получить уникальный идентификатор типа свойства идентификатора объекта
    /// </summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns></returns>
    protected abstract Guid GetIdentifierTypeUid(T metadata);

    /// <inheritdoc />
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        Guid identifierTypeUid;
        T relatedEntityMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              if (!(identifierTypeUid == Int16Descriptor.UID))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 3 : 1;
                continue;
              }
              goto label_17;
            case 3:
              if (!(identifierTypeUid == Int64Descriptor.UID))
              {
                num2 = 4;
                continue;
              }
              goto label_6;
            case 4:
              if (!(identifierTypeUid == Int32Descriptor.UID))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
                continue;
              }
              goto label_10;
            case 5:
              goto label_3;
            case 6:
              goto label_10;
            case 7:
              goto label_6;
            case 8:
              goto label_17;
            case 9:
              goto label_9;
            case 10:
              relatedEntityMetadata = this.GetRelatedEntityMetadata((PropertyMetadata) propertyMetadata);
              num2 = 9;
              continue;
            case 11:
              goto label_12;
            case 12:
              if (!(identifierTypeUid == DoubleDescriptor.UID))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 0;
                continue;
              }
              goto label_20;
            case 13:
              if (!(identifierTypeUid == GuidDescriptor.UID))
              {
                if (!(identifierTypeUid == DateTimeDescriptor.UID))
                {
                  num2 = 12;
                  continue;
                }
                goto label_3;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 2 : 11;
                continue;
              }
            default:
              goto label_20;
          }
        }
label_9:
        identifierTypeUid = this.GetIdentifierTypeUid(relatedEntityMetadata);
        num1 = 13;
      }
label_3:
      return new ColumnType(DbType.DateTime);
label_6:
      return new ColumnType(DbType.Int64);
label_10:
      return new ColumnType(DbType.Int32);
label_11:
      return new ColumnType(DbType.String, int.MaxValue);
label_12:
      return new ColumnType(DbType.Guid);
label_17:
      return new ColumnType(DbType.Int16);
label_20:
      return new ColumnType(DbType.Double);
    }

    /// <inheritdoc />
    public override bool ApplyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      int num1 = 21;
      while (true)
      {
        int num2 = num1;
        TSettings settings1;
        while (true)
        {
          RelationType relationType1;
          TSettings settings2;
          RelationType relationType2;
          switch (num2)
          {
            case 1:
              goto label_22;
            case 2:
              if (settings2.RelationTableName.Equals(settings1.RelationTableName, StringComparison.CurrentCultureIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 8 : 19;
                continue;
              }
              goto case 13;
            case 3:
              if (string.IsNullOrEmpty(settings1.RelationTableName))
              {
                num2 = 26;
                continue;
              }
              goto case 2;
            case 4:
              if (relationType2 != relationType1)
              {
                num2 = 24;
                continue;
              }
              break;
            case 5:
              Contract.CheckArgument(oldPropertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239419072), (object) typeof (TSettings).FullName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 29 : 12;
              continue;
            case 6:
              goto label_9;
            case 7:
            case 18:
            case 22:
            case 23:
              goto label_32;
            case 8:
            case 19:
            case 26:
              if (settings2.ParentColumnName != settings1.ParentColumnName)
              {
                num2 = 27;
                continue;
              }
              goto case 10;
            case 9:
              updater.ForeignKeysCreatedActions.Add((IDbAction) new DbCreateForeignKeyAction(updater.Transform, this.GetForeignKeyForParent(updater, entityMetadata, propertyMetadata)));
              num2 = 10;
              continue;
            case 10:
              if (!(settings2.ChildColumnName != settings1.ChildColumnName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 17 : 22;
                continue;
              }
              goto case 28;
            case 11:
            case 31:
              goto label_35;
            case 12:
              Contract.ArgumentNotNull((object) oldPropertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672071804));
              num2 = 5;
              continue;
            case 13:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameRelationTableAction(updater, (ClassMetadata) entityMetadata, this.GetRelatedEntityMetadata((ClassMetadata) entityMetadata, (PropertyMetadata) propertyMetadata, false) as ClassMetadata, (EntitySettings) settings1, (EntitySettings) settings2));
              num2 = 7;
              continue;
            case 14:
              goto label_12;
            case 15:
              relationType2 = this.GetRelationType(settings2);
              num2 = 25;
              continue;
            case 16:
              if (relationType2 != RelationType.ManyToManyInverse)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 6;
                continue;
              }
              break;
            case 17:
              Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536644026), (object) typeof (TSettings).FullName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
              continue;
            case 20:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323103072));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            case 21:
              Contract.ArgumentNotNull((object) updater, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411346835));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 20 : 12;
              continue;
            case 24:
              if (relationType2 != RelationType.OneToMany)
              {
                num2 = 16;
                continue;
              }
              break;
            case 25:
              relationType1 = this.GetRelationType(settings1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 0;
              continue;
            case 27:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(updater.Transform, settings2.RelationTableName, settings1.ParentColumnName, settings2.ParentColumnName));
              num2 = 9;
              continue;
            case 28:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(updater.Transform, settings2.RelationTableName, settings1.ChildColumnName, settings2.ChildColumnName));
              num2 = 23;
              continue;
            case 29:
              settings2 = (TSettings) propertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 4 : 14;
              continue;
            case 30:
label_29:
              if (relationType2 != RelationType.ManyToMany)
              {
                num2 = 18;
                continue;
              }
              if (!string.IsNullOrEmpty(settings2.RelationTableName))
              {
                num2 = 3;
                continue;
              }
              goto case 8;
            default:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541606305));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 17 : 15;
              continue;
          }
          if (relationType2 == RelationType.OneToOne)
            num2 = 31;
          else
            goto label_29;
        }
label_12:
        settings1 = (TSettings) oldPropertyMetadata.Settings;
        num1 = 15;
        continue;
label_22:
        Contract.ArgumentNotNull((object) oldPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917152480));
        num1 = 12;
      }
label_9:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360490889)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
label_32:
      return false;
label_35:
      return base.ApplyDbChanges(updater, entityMetadata, propertyMetadata, oldPropertyMetadata);
    }

    private ForeignKey GetForeignKeyForParent(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      TSettings settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            settings = (TSettings) propertyMetadata.Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824355645)
        }
      };
    }

    /// <summary>Получить метаданные ссылочного свойства</summary>
    /// <param name="metadata">Метаданные типа</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="throwOnError">Генерировать ошибку, при некорректных данных</param>
    protected virtual IEntityMetadata GetRelatedEntityMetadata(
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      bool throwOnError)
    {
      int num1 = 10;
      IEntityMetadata relatedEntityMetadata;
      IMetadata metadata1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
                metadata1 = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_8;
                }
              }
              catch (Exception ex)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      this.Logger.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153970329) + (object) propertyMetadata.SubTypeUid), ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_8;
                    default:
                      metadata1 = (IMetadata) null;
                      num4 = 2;
                      continue;
                  }
                }
              }
            case 2:
              relatedEntityMetadata = metadata1 as IEntityMetadata;
              num2 = 11;
              continue;
            case 3:
label_8:
              if (metadata1 == null)
                goto case 12;
              else
                goto label_9;
            case 4:
              goto label_6;
            case 5:
              goto label_5;
            case 6:
              goto label_22;
            case 7:
              metadata1 = (IMetadata) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
              continue;
            case 8:
              if (throwOnError)
              {
                num2 = 4;
                continue;
              }
              goto label_5;
            case 9:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235947033));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            case 10:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488895847));
              num2 = 9;
              continue;
            case 11:
              if (relatedEntityMetadata == null)
              {
                num2 = 8;
                continue;
              }
              goto label_7;
            case 12:
              if (!throwOnError)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 6;
                continue;
              }
              goto label_23;
            default:
              Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309774740), (object) typeof (TSettings).FullName));
              num2 = 7;
              continue;
          }
        }
label_9:
        num1 = 2;
      }
label_5:
      return (IEntityMetadata) null;
label_6:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122153786)), (object) metadata.FullTypeName, (object) propertyMetadata.Name, (object) metadata1.GetType().FullName));
label_7:
      return relatedEntityMetadata;
label_22:
      return (IEntityMetadata) null;
label_23:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978453129)), (object) metadata.FullTypeName, (object) propertyMetadata.Name, (object) propertyMetadata.SubTypeUid));
    }

    /// <summary>Получить метаданные типа свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойтва</param>
    protected virtual T GetRelatedEntityMetadata(PropertyMetadata propertyMetadata)
    {
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289732808));
      Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411337093));
      Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293840180), (object) typeof (TSettings).FullName));
      IMetadata metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
      if (metadata == null)
        throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97819046)), (object) propertyMetadata.Name, (object) propertyMetadata.SubTypeUid));
      return metadata is T obj ? obj : throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859004575)), (object) propertyMetadata.Name, (object) metadata.GetType().FullName));
    }

    /// <inheritdoc />
    public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => CompositeTypeDescriptorHelper.GetDescriptorsByGroups((ITypeDescriptor) this, ((IEnumerable<EleWise.ELMA.Model.Metadata.NamedMetadata>) MetadataServiceContext.Service.GetMetadataList().OfType<T>().OrderBy<T, string>((System.Func<T, string>) (m => m.DisplayName)).Where<T>((System.Func<T, bool>) (k => k.ShowInTypeTree))).ToList<EleWise.ELMA.Model.Metadata.NamedMetadata>()).SelectMany<ITypeDescriptor, ITypeDescriptor>((System.Func<ITypeDescriptor, IEnumerable<ITypeDescriptor>>) (d => d.GetSubTypes(classMetadata)));

    /// <summary>Получить информацию о требуемых структурах БД</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Структуры БД</returns>
    public override TypeDbStructures GetDbStructures(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 12;
      TypeDbStructures dbStructures;
      while (true)
      {
        int num2 = num1;
        Column columnForIdentifier;
        TSettings settings;
        T relatedEntityMetadata;
        RelationType relationType;
        Column column;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 25:
              column.Name = settings.ChildColumnName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 2;
              continue;
            case 2:
              if (!string.IsNullOrEmpty(settings.ParentColumnName))
              {
                if (string.IsNullOrEmpty(settings.ChildColumnName))
                {
                  num2 = 19;
                  continue;
                }
                goto label_29;
              }
              else
              {
                num2 = 14;
                continue;
              }
            case 3:
              table = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table()
              {
                Name = settings.RelationTableName,
                Columns = new List<Column>()
                {
                  columnForIdentifier,
                  column
                }
              };
              num2 = 17;
              continue;
            case 4:
              Contract.CheckArgument(propertyMetadata.Settings is TSettings, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765978886), (object) typeof (TSettings)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 16;
              continue;
            case 5:
              goto label_30;
            case 6:
              if ((object) relatedEntityMetadata == null)
              {
                num2 = 24;
                continue;
              }
              goto case 10;
            case 7:
              dbStructures.ForeignKeys.Add(this.GetForeignKeyForParent((IDbModelUpdater) null, entityMetadata, propertyMetadata));
              num2 = 13;
              continue;
            case 8:
              dbStructures = new TypeDbStructures();
              num2 = 20;
              continue;
            case 10:
              column = new Column(((SimpleTypeSettings) propertyMetadata.Settings).FieldName, this.GetDbColumnType(entityMetadata, propertyMetadata));
              num2 = 25;
              continue;
            case 11:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638556729));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 4 : 4;
              continue;
            case 12:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643772245));
              num2 = 11;
              continue;
            case 13:
              goto label_26;
            case 14:
              goto label_10;
            case 15:
              goto label_5;
            case 16:
              settings = (TSettings) propertyMetadata.Settings;
              num2 = 8;
              continue;
            case 17:
              dbStructures.Tables.Add(table);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 4;
              continue;
            case 18:
            case 24:
              column = DbModelHelper.GetDefaultColumnForIdentifier();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
              continue;
            case 19:
              goto label_28;
            case 20:
              relatedEntityMetadata = (T) this.GetRelatedEntityMetadata((ClassMetadata) entityMetadata, (PropertyMetadata) propertyMetadata, false);
              num2 = 22;
              continue;
            case 21:
              switch (relationType)
              {
                case RelationType.OneToMany:
                case RelationType.ManyToManyInverse:
                  goto label_26;
                case RelationType.ManyToMany:
                  goto label_20;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                  continue;
              }
            case 22:
              relationType = settings.RelationType;
              num2 = 21;
              continue;
            case 23:
label_20:
              if (!string.IsNullOrEmpty(settings.RelationTableName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
                continue;
              }
              goto label_30;
            default:
              goto label_25;
          }
        }
label_5:
        columnForIdentifier.Name = settings.ParentColumnName;
        num1 = 6;
        continue;
label_29:
        columnForIdentifier = DbModelHelper.GetColumnForIdentifier(entityMetadata);
        num1 = 15;
      }
label_10:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413404791)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
label_25:
      return base.GetDbStructures(entityMetadata, propertyMetadata);
label_26:
      return dbStructures;
label_28:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669091519)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
label_30:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138119623)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
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
            Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727344612));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_4;
          case 4:
            goto label_7;
          default:
            int relationType = (int) this.GetRelationType(propertyMetadata);
            typeSyntax = this.GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
            if (relationType == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 4;
              continue;
            }
            if (!(classMetadata is DataClassMetadata))
            {
              num = 3;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return TypeOf.ICollection.Raw.CreateTypeSyntax(typeSyntax);
label_4:
      return typeof (Iesi.Collections.Generic.ISet<>).CreateTypeSyntax(typeSyntax);
label_7:
      return typeSyntax;
    }

    private ISyntaxNode GetPropertyInitExpressionInnerLogic(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num1 = 7;
      EntitySettings settings;
      PropertyMetadata property;
      ISyntaxNode typeSyntax;
      while (true)
      {
        int num2 = num1;
        T metadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (settings.SortPropertyUid != Guid.Empty)
              {
                num2 = 2;
                continue;
              }
              goto label_7;
            case 2:
              goto label_18;
            case 3:
              goto label_7;
            case 4:
              if (this.GetRelationType(propertyMetadata) != RelationType.OneToOne)
              {
                num2 = 8;
                continue;
              }
              goto label_19;
            case 5:
              goto label_5;
            case 6:
              settings = (EntitySettings) propertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 4 : 4;
              continue;
            case 7:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105214288));
              num2 = 6;
              continue;
            case 8:
              typeSyntax = this.GetTypeName(classMetadata, propertyMetadata, forFilter).CreateTypeSyntax();
              num2 = 9;
              continue;
            case 9:
              if (!settings.CanSortProperty)
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            case 10:
              property = this.FindProperty(metadata, settings.SortPropertyUid, out T _);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 11 : 3;
              continue;
            case 11:
              if (property != null)
              {
                if (!(MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) is ITypeGenerationInfo))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 5 : 3;
                  continue;
                }
                goto label_6;
              }
              else
              {
                num2 = 12;
                continue;
              }
            case 12:
              goto label_8;
            default:
              goto label_19;
          }
        }
label_18:
        metadata = this.GetMetadata(propertyMetadata.SubTypeUid) as T;
        num1 = 10;
      }
label_5:
      throw new ArgumentNullException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539254797), (object) property.DisplayName, (object) property.Uid, (object) property.TypeUid, (object) property.SubTypeUid));
label_6:
      return typeof (IesiSortedSet<>).CreateTypeSyntax(typeSyntax).MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583761280)).InvocationExpression(property.TypeUid.ToString().CreateSyntaxNode(), property.SubTypeUid.ToString().CreateSyntaxNode(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088179850).ValueReturningLambdaExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488752795).IdentifierName().MemberAccessExpression(property.Name)), settings.SortPropertyOrder.CreateSyntaxNode());
label_7:
      return typeof (HashedSet<>).CreateTypeSyntax(typeSyntax).ObjectCreationExpression();
label_8:
      throw new ArgumentNullException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36128757), (object) settings.SortPropertyUid, (object) propertyMetadata.SubTypeUid));
label_19:
      return (ISyntaxNode) null;
    }

    /// <summary>Получить Uid сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="entityType">Тип сущности</param>
    /// <returns><c>Guid.Empty</c> если свойство не найдено, иначе uid сущности</returns>
    private string GetEntityId(IEntity entity, Type entityType = null) => entity.GetId().ToString();

    protected RefCLRTypeDescriptorBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static RefCLRTypeDescriptorBase()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RefCLRTypeDescriptorBase<T, TSettings>.entityUidProperties = new ConcurrentDictionary<Guid, Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool h0aZ57o4At6H9x23Oh6J() => RefCLRTypeDescriptorBase<T, TSettings>.z25R8do4H2dNgYl1XWsv == null;

    internal static object K1uV1do47CHjOvQJqVyD() => RefCLRTypeDescriptorBase<T, TSettings>.z25R8do4H2dNgYl1XWsv;
  }
}
