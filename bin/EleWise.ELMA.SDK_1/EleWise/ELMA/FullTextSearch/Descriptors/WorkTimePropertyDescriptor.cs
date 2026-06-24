// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.WorkTimePropertyDescriptor
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
  public class WorkTimePropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static WorkTimePropertyDescriptor qNstEWGu990mVm4LimTQ;

    public WorkTimePropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      WorkTimePropertyDescriptor.aE5xiDGurGROOPHkpQyv();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (reindex)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return this.GetIndexField(obj, propMd);
label_5:
      return this.GetReIndexField(obj, propMd);
    }

    private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 3;
      WorkTime workTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj is WorkTime)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 5 : 5;
              continue;
            }
            goto label_10;
          case 2:
            if (obj == null)
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 3:
            if (propMd != null)
            {
              num = 2;
              continue;
            }
            goto label_10;
          case 4:
            goto label_10;
          case 5:
            workTime = (WorkTime) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) (!workTime.HasValue ? new long?(0L) : new long?(WorkTimePropertyDescriptor.iTrtsdGugH6NwIZXudr9(workTime.Value))), FullTextFieldType.Long));
      return indexField;
label_10:
      return new FieldIndexList();
    }

    private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(obj is WorkTime))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 3;
              continue;
            }
            goto label_4;
          case 2:
            if (propMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
              continue;
            }
            goto label_10;
          case 3:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 4;
              continue;
            }
            goto label_9;
          case 4:
            goto label_10;
          case 5:
            goto label_4;
          default:
            goto label_9;
        }
      }
label_4:
      return this.GetIndexField(obj, propMd);
label_9:
      FieldIndexList reIndexField = new FieldIndexList();
      reIndexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) 0, FullTextFieldType.Long));
      return reIndexField;
label_10:
      return new FieldIndexList();
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      int num = 3;
      WorkTimeWrapper workTimeWrapper;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (workTimeWrapper != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            workTimeWrapper = value as WorkTimeWrapper;
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return (FilterListItem) null;
label_6:
      return new FilterListItem(this.ValueFieldName(propMd), new List<object>()
      {
        (object) WorkTimePropertyDescriptor.vrWa4KGu5v6UL7gfrxVv((object) workTimeWrapper)
      }, FilterListItemType.Must, FullTextFieldType.Long);
    }

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.Long);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 8;
      WebDataItem webDataItem;
      PropertyInfo propertyCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_36;
            case 2:
              goto label_27;
            case 3:
              if (!WorkTimePropertyDescriptor.YxoXfZGuYL2hfXxQVXVT((object) propertyCached, (object) null))
              {
                num2 = 10;
                continue;
              }
              goto label_3;
            case 4:
              if (!((string) WorkTimePropertyDescriptor.ztpcHLGuL0kESnc1eNsw((object) webDataItem) != this.ValueFieldName(propMd)))
              {
                num2 = 5;
                continue;
              }
              goto label_6;
            case 5:
              goto label_31;
            case 6:
              goto label_30;
            case 7:
              if (propMd == null)
              {
                num2 = 6;
                continue;
              }
              propertyCached = obj.GetType().GetPropertyCached((string) WorkTimePropertyDescriptor.QqNLwBGujqTZHlxOZw6A((object) propMd));
              num2 = 11;
              continue;
            case 8:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 7 : 4;
                continue;
              }
              goto label_38;
            case 9:
              goto label_12;
            case 10:
              if (webDataItem == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 11:
              webDataItem = value as WebDataItem;
              num2 = 3;
              continue;
            default:
              goto label_37;
          }
        }
label_31:
        num1 = 9;
      }
label_7:
      return;
label_36:
      return;
label_27:
      return;
label_30:
      return;
label_37:
      return;
label_38:
      return;
label_6:
      return;
label_12:
      try
      {
        long result;
        int num3;
        if (long.TryParse((string) WorkTimePropertyDescriptor.JBp9jYGuUXnGfPpZAKaP((object) webDataItem), out result))
          num3 = 3;
        else
          goto label_17;
label_14:
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_26;
            case 1:
              goto label_17;
            case 2:
              goto label_24;
            case 3:
              propertyCached.SetValue(obj, (object) new WorkTime(result), (object[]) null);
              num3 = 2;
              continue;
            default:
              goto label_20;
          }
        }
label_26:
        return;
label_24:
        return;
label_20:
        return;
label_17:
        WorkTimePropertyDescriptor.WS3uqkGusX9sCXMxruSI((object) propertyCached, obj, (object) new WorkTime(0), (object) null);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        {
          num3 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
      catch (Exception ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_16;
            case 1:
              WorkTimePropertyDescriptor.qEOsg7GuzEyYTEp9hMBg((object) Logger.Log, WorkTimePropertyDescriptor.BKHxPSGucdGMd0EXLbmm(323422137 << 2 ^ 1293931532), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
label_16:
        return;
label_15:
        return;
      }
label_3:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 1;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto label_30;
          case 2:
            propertyCached = obj.GetType().GetPropertyCached((string) WorkTimePropertyDescriptor.QqNLwBGujqTZHlxOZw6A((object) propMd));
            num1 = 4;
            continue;
          case 3:
            goto label_3;
          case 4:
            if (WorkTimePropertyDescriptor.YxoXfZGuYL2hfXxQVXVT((object) propertyCached, (object) null))
            {
              num1 = 3;
              continue;
            }
            goto case 6;
          case 5:
            goto label_7;
          case 6:
            if (!WorkTimePropertyDescriptor.qainxxGIFeonDXlN0Frf((object) fieldName, (object) this.ValueFieldName(propMd)))
            {
              num1 = 7;
              continue;
            }
            goto label_4;
          case 7:
            if (!(propMd is PropertyMetadata))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 9 : 9;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 5 : 2;
            continue;
          case 8:
            goto label_21;
          case 9:
            goto label_2;
          case 10:
            goto label_26;
          default:
            if (propMd != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 0;
              continue;
            }
            goto label_29;
        }
      }
label_3:
      return;
label_21:
      return;
label_2:
      return;
label_26:
      return;
label_7:
      try
      {
        WorkTimePropertyDescriptor.WS3uqkGusX9sCXMxruSI((object) propertyCached, obj, (object) new WorkTime(), (object) null);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
          num2 = 0;
        switch (num2)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_29:
      return;
label_4:
      return;
label_30:;
    }

    internal static void aE5xiDGurGROOPHkpQyv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool BgSiAeGudpa3mSALKvJg() => WorkTimePropertyDescriptor.qNstEWGu990mVm4LimTQ == null;

    internal static WorkTimePropertyDescriptor UfncJIGul5tKcmEDVKiZ() => WorkTimePropertyDescriptor.qNstEWGu990mVm4LimTQ;

    internal static long iTrtsdGugH6NwIZXudr9([In] long obj0) => Convert.ToInt64(obj0);

    internal static long vrWa4KGu5v6UL7gfrxVv([In] object obj0) => ((WorkTimeWrapper) obj0).Value;

    internal static object QqNLwBGujqTZHlxOZw6A([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool YxoXfZGuYL2hfXxQVXVT([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object ztpcHLGuL0kESnc1eNsw([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static object JBp9jYGuUXnGfPpZAKaP([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static void WS3uqkGusX9sCXMxruSI([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object BKHxPSGucdGMd0EXLbmm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void qEOsg7GuzEyYTEp9hMBg([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool qainxxGIFeonDXlN0Frf([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;
  }
}
