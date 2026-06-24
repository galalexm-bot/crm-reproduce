// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.DateTimePropertyDescriptor
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
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class DateTimePropertyDescriptor : FullTextPropertyDescriptor
  {
    private Func<IPropertyMetadata, string> IndexFieldName;
    private static DateTimePropertyDescriptor iT09vMGv8rnDWmrO9NK7;

    public DateTimePropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: reference to a compiler-generated field
      Func<IPropertyMetadata, string> func1 = DateTimePropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__1_0;
      Func<IPropertyMetadata, string> func2;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        DateTimePropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__1_0 = func2 = (Func<IPropertyMetadata, string>) (propMd => (string) DateTimePropertyDescriptor.\u003C\u003Ec.tFX8oovjwJ0Zbpk1YghC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767638753), DateTimePropertyDescriptor.\u003C\u003Ec.cBqH09vjDv88WD08b76d((object) DateTimePropertyDescriptor.\u003C\u003Ec.bBFh64vja6A8jewNaqiy((object) propMd).ToString()), DateTimePropertyDescriptor.\u003C\u003Ec.YNPVVqvjtNkPBZk8chiI(964881585 - -1459193222 ^ -1870807229)));
      }
      else
        goto label_7;
label_3:
      this.IndexFieldName = func2;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
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

    /// <inheritdoc />
    public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      FieldIndexList mappingField = new FieldIndexList();
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
      mappingField.Add(new FieldIndexListItem(this.IndexFieldName(propMd), (object) null, FullTextFieldType.Long, FullTextFieldTag.Sort));
      return mappingField;
    }

    private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 1;
      DateTime dateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (obj is DateTime)
            {
              num = 4;
              continue;
            }
            goto label_6;
          case 3:
            goto label_5;
          case 4:
            dateTime = (DateTime) obj;
            num = 3;
            continue;
          default:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) dateTime.ToString((string) DateTimePropertyDescriptor.FwVDe1GvIUB3rtgTleWA(1052221104 - 768835541 ^ 283437403)), FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.IndexFieldName(propMd), (object) dateTime.Ticks, FullTextFieldType.Long));
      return indexField;
label_6:
      return new FieldIndexList();
    }

    private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (propMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            }
            break;
          case 3:
            goto label_6;
        }
        if (obj is DateTime)
          num = 3;
        else
          goto label_7;
      }
label_6:
      return this.GetIndexField(obj, propMd);
label_7:
      FieldIndexList reIndexField = new FieldIndexList();
      reIndexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) string.Empty, FullTextFieldType.String));
      reIndexField.Add(new FieldIndexListItem(this.IndexFieldName(propMd), (object) null, FullTextFieldType.Long));
      return reIndexField;
label_8:
      return new FieldIndexList();
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      int num1 = 8;
      List<object> values1;
      DateTimeWrapper dateTimeWrapper;
      DateTime? nullable1;
      List<object> values2;
      List<object> values3;
      DateTime dateTime1;
      while (true)
      {
        int num2 = num1;
        RelativeDateTimeWrapper relativeDateTimeWrapper;
        DateTimeRangeWrapper timeRangeWrapper;
        DateTimeRange dateTimeRange;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 46:
              values3 = new List<object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 28 : 2;
              continue;
            case 2:
              goto label_18;
            case 3:
            case 10:
              values1 = new List<object>();
              num2 = 58;
              continue;
            case 4:
            case 38:
            case 40:
              goto label_29;
            case 5:
              relativeDateTimeWrapper = value as RelativeDateTimeWrapper;
              num2 = 34;
              continue;
            case 6:
              goto label_15;
            case 7:
              if (timeRangeWrapper == null)
              {
                num2 = 5;
                continue;
              }
              goto case 59;
            case 8:
              timeRangeWrapper = value as DateTimeRangeWrapper;
              num2 = 7;
              continue;
            case 9:
              if (!nullable1.HasValue)
              {
                num2 = 24;
                continue;
              }
              goto label_27;
            case 11:
              goto label_27;
            case 12:
              nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.YOlJ5kGvVnIU2YydEP8Y((object) timeRangeWrapper)).Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 22 : 17;
              continue;
            case 13:
              if (!nullable1.HasValue)
              {
                num2 = 42;
                continue;
              }
              goto case 52;
            case 14:
            case 42:
              goto label_58;
            case 15:
            case 45:
              values2 = new List<object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 6 : 18;
              continue;
            case 16:
            case 29:
              goto label_54;
            case 17:
              nullable1 = ((DateTimeRangeWrapper) DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper)).From.Value;
              num2 = 30;
              continue;
            case 18:
              List<object> objectList1 = values2;
              long? nullable2;
              if (timeRangeWrapper.From != null)
              {
                nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.YOlJ5kGvVnIU2YydEP8Y((object) timeRangeWrapper)).Value;
                if (nullable1.HasValue)
                {
                  nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.YOlJ5kGvVnIU2YydEP8Y((object) timeRangeWrapper)).Value;
                  DateTime dateTime2 = nullable1.Value;
                  nullable1 = timeRangeWrapper.From.Value;
                  dateTime1 = nullable1.Value;
                  nullable2 = new long?(dateTime1.Ticks);
                  goto label_70;
                }
              }
              nullable2 = new long?();
label_70:
              // ISSUE: variable of a boxed type
              __Boxed<long?> local1 = (System.ValueType) nullable2;
              objectList1.Add((object) local1);
              num2 = 50;
              continue;
            case 19:
              nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9((object) timeRangeWrapper)).Value;
              num2 = 43;
              continue;
            case 20:
              DateTime dateTime3 = nullable1.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
              continue;
            case 21:
              List<object> objectList2 = values3;
              nullable1 = dateTimeRange.To;
              long? nullable3;
              if (nullable1.HasValue)
              {
                nullable1 = dateTimeRange.To;
                DateTime dateTime4 = nullable1.Value;
                nullable1 = dateTimeRange.To;
                dateTime1 = nullable1.Value;
                nullable3 = new long?(dateTime1.Ticks);
              }
              else
                nullable3 = new long?();
              // ISSUE: variable of a boxed type
              __Boxed<long?> local2 = (System.ValueType) nullable3;
              objectList2.Add((object) local2);
              num2 = 2;
              continue;
            case 22:
              if (nullable1.HasValue)
              {
                num2 = 54;
                continue;
              }
              goto case 39;
            case 23:
              nullable1 = dateTimeRange.From;
              num2 = 33;
              continue;
            case 24:
            case 26:
              goto label_28;
            case 25:
              nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9(DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper))).Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 35;
              continue;
            case 27:
              nullable1 = dateTimeRange.From;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 20 : 2;
              continue;
            case 28:
              List<object> objectList3 = values3;
              nullable1 = dateTimeRange.From;
              long? nullable4;
              if (nullable1.HasValue)
              {
                nullable1 = dateTimeRange.From;
                DateTime dateTime5 = nullable1.Value;
                nullable1 = dateTimeRange.From;
                dateTime1 = nullable1.Value;
                nullable4 = new long?(dateTime1.Ticks);
              }
              else
                nullable4 = new long?();
              // ISSUE: variable of a boxed type
              __Boxed<long?> local3 = (System.ValueType) nullable4;
              objectList3.Add((object) local3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 10 : 21;
              continue;
            case 30:
              if (nullable1.HasValue)
              {
                num2 = 3;
                continue;
              }
              goto default;
            case 31:
              goto label_13;
            case 32:
              List<object> objectList4 = values1;
              long? nullable5;
              if (DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9(DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper)) != null)
              {
                nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9(DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper))).Value;
                if (nullable1.HasValue)
                {
                  nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9((object) relativeDateTimeWrapper.DateTimeRange)).Value;
                  dateTime1 = nullable1.Value;
                  nullable5 = new long?(dateTime1.Ticks);
                  goto label_93;
                }
              }
              nullable5 = new long?();
label_93:
              // ISSUE: variable of a boxed type
              __Boxed<long?> local4 = (System.ValueType) nullable5;
              objectList4.Add((object) local4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 41 : 1;
              continue;
            case 33:
              if (!nullable1.HasValue)
                goto case 51;
              else
                goto label_36;
            case 34:
              if (relativeDateTimeWrapper == null)
              {
                num2 = 55;
                continue;
              }
              goto case 37;
            case 35:
              if (nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 10 : 5;
                continue;
              }
              goto label_54;
            case 36:
              if (!nullable1.HasValue)
              {
                num2 = 38;
                continue;
              }
              goto case 19;
            case 37:
              if (DateTimePropertyDescriptor.VTSNiXGvi7rShoRNYSSO((object) relativeDateTimeWrapper))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 29 : 57;
                continue;
              }
              if (DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper) != null)
              {
                num2 = 56;
                continue;
              }
              goto label_15;
            case 39:
              if (DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9((object) timeRangeWrapper) == null)
              {
                num2 = 40;
                continue;
              }
              goto case 49;
            case 41:
              goto label_3;
            case 43:
              DateTime dateTime6 = nullable1.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 4 : 15;
              continue;
            case 44:
              DateTime dateTime7 = nullable1.Value;
              num2 = 45;
              continue;
            case 47:
              nullable1 = dateTimeWrapper.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 9 : 7;
              continue;
            case 48:
              if (dateTimeWrapper == null)
              {
                num2 = 26;
                continue;
              }
              goto case 47;
            case 49:
              nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9((object) timeRangeWrapper)).Value;
              num2 = 36;
              continue;
            case 50:
              List<object> objectList5 = values2;
              long? nullable6;
              if (DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9((object) timeRangeWrapper) != null)
              {
                nullable1 = timeRangeWrapper.To.Value;
                if (nullable1.HasValue)
                {
                  nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9((object) timeRangeWrapper)).Value;
                  DateTime dateTime8 = nullable1.Value;
                  nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9((object) timeRangeWrapper)).Value;
                  dateTime1 = nullable1.Value;
                  nullable6 = new long?(dateTime1.Ticks);
                  goto label_75;
                }
              }
              nullable6 = new long?();
label_75:
              // ISSUE: variable of a boxed type
              __Boxed<long?> local5 = (System.ValueType) nullable6;
              objectList5.Add((object) local5);
              num2 = 31;
              continue;
            case 51:
              nullable1 = dateTimeRange.To;
              num2 = 13;
              continue;
            case 52:
              nullable1 = dateTimeRange.To;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 53 : 27;
              continue;
            case 53:
              DateTime dateTime9 = nullable1.Value;
              num2 = 46;
              continue;
            case 54:
              nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.YOlJ5kGvVnIU2YydEP8Y((object) timeRangeWrapper)).Value;
              num2 = 44;
              continue;
            case 55:
              dateTimeWrapper = value as DateTimeWrapper;
              num2 = 48;
              continue;
            case 56:
              if (((DateTimeRangeWrapper) DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper)).From != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 17 : 6;
                continue;
              }
              goto default;
            case 57:
              dateTimeRange = DateTimePropertyDescriptor.AbU2ldGvKWgwEJ3462V8(DateTimePropertyDescriptor.nql4AGGvRyYYnhjsSa7v((object) relativeDateTimeWrapper), DateTimePropertyDescriptor.SRM9F6GvqldQdYxkOMuP((object) relativeDateTimeWrapper));
              num2 = 23;
              continue;
            case 58:
              List<object> objectList6 = values1;
              long? nullable7;
              if (((DateTimeRangeWrapper) DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper)).From != null)
              {
                nullable1 = ((DateTimeRangeWrapper) DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper)).From.Value;
                if (nullable1.HasValue)
                {
                  nullable1 = ((DateTimeWrapper) DateTimePropertyDescriptor.YOlJ5kGvVnIU2YydEP8Y(DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper))).Value;
                  dateTime1 = nullable1.Value;
                  nullable7 = new long?(dateTime1.Ticks);
                  goto label_88;
                }
              }
              nullable7 = new long?();
label_88:
              // ISSUE: variable of a boxed type
              __Boxed<long?> local6 = (System.ValueType) nullable7;
              objectList6.Add((object) local6);
              num2 = 32;
              continue;
            case 59:
              if (DateTimePropertyDescriptor.YOlJ5kGvVnIU2YydEP8Y((object) timeRangeWrapper) == null)
                goto case 39;
              else
                goto label_46;
            default:
              if (DateTimePropertyDescriptor.AfdNetGvSrifiKfadJO9(DateTimePropertyDescriptor.SsdBa6GvXYP3VVFThnPH((object) relativeDateTimeWrapper)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 6 : 29;
                continue;
              }
              goto case 25;
          }
        }
label_36:
        num1 = 27;
        continue;
label_46:
        num1 = 12;
      }
label_3:
      return new FilterListItem(this.IndexFieldName(propMd), values1, FilterListItemType.Between, FullTextFieldType.Long);
label_13:
      return new FilterListItem(this.IndexFieldName(propMd), values2, FilterListItemType.Between, FullTextFieldType.Long);
label_15:
      return (FilterListItem) null;
label_18:
      return new FilterListItem(this.IndexFieldName(propMd), values3, FilterListItemType.Between, FullTextFieldType.Long);
label_27:
      string field = this.IndexFieldName(propMd);
      List<object> values4 = new List<object>();
      nullable1 = dateTimeWrapper.Value;
      dateTime1 = nullable1.Value;
      values4.Add((object) dateTime1.Ticks);
      return new FilterListItem(field, values4, FilterListItemType.Must, FullTextFieldType.Long);
label_28:
      return (FilterListItem) null;
label_29:
      return (FilterListItem) null;
label_54:
      return (FilterListItem) null;
label_58:
      return (FilterListItem) null;
    }

    public override List<string> GetReturnField(IPropertyMetadata propMd) => new List<string>()
    {
      this.IndexFieldName(propMd)
    };

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.IndexFieldName(propMd), FullTextFieldType.Long);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 11;
      WebDataItem webDataItem;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (propMd != null)
            {
              propertyCached = obj.GetType().GetPropertyCached((string) DateTimePropertyDescriptor.VlJRcZGvT3j39ClKtClo((object) propMd));
              num1 = 6;
              continue;
            }
            num1 = 7;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (!DateTimePropertyDescriptor.lqBBnuGvOxNWcNDOJ1wx(DateTimePropertyDescriptor.p6kO1fGvnqtRkodYrt5S((object) webDataItem), (object) this.IndexFieldName(propMd)))
            {
              num1 = 4;
              continue;
            }
            goto label_11;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 1;
            continue;
          case 5:
            goto label_20;
          case 6:
            webDataItem = value as WebDataItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_23;
          case 8:
            if (webDataItem == null)
            {
              num1 = 9;
              continue;
            }
            goto case 3;
          case 9:
            goto label_6;
          case 10:
            goto label_2;
          case 11:
            if (obj == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 8 : 10;
              continue;
            }
            goto case 1;
          case 12:
            goto label_30;
          default:
            if (!DateTimePropertyDescriptor.ltG0RUGvkCL9lDDjVU4H((object) propertyCached, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 8 : 2;
              continue;
            }
            goto label_10;
        }
      }
label_20:
      return;
label_23:
      return;
label_6:
      return;
label_2:
      return;
label_30:
      return;
label_3:
      try
      {
        long result;
        int num2;
        if (long.TryParse(webDataItem.Value, out result))
          num2 = 2;
        else
          goto label_8;
label_5:
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_22;
            case 1:
              goto label_8;
            case 2:
              propertyCached.SetValue(obj, (object) new DateTime(result), (object[]) null);
              num2 = 3;
              continue;
            case 3:
              goto label_21;
            default:
              goto label_17;
          }
        }
label_22:
        return;
label_21:
        return;
label_17:
        return;
label_8:
        DateTimePropertyDescriptor.oXFECRGv2Z34fjDhwqpf((object) propertyCached, obj, (object) null, (object) null);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_15;
            default:
              DateTimePropertyDescriptor.UgiAhTGvPdqElQgDpa3L(DateTimePropertyDescriptor.qQFHXcGveE7R3l5x8gva(), DateTimePropertyDescriptor.FwVDe1GvIUB3rtgTleWA(1574260816 ^ 1574345400), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
              continue;
          }
        }
label_15:
        return;
      }
label_11:
      return;
label_10:;
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
              propertyCached = obj.GetType().GetPropertyCached((string) DateTimePropertyDescriptor.VlJRcZGvT3j39ClKtClo((object) propMd));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 6;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 7;
            continue;
          case 2:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
              continue;
            }
            goto label_13;
          case 3:
            goto label_31;
          case 4:
            if (propMd is PropertyMetadata)
            {
              num1 = 8;
              continue;
            }
            goto label_39;
          case 5:
            goto label_8;
          case 6:
            if (!DateTimePropertyDescriptor.ltG0RUGvkCL9lDDjVU4H((object) propertyCached, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 7:
            goto label_7;
          case 8:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 10 : 6;
            continue;
          case 9:
            goto label_40;
          case 10:
            goto label_10;
          default:
            if (fieldName != this.IndexFieldName(propMd))
            {
              num1 = 5;
              continue;
            }
            goto case 4;
        }
      }
label_31:
      return;
label_8:
      return;
label_7:
      return;
label_40:
      return;
label_2:
      return;
label_13:
      return;
label_10:
      try
      {
        int num2;
        if (!DateTimePropertyDescriptor.HPUu1VGv1O4jcyCZbvox((object) (propMd as PropertyMetadata)))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 3 : 7;
        else
          goto label_15;
label_12:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, DateTimePropertyDescriptor.lNGegcGv3lVdVc21Kd5Y(__typeref (DateTime)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 6;
              continue;
            case 2:
              if (!(propMd.Settings as DateTimeSettings).SetCurrentDate)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 4;
                continue;
              }
              goto label_29;
            case 3:
              goto label_30;
            case 4:
              // ISSUE: type reference
              obj1 = this.TypeDescriptor.SerializeSimple((object) null, DateTimePropertyDescriptor.lNGegcGv3lVdVc21Kd5Y(__typeref (DateTime)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_24;
            case 6:
              DateTimePropertyDescriptor.oXFECRGv2Z34fjDhwqpf((object) propertyCached, obj, obj2, (object) null);
              num2 = 3;
              continue;
            case 7:
            case 8:
              if (DateTimePropertyDescriptor.dcNGHpGvNVaw3uwcdNLw((object) propMd) is DateTimeSettings)
              {
                num2 = 2;
                continue;
              }
              goto label_28;
            default:
              goto label_15;
          }
        }
label_30:
        return;
label_24:
        return;
label_29:
        return;
label_28:
        return;
label_15:
        propertyCached.SetValue(obj, (object) null, (object[]) null);
        num2 = 5;
        goto label_12;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_39:;
    }

    internal static bool vD3SS3GvZu1OjLO2IAMn() => DateTimePropertyDescriptor.iT09vMGv8rnDWmrO9NK7 == null;

    internal static DateTimePropertyDescriptor AUulPAGvuvgY2kaX6Xke() => DateTimePropertyDescriptor.iT09vMGv8rnDWmrO9NK7;

    internal static object FwVDe1GvIUB3rtgTleWA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YOlJ5kGvVnIU2YydEP8Y([In] object obj0) => (object) ((DateTimeRangeWrapper) obj0).From;

    internal static object AfdNetGvSrifiKfadJO9([In] object obj0) => (object) ((DateTimeRangeWrapper) obj0).To;

    internal static bool VTSNiXGvi7rShoRNYSSO([In] object obj0) => ((RelativeDateTimeWrapper) obj0).IsRelative;

    internal static object nql4AGGvRyYYnhjsSa7v([In] object obj0) => (object) ((RelativeDateTimeWrapper) obj0).RelativeFrom;

    internal static object SRM9F6GvqldQdYxkOMuP([In] object obj0) => (object) ((RelativeDateTimeWrapper) obj0).RelativeTo;

    internal static DateTimeRange AbU2ldGvKWgwEJ3462V8([In] object obj0, [In] object obj1) => RelativeDateTimeDescriptor.GetDateTimeRange((string) obj0, (string) obj1);

    internal static object SsdBa6GvXYP3VVFThnPH([In] object obj0) => (object) ((RelativeDateTimeWrapper) obj0).DateTimeRange;

    internal static object VlJRcZGvT3j39ClKtClo([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool ltG0RUGvkCL9lDDjVU4H([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object p6kO1fGvnqtRkodYrt5S([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool lqBBnuGvOxNWcNDOJ1wx([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void oXFECRGv2Z34fjDhwqpf([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object qQFHXcGveE7R3l5x8gva() => (object) Logger.Log;

    internal static void UgiAhTGvPdqElQgDpa3L([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static bool HPUu1VGv1O4jcyCZbvox([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static object dcNGHpGvNVaw3uwcdNLw([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;

    internal static Type lNGegcGv3lVdVc21Kd5Y([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
