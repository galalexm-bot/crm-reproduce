// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.TextPropertyDescriptor
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
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class TextPropertyDescriptor : FullTextPropertyDescriptor
  {
    private static TextPropertyDescriptor MORBMvGuDGw2KmVCfpes;

    public TextPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (propMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return new FieldIndexList();
label_3:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) Convert.ToString(obj), FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.SortFieldName(propMd), TextPropertyDescriptor.FBHZhwGu4014KZDEjf6M(obj), FullTextFieldType.String));
      return indexField;
    }

    public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd) => new FieldListItem(this.ValueFieldName(propMd), value != null ? value.ToString() : string.Empty);

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.SortFieldName(propMd), FullTextFieldType.String);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 3;
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
              goto label_33;
            case 1:
              goto label_11;
            case 2:
              goto label_30;
            case 3:
              if (obj == null)
              {
                num2 = 2;
                continue;
              }
              goto label_11;
            case 4:
              goto label_34;
            case 5:
              goto label_26;
            case 6:
              num2 = 13;
              continue;
            case 7:
              if (webDataItem != null)
              {
                num2 = 12;
                continue;
              }
              goto label_6;
            case 8:
              webDataItem = value as WebDataItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 10 : 4;
              continue;
            case 9:
              goto label_4;
            case 10:
              if (TextPropertyDescriptor.kxfqf7GuHEBmqjost8Wb((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 5 : 0;
                continue;
              }
              goto case 7;
            case 11:
              propertyCached = obj.GetType().GetPropertyCached((string) TextPropertyDescriptor.HSaI4UGu6hNrC3JkFIva((object) propMd));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 7 : 8;
              continue;
            case 12:
              if (!TextPropertyDescriptor.JE5gT0Gu7U93VOOWRltf(TextPropertyDescriptor.nF8Gt8GuATIDHVx3aiKy((object) webDataItem), (object) this.ValueFieldName(propMd)))
              {
                num2 = 6;
                continue;
              }
              goto label_16;
            case 13:
              goto label_13;
            default:
              goto label_27;
          }
        }
label_11:
        if (propMd != null)
          num1 = 11;
        else
          goto label_3;
      }
label_33:
      return;
label_30:
      return;
label_34:
      return;
label_26:
      return;
label_4:
      return;
label_27:
      return;
label_3:
      return;
label_13:
      try
      {
        propertyCached.SetValue(obj, TextPropertyDescriptor.SYCJBcGuxj9I18nws6hS((object) webDataItem), (object[]) null);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
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
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_17;
            default:
              TextPropertyDescriptor.WOyxGdGumiu3Ygcb9opU(TextPropertyDescriptor.MiJNKEGu0h7KRZOQe8T4(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234154504), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
              continue;
          }
        }
label_17:
        return;
      }
label_16:
      return;
label_6:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 13;
      PropertyInfo propertyCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_37;
            case 1:
              goto label_26;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 10 : 5;
              continue;
            case 3:
              if (TextPropertyDescriptor.kxfqf7GuHEBmqjost8Wb((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
                continue;
              }
              goto case 11;
            case 4:
              goto label_5;
            case 5:
              goto label_36;
            case 6:
              goto label_24;
            case 7:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 9 : 3;
                continue;
              }
              goto label_4;
            case 8:
              goto label_23;
            case 9:
              goto label_38;
            case 10:
              goto label_8;
            case 11:
              if (TextPropertyDescriptor.JE5gT0Gu7U93VOOWRltf((object) fieldName, (object) this.ValueFieldName(propMd)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 12:
              goto label_3;
            case 13:
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 12 : 12;
                continue;
              }
              goto case 7;
            default:
              goto label_22;
          }
        }
label_5:
        if (propMd is PropertyMetadata)
        {
          num1 = 2;
          continue;
        }
        goto label_31;
label_38:
        propertyCached = obj.GetType().GetPropertyCached((string) TextPropertyDescriptor.HSaI4UGu6hNrC3JkFIva((object) propMd));
        num1 = 3;
      }
label_37:
      return;
label_26:
      return;
label_36:
      return;
label_24:
      return;
label_23:
      return;
label_3:
      return;
label_22:
      return;
label_31:
      return;
label_8:
      try
      {
        int num3;
        if (TextPropertyDescriptor.COYgPlGuy8a39aspA4Ri((object) (propMd as PropertyMetadata)))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
        else
          goto label_12;
label_10:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_18;
            case 2:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, TextPropertyDescriptor.CLc4tSGuMZwJ189DkwVq(__typeref (string)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 4;
              continue;
            case 3:
              goto label_15;
            case 4:
              TextPropertyDescriptor.w6B5NKGuJNkQX6vJn4pb((object) propertyCached, obj, obj2, (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 1;
              continue;
            case 5:
              goto label_12;
            default:
              propertyCached.SetValue(obj, (object) null, (object[]) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 1;
              continue;
          }
        }
label_18:
        return;
label_15:
        return;
label_12:
        obj1 = this.TypeDescriptor.SerializeSimple((object) null, typeof (string));
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        {
          num3 = 2;
          goto label_10;
        }
        else
          goto label_10;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_4:;
    }

    internal static bool B5xH1VGutso8n0bLhsNv() => TextPropertyDescriptor.MORBMvGuDGw2KmVCfpes == null;

    internal static TextPropertyDescriptor PCsxh7GuwSJcdslWlxQF() => TextPropertyDescriptor.MORBMvGuDGw2KmVCfpes;

    internal static object FBHZhwGu4014KZDEjf6M([In] object obj0) => (object) StringPropertyDescriptor.ConvertToSortable(obj0);

    internal static object HSaI4UGu6hNrC3JkFIva([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool kxfqf7GuHEBmqjost8Wb([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object nF8Gt8GuATIDHVx3aiKy([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool JE5gT0Gu7U93VOOWRltf([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object SYCJBcGuxj9I18nws6hS([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static object MiJNKEGu0h7KRZOQe8T4() => (object) Logger.Log;

    internal static void WOyxGdGumiu3Ygcb9opU([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool COYgPlGuy8a39aspA4Ri([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type CLc4tSGuMZwJ189DkwVq([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void w6B5NKGuJNkQX6vJn4pb([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);
  }
}
