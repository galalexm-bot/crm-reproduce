// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.MoneyTypeConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Common.Models
{
  public class MoneyTypeConverter : TypeConverter
  {
    internal static MoneyTypeConverter mnwrHrfS5awDvLkklbin;

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => false;

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!(destinationType == (Type) null))
            {
              // ISSUE: type reference
              if (!(destinationType == MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (Money))))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 3;
                continue;
              }
              goto label_3;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
              continue;
            }
          case 3:
            // ISSUE: type reference
            if (!(destinationType == MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double))))
            {
              num = 5;
              continue;
            }
            goto label_3;
          case 4:
            goto label_2;
          case 5:
            // ISSUE: type reference
            if (MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(destinationType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double?))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      // ISSUE: type reference
      return MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(destinationType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (string)));
label_3:
      return true;
label_4:
      throw new ArgumentNullException((string) MoneyTypeConverter.i7E0RefSLN6ok9gqjsXG(-1867198571 ^ -1867081847));
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (!MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(sourceType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (Money))))
            {
              num = 4;
              continue;
            }
            goto label_10;
          case 2:
            if (!MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(sourceType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 3:
            // ISSUE: type reference
            if (sourceType == MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double?)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 0;
              continue;
            }
            goto label_9;
          case 4:
            // ISSUE: type reference
            if (!MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(sourceType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double))))
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 5:
            goto label_10;
          case 6:
            goto label_9;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) MoneyTypeConverter.i7E0RefSLN6ok9gqjsXG(825385222 ^ 825243960));
label_9:
      // ISSUE: type reference
      return sourceType == MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (string));
label_10:
      return true;
    }

    public override object ConvertTo(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value,
      Type destinationType)
    {
      int num1 = 8;
      double? nullable1;
      Money money;
      TypeConverter typeConverter;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              money = (Money) value;
              num2 = 10;
              continue;
            case 3:
              if (money.HasValue)
              {
                num2 = 15;
                continue;
              }
              goto case 13;
            case 4:
              goto label_23;
            case 5:
              goto label_3;
            case 6:
              if (!money.HasValue)
              {
                num2 = 16;
                continue;
              }
              goto label_25;
            case 7:
              goto label_7;
            case 8:
              if (MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(destinationType, (Type) null))
              {
                num2 = 7;
                continue;
              }
              goto label_8;
            case 9:
              goto label_21;
            case 10:
              // ISSUE: type reference
              if (MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(destinationType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double))))
              {
                num2 = 6;
                continue;
              }
              // ISSUE: type reference
              if (!MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(destinationType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double?))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 12 : 5;
                continue;
              }
              goto case 3;
            case 11:
              // ISSUE: type reference
              typeConverter = (TypeConverter) MoneyTypeConverter.LJSPwLfScgGxXTt4iQWc(MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double)));
              num2 = 14;
              continue;
            case 12:
              // ISSUE: type reference
              if (!MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(destinationType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (string))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 4;
                continue;
              }
              goto case 11;
            case 13:
              nullable1 = new double?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 5;
              continue;
            case 14:
              if (money.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              }
              goto label_21;
            case 15:
              goto label_29;
            case 16:
              goto label_6;
            default:
              goto label_22;
          }
        }
label_8:
        // ISSUE: type reference
        if (!MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(destinationType, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (Money))))
          num1 = 2;
        else
          goto label_13;
      }
label_3:
      double? nullable2 = nullable1;
      goto label_30;
label_6:
      double num3 = 0.0;
      goto label_26;
label_7:
      throw new ArgumentNullException((string) MoneyTypeConverter.i7E0RefSLN6ok9gqjsXG(-1858887263 ^ -1858995779));
label_13:
      return value;
label_21:
      return (object) null;
label_22:
      return MoneyTypeConverter.xN7rYWfSzXBNNyGu4JJ2((object) typeConverter, (object) context, (object) culture, (object) money.Value);
label_23:
      // ISSUE: type reference
      throw new NotSupportedException((string) MoneyTypeConverter.ckZbG1fiFVAaZ7hWGsHd(MoneyTypeConverter.i7E0RefSLN6ok9gqjsXG(-441065788 ^ -2092910478 ^ 1727479520), (object) MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (Money)).FullName, (object) destinationType.FullName));
label_25:
      num3 = money.Value;
label_26:
      return (object) num3;
label_29:
      nullable2 = new double?(money.Value);
label_30:
      return (object) nullable2;
    }

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      int num1 = 6;
      Money money;
      Type type;
      while (true)
      {
        int num2 = num1;
        double num3;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_25;
            case 2:
              money.HasValue = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_19;
            case 4:
              money = new Money();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 9 : 15;
              continue;
            case 5:
              type = value.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 9;
              continue;
            case 6:
              if (value != null)
              {
                num2 = 5;
                continue;
              }
              goto case 10;
            case 7:
              money.HasValue = false;
              num2 = 3;
              continue;
            case 8:
              if (MoneyTypeConverter.YGclvsfiBbxEKfRdWM5G((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 10 : 13;
                continue;
              }
              goto label_29;
            case 9:
              // ISSUE: type reference
              if (!MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(type, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (Money))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 12 : 3;
                continue;
              }
              goto label_25;
            case 10:
              money = new Money();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 7 : 5;
              continue;
            case 11:
              str = (string) value;
              num2 = 8;
              continue;
            case 12:
              // ISSUE: type reference
              if (MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(type, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 5 : 18;
                continue;
              }
              goto label_22;
            case 13:
              money = new Money();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 1;
              continue;
            case 14:
              goto label_7;
            case 15:
              money.Value = num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 14 : 14;
              continue;
            case 16:
              money.Value = (double) value;
              num2 = 17;
              continue;
            case 17:
              goto label_21;
            case 18:
              money = new Money();
              num2 = 16;
              continue;
            default:
              goto label_28;
          }
        }
label_22:
        // ISSUE: type reference
        if (MoneyTypeConverter.HtSwXVfSsTXD8yn3p8DK(type, MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (string))))
        {
          num1 = 11;
          continue;
        }
        goto label_8;
label_29:
        // ISSUE: type reference
        object obj = MoneyTypeConverter.LJSPwLfScgGxXTt4iQWc(MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (double)));
        if (!culture.Equals(MoneyTypeConverter.BHmOwnfiWn6nD8HwYAnC()))
        {
          string decimalSeparator = ((NumberFormatInfo) MoneyTypeConverter.zSsrs6fioQwo09xNpx3S((object) CultureInfo.CurrentCulture)).CurrencyDecimalSeparator;
          string newValue = (string) MoneyTypeConverter.jbuU05fibjEHP5P7dRCM(MoneyTypeConverter.zSsrs6fioQwo09xNpx3S((object) culture));
          str = str.Replace(decimalSeparator, newValue);
        }
        ITypeDescriptorContext context1 = context;
        CultureInfo culture1 = culture;
        string text = str;
        num3 = (double) ((TypeConverter) obj).ConvertFromString(context1, culture1, text);
        num1 = 4;
      }
label_7:
      return (object) money;
label_8:
      // ISSUE: type reference
      throw new NotSupportedException((string) MoneyTypeConverter.ckZbG1fiFVAaZ7hWGsHd(MoneyTypeConverter.i7E0RefSLN6ok9gqjsXG(-2092274397 << 4 ^ 883198566), (object) type.FullName, (object) MoneyTypeConverter.RnRBaEfSUCgqqkjI5vfT(__typeref (Money)).FullName));
label_19:
      return (object) money;
label_21:
      return (object) money;
label_25:
      return value;
label_28:
      return (object) money;
    }

    public MoneyTypeConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object i7E0RefSLN6ok9gqjsXG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type RnRBaEfSUCgqqkjI5vfT([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool HtSwXVfSsTXD8yn3p8DK([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool z9trKKfSjZxBQtc7kZIG() => MoneyTypeConverter.mnwrHrfS5awDvLkklbin == null;

    internal static MoneyTypeConverter ogloyHfSYurTiGJN2bXX() => MoneyTypeConverter.mnwrHrfS5awDvLkklbin;

    internal static object LJSPwLfScgGxXTt4iQWc([In] Type obj0) => (object) TypeDescriptor.GetConverter(obj0);

    internal static object xN7rYWfSzXBNNyGu4JJ2(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((TypeConverter) obj0).ConvertToString((ITypeDescriptorContext) obj1, (CultureInfo) obj2, obj3);
    }

    internal static object ckZbG1fiFVAaZ7hWGsHd([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool YGclvsfiBbxEKfRdWM5G([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object BHmOwnfiWn6nD8HwYAnC() => (object) CultureInfo.CurrentCulture;

    internal static object zSsrs6fioQwo09xNpx3S([In] object obj0) => (object) ((CultureInfo) obj0).NumberFormat;

    internal static object jbuU05fibjEHP5P7dRCM([In] object obj0) => (object) ((NumberFormatInfo) obj0).CurrencyDecimalSeparator;
  }
}
