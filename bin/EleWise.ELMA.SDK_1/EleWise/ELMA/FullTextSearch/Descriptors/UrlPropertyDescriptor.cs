// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.UrlPropertyDescriptor
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

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class UrlPropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static UrlPropertyDescriptor iVXhgjGZCsr61r6UdSCV;

    public UrlPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool IsSupportedFullTextSearchInIndex => true;

    /// <inheritdoc />
    public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      FieldIndexList mappingField = new FieldIndexList();
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
      mappingField.Add(new FieldIndexListItem(this.SortFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Sort));
      return mappingField;
    }

    public override FieldIndexList GetIndexField(
      object obj,
      IPropertyMetadata propMd,
      bool reindex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return new FieldIndexList();
label_5:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), UrlPropertyDescriptor.KvkhxLGZZcnPvEtJPfTx(obj), FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.SortFieldName(propMd), UrlPropertyDescriptor.mlVGwuGZuYduCxlgBs27(obj), FullTextFieldType.String));
      return indexField;
    }

    public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
    {
      int num = 1;
      UriWrapper uriWrapper;
      while (true)
      {
        switch (num)
        {
          case 1:
            uriWrapper = value as UriWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new FieldListItem(this.ValueFieldName(propMd), uriWrapper == null || UrlPropertyDescriptor.gDIpMDGZIi215XhjFLyl((object) uriWrapper) == null ? string.Empty : uriWrapper.UriValue);
    }

    public override List<string> GetReturnField(IPropertyMetadata propMd) => new List<string>()
    {
      this.ValueFieldName(propMd)
    };

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.SortFieldName(propMd), FullTextFieldType.String);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 3;
      PropertyInfo propertyCached;
      WebDataItem webDataItem;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              webDataItem = value as WebDataItem;
              num2 = 11;
              continue;
            case 2:
              goto label_16;
            case 3:
              if (obj == null)
              {
                num2 = 2;
                continue;
              }
              goto case 13;
            case 4:
              goto label_17;
            case 5:
              goto label_9;
            case 6:
              goto label_24;
            case 7:
              goto label_5;
            case 8:
              goto label_8;
            case 9:
              goto label_34;
            case 10:
              if (webDataItem == null)
              {
                num2 = 8;
                continue;
              }
              goto case 12;
            case 11:
              if (UrlPropertyDescriptor.b0u4KwGZSwilhUhKwttU((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 12:
              if (!((string) UrlPropertyDescriptor.Tlw5MJGZiERseEE9AS7x((object) webDataItem) != this.ValueFieldName(propMd)))
              {
                num2 = 4;
                continue;
              }
              goto label_13;
            case 13:
              if (propMd != null)
              {
                propertyCached = obj.GetType().GetPropertyCached((string) UrlPropertyDescriptor.x4Jb3oGZVBK7I5S9kvPV((object) propMd));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 9 : 6;
              continue;
            default:
              goto label_3;
          }
        }
label_17:
        num1 = 7;
      }
label_4:
      return;
label_16:
      return;
label_9:
      return;
label_24:
      return;
label_8:
      return;
label_34:
      return;
label_3:
      return;
label_5:
      try
      {
        UrlPropertyDescriptor.uIa2amGZqx8qCh6x0avj((object) propertyCached, obj, (object) new Uri((string) UrlPropertyDescriptor.cxQekMGZRtre6QEjA05l((object) webDataItem), UriKind.RelativeOrAbsolute), (object) null);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
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
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_19;
            case 1:
              Logger.Log.Warn(UrlPropertyDescriptor.ustCc4GZKMxHUVhPlYAe(-342626196 - 1290888215 ^ -1633597763), ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
label_19:
        return;
label_15:
        return;
      }
label_13:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 6;
      PropertyInfo propertyCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!(propMd is PropertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 3 : 3;
                continue;
              }
              num2 = 8;
              continue;
            case 2:
              goto label_33;
            case 3:
              goto label_28;
            case 4:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                continue;
              }
              goto label_32;
            case 5:
              goto label_35;
            case 6:
              if (obj != null)
                goto case 4;
              else
                goto label_4;
            case 7:
              goto label_22;
            case 8:
              goto label_12;
            case 9:
              if (UrlPropertyDescriptor.BiD9P3GZXNtyCED5rWhB((object) fieldName, (object) this.ValueFieldName(propMd)))
              {
                num2 = 7;
                continue;
              }
              goto case 1;
            case 10:
              if (!UrlPropertyDescriptor.b0u4KwGZSwilhUhKwttU((object) propertyCached, (object) null))
              {
                num2 = 9;
                continue;
              }
              goto label_26;
            case 11:
              goto label_27;
            default:
              propertyCached = obj.GetType().GetPropertyCached((string) UrlPropertyDescriptor.x4Jb3oGZVBK7I5S9kvPV((object) propMd));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 10 : 8;
              continue;
          }
        }
label_4:
        num1 = 5;
      }
label_33:
      return;
label_28:
      return;
label_35:
      return;
label_22:
      return;
label_27:
      return;
label_32:
      return;
label_12:
      try
      {
        int num3;
        if (!UrlPropertyDescriptor.ABF9EmGZTjktXRhNW83a((object) (propMd as PropertyMetadata)))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
        else
          goto label_21;
label_14:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, UrlPropertyDescriptor.MsObLcGZknjnrbOsfhSS(__typeref (Uri)));
              num3 = 6;
              continue;
            case 3:
              goto label_20;
            case 4:
              goto label_16;
            case 5:
              goto label_21;
            case 6:
              UrlPropertyDescriptor.uIa2amGZqx8qCh6x0avj((object) propertyCached, obj, obj2, (object) null);
              num3 = 3;
              continue;
            default:
              // ISSUE: type reference
              obj1 = this.TypeDescriptor.SerializeSimple((object) null, UrlPropertyDescriptor.MsObLcGZknjnrbOsfhSS(__typeref (Uri)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
              continue;
          }
        }
label_20:
        return;
label_16:
        return;
label_21:
        UrlPropertyDescriptor.uIa2amGZqx8qCh6x0avj((object) propertyCached, obj, (object) null, (object) null);
        num3 = 4;
        goto label_14;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_26:;
    }

    internal static bool blPtjCGZv6qc3BkgoQOd() => UrlPropertyDescriptor.iVXhgjGZCsr61r6UdSCV == null;

    internal static UrlPropertyDescriptor XIXu2VGZ8To9VftyuN9W() => UrlPropertyDescriptor.iVXhgjGZCsr61r6UdSCV;

    internal static object KvkhxLGZZcnPvEtJPfTx([In] object obj0) => (object) Convert.ToString(obj0);

    internal static object mlVGwuGZuYduCxlgBs27([In] object obj0) => (object) StringPropertyDescriptor.ConvertToSortable(obj0);

    internal static object gDIpMDGZIi215XhjFLyl([In] object obj0) => (object) ((UriWrapper) obj0).UriValue;

    internal static object x4Jb3oGZVBK7I5S9kvPV([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool b0u4KwGZSwilhUhKwttU([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object Tlw5MJGZiERseEE9AS7x([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static object cxQekMGZRtre6QEjA05l([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static void uIa2amGZqx8qCh6x0avj([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object ustCc4GZKMxHUVhPlYAe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool BiD9P3GZXNtyCED5rWhB([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool ABF9EmGZTjktXRhNW83a([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type MsObLcGZknjnrbOsfhSS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
