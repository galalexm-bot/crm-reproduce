// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonInformationPart
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>Блок общей информации</summary>
  [Component]
  public abstract class CommonInformationPart : ICommonInformationPart
  {
    internal static CommonInformationPart aTb0lHEQiVBL4A497daK;

    /// <inheritdoc />
    public abstract string Title { get; }

    /// <inheritdoc />
    public abstract IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics);

    protected CommonInformationPart()
    {
      CommonInformationPart.IWykc0EQKhQkDQ2CVg70();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void IWykc0EQKhQkDQ2CVg70() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JIdSXOEQRi9K3TKDeIZG() => CommonInformationPart.aTb0lHEQiVBL4A497daK == null;

    internal static CommonInformationPart PsXjflEQqJqV9qKckh7y() => CommonInformationPart.aTb0lHEQiVBL4A497daK;
  }
}
