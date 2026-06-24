// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.NHibernateClassMapping
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

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
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  internal class NHibernateClassMapping : IConformistHoldersProvider
  {
    private readonly NHibernateClassMapping.CandidatePersistentMembersProvider membersProvider;
    private readonly IModelExplicitDeclarationsHolder explicitDeclarationsHolder;
    private readonly ICustomizersHolder customizersHolder;
    private readonly Type type;
    private readonly EntityMetadata metadata;
    private static NHibernateClassMapping NtDM6Ph5mesUU50jOJRq;

    internal static ModelMapper CreateModelMapper(
      IDictionary<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> mappings)
    {
      NHibernateClassMapping.CandidatePersistentMembersProvider membersProvider = new NHibernateClassMapping.CandidatePersistentMembersProvider((IDictionary<Type, string>) mappings.Where<KeyValuePair<Type, (string, int?, bool?, bool?)>>((Func<KeyValuePair<Type, (string, int?, bool?, bool?)>, bool>) (p => p.Value.entityName != null)).ToDictionary<KeyValuePair<Type, (string, int?, bool?, bool?)>, Type, string>((Func<KeyValuePair<Type, (string, int?, bool?, bool?)>, Type>) (p => p.Key), (Func<KeyValuePair<Type, (string, int?, bool?, bool?)>, string>) (p => p.Value.entityName)));
      ModelMapper mapper = new ModelMapper((IModelInspector) new ExplicitlyDeclaredModel(), (ICandidatePersistentMembersProvider) membersProvider);
      mappings.ForEach<KeyValuePair<Type, (string, int?, bool?, bool?)>>((Action<KeyValuePair<Type, (string, int?, bool?, bool?)>>) (p => mapper.AddMapping((IConformistHoldersProvider) new NHibernateClassMapping(p.Key, p.Value.entityName, p.Value.tableNumber, p.Value.dynamicInsert, p.Value.dynamicUpdate, membersProvider))));
      return mapper;
    }

    IModelExplicitDeclarationsHolder IConformistHoldersProvider.ExplicitDeclarationsHolder => this.explicitDeclarationsHolder;

    ICustomizersHolder IConformistHoldersProvider.CustomizersHolder => this.customizersHolder;

    private NHibernateClassMapping(
      Type type,
      string entityName,
      int? tableNumber,
      bool? dynamicInsert,
      bool? dynamicUpdate,
      NHibernateClassMapping.CandidatePersistentMembersProvider membersProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      NHibernateClassMapping nhibernateClassMapping = this;
      this.membersProvider = membersProvider;
      Contract.CheckArgument(type.IsClass, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123739278), (object) type));
      this.type = type;
      this.metadata = MetadataLoader.LoadMetadata(type, false) as EntityMetadata;
      Contract.CheckArgument(this.metadata != null, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978568244), (object) type));
      string tableName = NHibernateClassMapping.GetTableName(this.metadata, new int?());
      this.explicitDeclarationsHolder = (IModelExplicitDeclarationsHolder) new ExplicitDeclarationsHolder();
      this.customizersHolder = (ICustomizersHolder) new CustomizersHolder();
      if (this.metadata.BaseClassUid == Guid.Empty)
      {
        this.explicitDeclarationsHolder.AddAsRootEntity(type);
        this.customizersHolder.AddCustomizer(type, (Action<IClassMapper>) (m =>
        {
          int num5 = 8;
          while (true)
          {
            int num6 = num5;
            PropertyInfo propertyInfo;
            IClassMapper m1;
            // ISSUE: variable of a compiler-generated type
            NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1 cDisplayClass121;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.JW8kOBv0S6ZkGiBnhjir((object) m1, (object) tableName);
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                  continue;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  if (!NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.hccV1kv0RNEGjaB9abDq((object) closure_0.metadata))
                  {
                    if (!tableNumber.HasValue)
                    {
                      num6 = 5;
                      continue;
                    }
                    goto label_22;
                  }
                  else
                  {
                    num6 = 3;
                    continue;
                  }
                case 3:
                  IClassMapper classMapper = m1;
                  // ISSUE: reference to a compiler-generated field
                  Action<IDiscriminatorMapper> action = NHibernateClassMapping.\u003C\u003Ec.\u003C\u003E9__12_6;
                  Action<IDiscriminatorMapper> discriminatorMapping;
                  if (action == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    NHibernateClassMapping.\u003C\u003Ec.\u003C\u003E9__12_6 = discriminatorMapping = (Action<IDiscriminatorMapper>) (d =>
                    {
                      int num7 = 1;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            NHibernateClassMapping.\u003C\u003Ec.ACQR8Zv0boX3q5UPBkZG((object) d, NHibernateClassMapping.\u003C\u003Ec.emu5mgv0oCVRcoFLeLX4(864270449 << 6 ^ -521249246));
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
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
                    goto label_29;
label_24:
                  classMapper.Discriminator(discriminatorMapping);
                  num6 = 11;
                  continue;
label_29:
                  discriminatorMapping = action;
                  goto label_24;
                case 4:
                  m1 = m;
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
                  continue;
                case 5:
                  goto label_25;
                case 6:
                case 16:
                  closure_0.CreateClassMapAdditional((IEntityAttributesMapper) m1, dynamicInsert, dynamicUpdate);
                  num6 = 17;
                  continue;
                case 7:
                  cDisplayClass121 = this;
                  num6 = 4;
                  continue;
                case 8:
                  num6 = 7;
                  continue;
                case 9:
                  m1.EntityName(entityName);
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 6;
                  continue;
                case 10:
                  goto label_26;
                case 11:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.wjjDklv0KWxMrsga7xC9((object) m1, (object) NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.QdrgrJv0qcikAD2TvruX((object) closure_0.metadata));
                  num6 = 10;
                  continue;
                case 12:
                  goto label_5;
                case 13:
                  closure_0.explicitDeclarationsHolder.AddAsPoid((MemberInfo) propertyInfo);
                  num6 = 14;
                  continue;
                case 14:
                  m1.Id((MemberInfo) propertyInfo, (Action<IIdMapper>) (i =>
                  {
                    int num8 = 4;
                    while (true)
                    {
                      int num9;
                      int? nullable;
                      switch (num8)
                      {
                        case 1:
                          goto label_11;
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.REBaqbv0TG6j9oVe3oB7((object) i, NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.dqekykv0X5MfIkUIXRZ7());
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                          continue;
                        case 3:
                          num9 = 0;
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 9 : 8;
                          continue;
                        case 4:
                          nullable = tableNumber;
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 3 : 1;
                          continue;
                        case 5:
                          goto label_7;
                        case 6:
                          if (!(closure_0.metadata is TablePartMetadata))
                          {
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 5 : 5;
                            continue;
                          }
                          break;
                        case 7:
                          // ISSUE: reference to a compiler-generated method
                          i.SetGenerator(tableName, (string) NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.M8Ye5av0kxekrBiv4QcA(1994213607 >> 4 ^ 124605904));
                          num8 = 6;
                          continue;
                        case 8:
                          goto label_10;
                        case 9:
                          if (!(nullable.GetValueOrDefault() > num9 & nullable.HasValue))
                          {
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 7;
                            continue;
                          }
                          goto case 2;
                      }
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.m7EN1Fv0ncvQrEAjbWSu((object) i, NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.M8Ye5av0kxekrBiv4QcA(1232639661 >> 3 ^ 153797823));
                      num8 = 8;
                    }
label_11:
                    return;
label_7:
                    return;
label_10:;
                  }));
                  num6 = 2;
                  continue;
                case 15:
                  // ISSUE: reference to a compiler-generated method
                  propertyInfo = (PropertyInfo) NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.xsvlIbv0ikLXO8UgQWvE(type, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335026351));
                  num6 = 13;
                  continue;
                case 17:
                  closure_0.WriteClassMapCache(m1);
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 15 : 13;
                  continue;
                default:
                  if (entityName == null)
                  {
                    num6 = 16;
                    continue;
                  }
                  goto case 9;
              }
            }
label_25:
            IEnumerable<EntityPropertyMetadata> source = closure_0.metadata.Properties.OfType<EntityPropertyMetadata>();
            // ISSUE: reference to a compiler-generated field
            Func<EntityPropertyMetadata, bool> func = NHibernateClassMapping.\u003C\u003Ec.\u003C\u003E9__12_7;
            Func<EntityPropertyMetadata, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHibernateClassMapping.\u003C\u003Ec.\u003C\u003E9__12_7 = predicate = (Func<EntityPropertyMetadata, bool>) (p => p.TableNumber != 0);
            }
            else
              goto label_30;
label_28:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            source.Where<EntityPropertyMetadata>(predicate).GroupBy<EntityPropertyMetadata, int>((Func<EntityPropertyMetadata, int>) (p => NHibernateClassMapping.\u003C\u003Ec.ylqu8jv0hyikBOrbiAUA((object) p))).ForEach<IGrouping<int, EntityPropertyMetadata>>((Action<IGrouping<int, EntityPropertyMetadata>>) (grouping => m1.Join(NHibernateClassMapping.GetTableName(cDisplayClass121.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.metadata, new int?(grouping.Key)), (Action<IJoinMapper>) (j =>
            {
              int num10 = 1;
              while (true)
              {
                switch (num10)
                {
                  case 1:
                    j.Key((Action<IKeyMapper>) (x =>
                    {
                      int num4 = 1;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            x.Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439582568));
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_2;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    NHibernateClassMapping.\u003C\u003Ec.tibWkbv0GhKLUbLoUIZi((object) j, true);
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 2;
                    continue;
                }
              }
label_2:;
            }))));
            num5 = 12;
            continue;
label_30:
            predicate = func;
            goto label_28;
          }
label_26:
          return;
label_5:
          return;
label_22:;
        }));
        if (this.metadata.AllowCreateHeirs)
          this.CreateClassMapProperties();
        else
          this.metadata.Properties.OfType<EntityPropertyMetadata>().GroupBy<EntityPropertyMetadata, int>((Func<EntityPropertyMetadata, int>) (p => p.TableNumber)).ForEach<IGrouping<int, EntityPropertyMetadata>>((Action<IGrouping<int, EntityPropertyMetadata>>) (grouping => nhibernateClassMapping.CreateClassMapProperties((IEnumerable<EntityPropertyMetadata>) grouping, tableNumber.HasValue || grouping.Key == 0 ? (string) null : NHibernateClassMapping.GetTableName(nhibernateClassMapping.metadata, new int?(grouping.Key)))));
        int? nullable1 = tableNumber;
        int num11 = 0;
        if (!(nullable1.GetValueOrDefault() == num11 & nullable1.HasValue) && (tableNumber.HasValue || !this.metadata.Properties.OfType<EntityPropertyMetadata>().All<EntityPropertyMetadata>((Func<EntityPropertyMetadata, bool>) (p => p.TableNumber == 0))))
          return;
        this.CreateClassMapTableParts();
      }
      else
      {
        this.explicitDeclarationsHolder.AddAsTablePerClassHierarchyEntity(type);
        this.customizersHolder.AddCustomizer(type, (Action<ISubclassMapper>) (m =>
        {
          int num14 = 7;
          while (true)
          {
            switch (num14)
            {
              case 1:
              case 6:
                closure_0.CreateClassMapAdditional((IEntityAttributesMapper) m, dynamicInsert, dynamicUpdate);
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 4;
                continue;
              case 2:
                m.EntityName(entityName);
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
                continue;
              case 3:
                goto label_10;
              case 4:
                // ISSUE: reference to a compiler-generated method
                NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.dLt4pOv0Ou7oh6DuJUOF((object) m, type.BaseType);
                num14 = 5;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.QqVSlJv02k5qGbQ0ioWH((object) m, (object) NHibernateClassMapping.\u003C\u003Ec__DisplayClass12_1.QdrgrJv0qcikAD2TvruX((object) closure_0.metadata));
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              case 7:
                if (entityName == null)
                {
                  num14 = 6;
                  continue;
                }
                goto case 2;
              default:
                ISubclassMapper subclassMapper = m;
                string splitGroupId = tableName;
                // ISSUE: reference to a compiler-generated field
                Action<IJoinMapper> action = NHibernateClassMapping.\u003C\u003Ec.\u003C\u003E9__12_12;
                Action<IJoinMapper> splitMapping;
                if (action == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  NHibernateClassMapping.\u003C\u003Ec.\u003C\u003E9__12_12 = splitMapping = (Action<IJoinMapper>) (j =>
                  {
                    int num15 = 1;
                    while (true)
                    {
                      switch (num15)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          j.Key((Action<IKeyMapper>) (x =>
                          {
                            int num13 = 1;
                            while (true)
                            {
                              switch (num13)
                              {
                                case 0:
                                  goto label_2;
                                case 1:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  NHibernateClassMapping.\u003C\u003Ec.ct8sUCv0EyMl31y4H1rj((object) x, NHibernateClassMapping.\u003C\u003Ec.emu5mgv0oCVRcoFLeLX4(-1839087379 - 334718690 ^ 2121194325));
                                  num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_4;
                              }
                            }
label_2:
                            return;
label_4:;
                          }));
                          num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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
                  goto label_3;
label_12:
                subclassMapper.Join(splitGroupId, splitMapping);
                num14 = 3;
                continue;
label_3:
                splitMapping = action;
                goto label_12;
            }
          }
label_10:;
        }));
        this.CreateClassMapProperties(tableName);
        this.CreateClassMapTableParts(tableName);
      }
    }

    internal static string GetTableName(EntityMetadata metadata, int? tableNumber)
    {
      string tableName = metadata.TableName;
      int? nullable = tableNumber;
      int num = 0;
      string str = nullable.GetValueOrDefault() > num & nullable.HasValue ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638401429) + (object) tableNumber : "";
      return tableName + str;
    }

    /// <summary>
    /// Записать метод включения кэширования сущности в класс маппинга (если кэширование включено)
    /// </summary>
    private void WriteClassMapCache(IClassMapper mapper)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_5;
          case 1:
            mapper.Cache((Action<ICacheMapper>) (c =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    NHibernateClassMapping.\u003C\u003Ec.fLgH6nv0fJq9sR4AX4ep((object) c, (object) CacheUsage.ReadWrite);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!NHibernateClassMapping.XQAgqGh5JPaMkEJvZTtP((object) this.metadata))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    /// <summary>Записать дополнительные параметры в маппинг</summary>
    private void CreateClassMapAdditional(
      IEntityAttributesMapper mapper,
      bool? dynamicInsert,
      bool? dynamicUpdate)
    {
      bool? nullable1 = dynamicInsert;
      bool flag1 = true;
      if (nullable1.GetValueOrDefault() == flag1 & nullable1.HasValue)
        mapper.DynamicInsert(true);
      bool? nullable2 = dynamicUpdate;
      bool flag2 = true;
      if (!(nullable2.GetValueOrDefault() == flag2 & nullable2.HasValue))
        return;
      mapper.DynamicUpdate(true);
    }

    private void CreateClassMapTableParts(string splitGroupId = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CreateClassMapProperties((IEnumerable<EntityPropertyMetadata>) this.metadata.TableParts.Select<TablePartMetadata, EntityPropertyTablePartMetadata>((Func<TablePartMetadata, EntityPropertyTablePartMetadata>) (tablePartMetadata => new EntityPropertyTablePartMetadata(this.metadata, tablePartMetadata))), splitGroupId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void CreateClassMapProperties(string splitGroupId = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CreateClassMapProperties((IEnumerable<EntityPropertyMetadata>) null, splitGroupId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void CreateClassMapProperties(
      IEnumerable<EntityPropertyMetadata> properties,
      string splitGroupId = null)
    {
      (properties ?? this.metadata.Properties.OfType<EntityPropertyMetadata>()).ForEach<EntityPropertyMetadata>((Action<EntityPropertyMetadata>) (property =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.CreateClassMapProperty(property, splitGroupId);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
    }

    private void CreateClassMapProperty(EntityPropertyMetadata entityProperty, string splitGroupId)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_3;
          case 2:
            if (!(NHibernateClassMapping.e5rRWMh5l3BDxIlXlV7Q((object) MetadataServiceContext.Service, NHibernateClassMapping.q2LSBmh59qX0CKFBbX22((object) entityProperty), NHibernateClassMapping.BdblvRh5dlUfd6scZCL4((object) entityProperty)) is IMappingTypeDescriptor mappingTypeDescriptor))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
              continue;
            }
            NHibernateClassMapping.yvijg3h5rFSjppodeTJp((object) mappingTypeDescriptor, (object) new NHibernateClassMapping.NHibernatePropertiesMapper(this, this.membersProvider, splitGroupId), (object) this.metadata, (object) entityProperty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_3:
      return;
label_7:;
    }

    internal static bool XQAgqGh5JPaMkEJvZTtP([In] object obj0) => ((EntityMetadata) obj0).CacheEntity;

    internal static bool WAhdBbh5yapqCAMRE91l() => NHibernateClassMapping.NtDM6Ph5mesUU50jOJRq == null;

    internal static NHibernateClassMapping kjPBfGh5Mob3tFDfYjR6() => NHibernateClassMapping.NtDM6Ph5mesUU50jOJRq;

    internal static Guid q2LSBmh59qX0CKFBbX22([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid BdblvRh5dlUfd6scZCL4([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object e5rRWMh5l3BDxIlXlV7Q([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static void yvijg3h5rFSjppodeTJp([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IMappingTypeDescriptor) obj0).CreatePropertyMapping((INHibernatePropertiesMapper) obj1, (ClassMetadata) obj2, (EntityPropertyMetadata) obj3);

    private class CandidatePersistentMembersProvider : 
      DefaultCandidatePersistentMembersProvider,
      ICandidatePersistentMembersProvider
    {
      private readonly IDictionary<Type, IDictionary<string, PropertyInfo>> properties;
      private readonly IDictionary<Type, string> entityNames;
      internal static object RO6XXxvxwNjXcjXu4TLD;

      public CandidatePersistentMembersProvider(IDictionary<Type, string> entityNames)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.properties = (IDictionary<Type, IDictionary<string, PropertyInfo>>) new Dictionary<Type, IDictionary<string, PropertyInfo>>();
        this.entityNames = (IDictionary<Type, string>) new Dictionary<Type, string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.entityNames = entityNames.Count > 0 ? entityNames : (IDictionary<Type, string>) null;
      }

      IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetComponentMembers(
        Type componentClass)
      {
        return this.GetProperties(componentClass) ?? this.GetComponentMembers(componentClass);
      }

      IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetEntityMembersForPoid(
        Type entityClass)
      {
        return this.GetProperties(entityClass) ?? this.GetEntityMembersForPoid(entityClass);
      }

      IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetRootEntityMembers(
        Type entityClass)
      {
        return this.GetProperties(entityClass) ?? this.GetRootEntityMembers(entityClass);
      }

      IEnumerable<MemberInfo> ICandidatePersistentMembersProvider.GetSubEntityMembers(
        Type entityClass,
        Type entitySuperclass)
      {
        return this.GetProperties(entityClass) ?? this.GetSubEntityMembers(entityClass, entitySuperclass);
      }

      private IEnumerable<MemberInfo> GetProperties(Type type)
      {
        IDictionary<string, PropertyInfo> dictionary;
        return !this.properties.TryGetValue(type, out dictionary) ? (IEnumerable<MemberInfo>) null : (IEnumerable<MemberInfo>) dictionary.Values;
      }

      internal bool TryGetEntityName(PropertyPath propertyPath, out string entityName)
      {
        int num1 = 2;
        Type type;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                type = NHibernateClassMapping.CandidatePersistentMembersProvider.ENxwUpvxAYcVsSC2isvR((object) (PropertyInfo) NHibernateClassMapping.CandidatePersistentMembersProvider.f0BfScvxHxCXUirUWGHL((object) propertyPath));
                num2 = 6;
                continue;
              case 2:
                if (this.entityNames != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
                  continue;
                }
                goto label_3;
              case 3:
                goto label_11;
              case 4:
              case 7:
                goto label_10;
              case 5:
                goto label_3;
              case 6:
                if (NHibernateClassMapping.CandidatePersistentMembersProvider.jmsMaFvx7d70p8n3EMxV(type, TypeOf<string>.Raw))
                  goto case 8;
                else
                  goto label_9;
              case 8:
                if (TypeOf<IEnumerable>.Raw.IsAssignableFrom(type))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                  continue;
                }
                goto label_10;
              default:
                type = type.GetInterface(TypeOf.IEnumerable.FullName).GetGenericArguments()[0];
                num2 = 7;
                continue;
            }
          }
label_3:
          entityName = (string) null;
          num1 = 3;
          continue;
label_9:
          num1 = 4;
        }
label_10:
        return this.entityNames.TryGetValue(type, out entityName);
label_11:
        return false;
      }

      internal PropertyInfo GetProperty(Type type, string name)
      {
        int num1 = 4;
        Type type1;
        string name1;
        IDictionary<string, PropertyInfo> props;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_9;
              case 2:
                if (((TypeDescriptionProvider) NHibernateClassMapping.CandidatePersistentMembersProvider.qbgxxPvxxrN48LfA0K5g()).IsSupportedType(type1))
                {
                  num2 = 5;
                  continue;
                }
                goto label_9;
              case 3:
                type1 = type;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                continue;
              case 4:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 3;
                continue;
              case 5:
                goto label_10;
              case 6:
                goto label_8;
              default:
                name1 = name;
                num2 = 2;
                continue;
            }
          }
label_10:
          IDictionary<Type, IDictionary<string, PropertyInfo>> properties = this.properties;
          Type key = type1;
          // ISSUE: reference to a compiler-generated field
          Func<Type, IDictionary<string, PropertyInfo>> func = NHibernateClassMapping.CandidatePersistentMembersProvider.\u003C\u003Ec.\u003C\u003E9__9_0;
          Func<Type, IDictionary<string, PropertyInfo>> valueFactory;
          if (func == null)
          {
            // ISSUE: reference to a compiler-generated field
            NHibernateClassMapping.CandidatePersistentMembersProvider.\u003C\u003Ec.\u003C\u003E9__9_0 = valueFactory = (Func<Type, IDictionary<string, PropertyInfo>>) (_ => (IDictionary<string, PropertyInfo>) new Dictionary<string, PropertyInfo>());
          }
          else
            goto label_13;
label_12:
          props = properties.GetOrAdd<Type, IDictionary<string, PropertyInfo>>(key, valueFactory);
          num1 = 6;
          continue;
label_13:
          valueFactory = func;
          goto label_12;
        }
label_8:
        return props.GetOrAdd<string, PropertyInfo>(name1, (Func<string, PropertyInfo>) (_ =>
        {
          // ISSUE: reference to a compiler-generated method
          object obj = NHibernateClassMapping.CandidatePersistentMembersProvider.\u003C\u003Ec__DisplayClass9_0.zo4rfiZTevhVWfp0WJu9(type1, (object) name1, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
          PropertyInfo propertyInfo = props.Values.FirstOrDefault<PropertyInfo>();
          // ISSUE: reference to a compiler-generated method
          Type type2 = (object) propertyInfo != null ? NHibernateClassMapping.CandidatePersistentMembersProvider.\u003C\u003Ec__DisplayClass9_0.plGdMSZTP3GPhYiB46IG((object) propertyInfo) : (Type) null;
          Type declaringType = (object) type2 == null ? (Type) new NHibernateClassMapping.CandidatePersistentMembersProvider.TypeDelegator(type1, props) : type2;
          // ISSUE: reference to a compiler-generated method
          return (PropertyInfo) NHibernateClassMapping.CandidatePersistentMembersProvider.\u003C\u003Ec__DisplayClass9_0.TcRu3dZT1Xy79BPvx7eW(obj, declaringType);
        }));
label_9:
        return type1.GetProperty(name1, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
      }

      private static PropertyInfo DeclaringTo(object propertyInfo, Type declaringType) => (PropertyInfo) new PropertyInfoProxy((PropertyInfo) propertyInfo, declaringType);

      internal static object f0BfScvxHxCXUirUWGHL([In] object obj0) => (object) ((PropertyPath) obj0).LocalMember;

      internal static Type ENxwUpvxAYcVsSC2isvR([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

      internal static bool jmsMaFvx7d70p8n3EMxV([In] Type obj0, [In] Type obj1) => obj0 != obj1;

      internal static bool Hv6V9rvx4Iq0YC8Y8Jls() => NHibernateClassMapping.CandidatePersistentMembersProvider.RO6XXxvxwNjXcjXu4TLD == null;

      internal static NHibernateClassMapping.CandidatePersistentMembersProvider p86BpXvx6kBW9w01XL4T() => (NHibernateClassMapping.CandidatePersistentMembersProvider) NHibernateClassMapping.CandidatePersistentMembersProvider.RO6XXxvxwNjXcjXu4TLD;

      internal static object qbgxxPvxxrN48LfA0K5g() => (object) EntityDynamicProvider.Instance;

      private class TypeDelegator : System.Reflection.TypeDelegator
      {
        private readonly IDictionary<string, PropertyInfo> properties;
        internal static object T9sgs5ZTKeJru5nvQugs;

        public TypeDelegator(Type runtimeType, IDictionary<string, PropertyInfo> properties)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector(runtimeType);
          this.properties = properties;
        }

        public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) => new MemberInfo[1]
        {
          (MemberInfo) this.properties[name]
        };

        internal static bool bpqbQCZTXsvhLRPxj9hK() => NHibernateClassMapping.CandidatePersistentMembersProvider.TypeDelegator.T9sgs5ZTKeJru5nvQugs == null;

        internal static NHibernateClassMapping.CandidatePersistentMembersProvider.TypeDelegator eL4ORVZTT29aWSHhn3Cy() => (NHibernateClassMapping.CandidatePersistentMembersProvider.TypeDelegator) NHibernateClassMapping.CandidatePersistentMembersProvider.TypeDelegator.T9sgs5ZTKeJru5nvQugs;
      }
    }

    private class NHibernatePropertiesMapper : INHibernatePropertiesMapper
    {
      private static readonly IDictionary<Type, string[]> UserTypePropertyNames;
      private readonly object mapper;
      private readonly object membersProvider;
      private readonly object splitGroupId;
      private object dialect;
      internal static object AMIrFVvx07A1ppIQstvv;

      /// <summary>ctor</summary>
      public NHibernatePropertiesMapper(
        NHibernateClassMapping mapper,
        NHibernateClassMapping.CandidatePersistentMembersProvider membersProvider,
        string splitGroupId)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.membersProvider = (object) membersProvider;
              num = 2;
              continue;
            case 2:
              this.splitGroupId = (object) splitGroupId;
              num = 3;
              continue;
            case 3:
              goto label_3;
            default:
              this.mapper = (object) mapper;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public void Property(
        string name,
        string columnName,
        Action<INHibernatePropertyTypeMapper> propertyTypeBuilder,
        bool notNull,
        string formula,
        string sqlType)
      {
        PropertyPath propertyPath = this.GetPropertyPath(name);
        this.ExplicitDeclaration(propertyPath.LocalMember, new Action<MemberInfo>(((NHibernateClassMapping) this.mapper).explicitDeclarationsHolder.AddAsProperty));
        ((NHibernateClassMapping) this.mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IPropertyMapper>) (m =>
        {
          int num = 4;
          while (true)
          {
            Type persistentType;
            NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder propertyTypeBuilder1;
            switch (num)
            {
              case 1:
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (!NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass6_0.QQOQF7ZTdlIZwrkZm6du((object) formula))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 5 : 0;
                  continue;
                }
                break;
              case 3:
                if (propertyTypeBuilder == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 2 : 0;
                  continue;
                }
                goto case 9;
              case 4:
                persistentType = (Type) null;
                num = 3;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated method
                NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass6_0.aeVRxTZTljOnhcbiJ1GH((object) m, (object) formula);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              case 6:
                propertyTypeBuilder((INHibernatePropertyTypeMapper) propertyTypeBuilder1);
                num = 7;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated method
                persistentType = NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass6_0.pDEM5LZT9DIY94l1JbSB((object) propertyTypeBuilder1);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
                continue;
              case 8:
                goto label_8;
              case 9:
                propertyTypeBuilder1 = new NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder(m);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 4;
                continue;
            }
            this.PropertyColumnMap(m, persistentType, name, columnName, notNull, sqlType);
            num = 8;
          }
label_8:;
        }));
      }

      /// <inheritdoc />
      public void ManyToOne(string name, string columnName, CascadeMode cascadeMode)
      {
        int num1 = 8;
        while (true)
        {
          int num2 = num1;
          string columnName1;
          string name1;
          NHibernateClassMapping.NHibernatePropertiesMapper propertiesMapper;
          PropertyPath propertyPath;
          CascadeMode cascadeMode1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                name1 = name;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              case 2:
                this.ExplicitDeclaration((MemberInfo) NHibernateClassMapping.NHibernatePropertiesMapper.OTgL83vxMJvsa9uR8itn((object) propertyPath), new Action<MemberInfo>(((NHibernateClassMapping) this.mapper).explicitDeclarationsHolder.AddAsManyToOneRelation));
                num2 = 5;
                continue;
              case 3:
                goto label_3;
              case 4:
                propertyPath = this.GetPropertyPath(name1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 2;
                continue;
              case 5:
                ((NHibernateClassMapping) this.mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IManyToOneMapper>) (m =>
                {
                  int num3 = 5;
                  while (true)
                  {
                    int num4 = num3;
                    string name2;
                    string entityName;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 2:
                          // ISSUE: reference to a compiler-generated method
                          NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass7_0.efawB2ZTsRaMHIXv6rfE((object) m, (object) entityName);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                          continue;
                        case 3:
                          goto label_12;
                        case 4:
                          // ISSUE: reference to a compiler-generated method
                          if (NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass7_0.Y2JvryZTLAFllfjDVfOc((object) columnName1, (object) name1))
                          {
                            num4 = 9;
                            continue;
                          }
                          goto label_9;
                        case 5:
                          // ISSUE: reference to a compiler-generated method
                          if (!NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass7_0.XHyyMPZTYohlZlvabB1m((object) columnName1))
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 4;
                            continue;
                          }
                          goto label_9;
                        case 6:
                          goto label_11;
                        case 7:
                        case 10:
                        case 14:
                          if (!((NHibernateClassMapping.CandidatePersistentMembersProvider) propertiesMapper.membersProvider).TryGetEntityName(propertyPath, out entityName))
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                            continue;
                          }
                          goto case 2;
                        case 8:
                          goto label_9;
                        case 9:
                          // ISSUE: reference to a compiler-generated method
                          NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass7_0.PxF70WZTUnJn8ORukqqr((object) m, (object) propertiesMapper.QuoteIfNeeded(columnName1));
                          num4 = 10;
                          continue;
                        case 11:
                          m.Column(name2);
                          num4 = 14;
                          continue;
                        case 12:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass7_0.RsVsdaZTzkPVwOvwJXEr((object) m, NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass7_0.hRyFeXZTc9PBRI1o0WsJ(cascadeMode1));
                          num4 = 3;
                          continue;
                        case 13:
                          // ISSUE: reference to a compiler-generated method
                          if (NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass7_0.Y2JvryZTLAFllfjDVfOc((object) name2, (object) name1))
                            goto case 11;
                          else
                            goto label_19;
                        default:
                          if (cascadeMode1 == CascadeMode.None)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 4 : 6;
                            continue;
                          }
                          goto case 12;
                      }
                    }
label_9:
                    name2 = propertiesMapper.QuoteIfNeeded(name1);
                    num3 = 13;
                    continue;
label_19:
                    num3 = 7;
                  }
label_12:
                  return;
label_11:;
                }));
                num2 = 3;
                continue;
              case 6:
                cascadeMode1 = cascadeMode;
                num2 = 4;
                continue;
              case 7:
                columnName1 = columnName;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                continue;
              case 8:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 7 : 4;
                continue;
              default:
                goto label_5;
            }
          }
label_5:
          propertiesMapper = this;
          num1 = 6;
        }
label_3:;
      }

      /// <inheritdoc />
      public void OneToManyCollection(
        string name,
        string tableName,
        string keyColumn,
        CascadeMode cascadeMode,
        int batchSize,
        Type comparerType)
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          PropertyPath propertyPath;
          string entityName;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_11;
              case 1:
                ((NHibernateClassMapping) this.mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IOneToManyMapper>) (x =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass8_0.vWP0ksZkbnbP8x49Un9a((object) x, (object) entityName);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              case 3:
                this.ExplicitDeclaration((MemberInfo) NHibernateClassMapping.NHibernatePropertiesMapper.OTgL83vxMJvsa9uR8itn((object) propertyPath), new Action<MemberInfo>(((NHibernateClassMapping) this.mapper).explicitDeclarationsHolder.AddAsOneToManyRelation));
                num2 = 5;
                continue;
              case 4:
                if (!((NHibernateClassMapping.CandidatePersistentMembersProvider) this.membersProvider).TryGetEntityName(propertyPath, out entityName))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 2;
                  continue;
                }
                goto case 1;
              case 5:
                this.CollectionMapping(propertyPath, tableName, keyColumn, cascadeMode, batchSize, comparerType);
                num2 = 4;
                continue;
              case 6:
                goto label_10;
              case 7:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 6;
                continue;
              default:
                goto label_12;
            }
          }
label_10:
          propertyPath = this.GetPropertyPath(name);
          num1 = 3;
        }
label_11:
        return;
label_3:
        return;
label_12:;
      }

      /// <inheritdoc />
      public void ManyToManyCollection(
        string name,
        string tableName,
        string parentKeyColumn,
        string childKeyColumn,
        CascadeMode cascadeMode,
        int batchSize,
        Type comparerType,
        bool inverse)
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          NHibernateClassMapping.NHibernatePropertiesMapper propertiesMapper;
          PropertyPath propertyPath;
          bool inverse1;
          string parentKeyColumn1;
          string childKeyColumn1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                ((NHibernateClassMapping) this.mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IManyToManyMapper>) (x =>
                {
                  int num3 = 4;
                  string entityName;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass9_0.avWNXSZkfDISDK31KUrW((object) x, (object) entityName);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_6;
                      case 4:
                        if (!((NHibernateClassMapping.CandidatePersistentMembersProvider) propertiesMapper.membersProvider).TryGetEntityName(propertyPath, out entityName))
                        {
                          num3 = 3;
                          continue;
                        }
                        goto case 1;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass9_0.NCeAU2ZkQn3QqAnEYjTw((object) x, (object) propertiesMapper.QuoteIfNeeded(!inverse1 ? childKeyColumn1 : parentKeyColumn1));
                        num3 = 2;
                        continue;
                    }
                  }
label_6:;
                }));
                num2 = 2;
                continue;
              case 2:
                goto label_3;
              case 3:
                propertiesMapper = this;
                num2 = 7;
                continue;
              case 4:
                num2 = 3;
                continue;
              case 5:
                this.ExplicitDeclaration((MemberInfo) NHibernateClassMapping.NHibernatePropertiesMapper.OTgL83vxMJvsa9uR8itn((object) propertyPath), new Action<MemberInfo>(((NHibernateClassMapping) this.mapper).explicitDeclarationsHolder.AddAsManyToManyItemRelation));
                num2 = 6;
                continue;
              case 6:
                this.CollectionMapping(propertyPath, tableName, this.QuoteIfNeeded(inverse1 ? childKeyColumn1 : parentKeyColumn1), cascadeMode, batchSize, comparerType, inverse1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
                continue;
              case 7:
                goto label_6;
              case 8:
                propertyPath = this.GetPropertyPath(name);
                num2 = 5;
                continue;
              case 9:
                parentKeyColumn1 = parentKeyColumn;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              default:
                childKeyColumn1 = childKeyColumn;
                num2 = 8;
                continue;
            }
          }
label_6:
          inverse1 = inverse;
          num1 = 9;
        }
label_3:;
      }

      /// <inheritdoc />
      public void Set(
        string name,
        string tableName,
        string parentKeyColumn,
        string childKeyColumn,
        CascadeMode cascadeMode,
        int batchSize,
        Type comparerType,
        Action<INHibernatePropertyTypeMapper> propertyTypeBuilder)
      {
        PropertyPath propertyPath = this.GetPropertyPath(name);
        this.ExplicitDeclaration(propertyPath.LocalMember, new Action<MemberInfo>(((NHibernateClassMapping) this.mapper).explicitDeclarationsHolder.AddAsSet));
        this.CollectionMapping(propertyPath, tableName, this.QuoteIfNeeded(parentKeyColumn), cascadeMode, batchSize, comparerType);
        ((NHibernateClassMapping) this.mapper).customizersHolder.AddCustomizer(propertyPath, (Action<IElementMapper>) (mappingElement =>
        {
          int num = 7;
          while (true)
          {
            NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder elementTypeBuilder;
            Type type;
            switch (num)
            {
              case 1:
                propertyTypeBuilder((INHibernatePropertyTypeMapper) elementTypeBuilder);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 3 : 0;
                continue;
              case 2:
              case 6:
                mappingElement.Column(this.QuoteIfNeeded(childKeyColumn));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 4 : 1;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated method
                type = NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass10_0.EnXUeBZkZ4rYEA8u5r89((object) elementTypeBuilder);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 5 : 3;
                continue;
              case 4:
                goto label_5;
              case 5:
                // ISSUE: reference to a compiler-generated method
                NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass10_0.wZ1ZXfZkuoS4XIcprMns((object) mappingElement, type, (object) null);
                num = 2;
                continue;
              case 7:
                if (propertyTypeBuilder == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 6;
                  continue;
                }
                break;
            }
            elementTypeBuilder = new NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder(mappingElement);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
          }
label_5:;
        }));
      }

      private PropertyPath GetPropertyPath(string name) => new PropertyPath((PropertyPath) null, (MemberInfo) ((NHibernateClassMapping.CandidatePersistentMembersProvider) this.membersProvider).GetProperty(((NHibernateClassMapping) this.mapper).type, name));

      private void ExplicitDeclaration(MemberInfo member, Action<MemberInfo> explicitDeclaration)
      {
        if (this.splitGroupId != null)
          ((NHibernateClassMapping) this.mapper).explicitDeclarationsHolder.AddAsPropertySplit(new SplitDefinition(((NHibernateClassMapping) this.mapper).type, (string) this.splitGroupId, member));
        explicitDeclaration(member);
      }

      private string QuoteIfNeeded(string name)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.dialect == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_2;
            case 3:
              if (!((Dialect) this.dialect).IsReservedWord(name))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 2;
                continue;
              }
              goto label_3;
            default:
              string name1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021619847);
              // ISSUE: reference to a compiler-generated field
              Func<Dialect> func = NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec.\u003C\u003E9__13_0;
              Func<Dialect> val;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec.\u003C\u003E9__13_0 = val = (Func<Dialect>) (() => ((ITransformationProvider) NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec.JryCKfZkRwI4Oio5yk0D((object) Locator.GetServiceNotNull<IRuntimeApplication>())).Dialect);
              }
              else
                goto label_11;
label_10:
              this.dialect = (object) ContextVars.GetOrAdd<Dialect>(name1, val);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 3;
              continue;
label_11:
              val = func;
              goto label_10;
          }
        }
label_2:
        return name;
label_3:
        return (string) NHibernateClassMapping.NHibernatePropertiesMapper.Vsh3eavx9IaHOGNMcPS7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272252689), (object) name, NHibernateClassMapping.NHibernatePropertiesMapper.kOatePvxJSJd4IGwbBCg(654297945 ^ 653925693));
      }

      private void PropertyColumnMap(
        IPropertyMapper m,
        Type persistentType,
        string name,
        string columnName,
        bool notNull,
        string sqlType)
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          string[] source;
          NHibernateClassMapping.NHibernatePropertiesMapper propertiesMapper;
          string name1;
          string columnName1;
          bool notNull1;
          string sqlType1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                propertiesMapper = this;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                continue;
              case 2:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
                continue;
              case 3:
                goto label_14;
              case 4:
                columnName1 = columnName;
                num2 = 13;
                continue;
              case 5:
                if (NHibernateClassMapping.NHibernatePropertiesMapper.UserTypePropertyNames.TryGetValue(persistentType, out source))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 6 : 8;
                  continue;
                }
                goto case 9;
              case 6:
                NHibernateClassMapping.NHibernatePropertiesMapper.lb2iEVvxlkKfbYpJdjdZ((object) m, (object) ((IEnumerable<string>) source).Select<string, Action<IColumnMapper>>((Func<string, Action<IColumnMapper>>) (propertyName => (Action<IColumnMapper>) (c =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        propertiesMapper.PropertyColumnMap(c, name1, (string) NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass14_1.OUlrSDZk2t3dsDEnuQhY((object) columnName1, (object) propertyName), notNull1, sqlType1);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }))).ToArray<Action<IColumnMapper>>());
                num2 = 14;
                continue;
              case 7:
              case 8:
                if (source.Length > 1)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 6;
                  continue;
                }
                goto case 12;
              case 9:
                NHibernateClassMapping.NHibernatePropertiesMapper.UserTypePropertyNames[persistentType] = source = (string[]) NHibernateClassMapping.NHibernatePropertiesMapper.JYGfAnvxdqi1UqrcvQLb((object) (ICompositeUserType) Activator.CreateInstance(persistentType));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 7 : 2;
                continue;
              case 10:
                if (!TypeOf<ICompositeUserType>.Raw.IsAssignableFrom(persistentType))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 12 : 4;
                  continue;
                }
                goto case 5;
              case 11:
                sqlType1 = sqlType;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 10 : 2;
                continue;
              case 12:
                m.Column((Action<IColumnMapper>) (c =>
                {
                  int num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        propertiesMapper.PropertyColumnMap(c, name1, columnName1, notNull1, sqlType1);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 3 : 1;
                continue;
              case 13:
                notNull1 = notNull;
                num2 = 11;
                continue;
              case 14:
                goto label_5;
              default:
                goto label_3;
            }
          }
label_3:
          name1 = name;
          num1 = 4;
        }
label_14:
        return;
label_5:;
      }

      private void PropertyColumnMap(
        IColumnMapper c,
        string name,
        string columnName,
        bool notNull,
        string sqlType)
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          string str;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_11;
              case 1:
                if (columnName != name)
                {
                  num2 = 6;
                  continue;
                }
                goto case 11;
              case 2:
                if (!NHibernateClassMapping.NHibernatePropertiesMapper.PSEpUOvxrGa6RGkp3wvd((object) columnName))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                  continue;
                }
                goto case 11;
              case 3:
              case 12:
              case 13:
                if (notNull)
                {
                  num2 = 5;
                  continue;
                }
                goto case 9;
              case 4:
                NHibernateClassMapping.NHibernatePropertiesMapper.AJmbHUvxgWI4gWirdxEq((object) c, (object) str);
                num2 = 13;
                continue;
              case 5:
              case 7:
                goto label_19;
              case 6:
                c.Name(this.QuoteIfNeeded(columnName));
                num2 = 3;
                continue;
              case 8:
                if (!(str != name))
                {
                  num2 = 12;
                  continue;
                }
                goto case 4;
              case 9:
                NHibernateClassMapping.NHibernatePropertiesMapper.CoUiyBvx5kjG3nStIm2x((object) c, false);
                num2 = 7;
                continue;
              case 10:
                NHibernateClassMapping.NHibernatePropertiesMapper.ooOxW8vxj4SU6MJndho8((object) c, (object) sqlType);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              case 11:
                str = this.QuoteIfNeeded(name);
                num2 = 8;
                continue;
              default:
                goto label_7;
            }
          }
label_19:
          if (!string.IsNullOrWhiteSpace(sqlType))
            num1 = 10;
          else
            goto label_8;
        }
label_11:
        return;
label_7:
        return;
label_8:;
      }

      private void CollectionMapping(
        PropertyPath propertyPath,
        string tableName,
        string keyColumn,
        CascadeMode cascadeMode,
        int batchSize,
        Type comparerType,
        bool inverse = false)
      {
        int num1 = 8;
        NHibernateClassMapping.NHibernatePropertiesMapper propertiesMapper;
        string keyColumn1;
        string tableName1;
        int batchSize1;
        CascadeMode cascadeMode1;
        Type comparerType1;
        bool inverse1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              cascadeMode1 = cascadeMode;
              num1 = 10;
              continue;
            case 2:
              goto label_2;
            case 3:
              ((NHibernateClassMapping) this.mapper).explicitDeclarationsHolder.AddAsSet(propertyPath.LocalMember);
              num1 = 5;
              continue;
            case 4:
              tableName1 = tableName;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 9 : 7;
              continue;
            case 5:
              ((NHibernateClassMapping) this.mapper).customizersHolder.AddCustomizer(propertyPath, (Action<ICollectionPropertiesMapper>) (m =>
              {
                int num3 = 8;
                while (true)
                {
                  int num4 = num3;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                      case 4:
                        if (!inverse1)
                        {
                          num4 = 5;
                          continue;
                        }
                        goto case 2;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass16_0.Fcx8xiZkwvuWRDSfN5Bu((object) m, true);
                        num4 = 11;
                        continue;
                      case 3:
                      case 10:
                        // ISSUE: reference to a compiler-generated method
                        if (!NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass16_0.WJ2p2IZkDPrwseeR0tPj(comparerType1, (Type) null))
                        {
                          num4 = 4;
                          continue;
                        }
                        goto case 6;
                      case 5:
                        goto label_15;
                      case 6:
                        // ISSUE: reference to a compiler-generated method
                        NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass16_0.EbOhu4ZktghyjnBGTC8k((object) m, comparerType1);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                        continue;
                      case 7:
                        // ISSUE: reference to a compiler-generated method
                        NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass16_0.mgHCFlZkNg7gaCrX0eV6((object) m, (object) tableName1);
                        num4 = 9;
                        continue;
                      case 8:
                        m.Key((Action<IKeyMapper>) (k =>
                        {
                          int num5 = 1;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                k.Column(propertiesMapper.QuoteIfNeeded(keyColumn1));
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_4;
                            }
                          }
label_2:
                          return;
label_4:;
                        }));
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 7 : 5;
                        continue;
                      case 9:
                        // ISSUE: reference to a compiler-generated method
                        NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass16_0.iXwfdbZk3iaNr9mwnDd7((object) m, batchSize1);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 12 : 12;
                        continue;
                      case 11:
                        goto label_14;
                      case 12:
                        if (cascadeMode1 != CascadeMode.None)
                          break;
                        goto label_13;
                    }
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass16_0.xO0fPFZkaMUiUV4U9THi((object) m, NHibernateClassMapping.NHibernatePropertiesMapper.\u003C\u003Ec__DisplayClass16_0.VAyp4WZkpbMnhDDgt8b0(cascadeMode1));
                    num4 = 3;
                  }
label_13:
                  num3 = 10;
                }
label_15:
                return;
label_14:;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
              continue;
            case 6:
              keyColumn1 = keyColumn;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 4 : 2;
              continue;
            case 7:
              propertiesMapper = this;
              num1 = 6;
              continue;
            case 8:
              num1 = 7;
              continue;
            case 9:
              batchSize1 = batchSize;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
            case 10:
              comparerType1 = comparerType;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            default:
              inverse1 = inverse;
              num1 = 3;
              continue;
          }
        }
label_2:;
      }

      private static Cascade ToCascade(CascadeMode cascadeMode)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              switch (cascadeMode)
              {
                case CascadeMode.All:
                  goto label_2;
                case CascadeMode.SaveUpdate:
                  goto label_3;
                case CascadeMode.AllDeleteOrphan:
                  goto label_4;
                default:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
                  continue;
              }
            default:
              goto label_2;
          }
        }
label_2:
        return Cascade.All;
label_3:
        return Cascade.Persist;
label_4:
        return Cascade.DeleteOrphans | Cascade.All;
label_5:
        return Cascade.None;
      }

      static NHibernatePropertiesMapper()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              NHibernateClassMapping.NHibernatePropertiesMapper.lK5SOovxYA5ntpvgcNq0();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              NHibernateClassMapping.NHibernatePropertiesMapper.UserTypePropertyNames = (IDictionary<Type, string[]>) new Dictionary<Type, string[]>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static bool qSPC8YvxmJWerajScwRy() => NHibernateClassMapping.NHibernatePropertiesMapper.AMIrFVvx07A1ppIQstvv == null;

      internal static NHibernateClassMapping.NHibernatePropertiesMapper k7mRLDvxynIpvq7LsxqL() => (NHibernateClassMapping.NHibernatePropertiesMapper) NHibernateClassMapping.NHibernatePropertiesMapper.AMIrFVvx07A1ppIQstvv;

      internal static object OTgL83vxMJvsa9uR8itn([In] object obj0) => (object) ((PropertyPath) obj0).LocalMember;

      internal static object kOatePvxJSJd4IGwbBCg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object Vsh3eavx9IaHOGNMcPS7([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

      internal static object JYGfAnvxdqi1UqrcvQLb([In] object obj0) => (object) ((ICompositeUserType) obj0).PropertyNames;

      internal static void lb2iEVvxlkKfbYpJdjdZ([In] object obj0, [In] object obj1) => ((IColumnsMapper) obj0).Columns((Action<IColumnMapper>[]) obj1);

      internal static bool PSEpUOvxrGa6RGkp3wvd([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

      internal static void AJmbHUvxgWI4gWirdxEq([In] object obj0, [In] object obj1) => ((IColumnMapper) obj0).Name((string) obj1);

      internal static void CoUiyBvx5kjG3nStIm2x([In] object obj0, [In] bool obj1) => ((IColumnMapper) obj0).NotNullable(obj1);

      internal static void ooOxW8vxj4SU6MJndho8([In] object obj0, [In] object obj1) => ((IColumnMapper) obj0).SqlType((string) obj1);

      internal static void lK5SOovxYA5ntpvgcNq0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      private class NHibernatePropertyTypeBuilder : INHibernatePropertyTypeMapper
      {
        private object m;
        internal static object LsZWQ8ZTDD6bJWrOG01O;

        public NHibernatePropertyTypeBuilder(IPropertyMapper m)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.m = (object) m;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_3:
          return;
label_5:;
        }

        public void Type<TPersistentType>()
        {
          this.PersistentType = typeof (TPersistentType);
          ((IPropertyMapper) this.m).Type<TPersistentType>();
        }

        public void Type(Type persistentType)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.PersistentType = persistentType;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder.jagYsSZT4rwn2bEd7P4O(this.m, persistentType, (object) null);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 1;
                continue;
            }
          }
label_2:;
        }

        public void Type<TPersistentType>(object parameter)
        {
          this.PersistentType = typeof (TPersistentType);
          ((IPropertyMapper) this.m).Type<TPersistentType>(parameter);
        }

        public void Type(Type persistentType, object parameter)
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder.jagYsSZT4rwn2bEd7P4O(this.m, persistentType, parameter);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              case 2:
                this.PersistentType = persistentType;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }

        public void Length(int length)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder.lJfS03ZT6eVr7KqxXFbJ(this.m, length);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        public Type PersistentType
        {
          get => this.\u003CPersistentType\u003Ek__BackingField;
          private set
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  this.\u003CPersistentType\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }
        }

        internal static bool viQJMRZTtc0ZwBZkEGWl() => NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder.LsZWQ8ZTDD6bJWrOG01O == null;

        internal static NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder HY3XB4ZTwBfCZtm9Fchx() => (NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder) NHibernateClassMapping.NHibernatePropertiesMapper.NHibernatePropertyTypeBuilder.LsZWQ8ZTDD6bJWrOG01O;

        internal static void jagYsSZT4rwn2bEd7P4O([In] object obj0, [In] Type obj1, [In] object obj2) => ((IPropertyMapper) obj0).Type(obj1, obj2);

        internal static void lJfS03ZT6eVr7KqxXFbJ([In] object obj0, [In] int obj1) => ((IPropertyMapper) obj0).Length(obj1);
      }

      private class NHibernateElementTypeBuilder : INHibernatePropertyTypeMapper
      {
        private object m;
        internal static object QuHeA9ZTHuhXKkOmABCA;

        public NHibernateElementTypeBuilder(IElementMapper m)
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_3;
              case 1:
                this.m = (object) m;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_3:
          return;
label_5:;
        }

        public void Type<TPersistentType>()
        {
          this.PersistentType = typeof (TPersistentType);
          ((IElementMapper) this.m).Type<TPersistentType>();
        }

        public void Type(Type persistentType)
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder.TaVDUOZTxgep3iOmrkkZ(this.m, persistentType, (object) null);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              case 2:
                this.PersistentType = persistentType;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        }

        public void Type<TPersistentType>(object parameter)
        {
          this.PersistentType = typeof (TPersistentType);
          ((IElementMapper) this.m).Type<TPersistentType>(parameter);
        }

        public void Type(Type persistentType, object parameter)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.PersistentType = persistentType;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                ((IElementMapper) this.m).Type(persistentType, parameter);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 2;
                continue;
            }
          }
label_2:;
        }

        public void Length(int length)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder.xwyfPOZT02layE43urhy(this.m, length);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        public Type PersistentType
        {
          get => this.\u003CPersistentType\u003Ek__BackingField;
          private set
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  this.\u003CPersistentType\u003Ek__BackingField = value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }
        }

        internal static bool cy44mQZTAbe3jAKQvLNT() => NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder.QuHeA9ZTHuhXKkOmABCA == null;

        internal static NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder S0p0IBZT7QjsxsaGbRpA() => (NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder) NHibernateClassMapping.NHibernatePropertiesMapper.NHibernateElementTypeBuilder.QuHeA9ZTHuhXKkOmABCA;

        internal static void TaVDUOZTxgep3iOmrkkZ([In] object obj0, [In] Type obj1, [In] object obj2) => ((IElementMapper) obj0).Type(obj1, obj2);

        internal static void xwyfPOZT02layE43urhy([In] object obj0, [In] int obj1) => ((IElementMapper) obj0).Length(obj1);
      }
    }
  }
}
