// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Services.FullTextSearchDescriptorService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Services
{
  /// <summary>Сервис работы с дескрипторами полнотекстового поиска</summary>
  [Service]
  internal class FullTextSearchDescriptorService : 
    IFullTextSearchDescriptorMappingService,
    IFullTextSearchDescriptorService
  {
    private readonly IDictionary<(Guid TypeUid, Guid SubTypeUid), IFullTextPropertyDescriptor> descriptorList;
    private readonly IFullTextPropertyMappingDescriptor defaultPropertyDescriptor;
    internal static FullTextSearchDescriptorService sUJB34GSQSck3JBRdbGV;

    private IFullTextPropertyDescriptor GetDescriptor(IPropertyMetadata propertyMd)
    {
      int num1 = 2;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        int num2 = num1;
        IFullTextTypeDescriptor textTypeDescriptor;
        (Guid, Guid) key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              key = (FullTextSearchDescriptorService.qvjlsrGS8UQydnyUcF03((object) propertyMd), FullTextSearchDescriptorService.AYgFxUGSZshLKCvcxME5((object) propertyMd));
              num2 = 4;
              continue;
            case 2:
              if (propertyMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
                continue;
              }
              goto label_9;
            case 3:
              textTypeDescriptor = FullTextSearchDescriptorService.Yv3o45GSuRurQWVoH5Km((object) MetadataServiceContext.Service, propertyMd.TypeUid, FullTextSearchDescriptorService.AYgFxUGSZshLKCvcxME5((object) propertyMd)) as IFullTextTypeDescriptor;
              num2 = 7;
              continue;
            case 4:
              if (!this.descriptorList.TryGetValue(key, out descriptor))
                goto case 3;
              else
                goto label_7;
            case 6:
              goto label_9;
            case 7:
              this.descriptorList[key] = descriptor = textTypeDescriptor != null ? (IFullTextPropertyDescriptor) FullTextSearchDescriptorService.b6q3tVGSIyN25rg84Cn0((object) textTypeDescriptor) : (IFullTextPropertyDescriptor) (object) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            default:
              goto label_8;
          }
        }
label_7:
        num1 = 5;
      }
label_8:
      return descriptor;
label_9:
      return (IFullTextPropertyDescriptor) null;
    }

    public bool IsSupportedIndexing(IPropertyMetadata propMd)
    {
      int num = 1;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_6;
          default:
            if (descriptor == null)
            {
              num = 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return descriptor.IsSupportedIndexing;
label_6:
      return false;
    }

    public bool IsSupportedSearchInIndex(IPropertyMetadata propMd)
    {
      int num1 = 5;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EntitySettings settings;
          switch (num2)
          {
            case 1:
              if (FullTextSearchDescriptorService.IvXegCGSV3rHpqHKS3rY((object) settings) == RelationType.OneToMany)
              {
                num2 = 2;
                continue;
              }
              break;
            case 2:
              goto label_12;
            case 3:
              goto label_4;
            case 4:
              if (settings != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                continue;
              }
              break;
            case 5:
              settings = propMd.Settings as EntitySettings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 4;
              continue;
            case 6:
              goto label_3;
            default:
              goto label_5;
          }
          descriptor = this.GetDescriptor(propMd);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
        }
label_5:
        if (descriptor == null)
          num1 = 3;
        else
          break;
      }
label_3:
      return FullTextSearchDescriptorService.qRn8ajGSS2cRHEZk5x3U((object) descriptor);
label_4:
      return false;
label_12:
      return false;
    }

    public bool IsSupportedFullTextSearchInIndex(IPropertyMetadata propMd)
    {
      int num = 2;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (descriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return FullTextSearchDescriptorService.tC6sF5GSivjrtOtvGZlA((object) descriptor);
label_6:
      return false;
    }

    public FieldIndexList GetIndexField(object value, IPropertyMetadata propMd, bool reindex)
    {
      int num = 2;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (descriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return descriptor.GetIndexField(value, propMd, reindex);
label_4:
      return (FieldIndexList) FullTextSearchDescriptorService.bsH8UKGSRDxWYf0pWxDO((object) this.defaultPropertyDescriptor, value, (object) propMd, reindex);
    }

    public FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
    {
      int num = 2;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (descriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (FieldListItem) FullTextSearchDescriptorService.ti4vnuGSqNSnA0I2IwAn((object) descriptor, value, (object) propMd);
label_6:
      return (FieldListItem) FullTextSearchDescriptorService.ti4vnuGSqNSnA0I2IwAn((object) this.defaultPropertyDescriptor, value, (object) propMd);
    }

    public FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      int num = 3;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (descriptor == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return (FilterListItem) FullTextSearchDescriptorService.BunUlfGSKjo8mwfgkKCw((object) descriptor, value, (object) propMd, (object) filter);
label_3:
      return (FilterListItem) FullTextSearchDescriptorService.BunUlfGSKjo8mwfgkKCw((object) this.defaultPropertyDescriptor, value, (object) propMd, (object) filter);
    }

    public List<string> GetReturnField(IPropertyMetadata propMd)
    {
      IFullTextPropertyDescriptor descriptor = this.GetDescriptor(propMd);
      return descriptor != null ? descriptor.GetReturnField(propMd) : this.defaultPropertyDescriptor.GetReturnField(propMd);
    }

    public SortListItem GetSortField(IPropertyMetadata propMd)
    {
      int num = 2;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (descriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return descriptor.GetSortField(propMd);
label_3:
      return (SortListItem) FullTextSearchDescriptorService.THAKD3GSXRRHfExhwhjN((object) this.defaultPropertyDescriptor, (object) propMd);
    }

    public void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num = 1;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.defaultPropertyDescriptor.SetIndexField(obj, value, propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 0;
            continue;
          case 4:
            goto label_7;
          case 5:
            FullTextSearchDescriptorService.bNB6QhGSTtk9ElGwyfYc((object) descriptor, obj, value, (object) propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 4;
            continue;
          default:
            if (descriptor != null)
            {
              num = 5;
              continue;
            }
            goto case 3;
        }
      }
label_2:
      return;
label_7:;
    }

    public void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num = 2;
      IFullTextPropertyDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (descriptor == null)
            {
              num = 3;
              continue;
            }
            descriptor.SetEmptyIndexField(obj, propMd, fieldName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
            descriptor = this.GetDescriptor(propMd);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
            continue;
          case 3:
            FullTextSearchDescriptorService.N8L2lLGSkfjvhNEmyrFr((object) this.defaultPropertyDescriptor, obj, (object) propMd, (object) fieldName);
            num = 4;
            continue;
          case 4:
            goto label_3;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_3:
      return;
label_9:;
    }

    /// <inheritdoc />
    public FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      int num = 1;
      IFullTextPropertyMappingDescriptor descriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            descriptor = this.GetDescriptor(propMd) as IFullTextPropertyMappingDescriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            if (descriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
              continue;
            }
            goto label_4;
        }
      }
label_3:
      return descriptor.GetMappingField(propMd);
label_4:
      return (FieldIndexList) FullTextSearchDescriptorService.wnhMHNGSneMGrs3j2gVB((object) this.defaultPropertyDescriptor, (object) propMd);
    }

    public FullTextSearchDescriptorService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.descriptorList = (IDictionary<(Guid, Guid), IFullTextPropertyDescriptor>) new Dictionary<(Guid, Guid), IFullTextPropertyDescriptor>();
      this.defaultPropertyDescriptor = (IFullTextPropertyMappingDescriptor) new NoFullTextPropertyDescriptor();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid qvjlsrGS8UQydnyUcF03([In] object obj0) => ((IPropertyMetadata) obj0).TypeUid;

    internal static Guid AYgFxUGSZshLKCvcxME5([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static object Yv3o45GSuRurQWVoH5Km([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object b6q3tVGSIyN25rg84Cn0([In] object obj0) => (object) ((IFullTextTypeDescriptor) obj0).FullTextPropertyDescriptor;

    internal static bool e0OpiTGSCZwbvyMSiUPQ() => FullTextSearchDescriptorService.sUJB34GSQSck3JBRdbGV == null;

    internal static FullTextSearchDescriptorService QIwFstGSvVfurhXbcno0() => FullTextSearchDescriptorService.sUJB34GSQSck3JBRdbGV;

    internal static RelationType IvXegCGSV3rHpqHKS3rY([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static bool qRn8ajGSS2cRHEZk5x3U([In] object obj0) => ((IFullTextPropertyDescriptor) obj0).IsSupportedSearchInIndex;

    internal static bool tC6sF5GSivjrtOtvGZlA([In] object obj0) => ((IFullTextPropertyDescriptor) obj0).IsSupportedFullTextSearchInIndex;

    internal static object bsH8UKGSRDxWYf0pWxDO(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool reindex)
    {
      return (object) ((IFullTextPropertyDescriptor) obj0).GetIndexField(obj1, (IPropertyMetadata) obj2, reindex);
    }

    internal static object ti4vnuGSqNSnA0I2IwAn([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IFullTextPropertyDescriptor) obj0).GetSearchField(obj1, (IPropertyMetadata) obj2);

    internal static object BunUlfGSKjo8mwfgkKCw(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IFullTextPropertyDescriptor) obj0).GetFilterField(obj1, (IPropertyMetadata) obj2, (IEntityFilter) obj3);
    }

    internal static object THAKD3GSXRRHfExhwhjN([In] object obj0, [In] object obj1) => (object) ((IFullTextPropertyDescriptor) obj0).GetSortField((IPropertyMetadata) obj1);

    internal static void bNB6QhGSTtk9ElGwyfYc([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IFullTextPropertyDescriptor) obj0).SetIndexField(obj1, obj2, (IPropertyMetadata) obj3);

    internal static void N8L2lLGSkfjvhNEmyrFr([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IFullTextPropertyDescriptor) obj0).SetEmptyIndexField(obj1, (IPropertyMetadata) obj2, (string) obj3);

    internal static object wnhMHNGSneMGrs3j2gVB([In] object obj0, [In] object obj1) => (object) ((IFullTextPropertyMappingDescriptor) obj0).GetMappingField((IPropertyMetadata) obj1);
  }
}
