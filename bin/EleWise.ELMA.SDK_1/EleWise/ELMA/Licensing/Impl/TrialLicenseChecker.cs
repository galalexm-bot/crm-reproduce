// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Impl.TrialLicenseChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Licensing.Impl
{
  [Component(Type = ComponentType.WebServer)]
  internal class TrialLicenseChecker : ISweepHandler
  {
    private DateTime? lastCheck;
    private static TrialLicenseChecker gnv2ej7aFh2P7aZnLBD;

    public void Execute()
    {
      int num1 = 5;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_32;
          case 3:
            goto label_27;
          case 4:
            if (!TrialLicenseChecker.UBs1D37HKHUrxAqa97e(TrialLicenseChecker.KySmc374dY1cYew429Q(TrialLicenseChecker.x6Ayjh7wWvNl6NeATRA(), this.lastCheck.Value), TrialLicenseChecker.aJkQiT76ZA6nuUlaBbA(1.0)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            }
            goto label_34;
          case 5:
            if (this.lastCheck.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 0;
              continue;
            }
            break;
        }
        this.lastCheck = new DateTime?(TrialLicenseChecker.x6Ayjh7wWvNl6NeATRA());
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
      }
label_32:
      return;
label_27:
      return;
label_3:
      try
      {
        int num2;
        if (!TrialLicenseChecker.uiaXAy7A4nauwgJE0ZW())
          num2 = 8;
        else
          goto label_11;
label_5:
        ILicensedUnit mainApplication;
        ILicenseInfo licenseInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              licenseInfo = mainApplication.GetLicenseInfo();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 1;
              continue;
            case 2:
              goto label_26;
            case 3:
              goto label_11;
            case 4:
              TrialLicenseChecker.wNKBLw7mGuTAr3SOA94((object) mainApplication);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 2;
              continue;
            case 5:
              if (licenseInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 7;
                continue;
              }
              goto case 6;
            case 6:
              if (licenseInfo.LicenseType != (byte) 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 7:
              goto label_24;
            case 8:
              goto label_8;
            case 9:
              if (mainApplication != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
                continue;
              }
              goto label_20;
            default:
              if (TrialLicenseChecker.hKnh1t70RcUSoyfWEiw((object) licenseInfo) == (byte) 2)
              {
                num2 = 4;
                continue;
              }
              goto label_19;
          }
        }
label_26:
        return;
label_24:
        return;
label_8:
        return;
label_20:
        return;
label_19:
        return;
label_11:
        mainApplication = ((IModuleManager) TrialLicenseChecker.wWLkfM7xXbOiRvN0w0J(TrialLicenseChecker.NdUK0k77b4kg5FPFOJs())).MainApplication as ILicensedUnit;
        num2 = 9;
        goto label_5;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_6;
            case 1:
              ((ILogger) TrialLicenseChecker.nYg8lK7yttlSAn6RWP9()).Warn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317763126), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_6:
        return;
label_2:
        return;
      }
label_34:;
    }

    public TrialLicenseChecker()
    {
      TrialLicenseChecker.pJxSPN7M88ch9RZ2EHY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static DateTime x6Ayjh7wWvNl6NeATRA() => DateTime.Now;

    internal static TimeSpan KySmc374dY1cYew429Q([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static TimeSpan aJkQiT76ZA6nuUlaBbA([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static bool UBs1D37HKHUrxAqa97e([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 < obj1;

    internal static bool uiaXAy7A4nauwgJE0ZW() => ComponentManager.Initialized;

    internal static object NdUK0k77b4kg5FPFOJs() => (object) ComponentManager.Current;

    internal static object wWLkfM7xXbOiRvN0w0J([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static byte hKnh1t70RcUSoyfWEiw([In] object obj0) => ((ILicenseInfo) obj0).LicenseType;

    internal static void wNKBLw7mGuTAr3SOA94([In] object obj0) => ((ILicensedUnit) obj0).UpdateLicenseInfo();

    internal static object nYg8lK7yttlSAn6RWP9() => (object) Logger.Log;

    internal static bool JpNJGl7DHOZhcXjVyPX() => TrialLicenseChecker.gnv2ej7aFh2P7aZnLBD == null;

    internal static TrialLicenseChecker yPi2EL7tnPho8CmL3ym() => TrialLicenseChecker.gnv2ej7aFh2P7aZnLBD;

    internal static void pJxSPN7M88ch9RZ2EHY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
