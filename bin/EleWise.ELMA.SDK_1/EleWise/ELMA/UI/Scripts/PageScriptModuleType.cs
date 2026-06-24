// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.PageScriptModuleType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts
{
  public class PageScriptModuleType : FormScriptModuleType<PageScriptCodeGenerationParams>
  {
    public const string UID_S = "{C8A77AC7-5AB2-4E58-8FA3-2C93C40C8E34}";
    public static readonly Guid UID;
    internal static PageScriptModuleType u26YPTYAAinVUT5OkYR;

    public override Guid Uid => PageScriptModuleType.UID;

    public override string Name => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882172616));

    protected override string TemplateFileName => (string) PageScriptModuleType.yms7H9Y0pGFbXoJkBkn(-1822890472 ^ -1822938468);

    protected override string GetSummary(PageScriptCodeGenerationParams p)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            PageScriptModuleType.yv7s0KYycgTPW0XSqNl((object) p.Metadata, PageScriptModuleType.yms7H9Y0pGFbXoJkBkn(1218962250 ^ 1218914708));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            PageScriptModuleType.QNIDU0Ymy1GJPsjIgty((object) p, PageScriptModuleType.yms7H9Y0pGFbXoJkBkn(1021410165 ^ 1021424045));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return EleWise.ELMA.SR.T((string) PageScriptModuleType.yms7H9Y0pGFbXoJkBkn(~210725948 ^ -210739451), PageScriptModuleType.XKX1qBYM8WmDYj3HM69((object) p.Metadata));
    }

    public PageScriptModuleType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PageScriptModuleType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PageScriptModuleType.UID = new Guid((string) PageScriptModuleType.yms7H9Y0pGFbXoJkBkn(-1598106783 - -968262081 ^ -629827106));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool UPhhd0Y7hMmQlPCnrMI() => PageScriptModuleType.u26YPTYAAinVUT5OkYR == null;

    internal static PageScriptModuleType rCbUNnYxcweQSDweYyF() => PageScriptModuleType.u26YPTYAAinVUT5OkYR;

    internal static object yms7H9Y0pGFbXoJkBkn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void QNIDU0Ymy1GJPsjIgty([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void yv7s0KYycgTPW0XSqNl([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object XKX1qBYM8WmDYj3HM69([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;
  }
}
