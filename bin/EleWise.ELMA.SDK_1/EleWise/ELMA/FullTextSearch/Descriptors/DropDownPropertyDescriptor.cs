// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.DropDownPropertyDescriptor
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
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class DropDownPropertyDescriptor : FullTextPropertyDescriptor
  {
    private Func<IPropertyMetadata, string> indexFieldName;
    internal static DropDownPropertyDescriptor rvLTCMGvpa60VW2q6Zwf;

    public DropDownPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      DropDownPropertyDescriptor.vxNhRUGvtWnr6yR9hYO6();
      // ISSUE: reference to a compiler-generated field
      Func<IPropertyMetadata, string> func1 = DropDownPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__1_0;
      Func<IPropertyMetadata, string> func2;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        DropDownPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__1_0 = func2 = (Func<IPropertyMetadata, string>) (propMd => (string) DropDownPropertyDescriptor.\u003C\u003Ec.pGv0Vwvj0XWoBVqnfy7x(DropDownPropertyDescriptor.\u003C\u003Ec.RdjomNvj7gK8MEiXlj9X(-16752921 ^ -16703997), (object) DropDownPropertyDescriptor.\u003C\u003Ec.OkDoDOvjxom9UA2v25Am((object) propMd).ToString(), DropDownPropertyDescriptor.\u003C\u003Ec.RdjomNvj7gK8MEiXlj9X(712480695 ^ 712399555)));
      }
      else
        goto label_7;
label_3:
      this.indexFieldName = func2;
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 0;
      switch (num)
      {
        case 0:
          return;
        default:
          return;
      }
label_7:
      func2 = func1;
      goto label_3;
    }

    /// <inheritdoc />
    public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      FieldIndexList mappingField = new FieldIndexList();
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
      mappingField.Add(new FieldIndexListItem(this.SortFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Sort));
      mappingField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) null, FullTextFieldType.Long, FullTextFieldTag.Value));
      return mappingField;
    }

    public override FieldIndexList GetIndexField(
      object obj,
      IPropertyMetadata propMd,
      bool reindex)
    {
      int num = 4;
      DropDownItem dropDownItem;
      string str1;
      while (true)
      {
        string str2;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (dropDownItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 3:
            dropDownItem = obj as DropDownItem;
            num = 2;
            continue;
          case 4:
            if (propMd != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 5:
            goto label_11;
          case 6:
            str2 = dropDownItem.ToString();
            break;
          default:
            str2 = (string) null;
            break;
        }
        str1 = str2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 3 : 5;
      }
label_2:
      return new FieldIndexList();
label_11:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) str1, FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.SortFieldName(propMd), DropDownPropertyDescriptor.xSxlKuGvwBoYh3iDnwUW(obj), FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) (dropDownItem != null ? new long?(DropDownPropertyDescriptor.abdYJIGv4uHp8qLsHNeX(str1.GetHashCode())) : new long?()), FullTextFieldType.Long));
      return indexField;
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      int num1 = 1;
      DropDownItem dropDownItem;
      while (true)
      {
        switch (num1)
        {
          case 1:
            dropDownItem = value as DropDownItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_9;
          case 3:
            goto label_2;
          default:
            if (dropDownItem != null)
            {
              num1 = 3;
              continue;
            }
            goto label_9;
        }
      }
label_2:
      FilterListItem filterField;
      try
      {
        filterField = new FilterListItem(this.indexFieldName(propMd), new List<object>()
        {
          (object) DropDownPropertyDescriptor.abdYJIGv4uHp8qLsHNeX(dropDownItem.ToString().GetHashCode())
        }, FilterListItemType.Must, FullTextFieldType.Long);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_10;
            default:
              filterField = (FilterListItem) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
              continue;
          }
        }
      }
label_10:
      return filterField;
label_9:
      return (FilterListItem) null;
    }

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.SortFieldName(propMd), FullTextFieldType.String);

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
            case 0:
              goto label_18;
            case 1:
              propertyCached = obj.GetType().GetPropertyCached((string) DropDownPropertyDescriptor.yZFYqnGv6lhSRRfAZjmT((object) propMd));
              num2 = 13;
              continue;
            case 2:
              if (webDataItem != null)
                goto case 7;
              else
                goto label_15;
            case 3:
              goto label_12;
            case 4:
              goto label_6;
            case 5:
              if (propertyCached == (PropertyInfo) null)
              {
                num2 = 6;
                continue;
              }
              goto case 2;
            case 6:
              goto label_3;
            case 7:
              if (!DropDownPropertyDescriptor.pOROsDGvAP76rQvJS0FE(DropDownPropertyDescriptor.C16g5tGvHSy4C4eCOX4v((object) webDataItem), (object) this.ValueFieldName(propMd)))
              {
                num2 = 11;
                continue;
              }
              goto label_16;
            case 8:
              goto label_22;
            case 9:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
                continue;
              }
              goto label_26;
            case 10:
              goto label_10;
            case 11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 8 : 8;
              continue;
            case 12:
              goto label_32;
            case 13:
              webDataItem = value as WebDataItem;
              num2 = 5;
              continue;
            default:
              goto label_34;
          }
        }
label_10:
        if (obj != null)
        {
          num1 = 9;
          continue;
        }
        goto label_30;
label_15:
        num1 = 4;
      }
label_18:
      return;
label_12:
      return;
label_6:
      return;
label_3:
      return;
label_32:
      return;
label_34:
      return;
label_16:
      return;
label_30:
      return;
label_26:
      return;
label_22:
      try
      {
        propertyCached.SetValue(obj, (object) new DropDownItem(webDataItem.Value), (object[]) null);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_17;
            default:
              DropDownPropertyDescriptor.QHyMbTGvxPBL5j7YkuoP((object) Logger.Log, DropDownPropertyDescriptor.AwJjSjGv7ERvUjBOtDQP(~-397266137 ^ 397280816), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
              continue;
          }
        }
label_17:;
      }
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 9;
      PropertyInfo propertyCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!DropDownPropertyDescriptor.v9aT9UGv0t3NDHgAxviv((object) propertyCached, (object) null))
              {
                num2 = 5;
                continue;
              }
              goto label_36;
            case 2:
              goto label_31;
            case 3:
              goto label_28;
            case 4:
              goto label_8;
            case 5:
              goto label_33;
            case 6:
              propertyCached = obj.GetType().GetPropertyCached((string) DropDownPropertyDescriptor.yZFYqnGv6lhSRRfAZjmT((object) propMd));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            case 7:
              if (!(propMd is PropertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 2;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            case 8:
              if (propMd != null)
              {
                num2 = 6;
                continue;
              }
              goto label_24;
            case 9:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 8 : 2;
                continue;
              }
              goto label_25;
            default:
              goto label_10;
          }
        }
label_33:
        if (!DropDownPropertyDescriptor.pOROsDGvAP76rQvJS0FE((object) fieldName, (object) this.ValueFieldName(propMd)))
          num1 = 7;
        else
          goto label_37;
      }
label_31:
      return;
label_28:
      return;
label_8:
      return;
label_25:
      return;
label_24:
      return;
label_10:
      try
      {
        int num3;
        if ((propMd as PropertyMetadata).Nullable)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
        else
          goto label_18;
label_13:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_20;
            case 1:
              DropDownPropertyDescriptor.ArGMWOGvmTqwJ7cEm6hR((object) propertyCached, obj, (object) null, (object) null);
              num3 = 4;
              continue;
            case 2:
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, typeof (DropDownItem));
              num3 = 3;
              continue;
            case 3:
              DropDownPropertyDescriptor.ArGMWOGvmTqwJ7cEm6hR((object) propertyCached, obj, obj2, (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_17;
            case 5:
              goto label_18;
            default:
              goto label_14;
          }
        }
label_20:
        return;
label_17:
        return;
label_14:
        return;
label_18:
        obj1 = this.TypeDescriptor.SerializeSimple((object) null, typeof (DropDownItem));
        num3 = 2;
        goto label_13;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_36:
      return;
label_37:;
    }

    internal static void vxNhRUGvtWnr6yR9hYO6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OpyYcuGvaVhFAl1dqb4P() => DropDownPropertyDescriptor.rvLTCMGvpa60VW2q6Zwf == null;

    internal static DropDownPropertyDescriptor yyIIYLGvDkutD4vp6GX1() => DropDownPropertyDescriptor.rvLTCMGvpa60VW2q6Zwf;

    internal static object xSxlKuGvwBoYh3iDnwUW([In] object obj0) => (object) StringPropertyDescriptor.ConvertToSortable(obj0);

    internal static long abdYJIGv4uHp8qLsHNeX([In] int obj0) => Convert.ToInt64(obj0);

    internal static object yZFYqnGv6lhSRRfAZjmT([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static object C16g5tGvHSy4C4eCOX4v([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool pOROsDGvAP76rQvJS0FE([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object AwJjSjGv7ERvUjBOtDQP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void QHyMbTGvxPBL5j7YkuoP([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool v9aT9UGv0t3NDHgAxviv([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static void ArGMWOGvmTqwJ7cEm6hR([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);
  }
}
