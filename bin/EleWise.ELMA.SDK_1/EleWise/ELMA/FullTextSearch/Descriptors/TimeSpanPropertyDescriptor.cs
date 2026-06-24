// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.TimeSpanPropertyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
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
  public class TimeSpanPropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static TimeSpanPropertyDescriptor Hne08EGIBkO27JekZA1x;

    public TimeSpanPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TimeSpanPropertyDescriptor.whe80mGIb3i9qHBNdpxK();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
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
            if (!reindex)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetIndexField(obj, propMd);
label_3:
      return this.GetReIndexField(obj, propMd);
    }

    private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
    {
      int num1 = 1;
      TimeSpan timeSpan;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (propMd == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 2:
              timeSpan = (TimeSpan) obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 2;
              continue;
            case 3:
              goto label_8;
            case 5:
              if (obj != null)
                goto case 6;
              else
                goto label_11;
            case 6:
              if (obj is TimeSpan)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 2;
                continue;
              }
              goto label_9;
            default:
              goto label_9;
          }
        }
label_11:
        num1 = 4;
      }
label_8:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) TimeSpanPropertyDescriptor.H2CpafGIh04ZdN9xFFRV(timeSpan.Ticks), FullTextFieldType.Long));
      return indexField;
label_9:
      return new FieldIndexList();
    }

    private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (obj is TimeSpan)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 5 : 2;
              continue;
            }
            goto label_4;
          case 3:
          case 5:
            goto label_5;
          case 4:
            if (propMd == null)
            {
              num = 3;
              continue;
            }
            goto case 2;
          default:
            goto label_8;
        }
      }
label_4:
      FieldIndexList reIndexField = new FieldIndexList();
      reIndexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.Long));
      return reIndexField;
label_5:
      return new FieldIndexList();
label_8:
      return this.GetIndexField(obj, propMd);
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      switch (1)
      {
        case 1:
          FilterListItem filterField;
          try
          {
            TimeSpanWrapper timeSpanWrapper = value as TimeSpanWrapper;
            int num = 7;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
              num = 2;
            TimeSpan? nullable;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_15;
                case 2:
                case 4:
                case 6:
                  goto label_14;
                case 3:
                  string field = this.ValueFieldName(propMd);
                  List<object> values = new List<object>();
                  nullable = timeSpanWrapper.Value;
                  values.Add((object) nullable.Value.Ticks);
                  filterField = new FilterListItem(field, values, FilterListItemType.Must, FullTextFieldType.Long);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
                  continue;
                case 5:
                  nullable = timeSpanWrapper.Value;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                  continue;
                case 7:
                  if (timeSpanWrapper == null)
                  {
                    num = 4;
                    continue;
                  }
                  goto case 5;
                default:
                  if (!nullable.HasValue)
                  {
                    num = 2;
                    continue;
                  }
                  goto case 3;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  filterField = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
label_15:
          return filterField;
      }
label_14:
      return (FilterListItem) null;
    }

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.Long);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 5;
      WebDataItem webDataItem;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            if (!TimeSpanPropertyDescriptor.ADr3xEGIf2e6dxKNi9Sg((object) webDataItem.Name, (object) this.ValueFieldName(propMd)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 6 : 0;
            continue;
          case 3:
            webDataItem = value as WebDataItem;
            num1 = 8;
            continue;
          case 4:
            if (propMd != null)
            {
              propertyCached = obj.GetType().GetPropertyCached((string) TimeSpanPropertyDescriptor.mv4JCYGIGbQXyZGrYobW((object) propMd));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
            continue;
          case 5:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 4 : 4;
              continue;
            }
            goto label_25;
          case 6:
            goto label_32;
          case 7:
            if (webDataItem != null)
            {
              num1 = 2;
              continue;
            }
            goto label_30;
          case 8:
            if (TimeSpanPropertyDescriptor.gV7FX0GIEcrsjJ6tsRPp((object) propertyCached, (object) null))
            {
              num1 = 9;
              continue;
            }
            goto case 7;
          case 9:
            goto label_26;
          case 10:
            goto label_8;
          default:
            goto label_16;
        }
      }
label_4:
      return;
label_32:
      return;
label_26:
      return;
label_8:
      return;
label_25:
      return;
label_16:
      try
      {
        long result;
        int num2;
        if (!long.TryParse(webDataItem.Value, out result))
          num2 = 4;
        else
          goto label_21;
label_19:
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_23;
            case 2:
            case 4:
              TimeSpanPropertyDescriptor.wxkrTqGIQRrYpGrcGinp((object) propertyCached, obj, (object) null, (object) null);
              num2 = 3;
              continue;
            case 3:
              goto label_20;
            default:
              goto label_21;
          }
        }
label_23:
        return;
label_20:
        return;
label_21:
        TimeSpanPropertyDescriptor.wxkrTqGIQRrYpGrcGinp((object) propertyCached, obj, (object) new TimeSpan(result), (object) null);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        {
          num2 = 1;
          goto label_19;
        }
        else
          goto label_19;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_7;
            default:
              TimeSpanPropertyDescriptor.ExcdWPGIvbj6bAgk61bO((object) Logger.Log, TimeSpanPropertyDescriptor.GxFyZAGIChb6YqstuU4E(222162814 ^ 222176662), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
              continue;
          }
        }
label_7:
        return;
      }
label_30:;
    }

    internal static void whe80mGIb3i9qHBNdpxK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HcbWRiGIWHbf9ipCDbMR() => TimeSpanPropertyDescriptor.Hne08EGIBkO27JekZA1x == null;

    internal static TimeSpanPropertyDescriptor wgauRWGIo8ZmF8fidKVk() => TimeSpanPropertyDescriptor.Hne08EGIBkO27JekZA1x;

    internal static long H2CpafGIh04ZdN9xFFRV([In] long obj0) => Convert.ToInt64(obj0);

    internal static object mv4JCYGIGbQXyZGrYobW([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool gV7FX0GIEcrsjJ6tsRPp([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool ADr3xEGIf2e6dxKNi9Sg([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void wxkrTqGIQRrYpGrcGinp([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object GxFyZAGIChb6YqstuU4E(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void ExcdWPGIvbj6bAgk61bO([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);
  }
}
