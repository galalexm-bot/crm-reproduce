// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.FullTextTypeMappingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>Сервис управления типами полнотекстового поиска</summary>
  [Service]
  internal sealed class FullTextTypeMappingService : 
    IFullTextTypeMappingServiceExt,
    IFullTextTypeMappingService
  {
    private List<IFullTextSearchObjectHandlerExtension> handlerPoints;
    private FullTextTypeMappingService.MappingCardHandlerObject mappingCardHandlerField;
    private FullTextTypeMappingService.MappingCardEntityField mappingCardEntityField;
    private List<IModuleFullTextSearchExtension> points;
    /// <summary>Создается ли в данный момент карта соответствий.</summary>
    private bool isCreatingMapping;
    internal static FullTextTypeMappingService M8ZWnSGS3vcprUSZ0fkT;

    private List<IFullTextSearchObjectHandlerExtension> HandlerPoints => this.handlerPoints ?? (this.handlerPoints = ComponentManager.Current.GetExtensionPoints<IFullTextSearchObjectHandlerExtension>().ToList<IFullTextSearchObjectHandlerExtension>());

    private List<IModuleFullTextSearchExtension> Points => this.points ?? (this.points = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>().ToList<IModuleFullTextSearchExtension>());

    /// <inheritdoc />
    public IFullTextTypeMappingAvailability CheckAvailability()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.isCreatingMapping)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (IFullTextTypeMappingAvailability) FullTextTypeMappingAvailability.NotAvailable((string) FullTextTypeMappingService.LHxClnGSDWwN0NKqR8cW(-138018305 ^ -138031923));
label_3:
      return (IFullTextTypeMappingAvailability) FullTextTypeMappingService.cyeIeoGStP9WBPNG2i1w();
    }

    public void CreateMapping()
    {
      switch (1)
      {
        case 1:
          try
          {
            this.isCreatingMapping = true;
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
              num1 = 0;
            List<IFullTextSearchObjectHandlerExtension>.Enumerator enumerator1;
            while (true)
            {
              switch (num1)
              {
                case 1:
label_6:
                  this.mappingCardEntityField = new FullTextTypeMappingService.MappingCardEntityField((IEnumerable<IModuleFullTextSearchExtension>) this.Points);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 4 : 1;
                  continue;
                case 2:
                  enumerator1 = this.HandlerPoints.GetEnumerator();
                  num1 = 3;
                  continue;
                case 3:
                  try
                  {
label_32:
                    if (enumerator1.MoveNext())
                      goto label_10;
                    else
                      goto label_33;
label_8:
                    IFullTextSearchObjectHandlerExtension current1;
                    List<Guid>.Enumerator enumerator2;
                    int num2;
                    List<Guid> typeUids;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 1:
                          typeUids = new List<Guid>();
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                          continue;
                        case 2:
label_34:
                          this.mappingCardHandlerField.AddMappings(FullTextTypeMappingService.xyK2Y9GSwABOc65U1EW9((object) current1), current1, typeUids);
                          num2 = 6;
                          continue;
                        case 3:
                          goto label_6;
                        case 4:
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
                          continue;
                        case 5:
                          goto label_10;
                        case 6:
                          goto label_32;
                        case 7:
                          try
                          {
label_18:
                            if (enumerator2.MoveNext())
                              goto label_14;
                            else
                              goto label_19;
label_12:
                            Guid current2;
                            ClassMetadata metadata;
                            List<ClassMetadata> childClasses;
                            int num3;
                            while (true)
                            {
                              switch (num3)
                              {
                                case 1:
                                  if (metadata != null)
                                  {
                                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 3;
                                    continue;
                                  }
                                  goto case 4;
                                case 2:
                                  goto label_34;
                                case 3:
                                  childClasses = MetadataLoader.GetChildClasses(metadata);
                                  num3 = 7;
                                  continue;
                                case 4:
                                  typeUids.Add(current2);
                                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                                  continue;
                                case 5:
                                  metadata = MetadataLoader.LoadMetadata(current2) as ClassMetadata;
                                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                                  continue;
                                case 6:
                                  goto label_14;
                                case 7:
                                  if (childClasses.Any<ClassMetadata>())
                                  {
                                    num3 = 9;
                                    continue;
                                  }
                                  goto case 4;
                                case 8:
                                  if (!typeUids.Contains(current2))
                                  {
                                    num3 = 5;
                                    continue;
                                  }
                                  goto label_18;
                                case 9:
                                  childClasses.ForEach((Action<ClassMetadata>) (c =>
                                  {
                                    int num4 = 1;
                                    while (true)
                                    {
                                      switch (num4)
                                      {
                                        case 1:
                                          if (!typeUids.Contains(c.Uid))
                                          {
                                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                                            continue;
                                          }
                                          goto label_6;
                                        case 2:
                                          goto label_2;
                                        default:
                                          // ISSUE: reference to a compiler-generated method
                                          typeUids.Add(FullTextTypeMappingService.\u003C\u003Ec__DisplayClass14_0.isNuwQvLcutdDdwF3NpT((object) c));
                                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 2;
                                          continue;
                                      }
                                    }
label_2:
                                    return;
label_6:;
                                  }));
                                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 3;
                                  continue;
                                default:
                                  goto label_18;
                              }
                            }
label_14:
                            current2 = enumerator2.Current;
                            num3 = 8;
                            goto label_12;
label_19:
                            num3 = 2;
                            goto label_12;
                          }
                          finally
                          {
                            enumerator2.Dispose();
                            int num5 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
                              num5 = 0;
                            switch (num5)
                            {
                              default:
                            }
                          }
                        default:
                          enumerator2 = current1.SupportedUids.GetEnumerator();
                          num2 = 7;
                          continue;
                      }
                    }
label_10:
                    current1 = enumerator1.Current;
                    num2 = 4;
                    goto label_8;
label_33:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 3;
                    goto label_8;
                  }
                  finally
                  {
                    enumerator1.Dispose();
                    int num6 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                      num6 = 0;
                    switch (num6)
                    {
                      default:
                    }
                  }
                case 4:
                  goto label_38;
                default:
                  this.mappingCardHandlerField = new FullTextTypeMappingService.MappingCardHandlerObject();
                  num1 = 2;
                  continue;
              }
            }
label_38:
            break;
          }
          finally
          {
            this.isCreatingMapping = false;
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    public Dictionary<Guid, List<string>> GetImportantProperties(Guid objectTypeUid)
    {
      Dictionary<Guid, List<string>> importantProperties = new Dictionary<Guid, List<string>>();
      List<FullTextTypeMappingService.MappingCardHandlerObjectItem> source = this.mappingCardHandlerField.Where(objectTypeUid);
      if (source.Any<FullTextTypeMappingService.MappingCardHandlerObjectItem>())
      {
        foreach (FullTextTypeMappingService.MappingCardHandlerObjectItem handlerObjectItem in source)
        {
          if (importantProperties.ContainsKey(handlerObjectItem.CardUid))
          {
            foreach (string importantProperty in handlerObjectItem.HandlerPoint.GetImportantProperties)
            {
              if (!importantProperties[handlerObjectItem.CardUid].Contains(importantProperty))
                importantProperties[handlerObjectItem.CardUid].Add(importantProperty);
            }
          }
          else
            importantProperties.Add(handlerObjectItem.CardUid, handlerObjectItem.HandlerPoint.GetImportantProperties);
        }
      }
      return importantProperties;
    }

    public Dictionary<Guid, List<string>> GetVisualDataProperties(Guid objectTypeUid)
    {
      Dictionary<Guid, List<string>> visualDataProperties = new Dictionary<Guid, List<string>>();
      List<FullTextTypeMappingService.MappingCardHandlerObjectItem> source = this.mappingCardHandlerField.Where(objectTypeUid);
      if (source.Any<FullTextTypeMappingService.MappingCardHandlerObjectItem>())
      {
        foreach (FullTextTypeMappingService.MappingCardHandlerObjectItem handlerObjectItem in source)
        {
          if (visualDataProperties.ContainsKey(handlerObjectItem.CardUid))
          {
            foreach (string visualDataProperty in handlerObjectItem.HandlerPoint.GetVisualDataProperties)
            {
              if (!visualDataProperties[handlerObjectItem.CardUid].Contains(visualDataProperty))
                visualDataProperties[handlerObjectItem.CardUid].Add(visualDataProperty);
            }
          }
          else
            visualDataProperties.Add(handlerObjectItem.CardUid, handlerObjectItem.HandlerPoint.GetVisualDataProperties);
        }
      }
      return visualDataProperties;
    }

    public Dictionary<Guid, List<string>> GetImportantDynamicProperties(Guid objectTypeUid)
    {
      Dictionary<Guid, List<string>> dynamicProperties = new Dictionary<Guid, List<string>>();
      IEnumerable<FullTextTypeMappingService.MappingCardEntityFieldItem> source = this.mappingCardEntityField.Where(objectTypeUid);
      if (source.Any<FullTextTypeMappingService.MappingCardEntityFieldItem>())
      {
        foreach (FullTextTypeMappingService.MappingCardEntityFieldItem cardEntityFieldItem in source)
        {
          if (dynamicProperties.ContainsKey(cardEntityFieldItem.CardUid))
          {
            foreach (string importantProperty in cardEntityFieldItem.ImportantProperties)
            {
              if (!dynamicProperties[cardEntityFieldItem.CardUid].Contains(importantProperty))
                dynamicProperties[cardEntityFieldItem.CardUid].Add(importantProperty);
            }
          }
          else
            dynamicProperties.Add(cardEntityFieldItem.CardUid, cardEntityFieldItem.ImportantProperties);
        }
      }
      return dynamicProperties;
    }

    public List<KeyValuePair<string, object>> OnInsertProcessing(Guid objectTypeUid, object obj)
    {
      List<KeyValuePair<string, object>> keyValuePairList = new List<KeyValuePair<string, object>>();
      this.mappingCardHandlerField.Where(objectTypeUid).Select<FullTextTypeMappingService.MappingCardHandlerObjectItem, IFullTextSearchObjectHandlerExtension>((Func<FullTextTypeMappingService.MappingCardHandlerObjectItem, IFullTextSearchObjectHandlerExtension>) (m => m.HandlerPoint)).Distinct<IFullTextSearchObjectHandlerExtension>().ForEach<IFullTextSearchObjectHandlerExtension>((Action<IFullTextSearchObjectHandlerExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              FullTextTypeMappingService.\u003C\u003Ec__DisplayClass18_0.VjdZDcvUWy4NqsbXqEy3((object) p, objectTypeUid, obj);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return keyValuePairList;
    }

    public List<KeyValuePair<string, object>> OnDeleteProcessing(Guid objectTypeUid, object obj)
    {
      List<KeyValuePair<string, object>> keyValuePairList = new List<KeyValuePair<string, object>>();
      if (!this.IsSupported(objectTypeUid))
        return keyValuePairList;
      // ISSUE: reference to a compiler-generated method
      this.mappingCardHandlerField.Where(objectTypeUid).Select<FullTextTypeMappingService.MappingCardHandlerObjectItem, IFullTextSearchObjectHandlerExtension>((Func<FullTextTypeMappingService.MappingCardHandlerObjectItem, IFullTextSearchObjectHandlerExtension>) (m => (IFullTextSearchObjectHandlerExtension) FullTextTypeMappingService.\u003C\u003Ec.kLqWp3vUE5WyC0G199kO((object) m))).Distinct<IFullTextSearchObjectHandlerExtension>().ForEach<IFullTextSearchObjectHandlerExtension>((Action<IFullTextSearchObjectHandlerExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              FullTextTypeMappingService.\u003C\u003Ec__DisplayClass19_0.mHvB8pvU8HDpi2boGYdh((object) p, objectTypeUid, obj);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return keyValuePairList;
    }

    public bool IsSupported(Guid objectTypeUid) => FullTextTypeMappingService.MwKS92GS4WjuLrLZ5avO((object) this.mappingCardHandlerField, objectTypeUid);

    public List<QueueToIndex> GetQueueToIndex(
      List<KeyValuePair<string, object>> item,
      long id,
      Guid objectTypeUid)
    {
      List<QueueToIndex> retunList = new List<QueueToIndex>();
      // ISSUE: reference to a compiler-generated method
      this.mappingCardHandlerField.Where(objectTypeUid).Select<FullTextTypeMappingService.MappingCardHandlerObjectItem, IFullTextSearchObjectHandlerExtension>((Func<FullTextTypeMappingService.MappingCardHandlerObjectItem, IFullTextSearchObjectHandlerExtension>) (m => (IFullTextSearchObjectHandlerExtension) FullTextTypeMappingService.\u003C\u003Ec.kLqWp3vUE5WyC0G199kO((object) m))).Distinct<IFullTextSearchObjectHandlerExtension>().ForEach<IFullTextSearchObjectHandlerExtension>((Action<IFullTextSearchObjectHandlerExtension>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              retunList.AddRange((IEnumerable<QueueToIndex>) p.ProcessingMergedIndexQueue(item, id, objectTypeUid));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return retunList;
    }

    public FullTextTypeMappingService()
    {
      FullTextTypeMappingService.NMM0wLGS6ZIfXxLd0GCw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object LHxClnGSDWwN0NKqR8cW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cyeIeoGStP9WBPNG2i1w() => (object) FullTextTypeMappingAvailability.Available();

    internal static bool cgm4uFGSpkkVtwnTZWX9() => FullTextTypeMappingService.M8ZWnSGS3vcprUSZ0fkT == null;

    internal static FullTextTypeMappingService Xio517GSa1S3GHulkNx3() => FullTextTypeMappingService.M8ZWnSGS3vcprUSZ0fkT;

    internal static Type xyK2Y9GSwABOc65U1EW9([In] object obj0) => ((IFullTextSearchObjectHandlerExtension) obj0).SupportedCard;

    internal static bool MwKS92GS4WjuLrLZ5avO([In] object obj0, Guid objectUid) => ((FullTextTypeMappingService.MappingCardHandlerObject) obj0).Any(objectUid);

    internal static void NMM0wLGS6ZIfXxLd0GCw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Класс мэпинга статических полей</summary>
    private class MappingCardHandlerObject
    {
      private List<FullTextTypeMappingService.MappingCardHandlerObjectItem> mappings;
      private static object joLQoRvL7qshbKD9Agwd;

      public void AddMappings(
        Type cardType,
        IFullTextSearchObjectHandlerExtension handlerPoint,
        List<Guid> supportedObjectUids)
      {
        if (cardType == (Type) null || handlerPoint == null)
          return;
        FullTextTypeMappingService.MappingCardHandlerObjectItem handlerObjectItem = this.mappings.FirstOrDefault<FullTextTypeMappingService.MappingCardHandlerObjectItem>((Func<FullTextTypeMappingService.MappingCardHandlerObjectItem, bool>) (m =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!FullTextTypeMappingService.MappingCardHandlerObject.\u003C\u003Ec__DisplayClass0_0.Wwm7pSZnbna0NYLPHrFj(FullTextTypeMappingService.MappingCardHandlerObject.\u003C\u003Ec__DisplayClass0_0.wwAQP2Zno25jxkqrKgN8((object) m), cardType))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              default:
                goto label_2;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          return FullTextTypeMappingService.MappingCardHandlerObject.\u003C\u003Ec__DisplayClass0_0.mPtu1JZnhvcZltlBN3ZL((object) m) == handlerPoint;
label_3:
          return false;
        }));
        if (handlerObjectItem != null)
          handlerObjectItem.Add(supportedObjectUids);
        else
          this.mappings.Add(new FullTextTypeMappingService.MappingCardHandlerObjectItem(cardType, handlerPoint, supportedObjectUids));
      }

      public bool Any(Guid objectUid)
      {
        int num = 2;
        Guid objectUid1;
        while (true)
        {
          switch (num)
          {
            case 1:
              objectUid1 = objectUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return this.mappings.Any<FullTextTypeMappingService.MappingCardHandlerObjectItem>((Func<FullTextTypeMappingService.MappingCardHandlerObjectItem, bool>) (m => m.SupportedObjectUids.Any<Guid>((Func<Guid, bool>) (o => FullTextTypeMappingService.MappingCardHandlerObject.\u003C\u003Ec__DisplayClass1_0.Hn9DKDZnCjGH4mAEe89E(o, objectUid1)))));
      }

      public List<FullTextTypeMappingService.MappingCardHandlerObjectItem> Where(Guid objectUid)
      {
        Func<Guid, bool> func;
        return this.mappings.Where<FullTextTypeMappingService.MappingCardHandlerObjectItem>((Func<FullTextTypeMappingService.MappingCardHandlerObjectItem, bool>) (m =>
        {
          List<Guid> supportedObjectUids = m.SupportedObjectUids;
          Func<Guid, bool> func1 = func;
          // ISSUE: reference to a compiler-generated method
          Func<Guid, bool> predicate = func1 == null ? (func = (Func<Guid, bool>) (o => FullTextTypeMappingService.MappingCardHandlerObject.\u003C\u003Ec__DisplayClass2_0.HQH5bEZnIpX2NhnYx4H5(o, objectUid))) : func1;
          return supportedObjectUids.Any<Guid>(predicate);
        })).ToList<FullTextTypeMappingService.MappingCardHandlerObjectItem>();
      }

      public MappingCardHandlerObject()
      {
        FullTextTypeMappingService.MappingCardHandlerObject.rsZWWgvLmNj57bmJPVBQ();
        this.mappings = new List<FullTextTypeMappingService.MappingCardHandlerObjectItem>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool X6O2yIvLxxIQpEUSJ8Bh() => FullTextTypeMappingService.MappingCardHandlerObject.joLQoRvL7qshbKD9Agwd == null;

      internal static FullTextTypeMappingService.MappingCardHandlerObject iySTAPvL0etSNtVyxt2S() => (FullTextTypeMappingService.MappingCardHandlerObject) FullTextTypeMappingService.MappingCardHandlerObject.joLQoRvL7qshbKD9Agwd;

      internal static void rsZWWgvLmNj57bmJPVBQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Запись мэпинга статических полей</summary>
    private class MappingCardHandlerObjectItem
    {
      private Guid cardUid;
      private object handlerPoint;
      private List<Guid> supportedObjectUids;
      private static object tJsPB5vLyEdxRLkUUjll;

      public MappingCardHandlerObjectItem(
        Type cardType,
        IFullTextSearchObjectHandlerExtension handlerPoint,
        List<Guid> supportedObjectUids)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.supportedObjectUids = new List<Guid>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.handlerPoint = (object) handlerPoint;
        this.supportedObjectUids = supportedObjectUids ?? new List<Guid>();
        this.CardType = cardType;
        this.cardUid = Locator.GetServiceNotNull<IFullTextSearchCardService>().GetCardUidByCardType(cardType) ?? Guid.Empty;
      }

      public void Add(List<Guid> supportedObjectUids)
      {
        if (supportedObjectUids == null)
          return;
        foreach (Guid supportedObjectUid in supportedObjectUids)
        {
          if (!this.supportedObjectUids.Contains(supportedObjectUid))
            this.supportedObjectUids.Add(supportedObjectUid);
        }
      }

      public Type CardType
      {
        get => this.\u003CCardType\u003Ek__BackingField;
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
                this.\u003CCardType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

      public Guid CardUid => this.cardUid;

      public IFullTextSearchObjectHandlerExtension HandlerPoint => (IFullTextSearchObjectHandlerExtension) this.handlerPoint;

      public List<Guid> SupportedObjectUids => this.supportedObjectUids;

      internal static bool JgFnPovLMqepLEEmusf1() => FullTextTypeMappingService.MappingCardHandlerObjectItem.tJsPB5vLyEdxRLkUUjll == null;

      internal static FullTextTypeMappingService.MappingCardHandlerObjectItem xFTIhmvLJtLDq5Zv5Ufp() => (FullTextTypeMappingService.MappingCardHandlerObjectItem) FullTextTypeMappingService.MappingCardHandlerObjectItem.tJsPB5vLyEdxRLkUUjll;
    }

    /// <summary>Класс мэпинга динамических полей</summary>
    private class MappingCardEntityField
    {
      private IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions;
      private readonly IDictionary<Guid, Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>> mappings;
      private bool addMappings;
      internal static object nJCYlcvL9OtnAKNyJkN3;

      public MappingCardEntityField(
        IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.moduleFullTextSearchExtensions = moduleFullTextSearchExtensions;
        this.mappings = PublishCacheContext.CreateCache<Guid, Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>>((Func<IDictionary<Guid, Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>>, IDictionary<Guid, Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>>>) (_ => (IDictionary<Guid, Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>>) new ConcurrentDictionary<Guid, Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>>()), onComplete: (Action<IDictionary<Guid, Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>>>) (_ => this.addMappings = true));
        this.addMappings = true;
      }

      public IEnumerable<FullTextTypeMappingService.MappingCardEntityFieldItem> Where(Guid objectUid)
      {
        if (this.addMappings)
          this.AddMappings();
        Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem> dictionary;
        return !this.mappings.TryGetValue(objectUid, out dictionary) ? Enumerable.Empty<FullTextTypeMappingService.MappingCardEntityFieldItem>() : (IEnumerable<FullTextTypeMappingService.MappingCardEntityFieldItem>) dictionary.Values;
      }

      private void AddMappings()
      {
        int num1 = 2;
        IEnumerator<KeyValuePair<Type, Dictionary<Guid, List<string>>>> enumerator1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_30;
            case 1:
              goto label_2;
            case 2:
              enumerator1 = this.moduleFullTextSearchExtensions.SelectMany<IModuleFullTextSearchExtension, KeyValuePair<Type, Dictionary<Guid, List<string>>>>((Func<IModuleFullTextSearchExtension, IEnumerable<KeyValuePair<Type, Dictionary<Guid, List<string>>>>>) (p => p.GetDynamicFieldsMapping().EmptyIfNull<KeyValuePair<Type, Dictionary<Guid, List<string>>>>())).Where<KeyValuePair<Type, Dictionary<Guid, List<string>>>>((Func<KeyValuePair<Type, Dictionary<Guid, List<string>>>, bool>) (p => p.Value != null)).GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
            default:
              goto label_29;
          }
        }
label_30:
        return;
label_29:
        return;
label_2:
        try
        {
label_21:
          if (enumerator1.MoveNext())
            goto label_23;
          else
            goto label_22;
label_3:
          KeyValuePair<Type, Dictionary<Guid, List<string>>> current1;
          Dictionary<Guid, List<string>>.Enumerator enumerator2;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_25;
              case 1:
                goto label_23;
              case 2:
                goto label_21;
              case 3:
                goto label_5;
              case 4:
                enumerator2 = current1.Value.GetEnumerator();
                num2 = 3;
                continue;
              default:
                goto label_19;
            }
          }
label_25:
          return;
label_19:
          return;
label_5:
          try
          {
label_13:
            if (enumerator2.MoveNext())
              goto label_7;
            else
              goto label_14;
label_6:
            KeyValuePair<Guid, List<string>> current2;
            FullTextTypeMappingService.MappingCardEntityFieldItem cardEntityFieldItem;
            Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem> dictionary;
            int num3;
            while (true)
            {
              switch (num3)
              {
                case 1:
                case 2:
                case 3:
                  this.mappings.Add(current2.Key, new Dictionary<Type, FullTextTypeMappingService.MappingCardEntityFieldItem>()
                  {
                    {
                      current1.Key,
                      new FullTextTypeMappingService.MappingCardEntityFieldItem(current1.Key, current2.Key, current2.Value)
                    }
                  });
                  num3 = 8;
                  continue;
                case 4:
                  goto label_21;
                case 5:
                  if (!this.mappings.TryGetValue(current2.Key, out dictionary))
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                    continue;
                  }
                  goto case 9;
                case 6:
                  cardEntityFieldItem.Add(current2.Value);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                  continue;
                case 7:
                  goto label_7;
                case 9:
                  if (!dictionary.TryGetValue(current1.Key, out cardEntityFieldItem))
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 3;
                    continue;
                  }
                  goto case 6;
                default:
                  goto label_13;
              }
            }
label_7:
            current2 = enumerator2.Current;
            num3 = 5;
            goto label_6;
label_14:
            num3 = 4;
            goto label_6;
          }
          finally
          {
            enumerator2.Dispose();
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
              num4 = 0;
            switch (num4)
            {
              default:
            }
          }
label_22:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
          goto label_3;
label_23:
          current1 = enumerator1.Current;
          num2 = 4;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
          {
            num2 = 2;
            goto label_3;
          }
          else
            goto label_3;
        }
        finally
        {
          int num5;
          if (enumerator1 == null)
            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
          else
            goto label_31;
label_28:
          switch (num5)
          {
            case 1:
            case 2:
          }
label_31:
          FullTextTypeMappingService.MappingCardEntityField.kLEeyVvLrgg0qFDFymfM((object) enumerator1);
          num5 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          {
            num5 = 2;
            goto label_28;
          }
          else
            goto label_28;
        }
      }

      internal static void kLEeyVvLrgg0qFDFymfM([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static bool QeLvdlvLd6TD3B9URPhC() => FullTextTypeMappingService.MappingCardEntityField.nJCYlcvL9OtnAKNyJkN3 == null;

      internal static FullTextTypeMappingService.MappingCardEntityField lo0xrJvLlUmkUafQe2Yv() => (FullTextTypeMappingService.MappingCardEntityField) FullTextTypeMappingService.MappingCardEntityField.nJCYlcvL9OtnAKNyJkN3;
    }

    /// <summary>Запись мэпинга динамических полей</summary>
    private class MappingCardEntityFieldItem
    {
      private Guid cardUid;
      private Guid entityTypeUid;
      private List<string> importantProperties;
      private static object GAduxFvLgUS0cyPXTbWt;

      public MappingCardEntityFieldItem(
        Type cardType,
        Guid entityTypeUid,
        List<string> importantProperties)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.importantProperties = new List<string>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.entityTypeUid = entityTypeUid;
        this.importantProperties = importantProperties ?? new List<string>();
        this.CardType = cardType;
        this.cardUid = Locator.GetServiceNotNull<IFullTextSearchCardService>().GetCardUidByCardType(cardType) ?? Guid.Empty;
      }

      public void Add(List<string> importantProperties)
      {
        if (importantProperties == null)
          return;
        foreach (string importantProperty in importantProperties)
        {
          if (!this.importantProperties.Contains(importantProperty))
            this.importantProperties.Add(importantProperty);
        }
      }

      public Type CardType
      {
        get => this.\u003CCardType\u003Ek__BackingField;
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
                this.\u003CCardType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

      public Guid CardUid => this.cardUid;

      public Guid EntityTypeUid => this.entityTypeUid;

      public List<string> ImportantProperties => this.importantProperties;

      internal static bool aIGs8MvL53LiLYE7A6h9() => FullTextTypeMappingService.MappingCardEntityFieldItem.GAduxFvLgUS0cyPXTbWt == null;

      internal static FullTextTypeMappingService.MappingCardEntityFieldItem pIlntivLjlLgC2YPeuiw() => (FullTextTypeMappingService.MappingCardEntityFieldItem) FullTextTypeMappingService.MappingCardEntityFieldItem.GAduxFvLgUS0cyPXTbWt;
    }
  }
}
