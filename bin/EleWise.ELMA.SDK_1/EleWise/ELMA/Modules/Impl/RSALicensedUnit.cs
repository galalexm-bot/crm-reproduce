// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.RSALicensedUnit
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Modules.Impl
{
  public class RSALicensedUnit : ILicensedUnit, IActivationTokenContainer
  {
    private RSALicense _impl;
    internal static RSALicensedUnit Oqo2H312pGEYmWRSCZy;

    public RSALicensedUnit(
      Guid moduleUid,
      string id,
      string version,
      IEnumerable<X509Certificate2> certificates,
      Func<DateTime?> getMainUnitExpiration)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._impl = new RSALicense(moduleUid, id, version, certificates, getMainUnitExpiration);
    }

    public Guid RegistrationKeyMethodUid => new Guid((string) RSALicensedUnit.LNqh2b11rPG4Ue9hd4l(979449278 ^ 979453834));

    public string GetRegistrationKey() => this._impl.GetRegistrationKey();

    public void ApplyActivationKey(string key)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RSALicensedUnit.WMtmMT1NT0t4vtaXfOG((object) this._impl, (object) key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void CompleteLicensingInitialize()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RSALicensedUnit.seu7P213AcS9W96JtpG((object) this._impl);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ILicenseInfo GetLicenseInfo()
    {
      int num = 1;
      ComponentLicenseInfo componentLicenseInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            componentLicenseInfo = (ComponentLicenseInfo) RSALicensedUnit.dF1vAq1pQLW8XVqxNOL((object) this._impl);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (componentLicenseInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return (ILicenseInfo) null;
label_5:
      LicenseInfo licenseInfo = new LicenseInfo((object) null);
      RSALicensedUnit.UxAaHN1D78RxhCKCrfq((object) licenseInfo, RSALicensedUnit.ViwrUI1aHWT4ohgPva5((object) componentLicenseInfo));
      RSALicensedUnit.MyjXud1wja0Xu0m6sRo((object) licenseInfo, this.ConvertStatus(RSALicensedUnit.E7W3wP1tmt7yaE8fsY7((object) componentLicenseInfo)));
      licenseInfo.TrialExpiration = componentLicenseInfo.TrialExpiration;
      return (ILicenseInfo) licenseInfo;
    }

    public void UpdateLicenseInfo()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RSALicensedUnit.Es7Zlu149xSTcJVkbTa((object) this._impl);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public byte[] GetActivationToken() => (byte[]) RSALicensedUnit.bsqLhU16CE7G2EPdoib((object) this._impl);

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num = 2;
      byte[] activationTokenV2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (activationTokenV2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            activationTokenV2 = this._impl.GetActivationTokenV2();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (ActivationToken) null;
label_6:
      return new ActivationToken()
      {
        Token = activationTokenV2
      };
    }

    private LicenseStatus ConvertStatus(ComponentLicenseStatus status)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (status != ComponentLicenseStatus.DateExpired)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (status != ComponentLicenseStatus.Activated)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
              continue;
            }
            goto label_7;
          case 3:
            goto label_4;
          default:
            if (status != ComponentLicenseStatus.NeedRestart)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 3;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return LicenseStatus.NotActivated;
label_5:
      return LicenseStatus.NeedRestart;
label_6:
      return LicenseStatus.DateExpired;
label_7:
      return LicenseStatus.Activated;
    }

    internal static object LNqh2b11rPG4Ue9hd4l(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool dFgKIU1e7LRQ2Hb9s07() => RSALicensedUnit.Oqo2H312pGEYmWRSCZy == null;

    internal static RSALicensedUnit rTkSNk1Phb0uZVARsak() => RSALicensedUnit.Oqo2H312pGEYmWRSCZy;

    internal static void WMtmMT1NT0t4vtaXfOG([In] object obj0, [In] object obj1) => ((RSALicense) obj0).ApplyActivationKey((string) obj1);

    internal static void seu7P213AcS9W96JtpG([In] object obj0) => ((RSALicense) obj0).CompleteLicensingInitialize();

    internal static object dF1vAq1pQLW8XVqxNOL([In] object obj0) => (object) ((RSALicense) obj0).GetLicenseInfo();

    internal static byte ViwrUI1aHWT4ohgPva5([In] object obj0) => ((ComponentLicenseInfo) obj0).LicenseType;

    internal static void UxAaHN1D78RxhCKCrfq([In] object obj0, byte value) => ((LicenseInfo) obj0).LicenseType = value;

    internal static ComponentLicenseStatus E7W3wP1tmt7yaE8fsY7([In] object obj0) => ((ComponentLicenseInfo) obj0).Status;

    internal static void MyjXud1wja0Xu0m6sRo([In] object obj0, LicenseStatus value) => ((LicenseInfo) obj0).Status = value;

    internal static void Es7Zlu149xSTcJVkbTa([In] object obj0) => ((RSALicense) obj0).UpdateLicenseInfo();

    internal static object bsqLhU16CE7G2EPdoib([In] object obj0) => (object) ((RSALicense) obj0).GetActivationToken();
  }
}
