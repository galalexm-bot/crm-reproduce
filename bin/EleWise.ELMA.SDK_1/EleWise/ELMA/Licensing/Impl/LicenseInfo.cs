// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Impl.LicenseInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Licensing.Impl
{
  public class LicenseInfo : ILicenseInfo, ITrialLicenseInfo
  {
    private object _owner;
    internal static LicenseInfo sXQ0xP7lxeLKU4m6e4w;

    public LicenseInfo(object owner)
    {
      LicenseInfo.wUSi6p75FBTBn9lxNIl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._owner = owner;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public LicenseStatus Status
    {
      get => this.\u003CStatus\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CStatus\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public string Description
    {
      get
      {
        int num = 1;
        LicenseStatus status;
        while (true)
        {
          switch (num)
          {
            case 1:
              status = this.Status;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return status.ToString();
      }
    }

    public DateTime? TrialExpiration { get; set; }

    public byte LicenseType
    {
      get => this.\u003CLicenseType\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLicenseType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    protected object Owner => this._owner;

    internal static void wUSi6p75FBTBn9lxNIl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Senwh97rimhQuAbyXZj() => LicenseInfo.sXQ0xP7lxeLKU4m6e4w == null;

    internal static LicenseInfo uNepAN7gl8GyTZpiHqP() => LicenseInfo.sXQ0xP7lxeLKU4m6e4w;
  }
}
