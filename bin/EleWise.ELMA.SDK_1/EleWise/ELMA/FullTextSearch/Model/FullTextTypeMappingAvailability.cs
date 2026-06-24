// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FullTextTypeMappingAvailability
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <inheritdoc />
  internal sealed class FullTextTypeMappingAvailability : IFullTextTypeMappingAvailability
  {
    internal static FullTextTypeMappingAvailability mr7l3SGiOW2U2gk34FAr;

    /// <summary>Ctor.</summary>
    /// <param name="errors">Список ошибок, из-за которых сервис является недоступным.</param>
    private FullTextTypeMappingAvailability(params string[] errors)
    {
      FullTextTypeMappingAvailability.sCGkDvGiPEAV5TO3vUqq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Errors = (IReadOnlyCollection<string>) errors;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            this.IsAvailable = errors.Length == 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public bool IsAvailable { get; }

    /// <inheritdoc />
    public IReadOnlyCollection<string> Errors { get; }

    /// <summary>Сервис доступен.</summary>
    internal static FullTextTypeMappingAvailability Available() => new FullTextTypeMappingAvailability(Array.Empty<string>());

    /// <summary>Сервис недоступен.</summary>
    /// <param name="errors">Список ошибок, из-за которых сервис является недоступным.</param>
    internal static FullTextTypeMappingAvailability NotAvailable(params string[] errors) => new FullTextTypeMappingAvailability(errors);

    internal static void sCGkDvGiPEAV5TO3vUqq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool qQ9fXuGi2xSgtyOqNGsg() => FullTextTypeMappingAvailability.mr7l3SGiOW2U2gk34FAr == null;

    internal static FullTextTypeMappingAvailability PMsfIqGieripk3ZZjGDQ() => FullTextTypeMappingAvailability.mr7l3SGiOW2U2gk34FAr;
  }
}
