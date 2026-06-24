// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.LicensedModuleAssembly
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Modules.Impl
{
  internal class LicensedModuleAssembly : 
    ModuleAssembly,
    ILicensedModuleAssembly,
    IModuleAssembly,
    IApplicationUnit,
    ILicensedUnit,
    IActivationTokenContainer
  {
    private ILicensedUnit licenseUnit;
    internal static LicensedModuleAssembly SfrxEwNieoAagOPrA1I;

    public LicensedModuleAssembly(Assembly assembly, AssemblyLicenseUnitAttribute licenseUnitAttr)
    {
      LicensedModuleAssembly.jJLKojNKvW6cVBU0sGW();
      // ISSUE: explicit constructor call
      base.\u002Ector(assembly);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (licenseUnitAttr == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            this.licenseUnit = (ILicensedUnit) LicensedModuleAssembly.oTS4DcNkLObKmAhmxvY(LicensedModuleAssembly.iEB4HfNTSjrobeOtE8g((object) licenseUnitAttr));
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:
      throw new ArgumentNullException((string) LicensedModuleAssembly.UWka00NXrnq1qKUSVtd(--1360331293 ^ 1360359679));
    }

    /// <summary>Получить модуль лицензирования сборки</summary>
    public ILicensedUnit LicenseUnit => this.licenseUnit;

    public Guid RegistrationKeyMethodUid => LicensedModuleAssembly.bPFDj5NnqjC9bcqlevt((object) this.licenseUnit);

    public string GetRegistrationKey() => (string) LicensedModuleAssembly.n1NXtLNOGZ2GxZ8NIgw((object) this.licenseUnit);

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
            LicensedModuleAssembly.xB2QBoN2LGP5ELVGxR3((object) this.licenseUnit, (object) key);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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
            LicensedModuleAssembly.GwwdTXNelL73nacEybe((object) this.licenseUnit);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public ILicenseInfo GetLicenseInfo() => (ILicenseInfo) LicensedModuleAssembly.rKVV27NPkEnWbn03HC4((object) this.licenseUnit);

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
            this.licenseUnit.UpdateLicenseInfo();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public byte[] GetActivationToken() => (byte[]) LicensedModuleAssembly.CuOQhRN1ZIuAN1sDj0m((object) this.licenseUnit);

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num = 1;
      IActivationTokenContainer licenseUnit;
      while (true)
      {
        switch (num)
        {
          case 1:
            licenseUnit = this.licenseUnit as IActivationTokenContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (licenseUnit == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return (ActivationToken) null;
label_5:
      return (ActivationToken) LicensedModuleAssembly.hsyj70NNcjXFHJIOBVe((object) licenseUnit);
    }

    internal static void jJLKojNKvW6cVBU0sGW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object UWka00NXrnq1qKUSVtd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type iEB4HfNTSjrobeOtE8g([In] object obj0) => ((AssemblyLicenseUnitAttribute) obj0).LicenseUnitType;

    internal static object oTS4DcNkLObKmAhmxvY([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static bool Lmnn9cNROVFewgt2U95() => LicensedModuleAssembly.SfrxEwNieoAagOPrA1I == null;

    internal static LicensedModuleAssembly rY2R0cNqOwFfkn4usZh() => LicensedModuleAssembly.SfrxEwNieoAagOPrA1I;

    internal static Guid bPFDj5NnqjC9bcqlevt([In] object obj0) => ((ILicensedUnit) obj0).RegistrationKeyMethodUid;

    internal static object n1NXtLNOGZ2GxZ8NIgw([In] object obj0) => (object) ((ILicensedUnit) obj0).GetRegistrationKey();

    internal static void xB2QBoN2LGP5ELVGxR3([In] object obj0, [In] object obj1) => ((ILicensedUnit) obj0).ApplyActivationKey((string) obj1);

    internal static void GwwdTXNelL73nacEybe([In] object obj0) => ((ILicensedUnit) obj0).CompleteLicensingInitialize();

    internal static object rKVV27NPkEnWbn03HC4([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static object CuOQhRN1ZIuAN1sDj0m([In] object obj0) => (object) ((ILicensedUnit) obj0).GetActivationToken();

    internal static object hsyj70NNcjXFHJIOBVe([In] object obj0) => (object) ((IActivationTokenContainer) obj0).GetActivationToken();
  }
}
