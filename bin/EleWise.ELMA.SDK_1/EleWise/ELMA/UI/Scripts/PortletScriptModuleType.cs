// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.PortletScriptModuleType
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
  public class PortletScriptModuleType : FormScriptModuleType<PortletScriptCodeGenerationParams>
  {
    public const string UID_S = "{A43A3F0D-63D6-4DE8-A8C5-58B1666185BA}";
    public static readonly Guid UID;
    internal static PortletScriptModuleType iBHXDKYlUQwCl3w2T6d;

    public override Guid Uid => PortletScriptModuleType.UID;

    public override string Name => (string) PortletScriptModuleType.Ekvm9VYjgshGccWIwch(PortletScriptModuleType.pw6wtpY5csV34QoVlv1(1461625753 ^ 1461612245));

    protected override string TemplateFileName => (string) PortletScriptModuleType.pw6wtpY5csV34QoVlv1(-342626196 - 1290888215 ^ -1633533661);

    protected override string GetSummary(PortletScriptCodeGenerationParams p)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            PortletScriptModuleType.jwdGXVYLjAYZQa9xVBT((object) p.Metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323069676));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            PortletScriptModuleType.SbCV1dYY92j2YsOtsQx((object) p, PortletScriptModuleType.pw6wtpY5csV34QoVlv1(1574260816 ^ 1574279816));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283431781), PortletScriptModuleType.puqanwYU3bqocslXN0H((object) p.Metadata));
    }

    public PortletScriptModuleType()
    {
      PortletScriptModuleType.e4SE4vYsqElT8RWjITg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PortletScriptModuleType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PortletScriptModuleType.UID = new Guid((string) PortletScriptModuleType.pw6wtpY5csV34QoVlv1(979449278 ^ 979499082));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            PortletScriptModuleType.e4SE4vYsqElT8RWjITg();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object pw6wtpY5csV34QoVlv1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Ekvm9VYjgshGccWIwch([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool jjlLqZYrf7wtLIup2Sm() => PortletScriptModuleType.iBHXDKYlUQwCl3w2T6d == null;

    internal static PortletScriptModuleType wEqkYcYgb8awgqCDPtc() => PortletScriptModuleType.iBHXDKYlUQwCl3w2T6d;

    internal static void SbCV1dYY92j2YsOtsQx([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void jwdGXVYLjAYZQa9xVBT([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object puqanwYU3bqocslXN0H([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void e4SE4vYsqElT8RWjITg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
