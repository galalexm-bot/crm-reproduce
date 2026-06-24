// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.Int32PropertyDescriptor
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
  public class Int32PropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static Int32PropertyDescriptor uqqYVkGIPCMgNcHWoQ6R;

    public Int32PropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      Int32PropertyDescriptor.knsBjkGI3PH1jdq3egV4();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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
            if (propMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) (obj != null ? new long?(Int32PropertyDescriptor.ufspQXGIpiKEpedun9we(obj)) : new long?()), FullTextFieldType.Long));
      return indexField;
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      FilterListItem filterField1;
      switch (1)
      {
        case 1:
          FilterListItem filterField2;
          try
          {
            Int32RangeWrapper int32RangeWrapper = value as Int32RangeWrapper;
            int num = 8;
            List<object> values;
            while (true)
            {
              switch (num)
              {
                case 1:
                  values.Add((object) (!Int32PropertyDescriptor.YTWx3fGIDdT6saEr1xXg((object) int32RangeWrapper) ? new long?() : new long?(Int32PropertyDescriptor.dBloHEGIwDU0THat8tvJ(Int32PropertyDescriptor.hXBG4sGI4kTDQjwSCKsb((object) int32RangeWrapper)))));
                  num = 5;
                  continue;
                case 2:
                case 3:
                  values = new List<object>();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 10 : 4;
                  continue;
                case 4:
                  filterField1 = new FilterListItem(this.ValueFieldName(propMd), new List<object>()
                  {
                    (object) (value != null ? new long?(Int32PropertyDescriptor.ufspQXGIpiKEpedun9we(value)) : new long?())
                  }, FilterListItemType.Must, FullTextFieldType.Long);
                  num = 11;
                  continue;
                case 5:
                  filterField1 = new FilterListItem(this.ValueFieldName(propMd), values, FilterListItemType.Between, FullTextFieldType.Long);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 12;
                  continue;
                case 6:
                  goto label_2;
                case 7:
                  if (!Int32PropertyDescriptor.YTWx3fGIDdT6saEr1xXg((object) int32RangeWrapper))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                    continue;
                  }
                  goto case 2;
                case 8:
                  if (int32RangeWrapper != null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 9 : 9;
                    continue;
                  }
                  goto case 4;
                case 9:
                  if (Int32PropertyDescriptor.HcZsX0GIaBnesKbS0ejI((object) int32RangeWrapper))
                  {
                    num = 2;
                    continue;
                  }
                  goto case 7;
                case 10:
                  values.Add((object) (Int32PropertyDescriptor.HcZsX0GIaBnesKbS0ejI((object) int32RangeWrapper) ? new long?(Int32PropertyDescriptor.dBloHEGIwDU0THat8tvJ(Int32PropertyDescriptor.wopHeiGItwMn8uscsyr8((object) int32RangeWrapper))) : new long?()));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                  continue;
                case 11:
                case 12:
                  goto label_1;
                default:
                  filterField2 = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 6 : 6;
                  continue;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  filterField2 = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_2;
              }
            }
          }
label_2:
          return filterField2;
      }
label_1:
      return filterField1;
    }

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.Long);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 9;
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
              webDataItem = value as WebDataItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 7;
              continue;
            case 2:
              if (webDataItem != null)
              {
                num2 = 4;
                continue;
              }
              goto label_16;
            case 3:
              goto label_24;
            case 4:
              if (Int32PropertyDescriptor.VRw4h8GIAsb5Q8ygH6ph(Int32PropertyDescriptor.i13rNZGIH6bMPXAym9lp((object) webDataItem), (object) this.ValueFieldName(propMd)))
              {
                num2 = 3;
                continue;
              }
              goto label_28;
            case 5:
              goto label_27;
            case 6:
              goto label_29;
            case 7:
              if (!Int32PropertyDescriptor.XC58VkGI6Xe9ENT3viNY((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
                continue;
              }
              goto label_14;
            case 8:
              goto label_12;
            case 9:
              if (obj == null)
              {
                num2 = 8;
                continue;
              }
              break;
            case 10:
              goto label_9;
          }
          if (propMd != null)
          {
            propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
          }
          else
            num2 = 5;
        }
label_28:
        num1 = 10;
      }
label_24:
      return;
label_27:
      return;
label_29:
      return;
label_12:
      return;
label_16:
      return;
label_9:
      try
      {
        int result;
        int num3;
        if (!int.TryParse(webDataItem.Value, out result))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
        else
          goto label_13;
label_11:
        while (true)
        {
          switch (num3)
          {
            case 2:
              goto label_23;
            case 3:
              goto label_13;
            case 4:
              goto label_21;
            default:
              Int32PropertyDescriptor.FLGwN0GI7US6vbB5KYBS((object) propertyCached, obj, (object) null, (object) null);
              num3 = 4;
              continue;
          }
        }
label_23:
        return;
label_21:
        return;
label_13:
        Int32PropertyDescriptor.FLGwN0GI7US6vbB5KYBS((object) propertyCached, obj, (object) result, (object) null);
        num3 = 2;
        goto label_11;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_17;
            default:
              Int32PropertyDescriptor.EdwCr4GImiInXsWj4ybn(Int32PropertyDescriptor.FaWCAGGIxDVcJ7BC5l1T(), Int32PropertyDescriptor.U2bbtGGI08I39uSqt7jw(-1487388570 ^ -1487172978), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
          }
        }
label_17:
        return;
      }
label_14:;
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
            goto label_13;
          case 2:
            if (propMd != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_25;
          case 3:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 2;
              continue;
            }
            goto label_29;
          case 4:
            if (propertyCached == (PropertyInfo) null)
            {
              num1 = 7;
              continue;
            }
            goto case 8;
          case 5:
            if (!(propMd is PropertyMetadata))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 9 : 2;
            continue;
          case 6:
            goto label_5;
          case 7:
            goto label_35;
          case 8:
            if (!Int32PropertyDescriptor.VRw4h8GIAsb5Q8ygH6ph((object) fieldName, (object) this.ValueFieldName(propMd)))
            {
              num1 = 5;
              continue;
            }
            goto label_34;
          case 9:
            goto label_16;
          case 10:
            goto label_30;
          default:
            propertyCached = obj.GetType().GetPropertyCached((string) Int32PropertyDescriptor.jl8YrNGIyQb4X6sXOu1w((object) propMd));
            num1 = 4;
            continue;
        }
      }
label_13:
      return;
label_5:
      return;
label_35:
      return;
label_30:
      return;
label_34:
      return;
label_29:
      return;
label_25:
      return;
label_16:
      try
      {
        int num2;
        if (Int32PropertyDescriptor.SxXvoHGIM8ZJcqOaK7q0((object) (propMd as PropertyMetadata)))
          num2 = 5;
        else
          goto label_22;
label_18:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_20;
            case 1:
              Int32PropertyDescriptor.FLGwN0GI7US6vbB5KYBS((object) propertyCached, obj, obj1, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 4 : 4;
              continue;
            case 2:
              obj1 = this.TypeDescriptor.DeserializeSimple(obj2, typeof (int));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_22;
            case 4:
              goto label_19;
            case 5:
              Int32PropertyDescriptor.FLGwN0GI7US6vbB5KYBS((object) propertyCached, obj, (object) null, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
label_20:
        return;
label_19:
        return;
label_15:
        return;
label_22:
        // ISSUE: type reference
        obj2 = this.TypeDescriptor.SerializeSimple((object) null, Int32PropertyDescriptor.g8ZblNGIJX25BhwZ6Pp3(__typeref (int)));
        num2 = 2;
        goto label_18;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
    }

    internal static void knsBjkGI3PH1jdq3egV4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fEfjQuGI1M7l4juklTqa() => Int32PropertyDescriptor.uqqYVkGIPCMgNcHWoQ6R == null;

    internal static Int32PropertyDescriptor lNFijPGIN7TqQBSH8roC() => Int32PropertyDescriptor.uqqYVkGIPCMgNcHWoQ6R;

    internal static long ufspQXGIpiKEpedun9we([In] object obj0) => Convert.ToInt64(obj0);

    internal static bool HcZsX0GIaBnesKbS0ejI([In] object obj0) => ((Int32RangeWrapper) obj0).HasFromValue;

    internal static bool YTWx3fGIDdT6saEr1xXg([In] object obj0) => ((Int32RangeWrapper) obj0).HasToValue;

    internal static int wopHeiGItwMn8uscsyr8([In] object obj0) => ((Int32RangeWrapper) obj0).From;

    internal static long dBloHEGIwDU0THat8tvJ([In] int obj0) => Convert.ToInt64(obj0);

    internal static int hXBG4sGI4kTDQjwSCKsb([In] object obj0) => ((Int32RangeWrapper) obj0).To;

    internal static bool XC58VkGI6Xe9ENT3viNY([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object i13rNZGIH6bMPXAym9lp([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool VRw4h8GIAsb5Q8ygH6ph([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void FLGwN0GI7US6vbB5KYBS([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object FaWCAGGIxDVcJ7BC5l1T() => (object) Logger.Log;

    internal static object U2bbtGGI08I39uSqt7jw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void EdwCr4GImiInXsWj4ybn([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static object jl8YrNGIyQb4X6sXOu1w([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool SxXvoHGIM8ZJcqOaK7q0([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type g8ZblNGIJX25BhwZ6Pp3([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
