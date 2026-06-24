// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.StringPropertyDescriptor
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class StringPropertyDescriptor : FullTextPropertyDescriptor
  {
    internal static StringPropertyDescriptor Wi7Q95GuV37ADXK74hYF;

    public StringPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      StringPropertyDescriptor.hpdOMKGuReJbWaRlJk66();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Выбираем только буквы и цифры</summary>
    public static string ConvertToSortable(object obj)
    {
      int num1 = 1;
      string str;
      IEnumerator<char> enumerator;
      string sortable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_22;
          case 2:
            if (str != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 4;
              continue;
            }
            goto label_24;
          case 3:
            goto label_22;
          case 4:
            sortable = string.Empty;
            num1 = 9;
            continue;
          case 5:
            goto label_24;
          case 6:
label_6:
            sortable = (string) StringPropertyDescriptor.gpjsjyGuXJVnNBqVEPjF((object) sortable, StringPropertyDescriptor.hpVe5GGunx2A196kWAM6(1574260816 ^ 1574260700));
            num1 = 7;
            continue;
          case 7:
            goto label_5;
          case 8:
            try
            {
label_13:
              if (StringPropertyDescriptor.KQaPgYGuTs6NupInWWE6((object) enumerator))
                goto label_11;
              else
                goto label_14;
label_10:
              char current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_11;
                  case 2:
                    sortable = (string) StringPropertyDescriptor.gpjsjyGuXJVnNBqVEPjF((object) sortable, (object) current.ToString());
                    num2 = 3;
                    continue;
                  case 3:
                    goto label_13;
                  default:
                    goto label_6;
                }
              }
label_11:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
              {
                num2 = 2;
                goto label_10;
              }
              else
                goto label_10;
label_14:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              goto label_10;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      StringPropertyDescriptor.osP3xZGuk3hb9qPfXIDK((object) enumerator);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_21;
                  }
                }
              }
label_21:;
            }
          case 9:
            enumerator = ((IEnumerable<char>) StringPropertyDescriptor.LWGYISGuKpnOv9duJuUe((object) str)).Where<char>(new Func<char, bool>(char.IsLetterOrDigit)).Take<char>(50).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 8;
            continue;
          default:
            str = (string) StringPropertyDescriptor.oigbtmGuqMG72uxrWcMl(obj);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      return sortable;
label_22:
      return string.Empty;
label_24:
      return string.Empty;
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
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), StringPropertyDescriptor.oigbtmGuqMG72uxrWcMl(obj), FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.SortFieldName(propMd), StringPropertyDescriptor.D5g1j4GuOjZEw7SLMWiG(obj), FullTextFieldType.String));
      return indexField;
    }

    public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd) => new FieldListItem(this.ValueFieldName(propMd), value != null ? value.ToString() : string.Empty);

    public override SortListItem GetSortField(IPropertyMetadata propMd) => new SortListItem(this.SortFieldName(propMd), FullTextFieldType.String);

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 5;
      PropertyInfo propertyCached;
      WebDataItem webDataItem;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_20;
            case 1:
              goto label_8;
            case 2:
              if (propMd != null)
              {
                num2 = 3;
                continue;
              }
              goto label_12;
            case 3:
              propertyCached = obj.GetType().GetPropertyCached((string) StringPropertyDescriptor.bJUkOhGu2KyZY8lC5lDa((object) propMd));
              num2 = 8;
              continue;
            case 4:
              goto label_7;
            case 5:
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 4;
                continue;
              }
              goto case 2;
            case 6:
              goto label_17;
            case 7:
              goto label_29;
            case 8:
              webDataItem = value as WebDataItem;
              num2 = 11;
              continue;
            case 9:
              goto label_27;
            case 10:
              if (webDataItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 7;
                continue;
              }
              goto label_19;
            case 11:
              if (StringPropertyDescriptor.BYUfuCGuev6yyG6Z62F0((object) propertyCached, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 12:
              goto label_9;
            default:
              goto label_13;
          }
        }
label_29:
        num1 = !StringPropertyDescriptor.LB69uIGuPi9rAkkkD59T((object) webDataItem.Name, (object) this.ValueFieldName(propMd)) ? 12 : 6;
      }
label_20:
      return;
label_8:
      return;
label_7:
      return;
label_17:
      return;
label_27:
      return;
label_13:
      return;
label_9:
      try
      {
        StringPropertyDescriptor.yQsQ6KGuNbLkLMHRFhiw((object) propertyCached, obj, StringPropertyDescriptor.S3yAVxGu1PWDmDetRFGG((object) webDataItem), (object) null);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_31;
            default:
              ((ILogger) StringPropertyDescriptor.SfRgcMGu38WOdEXRY164()).Warn(StringPropertyDescriptor.hpVe5GGunx2A196kWAM6(-688192331 - 435440695 ^ -1123716458), ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
          }
        }
label_31:
        return;
      }
label_12:
      return;
label_19:;
    }

    public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
    {
      int num1 = 6;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!StringPropertyDescriptor.BYUfuCGuev6yyG6Z62F0((object) propertyCached, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            }
            goto label_30;
          case 2:
            propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          case 4:
            num1 = 10;
            continue;
          case 5:
            if (propMd != null)
            {
              num1 = 2;
              continue;
            }
            goto label_15;
          case 6:
            if (obj != null)
            {
              num1 = 5;
              continue;
            }
            goto label_19;
          case 7:
            goto label_31;
          case 8:
            if (propMd is PropertyMetadata)
            {
              num1 = 4;
              continue;
            }
            goto label_26;
          case 9:
            goto label_34;
          case 10:
            goto label_16;
          case 11:
            goto label_25;
          default:
            if (StringPropertyDescriptor.LB69uIGuPi9rAkkkD59T((object) fieldName, (object) this.ValueFieldName(propMd)))
            {
              num1 = 7;
              continue;
            }
            goto case 8;
        }
      }
label_3:
      return;
label_31:
      return;
label_34:
      return;
label_25:
      return;
label_19:
      return;
label_30:
      return;
label_26:
      return;
label_16:
      try
      {
        int num2;
        if (StringPropertyDescriptor.hmBal4GupL4RNsoI5TUS((object) (propMd as PropertyMetadata)))
          num2 = 2;
        else
          goto label_23;
label_18:
        object obj1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_5;
            case 2:
              StringPropertyDescriptor.yQsQ6KGuNbLkLMHRFhiw((object) propertyCached, obj, (object) null, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_23;
            case 4:
              // ISSUE: type reference
              obj2 = this.TypeDescriptor.DeserializeSimple(obj1, StringPropertyDescriptor.UJDj7aGuajYt8vUot9rw(__typeref (string)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 5 : 0;
              continue;
            case 5:
              propertyCached.SetValue(obj, obj2, (object[]) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_12:
        return;
label_5:
        return;
label_2:
        return;
label_23:
        // ISSUE: type reference
        obj1 = this.TypeDescriptor.SerializeSimple((object) null, StringPropertyDescriptor.UJDj7aGuajYt8vUot9rw(__typeref (string)));
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        {
          num2 = 4;
          goto label_18;
        }
        else
          goto label_18;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
label_15:;
    }

    internal static void hpdOMKGuReJbWaRlJk66() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool joNNQOGuSB9AX0HCnJ6W() => StringPropertyDescriptor.Wi7Q95GuV37ADXK74hYF == null;

    internal static StringPropertyDescriptor yf5afHGuifrKrXaJg4in() => StringPropertyDescriptor.Wi7Q95GuV37ADXK74hYF;

    internal static object oigbtmGuqMG72uxrWcMl([In] object obj0) => (object) Convert.ToString(obj0);

    internal static object LWGYISGuKpnOv9duJuUe([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object gpjsjyGuXJVnNBqVEPjF([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool KQaPgYGuTs6NupInWWE6([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void osP3xZGuk3hb9qPfXIDK([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object hpVe5GGunx2A196kWAM6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object D5g1j4GuOjZEw7SLMWiG([In] object obj0) => (object) StringPropertyDescriptor.ConvertToSortable(obj0);

    internal static object bJUkOhGu2KyZY8lC5lDa([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool BYUfuCGuev6yyG6Z62F0([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool LB69uIGuPi9rAkkkD59T([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object S3yAVxGu1PWDmDetRFGG([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static void yQsQ6KGuNbLkLMHRFhiw([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object SfRgcMGu38WOdEXRY164() => (object) Logger.Log;

    internal static bool hmBal4GupL4RNsoI5TUS([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type UJDj7aGuajYt8vUot9rw([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
