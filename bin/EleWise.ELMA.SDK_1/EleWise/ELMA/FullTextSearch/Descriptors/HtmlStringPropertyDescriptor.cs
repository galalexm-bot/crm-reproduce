// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.HtmlStringPropertyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class HtmlStringPropertyDescriptor : FullTextPropertyDescriptor
  {
    private static HtmlStringPropertyDescriptor EjIYvwG8ktjdSXDxYJ4E;

    public HtmlStringPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      FieldIndexList mappingField = new FieldIndexList();
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
      mappingField.Add(new FieldIndexListItem(this.SortFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Sort));
      return mappingField;
    }

    public override bool IsSupportedFullTextSearchInIndex => true;

    public override FieldIndexList GetIndexField(
      object obj,
      IPropertyMetadata propMd,
      bool reindex)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_6;
          case 3:
            goto label_2;
          default:
            str = (string) HtmlStringPropertyDescriptor.k6MQAOG822wqK330is5A(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return new FieldIndexList();
label_6:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) str, FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.SortFieldName(propMd), (object) str, FullTextFieldType.String));
      return indexField;
    }

    public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
    {
      int num = 1;
      HtmlStringWrapper htmlStringWrapper;
      while (true)
      {
        switch (num)
        {
          case 1:
            htmlStringWrapper = value as HtmlStringWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new FieldListItem(this.ValueFieldName(propMd), htmlStringWrapper == null || HtmlStringPropertyDescriptor.DNvwxpG8eCZHJhiTSwn9((object) htmlStringWrapper) == null ? string.Empty : (string) HtmlStringPropertyDescriptor.DNvwxpG8eCZHJhiTSwn9((object) htmlStringWrapper));
    }

    public override List<string> GetReturnField(IPropertyMetadata propMd) => new List<string>()
    {
      this.ValueFieldName(propMd)
    };

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.SortFieldName(propMd), FullTextFieldType.String);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 4;
      WebDataItem webDataItem;
      PropertyInfo propertyCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (propertyCached == (PropertyInfo) null)
              {
                num2 = 2;
                continue;
              }
              goto case 7;
            case 2:
              goto label_26;
            case 3:
              if (propMd != null)
              {
                propertyCached = obj.GetType().GetPropertyCached((string) HtmlStringPropertyDescriptor.LH0P7SG8PHdD2H0B1hUb((object) propMd));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 5 : 1;
                continue;
              }
              num2 = 6;
              continue;
            case 4:
              if (obj != null)
              {
                num2 = 3;
                continue;
              }
              goto label_16;
            case 5:
              webDataItem = value as WebDataItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
              continue;
            case 6:
              goto label_17;
            case 7:
              if (webDataItem == null)
              {
                num2 = 8;
                continue;
              }
              break;
            case 8:
              goto label_8;
            case 9:
              goto label_5;
            case 10:
              goto label_3;
            case 11:
              goto label_18;
          }
          if (!HtmlStringPropertyDescriptor.jZpC05G8NWxLRYsoHNo9(HtmlStringPropertyDescriptor.wPIoFSG817k2Y0JW98RK((object) webDataItem), (object) this.ValueFieldName(propMd)))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 9 : 8;
          else
            break;
        }
        num1 = 10;
      }
label_26:
      return;
label_17:
      return;
label_8:
      return;
label_3:
      return;
label_18:
      return;
label_5:
      try
      {
        HtmlStringPropertyDescriptor.RRrtBAG83j4CbwjsaDeJ((object) propertyCached, obj, (object) new HtmlString(webDataItem.Value), (object) null);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_9;
            default:
              ((ILogger) HtmlStringPropertyDescriptor.NAPPF4G8p6Cr8Sd97Qtf()).Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195763203), ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
              continue;
          }
        }
label_9:
        return;
      }
label_16:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 3;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_27;
          case 2:
            goto label_7;
          case 3:
            if (obj == null)
            {
              num1 = 2;
              continue;
            }
            goto case 9;
          case 4:
            if (!(propertyCached == (PropertyInfo) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            }
            goto label_22;
          case 5:
            if (propMd is PropertyMetadata)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 5 : 7;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_28;
          case 7:
            goto label_13;
          case 8:
            goto label_16;
          case 9:
            if (propMd != null)
            {
              num1 = 10;
              continue;
            }
            goto label_17;
          case 10:
            propertyCached = obj.GetType().GetPropertyCached((string) HtmlStringPropertyDescriptor.LH0P7SG8PHdD2H0B1hUb((object) propMd));
            num1 = 4;
            continue;
          default:
            if (!HtmlStringPropertyDescriptor.jZpC05G8NWxLRYsoHNo9((object) fieldName, (object) this.ValueFieldName(propMd)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 5;
              continue;
            }
            goto label_26;
        }
      }
label_27:
      return;
label_7:
      return;
label_28:
      return;
label_16:
      return;
label_26:
      return;
label_17:
      return;
label_22:
      return;
label_13:
      try
      {
        int num2;
        if (HtmlStringPropertyDescriptor.nD2BHYG8ag838DhGtvje((object) (propMd as PropertyMetadata)))
          num2 = 2;
        else
          goto label_18;
label_15:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_6;
            case 1:
              propertyCached.SetValue(obj, obj2, (object[]) null);
              num2 = 5;
              continue;
            case 2:
              propertyCached.SetValue(obj, (object) null, (object[]) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_18;
            case 4:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, HtmlStringPropertyDescriptor.XmxiEGG8D131UCp7KYhF(__typeref (HtmlString)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
              continue;
            case 5:
              goto label_5;
            default:
              goto label_2;
          }
        }
label_6:
        return;
label_5:
        return;
label_2:
        return;
label_18:
        // ISSUE: type reference
        obj1 = this.TypeDescriptor.SerializeSimple((object) null, HtmlStringPropertyDescriptor.XmxiEGG8D131UCp7KYhF(__typeref (HtmlString)));
        num2 = 4;
        goto label_15;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
    }

    internal static bool VKt2t3G8nVPVp24pV2Fj() => HtmlStringPropertyDescriptor.EjIYvwG8ktjdSXDxYJ4E == null;

    internal static HtmlStringPropertyDescriptor OZLhQQG8Oj9RFOHdasZ8() => HtmlStringPropertyDescriptor.EjIYvwG8ktjdSXDxYJ4E;

    internal static object k6MQAOG822wqK330is5A([In] object obj0) => (object) Convert.ToString(obj0);

    internal static object DNvwxpG8eCZHJhiTSwn9([In] object obj0) => (object) ((HtmlStringWrapper) obj0).HtmlValue;

    internal static object LH0P7SG8PHdD2H0B1hUb([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static object wPIoFSG817k2Y0JW98RK([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool jZpC05G8NWxLRYsoHNo9([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void RRrtBAG83j4CbwjsaDeJ([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object NAPPF4G8p6Cr8Sd97Qtf() => (object) Logger.Log;

    internal static bool nD2BHYG8ag838DhGtvje([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type XmxiEGG8D131UCp7KYhF([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
