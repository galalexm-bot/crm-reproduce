// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.MoneyRange
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Model.Ranges
{
  /// <summary>Диапазон типа "Деньги"</summary>
  public struct MoneyRange : IRange<Money>
  {
    internal static object IlluDsWzArohGje9NaGf;

    /// <summary>От</summary>
    public Money From
    {
      get => this.\u003CFrom\u003Ek__BackingField;
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
              this.\u003CFrom\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    /// <summary>До</summary>
    public Money To
    {
      get => this.\u003CTo\u003Ek__BackingField;
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
              this.\u003CTo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    Money? IRange<Money>.From
    {
      get => !this.From.HasValue ? new Money?() : new Money?(this.From);
      set
      {
        Money? nullable = value;
        Money money;
        if (!nullable.HasValue)
          money = new Money() { HasValue = false };
        else
          money = nullable.GetValueOrDefault();
        this.From = money;
      }
    }

    /// <inheritdoc />
    Money? IRange<Money>.To
    {
      get => !this.To.HasValue ? new Money?() : new Money?(this.To);
      set
      {
        Money? nullable = value;
        Money money;
        if (!nullable.HasValue)
          money = new Money() { HasValue = false };
        else
          money = nullable.GetValueOrDefault();
        this.To = money;
      }
    }

    internal static bool Ge7HO0Wz7n9OZ88nZfe1() => MoneyRange.IlluDsWzArohGje9NaGf == null;

    internal static object ePuh5xWzxuqKw5SuiiMU() => MoneyRange.IlluDsWzArohGje9NaGf;
  }
}
