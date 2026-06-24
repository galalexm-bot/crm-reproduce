// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.Int16PropertyDescriptor
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
  public class Int16PropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static Int16PropertyDescriptor guG8TcGZ7ktjEq1hvIEc;

    public Int16PropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      Int16PropertyDescriptor.XGFZ3UGZmfOckq0KBuys();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) (obj != null ? new long?(Int16PropertyDescriptor.Ix7VD5GZyvgm2T8JwMfh(obj)) : new long?()), FullTextFieldType.Long));
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
            Int16RangeWrapper int16RangeWrapper = value as Int16RangeWrapper;
            int num = 2;
            while (true)
            {
              List<object> values;
              switch (num)
              {
                case 1:
                case 7:
                  goto label_1;
                case 2:
                  if (int16RangeWrapper != null)
                  {
                    num = 9;
                    continue;
                  }
                  break;
                case 3:
                  values.Add((object) (!Int16PropertyDescriptor.Hk3aOGGZMa81LibbGfZb((object) int16RangeWrapper) ? new long?() : new long?(Int16PropertyDescriptor.dyPpUIGZlR5kbjtvxqaN(Int16PropertyDescriptor.DgfYjhGZdrFNiut3AU4r((object) int16RangeWrapper)))));
                  num = 8;
                  continue;
                case 4:
                case 6:
                  values = new List<object>();
                  num = 5;
                  continue;
                case 5:
                  values.Add((object) (Int16PropertyDescriptor.XWZHcKGZJVPIrDxuhoRu((object) int16RangeWrapper) ? new long?(Convert.ToInt64(Int16PropertyDescriptor.Fme1uBGZ9TeVm9uokS4d((object) int16RangeWrapper))) : new long?()));
                  num = 3;
                  continue;
                case 8:
                  filterField1 = new FilterListItem(this.ValueFieldName(propMd), values, FilterListItemType.Between, FullTextFieldType.Long);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                  continue;
                case 9:
                  if (!int16RangeWrapper.HasFromValue)
                  {
                    num = 11;
                    continue;
                  }
                  goto case 4;
                case 10:
                  goto label_2;
                case 11:
                  if (Int16PropertyDescriptor.Hk3aOGGZMa81LibbGfZb((object) int16RangeWrapper))
                  {
                    num = 4;
                    continue;
                  }
                  goto case 12;
                case 12:
                  filterField2 = (FilterListItem) null;
                  num = 10;
                  continue;
              }
              filterField1 = new FilterListItem(this.ValueFieldName(propMd), new List<object>()
              {
                (object) (value != null ? new long?(Convert.ToInt64(value)) : new long?())
              }, FilterListItemType.Must, FullTextFieldType.Long);
              num = 7;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_2;
                default:
                  filterField2 = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
                  continue;
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
      int num1 = 10;
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
              propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 11;
              continue;
            case 2:
              goto label_9;
            case 3:
              if (!Int16PropertyDescriptor.An9xgNGZrawlWEHbhp6G((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              }
              goto label_28;
            case 4:
              goto label_35;
            case 5:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                continue;
              }
              goto label_22;
            case 6:
              goto label_7;
            case 7:
              goto label_8;
            case 8:
              if (!Int16PropertyDescriptor.PTRYXhGZ53K858ZyxUm6(Int16PropertyDescriptor.v8UmDVGZg5owhqLuyuNh((object) webDataItem), (object) this.ValueFieldName(propMd)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 6 : 7;
                continue;
              }
              goto label_24;
            case 9:
              goto label_19;
            case 10:
              if (obj == null)
              {
                num2 = 9;
                continue;
              }
              goto case 5;
            case 11:
              webDataItem = value as WebDataItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 3;
              continue;
            case 12:
              goto label_16;
            default:
              if (webDataItem != null)
              {
                num2 = 8;
                continue;
              }
              goto label_30;
          }
        }
label_8:
        num1 = 12;
      }
label_9:
      return;
label_35:
      return;
label_7:
      return;
label_19:
      return;
label_30:
      return;
label_28:
      return;
label_16:
      try
      {
        short result;
        int num3;
        if (short.TryParse(webDataItem.Value, out result))
          num3 = 2;
        else
          goto label_20;
label_18:
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_11;
            case 1:
              goto label_20;
            case 2:
              Int16PropertyDescriptor.MkVeHXGZjHSH1onYOAGo((object) propertyCached, obj, (object) result, (object) null);
              num3 = 3;
              continue;
            case 3:
              goto label_4;
            default:
              goto label_3;
          }
        }
label_11:
        return;
label_4:
        return;
label_3:
        return;
label_20:
        Int16PropertyDescriptor.MkVeHXGZjHSH1onYOAGo((object) propertyCached, obj, (object) null, (object) null);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        {
          num3 = 0;
          goto label_18;
        }
        else
          goto label_18;
      }
      catch (Exception ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_37;
            case 1:
              Int16PropertyDescriptor.VZktPQGZUmttt9UjHF93(Int16PropertyDescriptor.hAWPlfGZYrmuuTlAk5aC(), Int16PropertyDescriptor.hMWl90GZLUeEMSlCbcbC(-87337865 ^ -87515489), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            default:
              goto label_38;
          }
        }
label_37:
        return;
label_38:
        return;
      }
label_24:
      return;
label_22:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 8;
      PropertyInfo propertyCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_36;
            case 1:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 3 : 6;
                continue;
              }
              goto label_39;
            case 2:
              goto label_35;
            case 3:
              if (!Int16PropertyDescriptor.PTRYXhGZ53K858ZyxUm6((object) fieldName, (object) this.ValueFieldName(propMd)))
                goto case 10;
              else
                goto label_7;
            case 4:
              num2 = 5;
              continue;
            case 5:
              goto label_14;
            case 6:
              if (this.TypeDescriptor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                continue;
              }
              propertyCached = obj.GetType().GetPropertyCached((string) Int16PropertyDescriptor.KBkjNrGZsLA3Xu91gSft((object) propMd));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 12;
              continue;
            case 7:
              goto label_40;
            case 8:
              if (obj == null)
              {
                num2 = 7;
                continue;
              }
              goto case 1;
            case 9:
              goto label_32;
            case 10:
              if (propMd is PropertyMetadata)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 4 : 2;
                continue;
              }
              goto label_10;
            case 11:
              goto label_3;
            case 12:
              if (!Int16PropertyDescriptor.An9xgNGZrawlWEHbhp6G((object) propertyCached, (object) null))
              {
                num2 = 3;
                continue;
              }
              goto label_11;
            default:
              goto label_41;
          }
        }
label_7:
        num1 = 11;
      }
label_36:
      return;
label_35:
      return;
label_40:
      return;
label_32:
      return;
label_3:
      return;
label_41:
      return;
label_39:
      return;
label_11:
      return;
label_14:
      try
      {
        int num3;
        if (Int16PropertyDescriptor.SFJroLGZcOHxX3RiAtys((object) (propMd as PropertyMetadata)))
          num3 = 3;
        else
          goto label_21;
label_16:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_29;
            case 1:
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, typeof (short));
              num3 = 4;
              continue;
            case 2:
              goto label_28;
            case 3:
              Int16PropertyDescriptor.MkVeHXGZjHSH1onYOAGo((object) propertyCached, obj, (object) null, (object) null);
              num3 = 2;
              continue;
            case 4:
              Int16PropertyDescriptor.MkVeHXGZjHSH1onYOAGo((object) propertyCached, obj, obj2, (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_21;
            default:
              goto label_24;
          }
        }
label_29:
        return;
label_28:
        return;
label_24:
        return;
label_21:
        // ISSUE: type reference
        obj1 = this.TypeDescriptor.SerializeSimple((object) null, Int16PropertyDescriptor.n7demjGZzDotusDJkQxR(__typeref (short)));
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        {
          num3 = 1;
          goto label_16;
        }
        else
          goto label_16;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_10:;
    }

    internal static void XGFZ3UGZmfOckq0KBuys() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool y1YaSRGZxa5loxvqCGku() => Int16PropertyDescriptor.guG8TcGZ7ktjEq1hvIEc == null;

    internal static Int16PropertyDescriptor oY0d4lGZ0wvxGSAEy9y5() => Int16PropertyDescriptor.guG8TcGZ7ktjEq1hvIEc;

    internal static long Ix7VD5GZyvgm2T8JwMfh([In] object obj0) => Convert.ToInt64(obj0);

    internal static bool Hk3aOGGZMa81LibbGfZb([In] object obj0) => ((Int16RangeWrapper) obj0).HasToValue;

    internal static bool XWZHcKGZJVPIrDxuhoRu([In] object obj0) => ((Int16RangeWrapper) obj0).HasFromValue;

    internal static short Fme1uBGZ9TeVm9uokS4d([In] object obj0) => ((Int16RangeWrapper) obj0).From;

    internal static short DgfYjhGZdrFNiut3AU4r([In] object obj0) => ((Int16RangeWrapper) obj0).To;

    internal static long dyPpUIGZlR5kbjtvxqaN([In] short obj0) => Convert.ToInt64(obj0);

    internal static bool An9xgNGZrawlWEHbhp6G([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object v8UmDVGZg5owhqLuyuNh([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool PTRYXhGZ53K858ZyxUm6([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void MkVeHXGZjHSH1onYOAGo([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object hAWPlfGZYrmuuTlAk5aC() => (object) Logger.Log;

    internal static object hMWl90GZLUeEMSlCbcbC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void VZktPQGZUmttt9UjHF93([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static object KBkjNrGZsLA3Xu91gSft([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool SFJroLGZcOHxX3RiAtys([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type n7demjGZzDotusDJkQxR([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
