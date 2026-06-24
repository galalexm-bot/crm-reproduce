// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.DiagnosticsSettingsModule
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

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Модуль настроек диагностики системы</summary>
  [Component(Order = 10)]
  public class DiagnosticsSettingsModule : GlobalSettingsModuleBase<DiagnosticsSettings>
  {
    public const string UID = "{9CE3451C-6402-41B5-8F10-9514DB61B89E}";
    public static readonly Guid Uid;
    private static DiagnosticsSettingsModule NDgVvXEWqo9AnbWjKX2s;

    public override Guid ModuleGuid => DiagnosticsSettingsModule.Uid;

    /// <summary>Название модуля</summary>
    public override string ModuleName => (string) DiagnosticsSettingsModule.RZUZG8EWkf8Pa1pLI0nh(DiagnosticsSettingsModule.VvOyWEEWTgQMMaYFFYCZ(1581325282 << 3 ^ -234031366));

    public override void SaveSettings()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DiagnosticsSettingsModule.dOivyhEWPoR4JBHQCGoi(DiagnosticsSettingsModule.zZ8EAREWnNd5SAF67vwp());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          case 2:
            DiagnosticsSettingsModule.HY4rGjEWOOHNmX9wpon3(DiagnosticsSettingsModule.zZ8EAREWnNd5SAF67vwp(), (object) this.Settings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 4;
            continue;
          case 3:
            if (DiagnosticsManager.Initialized)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            DiagnosticsSettingsModule.PODffFEW2nGjyZtixx4y((object) this);
            num = 5;
            continue;
          case 5:
            if (DiagnosticsSettingsModule.ACB3gbEWeJyFvQ8swEdw())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
              continue;
            }
            goto label_10;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_11:
      return;
label_10:;
    }

    public DiagnosticsSettingsModule()
    {
      DiagnosticsSettingsModule.biaWfuEW1IQBIFpQMokI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DiagnosticsSettingsModule()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DiagnosticsSettingsModule.biaWfuEW1IQBIFpQMokI();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DiagnosticsSettingsModule.Uid = new Guid((string) DiagnosticsSettingsModule.VvOyWEEWTgQMMaYFFYCZ(-35995181 ^ -35722297));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object VvOyWEEWTgQMMaYFFYCZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RZUZG8EWkf8Pa1pLI0nh([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool RfPfyVEWKQ6leSpemCyi() => DiagnosticsSettingsModule.NDgVvXEWqo9AnbWjKX2s == null;

    internal static DiagnosticsSettingsModule huXcymEWXMF9v7SeA527() => DiagnosticsSettingsModule.NDgVvXEWqo9AnbWjKX2s;

    internal static object zZ8EAREWnNd5SAF67vwp() => (object) DiagnosticsManager.Instance;

    internal static void HY4rGjEWOOHNmX9wpon3([In] object obj0, [In] object obj1) => ((DiagnosticsManager) obj0).ValidateSettings((DiagnosticsSettings) obj1);

    internal static void PODffFEW2nGjyZtixx4y([In] object obj0) => __nonvirtual (((GlobalSettingsModuleBase<DiagnosticsSettings>) obj0).SaveSettings());

    internal static bool ACB3gbEWeJyFvQ8swEdw() => DiagnosticsManager.Initialized;

    internal static void dOivyhEWPoR4JBHQCGoi([In] object obj0) => ((DiagnosticsManager) obj0).RefreshSettings();

    internal static void biaWfuEW1IQBIFpQMokI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
