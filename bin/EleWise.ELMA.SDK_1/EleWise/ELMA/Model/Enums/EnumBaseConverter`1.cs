// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Enums.EnumBaseConverter`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Globalization;

namespace EleWise.ELMA.Model.Enums
{
  public class EnumBaseConverter<TEnum> : TypeConverter where TEnum : EnumBase
  {
    internal static object hPgt2xofQjp0KrEWbpFu;

    public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => false;

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!(destinationType == typeof (Guid)))
                goto case 4;
              else
                goto label_13;
            case 2:
            case 3:
              goto label_7;
            case 4:
              if (!(destinationType == typeof (Guid?)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 5;
                continue;
              }
              goto label_7;
            case 5:
              goto label_6;
            case 6:
              if (destinationType == typeof (TEnum))
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            case 7:
              goto label_10;
            default:
              goto label_3;
          }
        }
label_10:
        if (!(destinationType == (Type) null))
        {
          num1 = 6;
          continue;
        }
        break;
label_13:
        num1 = 2;
      }
label_3:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858995779));
label_6:
      return destinationType == typeof (string);
label_7:
      return true;
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!(sourceType == (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_3;
            case 3:
              goto label_5;
            case 4:
              if (!(sourceType == typeof (Guid?)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 4 : 5;
                continue;
              }
              goto label_11;
            case 5:
              goto label_10;
            default:
              if (!(sourceType == typeof (TEnum)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
                continue;
              }
              goto label_11;
          }
        }
label_3:
        if (!(sourceType == typeof (Guid)))
          num1 = 4;
        else
          goto label_11;
      }
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822769626));
label_10:
      return sourceType == typeof (string);
label_11:
      return true;
    }

    public override object ConvertTo(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value,
      Type destinationType)
    {
      int num1 = 11;
      TEnum @enum;
      Guid? nullable1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if ((EnumBase) @enum != (EnumBase) null)
              {
                num2 = 9;
                continue;
              }
              goto label_3;
            case 2:
              goto label_17;
            case 3:
              goto label_24;
            case 4:
              goto label_22;
            case 5:
              goto label_20;
            case 6:
              goto label_15;
            case 7:
              goto label_6;
            case 8:
              if (destinationType == typeof (string))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            case 9:
              goto label_4;
            case 10:
              if (destinationType == typeof (TEnum))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 4 : 4;
                continue;
              }
              @enum = (TEnum) value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            case 11:
              if (!(destinationType == (Type) null))
              {
                num2 = 10;
                continue;
              }
              goto label_10;
            case 12:
              goto label_21;
            case 13:
              goto label_3;
            case 14:
              goto label_10;
            default:
              if (destinationType == typeof (Guid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 7;
                continue;
              }
              if (!(destinationType == typeof (Guid?)))
              {
                num2 = 8;
                continue;
              }
              goto label_15;
          }
        }
label_6:
        if ((EnumBase) @enum != (EnumBase) null)
        {
          num1 = 3;
          continue;
        }
        goto label_21;
label_15:
        if (!((EnumBase) @enum != (EnumBase) null))
        {
          num1 = 2;
          continue;
        }
        goto label_28;
label_17:
        nullable1 = new Guid?();
        num1 = 5;
      }
label_3:
      return (object) null;
label_4:
      return (object) @enum.ToString();
label_5:
      throw new NotSupportedException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767841363), (object) typeof (TEnum).FullName, (object) destinationType.FullName));
label_10:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153963209));
label_20:
      Guid? nullable2 = nullable1;
      goto label_29;
label_21:
      Guid empty = Guid.Empty;
      goto label_25;
label_22:
      return value;
label_24:
      empty = @enum.Value;
label_25:
      return (object) empty;
label_28:
      nullable2 = new Guid?(@enum.Value);
label_29:
      return (object) nullable2;
    }

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      int num = 7;
      Type type;
      Guid result;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(type == typeof (Guid)))
            {
              if (!(type == typeof (string)))
              {
                num = 3;
                continue;
              }
              goto case 2;
            }
            else
            {
              num = 4;
              continue;
            }
          case 2:
            if (Guid.TryParse((string) value, out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 3:
            goto label_15;
          case 4:
            goto label_4;
          case 5:
            goto label_11;
          case 6:
            type = value.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
            continue;
          case 7:
            if (value != null)
            {
              num = 6;
              continue;
            }
            goto label_11;
          default:
            goto label_13;
        }
      }
label_4:
      return ModelHelper.GetEnumValue(typeof (TEnum), (Guid) value);
label_11:
      return (object) null;
label_13:
      return ModelHelper.GetEnumValue(typeof (TEnum), result);
label_14:
      return ModelHelper.GetEnumValue(typeof (TEnum), (string) value);
label_15:
      throw new NotSupportedException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470593800), (object) type.FullName, (object) typeof (TEnum).FullName));
    }

    public EnumBaseConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CPUYbMofCIwpOVj4rbaB() => EnumBaseConverter<TEnum>.hPgt2xofQjp0KrEWbpFu == null;

    internal static object a7yGKrofvclJoZeJgElD() => EnumBaseConverter<TEnum>.hPgt2xofQjp0KrEWbpFu;
  }
}
