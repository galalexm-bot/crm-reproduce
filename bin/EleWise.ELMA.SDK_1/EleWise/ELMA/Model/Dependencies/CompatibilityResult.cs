// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.CompatibilityResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Результат проверки совместимости</summary>
  public sealed class CompatibilityResult
  {
    private static CompatibilityResult ztYKgDhiHsKjo8SJNw1M;

    /// <summary>Ctor</summary>
    /// <param name="success">Пройдена ли проверка</param>
    /// <param name="errors">Список ошибок</param>
    public CompatibilityResult(bool success, params string[] errors)
    {
      CompatibilityResult.Yu7kOThixDwmVn8LYBme();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.IsValid = success;
            num = 2;
            continue;
          case 2:
            this.Errors = errors;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Ctor</summary>
    /// <param name="success">Пройдена ли проверка</param>
    /// <param name="errors">Список ошибок</param>
    public CompatibilityResult(bool success, IEnumerable<string> errors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(success, errors.ToArray<string>());
    }

    /// <summary>Пройдена ли проверка</summary>
    public bool IsValid { get; }

    /// <summary>Список ошибок</summary>
    public string[] Errors { get; }

    /// <summary>Результат пройденной проверки</summary>
    /// <returns>Результат проверки</returns>
    public static CompatibilityResult Ok() => new CompatibilityResult(true, Array.Empty<string>());

    /// <summary>Результат проверки с ошибкой</summary>
    /// <param name="errors">Ошибки</param>
    /// <returns>Результат проверки с ошибкой</returns>
    public static CompatibilityResult Error(IEnumerable<string> errors) => new CompatibilityResult(false, errors);

    /// <summary>Результат проверки с ошибкой</summary>
    /// <param name="errors">Ошибки</param>
    /// <returns>Результат проверки с ошибкой</returns>
    public static CompatibilityResult Error(params string[] errors) => new CompatibilityResult(false, errors);

    internal static void Yu7kOThixDwmVn8LYBme() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tr5onchiAjiURZ1kPxOX() => CompatibilityResult.ztYKgDhiHsKjo8SJNw1M == null;

    internal static CompatibilityResult sZwSCehi7aMLssbr7iPA() => CompatibilityResult.ztYKgDhiHsKjo8SJNw1M;
  }
}
