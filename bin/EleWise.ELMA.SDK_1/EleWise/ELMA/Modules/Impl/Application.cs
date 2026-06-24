// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.Application
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Licensing;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Modules.Impl
{
  internal class Application : 
    ModuleBase,
    IApplication,
    IModule,
    ICompositeApplicationUnit,
    IApplicationUnit,
    ILicensedUnit,
    IActivationTokenContainer
  {
    private ApplicationDescriptor descriptor;
    private IModule mainModule;
    private ILicensedUnit mainLicensedUnit;
    private List<IModule> systemModules;
    private static Application iiD7lQ1rlTYeHMTPOje;

    public Application(
      ApplicationDescriptor descriptor,
      Module mainModule,
      ILicensedUnit mainLicensedUnit)
    {
      Application.KyRm1p1j3mtcQkKd6VR();
      this.systemModules = new List<IModule>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_10;
          case 1:
            goto label_9;
          case 2:
            this.mainModule = (IModule) mainModule;
            num = 5;
            continue;
          case 3:
            if (descriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 7 : 8;
              continue;
            }
            goto label_12;
          case 4:
            this.systemModules.Add((IModule) mainModule);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 5:
            this.mainLicensedUnit = mainLicensedUnit;
            num = 7;
            continue;
          case 6:
            goto label_12;
          case 7:
            if (mainModule == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
              continue;
            }
            goto case 4;
          case 8:
            this.descriptor = descriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_10:
      return;
label_9:
      return;
label_2:
      return;
label_12:
      throw new ArgumentNullException((string) Application.jfiSNH1YIHcrOfO29U9(-2099751081 ^ -2099763811));
    }

    public override IEnumerable<IApplicationUnit> Units => base.Units.Union<IApplicationUnit>((IEnumerable<IApplicationUnit>) this.SystemModules);

    public override string Id => this.descriptor.Id;

    public override Guid Uid => Application.n5R4dU1LnsFjprRUInm((object) this.descriptor);

    public override string Title => this.descriptor.Title;

    public override string Description => (string) Application.aaHeDc1UJbITjNhJ7Ej((object) this.descriptor);

    public override string Version
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.mainModule != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return "";
label_5:
        return (string) Application.tSm1CO1so56JrMh6vaM((object) this.mainModule);
      }
    }

    public override string Author
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.mainModule != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return "";
label_5:
        return (string) Application.q9In0t1cOtDKGsDUTx7((object) this.mainModule);
      }
    }

    public override string WebSite
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.mainModule != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return "";
label_3:
        return (string) Application.fLjh2R1zikRCPuDqZ85((object) this.mainModule);
      }
    }

    public override string HtmlDescription => "";

    public override bool ServerModuleRequired => false;

    public IModule MainModule => this.mainModule;

    public ILicensedUnit MainLicensedUnit => this.mainLicensedUnit;

    public IEnumerable<IModule> SystemModules => (IEnumerable<IModule>) this.systemModules;

    public void AddSystemModule(IModule module)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.systemModules.Add(module);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            if (!this.systemModules.Contains(module))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    public Guid RegistrationKeyMethodUid
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.MainLicensedModule == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return Guid.Empty;
label_5:
        return Application.FDPvsxNFiu9oUoX8BSy((object) this.MainLicensedModule);
      }
    }

    public string GetRegistrationKey()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.MainLicensedModule == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) null;
label_3:
      return (string) Application.qQI2LiNBoUX10UVLwoo((object) this.MainLicensedModule);
    }

    public void ApplyActivationKey(string key)
    {
      int num1 = 3;
      IEnumerator<ILicensedUnit> enumerator;
      while (true)
      {
        int num2 = num1;
        ILicensedUnit sdkUnit;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_21;
            case 1:
              if (sdkUnit != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 4 : 1;
                continue;
              }
              goto label_24;
            case 2:
              IEnumerable<IModule> source = this.Units.OfType<IModule>();
              // ISSUE: reference to a compiler-generated field
              Func<IModule, bool> func = Application.\u003C\u003Ec.\u003C\u003E9__31_0;
              Func<IModule, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                Application.\u003C\u003Ec.\u003C\u003E9__31_0 = predicate = (Func<IModule, bool>) (m => Application.\u003C\u003Ec.HindwbfM7x4aDvrd28H7(Application.\u003C\u003Ec.VMYMiWfMAsoPvlk7h4oS((object) m), __ModuleInfo.UID));
              }
              else
                goto label_25;
label_23:
              sdkUnit = source.FirstOrDefault<IModule>(predicate) as ILicensedUnit;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
              continue;
label_25:
              predicate = func;
              goto label_23;
            case 3:
              num2 = 2;
              continue;
            case 4:
              Application.YGZJOFNWoKsPEkhyEDA((object) sdkUnit, (object) key);
              num2 = 5;
              continue;
            case 5:
              goto label_24;
            case 6:
              goto label_7;
            default:
              goto label_18;
          }
        }
label_24:
        enumerator = this.Units.OfType<ILicensedUnit>().Where<ILicensedUnit>((Func<ILicensedUnit, bool>) (u => u != sdkUnit)).GetEnumerator();
        num1 = 6;
      }
label_21:
      return;
label_18:
      return;
label_7:
      try
      {
label_9:
        if (Application.FbFET7NoenNN6QVbNtA((object) enumerator))
          goto label_11;
        else
          goto label_10;
label_8:
        int num3;
        switch (num3)
        {
          case 1:
            goto label_11;
          case 2:
            return;
          default:
            goto label_9;
        }
label_10:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 2;
        goto label_8;
label_11:
        Application.YGZJOFNWoKsPEkhyEDA((object) enumerator.Current, (object) key);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        {
          num3 = 0;
          goto label_8;
        }
        else
          goto label_8;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
        else
          goto label_17;
label_15:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_17:
        Application.mQkdgANbE3XijYi5w46((object) enumerator);
        num4 = 2;
        goto label_15;
      }
    }

    public void CompleteLicensingInitialize()
    {
      int num1 = 2;
      IEnumerator<ILicensedUnit> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_15;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.Units.OfType<ILicensedUnit>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_15:
      return;
label_10:
      return;
label_3:
      try
      {
label_8:
        if (Application.FbFET7NoenNN6QVbNtA((object) enumerator))
          goto label_6;
        else
          goto label_9;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_8;
        }
label_6:
        Application.cM9sHcNhGYZ2NvDi9Q7((object) enumerator.Current);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_9:
        num2 = 2;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_17;
              default:
                Application.mQkdgANbE3XijYi5w46((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_17:;
      }
    }

    public ILicenseInfo GetLicenseInfo()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.MainLicensedModule == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (ILicenseInfo) null;
label_5:
      return (ILicenseInfo) Application.Abug6BNGIUli0SdVdko((object) this.MainLicensedModule);
    }

    public void UpdateLicenseInfo()
    {
      int num1 = 2;
      IEnumerator<ILicensedUnit> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_4;
          case 2:
            enumerator = this.Units.OfType<ILicensedUnit>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_16:
      return;
label_11:
      return;
label_4:
      try
      {
label_9:
        if (Application.FbFET7NoenNN6QVbNtA((object) enumerator))
          goto label_7;
        else
          goto label_10;
label_5:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_9;
          case 2:
            break;
          default:
            return;
        }
label_7:
        enumerator.Current.UpdateLicenseInfo();
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_18;
              default:
                Application.mQkdgANbE3XijYi5w46((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_18:;
      }
    }

    public byte[] GetActivationToken()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.MainLicensedModule == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (byte[]) null;
label_3:
      return (byte[]) Application.lHElneNEWGN9KDPYFMJ((object) this.MainLicensedModule);
    }

    private ILicensedUnit MainLicensedModule => this.MainModule as ILicensedUnit;

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num = 2;
      IActivationTokenContainer mainLicensedModule;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (mainLicensedModule != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            mainLicensedModule = this.MainLicensedModule as IActivationTokenContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      return (ActivationToken) null;
label_4:
      return (ActivationToken) Application.yknP7XNf4gu2jDqhaeO((object) mainLicensedModule);
    }

    internal static void KyRm1p1j3mtcQkKd6VR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object jfiSNH1YIHcrOfO29U9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool litREW1gX9I5pYeoboZ() => Application.iiD7lQ1rlTYeHMTPOje == null;

    internal static Application CGZHf615GxsYwQXGBWN() => Application.iiD7lQ1rlTYeHMTPOje;

    internal static Guid n5R4dU1LnsFjprRUInm([In] object obj0) => ((ApplicationDescriptor) obj0).Uid;

    internal static object aaHeDc1UJbITjNhJ7Ej([In] object obj0) => (object) ((ApplicationDescriptor) obj0).Description;

    internal static object tSm1CO1so56JrMh6vaM([In] object obj0) => (object) ((IApplicationUnit) obj0).Version;

    internal static object q9In0t1cOtDKGsDUTx7([In] object obj0) => (object) ((IApplicationUnit) obj0).Author;

    internal static object fLjh2R1zikRCPuDqZ85([In] object obj0) => (object) ((IModule) obj0).WebSite;

    internal static Guid FDPvsxNFiu9oUoX8BSy([In] object obj0) => ((ILicensedUnit) obj0).RegistrationKeyMethodUid;

    internal static object qQI2LiNBoUX10UVLwoo([In] object obj0) => (object) ((ILicensedUnit) obj0).GetRegistrationKey();

    internal static void YGZJOFNWoKsPEkhyEDA([In] object obj0, [In] object obj1) => ((ILicensedUnit) obj0).ApplyActivationKey((string) obj1);

    internal static bool FbFET7NoenNN6QVbNtA([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void mQkdgANbE3XijYi5w46([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void cM9sHcNhGYZ2NvDi9Q7([In] object obj0) => ((ILicensedUnit) obj0).CompleteLicensingInitialize();

    internal static object Abug6BNGIUli0SdVdko([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static object lHElneNEWGN9KDPYFMJ([In] object obj0) => (object) ((ILicensedUnit) obj0).GetActivationToken();

    internal static object yknP7XNf4gu2jDqhaeO([In] object obj0) => (object) ((IActivationTokenContainer) obj0).GetActivationToken();
  }
}
