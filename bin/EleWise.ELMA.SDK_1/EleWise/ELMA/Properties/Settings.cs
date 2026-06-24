// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Properties.Settings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance;
    internal static Settings oGd28FvgVxbabqsguC6;

    public static Settings Default => Settings.defaultInstance;

    [DefaultSettingValue("http://localhost:7033/ServerInfo.asmx")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    public string EleWise_ELMA_SDK_ServerInfoReference_ServerInfo => (string) Settings.Q2yr0ivLcoqINU6OlxE((object) this, Settings.xuXCKqvYqoaZ430CATC(-2099751081 ^ -2099746087));

    public Settings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Settings()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            Settings.defaultInstance = (Settings) Settings.PX46iRvsQD0Lqsjv59y((object) new Settings());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated method
            Settings.JVlPRVvUbDYBsSMyYcE();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object xuXCKqvYqoaZ430CATC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Q2yr0ivLcoqINU6OlxE([In] object obj0, [In] object obj1) => ((SettingsBase) obj0)[(string) obj1];

    internal static bool EGXxO2v5rSfwev2Wt2P() => Settings.oGd28FvgVxbabqsguC6 == null;

    internal static Settings HmPWZOvjQlPbTvRMLOj() => Settings.oGd28FvgVxbabqsguC6;

    internal static void JVlPRVvUbDYBsSMyYcE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object PX46iRvsQD0Lqsjv59y([In] object obj0) => (object) SettingsBase.Synchronized((SettingsBase) obj0);
  }
}
