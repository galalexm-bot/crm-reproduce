// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.DefaultDateTimeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Common
{
  /// <summary>
  /// Провайдер, который всегда предоставляет реальное текущее время.
  /// </summary>
  [Service]
  public class DefaultDateTimeProvider : IDateTimeProvider
  {
    internal static DefaultDateTimeProvider w7iTgHfIzPMW8rmuj2iW;

    /// <inheritdoc />
    public DateTime Now() => DefaultDateTimeProvider.Koig3jfVWyktheEf5LqJ();

    /// <inheritdoc />
    public DateTime UtcNow() => DefaultDateTimeProvider.QoyG2NfVo7P4pHJh78iQ();

    public DefaultDateTimeProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static DateTime Koig3jfVWyktheEf5LqJ() => DateTime.Now;

    internal static DateTime QoyG2NfVo7P4pHJh78iQ() => DateTime.UtcNow;

    internal static bool fjDO71fVFDVBFJGl59tO() => DefaultDateTimeProvider.w7iTgHfIzPMW8rmuj2iW == null;

    internal static DefaultDateTimeProvider UXxZ8UfVBnxJJHdtWGgE() => DefaultDateTimeProvider.w7iTgHfIzPMW8rmuj2iW;
  }
}
