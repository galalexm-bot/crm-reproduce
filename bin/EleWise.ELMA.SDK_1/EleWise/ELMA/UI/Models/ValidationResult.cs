// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ValidationResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Результат проверки</summary>
  public sealed class ValidationResult
  {
    internal static ValidationResult HgdH8qBb25JXOFpcaNdi;

    /// <summary>Ctor</summary>
    /// <param name="success">Пройдена ли проверка</param>
    /// <param name="errors">Список ошибок</param>
    public ValidationResult(bool success, params ValidationError[] errors)
    {
      ValidationResult.S8i6doBb1HBiWiTBB5xy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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
    public ValidationResult(bool success, IEnumerable<ValidationError> errors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(success, errors.ToArray<ValidationError>());
    }

    /// <summary>Пройдена ли проверка</summary>
    public bool IsValid { get; }

    /// <summary>Список ошибок</summary>
    public ValidationError[] Errors { get; }

    internal static void S8i6doBb1HBiWiTBB5xy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jYKgKkBbe5tXajUeDTyL() => ValidationResult.HgdH8qBb25JXOFpcaNdi == null;

    internal static ValidationResult kbHYoYBbPpFhZnvol5ek() => ValidationResult.HgdH8qBb25JXOFpcaNdi;
  }
}
