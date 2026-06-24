// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.Services.UserDefinedListService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.UserDefinedList;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.UserDefinedList;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts.Services
{
  /// <inheritdoc />
  [Service]
  internal class UserDefinedListService : IUserDefinedListService
  {
    private readonly NestedScopeComponents<IEntityManagerBehavior> behaviors;
    private readonly ISessionProvider sessionProvider;
    private readonly ILogger logger;
    private static UserDefinedListService gT23erLe4xq53Drsw4N;

    /// <summary>ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий</param>
    public UserDefinedListService(ISessionProvider sessionProvider)
    {
      UserDefinedListService.POVZIPLNrdF5mD4OGJI();
      this.behaviors = new NestedScopeComponents<IEntityManagerBehavior>(ServiceScope.Shell);
      // ISSUE: type reference
      this.logger = (ILogger) UserDefinedListService.mHqXrBLpHigmZ7RuxCs(UserDefinedListService.A1DnkJL31cuZUAeXSts(__typeref (UserDefinedListService)));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Составить пользовательский список по выбранным данным</summary>
    /// <param name="preparationDataInfo">Данные, которые составил пользователь</param>
    /// <returns>Пользовательский список</returns>
    public IEnumerable<object> GetUserDefinedList(UserDefinedListInfo preparationDataInfo)
    {
      List<object> userDefinedList = new List<object>();
      if (preparationDataInfo.SubTypeUid == Guid.Empty)
        return (IEnumerable<object>) userDefinedList;
      IEnumerable<object> entities = this.GetEntities(preparationDataInfo);
      if (!entities.Any<object>())
        return (IEnumerable<object>) userDefinedList;
      ClassMetadata metadata = this.GetMetadata(preparationDataInfo);
      if (metadata == null)
        return (IEnumerable<object>) userDefinedList;
      EntitySerializationSettings settings = new EntitySerializationSettings();
      EntityJsonSerializer entityJsonSerializer = new EntityJsonSerializer();
      foreach (object obj1 in entities)
      {
        SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
        UDLDynamicObject udlDynamicObject = (UDLDynamicObject) obj1;
        foreach (PropertyMetadata property in metadata.Properties)
        {
          object obj2 = udlDynamicObject.TryGetValue(property.Name);
          if (obj2 != null)
          {
            ISerializableTypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) as ISerializableTypeDescriptor;
            object obj3 = (object) null;
            try
            {
              obj3 = !this.IsSimpleType(property.Settings) ? entityJsonSerializer.ConvertToSerializable(obj2, metadata, settings) : typeDescriptor.SerializeSimple(obj2, obj2.GetType());
            }
            catch (Exception ex)
            {
              this.logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629831826)), ex);
            }
            if (obj3 != null)
              serializableDictionary[property.Name] = obj3;
          }
        }
        userDefinedList.Add((object) serializableDictionary);
      }
      return (IEnumerable<object>) userDefinedList;
    }

    private bool IsSimpleType(TypeSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(settings is EntitySettings))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return !(settings is PropertySettings);
label_5:
      return false;
    }

    /// <summary>Построить список свойств для пользовательского списка</summary>
    /// <param name="userDefinedListInfo"></param>
    /// <returns></returns>
    /// 
    ///             TODO ELMA-28025 Изменить построение metadata для мастера подготовки данных
    private ClassMetadata GetMetadata(UserDefinedListInfo userDefinedListInfo)
    {
      int num1 = 11;
      ClassMetadata metadata;
      while (true)
      {
        List<GroupingProperty>.Enumerator enumerator1;
        List<Guid>.Enumerator enumerator2;
        ClassMetadata classMetadata1;
        List<AggregationProperty>.Enumerator enumerator3;
        IEnumerable<IPropertyMetadata> source;
        IEnumerable<IPropertyMetadata> properties;
        List<int>.Enumerator enumerator4;
        List<IncludedProperty>.Enumerator enumerator5;
        IEntityMetadata entityMetadata1;
        IEnumerable<IPropertyMetadata> propertyMetadatas;
        switch (num1)
        {
          case 1:
            try
            {
label_39:
              if (enumerator3.MoveNext())
                goto label_45;
              else
                goto label_40;
label_5:
              int num2;
              while (true)
              {
                int num3;
                IPropertyMetadata propertyMetadata1;
                PropertyMetadata propertyMetadata2;
                IPropertyMetadata propertyMetadata3;
                string empty;
                IncludedProperty includedProperty;
                AggregationProperty aggregation;
                switch (num2)
                {
                  case 1:
                    try
                    {
label_20:
                      if (enumerator2.MoveNext())
                        goto label_24;
                      else
                        goto label_21;
label_13:
                      int num4;
                      while (true)
                      {
                        IPropertyMetadata propertyMetadata4;
                        ClassMetadata classMetadata2;
                        Guid parentUid;
                        switch (num4)
                        {
                          case 1:
                            if (entityMetadata2 == null)
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 0;
                              continue;
                            }
                            goto label_20;
                          case 2:
                          case 4:
                          case 7:
                            goto label_33;
                          case 3:
                            parentUid = enumerator2.Current;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 6 : 5;
                            continue;
                          case 5:
                            classMetadata2 = (ClassMetadata) MetadataLoader.LoadMetadata(ModelHelper.GetEntityType(UserDefinedListService.mZhagXLtvOSNt22f2d4((object) propertyMetadata4)));
                            num4 = 8;
                            continue;
                          case 6:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            propertyMetadata4 = entityMetadata2.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass9_5.jb4Xf0fLq4FLMbaksGNp(UserDefinedListService.\u003C\u003Ec__DisplayClass9_5.s6WxyefLRlARO2TJ7JUn((object) prop), parentUid)));
                            num4 = 5;
                            continue;
                          case 8:
                            if (classMetadata2 == null)
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 2;
                              continue;
                            }
                            break;
                          case 9:
                            goto label_24;
                          case 10:
                            goto label_20;
                          case 11:
                            entityMetadata2 = classMetadata2 as EntityMetadata;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
                            continue;
                        }
                        empty += propertyMetadata4.Name;
                        num4 = 11;
                      }
label_21:
                      num4 = 7;
                      goto label_13;
label_24:
                      num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                      {
                        num4 = 3;
                        goto label_13;
                      }
                      else
                        goto label_13;
                    }
                    finally
                    {
                      enumerator2.Dispose();
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                  case 2:
                    if (UserDefinedListService.dqqX23LD9MKaMZVABlN(aggregation.OriginalPropertyUid, Guid.Empty))
                    {
                      num2 = 7;
                      continue;
                    }
                    goto case 25;
                  case 3:
                    goto label_175;
                  case 4:
                    aggregation = enumerator3.Current;
                    num2 = 2;
                    continue;
                  case 5:
                    goto label_45;
                  case 6:
label_33:
                    if (entityMetadata2 != null)
                    {
                      num2 = 19;
                      continue;
                    }
                    goto label_39;
                  case 7:
                  case 8:
                  case 10:
                  case 14:
                  case 20:
                    goto label_39;
                  case 9:
                    PropertyMetadata propertyMetadata5 = new PropertyMetadata();
                    UserDefinedListService.nTWd7hL6nYRn78RFmD6((object) propertyMetadata5, UserDefinedListService.oJxDA0LdwuZHQc6Mow3((object) propertyMetadata1));
                    UserDefinedListService.mN2SV9LmdOHVX2ju2Om((object) propertyMetadata5, (object) this.GetAggregationName((string) UserDefinedListService.rbs4B9L4BYm3530SLd2(UserDefinedListService.fFxNmQLAEJlD88S2B9f(-1255365154 ^ 596875508 ^ -1765806086), (object) empty), (string) UserDefinedListService.zqlmiTLwLLi9Jl0hijy((object) propertyMetadata1), UserDefinedListService.KAPY9bLlhSDfdZs87Gt((object) aggregation)));
                    UserDefinedListService.AI0UVyLxlggDZZG3qd2((object) propertyMetadata5, propertyMetadata3.TypeUid);
                    propertyMetadata5.SubTypeUid = UserDefinedListService.mZhagXLtvOSNt22f2d4((object) propertyMetadata3);
                    UserDefinedListService.hTNkrKL0lC24SPqI8x5((object) propertyMetadata5, UserDefinedListService.d23bYXLMdPAlme5Viru((object) propertyMetadata3));
                    propertyMetadata2 = propertyMetadata5;
                    num2 = 30;
                    continue;
                  case 11:
                    UserDefinedListService.hTNkrKL0lC24SPqI8x5((object) propertyMetadata2, UserDefinedListService.d23bYXLMdPAlme5Viru((object) propertyMetadata3));
                    num2 = 12;
                    continue;
                  case 12:
                  case 28:
                    metadata.Properties.Add(propertyMetadata2);
                    num2 = 10;
                    continue;
                  case 13:
                    enumerator2 = includedProperty.PropertyParents.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                    continue;
                  case 15:
                    if (includedProperty == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 5 : 20;
                      continue;
                    }
                    goto case 23;
                  case 16:
                    UserDefinedListService.vmCAHjLyntHQkpbGCnx((object) propertyMetadata2, UserDefinedListService.mZhagXLtvOSNt22f2d4((object) propertyMetadata3));
                    num2 = 11;
                    continue;
                  case 17:
                    if (propertyMetadata3 == null)
                    {
                      num3 = 26;
                      break;
                    }
                    goto case 32;
                  case 18:
                    empty = string.Empty;
                    num3 = 13;
                    break;
                  case 19:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    propertyMetadata1 = entityMetadata2.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass9_4.HOOodMfLuyk6gGjsdbll(prop.PropertyUid, UserDefinedListService.\u003C\u003Ec__DisplayClass9_4.TgwV39fLZpmOrmlhMpfJ((object) includedProperty))));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 22 : 15;
                    continue;
                  case 21:
                    UserDefinedListService.AI0UVyLxlggDZZG3qd2((object) propertyMetadata2, UserDefinedListService.WG5jVyLri4qaFgx39xi((object) propertyMetadata3));
                    num2 = 16;
                    continue;
                  case 22:
                    if (propertyMetadata1 == null)
                    {
                      num2 = 8;
                      continue;
                    }
                    goto case 9;
                  case 23:
                    if (classMetadata1 is EntityMetadata entityMetadata2)
                    {
                      num2 = 18;
                      continue;
                    }
                    goto label_39;
                  case 24:
                    propertyMetadata2 = (PropertyMetadata) null;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 12 : 17;
                    continue;
                  case 25:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    propertyMetadata3 = source.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => UserDefinedListService.\u003C\u003Ec__DisplayClass9_3.fyLE6LfLED1cWXmjB2Oh(UserDefinedListService.\u003C\u003Ec__DisplayClass9_3.j0EmfcfLG8GhfhLhDEWO((object) p), aggregation.OriginalPropertyUid)));
                    num2 = 24;
                    continue;
                  case 26:
                    num2 = 31;
                    continue;
                  case 27:
                    UserDefinedListService.AI0UVyLxlggDZZG3qd2((object) propertyMetadata2, Int32Descriptor.UID);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                    continue;
                  case 29:
                    if (UserDefinedListService.KAPY9bLlhSDfdZs87Gt((object) aggregation) == AggregationType.Count)
                    {
                      num2 = 27;
                      continue;
                    }
                    goto case 21;
                  case 30:
                    metadata.Properties.Add(propertyMetadata2);
                    num2 = 14;
                    continue;
                  case 31:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    includedProperty = userDefinedListInfo.IncludedProperties.FirstOrDefault<IncludedProperty>((Func<IncludedProperty, bool>) (ip => UserDefinedListService.\u003C\u003Ec__DisplayClass9_3.fyLE6LfLED1cWXmjB2Oh(UserDefinedListService.\u003C\u003Ec__DisplayClass9_3.AEIX8PfLfPJxhAVfBsPj((object) ip), aggregation.OriginalPropertyUid)));
                    num2 = 15;
                    continue;
                  case 32:
                    PropertyMetadata propertyMetadata6 = new PropertyMetadata();
                    propertyMetadata6.Uid = UserDefinedListService.bBxgn6L9i0fQVvww6tM((object) aggregation);
                    propertyMetadata6.Name = this.GetAggregationName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542741683), (string) UserDefinedListService.zqlmiTLwLLi9Jl0hijy((object) propertyMetadata3), UserDefinedListService.KAPY9bLlhSDfdZs87Gt((object) aggregation));
                    propertyMetadata2 = propertyMetadata6;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 9 : 29;
                    continue;
                  default:
                    UserDefinedListService.hTNkrKL0lC24SPqI8x5((object) propertyMetadata2, (object) new Int32Settings());
                    num3 = 28;
                    break;
                }
                num2 = num3;
              }
label_40:
              num2 = 3;
              goto label_5;
label_45:
              num2 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
              {
                num2 = 0;
                goto label_5;
              }
              else
                goto label_5;
            }
            finally
            {
              enumerator3.Dispose();
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
                num6 = 0;
              switch (num6)
              {
                default:
              }
            }
          case 2:
            if (entityMetadata1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            }
            propertyMetadatas = entityMetadata1.GetPropertiesAndTableParts();
            break;
          case 3:
label_176:
            enumerator3 = userDefinedListInfo.AggregationProperties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            continue;
          case 4:
label_175:
            UserDefinedListService.yH71x9LgMylxw7I3iC0((object) metadata);
            num1 = 12;
            continue;
          case 5:
            try
            {
label_130:
              if (enumerator5.MoveNext())
                goto label_163;
              else
                goto label_131;
label_109:
              int num7;
              while (true)
              {
                int num8;
                IPropertyMetadata propertyMetadata7;
                PropertyMetadata propertyMetadata8;
                string str1;
                string str2;
                List<int> datePartTypes;
                IncludedProperty includedProperty;
                switch (num7)
                {
                  case 1:
                    if (classMetadata1 is EntityMetadata entityMetadata3)
                    {
                      num7 = 11;
                      continue;
                    }
                    goto label_130;
                  case 2:
                    if (UserDefinedListService.AV031dLHIbW5OWVonix((object) datePartTypes) >= 3)
                    {
                      num7 = 16;
                      continue;
                    }
                    goto case 23;
                  case 3:
                  case 9:
                  case 30:
                    goto label_130;
                  case 4:
                  case 21:
                    metadata.Properties.Add(propertyMetadata8);
                    num7 = 9;
                    continue;
                  case 5:
                    PropertyMetadata propertyMetadata9 = new PropertyMetadata();
                    UserDefinedListService.nTWd7hL6nYRn78RFmD6((object) propertyMetadata9, propertyMetadata7.Uid);
                    propertyMetadata8 = propertyMetadata9;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 9 : 25;
                    continue;
                  case 6:
                    enumerator2 = includedProperty.PropertyParents.GetEnumerator();
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 19 : 11;
                    continue;
                  case 7:
                    includedProperty = enumerator5.Current;
                    num7 = 29;
                    continue;
                  case 8:
                  case 16:
                    UserDefinedListService.mN2SV9LmdOHVX2ju2Om((object) propertyMetadata8, (object) this.GetName((string) UserDefinedListService.rbs4B9L4BYm3530SLd2(UserDefinedListService.fFxNmQLAEJlD88S2B9f(-1120607109 - 305487170 ^ -1426106979), (object) str1), (string) UserDefinedListService.zqlmiTLwLLi9Jl0hijy((object) propertyMetadata7)));
                    num7 = 15;
                    continue;
                  case 10:
label_116:
                    if (entityMetadata3 == null)
                    {
                      num7 = 3;
                      continue;
                    }
                    goto case 28;
                  case 11:
                    str1 = string.Empty;
                    num7 = 6;
                    continue;
                  case 12:
                    enumerator4 = datePartTypes.GetEnumerator();
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 3 : 20;
                    continue;
                  case 13:
                    UserDefinedListService.vmCAHjLyntHQkpbGCnx((object) propertyMetadata8, propertyMetadata7.SubTypeUid);
                    num7 = 14;
                    continue;
                  case 14:
                    propertyMetadata8.Settings = (TypeSettings) UserDefinedListService.d23bYXLMdPAlme5Viru((object) propertyMetadata7);
                    num7 = 21;
                    continue;
                  case 15:
                    UserDefinedListService.AI0UVyLxlggDZZG3qd2((object) propertyMetadata8, propertyMetadata7.TypeUid);
                    num8 = 13;
                    break;
                  case 17:
                    UserDefinedListService.hTNkrKL0lC24SPqI8x5((object) propertyMetadata8, (object) new StringSettings());
                    num8 = 26;
                    break;
                  case 18:
                    goto label_2;
                  case 19:
                    try
                    {
label_142:
                      if (enumerator2.MoveNext())
                        goto label_144;
                      else
                        goto label_143;
label_140:
                      IPropertyMetadata propertyMetadata10;
                      ClassMetadata classMetadata3;
                      int num9;
                      Guid parentUid;
                      while (true)
                      {
                        switch (num9)
                        {
                          case 1:
                            parentUid = enumerator2.Current;
                            num9 = 11;
                            continue;
                          case 2:
                          case 5:
                          case 9:
                            goto label_116;
                          case 3:
                            classMetadata3 = (ClassMetadata) MetadataLoader.LoadMetadata(ModelHelper.GetEntityType(UserDefinedListService.mZhagXLtvOSNt22f2d4((object) propertyMetadata10)));
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                            continue;
                          case 4:
                            goto label_142;
                          case 6:
                          case 10:
                            str1 = (string) UserDefinedListService.rbs4B9L4BYm3530SLd2((object) str1, UserDefinedListService.zqlmiTLwLLi9Jl0hijy((object) propertyMetadata10));
                            num9 = 7;
                            continue;
                          case 7:
                            entityMetadata3 = classMetadata3 as EntityMetadata;
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 12 : 9;
                            continue;
                          case 8:
                            goto label_144;
                          case 11:
                            // ISSUE: reference to a compiler-generated method
                            propertyMetadata10 = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass9_1.m7ceLyfYYNocJeUg6g0b((object) prop) == parentUid));
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 3;
                            continue;
                          case 12:
                            if (entityMetadata3 == null)
                            {
                              num9 = 2;
                              continue;
                            }
                            goto label_142;
                          default:
                            if (classMetadata3 != null)
                            {
                              num9 = 6;
                              continue;
                            }
                            goto label_116;
                        }
                      }
label_143:
                      num9 = 9;
                      goto label_140;
label_144:
                      num9 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
                      {
                        num9 = 1;
                        goto label_140;
                      }
                      else
                        goto label_140;
                    }
                    finally
                    {
                      enumerator2.Dispose();
                      int num10 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                        num10 = 0;
                      switch (num10)
                      {
                        default:
                      }
                    }
                  case 20:
                    try
                    {
label_123:
                      if (enumerator4.MoveNext())
                        goto label_121;
                      else
                        goto label_124;
label_120:
                      int current;
                      int num11;
                      while (true)
                      {
                        switch (num11)
                        {
                          case 1:
                            str2 = (string) UserDefinedListService.jjG8uRL7CViqg5tDhjc(UserDefinedListService.fFxNmQLAEJlD88S2B9f(1461625753 ^ 1461641627), (object) str2, (object) (DatePartType) current);
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                            continue;
                          case 2:
                            goto label_133;
                          case 3:
                            goto label_121;
                          default:
                            goto label_123;
                        }
                      }
label_121:
                      current = enumerator4.Current;
                      num11 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                      {
                        num11 = 1;
                        goto label_120;
                      }
                      else
                        goto label_120;
label_124:
                      num11 = 2;
                      goto label_120;
                    }
                    finally
                    {
                      enumerator4.Dispose();
                      int num12 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
                        num12 = 0;
                      switch (num12)
                      {
                        default:
                      }
                    }
                  case 22:
                    goto label_163;
                  case 23:
                    str2 = string.Empty;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 24 : 17;
                    continue;
                  case 24:
                    string empty = string.Empty;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 9 : 12;
                    continue;
                  case 25:
                    datePartTypes = includedProperty.DatePartTypes;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
                    continue;
                  case 26:
                    UserDefinedListService.mN2SV9LmdOHVX2ju2Om((object) propertyMetadata8, (object) this.GetName((string) UserDefinedListService.fFxNmQLAEJlD88S2B9f(-345420348 ^ -345399456) + str1 + str2, (string) UserDefinedListService.zqlmiTLwLLi9Jl0hijy((object) propertyMetadata7)));
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 4;
                    continue;
                  case 27:
                    if (propertyMetadata7 == null)
                    {
                      num7 = 30;
                      continue;
                    }
                    goto case 5;
                  case 28:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    propertyMetadata7 = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass9_0.xfkHN2fYrYbh0elpGFSb(UserDefinedListService.\u003C\u003Ec__DisplayClass9_0.t1vNAEfYlv8LR0WSdX4C((object) prop), includedProperty.OriginalPropertyUid)));
                    num7 = 27;
                    continue;
                  case 29:
                    if (!UserDefinedListService.dqqX23LD9MKaMZVABlN(includedProperty.OriginalPropertyUid, Guid.Empty))
                    {
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
                      continue;
                    }
                    goto label_130;
                  default:
label_133:
                    UserDefinedListService.AI0UVyLxlggDZZG3qd2((object) propertyMetadata8, StringDescriptor.UID);
                    num7 = 17;
                    continue;
                }
                num7 = num8;
              }
label_131:
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 18 : 0;
              goto label_109;
label_163:
              num7 = 7;
              goto label_109;
            }
            finally
            {
              enumerator5.Dispose();
              int num13 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                num13 = 0;
              switch (num13)
              {
                default:
              }
            }
          case 6:
            goto label_181;
          case 7:
            enumerator5 = userDefinedListInfo.IncludedProperties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 5 : 0;
            continue;
          case 8:
            propertyMetadatas = properties;
            break;
          case 9:
label_2:
            enumerator1 = userDefinedListInfo.GroupingProperties.GetEnumerator();
            num1 = 13;
            continue;
          case 10:
            if (!UserDefinedListService.dqqX23LD9MKaMZVABlN(UserDefinedListService.BjNmPJLaN7aqXj2y2am((object) userDefinedListInfo), Guid.Empty))
            {
              classMetadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(ModelHelper.GetEntityType(UserDefinedListService.BjNmPJLaN7aqXj2y2am((object) userDefinedListInfo)));
              num1 = 14;
              continue;
            }
            num1 = 6;
            continue;
          case 11:
            metadata = new ClassMetadata();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 10 : 5;
            continue;
          case 12:
            goto label_174;
          case 13:
            try
            {
label_72:
              if (enumerator1.MoveNext())
                goto label_86;
              else
                goto label_73;
label_67:
              int num14;
              while (true)
              {
                int num15;
                IPropertyMetadata propertyMetadata11;
                PropertyMetadata propertyMetadata12;
                List<int> datePartTypes;
                string str;
                GroupingProperty grouping;
                switch (num14)
                {
                  case 1:
                    datePartTypes = grouping.DatePartTypes;
                    num14 = 18;
                    continue;
                  case 2:
                    goto label_86;
                  case 3:
                  case 10:
                    UserDefinedListService.AI0UVyLxlggDZZG3qd2((object) propertyMetadata12, propertyMetadata11.TypeUid);
                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 12 : 4;
                    continue;
                  case 4:
                    try
                    {
label_93:
                      if (enumerator4.MoveNext())
                        goto label_96;
                      else
                        goto label_94;
label_92:
                      int current;
                      int num16;
                      while (true)
                      {
                        switch (num16)
                        {
                          case 1:
                            goto label_69;
                          case 2:
                            goto label_96;
                          case 3:
                            goto label_93;
                          default:
                            str = (string) UserDefinedListService.jjG8uRL7CViqg5tDhjc((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234316526), (object) str, (object) (DatePartType) current);
                            num16 = 3;
                            continue;
                        }
                      }
label_94:
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                      goto label_92;
label_96:
                      current = enumerator4.Current;
                      num16 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                      {
                        num16 = 0;
                        goto label_92;
                      }
                      else
                        goto label_92;
                    }
                    finally
                    {
                      enumerator4.Dispose();
                      int num17 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
                        num17 = 0;
                      switch (num17)
                      {
                        default:
                      }
                    }
                  case 5:
                    grouping = enumerator1.Current;
                    num14 = 20;
                    continue;
                  case 6:
                  case 15:
                    goto label_72;
                  case 7:
                    UserDefinedListService.hTNkrKL0lC24SPqI8x5((object) propertyMetadata12, UserDefinedListService.d23bYXLMdPAlme5Viru((object) propertyMetadata11));
                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                    continue;
                  case 8:
                    PropertyMetadata propertyMetadata13 = new PropertyMetadata();
                    UserDefinedListService.nTWd7hL6nYRn78RFmD6((object) propertyMetadata13, UserDefinedListService.bBxgn6L9i0fQVvww6tM((object) grouping));
                    propertyMetadata12 = propertyMetadata13;
                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    propertyMetadata11 = source.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => UserDefinedListService.\u003C\u003Ec__DisplayClass9_2.Oj1JyffLBJjTFu9jmlUB(UserDefinedListService.\u003C\u003Ec__DisplayClass9_2.Qn3AJrfYz4RVn0TuUUlK((object) p), UserDefinedListService.\u003C\u003Ec__DisplayClass9_2.w5QWDhfLFEIghBxq5UMc((object) grouping))));
                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 13 : 1;
                    continue;
                  case 11:
label_69:
                    UserDefinedListService.AI0UVyLxlggDZZG3qd2((object) propertyMetadata12, StringDescriptor.UID);
                    num14 = 16;
                    continue;
                  case 12:
                    UserDefinedListService.vmCAHjLyntHQkpbGCnx((object) propertyMetadata12, UserDefinedListService.mZhagXLtvOSNt22f2d4((object) propertyMetadata11));
                    num15 = 7;
                    break;
                  case 13:
                    if (propertyMetadata11 != null)
                    {
                      num14 = 8;
                      continue;
                    }
                    goto label_72;
                  case 14:
                  case 19:
                    metadata.Properties.Add(propertyMetadata12);
                    num15 = 6;
                    break;
                  case 16:
                    UserDefinedListService.hTNkrKL0lC24SPqI8x5((object) propertyMetadata12, (object) new StringSettings());
                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 15 : 17;
                    continue;
                  case 17:
                    UserDefinedListService.mN2SV9LmdOHVX2ju2Om((object) propertyMetadata12, (object) this.GetName((string) UserDefinedListService.rbs4B9L4BYm3530SLd2(UserDefinedListService.fFxNmQLAEJlD88S2B9f(-1839087379 - 334718690 ^ 2121173193), (object) str), propertyMetadata11.Name));
                    num14 = 14;
                    continue;
                  case 18:
                    if (UserDefinedListService.AV031dLHIbW5OWVonix((object) datePartTypes) >= 3)
                    {
                      num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 10 : 9;
                      continue;
                    }
                    goto case 21;
                  case 20:
                    if (UserDefinedListService.dqqX23LD9MKaMZVABlN(UserDefinedListService.xNAYNyLJr08A25GN1KT((object) grouping), Guid.Empty))
                    {
                      num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 15 : 1;
                      continue;
                    }
                    goto case 9;
                  case 21:
                    str = string.Empty;
                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 13 : 22;
                    continue;
                  case 22:
                    enumerator4 = datePartTypes.GetEnumerator();
                    num15 = 4;
                    break;
                  case 23:
                    goto label_176;
                  default:
                    propertyMetadata12.Name = this.GetName((string) UserDefinedListService.fFxNmQLAEJlD88S2B9f(-2106517564 ^ -2106473210), (string) UserDefinedListService.zqlmiTLwLLi9Jl0hijy((object) propertyMetadata11));
                    num14 = 19;
                    continue;
                }
                num14 = num15;
              }
label_73:
              num14 = 23;
              goto label_67;
label_86:
              num14 = 5;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
              {
                num14 = 1;
                goto label_67;
              }
              else
                goto label_67;
            }
            finally
            {
              enumerator1.Dispose();
              int num18 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                num18 = 0;
              switch (num18)
              {
                default:
              }
            }
          case 14:
            entityMetadata1 = classMetadata1 as IEntityMetadata;
            num1 = 2;
            continue;
          default:
            properties = (IEnumerable<IPropertyMetadata>) classMetadata1.Properties;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 8 : 7;
            continue;
        }
        source = propertyMetadatas;
        num1 = 7;
      }
label_174:
      return metadata;
label_181:
      return metadata;
    }

    private string GetName(string prefix, string propertyName) => (string) UserDefinedListService.pxvgXUL5B3r9gWbx0b1((object) prefix, UserDefinedListService.fFxNmQLAEJlD88S2B9f(44884861 ^ 44890553), (object) propertyName);

    private string GetAggregationName(
      string prefix,
      string propertyName,
      AggregationType aggregationType)
    {
      int num = 1;
      string name;
      while (true)
      {
        switch (num)
        {
          case 1:
            name = this.GetName(prefix, propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return string.Format((string) UserDefinedListService.fFxNmQLAEJlD88S2B9f(572119659 - -337058038 ^ 909123979), (object) name, (object) aggregationType);
    }

    private IEnumerable<object> GetEntities(UserDefinedListInfo preparationDataInfo)
    {
      if (preparationDataInfo.SubTypeUid == Guid.Empty)
        return Enumerable.Empty<object>();
      System.Type entityType1 = ModelHelper.GetEntityType(preparationDataInfo.SubTypeUid);
      IEntityManager entityManager = ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(entityType1));
      if (entityManager == null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727378508), (object) entityType1), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751177278));
      IEntityFilter filter = (IEntityFilter) InterfaceActivator.Create(ModelHelper.GetEntityFilterType(entityType1));
      filter.Query = preparationDataInfo.ComputedEqlQuery;
      string alias1 = (string) null;
      if (entityManager is IEntityManagerAlias entityManagerAlias1)
        alias1 = entityManagerAlias1.GetDefaultCriteriaAlias();
      ICriteria criteria = this.CreateCriteria(FetchOptions.All, entityType1, alias1, filter);
      entityManager.SetupFilter(criteria, filter);
      ProjectionList projectionList = Projections.ProjectionList();
      ClassMetadata classMetadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(entityType1);
      IEnumerable<IPropertyMetadata> source = classMetadata1 is IEntityMetadata entityMetadata1 ? entityMetadata1.GetPropertiesAndTableParts() : (IEnumerable<IPropertyMetadata>) classMetadata1.Properties;
      Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
      foreach (IncludedProperty includedProperty1 in preparationDataInfo.IncludedProperties)
      {
        IncludedProperty includedProperty = includedProperty1;
        if (!(includedProperty.OriginalPropertyUid == Guid.Empty) && classMetadata1 is EntityMetadata entityMetadata3)
        {
          System.Type type = entityType1;
          string empty = string.Empty;
          string defaultAlias = (string) null;
          if (entityManager is IEntityManagerAlias entityManagerAlias2)
            defaultAlias = entityManagerAlias2.GetDefaultCriteriaAlias();
          foreach (Guid propertyParent in includedProperty.PropertyParents)
          {
            Guid parentUid = propertyParent;
            ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(type));
            // ISSUE: reference to a compiler-generated method
            IPropertyMetadata propertyMetadata = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass13_1.nfbDsUfL1eIki3Qw0Q4i((object) prop) == parentUid));
            string alias2 = this.CreateAlias(defaultAlias, propertyMetadata.Name);
            string name = propertyMetadata.Name;
            criteria.GetOrCreateAlias(alias2, alias2, JoinType.LeftOuterJoin, ref name);
            defaultAlias = propertyMetadata.Name;
            System.Type entityType2 = ModelHelper.GetEntityType(propertyMetadata.SubTypeUid);
            ClassMetadata classMetadata2 = (ClassMetadata) MetadataLoader.LoadMetadata(entityType2);
            if (classMetadata2 != null)
            {
              empty += propertyMetadata.Name;
              type = entityType2;
              if (!(classMetadata2 is EntityMetadata entityMetadata3))
                break;
            }
            else
              break;
          }
          if (entityMetadata3 != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            IPropertyMetadata propertyMetadata = entityMetadata3.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass13_0.wUaY8cfLnKJuARPhtvY2((object) prop) == UserDefinedListService.\u003C\u003Ec__DisplayClass13_0.Pb2OG8fLOkd7q2wnhw30((object) includedProperty)));
            string alias3 = this.CreateAlias(defaultAlias, propertyMetadata.Name);
            List<int> datePartTypes = includedProperty.DatePartTypes;
            if (propertyMetadata.Settings is DateTimeSettings && datePartTypes.Count < 3)
            {
              List<string> stringList = new List<string>();
              string str = string.Empty;
              foreach (DatePartType datePartType in datePartTypes)
              {
                string functionName = datePartType.ToString();
                string name = this.GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3279170) + empty + functionName, propertyMetadata.Name);
                projectionList.Add((IProjection) Projections.GroupProperty(Projections.SqlFunction(functionName, (IType) NHibernateUtil.Date, (IProjection) Projections.GroupProperty(alias3))), name);
                str = str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886644405) + functionName;
                stringList.Add(name);
              }
              string name1 = this.GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669351247) + empty + str, propertyMetadata.Name);
              dictionary.Add(name1, stringList);
            }
            else
              projectionList.Add(Projections.GroupProperty(alias3).As(this.GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488861329) + empty, propertyMetadata.Name)));
          }
        }
      }
      foreach (GroupingProperty groupingProperty in preparationDataInfo.GroupingProperties)
      {
        GroupingProperty grouping = groupingProperty;
        if (!(grouping.OriginalPropertyUid == Guid.Empty))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          IPropertyMetadata propertyMetadata = source.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => UserDefinedListService.\u003C\u003Ec__DisplayClass13_2.Ixl9bnfLwLpQfg3pWc27(UserDefinedListService.\u003C\u003Ec__DisplayClass13_2.tdZTBsfLDQgiZ8fCELX7((object) p), UserDefinedListService.\u003C\u003Ec__DisplayClass13_2.nhjgWtfLtm34ce4hurcg((object) grouping))));
          if (propertyMetadata != null)
          {
            string defaultAlias = (string) null;
            if (entityManager is IEntityManagerAlias entityManagerAlias3)
              defaultAlias = entityManagerAlias3.GetDefaultCriteriaAlias();
            string alias4 = this.CreateAlias(defaultAlias, propertyMetadata.Name);
            List<int> datePartTypes = grouping.DatePartTypes;
            if (propertyMetadata.Settings is DateTimeSettings && datePartTypes.Count < 3)
            {
              List<string> stringList = new List<string>();
              string str = string.Empty;
              foreach (DatePartType datePartType in datePartTypes)
              {
                string functionName = datePartType.ToString();
                string name = this.GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874024087) + functionName, propertyMetadata.Name);
                projectionList.Add((IProjection) Projections.GroupProperty(Projections.SqlFunction(functionName, (IType) NHibernateUtil.Date, (IProjection) Projections.GroupProperty(alias4))), name);
                str = str + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113860295) + functionName;
                stringList.Add(name);
              }
              string name2 = this.GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633526121) + str, propertyMetadata.Name);
              dictionary.Add(name2, stringList);
            }
            else
              projectionList.Add(Projections.GroupProperty(alias4).As(this.GetName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77706957), propertyMetadata.Name)));
          }
        }
      }
      foreach (AggregationProperty aggregationProperty in preparationDataInfo.AggregationProperties)
      {
        AggregationProperty aggregation = aggregationProperty;
        if (!(aggregation.OriginalPropertyUid == Guid.Empty))
        {
          string str1 = string.Empty;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          IPropertyMetadata propertyMetadata1 = source.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => UserDefinedListService.\u003C\u003Ec__DisplayClass13_3.TKS7SKfL74rNd3XsdwI1(UserDefinedListService.\u003C\u003Ec__DisplayClass13_3.R0K3xHfLAB0ukhIC6IR5((object) p), aggregation.OriginalPropertyUid)));
          string str2 = string.Empty;
          string empty = string.Empty;
          if (propertyMetadata1 == null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            IncludedProperty includedProperty = preparationDataInfo.IncludedProperties.FirstOrDefault<IncludedProperty>((Func<IncludedProperty, bool>) (ip => UserDefinedListService.\u003C\u003Ec__DisplayClass13_3.TKS7SKfL74rNd3XsdwI1(UserDefinedListService.\u003C\u003Ec__DisplayClass13_3.OyVflifLxJDtIC1Fl30L((object) ip), UserDefinedListService.\u003C\u003Ec__DisplayClass13_3.OyVflifLxJDtIC1Fl30L((object) aggregation))));
            if (includedProperty != null)
            {
              if (classMetadata1 is EntityMetadata entityMetadata5)
              {
                System.Type type = entityType1;
                str1 = (string) null;
                if (entityManager is IEntityManagerAlias entityManagerAlias4)
                  str1 = entityManagerAlias4.GetDefaultCriteriaAlias();
                foreach (Guid propertyParent in includedProperty.PropertyParents)
                {
                  Guid parentUid = propertyParent;
                  ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(type));
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  IPropertyMetadata propertyMetadata2 = entityMetadata5.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass13_5.Tl2R7QfLYRU8K4embk0O(UserDefinedListService.\u003C\u003Ec__DisplayClass13_5.jXq6DAfLj6j08VtIFnhW((object) prop), parentUid)));
                  str1 = propertyMetadata2.Name;
                  System.Type entityType3 = ModelHelper.GetEntityType(propertyMetadata2.SubTypeUid);
                  ClassMetadata classMetadata3 = (ClassMetadata) MetadataLoader.LoadMetadata(entityType3);
                  if (classMetadata3 != null)
                  {
                    empty += propertyMetadata2.Name;
                    type = entityType3;
                    if (!(classMetadata3 is EntityMetadata entityMetadata5))
                      break;
                  }
                  else
                    break;
                }
                if (entityMetadata5 != null)
                {
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  str2 = entityMetadata5.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (prop => UserDefinedListService.\u003C\u003Ec__DisplayClass13_4.vvV5UefLdGdMd4KlBy06(UserDefinedListService.\u003C\u003Ec__DisplayClass13_4.eqaAatfLJQHwQCwKsiQT((object) prop), UserDefinedListService.\u003C\u003Ec__DisplayClass13_4.HPE6aHfL9y8YHhIBb0pj((object) includedProperty)))).Name;
                  str1 = this.CreateAlias(str1, str2);
                }
              }
            }
            else
              continue;
          }
          else
          {
            string defaultAlias = (string) null;
            if (entityManager is IEntityManagerAlias entityManagerAlias5)
              entityManagerAlias5.GetDefaultCriteriaAlias();
            str1 = this.CreateAlias(defaultAlias, propertyMetadata1.Name);
            str2 = propertyMetadata1.Name;
          }
          if (!string.IsNullOrEmpty(str1))
          {
            string aggregationName = this.GetAggregationName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521220464) + empty, str2, aggregation.AggregationType);
            switch (aggregation.AggregationType)
            {
              case AggregationType.Min:
                projectionList.Add(Projections.Min(str1).As(aggregationName));
                continue;
              case AggregationType.Max:
                projectionList.Add(Projections.Max(str1).As(aggregationName));
                continue;
              case AggregationType.Sum:
                projectionList.Add(Projections.Sum(str1).As(aggregationName));
                continue;
              case AggregationType.Avg:
                projectionList.Add(Projections.Avg(str1).As(aggregationName));
                continue;
              case AggregationType.Count:
                projectionList.Add(Projections.Count(str1).As(aggregationName));
                continue;
              default:
                continue;
            }
          }
        }
      }
      criteria.SetProjection((IProjection) projectionList);
      criteria.SetResultTransformer((IResultTransformer) new UserDefinedListService.DictionaryResultTransformer());
      List<object> list = criteria.List().CastToListOrNull<object>().ToList<object>();
      if (dictionary.Any<KeyValuePair<string, List<string>>>())
        this.MergeDates(list, dictionary);
      return (IEnumerable<object>) list;
    }

    /// <summary>Объединить группировки по частям даты в одну дату</summary>
    /// <param name="entities">Результат запроса</param>
    /// <param name="dateTimeGroups">Имена составных частей даты</param>
    private void MergeDates(List<object> entities, Dictionary<string, List<string>> dateTimeGroups)
    {
      foreach (object entity in entities)
      {
        foreach (KeyValuePair<string, List<string>> dateTimeGroup in dateTimeGroups)
        {
          UDLDynamicObject udlDynamicObject = entity as UDLDynamicObject;
          string str1 = string.Empty;
          foreach (string propertyName in dateTimeGroup.Value)
          {
            object obj = udlDynamicObject.TryGetValue(propertyName);
            if (obj != null)
            {
              string str2 = propertyName;
              DatePartType datePartType = DatePartType.Day;
              string str3 = datePartType.ToString();
              int num;
              if (!str2.Contains(str3))
              {
                string str4 = propertyName;
                datePartType = DatePartType.Month;
                string str5 = datePartType.ToString();
                num = str4.Contains(str5) ? 1 : 0;
              }
              else
                num = 1;
              bool flag = num != 0;
              string str6 = ((int) obj).ToString(flag ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998560074) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638455915));
              str1 = string.IsNullOrEmpty(str1) ? str6 : str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883345652) + str6;
              udlDynamicObject.RemoveValue(propertyName);
            }
          }
          udlDynamicObject.AddMember(dateTimeGroup.Key, (object) str1);
        }
      }
    }

    /// <summary>Создать критерий выборки NHibernate</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="alias">Псевдоним</param>
    /// <param name="filter">Фильтр</param>
    /// <returns>Критерий</returns>
    protected internal ICriteria CreateCriteria(
      FetchOptions fetchOptions,
      System.Type type,
      string alias = null,
      IEntityFilter filter = null)
    {
      int num1 = 5;
      ICriteria criteria;
      IEnumerator<IEntityManagerBehavior> enumerator;
      while (true)
      {
        int num2 = num1;
        System.Type entityType;
        while (true)
        {
          switch (num2)
          {
            case 1:
              enumerator = this.behaviors.Value.GetEnumerator();
              num2 = 8;
              continue;
            case 2:
              if (criteria != null)
              {
                num2 = 10;
                continue;
              }
              goto label_26;
            case 3:
              UserDefinedListService.UIdL1ZLsSCP9f2gU3m9((object) this, (object) criteria, (object) fetchOptions, entityType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
              continue;
            case 4:
              if (this.sessionProvider == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 9;
                continue;
              }
              goto case 7;
            case 5:
              entityType = type;
              num2 = 4;
              continue;
            case 6:
              goto label_26;
            case 7:
              criteria = (ICriteria) UserDefinedListService.U19i0ALYe6RU9kUlf7k(UserDefinedListService.yjsMMuLjVaLURsqmgkg((object) this.sessionProvider, (object) ""), entityType, (object) alias);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 1;
              continue;
            case 8:
              goto label_13;
            case 9:
              goto label_27;
            case 10:
              UserDefinedListService.zXyAYoLLDTV1UC4olDk((object) criteria, (object) CriteriaSpecification.DistinctRootEntity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            default:
              if (!UserDefinedListService.NkSowmLUs3bQXCy2AQg((object) fetchOptions, (object) null))
                goto case 1;
              else
                goto label_7;
          }
        }
label_7:
        num1 = 3;
      }
label_13:
      try
      {
label_17:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_18;
label_14:
        int num3;
        switch (num3)
        {
          case 1:
            goto label_17;
          case 2:
            break;
          default:
            goto label_26;
        }
label_15:
        UserDefinedListService.hSA28YLcKM0J3SIpC8x((object) enumerator.Current, (object) criteria, (object) filter);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        {
          num3 = 1;
          goto label_14;
        }
        else
          goto label_14;
label_18:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
        goto label_14;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_24;
              default:
                UserDefinedListService.R1ZOGxLzc1yw3j52X0q((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_24:;
      }
label_26:
      return criteria;
label_27:
      return (ICriteria) null;
    }

    /// <summary>
    /// Применить параметры выборки к указанному типу сущности
    /// </summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="entityType">Тип сущности</param>
    protected virtual void SetupFetchOptions(
      ICriteria criteria,
      FetchOptions fetchOptions,
      System.Type entityType)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          List<string> stringList1;
          List<string> stringList2;
          EntityMetadata metadata;
          SelectMode selectMode;
          List<string> stringList3;
          int num3;
          switch (num2)
          {
            case 1:
              stringList3 = fetchOptions.FetchRelations;
              if (stringList3 == null)
                goto label_22;
              else
                break;
            case 2:
              if (!fetchOptions.UseProjections)
              {
                num2 = 16;
                continue;
              }
              goto case 9;
            case 3:
              stringList1 = new List<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
              continue;
            case 4:
              if (FetchOptionsBuilder.IsCanOptimaze(criteria, (IEnumerable<string>) stringList1.Union<string>((IEnumerable<string>) stringList2).ToList<string>(), metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 2;
                continue;
              }
              goto label_19;
            case 5:
              stringList3 = new List<string>();
              break;
            case 6:
            case 16:
              num3 = 1;
              goto label_26;
            case 7:
              num3 = 6;
              goto label_26;
            case 8:
              FetchOptionsBuilder.ResolveFetchColumns(criteria, (IEnumerable<string>) stringList1.ToList<string>(), selectMode, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            case 9:
              if (fetchOptions.UsePartialFetching)
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            case 10:
              goto label_21;
            case 11:
              if (UserDefinedListService.fsOsgRUBSrXMlxvMn6l((object) fetchOptions) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 13 : 13;
                continue;
              }
              goto case 15;
            case 12:
              criteria = (ICriteria) UserDefinedListService.eLM408UFJ1oxuPIAYuM((object) criteria, fetchOptions.FirstResult);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 5 : 11;
              continue;
            case 13:
              criteria = (ICriteria) UserDefinedListService.x5BNDVUWvPHqFhn1vkZ((object) criteria, fetchOptions.MaxResults);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 13 : 15;
              continue;
            case 14:
              metadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
              num2 = 4;
              continue;
            case 15:
              this.SetupSortOptions(criteria, fetchOptions, entityType);
              num2 = 3;
              continue;
            default:
              FetchOptionsBuilder.ResolveFetchColumns(criteria, (IEnumerable<string>) stringList2.ToList<string>(), SelectMode.Fetch);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 10 : 9;
              continue;
          }
          stringList2 = stringList3;
          num2 = 14;
          continue;
label_26:
          selectMode = (SelectMode) num3;
          num2 = 8;
        }
label_22:
        num1 = 5;
      }
label_21:
      return;
label_19:;
    }

    /// <summary>Установить критерии сортировки</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="fetchOptions">Опции сортировки</param>
    /// <param name="entityType">Тип сущности</param>
    protected void SetupSortOptions(ICriteria criteria, FetchOptions fetchOptions, System.Type entityType)
    {
      int num = 10;
      while (true)
      {
        PropertyMetadata propertyMetadata1;
        PropertyMetadata propertyMetadata2;
        EntityMetadata metadata;
        switch (num)
        {
          case 0:
            goto label_27;
          case 1:
          case 3:
          case 11:
          case 17:
            propertyMetadata2 = (PropertyMetadata) null;
            break;
          case 2:
            UserDefinedListService.HhswRwU8yKxdCeHTkRr((object) criteria, UserDefinedListService.AVP8fYUvuHrjMPlf1sm(UserDefinedListService.SHWcK7UClGcKgX0QrNS((object) propertyMetadata1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 4:
            MetadataLoader.GetChildProperties((ClassMetadata) metadata);
            num = 13;
            continue;
          case 5:
            if (UserDefinedListService.VE5sLyUGx5TZeVuhBoD(UserDefinedListService.cX3TeoUh66SB6VSiUNh((object) metadata), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 12 : 10;
              continue;
            }
            goto case 1;
          case 6:
            if (!metadata.Hierarchical)
            {
              num = 11;
              continue;
            }
            goto case 14;
          case 7:
            if (propertyMetadata1 == null)
            {
              num = 18;
              continue;
            }
            goto case 19;
          case 8:
            if (!UserDefinedListService.kPNc6CUQCCyTstv1eFf(UserDefinedListService.DWkxc4UfLlLPV5DjDrK((object) fetchOptions), (object) propertyMetadata1.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 20 : 19;
              continue;
            }
            goto case 16;
          case 9:
            UserDefinedListService.uJWcFOUoCEdh4LfeNyt((object) entityType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889505324));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 15 : 12;
            continue;
          case 10:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 9 : 3;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            propertyMetadata2 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => UserDefinedListService.\u003C\u003Ec__DisplayClass17_0.Ak3gh6fUFD4t1FSkNi3W(UserDefinedListService.\u003C\u003Ec__DisplayClass17_0.sn4WQDfLzXOsymn1wnt2((object) p), metadata.IsGroupPropertyUid)));
            break;
          case 13:
            if (metadata == null)
            {
              num = 17;
              continue;
            }
            goto case 6;
          case 14:
            if (UserDefinedListService.J0fgt0UbjV0Nh8KaQmR((object) metadata) != HierarchyType.GroupAndElements)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 15:
            metadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 4;
            continue;
          case 16:
            if (!fetchOptions.DisableDefaultGroupSorting)
            {
              num = 2;
              continue;
            }
            goto label_23;
          case 18:
            goto label_16;
          case 19:
            if (!UserDefinedListService.d9bZJhUE2g2pNC7Qs5v((object) fetchOptions, (object) null))
            {
              num = 8;
              continue;
            }
            goto case 2;
          case 20:
            goto label_10;
          default:
            goto label_9;
        }
        propertyMetadata1 = propertyMetadata2;
        num = 7;
      }
label_27:
      return;
label_16:
      return;
label_10:
      return;
label_9:
      return;
label_23:;
    }

    private string CreateAlias(string defaultAlias, string property)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (UserDefinedListService.GlSSBOUZJ4EUa9F3ld6((object) defaultAlias))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) UserDefinedListService.jjG8uRL7CViqg5tDhjc((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583761162), (object) defaultAlias, (object) property);
label_3:
      return property;
    }

    internal static void POVZIPLNrdF5mD4OGJI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static System.Type A1DnkJL31cuZUAeXSts([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object mHqXrBLpHigmZ7RuxCs(System.Type componentType) => (object) Logger.GetLogger(componentType);

    internal static bool ybtgBSLPhGxlg2x7Jiu() => UserDefinedListService.gT23erLe4xq53Drsw4N == null;

    internal static UserDefinedListService cRx3tgL14iWhRvS313b() => UserDefinedListService.gT23erLe4xq53Drsw4N;

    internal static Guid BjNmPJLaN7aqXj2y2am([In] object obj0) => ((UserDefinedListInfo) obj0).SubTypeUid;

    internal static bool dqqX23LD9MKaMZVABlN([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid mZhagXLtvOSNt22f2d4([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static object zqlmiTLwLLi9Jl0hijy([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static object rbs4B9L4BYm3530SLd2([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void nTWd7hL6nYRn78RFmD6([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static int AV031dLHIbW5OWVonix([In] object obj0) => ((List<int>) obj0).Count;

    internal static object fFxNmQLAEJlD88S2B9f(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jjG8uRL7CViqg5tDhjc([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void AI0UVyLxlggDZZG3qd2([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static void hTNkrKL0lC24SPqI8x5([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static void mN2SV9LmdOHVX2ju2Om([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static void vmCAHjLyntHQkpbGCnx([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static object d23bYXLMdPAlme5Viru([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;

    internal static Guid xNAYNyLJr08A25GN1KT([In] object obj0) => ((UserDefinedListPropertyBase) obj0).OriginalPropertyUid;

    internal static Guid bBxgn6L9i0fQVvww6tM([In] object obj0) => ((UserDefinedListPropertyBase) obj0).Uid;

    internal static Guid oJxDA0LdwuZHQc6Mow3([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static AggregationType KAPY9bLlhSDfdZs87Gt([In] object obj0) => ((AggregationProperty) obj0).AggregationType;

    internal static Guid WG5jVyLri4qaFgx39xi([In] object obj0) => ((IPropertyMetadata) obj0).TypeUid;

    internal static void yH71x9LgMylxw7I3iC0([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static object pxvgXUL5B3r9gWbx0b1([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object yjsMMuLjVaLURsqmgkg([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object U19i0ALYe6RU9kUlf7k([In] object obj0, [In] System.Type obj1, [In] object obj2) => (object) ((ISession) obj0).CreateCriteria(obj1, (string) obj2);

    internal static object zXyAYoLLDTV1UC4olDk([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetResultTransformer((IResultTransformer) obj1);

    internal static bool NkSowmLUs3bQXCy2AQg([In] object obj0, [In] object obj1) => (FetchOptions) obj0 != (FetchOptions) obj1;

    internal static void UIdL1ZLsSCP9f2gU3m9(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      System.Type entityType)
    {
      ((UserDefinedListService) obj0).SetupFetchOptions((ICriteria) obj1, (FetchOptions) obj2, entityType);
    }

    internal static void hSA28YLcKM0J3SIpC8x([In] object obj0, [In] object obj1, [In] object obj2) => ((IEntityManagerBehavior) obj0).OnCreateCriteria((ICriteria) obj1, (IEntityFilter) obj2);

    internal static void R1ZOGxLzc1yw3j52X0q([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object eLM408UFJ1oxuPIAYuM([In] object obj0, [In] int obj1) => (object) ((ICriteria) obj0).SetFirstResult(obj1);

    internal static int fsOsgRUBSrXMlxvMn6l([In] object obj0) => ((FetchOptions) obj0).MaxResults;

    internal static object x5BNDVUWvPHqFhn1vkZ([In] object obj0, [In] int obj1) => (object) ((ICriteria) obj0).SetMaxResults(obj1);

    internal static void uJWcFOUoCEdh4LfeNyt([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static HierarchyType J0fgt0UbjV0Nh8KaQmR([In] object obj0) => ((EntityMetadata) obj0).HierarchyType;

    internal static Guid cX3TeoUh66SB6VSiUNh([In] object obj0) => ((EntityMetadata) obj0).IsGroupPropertyUid;

    internal static bool VE5sLyUGx5TZeVuhBoD([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool d9bZJhUE2g2pNC7Qs5v([In] object obj0, [In] object obj1) => (FetchOptions) obj0 == (FetchOptions) obj1;

    internal static object DWkxc4UfLlLPV5DjDrK([In] object obj0) => (object) ((FetchOptions) obj0).SortExpression;

    internal static bool kPNc6CUQCCyTstv1eFf([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object SHWcK7UClGcKgX0QrNS([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object AVP8fYUvuHrjMPlf1sm([In] object obj0) => (object) Order.Desc((string) obj0);

    internal static object HhswRwU8yKxdCeHTkRr([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).AddOrder((Order) obj1);

    internal static bool GlSSBOUZJ4EUa9F3ld6([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    /// <summary>Получение трансформера результата критерии</summary>
    private class DictionaryResultTransformer : IResultTransformer
    {
      private static object IvULU1fYxObIZ0E9Mb1c;

      public object TransformTuple(object[] tuple, string[] aliases)
      {
        int num = 1;
        object[] tuple1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              tuple1 = tuple;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 2;
              continue;
          }
        }
label_4:
        return (object) new UDLDynamicObject(((IEnumerable<string>) aliases).Select<string, KeyValuePair<string, object>>((Func<string, int, KeyValuePair<string, object>>) ((a, i) => new KeyValuePair<string, object>(a, tuple1[i]))).ToDictionary<KeyValuePair<string, object>, string, object>((Func<KeyValuePair<string, object>, string>) (p => p.Key), (Func<KeyValuePair<string, object>, object>) (p => p.Value)));
      }

      public IList TransformList(IList collection) => collection;

      public DictionaryResultTransformer()
      {
        UserDefinedListService.DictionaryResultTransformer.DC5x7ufYyPSsbYORBBgi();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool ELIccCfY0guSa7TEruqG() => UserDefinedListService.DictionaryResultTransformer.IvULU1fYxObIZ0E9Mb1c == null;

      internal static UserDefinedListService.DictionaryResultTransformer qgKep1fYmJYnZ1u5Y54t() => (UserDefinedListService.DictionaryResultTransformer) UserDefinedListService.DictionaryResultTransformer.IvULU1fYxObIZ0E9Mb1c;

      internal static void DC5x7ufYyPSsbYORBBgi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
