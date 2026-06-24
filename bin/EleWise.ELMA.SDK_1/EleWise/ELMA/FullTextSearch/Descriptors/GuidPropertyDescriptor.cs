// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.GuidPropertyDescriptor
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
  public class GuidPropertyDescriptor : FullTextPropertyDescriptor
  {
    private Func<IPropertyMetadata, string> indexFieldName;
    private static GuidPropertyDescriptor Pr3WiyG8tqUancHQnH5k;

    public GuidPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      GuidPropertyDescriptor.VH8mfqG86o9UFsSKj2QN();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.indexFieldName = (Func<IPropertyMetadata, string>) (propMd => (string) GuidPropertyDescriptor.\u003C\u003Ec.zXglygvjcSadU2SO8hoh(GuidPropertyDescriptor.\u003C\u003Ec.kH6h05vjUMNsfUlR52IM(-420743386 ^ -420825150), (object) GuidPropertyDescriptor.\u003C\u003Ec.lyv1ZVvjsTe78VkWnb9p((object) propMd).ToString(), GuidPropertyDescriptor.\u003C\u003Ec.kH6h05vjUMNsfUlR52IM(-1710575414 ^ -1710522946)));
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      FieldIndexList mappingField = new FieldIndexList();
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Sort));
      mappingField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
      return mappingField;
    }

    public override FieldIndexList GetIndexField(
      object obj,
      IPropertyMetadata propMd,
      bool reindex)
    {
      int num = 3;
      Guid result;
      string str1;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 1:
            Guid.TryParse(obj.ToString(), out result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 7;
            continue;
          case 2:
            goto label_13;
          case 3:
            if (propMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 2;
              continue;
            }
            str2 = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 5;
            continue;
          case 4:
            goto label_10;
          case 5:
            str1 = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 6 : 1;
            continue;
          case 6:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
              continue;
            }
            goto label_10;
          case 7:
            if (GuidPropertyDescriptor.vAg87aG8H3AGLBtJd9hC(result, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 8 : 8;
              continue;
            }
            goto label_10;
          case 8:
            str2 = (string) GuidPropertyDescriptor.anT4F0G8A48bc8emSGBG((object) result.ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          default:
            str1 = result.ToString((string) GuidPropertyDescriptor.m7ooolG87cgKfLeqQXit(-2092274397 << 4 ^ 883304568));
            num = 4;
            continue;
        }
      }
label_10:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) str2, FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) str1, FullTextFieldType.String));
      return indexField;
label_13:
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
            int num;
            if (value == null)
              num = 4;
            else
              goto label_5;
label_3:
            Guid result;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 4:
                  goto label_12;
                case 2:
                  filterField = new FilterListItem(this.indexFieldName(propMd), new List<object>()
                  {
                    (object) result.ToString((string) GuidPropertyDescriptor.m7ooolG87cgKfLeqQXit(964881585 - -1459193222 ^ -1870886785))
                  }, FilterListItemType.Must, FullTextFieldType.String);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                  continue;
                case 3:
                  goto label_5;
                default:
                  goto label_13;
              }
            }
label_5:
            if (Guid.TryParse(value.ToString(), out result))
            {
              num = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
              {
                num = 2;
                goto label_3;
              }
              else
                goto label_3;
            }
            else
              break;
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  filterField = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_13;
              }
            }
          }
label_13:
          return filterField;
      }
label_12:
      return (FilterListItem) null;
    }

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.String);

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
            case 0:
              goto label_33;
            case 1:
              goto label_4;
            case 2:
              if (propMd != null)
              {
                propertyCached = obj.GetType().GetPropertyCached((string) GuidPropertyDescriptor.sCwe7SG8xjUWpD9lhuVX((object) propMd));
                num2 = 12;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_32;
            case 4:
              if (obj == null)
              {
                num2 = 3;
                continue;
              }
              goto case 2;
            case 5:
              goto label_34;
            case 6:
              if (!GuidPropertyDescriptor.sLB5BgG8yA5COh8pt0fa(GuidPropertyDescriptor.z2LsjcG8mRvvZdHJPbH0((object) webDataItem), (object) this.ValueFieldName(propMd)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 10 : 7;
                continue;
              }
              goto label_8;
            case 7:
              goto label_24;
            case 8:
              if (GuidPropertyDescriptor.jYK8pRG805YumLji7Lsj((object) propertyCached, (object) null))
              {
                num2 = 7;
                continue;
              }
              goto label_34;
            case 9:
              goto label_3;
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
              continue;
            case 11:
              goto label_20;
            case 12:
              webDataItem = value as WebDataItem;
              num2 = 8;
              continue;
            default:
              goto label_22;
          }
        }
label_34:
        if (webDataItem != null)
          num1 = 6;
        else
          goto label_7;
      }
label_33:
      return;
label_32:
      return;
label_24:
      return;
label_3:
      return;
label_20:
      return;
label_22:
      return;
label_4:
      try
      {
        Guid result;
        int num3;
        if (!Guid.TryParse((string) GuidPropertyDescriptor.yrkotsG8M7c75jpk9Fu4((object) webDataItem), out result))
          num3 = 3;
        else
          goto label_11;
label_6:
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_19;
            case 2:
              goto label_11;
            case 4:
              goto label_17;
            default:
              GuidPropertyDescriptor.SoiUT3G8J60yMw6FOqGC((object) propertyCached, obj, (object) null, (object) null);
              num3 = 4;
              continue;
          }
        }
label_19:
        return;
label_17:
        return;
label_11:
        GuidPropertyDescriptor.SoiUT3G8J60yMw6FOqGC((object) propertyCached, obj, (object) result, (object) null);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        {
          num3 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      catch (Exception ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_13;
            case 1:
              GuidPropertyDescriptor.dZWu0XG8dRw8KSU7C7pU(GuidPropertyDescriptor.IYjA1bG8902F10Pea24h(), GuidPropertyDescriptor.m7ooolG87cgKfLeqQXit(132912447 ^ 133160919), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
              continue;
            default:
              goto label_9;
          }
        }
label_13:
        return;
label_9:
        return;
      }
label_8:
      return;
label_7:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 10;
      PropertyInfo propertyCached;
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
              if (!(fieldName != this.ValueFieldName(propMd)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 3 : 7;
                continue;
              }
              goto label_25;
            case 2:
              goto label_19;
            case 3:
              goto label_30;
            case 4:
              goto label_16;
            case 5:
              goto label_12;
            case 6:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 4;
              continue;
            case 7:
              if (propMd is PropertyMetadata)
              {
                num2 = 6;
                continue;
              }
              goto label_20;
            case 8:
              if (GuidPropertyDescriptor.jYK8pRG805YumLji7Lsj((object) propertyCached, (object) null))
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            case 9:
              if (propMd == null)
              {
                num2 = 3;
                continue;
              }
              goto label_5;
            case 10:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 9;
                continue;
              }
              goto label_29;
            default:
              goto label_11;
          }
        }
label_5:
        propertyCached = obj.GetType().GetPropertyCached((string) GuidPropertyDescriptor.sCwe7SG8xjUWpD9lhuVX((object) propMd));
        num1 = 8;
      }
label_4:
      return;
label_19:
      return;
label_30:
      return;
label_12:
      return;
label_11:
      return;
label_25:
      return;
label_20:
      return;
label_16:
      try
      {
        int num3;
        if (GuidPropertyDescriptor.sS0sSfG8le9pjqiRrbXi((object) (propMd as PropertyMetadata)))
          num3 = 3;
        else
          goto label_24;
label_18:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              GuidPropertyDescriptor.SoiUT3G8J60yMw6FOqGC((object) propertyCached, obj, obj2, (object) null);
              num3 = 2;
              continue;
            case 2:
              goto label_10;
            case 3:
              GuidPropertyDescriptor.SoiUT3G8J60yMw6FOqGC((object) propertyCached, obj, (object) null, (object) null);
              num3 = 5;
              continue;
            case 4:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, GuidPropertyDescriptor.qWvhJFG8rG9y8nDmmPLc(__typeref (Guid)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
              continue;
            case 5:
              goto label_3;
            default:
              goto label_24;
          }
        }
label_10:
        return;
label_3:
        return;
label_24:
        // ISSUE: type reference
        obj1 = this.TypeDescriptor.SerializeSimple((object) null, GuidPropertyDescriptor.qWvhJFG8rG9y8nDmmPLc(__typeref (Guid)));
        num3 = 4;
        goto label_18;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_29:;
    }

    internal static void VH8mfqG86o9UFsSKj2QN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool lh3oRRG8wTaE3NSi5r8c() => GuidPropertyDescriptor.Pr3WiyG8tqUancHQnH5k == null;

    internal static GuidPropertyDescriptor p2LXhnG84Z4OIaxauVWS() => GuidPropertyDescriptor.Pr3WiyG8tqUancHQnH5k;

    internal static bool vAg87aG8H3AGLBtJd9hC([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object anT4F0G8A48bc8emSGBG([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object m7ooolG87cgKfLeqQXit(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sCwe7SG8xjUWpD9lhuVX([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool jYK8pRG805YumLji7Lsj([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object z2LsjcG8mRvvZdHJPbH0([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool sLB5BgG8yA5COh8pt0fa([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object yrkotsG8M7c75jpk9Fu4([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static void SoiUT3G8J60yMw6FOqGC([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object IYjA1bG8902F10Pea24h() => (object) Logger.Log;

    internal static void dZWu0XG8dRw8KSU7C7pU([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool sS0sSfG8le9pjqiRrbXi([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type qWvhJFG8rG9y8nDmmPLc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
