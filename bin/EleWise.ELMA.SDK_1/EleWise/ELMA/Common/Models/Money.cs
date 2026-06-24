// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.Money
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Деньги</summary>
  /// <remarks>
  /// Пока содержит только числовое значение. В будущем можно будет добавить поддержку валюты.
  /// </remarks>
  [Component]
  [TypeConverter(typeof (MoneyTypeConverter))]
  public struct Money : IComparable, IXsiType
  {
    private double value;
    private bool hasValue;
    private static object vb3FJFfSMse5ODPSJfSG;

    /// <summary>Значение</summary>
    public double Value
    {
      get => this.value;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.hasValue = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            case 2:
              this.value = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    /// <summary>Установлено ли значение</summary>
    public bool HasValue
    {
      get => this.hasValue;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.hasValue = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Получить строковое представление</summary>
    /// <returns></returns>
    public override string ToString()
    {
      int num1 = 1;
      double num2;
      while (true)
      {
        int num3 = num1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (this.HasValue)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            case 3:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_5:
        num2 = this.Value;
        num1 = 3;
      }
label_3:
      return num2.ToString();
label_4:
      return "";
    }

    public static implicit operator double(Money m)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!m.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return 0.0;
label_5:
      return m.Value;
    }

    public static implicit operator Money(double d)
    {
      int num = 1;
      Money money;
      while (true)
      {
        switch (num)
        {
          case 1:
            money = new Money();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            money.Value = d;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return money;
    }

    public int CompareTo(object obj)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (!Money.oZwlV0fSgLMywJ57JJlY(obj.GetType(), Money.ec9oHDfSrP87Uum4dStk(__typeref (double?))))
            {
              // ISSUE: type reference
              if (!(obj.GetType() == Money.ec9oHDfSrP87Uum4dStk(__typeref (double))))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 0;
              continue;
            }
          case 2:
            goto label_2;
          case 3:
            goto label_9;
          case 4:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 3;
              continue;
            }
            // ISSUE: type reference
            if (!Money.oZwlV0fSgLMywJ57JJlY(obj.GetType(), Money.ec9oHDfSrP87Uum4dStk(__typeref (Money))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            }
            goto label_12;
          case 5:
            goto label_7;
          case 6:
            goto label_12;
          default:
            goto label_8;
        }
      }
label_2:
      return this.Compare((double?) obj);
label_7:
      return this.Compare(new double?((double) obj));
label_8:
      throw new InvalidOperationException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107666852)), Money.aJLArVfSld2s4wtJ6puu(Money.MauWOcfSdwlQwWBYIfBU(-1426456882 ^ 2009939514 ^ -583645290)), (object) obj.GetType().FullName));
label_9:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) Money.MauWOcfSdwlQwWBYIfBU(1654249598 >> 2 ^ 413349885), Money.aJLArVfSld2s4wtJ6puu((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978640496))));
label_12:
      Money money = (Money) obj;
      double? nullable;
      if (!money.HasValue)
      {
        nullable = new double?();
      }
      else
      {
        money = (Money) obj;
        nullable = new double?(money.Value);
      }
      return this.Compare(nullable);
    }

    private int Compare(double? value)
    {
      int num = this.HasValue.CompareTo(value.HasValue);
      return num == 0 && this.HasValue ? this.Value.CompareTo((object) value) : num;
    }

    internal static bool n20DSJfSJyAFunc6wRlM() => Money.vb3FJFfSMse5ODPSJfSG == null;

    internal static object Opbi8NfS98EgMwXwmhhS() => Money.vb3FJFfSMse5ODPSJfSG;

    internal static object MauWOcfSdwlQwWBYIfBU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aJLArVfSld2s4wtJ6puu([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Type ec9oHDfSrP87Uum4dStk([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool oZwlV0fSgLMywJ57JJlY([In] Type obj0, [In] Type obj1) => obj0 == obj1;
  }
}
