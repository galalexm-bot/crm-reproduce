// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.Types.PortletScriptType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts.Types
{
  public class PortletScriptType : FormScriptType
  {
    public const string UID_S = "{8F831BBC-B778-48F6-AA3D-251F135A4645}";
    public static readonly Guid UID;
    internal static PortletScriptType nfPB8qLRon3sB7s6Rqf;

    public override Guid Uid => PortletScriptType.UID;

    public override string Name => (string) PortletScriptType.tEaTs8LTIFCc5r2T8Nk(PortletScriptType.p0mUJhLX91ewmnoeAZL(381945751 ^ 1158627804 ^ 1405851331));

    protected override void SetMethodParameters(
      ScriptMethodDeclaration declaration,
      FormMetadata formMetadata,
      FormContextMetadata contextMetadata,
      FormTablePartMetadata tablePartMetadata,
      IDictionary<string, object> generationParams)
    {
      Contract.ArgumentNotNull((object) declaration, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477125962));
      Contract.ArgumentNotNull((object) formMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787438877));
      Contract.ArgumentNotNull((object) contextMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841399826));
      FormContextMetadata generationParam = (FormContextMetadata) generationParams[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178263434)];
      Contract.NotNull((object) generationParam, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501419391));
      if (tablePartMetadata != null)
        declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479477194), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979494024), (object) formMetadata.Name, (object) tablePartMetadata.Name, (object) generationParam.Name)));
      else
        declaration.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921247657), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70017146), (object) formMetadata.Name, (object) contextMetadata.Name, (object) generationParam.Name)));
    }

    public PortletScriptType()
    {
      PortletScriptType.cLSb29Lk0tvjmN5oKU3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PortletScriptType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PortletScriptType.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236124211));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object p0mUJhLX91ewmnoeAZL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object tEaTs8LTIFCc5r2T8Nk([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool PcdEs8LqEiC7GvgZ9G2() => PortletScriptType.nfPB8qLRon3sB7s6Rqf == null;

    internal static PortletScriptType TRbXm9LKvNdfn3xQ3eC() => PortletScriptType.nfPB8qLRon3sB7s6Rqf;

    internal static void cLSb29Lk0tvjmN5oKU3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public static class PortletParameters
    {
      public const string PersonalizationContextMetadata = "PersonalizationContextMetadata";
    }
  }
}
