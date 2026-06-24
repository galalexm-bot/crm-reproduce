// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.FullTextSearchSettingsModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch
{
  /// <summary>Модуль настроек индексации</summary>
  [Component]
  public class FullTextSearchSettingsModule : GlobalSettingsModuleBase<FullTextSearchSettings>
  {
    private static FullTextSearchSettingsModule dJTjE0GQSArhxB5W8CZo;

    public override string ModuleName => EleWise.ELMA.SR.T((string) FullTextSearchSettingsModule.vn1Hm3GQqhFhE0XvfLPQ(1142330761 ^ 1541959139 ^ 536688876));

    public override Guid ModuleGuid => FullTextSearchSettingsModule.YjA5obGQKxuyiUYSRXs5(FullTextSearchSettingsModule.vn1Hm3GQqhFhE0XvfLPQ(-740338220 ^ -740518554));

    public FullTextSearchSettingsModule()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object vn1Hm3GQqhFhE0XvfLPQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool mtpGZwGQi7g5jQIJDrvA() => FullTextSearchSettingsModule.dJTjE0GQSArhxB5W8CZo == null;

    internal static FullTextSearchSettingsModule DwcuKuGQRche0aj1a5oI() => FullTextSearchSettingsModule.dJTjE0GQSArhxB5W8CZo;

    internal static Guid YjA5obGQKxuyiUYSRXs5([In] object obj0) => Guid.Parse((string) obj0);
  }
}
