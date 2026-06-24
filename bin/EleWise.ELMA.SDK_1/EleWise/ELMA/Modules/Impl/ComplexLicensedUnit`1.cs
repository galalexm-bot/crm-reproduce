// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.ComplexLicensedUnit`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Licensing;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Modules.Impl
{
  public abstract class ComplexLicensedUnit<TIntf> : 
    LicensedUnitBase,
    ILicensedUnit,
    IActivationTokenContainer
    where TIntf : ILicensedUnit
  {
    private TIntf e;
    private TIntf s;
    private TIntf o;
    private List<TIntf> all;
    internal static object iwyjrG19uqqwKlGun3B;

    public ComplexLicensedUnit(TIntf e, TIntf s, TIntf o)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.all = new List<TIntf>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.e = e;
      this.s = s;
      this.o = o;
      this.all.Add(e);
      this.all.Add(s);
      this.all.Add(o);
    }

    protected virtual bool ApplyKeysToAll => false;

    protected virtual TIntf ActiveUnit
    {
      get
      {
        if (string.IsNullOrEmpty(this.MainProviderType) || this.MainProviderType == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812053814))
          return this.e;
        return !(this.MainProviderType == z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289719098)) ? this.o : this.s;
      }
    }

    Guid ILicensedUnit.RegistrationKeyMethodUid
    {
      get
      {
        int num = 1;
        TIntf activeUnit;
        while (true)
        {
          switch (num)
          {
            case 1:
              activeUnit = this.ActiveUnit;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return activeUnit.RegistrationKeyMethodUid;
      }
    }

    string ILicensedUnit.GetRegistrationKey()
    {
      int num = 1;
      TIntf activeUnit;
      while (true)
      {
        switch (num)
        {
          case 1:
            activeUnit = this.ActiveUnit;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return activeUnit.GetRegistrationKey();
    }

    void ILicensedUnit.ApplyActivationKey(string key)
    {
      int num = 2;
      TIntf activeUnit;
      string key1;
      while (true)
      {
        switch (num)
        {
          case 1:
            key1 = key;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
            continue;
          case 3:
            activeUnit.ApplyActivationKey(key1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 6;
            continue;
          case 4:
            this.all.ForEach((Action<TIntf>) (a => a.ApplyActivationKey(key1)));
            num = 7;
            continue;
          case 5:
            activeUnit = this.ActiveUnit;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 3;
            continue;
          case 6:
            goto label_2;
          case 7:
            goto label_9;
          default:
            if (!this.ApplyKeysToAll)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 5 : 3;
              continue;
            }
            goto case 4;
        }
      }
label_2:
      return;
label_9:;
    }

    void ILicensedUnit.CompleteLicensingInitialize()
    {
      int num = 4;
      TIntf activeUnit;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_9;
          case 2:
            activeUnit.CompleteLicensingInitialize();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 3:
            List<TIntf> all = this.all;
            // ISSUE: reference to a compiler-generated field
            Action<TIntf> action1 = ComplexLicensedUnit<TIntf>.\u003C\u003Ec.\u003C\u003E9__9_0;
            Action<TIntf> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ComplexLicensedUnit<TIntf>.\u003C\u003Ec.\u003C\u003E9__9_0 = action2 = (Action<TIntf>) (a => a.CompleteLicensingInitialize());
            }
            else
              goto label_12;
label_11:
            all.ForEach(action2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
            continue;
label_12:
            action2 = action1;
            goto label_11;
          case 4:
            if (!this.ApplyKeysToAll)
            {
              activeUnit = this.ActiveUnit;
              num = 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 3;
            continue;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_9:
      return;
label_2:;
    }

    ILicenseInfo ILicensedUnit.GetLicenseInfo()
    {
      int num = 1;
      TIntf activeUnit;
      while (true)
      {
        switch (num)
        {
          case 1:
            activeUnit = this.ActiveUnit;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return activeUnit.GetLicenseInfo();
    }

    void ILicensedUnit.UpdateLicenseInfo()
    {
      int num = 3;
      TIntf activeUnit;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            activeUnit.UpdateLicenseInfo();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            List<TIntf> all = this.all;
            // ISSUE: reference to a compiler-generated field
            Action<TIntf> action1 = ComplexLicensedUnit<TIntf>.\u003C\u003Ec.\u003C\u003E9__11_0;
            Action<TIntf> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ComplexLicensedUnit<TIntf>.\u003C\u003Ec.\u003C\u003E9__11_0 = action2 = (Action<TIntf>) (a => a.UpdateLicenseInfo());
            }
            else
              goto label_12;
label_11:
            all.ForEach(action2);
            num = 4;
            continue;
label_12:
            action2 = action1;
            goto label_11;
          case 3:
            if (this.ApplyKeysToAll)
            {
              num = 2;
              continue;
            }
            activeUnit = this.ActiveUnit;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_2;
        }
      }
label_9:
      return;
label_5:
      return;
label_2:;
    }

    byte[] ILicensedUnit.GetActivationToken()
    {
      int num = 1;
      TIntf activeUnit;
      while (true)
      {
        switch (num)
        {
          case 1:
            activeUnit = this.ActiveUnit;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return activeUnit.GetActivationToken();
    }

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num = 1;
      IActivationTokenContainer activeUnit;
      while (true)
      {
        switch (num)
        {
          case 1:
            activeUnit = (object) this.ActiveUnit as IActivationTokenContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            if (activeUnit != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return (ActivationToken) null;
label_3:
      return activeUnit.GetActivationToken();
    }

    internal static bool ujO6NZ1dTrxgr6iFehK() => ComplexLicensedUnit<TIntf>.iwyjrG19uqqwKlGun3B == null;

    internal static object kKK6X71lOoxZfQ2Laf3() => ComplexLicensedUnit<TIntf>.iwyjrG19uqqwKlGun3B;
  }
}
