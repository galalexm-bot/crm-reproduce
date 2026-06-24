// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.Module
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Modules.Impl
{
  internal class Module : ModuleBase, ILicensedUnit, IActivationTokenContainer
  {
    private ModuleInfoMetadata info;
    private IModuleAssembly mainAssembly;
    internal static Module gayCFG3Fj3wI4OLp7lM;

    public Module(ModuleInfoMetadata info, IModuleAssembly mainAssembly)
    {
      Module.DGVSyx3ogKre39fkRYQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ModuleType = info.ModuleType;
            num = 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.mainAssembly = mainAssembly;
            num = 5;
            continue;
          case 4:
            goto label_12;
          case 5:
            this.Status = Module.JW1LfR3hoME1oLgDcaP((object) info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 10 : 4;
            continue;
          case 6:
            this.DisabledReason = ModuleDisabledReason.DisabledManually;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
            continue;
          case 7:
            goto label_8;
          case 8:
            this.info = info;
            num = 3;
            continue;
          case 9:
            if (mainAssembly != null)
            {
              num = 8;
              continue;
            }
            goto label_12;
          case 10:
            if (this.Status == ModuleStatus.Disabled)
            {
              num = 6;
              continue;
            }
            goto case 1;
          default:
            if (info != null)
            {
              num = 9;
              continue;
            }
            goto label_8;
        }
      }
label_3:
      return;
label_8:
      throw new ArgumentNullException((string) Module.hceJl33bwafrSuGeWuC(694673736 ^ -23604109 ^ -672120707));
label_12:
      throw new ArgumentNullException((string) Module.hceJl33bwafrSuGeWuC(-688192331 - 435440695 ^ -1123627732));
    }

    public override string Id => (string) Module.RKIAH33GtKNoJYnPDAG((object) this.info);

    public override Guid Uid => Module.Sq19Mx3EDurnXHI2S4C((object) this.info);

    public override string Title => (string) Module.REfv3A3fMj84WXhoOoo((object) this.info);

    public override string Description => (string) Module.DD6w8h3QwCHioEcoB65((object) this.info);

    public IModuleAssembly MainAssembly => this.mainAssembly;

    public override string Version
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.mainAssembly != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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
        return (string) Module.eFyCfw3CVjNArl8E03m((object) this.mainAssembly);
      }
    }

    public override string Author
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.mainAssembly != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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
        return (string) Module.IUlS8T3vyFpYuHibI6r((object) this.mainAssembly);
      }
    }

    public override string WebSite
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
              if (this.info != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
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
        return (string) Module.ftZ50o38aJuO0WlSUUB((object) this.info);
      }
    }

    public override string HtmlDescription
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.info == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return "";
label_5:
        return (string) Module.nFXWuq3Zf34JtV8hUd2((object) this.info);
      }
    }

    public override bool ServerModuleRequired
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.info != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return Module.m9WfV23u6bfKyMKNROJ((object) this.info);
label_5:
        return false;
      }
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
              if (this.MainLicensedAssembly != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return Guid.Empty;
label_5:
        return this.MainLicensedAssembly.RegistrationKeyMethodUid;
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
            if (this.MainLicensedAssembly == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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
      return (string) Module.TbEfsX3IqDFpN6qg8Vh((object) this.MainLicensedAssembly);
    }

    public void ApplyActivationKey(string key)
    {
      int num1 = 1;
      IEnumerator<ILicensedUnit> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.Units.OfType<ILicensedUnit>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_2;
        }
      }
label_14:
      return;
label_2:
      try
      {
label_5:
        if (Module.dKMMUr3Squ1BP6339W1((object) enumerator))
          goto label_7;
        else
          goto label_6;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_5;
          case 2:
            return;
          default:
            goto label_7;
        }
label_6:
        num2 = 2;
        goto label_4;
label_7:
        Module.rKBA323VFZM3n34RuKV((object) enumerator.Current, (object) key);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              default:
                Module.JnPD5V3iIPId2lSAxRw((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_16:;
      }
    }

    public void CompleteLicensingInitialize()
    {
      int num1 = 1;
      IEnumerator<ILicensedUnit> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.Units.OfType<ILicensedUnit>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_16;
          default:
            goto label_3;
        }
      }
label_16:
      return;
label_3:
      try
      {
label_8:
        if (Module.dKMMUr3Squ1BP6339W1((object) enumerator))
          goto label_6;
        else
          goto label_9;
label_5:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            break;
          default:
            goto label_8;
        }
label_6:
        Module.y8bbOY3RDBNpq8gBlET((object) enumerator.Current);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
        goto label_5;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
        else
          goto label_14;
label_12:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_14:
        Module.JnPD5V3iIPId2lSAxRw((object) enumerator);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        {
          num3 = 1;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    public ILicenseInfo GetLicenseInfo()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.MainLicensedAssembly != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (ILicenseInfo) null;
label_5:
      return (ILicenseInfo) Module.qcPowo3qQJq3TG1MrM8((object) this.MainLicensedAssembly);
    }

    public void UpdateLicenseInfo()
    {
      int num1 = 1;
      IEnumerator<ILicensedUnit> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.Units.OfType<ILicensedUnit>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_2;
        }
      }
label_14:
      return;
label_2:
      try
      {
label_5:
        if (Module.dKMMUr3Squ1BP6339W1((object) enumerator))
          goto label_7;
        else
          goto label_6;
label_4:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_5;
          case 2:
            goto label_7;
          default:
            return;
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
        goto label_4;
label_7:
        Module.cwckEI3KvrkQfuYKA98((object) enumerator.Current);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
        else
          goto label_15;
label_12:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_15:
        Module.JnPD5V3iIPId2lSAxRw((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        {
          num3 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    public byte[] GetActivationToken()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.MainLicensedAssembly != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (byte[]) null;
label_3:
      return (byte[]) Module.vtusj83XSBLBJ1OR3qn((object) this.MainLicensedAssembly);
    }

    private ILicensedUnit MainLicensedAssembly
    {
      get
      {
        int num = 1;
        ILicensedUnit licensedAssembly;
        while (true)
        {
          switch (num)
          {
            case 1:
              licensedAssembly = this.mainAssembly as ILicensedUnit;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              goto label_6;
            default:
              if (licensedAssembly != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 1;
                continue;
              }
              licensedAssembly = this.Assemblies.OfType<ILicensedUnit>().FirstOrDefault<ILicensedUnit>();
              num = 3;
              continue;
          }
        }
label_4:
        return licensedAssembly;
label_6:
        return licensedAssembly;
      }
    }

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num = 1;
      IActivationTokenContainer licensedAssembly;
      while (true)
      {
        switch (num)
        {
          case 1:
            licensedAssembly = this.MainLicensedAssembly as IActivationTokenContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (licensedAssembly == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (ActivationToken) null;
label_6:
      return licensedAssembly.GetActivationToken();
    }

    internal static void DGVSyx3ogKre39fkRYQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object hceJl33bwafrSuGeWuC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static ModuleStatus JW1LfR3hoME1oLgDcaP([In] object obj0) => ((ModuleInfoMetadata) obj0).DefaultStatus;

    internal static bool OMgal93Be9PoqXKPLfg() => Module.gayCFG3Fj3wI4OLp7lM == null;

    internal static Module uwinRy3Wi078HrwaLdk() => Module.gayCFG3Fj3wI4OLp7lM;

    internal static object RKIAH33GtKNoJYnPDAG([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static Guid Sq19Mx3EDurnXHI2S4C([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object REfv3A3fMj84WXhoOoo([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object DD6w8h3QwCHioEcoB65([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static object eFyCfw3CVjNArl8E03m([In] object obj0) => (object) ((IApplicationUnit) obj0).Version;

    internal static object IUlS8T3vyFpYuHibI6r([In] object obj0) => (object) ((IApplicationUnit) obj0).Author;

    internal static object ftZ50o38aJuO0WlSUUB([In] object obj0) => (object) ((ModuleInfoMetadata) obj0).WebSite;

    internal static object nFXWuq3Zf34JtV8hUd2([In] object obj0) => (object) ((ModuleInfoMetadata) obj0).HtmlDescription;

    internal static bool m9WfV23u6bfKyMKNROJ([In] object obj0) => ((ModuleInfoMetadata) obj0).ServerModuleRequired;

    internal static object TbEfsX3IqDFpN6qg8Vh([In] object obj0) => (object) ((ILicensedUnit) obj0).GetRegistrationKey();

    internal static void rKBA323VFZM3n34RuKV([In] object obj0, [In] object obj1) => ((ILicensedUnit) obj0).ApplyActivationKey((string) obj1);

    internal static bool dKMMUr3Squ1BP6339W1([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void JnPD5V3iIPId2lSAxRw([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void y8bbOY3RDBNpq8gBlET([In] object obj0) => ((ILicensedUnit) obj0).CompleteLicensingInitialize();

    internal static object qcPowo3qQJq3TG1MrM8([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static void cwckEI3KvrkQfuYKA98([In] object obj0) => ((ILicensedUnit) obj0).UpdateLicenseInfo();

    internal static object vtusj83XSBLBJ1OR3qn([In] object obj0) => (object) ((ILicensedUnit) obj0).GetActivationToken();
  }
}
