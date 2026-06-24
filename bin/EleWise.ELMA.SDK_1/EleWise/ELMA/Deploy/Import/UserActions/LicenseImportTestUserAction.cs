// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.UserActions.LicenseImportTestUserAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.UserActions
{
  [Component]
  public class LicenseImportTestUserAction : IImportTestUserAction
  {
    public static Guid UID;
    internal static LicenseImportTestUserAction Tw4IPkEy8GctuQHixtSN;

    public Guid ActionUid => LicenseImportTestUserAction.UID;

    public string Name => (string) LicenseImportTestUserAction.rTMTJ9EyV79VuwvImhWy(LicenseImportTestUserAction.DUrgrfEyIQY2WPILfsZE(-87337865 ^ -87033357));

    public string Description => EleWise.ELMA.SR.T((string) LicenseImportTestUserAction.DUrgrfEyIQY2WPILfsZE(~-397266137 ^ 396976492));

    public LicenseImportTestUserAction()
    {
      LicenseImportTestUserAction.wT2SjYEySEVtyyVuUFG6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static LicenseImportTestUserAction()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            LicenseImportTestUserAction.wT2SjYEySEVtyyVuUFG6();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            LicenseImportTestUserAction.UID = new Guid((string) LicenseImportTestUserAction.DUrgrfEyIQY2WPILfsZE(1505778440 - 1981636111 ^ -475639551));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object DUrgrfEyIQY2WPILfsZE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rTMTJ9EyV79VuwvImhWy([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool hs3ReHEyZtDfYcmIOeD0() => LicenseImportTestUserAction.Tw4IPkEy8GctuQHixtSN == null;

    internal static LicenseImportTestUserAction cr0C8nEyuxRb0xKh102s() => LicenseImportTestUserAction.Tw4IPkEy8GctuQHixtSN;

    internal static void wT2SjYEySEVtyyVuUFG6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
