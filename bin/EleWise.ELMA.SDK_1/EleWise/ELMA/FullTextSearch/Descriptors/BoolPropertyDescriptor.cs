// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.BoolPropertyDescriptor
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
  public class BoolPropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static BoolPropertyDescriptor tumMgcGCcCdPw34dXulo;

    public BoolPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      FieldIndexList mappingField = new FieldIndexList();
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
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
            goto label_5;
          case 2:
            if (propMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return new FieldIndexList();
label_5:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), obj != null ? BoolPropertyDescriptor.ii5bvYGvBNTSmuHZ3WRS((object) obj.ToString()) : (object) "", FullTextFieldType.String));
      return indexField;
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      FilterListItem filterField;
      switch (1)
      {
        case 1:
          try
          {
            int num;
            if (!(value is bool))
              num = 2;
            else
              goto label_6;
label_4:
            while (true)
            {
              switch (num)
              {
                case 2:
                  filterField = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                  continue;
                case 3:
                  goto label_6;
                default:
                  goto label_1;
              }
            }
label_6:
            filterField = new FilterListItem(this.ValueFieldName(propMd), new List<object>()
            {
              BoolPropertyDescriptor.ii5bvYGvBNTSmuHZ3WRS((object) value.ToString())
            }, FilterListItemType.Must, FullTextFieldType.String);
            num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
            {
              num = 0;
              goto label_4;
            }
            else
              goto label_4;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  filterField = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                  continue;
              }
            }
          }
      }
label_1:
      return filterField;
    }

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.String);

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
            case 1:
              goto label_12;
            case 2:
              goto label_26;
            case 3:
              if (BoolPropertyDescriptor.KPIDQrGvbuFLhRWUq0nI(BoolPropertyDescriptor.OgIgrZGvoqxMY9AX70HV((object) webDataItem), (object) this.ValueFieldName(propMd)))
              {
                num2 = 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
              continue;
            case 4:
              goto label_33;
            case 5:
              goto label_31;
            case 6:
              goto label_7;
            case 7:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                continue;
              }
              goto label_24;
            case 8:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 7;
                continue;
              }
              goto label_20;
            case 9:
              goto label_10;
            case 10:
              if (webDataItem != null)
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            default:
              goto label_11;
          }
        }
label_7:
        webDataItem = value as WebDataItem;
        num1 = 5;
        continue;
label_11:
        propertyCached = obj.GetType().GetPropertyCached((string) BoolPropertyDescriptor.GG3YGsGvWPARhLXjmG2S((object) propMd));
        num1 = 6;
        continue;
label_31:
        if (!(propertyCached == (PropertyInfo) null))
          num1 = 10;
        else
          goto label_3;
      }
label_26:
      return;
label_33:
      return;
label_10:
      return;
label_6:
      return;
label_24:
      return;
label_12:
      try
      {
        bool result;
        int num3;
        if (!bool.TryParse(webDataItem.Value, out result))
          num3 = 4;
        else
          goto label_17;
label_14:
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_17;
            case 2:
              goto label_19;
            case 3:
              goto label_18;
            default:
              BoolPropertyDescriptor.JyiOGwGvhnnGagdbUvE5((object) propertyCached, obj, (object) null, (object) null);
              num3 = 3;
              continue;
          }
        }
label_19:
        return;
label_18:
        return;
label_17:
        BoolPropertyDescriptor.JyiOGwGvhnnGagdbUvE5((object) propertyCached, obj, (object) result, (object) null);
        num3 = 2;
        goto label_14;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_15;
            default:
              BoolPropertyDescriptor.i3duEZGvf6sHrOxh7tAv(BoolPropertyDescriptor.z2kFIxGvGsqlBJQfKv9d(), BoolPropertyDescriptor.HBnwH4GvEu0kbpRSriPe(874012245 ^ 874222781), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              continue;
          }
        }
label_15:
        return;
      }
label_20:
      return;
label_3:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 7;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_20;
          case 1:
            goto label_25;
          case 2:
            goto label_12;
          case 3:
            if (propMd is PropertyMetadata)
            {
              num1 = 5;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 4:
            if (!(fieldName != this.ValueFieldName(propMd)))
            {
              num1 = 3;
              continue;
            }
            goto label_16;
          case 5:
            goto label_3;
          case 6:
            if (propMd != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 7 : 10;
              continue;
            }
            goto label_17;
          case 7:
            if (obj != null)
            {
              num1 = 6;
              continue;
            }
            goto label_24;
          case 8:
            if (BoolPropertyDescriptor.X1s6RrGvQHCNgMClqLmF((object) propertyCached, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 2 : 2;
              continue;
            }
            goto case 4;
          case 9:
            goto label_33;
          case 10:
            propertyCached = obj.GetType().GetPropertyCached((string) BoolPropertyDescriptor.GG3YGsGvWPARhLXjmG2S((object) propMd));
            num1 = 8;
            continue;
          default:
            goto label_7;
        }
      }
label_20:
      return;
label_25:
      return;
label_12:
      return;
label_33:
      return;
label_7:
      return;
label_3:
      try
      {
        int num2;
        if (BoolPropertyDescriptor.LHb1FhGvCIy2F34aD0Qs((object) (propMd as PropertyMetadata)))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
        else
          goto label_11;
label_5:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              // ISSUE: type reference
              obj1 = this.TypeDescriptor.DeserializeSimple(obj2, BoolPropertyDescriptor.hp5joSGvvDUdvErZMinB(__typeref (bool)));
              num2 = 4;
              continue;
            case 3:
              goto label_6;
            case 4:
              BoolPropertyDescriptor.JyiOGwGvhnnGagdbUvE5((object) propertyCached, obj, obj1, (object) null);
              num2 = 5;
              continue;
            case 5:
              goto label_2;
            default:
              propertyCached.SetValue(obj, (object) null, (object[]) null);
              num2 = 3;
              continue;
          }
        }
label_6:
        return;
label_2:
        return;
label_11:
        obj2 = this.TypeDescriptor.SerializeSimple((object) null, typeof (bool));
        num2 = 2;
        goto label_5;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_24:
      return;
label_17:
      return;
label_16:;
    }

    internal static bool V4rTy7GCzjVdtW8yOI8D() => BoolPropertyDescriptor.tumMgcGCcCdPw34dXulo == null;

    internal static BoolPropertyDescriptor Qf408YGvFiLepVRwIl1i() => BoolPropertyDescriptor.tumMgcGCcCdPw34dXulo;

    internal static object ii5bvYGvBNTSmuHZ3WRS([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object GG3YGsGvWPARhLXjmG2S([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static object OgIgrZGvoqxMY9AX70HV([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool KPIDQrGvbuFLhRWUq0nI([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void JyiOGwGvhnnGagdbUvE5([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object z2kFIxGvGsqlBJQfKv9d() => (object) Logger.Log;

    internal static object HBnwH4GvEu0kbpRSriPe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void i3duEZGvf6sHrOxh7tAv([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool X1s6RrGvQHCNgMClqLmF([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool LHb1FhGvCIy2F34aD0Qs([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type hp5joSGvvDUdvErZMinB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
