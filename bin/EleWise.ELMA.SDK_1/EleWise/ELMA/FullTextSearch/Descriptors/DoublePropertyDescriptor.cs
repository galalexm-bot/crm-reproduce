// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.DoublePropertyDescriptor
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
  public class DoublePropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static DoublePropertyDescriptor GaK2ojGI9AuwspJZqJNS;

    public DoublePropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      DoublePropertyDescriptor.udDw9pGIrPRHFnPTW0YX();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) (obj != null ? new double?(Convert.ToDouble(obj)) : new double?()), FullTextFieldType.Double));
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
            DoubleRangeWrapper doubleRangeWrapper = value as DoubleRangeWrapper;
            int num = 2;
            List<object> values;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 11:
                  filterField1 = new FilterListItem(this.ValueFieldName(propMd), new List<object>()
                  {
                    value
                  }, FilterListItemType.Must, FullTextFieldType.Double);
                  num = 12;
                  continue;
                case 2:
                  if (doubleRangeWrapper == null)
                  {
                    num = 11;
                    continue;
                  }
                  goto default;
                case 3:
                case 12:
                  goto label_1;
                case 4:
                  if (!DoublePropertyDescriptor.CK96uTGIgeZoB2FG5ttQ((object) doubleRangeWrapper))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 7;
                    continue;
                  }
                  goto case 6;
                case 5:
                  filterField1 = new FilterListItem(this.ValueFieldName(propMd), values, FilterListItemType.Between, FullTextFieldType.Double);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 3;
                  continue;
                case 6:
                  values = new List<object>();
                  num = 10;
                  continue;
                case 7:
                  filterField2 = (FilterListItem) null;
                  num = 9;
                  continue;
                case 8:
                  values.Add((object) (!DoublePropertyDescriptor.CK96uTGIgeZoB2FG5ttQ((object) doubleRangeWrapper) ? new double?() : new double?(DoublePropertyDescriptor.mOQ3QCGIjEZs0DPJxJN3((object) doubleRangeWrapper))));
                  num = 5;
                  continue;
                case 9:
                  goto label_2;
                case 10:
                  values.Add((object) (!DoublePropertyDescriptor.BGq7NXGI5yi6halnbZcT((object) doubleRangeWrapper) ? new double?() : new double?(doubleRangeWrapper.From)));
                  num = 8;
                  continue;
                default:
                  if (!doubleRangeWrapper.HasFromValue)
                  {
                    num = 4;
                    continue;
                  }
                  goto case 6;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_2;
                default:
                  filterField2 = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
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

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.Double);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 12;
      WebDataItem webDataItem;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_20;
          case 2:
            goto label_34;
          case 3:
            goto label_9;
          case 4:
            webDataItem = value as WebDataItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 3 : 9;
            continue;
          case 5:
            if (propMd != null)
            {
              propertyCached = obj.GetType().GetPropertyCached((string) DoublePropertyDescriptor.d6cERbGIYb9adqhCnKQb((object) propMd));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 4 : 4;
              continue;
            }
            num1 = 3;
            continue;
          case 6:
            goto label_27;
          case 7:
            if (webDataItem != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 10 : 7;
              continue;
            }
            goto label_28;
          case 8:
            goto label_4;
          case 9:
            if (DoublePropertyDescriptor.LqGG7XGILjS6F8EZOgVI((object) propertyCached, (object) null))
            {
              num1 = 2;
              continue;
            }
            goto case 7;
          case 10:
            if (!DoublePropertyDescriptor.G1iw0QGIsPnfJ4qUWdSv(DoublePropertyDescriptor.dAOFGNGIUuUC9RHOeX82((object) webDataItem), (object) this.ValueFieldName(propMd)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            }
            goto label_32;
          case 11:
            goto label_10;
          case 12:
            if (obj == null)
            {
              num1 = 11;
              continue;
            }
            goto case 5;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
            continue;
        }
      }
label_34:
      return;
label_9:
      return;
label_27:
      return;
label_4:
      return;
label_10:
      return;
label_32:
      return;
label_28:
      return;
label_20:
      try
      {
        double result;
        int num2;
        if (!double.TryParse((string) DoublePropertyDescriptor.p9rXcqGIcFRoo2QwsTjw((object) webDataItem), out result))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 4 : 3;
        else
          goto label_26;
label_22:
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_24;
            case 1:
              goto label_26;
            case 2:
              goto label_23;
            case 3:
            case 4:
              DoublePropertyDescriptor.KJdc7uGIzA8EcNU72ADP((object) propertyCached, obj, (object) null, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            default:
              goto label_19;
          }
        }
label_24:
        return;
label_23:
        return;
label_19:
        return;
label_26:
        DoublePropertyDescriptor.KJdc7uGIzA8EcNU72ADP((object) propertyCached, obj, (object) result, (object) null);
        num2 = 2;
        goto label_22;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_13;
            default:
              ((ILogger) DoublePropertyDescriptor.CQm5UJGVFTERZnUcJeOM()).Warn(DoublePropertyDescriptor.bAQkYrGVBUbHmnjVHT5Q(1012087039 ^ 1011937815), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
              continue;
          }
        }
label_13:;
      }
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 2;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (propMd != null)
            {
              propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
              num1 = 7;
              continue;
            }
            num1 = 5;
            continue;
          case 2:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
              continue;
            }
            goto label_29;
          case 3:
            goto label_5;
          case 4:
            goto label_21;
          case 5:
            goto label_34;
          case 6:
            goto label_27;
          case 7:
            if (propertyCached == (PropertyInfo) null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 3;
              continue;
            }
            break;
          case 8:
            num1 = 9;
            continue;
          case 9:
            goto label_11;
          case 10:
            if (propMd is PropertyMetadata)
            {
              num1 = 8;
              continue;
            }
            goto label_26;
        }
        if (!DoublePropertyDescriptor.G1iw0QGIsPnfJ4qUWdSv((object) fieldName, (object) this.ValueFieldName(propMd)))
          num1 = 10;
        else
          goto label_25;
      }
label_5:
      return;
label_21:
      return;
label_34:
      return;
label_27:
      return;
label_26:
      return;
label_11:
      try
      {
        int num2;
        if (!(propMd as PropertyMetadata).Nullable)
          num2 = 2;
        else
          goto label_15;
label_13:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              // ISSUE: type reference
              obj1 = this.TypeDescriptor.SerializeSimple((object) null, DoublePropertyDescriptor.jOvJ0UGVWvEechhQBGwO(__typeref (double)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_15;
            case 4:
              goto label_18;
            case 5:
              goto label_17;
            case 6:
              DoublePropertyDescriptor.KJdc7uGIzA8EcNU72ADP((object) propertyCached, obj, obj2, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 4;
              continue;
            default:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, DoublePropertyDescriptor.jOvJ0UGVWvEechhQBGwO(__typeref (double)));
              num2 = 6;
              continue;
          }
        }
label_18:
        return;
label_17:
        return;
label_15:
        propertyCached.SetValue(obj, (object) null, (object[]) null);
        num2 = 5;
        goto label_13;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_25:
      return;
label_29:;
    }

    internal static void udDw9pGIrPRHFnPTW0YX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QMjO3jGIdU47yHjd2M1A() => DoublePropertyDescriptor.GaK2ojGI9AuwspJZqJNS == null;

    internal static DoublePropertyDescriptor X61UaTGIlntO2VN4JWb0() => DoublePropertyDescriptor.GaK2ojGI9AuwspJZqJNS;

    internal static bool CK96uTGIgeZoB2FG5ttQ([In] object obj0) => ((DoubleRangeWrapper) obj0).HasToValue;

    internal static bool BGq7NXGI5yi6halnbZcT([In] object obj0) => ((DoubleRangeWrapper) obj0).HasFromValue;

    internal static double mOQ3QCGIjEZs0DPJxJN3([In] object obj0) => ((DoubleRangeWrapper) obj0).To;

    internal static object d6cERbGIYb9adqhCnKQb([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool LqGG7XGILjS6F8EZOgVI([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object dAOFGNGIUuUC9RHOeX82([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool G1iw0QGIsPnfJ4qUWdSv([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object p9rXcqGIcFRoo2QwsTjw([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static void KJdc7uGIzA8EcNU72ADP([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object CQm5UJGVFTERZnUcJeOM() => (object) Logger.Log;

    internal static object bAQkYrGVBUbHmnjVHT5Q(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type jOvJ0UGVWvEechhQBGwO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
