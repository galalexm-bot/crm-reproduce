// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.Int64PropertyDescriptor
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
  public class Int64PropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static Int64PropertyDescriptor pgJB4wGI8HJO1Bg2M6L9;

    public Int64PropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      Int64PropertyDescriptor.ewQPd9GII5RXOR1SfRx5();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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
            if (propMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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
      return new FieldIndexList();
label_5:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) (obj != null ? new long?(Convert.ToInt64(obj)) : new long?()), FullTextFieldType.Long));
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
            Int64RangeWrapper int64RangeWrapper = value as Int64RangeWrapper;
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
              num = 0;
            List<object> values;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (int64RangeWrapper != null)
                  {
                    num = 7;
                    continue;
                  }
                  goto case 2;
                case 2:
                  filterField1 = new FilterListItem(this.ValueFieldName(propMd), new List<object>()
                  {
                    value
                  }, FilterListItemType.Must, FullTextFieldType.Long);
                  num = 6;
                  continue;
                case 3:
                case 4:
                  values = new List<object>();
                  num = 12;
                  continue;
                case 5:
                  if (Int64PropertyDescriptor.GBhtP1GIVGvnxWmk0kDx((object) int64RangeWrapper))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 4;
                    continue;
                  }
                  goto case 11;
                case 6:
                case 9:
                  goto label_1;
                case 7:
                  if (!int64RangeWrapper.HasFromValue)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 5 : 5;
                    continue;
                  }
                  goto case 3;
                case 8:
                  filterField1 = new FilterListItem(this.ValueFieldName(propMd), values, FilterListItemType.Between, FullTextFieldType.Long);
                  num = 9;
                  continue;
                case 10:
                  values.Add((object) (Int64PropertyDescriptor.GBhtP1GIVGvnxWmk0kDx((object) int64RangeWrapper) ? new long?(Int64PropertyDescriptor.txqNNmGIRZqAqe24CJXR((object) int64RangeWrapper)) : new long?()));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 6 : 8;
                  continue;
                case 11:
                  filterField2 = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                  continue;
                case 12:
                  values.Add((object) (Int64PropertyDescriptor.SVHNacGIS9DpjyiVoY9F((object) int64RangeWrapper) ? new long?(Int64PropertyDescriptor.hK1RkBGIifWBK8SI295H((object) int64RangeWrapper)) : new long?()));
                  num = 10;
                  continue;
                default:
                  goto label_2;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  filterField2 = (FilterListItem) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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
      int num1 = 11;
      PropertyInfo propertyCached;
      WebDataItem webDataItem;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_3;
          case 1:
            webDataItem = value as WebDataItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
            continue;
          case 2:
            if (propertyCached == (PropertyInfo) null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 3;
              continue;
            }
            goto case 4;
          case 3:
            goto label_6;
          case 4:
            if (webDataItem == null)
            {
              num1 = 8;
              continue;
            }
            goto case 9;
          case 5:
            goto label_15;
          case 6:
            goto label_14;
          case 7:
            goto label_31;
          case 8:
            goto label_2;
          case 9:
            if (Int64PropertyDescriptor.QE5g4xGIqR7o0ZtSnYu8((object) webDataItem.Name, (object) this.ValueFieldName(propMd)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 5 : 6;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 5 : 0;
            continue;
          case 10:
            if (propMd == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
            continue;
          case 11:
            if (obj != null)
            {
              num1 = 10;
              continue;
            }
            goto label_22;
          default:
            goto label_18;
        }
      }
label_3:
      return;
label_6:
      return;
label_14:
      return;
label_31:
      return;
label_2:
      return;
label_18:
      return;
label_22:
      return;
label_15:
      try
      {
        long result;
        int num2;
        if (!long.TryParse((string) Int64PropertyDescriptor.klHQQ6GIKMM4oZ1YIYPq((object) webDataItem), out result))
          num2 = 2;
        else
          goto label_20;
label_17:
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_30;
            case 1:
              goto label_28;
            case 2:
            case 3:
              Int64PropertyDescriptor.BWl6L1GIX2JKQLNqUGta((object) propertyCached, obj, (object) null, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_20;
            default:
              goto label_24;
          }
        }
label_30:
        return;
label_28:
        return;
label_24:
        return;
label_20:
        Int64PropertyDescriptor.BWl6L1GIX2JKQLNqUGta((object) propertyCached, obj, (object) result, (object) null);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        {
          num2 = 1;
          goto label_17;
        }
        else
          goto label_17;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_23;
            default:
              Int64PropertyDescriptor.mmZmQ9GIncJRBEAKemN1(Int64PropertyDescriptor.SKvY6VGITNjU13ujfN3S(), Int64PropertyDescriptor.fR8v2HGIkxa3pkdCuWOo(-2138958856 ^ -2138973936), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
              continue;
          }
        }
label_23:;
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
              goto label_24;
            case 2:
              if (propMd is PropertyMetadata)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 3;
                continue;
              }
              goto label_7;
            case 3:
              goto label_4;
            case 4:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 5:
              goto label_31;
            case 6:
              goto label_8;
            case 7:
              if (!Int64PropertyDescriptor.QE5g4xGIqR7o0ZtSnYu8((object) fieldName, (object) this.ValueFieldName(propMd)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 0;
                continue;
              }
              goto label_23;
            case 8:
              goto label_29;
            case 9:
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 8 : 6;
                continue;
              }
              goto case 4;
            case 10:
              goto label_36;
            default:
              propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
              continue;
          }
        }
label_7:
        num1 = 5;
        continue;
label_24:
        if (!Int64PropertyDescriptor.DbQbq4GIOtbjLhkxOkyH((object) propertyCached, (object) null))
          num1 = 7;
        else
          goto label_28;
      }
label_4:
      return;
label_31:
      return;
label_29:
      return;
label_36:
      return;
label_8:
      try
      {
        int num3;
        if (!Int64PropertyDescriptor.WUsW9QGI2G3pBTqUJjA3((object) (propMd as PropertyMetadata)))
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
        else
          goto label_13;
label_10:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_22;
            case 1:
            case 3:
              // ISSUE: type reference
              obj1 = this.TypeDescriptor.SerializeSimple((object) null, Int64PropertyDescriptor.qX92s2GIePvhJuEqjF1y(__typeref (long)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 4;
              continue;
            case 2:
              goto label_13;
            case 4:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, Int64PropertyDescriptor.qX92s2GIePvhJuEqjF1y(__typeref (long)));
              num3 = 5;
              continue;
            case 5:
              Int64PropertyDescriptor.BWl6L1GIX2JKQLNqUGta((object) propertyCached, obj, obj2, (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_18;
            default:
              goto label_14;
          }
        }
label_22:
        return;
label_18:
        return;
label_14:
        return;
label_13:
        Int64PropertyDescriptor.BWl6L1GIX2JKQLNqUGta((object) propertyCached, obj, (object) null, (object) null);
        num3 = 6;
        goto label_10;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_28:
      return;
label_3:
      return;
label_23:;
    }

    internal static void ewQPd9GII5RXOR1SfRx5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xYAOUHGIZLFKtEBXfpWD() => Int64PropertyDescriptor.pgJB4wGI8HJO1Bg2M6L9 == null;

    internal static Int64PropertyDescriptor AF6jQ4GIudNuJx6AVieP() => Int64PropertyDescriptor.pgJB4wGI8HJO1Bg2M6L9;

    internal static bool GBhtP1GIVGvnxWmk0kDx([In] object obj0) => ((Int64RangeWrapper) obj0).HasToValue;

    internal static bool SVHNacGIS9DpjyiVoY9F([In] object obj0) => ((Int64RangeWrapper) obj0).HasFromValue;

    internal static long hK1RkBGIifWBK8SI295H([In] object obj0) => ((Int64RangeWrapper) obj0).From;

    internal static long txqNNmGIRZqAqe24CJXR([In] object obj0) => ((Int64RangeWrapper) obj0).To;

    internal static bool QE5g4xGIqR7o0ZtSnYu8([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object klHQQ6GIKMM4oZ1YIYPq([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static void BWl6L1GIX2JKQLNqUGta([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object SKvY6VGITNjU13ujfN3S() => (object) Logger.Log;

    internal static object fR8v2HGIkxa3pkdCuWOo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void mmZmQ9GIncJRBEAKemN1([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool DbQbq4GIOtbjLhkxOkyH([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool WUsW9QGI2G3pBTqUJjA3([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type qX92s2GIePvhJuEqjF1y([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
