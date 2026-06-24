// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.EntityDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Объект"</summary>
  [Component(Order = 400)]
  public class EntityDescriptor : 
    RefTypeDescriptor<IEntity, EntitySettings>,
    IConvertableTypeDescriptor,
    IEqualityTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{72ED98CA-F260-4671-9BCD-FF1D80235F47}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    protected static readonly string IdPropertyName;
    protected const string NamePropertyName = "Name";
    protected const string UidPropertyName = "Uid";
    protected static readonly string TypeUidPropertyName;
    private static ConcurrentDictionary<Guid, Guid> entityUidProperties;
    [ThreadStatic]
    private static bool сheckSoftDeletable;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static EntityDescriptor NyA7jho90FTcZKmug8Y3;

    /// <summary>Uid типа данных или группы типов</summary>
    public override Guid Uid => EntityDescriptor.UID;

    /// <summary>Имя "Объект"</summary>
    public override string Name => (string) EntityDescriptor.VTfxOto9JfEHSGKRwBi7(EntityDescriptor.sGggSRo9M7FDG9iI3Gii(825385222 ^ 825294208));

    /// <summary>Uid родительской группы типов данных - корневая папка</summary>
    public override Guid ParentUid => Guid.Empty;

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num1 = 8;
      ICollection source1;
      EntityDescriptor entityDescriptor;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        int num2 = num1;
        EntitySettings settings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              goto label_21;
            case 3:
              source1 = val as ICollection;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_14;
            case 5:
              goto label_4;
            case 6:
              if (propertyMetadata1 != null)
              {
                num2 = 14;
                continue;
              }
              goto label_12;
            case 7:
              entityDescriptor = this;
              num2 = 12;
              continue;
            case 8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 7 : 1;
              continue;
            case 9:
              goto label_7;
            case 10:
              goto label_16;
            case 11:
              if (EntityDescriptor.nLFjy2o99PPyGug0YhUK((object) settings) != RelationType.OneToOne)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 3 : 3;
                continue;
              }
              goto label_16;
            case 12:
              propertyMetadata1 = propertyMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 6;
              continue;
            case 13:
              IEnumerable<object> source2 = source1.Cast<object>();
              // ISSUE: reference to a compiler-generated field
              Func<object, bool> func = EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__8_0;
              Func<object, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__8_0 = predicate = (Func<object, bool>) (v => v == null);
              }
              else
                goto label_26;
label_24:
              if (source2.All<object>(predicate))
              {
                num2 = 4;
                continue;
              }
              goto label_15;
label_26:
              predicate = func;
              goto label_24;
            case 14:
              settings = (EntitySettings) propertyMetadata1.Settings;
              num2 = 9;
              continue;
            default:
              if (source1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 9 : 13;
                continue;
              }
              goto label_21;
          }
        }
label_7:
        if (settings != null)
          num1 = 11;
        else
          break;
      }
label_4:
      return true;
label_12:
      return true;
label_14:
      return true;
label_15:
      // ISSUE: reference to a compiler-generated method
      return source1.Cast<object>().All<object>((Func<object, bool>) (c => entityDescriptor.\u003C\u003En__0(propertyMetadata1, c)));
label_16:
      return base.IsEmpty(propertyMetadata1, val);
label_21:
      return true;
    }

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
    {
      int num = 3;
      EntitySettings entitySettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityDescriptor.VFwffro9lujehijBYfDG((object) entitySettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (entitySettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
              continue;
            }
            goto label_6;
          case 3:
            entitySettings = (EntitySettings) EntityDescriptor.ANZRtso9d3igFQKtT5ZT((object) propertyMetadata);
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return EntityFilterDescriptor.UID;
label_6:
      return base.GetFilterType(propertyMetadata, entityMetadata);
    }

    /// <summary>
    /// Получить список подтипов - список типов объектов, разбитых по папкам
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => CompositeTypeDescriptorHelper.GetDescriptorsByGroups((ITypeDescriptor) this, ((IEnumerable<NamedMetadata>) EntityDescriptor.GetSubTypesMetadataList().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => EntityDescriptor.\u003C\u003Ec__DisplayClass10_0.jh66R0CSRbt9uGUIVtPP((object) this, m.GetType(), (object) classMetadata)))).ToList<NamedMetadata>());

    /// <summary>Получить метаданные списка подтипов</summary>
    /// <returns>Список метаданных подтипов</returns>
    public static IEnumerable<EntityMetadata> GetSubTypesMetadataList() => (IEnumerable<EntityMetadata>) MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            // ISSUE: reference to a compiler-generated method
            if (EntityDescriptor.\u003C\u003Ec.q4iTDACSEiNTm5bM0IUL((object) m) != EntityMetadataType.Entity)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            // ISSUE: reference to a compiler-generated method
            if (EntityDescriptor.\u003C\u003Ec.q4iTDACSEiNTm5bM0IUL((object) m) != EntityMetadataType.Interface)
            {
              num = 2;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated method
      return EntityDescriptor.\u003C\u003Ec.w312PSCSfZKkvrI2i0Fd((object) m);
label_7:
      return false;
    })).OrderBy<EntityMetadata, string>((Func<EntityMetadata, string>) (m => (string) EntityDescriptor.\u003C\u003Ec.ipFnHHCSQujnZhp7kJX7((object) m)));

    /// <summary>Записать в генерируемый тип дополнительные члены</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Список выражений</returns>
    public override IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new EntityDescriptor.\u003CGetAdditionalTypeMembers\u003Ed__12(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__classMetadata = classMetadata,
        \u003C\u003E3__propertyMetadata = propertyMetadata
      };
    }

    /// <inheritdoc />
    public override IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      EntityMetadata entityMetadata1 = classMetadata as EntityMetadata;
      if (EntityDescriptor.сheckSoftDeletable && entityMetadata1 != null && !entityMetadata1.IsInterfaceType && ((EntitySettings) propertyMetadata.Settings).RelationType == RelationType.OneToOne && this.GetMetadata(propertyMetadata.SubTypeUid) is EntityMetadata metadata1)
      {
        EntityMetadata entityMetadata2 = metadata1;
        if (metadata1.Type == EntityMetadataType.Interface)
          entityMetadata2 = (EntityMetadata) this.GetMetadata(metadata1.ImplementationUid);
        else if (metadata1.Type == EntityMetadataType.InterfaceExtension)
        {
          EntityMetadata metadata = (EntityMetadata) this.GetMetadata(metadata1.BaseClassUid);
          entityMetadata2 = metadata != null ? (EntityMetadata) this.GetMetadata(metadata.ImplementationUid) : (EntityMetadata) null;
        }
        if (entityMetadata2 == null)
          throw new EleWise.ELMA.Model.Metadata.MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309732580), (object) metadata1.FullTypeName, (object) metadata1.ImplementationUid));
        if (entityMetadata2.ImplementedInterfaces.EmptyIfNull<string>().Any<string>((Func<string, bool>) (n => Type.GetType(n) == TypeOf<ISoftDeletable>.Raw)))
          return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
          {
            typeof (EntityExtensions).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70134986)).InvocationExpression(fieldName.IdentifierName()).ReturnStatement()
          };
      }
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        fieldName.IdentifierName().ReturnStatement()
      };
    }

    /// <inheritdoc />
    public override IEnumerable<ISyntaxNode> GetPropertySetterExpressions(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      if (((EntitySettings) propertyMetadata.Settings).RelationType == RelationType.OneToOne || (classMetadata is EntityMetadata entityMetadata1 ? (entityMetadata1.Type != EntityMetadataType.InterfaceImplementation ? 1 : 0) : 1) != 0)
        return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value)
        };
      if (!(this.GetMetadata(propertyMetadata.SubTypeUid) is EntityMetadata metadata1) || !metadata1.IsInterfaceType)
        return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value)
        };
      EntityMetadata entityMetadata2 = (EntityMetadata) null;
      if (metadata1.Type == EntityMetadataType.Interface)
        entityMetadata2 = (EntityMetadata) this.GetMetadata(metadata1.ImplementationUid);
      else if (metadata1.Type == EntityMetadataType.InterfaceExtension)
      {
        EntityMetadata metadata2 = (EntityMetadata) this.GetMetadata(metadata1.BaseClassUid);
        if (metadata2 != null)
          entityMetadata2 = (EntityMetadata) this.GetMetadata(metadata2.ImplementationUid);
      }
      ISyntaxNode typeSyntax1 = metadata1.FullTypeName.CreateTypeSyntax();
      ISyntaxNode typeSyntax2 = entityMetadata2.FullTypeName.CreateTypeSyntax();
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        fieldName.IdentifierName().AssignmentStatement(typeof (WrappedSetHelper).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -476028473).GenericName(typeSyntax2, typeSyntax1)).InvocationExpression(SyntaxGeneratorExtensions.Value))
      };
    }

    /// <summary>Получить описание структуры сериализуемых значений</summary>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Объект с описанием структуры сериализуемых значений</returns>
    public override TypeSerializationDescriptor GetSerializeDescriptor(
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata)
    {
      int num1 = 5;
      string description1;
      PropertyMetadata propertyMetadata1;
      EntitySettings settings;
      string descr;
      EntityMetadata valueMd;
      string descrList;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          switch (num2)
          {
            case 1:
              object obj1;
              if (string.IsNullOrEmpty((string) EntityDescriptor.f1CIdio9rZ4r8OHxb0k6((object) propertyMetadata1)))
              {
                obj1 = (object) "";
              }
              else
              {
                object obj2 = EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-1824388195 ^ -1824488939);
                string displayName = propertyMetadata1.DisplayName;
                string description2 = propertyMetadata1.Description;
                object obj3 = description2 == null ? EntityDescriptor.VTfxOto9JfEHSGKRwBi7(EntityDescriptor.sGggSRo9M7FDG9iI3Gii(654297945 ^ 654136851)) : (object) description2;
                object obj4 = EntityDescriptor.iW4pjto9g1RnqhQdJkZs((object) this, (object) propertyMetadata1);
                obj1 = EntityDescriptor.TiPCRjo9YVNGPUXkAWdL(obj2, (object) displayName, obj3, obj4);
              }
              descrList = (string) obj1;
              num2 = 3;
              continue;
            case 2:
              if (valueMd != null)
              {
                num2 = 8;
                continue;
              }
              goto label_12;
            case 3:
              goto label_5;
            case 4:
              propertyMetadata1 = propertyMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 3 : 7;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              goto label_12;
            case 7:
              settings = (EntitySettings) EntityDescriptor.ANZRtso9d3igFQKtT5ZT((object) propertyMetadata1);
              num2 = 11;
              continue;
            case 8:
              goto label_13;
            case 9:
              str = EleWise.ELMA.SR.T((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(~538519529 ^ -538685062), EntityDescriptor.f1CIdio9rZ4r8OHxb0k6((object) propertyMetadata1), EntityDescriptor.iW4pjto9g1RnqhQdJkZs((object) this, (object) propertyMetadata1));
              break;
            case 10:
              str = "";
              break;
            case 11:
              if (!string.IsNullOrEmpty((string) EntityDescriptor.f1CIdio9rZ4r8OHxb0k6((object) propertyMetadata1)))
              {
                num2 = 9;
                continue;
              }
              goto case 10;
            default:
              object obj5;
              if (EntityDescriptor.MmKhu2o95vW1RVN7BrLD(EntityDescriptor.f1CIdio9rZ4r8OHxb0k6((object) propertyMetadata1)))
                obj5 = (object) "";
              else
                obj5 = EntityDescriptor.TiPCRjo9YVNGPUXkAWdL(EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-1204263869 ^ -1341583247 ^ 137625018), EntityDescriptor.f1CIdio9rZ4r8OHxb0k6((object) propertyMetadata1), EntityDescriptor.iq2isfo9jiuvYdZ9xIsq((object) propertyMetadata1), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867102659), (object) this.GetPropertyTypeDisplayName(propertyMetadata1)));
              descr = (string) obj5;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
              continue;
          }
          description1 = str;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
        }
label_5:
        valueMd = MetadataLoader.LoadMetadata(EntityDescriptor.aXsQDqo9LAocDrZMPFve((object) propertyMetadata1)) as EntityMetadata;
        num1 = 2;
      }
label_12:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-1350312861 << 3 ^ 2082242228), (object) propertyMetadata1.TypeUid));
label_13:
      Action<TypeSerializationDescriptorBuilder> action;
      return (TypeSerializationDescriptor) EntityDescriptor.cjl5e7o9Ui3Rt1ySfrgb((object) new TypeSerializationDescriptorBuilder().Description(description1).Item((Action<TypeSerializationItemDescriptorBuilder>) (i =>
      {
        int num26 = 4;
        while (true)
        {
          int num27 = num26;
          while (true)
          {
            switch (num27)
            {
              case 0:
                goto label_3;
              case 1:
                goto label_8;
              case 2:
                goto label_7;
              case 3:
                // ISSUE: reference to a compiler-generated method
                if (EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.EYa3byCSLS9sxj6RreAg((object) settings) == RelationType.OneToOne)
                {
                  num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
                  continue;
                }
                i.Descriptor((Action<TypeSerializationDescriptorBuilder>) (d =>
                {
                  int num28 = 1;
                  while (true)
                  {
                    switch (num28)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        ((TypeSerializationDescriptorBuilder) EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.lUbpAmCSUlp315lhlf3a((object) d.IsArray(), (object) descrList)).Item((Action<TypeSerializationItemDescriptorBuilder>) (ai =>
                        {
                          int num15 = 1;
                          while (true)
                          {
                            switch (num15)
                            {
                              case 0:
                                goto label_4;
                              case 1:
                                TypeSerializationItemDescriptorBuilder descriptorBuilder7 = ai;
                                Action<TypeSerializationDescriptorBuilder> action6 = action;
                                Action<TypeSerializationDescriptorBuilder> descriptorBuilder8 = action6 == null ? (action = (Action<TypeSerializationDescriptorBuilder>) (dd =>
                                {
                                  int num13 = 4;
                                  while (true)
                                  {
                                    switch (num13)
                                    {
                                      case 1:
                                        TypeSerializationDescriptorBuilder descriptorBuilder5 = dd;
                                        // ISSUE: reference to a compiler-generated field
                                        Action<TypeSerializationItemDescriptorBuilder> action4 = EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_12;
                                        Action<TypeSerializationItemDescriptorBuilder> itemBuilder3;
                                        if (action4 == null)
                                        {
                                          // ISSUE: reference to a compiler-generated field
                                          EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_12 = itemBuilder3 = (Action<TypeSerializationItemDescriptorBuilder>) (di =>
                                          {
                                            int num8 = 1;
                                            while (true)
                                            {
                                              switch (num8)
                                              {
                                                case 0:
                                                  goto label_2;
                                                case 1:
                                                  // ISSUE: reference to a compiler-generated method
                                                  // ISSUE: reference to a compiler-generated method
                                                  // ISSUE: reference to a compiler-generated method
                                                  ((TypeSerializationItemDescriptorBuilder) EntityDescriptor.\u003C\u003Ec.lUhaysCSCxx6iLfpXkcF((object) di, EntityDescriptor.\u003C\u003Ec.kXTnWDCSZew75h1Q6bNQ(-2112703338 ^ -2112693500))).Descriptor(EleWise.ELMA.SR.T((string) EntityDescriptor.\u003C\u003Ec.kXTnWDCSZew75h1Q6bNQ(-2138160520 ^ -2138316904)));
                                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                                                  continue;
                                                default:
                                                  goto label_4;
                                              }
                                            }
label_2:
                                            return;
label_4:;
                                          });
                                        }
                                        else
                                          goto label_18;
label_17:
                                        descriptorBuilder5.Item(itemBuilder3);
                                        num13 = 8;
                                        continue;
label_18:
                                        itemBuilder3 = action4;
                                        goto label_17;
                                      case 2:
                                        // ISSUE: reference to a compiler-generated method
                                        if (EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.SnbFmrCScgIMTapBj6WA((object) valueMd) != null)
                                        {
                                          num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                                          continue;
                                        }
                                        goto label_10;
                                      case 3:
                                        if (!valueMd.AllowCreateHeirs)
                                        {
                                          num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                                          continue;
                                        }
                                        goto case 5;
                                      case 4:
                                        TypeSerializationDescriptorBuilder descriptorBuilder6 = dd.Item((Action<TypeSerializationItemDescriptorBuilder>) (di =>
                                        {
                                          int num9 = 1;
                                          while (true)
                                          {
                                            switch (num9)
                                            {
                                              case 0:
                                                goto label_2;
                                              case 1:
                                                // ISSUE: reference to a compiler-generated method
                                                // ISSUE: reference to a compiler-generated method
                                                // ISSUE: reference to a compiler-generated method
                                                // ISSUE: reference to a compiler-generated method
                                                EntityDescriptor.\u003C\u003Ec.o6dJeeCSvFe126ve3CQp(EntityDescriptor.\u003C\u003Ec.lUhaysCSCxx6iLfpXkcF((object) di, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606621630)), EntityDescriptor.\u003C\u003Ec.A9Fy2OCS8J5CAJVu5rCt(EntityDescriptor.\u003C\u003Ec.kXTnWDCSZew75h1Q6bNQ(-1998538950 ^ -1998247326)));
                                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                                                continue;
                                              default:
                                                goto label_4;
                                            }
                                          }
label_2:
                                          return;
label_4:;
                                        }));
                                        // ISSUE: reference to a compiler-generated field
                                        Action<TypeSerializationItemDescriptorBuilder> action5 = EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_10;
                                        Action<TypeSerializationItemDescriptorBuilder> itemBuilder4;
                                        if (action5 == null)
                                        {
                                          // ISSUE: reference to a compiler-generated field
                                          EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_10 = itemBuilder4 = (Action<TypeSerializationItemDescriptorBuilder>) (di =>
                                          {
                                            int num10 = 1;
                                            while (true)
                                            {
                                              switch (num10)
                                              {
                                                case 0:
                                                  goto label_2;
                                                case 1:
                                                  // ISSUE: reference to a compiler-generated method
                                                  // ISSUE: reference to a compiler-generated method
                                                  // ISSUE: reference to a compiler-generated method
                                                  ((TypeSerializationItemDescriptorBuilder) EntityDescriptor.\u003C\u003Ec.lUhaysCSCxx6iLfpXkcF((object) di, EntityDescriptor.\u003C\u003Ec.kXTnWDCSZew75h1Q6bNQ(~210725948 ^ -210706429))).Descriptor((string) EntityDescriptor.\u003C\u003Ec.A9Fy2OCS8J5CAJVu5rCt((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153784137)));
                                                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                                                  continue;
                                                default:
                                                  goto label_4;
                                              }
                                            }
label_2:
                                            return;
label_4:;
                                          });
                                        }
                                        else
                                          goto label_19;
label_12:
                                        descriptorBuilder6.Item(itemBuilder4);
                                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 0;
                                        continue;
label_19:
                                        itemBuilder4 = action5;
                                        goto label_12;
                                      case 5:
                                        dd.Item((Action<TypeSerializationItemDescriptorBuilder>) (di =>
                                        {
                                          int num11 = 1;
                                          while (true)
                                          {
                                            switch (num11)
                                            {
                                              case 0:
                                                goto label_2;
                                              case 1:
                                                // ISSUE: reference to a compiler-generated method
                                                // ISSUE: reference to a compiler-generated method
                                                EntityDescriptor.\u003C\u003Ec.o6dJeeCSvFe126ve3CQp((object) di.Name(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97955276)), EntityDescriptor.\u003C\u003Ec.A9Fy2OCS8J5CAJVu5rCt((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822558812)));
                                                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                                                continue;
                                              default:
                                                goto label_4;
                                            }
                                          }
label_2:
                                          return;
label_4:;
                                        }));
                                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 6;
                                        continue;
                                      case 7:
                                        goto label_15;
                                      case 8:
                                        goto label_6;
                                      default:
                                        // ISSUE: reference to a compiler-generated method
                                        if (!EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.RvI3m9CSz83vAJ84SyqJ((object) valueMd))
                                        {
                                          num13 = 7;
                                          continue;
                                        }
                                        goto case 2;
                                    }
                                  }
label_15:
                                  return;
label_6:
                                  return;
label_10:;
                                })) : action6;
                                descriptorBuilder7.Descriptor(descriptorBuilder8);
                                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_2;
                            }
                          }
label_4:
                          return;
label_2:;
                        }));
                        num28 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.wvMbA2CSYx7yl7SLxKQe((object) i, EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.OTNtU7CSjoZgsw8mUqEA((object) propertyMetadata1));
                num27 = 3;
                continue;
              default:
                goto label_10;
            }
          }
label_8:
          i.Descriptor((Action<TypeSerializationDescriptorBuilder>) (d =>
          {
            int num29 = 5;
            while (true)
            {
              int num30 = num29;
              while (true)
              {
                switch (num30)
                {
                  case 1:
                    d.Item((Action<TypeSerializationItemDescriptorBuilder>) (di =>
                    {
                      int num22 = 1;
                      while (true)
                      {
                        switch (num22)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            EntityDescriptor.\u003C\u003Ec.o6dJeeCSvFe126ve3CQp(EntityDescriptor.\u003C\u003Ec.lUhaysCSCxx6iLfpXkcF((object) di, EntityDescriptor.\u003C\u003Ec.kXTnWDCSZew75h1Q6bNQ(-53329496 >> 4 ^ -3316104)), EntityDescriptor.\u003C\u003Ec.A9Fy2OCS8J5CAJVu5rCt(EntityDescriptor.\u003C\u003Ec.kXTnWDCSZew75h1Q6bNQ(1642859704 ^ 1642667780)));
                            num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    num30 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 2;
                    continue;
                  case 2:
                  case 7:
                    if (valueMd.IsUnique)
                    {
                      num30 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_11;
                  case 3:
                    TypeSerializationDescriptorBuilder descriptorBuilder11 = d;
                    // ISSUE: reference to a compiler-generated field
                    Action<TypeSerializationItemDescriptorBuilder> action9 = EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_6;
                    Action<TypeSerializationItemDescriptorBuilder> itemBuilder7;
                    if (action9 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_6 = itemBuilder7 = (Action<TypeSerializationItemDescriptorBuilder>) (di =>
                      {
                        int num23 = 1;
                        while (true)
                        {
                          switch (num23)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              EntityDescriptor.\u003C\u003Ec.o6dJeeCSvFe126ve3CQp(EntityDescriptor.\u003C\u003Ec.lUhaysCSCxx6iLfpXkcF((object) di, EntityDescriptor.\u003C\u003Ec.kXTnWDCSZew75h1Q6bNQ(-643786247 ^ -643762581)), EntityDescriptor.\u003C\u003Ec.A9Fy2OCS8J5CAJVu5rCt((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475569895)));
                              num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      });
                    }
                    else
                      goto label_19;
label_18:
                    descriptorBuilder11.Item(itemBuilder7);
                    num30 = 6;
                    continue;
label_19:
                    itemBuilder7 = action9;
                    goto label_18;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    if (!EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.NysjRICSsrn27c8hBBJk((object) valueMd))
                    {
                      num30 = 7;
                      continue;
                    }
                    goto case 1;
                  case 5:
                    // ISSUE: reference to a compiler-generated method
                    TypeSerializationDescriptorBuilder descriptorBuilder12 = ((TypeSerializationDescriptorBuilder) EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.lUbpAmCSUlp315lhlf3a((object) d, (object) descr)).Item((Action<TypeSerializationItemDescriptorBuilder>) (di =>
                    {
                      int num24 = 1;
                      while (true)
                      {
                        switch (num24)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            EntityDescriptor.\u003C\u003Ec.o6dJeeCSvFe126ve3CQp(EntityDescriptor.\u003C\u003Ec.lUhaysCSCxx6iLfpXkcF((object) di, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576182534)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516673106)));
                            num24 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    // ISSUE: reference to a compiler-generated field
                    Action<TypeSerializationItemDescriptorBuilder> action10 = EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_4;
                    Action<TypeSerializationItemDescriptorBuilder> itemBuilder8;
                    if (action10 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__15_4 = itemBuilder8 = (Action<TypeSerializationItemDescriptorBuilder>) (di =>
                      {
                        int num25 = 1;
                        while (true)
                        {
                          switch (num25)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              EntityDescriptor.\u003C\u003Ec.o6dJeeCSvFe126ve3CQp(EntityDescriptor.\u003C\u003Ec.lUhaysCSCxx6iLfpXkcF((object) di, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487391834)), EntityDescriptor.\u003C\u003Ec.A9Fy2OCS8J5CAJVu5rCt((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886810093)));
                              num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      });
                    }
                    else
                      goto label_20;
label_13:
                    descriptorBuilder12.Item(itemBuilder8);
                    num30 = 4;
                    continue;
label_20:
                    itemBuilder8 = action10;
                    goto label_13;
                  case 6:
                    goto label_16;
                  default:
                    goto label_8;
                }
              }
label_8:
              // ISSUE: reference to a compiler-generated method
              if (EntityDescriptor.\u003C\u003Ec__DisplayClass15_0.SnbFmrCScgIMTapBj6WA((object) valueMd) != null)
                num29 = 3;
              else
                goto label_3;
            }
label_16:
            return;
label_11:
            return;
label_3:;
          }));
          num26 = 2;
        }
label_3:
        return;
label_7:
        return;
label_10:;
      })));
    }

    public override TypeSerializationDescriptor GetSerializeDescriptor(Guid subTypeUid)
    {
      int num = 2;
      PropertyMetadata propertyMetadata1;
      TypeSerializationDescriptor serializeDescriptor;
      EntityMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = new EntityMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 3 : 2;
            continue;
          case 2:
            serializeDescriptor = new TypeSerializationDescriptor();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
            continue;
          case 3:
            PropertyMetadata propertyMetadata2 = new PropertyMetadata();
            propertyMetadata2.Name = (string) EntityDescriptor.fu9QDyo9sMj57bHq21jD((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824373669), EntityDescriptor.VTfxOto9JfEHSGKRwBi7(EntityDescriptor.sGggSRo9M7FDG9iI3Gii(1917256330 ^ 1917162038)), EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-16752921 ^ -16772825));
            EntityDescriptor.DAaEZSo9c26UD4B01XkT((object) propertyMetadata2, this.Uid);
            propertyMetadata2.SubTypeUid = subTypeUid;
            propertyMetadata1 = propertyMetadata2;
            num = 4;
            continue;
          case 4:
            metadata.Properties.Add(propertyMetadata1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 3 : 6;
            continue;
          case 5:
            ICollection<TypeSerializationItemDescriptor> items1 = serializeDescriptor.Items;
            TypeSerializationItemDescriptor serializationItemDescriptor1 = new TypeSerializationItemDescriptor();
            serializationItemDescriptor1.Name = EleWise.ELMA.SR.T((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-882126494 ^ -882290846), (object) (EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-1317790512 ^ -1317633340).ToString() + (object) RelationType.OneToOne));
            EntityDescriptor.C37BVrodFhIBj61bKhqy((object) serializationItemDescriptor1, (object) this.GetSerializeDescriptor((ClassMetadata) metadata, propertyMetadata1));
            TypeSerializationItemDescriptor serializationItemDescriptor2 = serializationItemDescriptor1;
            items1.Add(serializationItemDescriptor2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 6 : 7;
            continue;
          case 6:
            EntityDescriptor.Do51Wjo9z2On9XKYiDRF((object) (EntitySettings) propertyMetadata1.Settings, RelationType.OneToOne);
            num = 5;
            continue;
          case 7:
            EntityDescriptor.Do51Wjo9z2On9XKYiDRF((object) (EntitySettings) EntityDescriptor.ANZRtso9d3igFQKtT5ZT((object) propertyMetadata1), RelationType.ManyToMany);
            num = 8;
            continue;
          case 8:
            ICollection<TypeSerializationItemDescriptor> items2 = serializeDescriptor.Items;
            TypeSerializationItemDescriptor serializationItemDescriptor3 = new TypeSerializationItemDescriptor();
            EntityDescriptor.QubtcaodWxhC5S84uyKS((object) serializationItemDescriptor3, (object) EleWise.ELMA.SR.T((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-1852837372 ^ -1853002748), EntityDescriptor.PTr3mkodB9TEO4tKZUwq(EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-1217523399 ^ -1217622159), (object) RelationType.OneToOne)));
            EntityDescriptor.C37BVrodFhIBj61bKhqy((object) serializationItemDescriptor3, (object) this.GetSerializeDescriptor((ClassMetadata) metadata, propertyMetadata1));
            TypeSerializationItemDescriptor serializationItemDescriptor4 = serializationItemDescriptor3;
            items2.Add(serializationItemDescriptor4);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return serializeDescriptor;
    }

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="serializationSettings">Настройки сериализации</param>
    /// <returns>Словарь сериализуемых значений</returns>
    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings serializationSettings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825370680));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218478340));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      using (ReferenceResolverSerializer.CreateResolver(ReferenceResolverSerializer.CurrentResolver != null | (serializationSettings != null && serializationSettings.WriteReferences)))
      {
        object obj1 = property.GetValue(obj, (object[]) null);
        SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
        if (obj1 != null)
        {
          switch (((EntitySettings) propertyMetadata.Settings).RelationType)
          {
            case RelationType.OneToOne:
              serializableDictionary[propertyMetadata.Name] = this.SerializeSimple(obj1, obj1.GetType(), serializationSettings);
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
                  serializableDictionary[propertyMetadata.Name] = (object) serializableList;
                  break;
                }
                catch (LazyInitializationException ex)
                {
                  this.Logger.Log(EleWise.ELMA.Logging.LogLevel.Debug, (Exception) ex, ex.Message);
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
          serializableDictionary[propertyMetadata.Name] = (object) null;
        return (IDictionary<string, object>) serializableDictionary;
      }
    }

    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 2;
      IReferenceResolver referenceResolver;
      bool flag1;
      IDisposable disposable;
      EntitySerializationSettings settings1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              settings1 = settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
            case 3:
              num3 = EntityDescriptor.bWpPduodbBoo4jF6ETiF((object) settings1) ? 1 : 0;
              break;
            case 4:
              referenceResolver = (IReferenceResolver) EntityDescriptor.SR49OWodhF5C0uU5I7Re();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 8;
              continue;
            case 5:
              if (settings1 == null)
              {
                num3 = 0;
                break;
              }
              goto label_122;
            case 6:
              goto label_120;
            case 7:
              goto label_8;
            case 8:
              disposable = (IDisposable) EntityDescriptor.evm0aOodGIEu960xfRNc(referenceResolver != null | flag1);
              num2 = 7;
              continue;
            default:
              goto label_7;
          }
          flag1 = num3 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 4;
        }
label_4:
        if (!EntityDescriptor.fOg8cKodoLabF4DApiQF(valueType, (Type) null))
        {
          num1 = 5;
          continue;
        }
        goto label_120;
label_122:
        num1 = 3;
      }
label_7:
      object obj;
      return obj;
label_8:
      try
      {
        int num4;
        // ISSUE: type reference
        if (EntityDescriptor.Rdtb3fodEj9WldhCsD2n(__typeref (IEntity)).IsAssignableFrom(valueType))
          num4 = 52;
        else
          goto label_16;
label_11:
        while (true)
        {
          int num5;
          bool flag2;
          IEntity entity;
          SerializableDictionary<string, object> serializableDictionary1;
          IEnumerator<KeyValuePair<string, object>> enumerator;
          string reference;
          EntityPropertyMetadata propertyMetadata;
          EntityMetadata valueMd;
          switch (num4)
          {
            case 1:
              if (valueType.IsInterface)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 36 : 4;
                continue;
              }
              goto case 61;
            case 2:
            case 26:
              propertyMetadata = (EntityPropertyMetadata) EntityDescriptor.bIQkvVodqc6moksZ09nE((object) valueMd);
              num5 = 44;
              break;
            case 3:
              if (EntityDescriptor.DntH6GodvqjPnMFG0u8B(EntityDescriptor.tbmoRkodCtV4AEFC5BAg((object) settings1)) != SelectionMode.Default)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 6 : 16;
                continue;
              }
              goto case 5;
            case 4:
              if (EntityDescriptor.nNyu9HodiBEQtdhmif3a((object) valueMd))
              {
                num4 = 13;
                continue;
              }
              goto case 6;
            case 5:
            case 15:
              if (EntityDescriptor.dFUH1noduobUSk8j6Jx0((object) settings1.TypePropertySelector) > 0)
              {
                num4 = 51;
                continue;
              }
              goto case 35;
            case 6:
              if (settings1 == null)
              {
                num4 = 59;
                continue;
              }
              goto case 49;
            case 7:
              obj = (object) null;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 43 : 34;
              continue;
            case 8:
              goto label_100;
            case 9:
            case 19:
            case 39:
              if (settings1 != null)
              {
                num4 = 18;
                continue;
              }
              goto case 42;
            case 10:
              if (EntityDescriptor.vnytVFodQ7LhRKFIhpv4((object) settings1) == EntitySerializationMode.Default)
              {
                num4 = 20;
                continue;
              }
              goto case 35;
            case 11:
              enumerator = ((IEnumerable<KeyValuePair<string, object>>) EntityDescriptor.Jp8J3vodIOCEDWS0B0Tw((object) new EntityJsonSerializer(), (object) entity, (object) settings1)).GetEnumerator();
              num4 = 30;
              continue;
            case 12:
            case 14:
              obj = (object) serializableDictionary1;
              num5 = 31;
              break;
            case 13:
            case 59:
            case 66:
              serializableDictionary1.Add(EntityDescriptor.TypeUidPropertyName, (object) EntityDescriptor.txZuxZodRdw61Gr5LRxu((object) valueMd));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 26 : 19;
              continue;
            case 16:
              enumerator = ((IEnumerable<KeyValuePair<string, object>>) new EntityJsonSerializer().ConvertToSerializable((object) entity, settings1)).GetEnumerator();
              num4 = 68;
              continue;
            case 17:
              if (settings1.Mode != EntitySerializationMode.Default)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 25 : 33;
                continue;
              }
              goto case 4;
            case 18:
              if (EntityDescriptor.vnytVFodQ7LhRKFIhpv4((object) settings1) != EntitySerializationMode.Default)
              {
                num4 = 14;
                continue;
              }
              goto case 42;
            case 20:
              if (settings1.PropertySelector == null)
              {
                num4 = 5;
                continue;
              }
              goto case 3;
            case 21:
              if (entity != null)
              {
                num4 = 65;
                continue;
              }
              goto case 7;
            case 22:
              if (flag2)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 41 : 30;
                continue;
              }
              goto case 38;
            case 23:
            case 24:
            case 31:
            case 43:
            case 48:
            case 56:
            case 62:
              goto label_7;
            case 25:
              if (valueMd == null)
              {
                num4 = 39;
                continue;
              }
              goto case 54;
            case 27:
              flag2 = HasPropertySelector((Func<IEnumerable<EntityMetadata>>) (() => MetadataLoader.GetChildClasses((ClassMetadata) valueMd).OfType<EntityMetadata>()));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 40 : 0;
              continue;
            case 28:
label_97:
              obj = (object) serializableDictionary1;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 23 : 19;
              continue;
            case 29:
              SerializableDictionary<string, object> serializableDictionary2 = new SerializableDictionary<string, object>();
              serializableDictionary2.Add((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(1304605005 ^ 1304676127), (object) reference);
              obj = (object) serializableDictionary2;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 45 : 48;
              continue;
            case 30:
              try
              {
label_38:
                if (EntityDescriptor.P67muCod8ED2Am6II7gA((object) enumerator))
                  goto label_40;
                else
                  goto label_39;
label_36:
                KeyValuePair<string, object> current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      serializableDictionary1.Add(current.Key, current.Value);
                      num6 = 3;
                      continue;
                    case 2:
                      goto label_90;
                    case 3:
                      goto label_38;
                    default:
                      goto label_40;
                  }
                }
label_39:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 2;
                goto label_36;
label_40:
                current = enumerator.Current;
                num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                {
                  num6 = 1;
                  goto label_36;
                }
                else
                  goto label_36;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_47;
                      default:
                        enumerator.Dispose();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_47:;
              }
            case 32:
              serializableDictionary1.Add(EntityDescriptor.IdPropertyName, EntityDescriptor.iLDYtuodVU0ZBvNWNvdT((object) entity));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 14 : 25;
              continue;
            case 33:
              if (!EntityDescriptor.S36he6odSjVF50kbYj5Y((object) entity))
              {
                num4 = 9;
                continue;
              }
              goto case 4;
            case 34:
              goto label_16;
            case 35:
            case 46:
            case 58:
              if (referenceResolver != null & flag1)
              {
                num5 = 64;
                break;
              }
              goto case 32;
            case 36:
              goto label_101;
            case 37:
              goto label_111;
            case 38:
              flag2 = HasPropertySelector((Func<IEnumerable<EntityMetadata>>) (() => MetadataLoader.GetBaseClasses((ClassMetadata) valueMd).OfType<EntityMetadata>()));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 50 : 11;
              continue;
            case 40:
              if (flag2)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 5 : 11;
                continue;
              }
              goto case 35;
            case 41:
            case 50:
              if (!flag2)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 10 : 27;
                continue;
              }
              goto case 40;
            case 42:
              serializableDictionary1.Add((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(1461825605 - 1531863589 ^ -70108324), (object) entity.ToString());
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 41 : 45;
              continue;
            case 44:
              if (propertyMetadata != null)
              {
                num4 = 60;
                continue;
              }
              goto case 9;
            case 45:
              serializableDictionary1.Add((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(323422137 << 2 ^ 1293708580), (object) entity.ToString());
              num5 = 12;
              break;
            case 47:
label_90:
              obj = (object) serializableDictionary1;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 62 : 50;
              continue;
            case 49:
              if (EntityDescriptor.vnytVFodQ7LhRKFIhpv4((object) settings1) != EntitySerializationMode.Default)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
                continue;
              }
              goto case 13;
            case 51:
              if (valueMd == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 35 : 27;
                continue;
              }
              goto case 63;
            case 52:
              entity = value as IEntity;
              num4 = 67;
              continue;
            case 53:
            case 55:
              serializableDictionary1[(string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(1033719030 - 2012070891 ^ -978387115)] = (object) reference;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 32 : 12;
              continue;
            case 54:
              if (settings1 != null)
              {
                num4 = 17;
                continue;
              }
              goto case 4;
            case 57:
              if (settings1 == null)
              {
                num4 = 46;
                continue;
              }
              goto case 10;
            case 60:
              serializableDictionary1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199952799), (object) entity.GetPropertyValue<Guid>(EntityDescriptor.txZuxZodRdw61Gr5LRxu((object) propertyMetadata)));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 19 : 19;
              continue;
            case 61:
              obj = base.SerializeSimple(value, valueType, settings1);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 18 : 56;
              continue;
            case 63:
              flag2 = HasPropertySelector((Func<IEnumerable<EntityMetadata>>) (() => (IEnumerable<EntityMetadata>) new EntityMetadata[1]
              {
                valueMd
              }));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 22 : 10;
              continue;
            case 64:
              if (!referenceResolver.TryGetReference((object) entity, (IMetadata) valueMd, out reference))
              {
                num4 = 53;
                continue;
              }
              goto case 29;
            case 65:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
              continue;
            case 67:
              serializableDictionary1 = new SerializableDictionary<string, object>();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 3 : 21;
              continue;
            case 68:
              try
              {
label_81:
                if (EntityDescriptor.P67muCod8ED2Am6II7gA((object) enumerator))
                  goto label_79;
                else
                  goto label_82;
label_78:
                KeyValuePair<string, object> current;
                int num8;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_81;
                    case 2:
                      goto label_79;
                    case 3:
                      goto label_97;
                    default:
                      serializableDictionary1.Add(current.Key, current.Value);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                      continue;
                  }
                }
label_79:
                current = enumerator.Current;
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                {
                  num8 = 0;
                  goto label_78;
                }
                else
                  goto label_78;
label_82:
                num8 = 3;
                goto label_78;
              }
              finally
              {
                int num9;
                if (enumerator == null)
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                else
                  goto label_87;
label_86:
                switch (num9)
                {
                  case 2:
                    break;
                  default:
                }
label_87:
                EntityDescriptor.aDCIFgodZSG33d1GslqU((object) enumerator);
                num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                {
                  num9 = 0;
                  goto label_86;
                }
                else
                  goto label_86;
              }
            default:
              valueMd = MetadataLoader.LoadMetadata(EntityDescriptor.Wm3Tf3odfFGjAkxDNPSg(value).GetType()) as EntityMetadata;
              num4 = 57;
              continue;
          }
          num4 = num5;
        }
label_111:
        IDictionary<string, object> dictionary = (IDictionary<string, object>) null;
        goto label_112;
label_16:
        if (!valueType.IsClass)
        {
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
          goto label_11;
        }
        else
          goto label_101;
label_100:
        dictionary = ((WebData) EntityDescriptor.YbpqDmodKcKOQ4JSqiPk(value)).ToDictionary();
        goto label_112;
label_101:
        if (value == null)
        {
          num4 = 37;
          goto label_11;
        }
        else
          goto label_100;
label_112:
        obj = (object) dictionary;
        num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        {
          num4 = 24;
          goto label_11;
        }
        else
          goto label_11;
      }
      finally
      {
        int num10;
        if (disposable == null)
          num10 = 2;
        else
          goto label_117;
label_116:
        switch (num10)
        {
          case 1:
            break;
          default:
        }
label_117:
        EntityDescriptor.aDCIFgodZSG33d1GslqU((object) disposable);
        num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        {
          num10 = 0;
          goto label_116;
        }
        else
          goto label_116;
      }
label_120:
      throw new ArgumentNullException((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-477139494 ^ -477240218));

      bool HasPropertySelector(Func<IEnumerable<EntityMetadata>> metadataList)
      {
        foreach (EntityMetadata entityMetadata in metadataList())
        {
          if (settings1.TypePropertySelector.ContainsKey(entityMetadata.Uid) || settings1.TypePropertySelector.ContainsKey(entityMetadata.ImplementationUid))
            return true;
        }
        return false;
      }
    }

    /// <summary>
    /// Восстановить значение свойства из сериализуемых значений
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="values">Словарь сериализуемых значений</param>
    public override void Deserialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867217237));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132930669));
      obj = obj.CastAsRealType();
      PropertyInfo propInfo = obj.GetProperty(metadata, propertyMetadata);
      object obj1;
      if (propInfo == (PropertyInfo) null || !propInfo.CanWrite || !values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      using (ReferenceResolverSerializer.CreateResolver(true))
      {
        object serializerMarker = new object();
        EntityJsonSerializer.AddSerializerMarker(serializerMarker);
        switch (((EntitySettings) propertyMetadata.Settings).RelationType)
        {
          case RelationType.OneToOne:
            IDictionary<string, object> dictionary1 = obj1 as IDictionary<string, object>;
            Type entityType1 = this.GetEntityType(dictionary1, propertyMetadata);
            object obj2 = this.TryDeserializeEntityId(dictionary1, entityType1);
            object obj3 = !(propInfo.GetValue(obj, (object[]) null) is IEntity entity1) || obj2 == null || !entity1.GetId().Equals(obj2) ? this.DeserializeSimple((object) dictionary1, entityType1) : this.DeserializeSimple((object) dictionary1, entityType1, entity1);
            Func<object> func;
            if ((func = obj3 as Func<object>) != null)
            {
              EntityJsonSerializer.AddAction((System.Action) (() =>
              {
                int num = 2;
                object obj4;
                while (true)
                {
                  switch (num)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      EntityDescriptor.\u003C\u003Ec__DisplayClass19_1.rQCJldCiIhkhXjEDM9I6((object) propInfo, obj, obj4, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (object) null, (object) null, (object) null);
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      obj4 = func();
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                      continue;
                    default:
                      goto label_5;
                  }
                }
label_2:
                return;
label_5:;
              }));
              break;
            }
            if (obj3 != null || obj2 == null)
            {
              propInfo.SetValue(obj, obj3, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, (object[]) null, (CultureInfo) null);
              break;
            }
            break;
          case RelationType.OneToMany:
          case RelationType.ManyToMany:
          case RelationType.ManyToManyInverse:
            IEnumerable enumerable1 = (IEnumerable) propInfo.GetValue(obj, (object[]) null);
            IUntypedCollectionProxy untypedISet = (IUntypedCollectionProxy) null;
            if (enumerable1 == null)
            {
              Type propertyType = propInfo.PropertyType;
              Type typeToCreate = (Type) null;
              if (propertyType.IsGenericType)
              {
                Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
                if (genericTypeDefinition == typeof (IDictionary<,>))
                {
                  typeToCreate = typeof (Dictionary<,>).MakeGenericType(propertyType.GetGenericArguments());
                  enumerable1 = (IEnumerable) Activator.CreateInstance(typeToCreate);
                  untypedISet = (IUntypedCollectionProxy) enumerable1.AsUntypedIDictionary();
                }
                else if (genericTypeDefinition == typeof (ICollection<>) || genericTypeDefinition == typeof (IList<>))
                {
                  typeToCreate = typeof (List<>).MakeGenericType(propertyType.GetGenericArguments());
                  enumerable1 = (IEnumerable) Activator.CreateInstance(typeToCreate);
                  untypedISet = (IUntypedCollectionProxy) enumerable1.AsUntypedICollection();
                }
              }
              else if (propertyType.IsArray && obj1 is IEnumerable source)
              {
                object[] arrayOrNull = source.CastToArrayOrNull<object>();
                if (arrayOrNull == null)
                  return;
                typeToCreate = propertyType.GetElementType();
                if (typeToCreate == (Type) null)
                  return;
                IList newArray = (IList) Array.CreateInstance(typeToCreate, arrayOrNull.Length);
                ((IEnumerable<object>) arrayOrNull).ForEach<object>((Action<object, int>) ((item, index) =>
                {
                  int num1 = 4;
                  Func<object> func1;
                  object obj6;
                  Func<object> function;
                  int index1;
                  // ISSUE: variable of a compiler-generated type
                  EntityDescriptor.\u003C\u003Ec__DisplayClass19_3 cDisplayClass193;
                  while (true)
                  {
                    switch (num1)
                    {
                      case 0:
                        goto label_9;
                      case 1:
                        goto label_2;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        EntityDescriptor.\u003C\u003Ec__DisplayClass19_3.ixm86TCiTDDYNJndJFAm((object) (System.Action) (() =>
                        {
                          int num2 = 1;
                          object obj7;
                          while (true)
                          {
                            switch (num2)
                            {
                              case 1:
                                obj7 = function();
                                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                                continue;
                              case 2:
                                goto label_2;
                              default:
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                EntityDescriptor.\u003C\u003Ec__DisplayClass19_4.fbkyfvCiPaEKbibYfVSA((object) cDisplayClass193.newArray, index1, obj7);
                                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
                                continue;
                            }
                          }
label_2:;
                        }));
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                        continue;
                      case 3:
                        cDisplayClass193 = this;
                        num1 = 7;
                        continue;
                      case 4:
                        num1 = 3;
                        continue;
                      case 5:
                        function = func1 = obj6 as Func<object>;
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 5 : 8;
                        continue;
                      case 6:
                        obj6 = this.DeserializeSimple(item, typeToCreate);
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 5 : 2;
                        continue;
                      case 7:
                        index1 = index;
                        num1 = 6;
                        continue;
                      case 8:
                        if (func1 != null)
                        {
                          num1 = 2;
                          continue;
                        }
                        // ISSUE: reference to a compiler-generated method
                        EntityDescriptor.\u003C\u003Ec__DisplayClass19_3.S5A0M9CikWKaG9YUNARZ((object) newArray, index1, obj6);
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                        continue;
                      default:
                        goto label_13;
                    }
                  }
label_9:
                  return;
label_2:
                  return;
label_13:;
                }));
                enumerable1 = (IEnumerable) newArray;
                untypedISet = (IUntypedCollectionProxy) enumerable1.AsUntypedICollection();
              }
              if (typeToCreate == (Type) null)
                return;
              if (enumerable1 != null)
                propInfo.SetValue(obj, (object) enumerable1, (object[]) null);
            }
            if (untypedISet == null)
              untypedISet = (IUntypedCollectionProxy) enumerable1.AsUntypedISet();
            if (untypedISet == null)
              return;
            Dictionary<Guid, IEntity> dictionary2 = new Dictionary<Guid, IEntity>();
            foreach (IEntity entity2 in enumerable1)
              dictionary2[this.GetEntityGuid(entity2)] = entity2;
            List<Guid> guidList = new List<Guid>();
            if (obj1 is IEnumerable enumerable2)
            {
              foreach (object obj8 in enumerable2)
              {
                IDictionary<string, object> objects = obj8 as IDictionary<string, object>;
                Type entityType2 = this.GetEntityType(objects, propertyMetadata);
                object obj9 = this.DeserializeSimple((object) objects, entityType2);
                Func<object> function;
                if ((function = obj9 as Func<object>) != null)
                {
                  EntityJsonSerializer.AddAction((System.Action) (() =>
                  {
                    int num = 2;
                    IEntity entity3;
                    while (true)
                    {
                      switch (num)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          EntityDescriptor.\u003C\u003Ec__DisplayClass19_5.euyji6CiahWX4a9J1Bhy((object) untypedISet, (object) entity3);
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                          continue;
                        case 2:
                          entity3 = (IEntity) function();
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                          continue;
                        default:
                          goto label_5;
                      }
                    }
label_2:
                    return;
label_5:;
                  }));
                }
                else
                {
                  IEntity entity4 = (IEntity) obj9;
                  if (entity4 != null)
                  {
                    Guid entityGuid = this.GetEntityGuid(entity4, entityType2);
                    if (!dictionary2.ContainsKey(entityGuid))
                      untypedISet.Add((object) entity4);
                    guidList.Add(entityGuid);
                  }
                }
              }
            }
            using (Dictionary<Guid, IEntity>.Enumerator enumerator = dictionary2.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                KeyValuePair<Guid, IEntity> current = enumerator.Current;
                if (!guidList.Contains(current.Key))
                  untypedISet.Remove((object) current.Value);
              }
              break;
            }
        }
        EntityJsonSerializer.InvokeActions(serializerMarker);
      }
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 1;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            disposable = (IDisposable) EntityDescriptor.evm0aOodGIEu960xfRNc(true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_2:
      object obj;
      try
      {
        obj = this.DeserializeSimple(value, deserializeToType, (IEntity) null);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (disposable == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
        else
          goto label_9;
label_8:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_9:
        EntityDescriptor.aDCIFgodZSG33d1GslqU((object) disposable);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
        {
          num3 = 1;
          goto label_8;
        }
        else
          goto label_8;
      }
label_13:
      return obj;
    }

    protected virtual object DeserializeSimple(
      object value,
      Type deserializeToType,
      IEntity entity)
    {
      int num1 = 2;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            if (deserializeToType == (Type) null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 1;
              continue;
            }
            disposable = (IDisposable) EntityDescriptor.evm0aOodGIEu960xfRNc(true);
            num1 = 3;
            continue;
          case 3:
            goto label_7;
          default:
            goto label_4;
        }
      }
label_4:
      object obj1;
      return obj1;
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138940804));
label_7:
      try
      {
        int num2;
        // ISSUE: type reference
        if (EntityDescriptor.Rdtb3fodEj9WldhCsD2n(__typeref (IEntity)).IsAssignableFrom(deserializeToType))
        {
          num2 = 2;
          goto label_10;
        }
        else
          goto label_23;
label_9:
        int num3;
        num2 = num3;
label_10:
        while (true)
        {
          object obj2;
          IDictionary<string, object> serObj;
          bool orDefault;
          object obj3;
          object obj4;
          switch (num2)
          {
            case 1:
            case 10:
            case 13:
            case 15:
              goto label_4;
            case 2:
              serObj = value as IDictionary<string, object>;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            case 3:
              EntityDescriptor.SDyfk4odXyjnwAinNhcF(obj3);
              num2 = 17;
              continue;
            case 4:
              EntityDescriptor.ERjICJodTtkKV2HioDor(obj3);
              num2 = 11;
              continue;
            case 5:
              if (obj2 is Func<object> func)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 12 : 5;
                continue;
              }
              goto case 4;
            case 6:
              obj3 = new object();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 3;
              continue;
            case 7:
              if (entity == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 6 : 14;
                continue;
              }
              goto case 8;
            case 8:
              obj4 = new EntityJsonSerializer().ConvertFromSerializable((object) entity, serObj, !orDefault);
              break;
            case 9:
              goto label_23;
            case 11:
              obj1 = (object) (IEntity) obj2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
              continue;
            case 12:
              obj1 = (object) func;
              num2 = 10;
              continue;
            case 14:
              obj4 = new EntityJsonSerializer().ConvertFromSerializable(serObj, deserializeToType, !orDefault);
              break;
            case 16:
              obj1 = (object) null;
              num2 = 15;
              continue;
            case 17:
              orDefault = ContextVars.GetOrDefault<bool>((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-53329496 >> 4 ^ -3163548));
              num2 = 7;
              continue;
            default:
              if (serObj != null)
                goto case 6;
              else
                goto label_19;
          }
          obj2 = obj4;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 5;
        }
label_19:
        num3 = 16;
        goto label_9;
label_23:
        obj1 = base.DeserializeSimple(value, deserializeToType);
        num3 = 13;
        goto label_9;
      }
      finally
      {
        int num4;
        if (disposable == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
        else
          goto label_32;
label_31:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_32:
        disposable.Dispose();
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        {
          num4 = 0;
          goto label_31;
        }
        else
          goto label_31;
      }
    }

    /// <summary>Скопировать значения свойства</summary>
    /// <param name="obj">Объект из которого нужно копировать</param>
    /// <param name="target">Объект, в который идет копирование</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    public override void Copy(
      object obj,
      object target,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata)
    {
      int num1 = 9;
      IEnumerator enumerator;
      UntypedISetProxy untypedIsetProxy;
      while (true)
      {
        int num2 = num1;
        PropertyInfo propertyCached;
        IEnumerable enumerable1;
        RelationType relationType;
        IEnumerable enumerable2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_68;
            case 1:
              if (target != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 14 : 3;
                continue;
              }
              goto label_46;
            case 2:
              goto label_59;
            case 3:
              enumerable1 = (IEnumerable) EntityDescriptor.QfYxApodnqp01XXlcgsl((object) propertyCached, obj, (object) null);
              num2 = 7;
              continue;
            case 4:
              enumerator = (IEnumerator) EntityDescriptor.LcNMByod1ed7Uv2UsvR8((object) enumerable1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 18 : 9;
              continue;
            case 5:
              switch (relationType)
              {
                case RelationType.OneToMany:
                case RelationType.ManyToMany:
                case RelationType.ManyToManyInverse:
                  num2 = 22;
                  continue;
                default:
                  goto label_3;
              }
            case 6:
              if (untypedIsetProxy == null)
              {
                num2 = 28;
                continue;
              }
              EntityDescriptor.aMI7P7odP1wlhTfoTycJ((object) untypedIsetProxy);
              num2 = 4;
              continue;
            case 7:
              if (enumerable1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
                continue;
              }
              propertyCached = target.GetType().GetPropertyCached((string) EntityDescriptor.avPtyiodk81ybncCa6L9((object) propertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 25 : 29;
              continue;
            case 8:
              goto label_35;
            case 9:
              if (obj == null)
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 10:
              if (EntityDescriptor.rglNjuod28gkaiITv2T2((object) propertyCached))
              {
                enumerable2 = (IEnumerable) propertyCached.GetValue(target, (object[]) null);
                num2 = 16;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 9 : 24;
              continue;
            case 11:
              goto label_55;
            case 12:
              goto label_70;
            case 13:
              goto label_40;
            case 14:
              if (metadata != null)
              {
                if (propertyMetadata == null)
                {
                  num2 = 11;
                  continue;
                }
                relationType = EntityDescriptor.nLFjy2o99PPyGug0YhUK((object) (EntitySettings) EntityDescriptor.ANZRtso9d3igFQKtT5ZT((object) propertyMetadata));
                num2 = 15;
                continue;
              }
              goto label_45;
            case 15:
              if (relationType != RelationType.OneToOne)
              {
                num2 = 5;
                continue;
              }
              base.Copy(obj, target, metadata, propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 12;
              continue;
            case 16:
              if (enumerable2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 10 : 17;
                continue;
              }
              goto label_13;
            case 17:
              untypedIsetProxy = (UntypedISetProxy) EntityDescriptor.rkJHx0ode8qwKGvBtUVt((object) enumerable2);
              num2 = 6;
              continue;
            case 18:
              goto label_5;
            case 19:
              if (propertyCached == (PropertyInfo) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 23 : 25;
                continue;
              }
              goto case 20;
            case 20:
              if (propertyCached.CanRead)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 3;
                continue;
              }
              goto label_7;
            case 21:
              goto label_57;
            case 22:
              propertyCached = obj.GetType().GetPropertyCached((string) EntityDescriptor.avPtyiodk81ybncCa6L9((object) propertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 19;
              continue;
            case 23:
              goto label_37;
            case 24:
              goto label_31;
            case 25:
              goto label_66;
            case 26:
              goto label_43;
            case 27:
              goto label_4;
            case 28:
              goto label_53;
            case 29:
              if (!EntityDescriptor.HaibTgodOeNPMAISM2rB((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 6 : 10;
                continue;
              }
              goto label_65;
            default:
              goto label_72;
          }
        }
label_45:
        num1 = 23;
      }
label_68:
      return;
label_72:
      return;
label_53:
      return;
label_4:
      return;
label_43:
      return;
label_66:
      return;
label_57:
      return;
label_31:
      return;
label_40:
      return;
label_70:
      return;
label_35:
      return;
label_59:
      return;
label_5:
      try
      {
label_8:
        if (EntityDescriptor.P67muCod8ED2Am6II7gA((object) enumerator))
          goto label_10;
        else
          goto label_9;
label_6:
        object o;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_30;
            case 1:
              untypedIsetProxy.Add(o);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 3;
              continue;
            case 2:
              goto label_10;
            case 3:
              goto label_8;
            default:
              goto label_17;
          }
        }
label_30:
        return;
label_17:
        return;
label_9:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
        goto label_6;
label_10:
        o = EntityDescriptor.gI2Ae8odNiv0WIfWdnNc((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        {
          num3 = 1;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (disposable != null)
              {
                num4 = 2;
                continue;
              }
              goto label_21;
            case 2:
              EntityDescriptor.aDCIFgodZSG33d1GslqU((object) disposable);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            default:
              goto label_21;
          }
        }
label_21:;
      }
label_65:
      return;
label_3:
      return;
label_37:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979467392));
label_46:
      return;
label_7:
      return;
label_55:
      throw new ArgumentNullException((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-2107978722 ^ -2107996852));
label_13:;
    }

    /// <summary>Применить в критерий NHibernate условия</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="value">Значение фильтра</param>
    /// <param name="alias">Алиас для выборки</param>
    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        IEnumerable source1;
        object[] array;
        DetachedCriteria detachedCriteria;
        EntitySettings settings;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_16;
            case 1:
              goto label_11;
            case 2:
              IEnumerable<IEntity> source2 = source1.OfType<IEntity>();
              // ISSUE: reference to a compiler-generated field
              Func<IEntity, object> func = EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__23_0;
              Func<IEntity, object> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__23_0 = selector = (Func<IEntity, object>) (e => EntityDescriptor.\u003C\u003Ec.X7WO1bCSuMjcQtoBBow5((object) e));
              }
              else
                goto label_4;
label_27:
              array = source2.Select<IEntity, object>(selector).ToArray<object>();
              num2 = 3;
              continue;
label_4:
              selector = func;
              goto label_27;
            case 3:
              if (array.Length != 0)
              {
                settings = (EntitySettings) EntityDescriptor.ANZRtso9d3igFQKtT5ZT((object) propertyMetadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 9 : 1;
                continue;
              }
              num2 = 15;
              continue;
            case 4:
              goto label_25;
            case 5:
            case 10:
              criteria.Add((ICriterion) EntityDescriptor.sNNvybodAPGp1y3Bs7Sl(EntityDescriptor.mfOY6IodHo8AVIitAvem(EntityDescriptor.rVQVmKod64m1Npbi3JYr((object) criteria), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477236354)), (object) detachedCriteria));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            case 6:
              num2 = 2;
              continue;
            case 7:
              base.ApplyFilterValue(criteria, metadata, propertyMetadata, value, alias);
              num2 = 4;
              continue;
            case 8:
              goto label_10;
            case 9:
              if (EntityDescriptor.nLFjy2o99PPyGug0YhUK((object) settings) == RelationType.OneToMany)
              {
                num2 = 8;
                continue;
              }
              goto case 12;
            case 11:
              if (source1 != null)
                goto case 6;
              else
                goto label_7;
            case 12:
              detachedCriteria = (DetachedCriteria) EntityDescriptor.zi4ISYodtXiaYryQqnxQ(EntityDescriptor.MdyUGhod49MsjBqIkeIP(EntityDescriptor.sGY6tsodw300ZTV9hvar((object) DetachedCriteria.For(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EntityDescriptor.txZuxZodRdw61Gr5LRxu((object) metadata))), EntityDescriptor.avPtyiodk81ybncCa6L9((object) propertyMetadata), JoinType.InnerJoin), (object) Restrictions.In((IProjection) EntityDescriptor.QHVvrVodpr5m3DF707Tl(), array)), EntityDescriptor.QHVvrVodpr5m3DF707Tl());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 5 : 3;
              continue;
            case 13:
              source1 = value as IEnumerable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 11 : 7;
              continue;
            case 14:
              if (value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 13;
                continue;
              }
              goto label_19;
            case 15:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_7:
        num1 = 7;
        continue;
label_10:
        Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EntityDescriptor.aXsQDqo9LAocDrZMPFve((object) propertyMetadata));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata1 = (InterfaceActivator.LoadMetadata(typeByUid) as ClassMetadata).Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EntityDescriptor.\u003C\u003Ec__DisplayClass23_0.rQJSRuCi67WO7p5f5qv0((object) p) == EntityDescriptor.\u003C\u003Ec__DisplayClass23_0.pxrfvJCiHNSPdOpxG3b9((object) settings)));
        detachedCriteria = (DetachedCriteria) EntityDescriptor.zi4ISYodtXiaYryQqnxQ((object) ((DetachedCriteria) EntityDescriptor.XlnLe7od3KiRmnv2iHlF(typeByUid)).Add((ICriterion) EntityDescriptor.BbahUaodaiGc8VT1bQb8(EntityDescriptor.QHVvrVodpr5m3DF707Tl(), (object) array)), EntityDescriptor.YBrpdcodDtksPVUD4Dmv(EntityDescriptor.avPtyiodk81ybncCa6L9((object) propertyMetadata1)));
        num1 = 10;
      }
label_16:
      return;
label_11:
      return;
label_25:
      return;
label_3:
      return;
label_5:
      return;
label_19:;
    }

    /// <summary>Форматировать значение</summary>
    /// <param name="value">Значение</param>
    /// <param name="settings">Настройки свойства</param>
    /// <returns>Сформатированное значение</returns>
    public override string FormatValue(object value, TypeSettings settings)
    {
      int num = 3;
      IEnumerable source1;
      while (true)
      {
        EntitySettings entitySettings;
        switch (num)
        {
          case 1:
            if (source1 == null)
            {
              num = 4;
              continue;
            }
            goto case 8;
          case 2:
            entitySettings = settings as EntitySettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
            continue;
          case 3:
            source1 = value as IEnumerable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 2;
            continue;
          case 4:
          case 5:
          case 6:
            goto label_10;
          case 7:
            goto label_11;
          case 8:
            if (entitySettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 5 : 1;
              continue;
            }
            break;
        }
        if (EntityDescriptor.nLFjy2o99PPyGug0YhUK((object) entitySettings) != RelationType.OneToOne)
          num = 7;
        else
          break;
      }
label_10:
      return base.FormatValue(value, settings);
label_11:
      object obj = EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-53329496 >> 4 ^ -3332072);
      IEnumerable<object> source2 = source1.Cast<object>();
      // ISSUE: reference to a compiler-generated field
      Func<object, string> func = EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__24_0;
      Func<object, string> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        EntityDescriptor.\u003C\u003Ec.\u003C\u003E9__24_0 = selector = (Func<object, string>) (o => o.ToString());
      }
      else
        goto label_14;
label_13:
      string[] array = source2.Select<object, string>(selector).ToArray<string>();
      return (string) EntityDescriptor.n0ZZ30od7K3RM5MX63AZ(obj, (object) array);
label_14:
      selector = func;
      goto label_13;
    }

    /// <summary>
    /// Создать настройки для свойства фильтра, построенного по свойству сущности (должен быть определен у дескриптора типа свойства фильтра)
    /// </summary>
    /// <param name="propertyMetadata">Свойство сущности</param>
    /// <returns></returns>
    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 5;
      EntitySettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            forFilterProperty = (EntitySettings) ClassSerializationHelper.CloneObjectByXml<TypeSettings>((TypeSettings) EntityDescriptor.ANZRtso9d3igFQKtT5ZT((object) propertyMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 3;
            continue;
          case 3:
            if (EntityDescriptor.unn6gpodx412EG27lmTf((object) forFilterProperty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 6;
              continue;
            }
            goto label_9;
          case 4:
            if (propertyMetadata.Settings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 2;
              continue;
            }
            goto label_5;
          case 5:
            if (propertyMetadata != null)
            {
              num = 4;
              continue;
            }
            goto label_5;
          case 6:
            EntityDescriptor.Do51Wjo9z2On9XKYiDRF((object) forFilterProperty, RelationType.ManyToMany);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (TypeSettings) null;
label_9:
      return (TypeSettings) forFilterProperty;
    }

    public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
    {
      int num = 12;
      IEntity entity;
      // ISSUE: variable of a compiler-generated type
      EntityDescriptor.\u003C\u003Ec__DisplayClass26_1 cDisplayClass261;
      Type typeByUid;
      // ISSUE: variable of a compiler-generated type
      EntityDescriptor.\u003C\u003Ec__DisplayClass26_0 cDisplayClass260;
      EntityInfo entityInfo;
      Action<EntityInfo> action;
      RelationType relationType;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_26;
          case 2:
            goto label_32;
          case 3:
            ((EntityListInfo) value).Items.ForEach(action);
            num = 22;
            continue;
          case 4:
            if (entityInfo.Uid != Guid.Empty)
            {
              num = 5;
              continue;
            }
            goto label_6;
          case 5:
            // ISSUE: reference to a compiler-generated field
            entity = (IEntity) EntityDescriptor.ExY5anodml90kLgvRR9t(EntityDescriptor.aXsQDqo9LAocDrZMPFve((object) cDisplayClass260.propertyMetadata), EntityDescriptor.GaO1Tood0p82QSfncg0m((object) entityInfo));
            num = 10;
            continue;
          case 6:
            if (!(value is IEntity))
            {
              num = 24;
              continue;
            }
            goto label_32;
          case 7:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass261.CS\u0024\u003C\u003E8__locals1 = cDisplayClass260;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          case 8:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass261 = new EntityDescriptor.\u003C\u003Ec__DisplayClass26_1();
            num = 7;
            continue;
          case 9:
            if (value is EntityInfo)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 13 : 5;
              continue;
            }
            goto case 3;
          case 10:
            if (entity == null)
            {
              num = 25;
              continue;
            }
            goto label_5;
          case 11:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass260.propertyMetadata = propertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 23 : 11;
            continue;
          case 12:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass260 = new EntityDescriptor.\u003C\u003Ec__DisplayClass26_0();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 7 : 11;
            continue;
          case 13:
            action((EntityInfo) value);
            num = 20;
            continue;
          case 14:
            goto label_13;
          case 15:
            if (relationType != RelationType.OneToOne)
            {
              if (!(value is EntityInfo))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 10 : 16;
                continue;
              }
              goto case 8;
            }
            else
            {
              num = 6;
              continue;
            }
          case 16:
            if (!(value is EntityListInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
              continue;
            }
            goto case 8;
          case 17:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass261.result = (ISet) Activator.CreateInstance(typeof (HashedSet<>).MakeGenericType(typeByUid));
            num = 21;
            continue;
          case 18:
            if (entityInfo != null)
            {
              num = 4;
              continue;
            }
            goto label_27;
          case 19:
            goto label_5;
          case 20:
          case 22:
            goto label_25;
          case 21:
            // ISSUE: reference to a compiler-generated method
            action = new Action<EntityInfo>(cDisplayClass261.\u003CConvertFrom\u003Eb__0);
            num = 9;
            continue;
          case 23:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass260.propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 3 : 14;
              continue;
            }
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 11 : 26;
              continue;
            }
            // ISSUE: reference to a compiler-generated field
            relationType = ((EntitySettings) EntityDescriptor.ANZRtso9d3igFQKtT5ZT((object) cDisplayClass260.propertyMetadata)).RelationType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 15 : 13;
            continue;
          case 24:
            entityInfo = value as EntityInfo;
            num = 18;
            continue;
          case 25:
            goto label_6;
          case 26:
            goto label_30;
          default:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EntityDescriptor.aXsQDqo9LAocDrZMPFve((object) cDisplayClass261.CS\u0024\u003C\u003E8__locals1.propertyMetadata));
            num = 17;
            continue;
        }
      }
label_5:
      return (object) entity;
label_6:
      // ISSUE: reference to a compiler-generated field
      return (object) ModelHelper.GetEntity(EntityDescriptor.aXsQDqo9LAocDrZMPFve((object) cDisplayClass260.propertyMetadata), EntityDescriptor.wlHig4odytsPSNNtXWV1((object) entityInfo));
label_13:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306468342));
label_25:
      // ISSUE: reference to a compiler-generated field
      return (object) cDisplayClass261.result;
label_26:
      return value;
label_27:
      return (object) null;
label_30:
      return (object) null;
label_32:
      return value;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    /// <summary>
    /// Сравнить значения. Если они равны - возвращается True.
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    /// <returns></returns>
    public virtual bool IsValuesEquals(object v1, object v2)
    {
      int num1 = 13;
      // ISSUE: variable of a compiler-generated type
      EntityDescriptor.\u003C\u003Ec__DisplayClass28_1 cDisplayClass281;
      // ISSUE: variable of a compiler-generated type
      EntityDescriptor.\u003C\u003Ec__DisplayClass28_0 cDisplayClass280;
      while (true)
      {
        int num2 = num1;
        IEnumerable source1;
        while (true)
        {
          IEnumerable source2;
          switch (num2)
          {
            case 1:
              if (!(v2 is IEntity))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 6;
                continue;
              }
              goto label_23;
            case 2:
            case 6:
              source2 = v1 as IEnumerable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 8;
              continue;
            case 3:
              goto label_3;
            case 4:
              if (!(v1 is IEntity))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
                continue;
              }
              goto case 1;
            case 5:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass281 = new EntityDescriptor.\u003C\u003Ec__DisplayClass28_1();
              num2 = 16;
              continue;
            case 7:
              goto label_15;
            case 8:
              source1 = v2 as IEnumerable;
              num2 = 22;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass281.list2 = source1.Cast<object>().ToList<object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            case 10:
            case 17:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (EntityDescriptor.TqQHEDodMOBxpMZQcr05((object) cDisplayClass281.list1) != cDisplayClass281.list2.Count)
              {
                num2 = 7;
                continue;
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              if (cDisplayClass281.list1.All<object>(new Func<object, bool>(cDisplayClass281.\u003CIsValuesEquals\u003Eb__1)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 19 : 21;
                continue;
              }
              goto label_21;
            case 11:
              // ISSUE: reference to a compiler-generated field
              if (EntityDescriptor.TqQHEDodMOBxpMZQcr05((object) cDisplayClass281.list2) != 0)
              {
                num2 = 10;
                continue;
              }
              goto label_5;
            case 12:
              if (v1 == null)
              {
                num2 = 23;
                continue;
              }
              break;
            case 13:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass280 = new EntityDescriptor.\u003C\u003Ec__DisplayClass28_0();
              num2 = 12;
              continue;
            case 14:
              goto label_5;
            case 15:
              goto label_36;
            case 16:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass281.CS\u0024\u003C\u003E8__locals1 = cDisplayClass280;
              num2 = 18;
              continue;
            case 18:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass281.list1 = source2.Cast<object>().ToList<object>();
              num2 = 9;
              continue;
            case 19:
              goto label_22;
            case 20:
              goto label_23;
            case 21:
              goto label_20;
            case 22:
              if (source2 == null)
              {
                num2 = 19;
                continue;
              }
              goto label_3;
            case 23:
              if (v2 == null)
              {
                num2 = 15;
                continue;
              }
              break;
            default:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass281.list1.Count != 0)
              {
                num2 = 17;
                continue;
              }
              goto case 11;
          }
          // ISSUE: reference to a compiler-generated field
          cDisplayClass280.CompareValues = (Func<object, object, bool>) ((obj1, obj2) =>
          {
            int num3 = 6;
            IEntity entity1;
            IEntity entity2;
            while (true)
            {
              int num4 = num3;
              while (true)
              {
                switch (num4)
                {
                  case 2:
                    if (entity2.GetType().IsAssignableFrom(entity1.GetType()))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                      continue;
                    }
                    goto label_12;
                  case 3:
                    if (entity1 == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 5 : 7;
                      continue;
                    }
                    goto case 8;
                  case 4:
                    if (entity1.GetType().IsAssignableFrom(entity2.GetType()))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 2;
                  case 5:
                    goto label_4;
                  case 6:
                    entity1 = obj1 as IEntity;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 5;
                    continue;
                  case 7:
                    goto label_12;
                  case 8:
                    if (entity2 != null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 4;
                      continue;
                    }
                    goto label_12;
                  default:
                    goto label_11;
                }
              }
label_4:
              entity2 = obj2 as IEntity;
              num3 = 3;
            }
label_11:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return EntityDescriptor.\u003C\u003Ec.X7WO1bCSuMjcQtoBBow5((object) entity1).Equals(EntityDescriptor.\u003C\u003Ec.X7WO1bCSuMjcQtoBBow5((object) entity2));
label_12:
            return false;
          });
          num2 = 4;
        }
label_3:
        if (source1 != null)
          num1 = 5;
        else
          goto label_22;
      }
label_5:
      return true;
label_15:
      return false;
label_20:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      return cDisplayClass281.list2.All<object>(new Func<object, bool>(cDisplayClass281.\u003CIsValuesEquals\u003Eb__2));
label_21:
      return false;
label_22:
      return false;
label_23:
      // ISSUE: reference to a compiler-generated field
      return cDisplayClass280.CompareValues(v1, v2);
label_36:
      return true;
    }

    /// <summary>
    /// Подготавливает восстановленные данные для последующей десериализации.
    /// В базовой реализации удаляет все поля за исключением поля Id.
    /// </summary>
    /// <param name="data"></param>
    public virtual void PrepareDeserializedData(IDictionary<string, object> data)
    {
      foreach (string key1 in (IEnumerable<string>) data.Keys)
      {
        if (data[key1] is IDictionary<string, object> dictionary1)
        {
          foreach (string key2 in dictionary1.Keys.ToList<string>())
          {
            if (key2 != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138127578))
              dictionary1.Remove(key2);
          }
        }
        if (data[key1] is List<IDictionary<string, object>> dictionaryList)
        {
          foreach (IDictionary<string, object> dictionary2 in dictionaryList)
          {
            foreach (string key3 in dictionary2.Keys.ToList<string>())
            {
              if (key3 != z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870859415))
                dictionary2.Remove(key3);
            }
          }
        }
      }
    }

    /// <summary>Включить добавление проверки CheckSoftDeletable</summary>
    /// <param name="action">Действие</param>
    internal static T RunWithCheckSoftDeletable<T>(Func<T> action)
    {
      bool сheckSoftDeletable = EntityDescriptor.сheckSoftDeletable;
      EntityDescriptor.сheckSoftDeletable = true;
      try
      {
        return action();
      }
      finally
      {
        EntityDescriptor.сheckSoftDeletable = сheckSoftDeletable;
      }
    }

    /// <summary>Получить имя типа данных CLR</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Имя типа</returns>
    protected override string GetTypeName(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num1 = 3;
      ClassMetadata classMetadata1;
      while (true)
      {
        int num2 = num1;
        EntityMetadata entityMetadata1;
        EntityMetadata entityMetadata2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              classMetadata1 = (ClassMetadata) EntityDescriptor.thEU7codlu6EVWL2TTKo((object) this, EntityDescriptor.PaWVJModdiZ9KNOgcbNM((object) entityMetadata2));
              num2 = 10;
              continue;
            case 2:
              entityMetadata2 = classMetadata1 as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 8 : 12;
              continue;
            case 3:
              classMetadata1 = this.GetMetadata(EntityDescriptor.aXsQDqo9LAocDrZMPFve((object) propertyMetadata));
              num2 = 2;
              continue;
            case 4:
              entityMetadata1 = EntityDescriptor.thEU7codlu6EVWL2TTKo((object) this, EntityDescriptor.qjvF9CodrTjn0du9rVMR((object) classMetadata1)) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 1;
              continue;
            case 5:
              if (!EntityDescriptor.bK0CxfodJsUP9Vq1mOLO((object) classMetadata))
              {
                num2 = 9;
                continue;
              }
              goto label_18;
            case 6:
              if (EntityDescriptor.KUmPIYod9O7ROugOeY08((object) entityMetadata2) == EntityMetadataType.InterfaceExtension)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 4;
                continue;
              }
              goto label_18;
            case 7:
              goto label_13;
            case 8:
              if (entityMetadata2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              }
              goto label_18;
            case 9:
              if (EntityDescriptor.KUmPIYod9O7ROugOeY08((object) entityMetadata2) == EntityMetadataType.Interface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
                continue;
              }
              goto case 6;
            case 10:
            case 11:
              goto label_18;
            case 12:
              if (!forFilter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 8 : 3;
                continue;
              }
              goto label_18;
            case 13:
              classMetadata1 = this.GetMetadata(EntityDescriptor.PaWVJModdiZ9KNOgcbNM((object) entityMetadata1));
              num2 = 11;
              continue;
            default:
              if (classMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 5 : 0;
                continue;
              }
              goto label_18;
          }
        }
label_13:
        if (entityMetadata1 != null)
          num1 = 13;
        else
          break;
      }
label_18:
      return classMetadata1.FullTypeName;
    }

    /// <summary>
    /// Получить отображаемое имя типа данных - в соответствии с выбранным типом объекта
    /// </summary>
    /// <param name="subTypeUid">Uid подтипа</param>
    /// <returns>Отображаемое имя типа</returns>
    public override string GetTypeDisplayName(Guid subTypeUid)
    {
      int num = 1;
      ClassMetadata classMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            classMetadata = (ClassMetadata) EntityDescriptor.thEU7codlu6EVWL2TTKo((object) this, subTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) EntityDescriptor.LhL7HCodgYQtXTX3rAIF(EntityDescriptor.sGggSRo9M7FDG9iI3Gii(1113862659 ^ 1113997623), EntityDescriptor.VTfxOto9JfEHSGKRwBi7(EntityDescriptor.f1CIdio9rZ4r8OHxb0k6((object) classMetadata)), (object) EleWise.ELMA.SR.T((string) EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-649342099 - -1150814748 ^ 501302055)));
    }

    /// <summary>
    /// Проверить, является ли тип поддерживаемым типом метаданных.
    /// </summary>
    /// <param name="type">Тип метаданных</param>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>True, если поддерживается</returns>
    protected virtual bool IsSupportedMetadataType(Type type, ClassMetadata classMetadata) => EntityDescriptor.fOg8cKodoLabF4DApiQF(type, typeof (EntityMetadata));

    /// <summary>
    /// Записать в генерируемый тип дополнительные члены для указанного интерфейса
    /// </summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="intfMetadata">Метаданные реализуемого интерфейса</param>
    /// <param name="refIntfMetadata">Метаданные интерфейса свойства</param>
    /// <param name="refImplMetadata">Метаданные типа, реализующего интерфейс свойства</param>
    /// <returns>Список выражений</returns>
    protected virtual IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(
      EntityMetadata entityMetadata,
      PropertyMetadata propertyMetadata,
      EntityMetadata intfMetadata,
      EntityMetadata refIntfMetadata,
      EntityMetadata refImplMetadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new EntityDescriptor.\u003CGetAdditionalTypeMembers\u003Ed__34(-2)
      {
        \u003C\u003E3__propertyMetadata = propertyMetadata,
        \u003C\u003E3__intfMetadata = intfMetadata,
        \u003C\u003E3__refIntfMetadata = refIntfMetadata,
        \u003C\u003E3__refImplMetadata = refImplMetadata
      };
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
      return dictionary != null && dictionary.TryGetValue(EntityDescriptor.IdPropertyName, out idValue) ? ModelHelper.TryConvertEntityId(entityType, idValue) : (object) null;
    }

    /// <summary>
    /// Получить тип сущности из поля с ключом <c>TypeUid</c> или из параметра метаданных <paramref name="propertyMetadata" />
    /// </summary>
    /// <param name="objects">Словарь, который может содержать идентификатор (в ключе TypeUid)</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns></returns>
    protected virtual Type GetEntityType(
      IDictionary<string, object> objects,
      PropertyMetadata propertyMetadata)
    {
      IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      object obj;
      if (objects != null && objects.TryGetValue(EntityDescriptor.TypeUidPropertyName, out obj))
      {
        Guid uid = (Guid) Locator.GetServiceNotNull<GuidDescriptor>().DeserializeSimple(obj, typeof (Guid));
        return serviceNotNull.GetTypeByUid(uid);
      }
      return propertyMetadata != null ? serviceNotNull.GetTypeByUid(propertyMetadata.SubTypeUid) : (Type) null;
    }

    /// <summary>Получить Uid сущности</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="entityType">Тип сущности</param>
    /// <returns><c>Guid.Empty</c> если свойство не найдено, иначе uid сущности</returns>
    private Guid GetEntityGuid(IEntity entity, Type entityType = null)
    {
      int num1 = 1;
      Guid orAdd;
      while (true)
      {
        int num2 = num1;
        Type entityType1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              entityType1 = entity.GetType();
              num2 = 7;
              continue;
            case 4:
            case 7:
              orAdd = EntityDescriptor.entityUidProperties.GetOrAdd(entityType1.GUID, (Func<Guid, Guid>) (guid =>
              {
                int num3 = 1;
                PropertyMetadata uidProperty;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      uidProperty = (MetadataLoader.LoadMetadata(entityType1) as ClassMetadata).GetUidProperty();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      if (uidProperty == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 2;
                        continue;
                      }
                      goto label_3;
                  }
                }
label_2:
                return Guid.Empty;
label_3:
                // ISSUE: reference to a compiler-generated method
                return EntityDescriptor.\u003C\u003Ec__DisplayClass43_0.kyGZkVCRHZZksTO82mCQ((object) uidProperty);
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 6 : 2;
              continue;
            case 5:
              if (entityType1 == (Type) null)
                goto case 3;
              else
                goto label_10;
            case 6:
              if (!(orAdd != Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 2 : 2;
                continue;
              }
              goto label_4;
            default:
              entityType1 = entityType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 5 : 2;
              continue;
          }
        }
label_10:
        num1 = 4;
      }
label_3:
      return Guid.Empty;
label_4:
      return entity.GetPropertyValue<Guid>(orAdd);
    }

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 1;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new EntityPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public EntityDescriptor()
    {
      EntityDescriptor.LvmKccod5r2THlyyIkiw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityDescriptor()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              EntityDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727526920));
              num2 = 5;
              continue;
            case 3:
              EntityDescriptor.LvmKccod5r2THlyyIkiw();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 2;
              continue;
            case 4:
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) EntityDescriptor.vqrgsXodjJMBkbVdtLFI(EntityDescriptor.Rdtb3fodEj9WldhCsD2n(__typeref (IInheritable)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146531661));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            case 5:
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) EntityDescriptor.vqrgsXodjJMBkbVdtLFI(EntityDescriptor.Rdtb3fodEj9WldhCsD2n(__typeref (IEntity<object>)), EntityDescriptor.sGggSRo9M7FDG9iI3Gii(-787452571 ^ -787421875));
              num2 = 7;
              continue;
            case 6:
              EntityDescriptor.entityUidProperties = new ConcurrentDictionary<Guid, Guid>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
              continue;
            case 7:
              // ISSUE: method reference
              // ISSUE: type reference
              EntityDescriptor.IdPropertyName = LinqUtils.NameOf<IEntity<object>>(System.Linq.Expressions.Expression.Lambda<Func<IEntity<object>, object>>((System.Linq.Expressions.Expression) EntityDescriptor.aYWAEjodLQ7j2uCDisIq((object) parameterExpression, (object) (MethodInfo) EntityDescriptor.cAwecmodYWdYSTE9niMY(__methodref (IEntity<object>.get_Id), __typeref (IEntity<object>))), parameterExpression));
              num2 = 4;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        // ISSUE: method reference
        // ISSUE: type reference
        EntityDescriptor.TypeUidPropertyName = LinqUtils.NameOf<IInheritable>(System.Linq.Expressions.Expression.Lambda<Func<IInheritable, object>>((System.Linq.Expressions.Expression) EntityDescriptor.lDNyTSodsbiJNnKvk2Zc(EntityDescriptor.aYWAEjodLQ7j2uCDisIq((object) parameterExpression, (object) (MethodInfo) EntityDescriptor.NdRAFModU3rtEVyGg4tC(__methodref (IInheritable.get_TypeUid))), EntityDescriptor.Rdtb3fodEj9WldhCsD2n(__typeref (object))), parameterExpression));
        num1 = 6;
      }
label_3:;
    }

    internal static object sGggSRo9M7FDG9iI3Gii(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VTfxOto9JfEHSGKRwBi7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool HLxy98o9m7bZNlKXg51B() => EntityDescriptor.NyA7jho90FTcZKmug8Y3 == null;

    internal static EntityDescriptor cLet6Zo9yhOeRgok8cvl() => EntityDescriptor.NyA7jho90FTcZKmug8Y3;

    internal static RelationType nLFjy2o99PPyGug0YhUK([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static object ANZRtso9d3igFQKtT5ZT([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool VFwffro9lujehijBYfDG([In] object obj0) => ((EntitySettings) obj0).GenerateFilterInFilter;

    internal static object f1CIdio9rZ4r8OHxb0k6([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object iW4pjto9g1RnqhQdJkZs([In] object obj0, [In] object obj1) => (object) ((TypeDescriptor) obj0).GetPropertyTypeDisplayName((PropertyMetadata) obj1);

    internal static bool MmKhu2o95vW1RVN7BrLD([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object iq2isfo9jiuvYdZ9xIsq([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static object TiPCRjo9YVNGPUXkAWdL(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static Guid aXsQDqo9LAocDrZMPFve([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object cjl5e7o9Ui3Rt1ySfrgb([In] object obj0) => (object) ((TypeSerializationDescriptorBuilder) obj0).Descriptor;

    internal static object fu9QDyo9sMj57bHq21jD([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void DAaEZSo9c26UD4B01XkT([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static void Do51Wjo9z2On9XKYiDRF([In] object obj0, RelationType value) => ((EntitySettings) obj0).RelationType = value;

    internal static void C37BVrodFhIBj61bKhqy([In] object obj0, [In] object obj1) => ((TypeSerializationItemDescriptor) obj0).Descriptor = (TypeSerializationDescriptor) obj1;

    internal static object PTr3mkodB9TEO4tKZUwq([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void QubtcaodWxhC5S84uyKS([In] object obj0, [In] object obj1) => ((TypeSerializationItemDescriptor) obj0).Name = (string) obj1;

    internal static bool fOg8cKodoLabF4DApiQF([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool bWpPduodbBoo4jF6ETiF([In] object obj0) => ((EntitySerializationSettings) obj0).WriteReferences;

    internal static object SR49OWodhF5C0uU5I7Re() => (object) ReferenceResolverSerializer.CurrentResolver;

    internal static object evm0aOodGIEu960xfRNc(bool needResolver) => (object) ReferenceResolverSerializer.CreateResolver(needResolver);

    internal static Type Rdtb3fodEj9WldhCsD2n([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Wm3Tf3odfFGjAkxDNPSg([In] object obj0) => obj0.CastAsRealType();

    internal static EntitySerializationMode vnytVFodQ7LhRKFIhpv4([In] object obj0) => ((EntitySerializationSettings) obj0).Mode;

    internal static object tbmoRkodCtV4AEFC5BAg([In] object obj0) => (object) ((EntitySerializationSettings) obj0).PropertySelector;

    internal static SelectionMode DntH6GodvqjPnMFG0u8B([In] object obj0) => ((EntitySerializationSelector) obj0).SelectionMode;

    internal static bool P67muCod8ED2Am6II7gA([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void aDCIFgodZSG33d1GslqU([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static int dFUH1noduobUSk8j6Jx0([In] object obj0) => ((Dictionary<Guid, EntitySerializationSelector>) obj0).Count;

    internal static object Jp8J3vodIOCEDWS0B0Tw([In] object obj0, [In] object obj1, [In] object obj2) => ((EntityJsonSerializer) obj0).ConvertToSerializable(obj1, (EntitySerializationSettings) obj2);

    internal static object iLDYtuodVU0ZBvNWNvdT([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static bool S36he6odSjVF50kbYj5Y([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static bool nNyu9HodiBEQtdhmif3a([In] object obj0) => ((ClassMetadata) obj0).AllowCreateHeirs;

    internal static Guid txZuxZodRdw61Gr5LRxu([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object bIQkvVodqc6moksZ09nE([In] object obj0) => (object) ((EntityMetadata) obj0).GetUidProperty();

    internal static object YbpqDmodKcKOQ4JSqiPk([In] object obj0) => (object) WebData.CreateFromObject(obj0);

    internal static void SDyfk4odXyjnwAinNhcF([In] object obj0) => EntityJsonSerializer.AddSerializerMarker(obj0);

    internal static void ERjICJodTtkKV2HioDor([In] object obj0) => EntityJsonSerializer.InvokeActions(obj0);

    internal static object avPtyiodk81ybncCa6L9([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object QfYxApodnqp01XXlcgsl([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool HaibTgodOeNPMAISM2rB([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool rglNjuod28gkaiITv2T2([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static object rkJHx0ode8qwKGvBtUVt([In] object obj0) => (object) obj0.AsUntypedISet();

    internal static void aMI7P7odP1wlhTfoTycJ([In] object obj0) => ((UntypedISetProxy) obj0).Clear();

    internal static object LcNMByod1ed7Uv2UsvR8([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object gI2Ae8odNiv0WIfWdnNc([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object XlnLe7od3KiRmnv2iHlF([In] Type obj0) => (object) DetachedCriteria.For(obj0);

    internal static object QHVvrVodpr5m3DF707Tl() => (object) Projections.Id();

    internal static object BbahUaodaiGc8VT1bQb8([In] object obj0, [In] object obj1) => (object) Restrictions.In((IProjection) obj0, (object[]) obj1);

    internal static object YBrpdcodDtksPVUD4Dmv([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object zi4ISYodtXiaYryQqnxQ([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).SetProjection((IProjection) obj1);

    internal static object sGY6tsodw300ZTV9hvar([In] object obj0, [In] object obj1, [In] JoinType obj2) => (object) ((DetachedCriteria) obj0).CreateCriteria((string) obj1, obj2);

    internal static object MdyUGhod49MsjBqIkeIP([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).Add((ICriterion) obj1);

    internal static object rVQVmKod64m1Npbi3JYr([In] object obj0) => (object) ((ICriteria) obj0).Alias;

    internal static object mfOY6IodHo8AVIitAvem([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object sNNvybodAPGp1y3Bs7Sl([In] object obj0, [In] object obj1) => (object) Subqueries.PropertyIn((string) obj0, (DetachedCriteria) obj1);

    internal static object n0ZZ30od7K3RM5MX63AZ([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static bool unn6gpodx412EG27lmTf([In] object obj0) => ((EntitySettings) obj0).GenerateListInFilter;

    internal static Guid GaO1Tood0p82QSfncg0m([In] object obj0) => ((EntityInfo) obj0).Uid;

    internal static object ExY5anodml90kLgvRR9t(Guid typeUid, Guid uid) => (object) ModelHelper.GetEntity(typeUid, uid);

    internal static object wlHig4odytsPSNNtXWV1([In] object obj0) => (object) ((EntityInfo) obj0).Id;

    internal static int TqQHEDodMOBxpMZQcr05([In] object obj0) => ((List<object>) obj0).Count;

    internal static bool bK0CxfodJsUP9Vq1mOLO([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static EntityMetadataType KUmPIYod9O7ROugOeY08([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid PaWVJModdiZ9KNOgcbNM([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static object thEU7codlu6EVWL2TTKo([In] object obj0, [In] Guid obj1) => (object) ((RefTypeDescriptor<IEntity, EntitySettings>) obj0).GetMetadata(obj1);

    internal static Guid qjvF9CodrTjn0du9rVMR([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static object LhL7HCodgYQtXTX3rAIF([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void LvmKccod5r2THlyyIkiw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object vqrgsXodjJMBkbVdtLFI([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object cAwecmodYWdYSTE9niMY([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static object aYWAEjodLQ7j2uCDisIq([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static object NdRAFModU3rtEVyGg4tC([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object lDNyTSodsbiJNnKvk2Zc([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);
  }
}
