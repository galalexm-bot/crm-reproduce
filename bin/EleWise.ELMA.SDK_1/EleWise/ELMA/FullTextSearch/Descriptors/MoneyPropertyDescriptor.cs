// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.MoneyPropertyDescriptor
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
  public class MoneyPropertyDescriptor : FullTextPropertyDescriptor
  {
    private static MoneyPropertyDescriptor XFgFRbGZnKdskTrnhRG5;

    public MoneyPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      MoneyPropertyDescriptor.HndYWFGZeYqUFy7ARCgX();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
            if (reindex)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return this.GetIndexField(obj, propMd);
label_5:
      return this.GetReIndexField(obj, propMd);
    }

    private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
    {
      int num1 = 1;
      Money money;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            case 2:
              if (money.HasValue)
              {
                num2 = 7;
                continue;
              }
              goto label_11;
            case 3:
              money = (Money) obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
              continue;
            case 4:
            case 6:
              goto label_11;
            case 5:
              if (!(obj is Money))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 3 : 6;
                continue;
              }
              goto case 3;
            case 7:
              goto label_10;
            default:
              if (obj != null)
                goto case 5;
              else
                goto label_7;
          }
        }
label_7:
        num1 = 4;
      }
label_10:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) MoneyPropertyDescriptor.l2367PGZPX4jBPiNZBhB(money.Value), FullTextFieldType.Double));
      return indexField;
label_11:
      return new FieldIndexList();
    }

    private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            goto label_8;
          case 3:
            if (propMd == null)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            if (!(obj is Money))
            {
              if (obj != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                continue;
              }
              goto label_7;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            }
          case 5:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetIndexField(obj, propMd);
label_7:
      FieldIndexList reIndexField = new FieldIndexList();
      reIndexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.Double));
      return reIndexField;
label_8:
      return new FieldIndexList();
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
            MoneyRangeWrapper moneyRangeWrapper = value as MoneyRangeWrapper;
            int num1 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
              num1 = 15;
            while (true)
            {
              int num2;
              MoneyWrapper moneyWrapper;
              Money money;
              List<object> values1;
              switch (num1)
              {
                case 1:
                case 3:
                  filterField = (FilterListItem) null;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 17;
                  continue;
                case 2:
                  List<object> objectList1 = values1;
                  double? nullable1;
                  if (MoneyPropertyDescriptor.HVU38OGZNF0PRbQ1OVH7((object) moneyRangeWrapper.From))
                  {
                    money = MoneyPropertyDescriptor.WDGqEZGZpyse8kZaVh5w(MoneyPropertyDescriptor.p4NyLLGZ17deMkO4o1SY((object) moneyRangeWrapper));
                    if (money.HasValue)
                    {
                      money = ((MoneyWrapper) MoneyPropertyDescriptor.p4NyLLGZ17deMkO4o1SY((object) moneyRangeWrapper)).Value;
                      nullable1 = new double?(money.Value);
                      goto label_33;
                    }
                  }
                  nullable1 = new double?();
label_33:
                  // ISSUE: variable of a boxed type
                  __Boxed<double?> local1 = (System.ValueType) nullable1;
                  objectList1.Add((object) local1);
                  num1 = 9;
                  continue;
                case 4:
                  money = MoneyPropertyDescriptor.WDGqEZGZpyse8kZaVh5w((object) moneyWrapper);
                  num2 = 5;
                  break;
                case 5:
                  if (money.HasValue)
                  {
                    num1 = 14;
                    continue;
                  }
                  goto label_43;
                case 6:
                  if (MoneyPropertyDescriptor.HVU38OGZNF0PRbQ1OVH7((object) moneyWrapper))
                  {
                    num1 = 4;
                    continue;
                  }
                  goto label_43;
                case 7:
                case 21:
                  values1 = new List<object>();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 2 : 0;
                  continue;
                case 8:
                  if (money.HasValue)
                  {
                    num1 = 21;
                    continue;
                  }
                  goto case 13;
                case 9:
                  List<object> objectList2 = values1;
                  double? nullable2;
                  if (MoneyPropertyDescriptor.HVU38OGZNF0PRbQ1OVH7(MoneyPropertyDescriptor.Wfi4IqGZ3UN12UUlQ7Mf((object) moneyRangeWrapper)))
                  {
                    money = MoneyPropertyDescriptor.WDGqEZGZpyse8kZaVh5w(MoneyPropertyDescriptor.Wfi4IqGZ3UN12UUlQ7Mf((object) moneyRangeWrapper));
                    if (money.HasValue)
                    {
                      money = MoneyPropertyDescriptor.WDGqEZGZpyse8kZaVh5w((object) moneyRangeWrapper.To);
                      nullable2 = new double?(money.Value);
                      goto label_38;
                    }
                  }
                  nullable2 = new double?();
label_38:
                  // ISSUE: variable of a boxed type
                  __Boxed<double?> local2 = (System.ValueType) nullable2;
                  objectList2.Add((object) local2);
                  num1 = 16;
                  continue;
                case 10:
                  if (!money.HasValue)
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
                    continue;
                  }
                  goto case 7;
                case 11:
                  if (moneyWrapper != null)
                  {
                    num2 = 6;
                    break;
                  }
                  goto label_43;
                case 12:
                  if (!MoneyPropertyDescriptor.HVU38OGZNF0PRbQ1OVH7(MoneyPropertyDescriptor.p4NyLLGZ17deMkO4o1SY((object) moneyRangeWrapper)))
                  {
                    num1 = 13;
                    continue;
                  }
                  goto case 19;
                case 13:
                case 18:
                  if (!MoneyPropertyDescriptor.HVU38OGZNF0PRbQ1OVH7(MoneyPropertyDescriptor.Wfi4IqGZ3UN12UUlQ7Mf((object) moneyRangeWrapper)))
                  {
                    num1 = 3;
                    continue;
                  }
                  goto case 24;
                case 14:
                  string field = this.ValueFieldName(propMd);
                  List<object> values2 = new List<object>();
                  money = MoneyPropertyDescriptor.WDGqEZGZpyse8kZaVh5w((object) moneyWrapper);
                  values2.Add((object) money.Value);
                  filterField = new FilterListItem(field, values2, FilterListItemType.Must, FullTextFieldType.Double);
                  num1 = 20;
                  continue;
                case 15:
                  if (moneyRangeWrapper != null)
                  {
                    num1 = 12;
                    continue;
                  }
                  goto case 23;
                case 16:
                  filterField = new FilterListItem(this.ValueFieldName(propMd), values1, FilterListItemType.Between, FullTextFieldType.Double);
                  num1 = 22;
                  continue;
                case 17:
                case 20:
                case 22:
                  goto label_44;
                case 19:
                  money = ((MoneyWrapper) MoneyPropertyDescriptor.p4NyLLGZ17deMkO4o1SY((object) moneyRangeWrapper)).Value;
                  num1 = 8;
                  continue;
                case 23:
                  moneyWrapper = value as MoneyWrapper;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 5 : 11;
                  continue;
                case 24:
                  money = ((MoneyWrapper) MoneyPropertyDescriptor.Wfi4IqGZ3UN12UUlQ7Mf((object) moneyRangeWrapper)).Value;
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 10 : 3;
                  continue;
                default:
                  goto label_43;
              }
              num1 = num2;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_44;
                default:
                  filterField = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                  continue;
              }
            }
          }
label_44:
          return filterField;
      }
label_43:
      return (FilterListItem) null;
    }

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.Double);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 10;
      PropertyInfo propertyCached;
      WebDataItem webDataItem;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_33;
          case 3:
            if (!MoneyPropertyDescriptor.DMY4QuGZDYmR2m6hBBv4((object) propertyCached, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 3 : 6;
              continue;
            }
            goto label_32;
          case 4:
            propertyCached = obj.GetType().GetPropertyCached((string) MoneyPropertyDescriptor.m3wbMZGZaZdh45KGeGEU((object) propMd));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_19;
          case 6:
            if (webDataItem != null)
            {
              num1 = 11;
              continue;
            }
            goto label_30;
          case 7:
            if (propMd != null)
            {
              num1 = 4;
              continue;
            }
            goto label_26;
          case 8:
            goto label_3;
          case 9:
            goto label_25;
          case 10:
            if (obj == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 9 : 2;
              continue;
            }
            goto case 7;
          case 11:
            if (!((string) MoneyPropertyDescriptor.oEissPGZtpf4TE60sfIY((object) webDataItem) != this.ValueFieldName(propMd)))
            {
              num1 = 5;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 2;
            continue;
          default:
            webDataItem = value as WebDataItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 3;
            continue;
        }
      }
label_5:
      return;
label_33:
      return;
label_3:
      return;
label_25:
      return;
label_32:
      return;
label_30:
      return;
label_26:
      return;
label_19:
      try
      {
        PropertyInfo propertyInfo = propertyCached;
        object obj1 = obj;
        double result;
        Money money;
        if (!double.TryParse(webDataItem.Value, out result))
          money = new Money() { HasValue = false };
        else
          money = new Money() { Value = result };
        // ISSUE: variable of a boxed type
        __Boxed<Money> local = (System.ValueType) money;
        MoneyPropertyDescriptor.MXdZRBGZwa56UUGWgdbT((object) propertyInfo, obj1, (object) local, (object) null);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_34;
            case 1:
              MoneyPropertyDescriptor.FCuNUgGZHfWmArOou6bI(MoneyPropertyDescriptor.fwTRSFGZ4fQrbCkV7mrr(), MoneyPropertyDescriptor.t4LEmLGZ6Eb7a0iKG1pU(-2112703338 ^ -2112782722), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            default:
              goto label_35;
          }
        }
label_34:
        return;
label_35:;
      }
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 3;
      PropertyInfo propertyCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_30;
            case 2:
              goto label_22;
            case 3:
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
                continue;
              }
              break;
            case 4:
              goto label_32;
            case 5:
              goto label_5;
            case 6:
              if (!MoneyPropertyDescriptor.DMY4QuGZDYmR2m6hBBv4((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
                continue;
              }
              goto label_20;
            case 7:
              if (propMd is PropertyMetadata)
              {
                num2 = 9;
                continue;
              }
              goto label_21;
            case 8:
              goto label_36;
            case 9:
              num2 = 5;
              continue;
            case 10:
              goto label_14;
            case 11:
              propertyCached = obj.GetType().GetPropertyCached((string) MoneyPropertyDescriptor.m3wbMZGZaZdh45KGeGEU((object) propMd));
              num2 = 6;
              continue;
          }
          if (propMd != null)
            num2 = 11;
          else
            goto label_15;
        }
label_30:
        if (!MoneyPropertyDescriptor.LWSpH9GZAYyrVeHEGMn0((object) fieldName, (object) this.ValueFieldName(propMd)))
          num1 = 7;
        else
          goto label_19;
      }
label_22:
      return;
label_32:
      return;
label_36:
      return;
label_14:
      return;
label_5:
      try
      {
        int num3;
        if (!(propMd as PropertyMetadata).Nullable)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
        else
          goto label_10;
label_7:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_9;
            case 1:
            case 6:
              obj2 = this.TypeDescriptor.SerializeSimple((object) null, typeof (Money));
              num3 = 4;
              continue;
            case 2:
              MoneyPropertyDescriptor.MXdZRBGZwa56UUGWgdbT((object) propertyCached, obj, obj1, (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_8;
            case 4:
              obj1 = this.TypeDescriptor.DeserializeSimple(obj2, typeof (Money));
              num3 = 2;
              continue;
            case 5:
              goto label_10;
            default:
              goto label_4;
          }
        }
label_9:
        return;
label_8:
        return;
label_4:
        return;
label_10:
        MoneyPropertyDescriptor.MXdZRBGZwa56UUGWgdbT((object) propertyCached, obj, (object) null, (object) null);
        num3 = 3;
        goto label_7;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_15:
      return;
label_21:
      return;
label_20:
      return;
label_19:;
    }

    internal static void HndYWFGZeYqUFy7ARCgX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool BTbK5rGZO2iMkQgYSHCR() => MoneyPropertyDescriptor.XFgFRbGZnKdskTrnhRG5 == null;

    internal static MoneyPropertyDescriptor tWBkTFGZ2Mpbg3K3GZci() => MoneyPropertyDescriptor.XFgFRbGZnKdskTrnhRG5;

    internal static double l2367PGZPX4jBPiNZBhB([In] double obj0) => Convert.ToDouble(obj0);

    internal static object p4NyLLGZ17deMkO4o1SY([In] object obj0) => (object) ((MoneyRangeWrapper) obj0).From;

    internal static bool HVU38OGZNF0PRbQ1OVH7([In] object obj0) => ((MoneyWrapper) obj0).HasValue;

    internal static object Wfi4IqGZ3UN12UUlQ7Mf([In] object obj0) => (object) ((MoneyRangeWrapper) obj0).To;

    internal static Money WDGqEZGZpyse8kZaVh5w([In] object obj0) => ((MoneyWrapper) obj0).Value;

    internal static object m3wbMZGZaZdh45KGeGEU([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool DMY4QuGZDYmR2m6hBBv4([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object oEissPGZtpf4TE60sfIY([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static void MXdZRBGZwa56UUGWgdbT([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object fwTRSFGZ4fQrbCkV7mrr() => (object) Logger.Log;

    internal static object t4LEmLGZ6Eb7a0iKG1pU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void FCuNUgGZHfWmArOou6bI([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool LWSpH9GZAYyrVeHEGMn0([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;
  }
}
