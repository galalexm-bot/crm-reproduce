// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.EnumPropertyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class EnumPropertyDescriptor : FullTextPropertyDescriptor
  {
    private Func<IPropertyMetadata, string> indexFieldName;
    private static EnumPropertyDescriptor e6Sl2qG8ggH8o8ZyRwbs;

    public EnumPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      EnumPropertyDescriptor.O0EIknG8Y0HOn6dCd6PF();
      // ISSUE: reference to a compiler-generated field
      Func<IPropertyMetadata, string> func1 = EnumPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__1_0;
      Func<IPropertyMetadata, string> func2;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        EnumPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__1_0 = func2 = (Func<IPropertyMetadata, string>) (propMd => (string) EnumPropertyDescriptor.\u003C\u003Ec.ySRHGEvYh3kdRoVTsuE1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87944263), (object) EnumPropertyDescriptor.\u003C\u003Ec.rLGG6WvYoYNVrUW38xDu((object) propMd).ToString(), EnumPropertyDescriptor.\u003C\u003Ec.DRCE95vYbVR0tEfrZkpS(-1872275253 >> 6 ^ -29339625)));
      }
      else
        goto label_7;
label_3:
      this.indexFieldName = func2;
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Sort));
      mappingField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
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
            if (reindex)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetIndexField(obj, propMd);
label_3:
      return this.GetReIndexField(obj, propMd);
    }

    private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 4;
      EnumBase enumBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
          case 5:
            goto label_2;
          case 4:
            if (propMd == null)
            {
              num = 3;
              continue;
            }
            goto case 2;
          default:
            enumBase = obj as EnumBase;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return new FieldIndexList();
label_8:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.indexFieldName(propMd), EnumPropertyDescriptor.qF8VhLG8LUb9cfp0FG9f((object) enumBase, (object) null) ? (object) EnumPropertyDescriptor.tBw58dG8seiE5E32XlGx((object) enumBase).ToString((string) EnumPropertyDescriptor.J2WkynG8cWLttdTyybZN(1470440286 ^ 1470486806)) : (object) EnumPropertyDescriptor.cAaL2AG8UO6tAIgDCqq6(obj).ToString(), FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), EnumPropertyDescriptor.AS9XJPG8z26yM37OYZq1(!EnumPropertyDescriptor.qF8VhLG8LUb9cfp0FG9f((object) enumBase, (object) null) ? (object) obj.ToString() : (object) enumBase.Name), FullTextFieldType.String));
      return indexField;
    }

    private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (propMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            goto label_5;
          case 4:
            goto label_4;
        }
        if (obj == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 0;
        else
          break;
      }
label_4:
      return this.GetIndexField(obj, propMd);
label_5:
      FieldIndexList reIndexField = new FieldIndexList();
      reIndexField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) null, FullTextFieldType.String));
      reIndexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String));
      return reIndexField;
label_6:
      return new FieldIndexList();
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_39;
          case 2:
            if (value == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_35;
          default:
            goto label_2;
        }
      }
label_2:
      FilterListItem filterField;
      try
      {
        int num2;
        if (value is System.Enum)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 2;
        else
          goto label_13;
label_5:
        ListInfo listInfo;
        List<object> values;
        List<object>.Enumerator enumerator;
        EnumBaseWrapper enumBaseWrapper1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              goto label_36;
            case 2:
            case 15:
              enumBaseWrapper1 = value as EnumBaseWrapper;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 8 : 1;
              continue;
            case 3:
              if (listInfo.Objects != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 14 : 0;
                continue;
              }
              goto label_35;
            case 4:
              if (listInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 16 : 16;
                continue;
              }
              goto case 3;
            case 6:
              goto label_13;
            case 7:
              try
              {
label_20:
                if (enumerator.MoveNext())
                  goto label_18;
                else
                  goto label_21;
label_17:
                object current;
                EnumBaseWrapper enumBaseWrapper2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_11;
                    case 2:
                      goto label_18;
                    case 3:
                      values.Add(enumBaseWrapper2 != null ? (object) EnumPropertyDescriptor.WiEpCTGZFVY3Fg6QtUJI((object) enumBaseWrapper2).ToString((string) EnumPropertyDescriptor.J2WkynG8cWLttdTyybZN(1461825605 - 1531863589 ^ -70011800)) : (object) EnumPropertyDescriptor.cAaL2AG8UO6tAIgDCqq6(current).ToString());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                      continue;
                    case 4:
                      enumBaseWrapper2 = current as EnumBaseWrapper;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 3;
                      continue;
                    default:
                      goto label_20;
                  }
                }
label_18:
                current = enumerator.Current;
                num3 = 4;
                goto label_17;
label_21:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                goto label_17;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 8:
              filterField = new FilterListItem(this.indexFieldName(propMd), new List<object>()
              {
                enumBaseWrapper1 == null ? (object) EnumPropertyDescriptor.cAaL2AG8UO6tAIgDCqq6(value).ToString() : (object) EnumPropertyDescriptor.WiEpCTGZFVY3Fg6QtUJI((object) enumBaseWrapper1).ToString((string) EnumPropertyDescriptor.J2WkynG8cWLttdTyybZN(-1317790512 ^ -1317738856))
              }, FilterListItemType.Must, FullTextFieldType.String);
              num2 = 5;
              continue;
            case 9:
            case 13:
            case 16:
              goto label_35;
            case 10:
              goto label_27;
            case 11:
              values = new List<object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            case 12:
label_11:
              filterField = new FilterListItem(this.indexFieldName(propMd), values, FilterListItemType.Must, FullTextFieldType.String);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
              continue;
            case 14:
              if (!listInfo.Objects.Any<object>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 13;
                continue;
              }
              goto case 11;
            default:
              enumerator = listInfo.Objects.GetEnumerator();
              num2 = 7;
              continue;
          }
        }
label_13:
        if (value is EnumBaseWrapper)
        {
          num2 = 15;
          goto label_5;
        }
label_27:
        listInfo = value as ListInfo;
        num2 = 4;
        goto label_5;
      }
      catch (Exception ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
          num5 = 1;
        while (true)
        {
          switch (num5)
          {
            case 1:
              filterField = (FilterListItem) null;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_36;
          }
        }
      }
label_36:
      return filterField;
label_35:
      return (FilterListItem) null;
label_39:
      return (FilterListItem) null;
    }

    public override List<string> GetReturnField(IPropertyMetadata propMd) => new List<string>()
    {
      this.indexFieldName(propMd)
    };

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.ValueFieldName(propMd), FullTextFieldType.String);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 15;
      PropertyInfo propertyCached;
      List<EnumValueMetadata> source;
      while (true)
      {
        int num2 = num1;
        WebDataItem webDataItem;
        Guid valueUid;
        while (true)
        {
          EnumMetadata metadata;
          List<EnumValueMetadata> list;
          int valueInt;
          switch (num2)
          {
            case 1:
              goto label_40;
            case 2:
              if (EnumPropertyDescriptor.kbWn0ZGZGo1EEEH8gxy6((object) metadata) == EnumMetadataType.Enum)
              {
                num2 = 12;
                continue;
              }
              goto case 10;
            case 3:
              webDataItem = value as WebDataItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 18 : 0;
              continue;
            case 4:
              goto label_5;
            case 5:
              if (webDataItem == null)
              {
                num2 = 6;
                continue;
              }
              goto case 7;
            case 6:
              goto label_39;
            case 7:
              if (!((string) EnumPropertyDescriptor.gtkFP0GZoEVTgv9xT3EE((object) webDataItem) != this.indexFieldName(propMd)))
              {
                metadata = this.GetMetadata(EnumPropertyDescriptor.AxAg58GZb7jTGFe6u44s((object) propMd), false);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 8;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 17 : 7;
              continue;
            case 8:
              if (metadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                continue;
              }
              goto label_52;
            case 9:
              goto label_47;
            case 10:
              // ISSUE: reference to a compiler-generated method
              list = metadata.Values.Where<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EnumPropertyDescriptor.\u003C\u003Ec__DisplayClass9_0.GroEegvYQTh7BnPufN6p(v.Uid, valueUid))).ToList<EnumValueMetadata>();
              break;
            case 11:
              if (propMd != null)
              {
                num2 = 16;
                continue;
              }
              goto label_35;
            case 12:
              list = metadata.Values.Where<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v =>
              {
                int num3 = 1;
                int? intValue;
                int num4;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      intValue = v.IntValue;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_4;
                    default:
                      num4 = valueInt;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 2;
                      continue;
                  }
                }
label_4:
                return intValue.GetValueOrDefault() == num4 & intValue.HasValue;
              })).ToList<EnumValueMetadata>();
              break;
            case 13:
              goto label_9;
            case 14:
              if (obj != null)
              {
                num2 = 11;
                continue;
              }
              goto label_31;
            case 15:
              num2 = 14;
              continue;
            case 16:
              propertyCached = obj.GetType().GetPropertyCached((string) EnumPropertyDescriptor.zOstC9GZBmPrwItGR9oM((object) propMd));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 3;
              continue;
            case 17:
              goto label_37;
            case 18:
              if (!EnumPropertyDescriptor.BPFob3GZWC9j0wcieCBS((object) propertyCached, (object) null))
              {
                num2 = 5;
                continue;
              }
              goto label_38;
            case 19:
              goto label_21;
            default:
              int.TryParse(webDataItem.Value, out valueInt);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 9 : 2;
              continue;
          }
          source = list;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 19 : 17;
        }
label_47:
        Guid.TryParse((string) EnumPropertyDescriptor.eAoexSGZhg1QjM2kfTeN((object) webDataItem), out valueUid);
        num1 = 2;
      }
label_40:
      return;
label_5:
      return;
label_39:
      return;
label_9:
      return;
label_37:
      return;
label_35:
      return;
label_38:
      return;
label_52:
      return;
label_21:
      try
      {
        if (source == null)
          return;
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_18;
            case 2:
              EnumPropertyDescriptor.Ao17SmGZfFROKhKqrDCP((object) propertyCached, obj, EnumPropertyDescriptor.AiuVkmGZEQinYwVvpaE7((object) source[0]), (object) null);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
              continue;
            case 3:
              if (source[0] != null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
                continue;
              }
              goto label_4;
            default:
              if (source.Any<EnumValueMetadata>())
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 1;
                continue;
              }
              goto label_3;
          }
        }
label_18:
        return;
label_4:
        return;
label_3:
        return;
      }
      catch (Exception ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_51;
            default:
              Logger.Log.Warn(EnumPropertyDescriptor.J2WkynG8cWLttdTyybZN(-1380439818 << 3 ^ 1841466712), ex);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 0;
              continue;
          }
        }
label_51:
        return;
      }
label_31:;
    }

    private EnumMetadata GetMetadata(Guid subTypeUid, bool throwOnError)
    {
      int num1 = 2;
      EnumMetadata metadata;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              metadata = (EnumMetadata) ((IMetadataService) EnumPropertyDescriptor.RmYHTXGZQ3eAAmDfbi4W()).GetMetadata(subTypeUid);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_9;
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    metadata = (EnumMetadata) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_9;
                }
              }
            }
          case 2:
            metadata = (EnumMetadata) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
            continue;
          case 3:
label_9:
            if (metadata == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto label_16;
          case 4:
            goto label_14;
          case 5:
            goto label_15;
          default:
            if (throwOnError)
            {
              num1 = 5;
              continue;
            }
            goto label_14;
        }
      }
label_14:
      return (EnumMetadata) null;
label_15:
      throw new TypeNotFoundException(subTypeUid);
label_16:
      return metadata;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 7;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!EnumPropertyDescriptor.BPFob3GZWC9j0wcieCBS((object) propertyCached, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 2:
            goto label_27;
          case 3:
            if (propMd != null)
            {
              num1 = 9;
              continue;
            }
            goto label_25;
          case 4:
            goto label_15;
          case 5:
            goto label_26;
          case 6:
            goto label_21;
          case 7:
            if (obj == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 6 : 4;
              continue;
            }
            goto case 3;
          case 8:
            if (!(propMd is PropertyMetadata))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 4 : 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 7 : 10;
            continue;
          case 9:
            propertyCached = obj.GetType().GetPropertyCached((string) EnumPropertyDescriptor.zOstC9GZBmPrwItGR9oM((object) propMd));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
            continue;
          case 10:
            goto label_17;
          default:
            if (!(fieldName != this.indexFieldName(propMd)))
            {
              num1 = 8;
              continue;
            }
            goto label_20;
        }
      }
label_27:
      return;
label_15:
      return;
label_26:
      return;
label_21:
      return;
label_20:
      return;
label_25:
      return;
label_14:
      return;
label_17:
      try
      {
        EnumPropertyDescriptor.Ao17SmGZfFROKhKqrDCP((object) propertyCached, obj, (object) null, (object) null);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
    }

    internal static void O0EIknG8Y0HOn6dCd6PF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xwMGPmG85XCYX5dtbS7s() => EnumPropertyDescriptor.e6Sl2qG8ggH8o8ZyRwbs == null;

    internal static EnumPropertyDescriptor klcJH5G8jdIp9JR1cwSv() => EnumPropertyDescriptor.e6Sl2qG8ggH8o8ZyRwbs;

    internal static bool qF8VhLG8LUb9cfp0FG9f([In] object obj0, [In] object obj1) => (EnumBase) obj0 != (EnumBase) obj1;

    internal static long cAaL2AG8UO6tAIgDCqq6([In] object obj0) => Convert.ToInt64(obj0);

    internal static Guid tBw58dG8seiE5E32XlGx([In] object obj0) => ((EnumBase) obj0).Value;

    internal static object J2WkynG8cWLttdTyybZN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object AS9XJPG8z26yM37OYZq1([In] object obj0) => (object) StringPropertyDescriptor.ConvertToSortable(obj0);

    internal static Guid WiEpCTGZFVY3Fg6QtUJI([In] object obj0) => ((EnumBaseWrapper) obj0).Value;

    internal static object zOstC9GZBmPrwItGR9oM([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool BPFob3GZWC9j0wcieCBS([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object gtkFP0GZoEVTgv9xT3EE([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static Guid AxAg58GZb7jTGFe6u44s([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static object eAoexSGZhg1QjM2kfTeN([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static EnumMetadataType kbWn0ZGZGo1EEEH8gxy6([In] object obj0) => ((EnumMetadata) obj0).Type;

    internal static object AiuVkmGZEQinYwVvpaE7([In] object obj0) => ((EnumValueMetadata) obj0).EnumValue;

    internal static void Ao17SmGZfFROKhKqrDCP([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object RmYHTXGZQ3eAAmDfbi4W() => (object) MetadataServiceContext.Service;
  }
}
