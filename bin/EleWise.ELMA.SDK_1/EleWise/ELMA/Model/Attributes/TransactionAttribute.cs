// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TransactionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Data;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут метода, который может выполняться в транзакции
  /// </summary>
  [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
  public class TransactionAttribute : Attribute
  {
    internal static TransactionAttribute yfIHmkoILjCMP51pgiqP;

    /// <summary>Ctor</summary>
    public TransactionAttribute()
    {
      TransactionAttribute.sVcHIGoIcgOD4dNyKJbg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.IsolationLevel = IsolationLevel.Unspecified;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уровень изоляции транзации</summary>
    public IsolationLevel IsolationLevel
    {
      get => this.\u003CIsolationLevel\u003Ek__BackingField;
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
              this.\u003CIsolationLevel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    internal static void sVcHIGoIcgOD4dNyKJbg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool squ2J8oIUCpjm5t3mLws() => TransactionAttribute.yfIHmkoILjCMP51pgiqP == null;

    internal static TransactionAttribute wD9w8foIseCiAd1KJ7fR() => TransactionAttribute.yfIHmkoILjCMP51pgiqP;
  }
}
