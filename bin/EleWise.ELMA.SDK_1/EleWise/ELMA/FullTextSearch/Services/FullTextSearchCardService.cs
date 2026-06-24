// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.FullTextSearchCardService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>Сервис работы с карточками полнотекстового поиска</summary>
  [Service]
  internal class FullTextSearchCardService : IFullTextSearchCardService
  {
    private static readonly ILogger IndexLog;
    private List<IModuleFullTextSearchExtension> points;
    private static FullTextSearchCardService WqyMArGSBtlPCtZLv2od;

    private List<IModuleFullTextSearchExtension> Points => this.points ?? (this.points = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>().ToList<IModuleFullTextSearchExtension>());

    public List<IEntity> ReconstructEntities(Type cardType, FullTextSearchResultModel resultModel)
    {
      try
      {
        List<FullTextSearchResultItem> items = resultModel.Items;
        List<string> listReturnFields = resultModel.ListReturnFields;
        Dictionary<string, Guid> dictionary = new Dictionary<string, Guid>();
        // ISSUE: reference to a compiler-generated method
        foreach (string key in listReturnFields.Where<string>((Func<string, bool>) (f => !FullTextSearchCardService.\u003C\u003Ec.VTLis7vLqJfcceEHN6lI((object) f))))
        {
          string[] source = key.Split('_');
          Guid result;
          if (((IEnumerable<string>) source).Count<string>() == 2 && Guid.TryParse(source[0], out result) && !dictionary.ContainsKey(key))
            dictionary.Add(key, result);
        }
        List<IEntity> entityList = new List<IEntity>();
        foreach (FullTextSearchResultItem searchResultItem in items)
        {
          FullTextSearchResultItem itemF = searchResultItem;
          if (itemF != null && itemF.ResultData != null)
          {
            WebData resultData = itemF.ResultData;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            WebDataItem webDataItem1 = ((IEnumerable<WebDataItem>) resultData.Items).FirstOrDefault<WebDataItem>((Func<WebDataItem, bool>) (i => FullTextSearchCardService.\u003C\u003Ec.RSgT0dvLTaDru4pFUORV(FullTextSearchCardService.\u003C\u003Ec.a48kKqvLKRdCyJY23Dbx((object) i), FullTextSearchCardService.\u003C\u003Ec.Ea1A0gvLXJ8cEEkpN5Wa(-1598106783 - -968262081 ^ -629860544))));
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            WebDataItem webDataItem2 = ((IEnumerable<WebDataItem>) resultData.Items).FirstOrDefault<WebDataItem>((Func<WebDataItem, bool>) (i => FullTextSearchCardService.\u003C\u003Ec.RSgT0dvLTaDru4pFUORV((object) i.Name, FullTextSearchCardService.\u003C\u003Ec.Ea1A0gvLXJ8cEEkpN5Wa(-1380439818 << 3 ^ 1841415918))));
            Guid result1;
            long result2;
            if (webDataItem1 != null && Guid.TryParse(webDataItem1.Value, out result1) && webDataItem2 != null && long.TryParse(webDataItem2.Value, out result2))
            {
              Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(result1);
              EntityMetadata metadata = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(result1) as EntityMetadata;
              if (typeByUid != (Type) null && metadata != null && ModelHelper.GetEntityManager(typeByUid) != null)
              {
                IEntity<long> fakeEntity = InterfaceActivator.Create(typeByUid) as IEntity<long>;
                if (fakeEntity != null)
                {
                  fakeEntity.Id = result2;
                  foreach (WebDataItem webDataItem3 in resultData.Items)
                  {
                    if (webDataItem3 != null && !string.IsNullOrWhiteSpace(webDataItem3.Name))
                    {
                      if (dictionary.ContainsKey(webDataItem3.Name))
                        dictionary.Remove(webDataItem3.Name);
                      string[] strArray = webDataItem3.Name.Split('_');
                      if (strArray.Length != 0)
                      {
                        Guid resultDataItemGuid;
                        if (Guid.TryParse(strArray[0], out resultDataItemGuid))
                        {
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FullTextSearchCardService.\u003C\u003Ec__DisplayClass4_3.nLjRUivLQ0wVbPfx3yTP(FullTextSearchCardService.\u003C\u003Ec__DisplayClass4_3.WCI5gnvLf7sGW88Skl9k((object) p), resultDataItemGuid)));
                          if (propertyMetadata != null)
                          {
                            IFullTextSearchDescriptorService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
                            if (!serviceNotNull.IsSupportedSearchInIndex((IPropertyMetadata) propertyMetadata))
                              throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766002350), (object) propertyMetadata.TypeUid, (object) propertyMetadata.SubTypeUid, (object) propertyMetadata.Uid, (object) propertyMetadata.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218719562)));
                            serviceNotNull.SetIndexField((object) fakeEntity, (object) webDataItem3, (IPropertyMetadata) propertyMetadata);
                          }
                        }
                      }
                    }
                  }
                  foreach (KeyValuePair<string, Guid> keyValuePair in dictionary)
                  {
                    KeyValuePair<string, Guid> returnDynamicFieldF = keyValuePair;
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => FullTextSearchCardService.\u003C\u003Ec__DisplayClass4_4.JccX7cvLI9JtZwNjetH2(FullTextSearchCardService.\u003C\u003Ec__DisplayClass4_4.GpXOoYvLuxxZPRwSYAUf((object) p), returnDynamicFieldF.Value)));
                    if (propertyMetadata != null)
                    {
                      IFullTextSearchDescriptorService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>();
                      if (!serviceNotNull.IsSupportedSearchInIndex((IPropertyMetadata) propertyMetadata))
                        throw new FullTextFilterException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70221224), (object) propertyMetadata.TypeUid, (object) propertyMetadata.SubTypeUid, (object) propertyMetadata.Uid, (object) propertyMetadata.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470558046)));
                      serviceNotNull.SetEmptyIndexField((object) fakeEntity, (IPropertyMetadata) propertyMetadata, returnDynamicFieldF.Key);
                    }
                  }
                  this.Points.ForEach((Action<IModuleFullTextSearchExtension>) (p =>
                  {
                    int num = 1;
                    while (true)
                    {
                      switch (num)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          p.ReconstructEntity(cardType, (IFullTextSearchResultItem) itemF, fakeEntity);
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  }));
                  entityList.Add((IEntity) fakeEntity);
                }
              }
            }
          }
        }
        return entityList;
      }
      catch (FullTextFilterException ex)
      {
        FullTextSearchCardService.IndexLog.Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082287384), (Exception) ex);
        return (List<IEntity>) null;
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) ex);
        return (List<IEntity>) null;
      }
    }

    public List<long> GetIdArray(List<FullTextSearchResultItem> resultItems)
    {
      try
      {
        if (resultItems == null)
          return (List<long>) null;
        List<long> idArray = new List<long>();
        foreach (FullTextSearchResultItem resultItem in resultItems)
        {
          if (resultItem != null && resultItem.ResultData != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            WebDataItem webDataItem = ((IEnumerable<WebDataItem>) resultItem.ResultData.Items).FirstOrDefault<WebDataItem>((Func<WebDataItem, bool>) (i => FullTextSearchCardService.\u003C\u003Ec.RSgT0dvLTaDru4pFUORV((object) i.Name, FullTextSearchCardService.\u003C\u003Ec.Ea1A0gvLXJ8cEEkpN5Wa(-787452571 ^ -787420101))));
            long result;
            if (webDataItem != null && long.TryParse(webDataItem.Value, out result))
              idArray.Add(result);
          }
        }
        return idArray;
      }
      catch (FullTextFilterException ex)
      {
        FullTextSearchCardService.IndexLog.Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099537065), (Exception) ex);
        return (List<long>) null;
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) ex);
        return (List<long>) null;
      }
    }

    /// <summary>Получить расширение карточки для типа фильтра</summary>
    public IModuleFullTextSearchExtension GetExtensionByFilter(IEntityFilter filter)
    {
      int num = 4;
      ClassMetadata metadataByFilter;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            goto label_6;
          case 4:
            if (filter == null)
            {
              num = 3;
              continue;
            }
            metadataByFilter = MetadataLoader.GetEntityMetadataByFilter(filter.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          default:
            if (metadataByFilter == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return this.GetExtensionByObjectTypeUid(metadataByFilter.Uid);
label_3:
      return (IModuleFullTextSearchExtension) null;
label_6:
      return (IModuleFullTextSearchExtension) null;
    }

    /// <summary>Получить тип карточки для типа фильтра</summary>
    public Type GetCardTypeByFilter(IEntityFilter filter)
    {
      int num = 2;
      ClassMetadata metadataByFilter;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataByFilter = MetadataLoader.GetEntityMetadataByFilter(filter.GetType());
            num = 4;
            continue;
          case 2:
            if (filter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 3:
            goto label_6;
          case 4:
            if (metadataByFilter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetCardTypeByObjectTypeUid(FullTextSearchCardService.w16b87GSbv9xwPoEulhL((object) metadataByFilter));
label_3:
      return (Type) null;
label_6:
      return (Type) null;
    }

    /// <summary>Получить расширение для Uid'а типа объекта</summary>
    public IModuleFullTextSearchExtension GetExtensionByObjectTypeUid(Guid typeUid)
    {
      int num = 2;
      Guid typeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeUid1 = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.Points.FirstOrDefault<IModuleFullTextSearchExtension>((Func<IModuleFullTextSearchExtension, bool>) (p => FullTextSearchCardService.\u003C\u003Ec__DisplayClass8_0.qBmUUZvL1j8567HViWeG(FullTextSearchCardService.\u003C\u003Ec__DisplayClass8_0.nva6xjvLP0WQKPDKLn9j((object) p, typeUid1), (Type) null)));
    }

    /// <summary>Получить расширение для типа объекта</summary>
    public IModuleFullTextSearchExtension GetExtensionByObjectType(Type type)
    {
      int num = 2;
      IMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            metadata = MetadataLoader.LoadMetadata(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (IModuleFullTextSearchExtension) null;
label_3:
      return this.GetExtensionByObjectTypeUid(FullTextSearchCardService.XWSQ84GSh9Gy0eCnBAig((object) metadata));
    }

    /// <summary>Получить тип карточки для Uid'а типа объекта</summary>
    public Type GetCardTypeByObjectTypeUid(Guid typeUid)
    {
      int num = 1;
      Guid typeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            typeUid1 = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      IEnumerable<Type> source = this.Points.Select<IModuleFullTextSearchExtension, Type>((Func<IModuleFullTextSearchExtension, Type>) (p => FullTextSearchCardService.\u003C\u003Ec__DisplayClass10_0.H4lp3FvLaj1prpRPbGZh((object) p, typeUid1)));
      // ISSUE: reference to a compiler-generated field
      Func<Type, bool> func = FullTextSearchCardService.\u003C\u003Ec.\u003C\u003E9__10_1;
      Func<Type, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        FullTextSearchCardService.\u003C\u003Ec.\u003C\u003E9__10_1 = predicate = (Func<Type, bool>) (cardType => FullTextSearchCardService.\u003C\u003Ec.qSN9ZavLkFRu3lRyWNoW(cardType, (Type) null));
      }
      else
        goto label_7;
label_6:
      return source.FirstOrDefault<Type>(predicate);
label_7:
      predicate = func;
      goto label_6;
    }

    /// <summary>Получить тип карточки для типа объекта</summary>
    public Type GetCardTypeByObjectType(Type type)
    {
      int num = 3;
      IMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            metadata = MetadataLoader.LoadMetadata(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (Type) null;
label_3:
      return this.GetCardTypeByObjectTypeUid(FullTextSearchCardService.XWSQ84GSh9Gy0eCnBAig((object) metadata));
    }

    /// <summary>Получить расширение для типа карточки</summary>
    public IModuleFullTextSearchExtension GetExtensionByCardType(Type cardType)
    {
      int num1 = 2;
      Type cardType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            cardType1 = cardType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.Points.FirstOrDefault<IModuleFullTextSearchExtension>((Func<IModuleFullTextSearchExtension, bool>) (p =>
      {
        int num2 = 1;
        Guid? supportedCardType;
        while (true)
        {
          switch (num2)
          {
            case 1:
              supportedCardType = p.GetSupportedCardType(cardType1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return supportedCardType.HasValue;
      }));
    }

    /// <summary>Получить Uid типа карточки по ее типу</summary>
    public Guid? GetCardUidByCardType(Type cardType)
    {
      foreach (IModuleFullTextSearchExtension point in this.Points)
      {
        Guid? supportedCardType = point.GetSupportedCardType(cardType);
        if (supportedCardType.HasValue)
        {
          Guid? cardUidByCardType = supportedCardType;
          Guid empty = Guid.Empty;
          if ((cardUidByCardType.HasValue ? (cardUidByCardType.HasValue ? (cardUidByCardType.GetValueOrDefault() != empty ? 1 : 0) : 0) : 1) != 0)
          {
            cardUidByCardType = supportedCardType;
            return cardUidByCardType;
          }
        }
      }
      return new Guid?();
    }

    /// <summary>Получить тип карточки по ее Uid'у ее типа</summary>
    public Type GetCardTypeByCardUid(Guid cardUid)
    {
      int num = 1;
      Guid cardUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            cardUid1 = cardUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
            continue;
        }
      }
label_4:
      IEnumerable<Type> source = this.Points.Select<IModuleFullTextSearchExtension, Type>((Func<IModuleFullTextSearchExtension, Type>) (p => p.GetSupportedCardType(cardUid1)));
      // ISSUE: reference to a compiler-generated field
      Func<Type, bool> func = FullTextSearchCardService.\u003C\u003Ec.\u003C\u003E9__14_1;
      Func<Type, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        FullTextSearchCardService.\u003C\u003Ec.\u003C\u003E9__14_1 = predicate = (Func<Type, bool>) (cardType => FullTextSearchCardService.\u003C\u003Ec.qSN9ZavLkFRu3lRyWNoW(cardType, (Type) null));
      }
      else
        goto label_7;
label_6:
      return source.FirstOrDefault<Type>(predicate);
label_7:
      predicate = func;
      goto label_6;
    }

    public FullTextSearchCardService()
    {
      FullTextSearchCardService.O5sJ71GSG89Qg0Jk8eo5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FullTextSearchCardService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FullTextSearchCardService.O5sJ71GSG89Qg0Jk8eo5();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FullTextSearchCardService.IndexLog = (ILogger) FullTextSearchCardService.fV8f0xGSfIVaDtglXoHH(FullTextSearchCardService.PSbwEOGSEnEvECdLCtuj(~1767720452 ^ -1767800469));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool ek4sqNGSWcwQiMhlKh9d() => FullTextSearchCardService.WqyMArGSBtlPCtZLv2od == null;

    internal static FullTextSearchCardService L7PcllGSop6brncRHf9r() => FullTextSearchCardService.WqyMArGSBtlPCtZLv2od;

    internal static Guid w16b87GSbv9xwPoEulhL([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid XWSQ84GSh9Gy0eCnBAig([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static void O5sJ71GSG89Qg0Jk8eo5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object PSbwEOGSEnEvECdLCtuj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object fV8f0xGSfIVaDtglXoHH([In] object obj0) => (object) Logger.GetLogger((string) obj0);
  }
}
